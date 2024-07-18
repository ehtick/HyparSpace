using Elements;
using Elements.Geometry;
using System.Collections.Generic;
using Elements.Components;
using System.Linq;
using System.IO;
using Newtonsoft.Json;
using System;
using Elements.Spatial;
using LayoutFunctionCommon;

namespace MeetingRoomLayout
{

    public static class MeetingRoomLayout
    {
        private class MeetingLayoutGeneration : LayoutGeneration<LevelElements, LevelVolume, SpaceBoundary, CirculationSegment>
        {
            private Dictionary<string, RoomTally> seatsTable = new();

            protected override SeatsCount CountSeats(LayoutInstantiated layout)
            {
                int seatsCount = 0;
                if (layout != null)
                {
                    if (configInfos.TryGetValue(layout.ConfigName, out var configInfo))
                    {
                        seatsCount = configInfo.capacity;
                    }

                    if (seatsTable.ContainsKey(layout.ConfigName))
                    {
                        seatsTable[layout.ConfigName].SeatsCount += seatsCount;
                    }
                    else
                    {
                        seatsTable[layout.ConfigName] = new RoomTally(layout.ConfigName, seatsCount);
                    }
                }
                return new SeatsCount(seatsCount, 0, 0, 0);
            }

            public override LayoutGenerationResult StandardLayoutOnAllLevels(string programTypeName, Dictionary<string, Model> inputModels, dynamic overrides, bool createWalls, SpaceConfiguration configs)
            {
                seatsTable = new Dictionary<string, RoomTally>();

                var result = base.StandardLayoutOnAllLevels(programTypeName, inputModels, (object)overrides, createWalls, configs);
                result.OutputModel.AddElements(seatsTable.Select(kvp => kvp.Value).OrderByDescending(a => a.SeatsCount));
                return result;
            }

            protected override IEnumerable<KeyValuePair<string, ContentConfiguration>> OrderConfigs(Dictionary<string, ContentConfiguration> configs)
            {
                return configs.OrderBy(i =>
                {
                    if (!configInfos.ContainsKey(i.Key))
                    {
                        return int.MaxValue;
                    }
                    return configInfos[i.Key].orderIndex;
                });
            }
        }

        /// <summary>
        /// The MeetingRoomLayout function.
        /// </summary>
        /// <param name="model">The input model.</param>
        /// <param name="input">The arguments to the execution.</param>
        /// <returns>A MeetingRoomLayoutOutputs instance containing computed results and the model with any new elements.</returns>
        public static MeetingRoomLayoutOutputs Execute(Dictionary<string, Model> inputModels, MeetingRoomLayoutInputs input)
        {
            Elements.Serialization.glTF.GltfExtensions.UseReferencedContentExtension = true;
            var layoutGeneration = new MeetingLayoutGeneration();

            string configJsonPath = Path.Combine(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location), "./ConferenceRoomConfigurations.json");
            SpaceConfiguration configs = ContentManagement.GetSpaceConfiguration<ProgramRequirement>(inputModels, configJsonPath, "Meeting Room");

            var result = layoutGeneration.StandardLayoutOnAllLevels("Meeting Room", inputModels, input.Overrides, input.CreateWalls, configs);
            var output = new MeetingRoomLayoutOutputs
            {
                Model = result.OutputModel,
                TotalSeatCount = result.SeatsCount
            };
            return output;
        }

        private static readonly Dictionary<string, (int capacity, int orderIndex)> configInfos = new()
        {
            {"22P", (22, 1)},
            {"20P", (20, 2)},
            {"14P", (14, 3)},
            {"13P", (13, 4)},
            {"8P", (8, 5)},
            {"6P-A", (6, 6)},
            {"6P-B", (6, 7)},
            {"4P-A", (4, 8)},
            {"4P-B", (4, 9)}
        };
    }

}