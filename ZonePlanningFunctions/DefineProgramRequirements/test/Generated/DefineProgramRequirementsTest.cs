
// This code was generated by Hypar.
// Edits to this code will be overwritten the next time you run 'hypar test generate'.
// DO NOT EDIT THIS FILE.

using Elements;
using Xunit;
using System.IO;
using System.Collections.Generic;
using Elements.Serialization.glTF;

namespace DefineProgramRequirements
{
    public class DefineProgramRequirementsTest
    {
        [Fact]
        public void TestExecute()
        {
            var input = GetInput();

            var modelDependencies = new Dictionary<string, Model> { 
            };

            var result = DefineProgramRequirements.Execute(modelDependencies, input);
            result.Model.ToGlTF("../../../Generated/DefineProgramRequirementsTest/results/DefineProgramRequirementsTest.gltf", false);
            result.Model.ToGlTF("../../../Generated/DefineProgramRequirementsTest/results/DefineProgramRequirementsTest.glb");
            File.WriteAllText("../../../Generated/DefineProgramRequirementsTest/results/DefineProgramRequirementsTest.json", result.Model.ToJson());
        }

        public DefineProgramRequirementsInputs GetInput()
        {
            var inputText = @"
            {
  ""Program Requirements"": [
    {
      ""Program Name"": ""Open Office"",
      ""Area per Space"": 11200,
      ""Color"": {
        ""Red"": 0.6784313725490196,
        ""Alpha"": 1,
        ""Blue"": 0.9019607843137255,
        ""Green"": 0.8470588235294118
      },
      ""Space Count"": 1,
      ""Id"": ""90ba1244-6e9a-498e-8782-29ac70433dba"",
      ""Hypar Space Type"": ""Open Office"",
      ""discriminator"": ""Elements.ProgramRequirement""
    },
    {
      ""Program Name"": ""Private Office"",
      ""Area per Space"": 140,
      ""Color"": {
        ""Red"": 0.5019607843137255,
        ""Alpha"": 1,
        ""Blue"": 0.5019607843137255,
        ""Green"": 0
      },
      ""Space Count"": 16,
      ""Id"": ""48f202f7-f1e7-485c-a6de-c50b65bf71c9"",
      ""Hypar Space Type"": ""Private Office"",
      ""discriminator"": ""Elements.ProgramRequirement""
    },
    {
      ""Program Name"": ""Phone Booth"",
      ""Area per Space"": 150,
      ""Color"": {
        ""Red"": 0,
        ""Alpha"": 1,
        ""Blue"": 0,
        ""Green"": 0.5019607843137255
      },
      ""Space Count"": 5,
      ""Id"": ""84beb75d-52be-49bd-8e4a-5ca60eb3cddc"",
      ""Hypar Space Type"": ""Phone Booth"",
      ""discriminator"": ""Elements.ProgramRequirement""
    },
    {
      ""Program Name"": ""Meeting Rm Lg"",
      ""Area per Space"": 600,
      ""Color"": {
        ""Red"": 1,
        ""Alpha"": 1,
        ""Blue"": 0.796078431372549,
        ""Green"": 0.7529411764705882
      },
      ""Space Count"": 1,
      ""Id"": ""fa0b6e5b-f46e-4cda-ace3-0eb00fbeeff7"",
      ""Hypar Space Type"": ""Meeting Room"",
      ""discriminator"": ""Elements.ProgramRequirement""
    },
    {
      ""Program Name"": ""Meeting Rm Md"",
      ""Area per Space"": 350,
      ""Color"": {
        ""Red"": 1,
        ""Alpha"": 1,
        ""Blue"": 0.796078431372549,
        ""Green"": 0.7529411764705882
      },
      ""Space Count"": 5,
      ""Id"": ""5de71893-b16f-4fad-93a3-1463c536d0c1"",
      ""Hypar Space Type"": ""Meeting Room"",
      ""discriminator"": ""Elements.ProgramRequirement""
    },
    {
      ""Program Name"": ""Meeting Rm Sm"",
      ""Area per Space"": 250,
      ""Color"": {
        ""Red"": 1,
        ""Alpha"": 1,
        ""Blue"": 0.796078431372549,
        ""Green"": 0.7529411764705882
      },
      ""Space Count"": 2,
      ""Id"": ""f5e6265f-a43d-44ec-9fa5-99e97db1a3ca"",
      ""Hypar Space Type"": ""Meeting Room"",
      ""discriminator"": ""Elements.ProgramRequirement""
    },
    {
      ""Program Name"": ""Circulation"",
      ""Area per Space"": 4600,
      ""Color"": {
        ""Red"": 1,
        ""Alpha"": 1,
        ""Blue"": 1,
        ""Green"": 1
      },
      ""Space Count"": 1,
      ""Id"": ""4cbb4985-ac73-47d8-9720-955043b94a3b"",
      ""Hypar Space Type"": ""Circulation"",
      ""discriminator"": ""Elements.ProgramRequirement""
    },
    {
      ""Program Name"": ""Open Collaboration Lg"",
      ""Area per Space"": 700,
      ""Color"": {
        ""Red"": 1,
        ""Alpha"": 1,
        ""Blue"": 0,
        ""Green"": 1
      },
      ""Space Count"": 1,
      ""Id"": ""77b0a1cd-5bc0-4fe2-b14d-7fa96538e16f"",
      ""Hypar Space Type"": ""Meeting Room"",
      ""discriminator"": ""Elements.ProgramRequirement""
    },
    {
      ""Program Name"": ""Open Collaboration Sm"",
      ""Area per Space"": 300,
      ""Color"": {
        ""Red"": 1,
        ""Alpha"": 1,
        ""Blue"": 0,
        ""Green"": 1
      },
      ""Space Count"": 2,
      ""Id"": ""8294b593-7e06-41c7-8f4a-3c12b740c968"",
      ""Hypar Space Type"": ""Lounge"",
      ""discriminator"": ""Elements.ProgramRequirement""
    },
    {
      ""Program Name"": ""Service"",
      ""Area per Space"": 250,
      ""Color"": {
        ""Red"": 0.5019607843137255,
        ""Alpha"": 1,
        ""Blue"": 0.5019607843137255,
        ""Green"": 0.5019607843137255
      },
      ""Space Count"": 1,
      ""Id"": ""95a458ed-9ce7-4e43-83b6-0ac36a0dc02e"",
      ""Hypar Space Type"": ""Service"",
      ""discriminator"": ""Elements.ProgramRequirement""
    },
    {
      ""Program Name"": ""Common Area"",
      ""Area per Space"": 350,
      ""Color"": {
        ""Red"": 1,
        ""Alpha"": 1,
        ""Blue"": 1,
        ""Green"": 1
      },
      ""Space Count"": 1,
      ""Id"": ""215f10ae-82ef-4654-83ae-dd866d845d3a"",
      ""Hypar Space Type"": ""Lounge"",
      ""discriminator"": ""Elements.ProgramRequirement""
    },
    {
      ""Program Name"": ""Reception"",
      ""Area per Space"": 230,
      ""Color"": {
        ""Red"": 1,
        ""Alpha"": 1,
        ""Blue"": 1,
        ""Green"": 1
      },
      ""Space Count"": 1,
      ""Id"": ""aa4c0df8-7466-485a-bd6d-7685dcfc37d2"",
      ""Hypar Space Type"": ""Reception"",
      ""discriminator"": ""Elements.ProgramRequirement""
    },
    {
      ""Program Name"": ""Kitchen"",
      ""Area per Space"": 625,
      ""Color"": {
        ""Red"": 1,
        ""Alpha"": 1,
        ""Blue"": 1,
        ""Green"": 1
      },
      ""Space Count"": 1,
      ""Id"": ""c59877f3-4101-4cb8-9860-b430bb230e5e"",
      ""Hypar Space Type"": ""Pantry"",
      ""discriminator"": ""Elements.ProgramRequirement""
    }
  ],
  ""model_input_keys"": {}
}
            ";
            return Newtonsoft.Json.JsonConvert.DeserializeObject<DefineProgramRequirementsInputs>(inputText);
        }
    }
}