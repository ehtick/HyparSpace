using System;
using DefineProgramRequirements;
using Newtonsoft.Json;

namespace Elements
{
    public partial class ProgramRequirement : Element
    {
        [JsonProperty("Qualified Program Name")]
        public string QualifiedProgramName => String.IsNullOrEmpty(this.ProgramGroup) ? this.ProgramName : $"{this.ProgramGroup} - {this.ProgramName}";

        [JsonProperty("Program Display Name")]
        public string ProgramDisplayName { get; set; }

        public bool Enclosed { get; set; }
        public ProfileConstraint Dimensions { get; internal set; }

        [JsonProperty("Default Wall Type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ProgramRequirementsDefaultWallType? DefaultWallType { get; internal set; }

        [JsonProperty("Layout Type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public InputFolder LayoutType { get; set; }

        // this is just a front-end thing we need to make sure persists from the inputs
        [JsonProperty("isSpaceType")]
        public bool? IsSpaceType { get; set; }
    }
}