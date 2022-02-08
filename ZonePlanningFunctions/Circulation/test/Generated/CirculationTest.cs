
// This code was generated by Hypar.
// Edits to this code will be overwritten the next time you run 'hypar test generate'.
// DO NOT EDIT THIS FILE.

using Elements;
using Xunit;
using System.IO;
using System.Collections.Generic;
using Elements.Serialization.glTF;

namespace Circulation
{
    public class CirculationTest
    {
        [Fact]
        public void TestExecute()
        {
            var input = GetInput();

            var modelDependencies = new Dictionary<string, Model> { 
                {"Levels", Model.FromJson(File.ReadAllText(@"/Users/andrewheumann/Dev/HyparSpace/ZonePlanningFunctions/Circulation/test/Generated/CirculationTest/model_dependencies/Levels/bbcb2c96-8ad7-420c-b623-4767e053c707.json")) }, 
                {"Program Requirements", Model.FromJson(File.ReadAllText(@"/Users/andrewheumann/Dev/HyparSpace/ZonePlanningFunctions/Circulation/test/Generated/CirculationTest/model_dependencies/Program Requirements/d4760f77-d0f9-4b8e-91b0-b8247d1a0273.json")) }, 
                {"Floors", Model.FromJson(File.ReadAllText(@"/Users/andrewheumann/Dev/HyparSpace/ZonePlanningFunctions/Circulation/test/Generated/CirculationTest/model_dependencies/Floors/6f0cbc73-46dc-4fc7-af00-49727a712a80.json")) }, 
                {"Core", Model.FromJson(File.ReadAllText(@"/Users/andrewheumann/Dev/HyparSpace/ZonePlanningFunctions/Circulation/test/Generated/CirculationTest/model_dependencies/Core/6f0cbc73-46dc-4fc7-af00-49727a712a80.json")) }, 
            };

            var result = Circulation.Execute(modelDependencies, input);
            result.Model.ToGlTF("../../../Generated/CirculationTest/results/CirculationTest.gltf", false);
            result.Model.ToGlTF("../../../Generated/CirculationTest/results/CirculationTest.glb");
            File.WriteAllText("../../../Generated/CirculationTest/results/CirculationTest.json", result.Model.ToJson());
        }

        public CirculationInputs GetInput()
        {
            var json = File.ReadAllText("../../../Generated/CirculationTest/inputs.json");
            return Newtonsoft.Json.JsonConvert.DeserializeObject<CirculationInputs>(json);
        }
    }
}