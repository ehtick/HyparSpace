
// This code was generated by Hypar.
// Edits to this code will be overwritten the next time you run 'hypar test generate'.
// DO NOT EDIT THIS FILE.

using Elements;
using Xunit;
using System;
using System.IO;
using System.Collections.Generic;
using Elements.Serialization.glTF;

namespace Circulation
{
    public class MultiFloorEditingAutoCreated
    {
        [Fact]
        public void TestExecute()
        {
            var input = GetInput();

            var modelDependencies = new Dictionary<string, Model> { 
                {"Levels", Model.FromJson(File.ReadAllText(@"/Users/andrewheumann/Dev/HyparSpace/ZonePlanningFunctions/Circulation/test/Generated/MultiFloorEditingAutoCreated/model_dependencies/Levels/6964f543-89fc-49db-8e9e-77bbe7c78be5.json")) }, 
                {"Conceptual Mass", Model.FromJson(File.ReadAllText(@"/Users/andrewheumann/Dev/HyparSpace/ZonePlanningFunctions/Circulation/test/Generated/MultiFloorEditingAutoCreated/model_dependencies/Conceptual Mass/0e9391fe-10a2-47b5-b0b4-5fcae7df712a.json")) }, 
            };

            var result = Circulation.Execute(modelDependencies, input);
            result.Model.ToGlTF("../../../Generated/MultiFloorEditingAutoCreated/results/MultiFloorEditingAutoCreated.gltf", false);
            result.Model.ToGlTF("../../../Generated/MultiFloorEditingAutoCreated/results/MultiFloorEditingAutoCreated.glb");
            File.WriteAllText("../../../Generated/MultiFloorEditingAutoCreated/results/MultiFloorEditingAutoCreated.json", result.Model.ToJson());

        }

        public CirculationInputs GetInput()
        {
            var json = File.ReadAllText("../../../Generated/MultiFloorEditingAutoCreated/inputs.json");
            return Newtonsoft.Json.JsonConvert.DeserializeObject<CirculationInputs>(json);
        }
    }
}