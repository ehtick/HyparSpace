//----------------------
// <auto-generated>
//     Generated using the NJsonSchema v10.1.21.0 (Newtonsoft.Json v12.0.0.0) (http://NJsonSchema.org)
// </auto-generated>
//----------------------
using Elements;
using Elements.GeoJSON;
using Elements.Geometry;
using Elements.Geometry.Solids;
using Elements.Spatial;
using Elements.Validators;
using Elements.Serialization.JSON;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using Line = Elements.Geometry.Line;
using Polygon = Elements.Geometry.Polygon;

namespace Elements
{
    #pragma warning disable // Disable all warnings

    /// <summary>Fill out your program requirements. Use "Hypar Space Type" to dictate which function should be used to lay out your space.</summary>
    [JsonConverter(typeof(Elements.Serialization.JSON.JsonInheritanceConverter), "discriminator")]
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.21.0 (Newtonsoft.Json v12.0.0.0)")]
    public partial class ProgramRequirement : Element
    {
        [JsonConstructor]
        public ProgramRequirement(string @programGroup, string @programName, Color @color, double @areaPerSpace, int @spaceCount, double? @width, double? @depth, string @hyparSpaceType, ProgramRequirementCountType @countType, double @totalArea, System.Guid @id = default, string @name = null)
            : base(id, name)
        {
            this.ProgramGroup = @programGroup;
            this.ProgramName = @programName;
            this.Color = @color;
            this.AreaPerSpace = @areaPerSpace;
            this.SpaceCount = @spaceCount;
            this.Width = @width;
            this.Depth = @depth;
            this.HyparSpaceType = @hyparSpaceType;
            this.CountType = @countType;
            this.TotalArea = @totalArea;
            }
        
        // Empty constructor
        public ProgramRequirement()
            : base()
        {
        }
    
        /// <summary>What group does this program belong to?</summary>
        [JsonProperty("Program Group", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ProgramGroup { get; set; }
    
        /// <summary>What display name should be used for this program type?</summary>
        [JsonProperty("Program Name", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string ProgramName { get; set; }
    
        /// <summary>What color should be used to display this space type?</summary>
        [JsonProperty("Color", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Color Color { get; set; }
    
        /// <summary>How much area should be allocated for this space?</summary>
        [JsonProperty("Area per Space", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double AreaPerSpace { get; set; }
    
        /// <summary>How many of this space type are required? Leave at 1 for spaces measured in aggregate, like circulation.</summary>
        [JsonProperty("Space Count", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int SpaceCount { get; set; } = 1;
    
        /// <summary>The width of this space (typically the longer dimension — along the side from which the space is accessed, like a corridor.)</summary>
        [JsonProperty("Width", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Width { get; set; }
    
        /// <summary>The depth of this space (typically the shorter dimension — perpendicular to the side from which the space is accessed, like a corridor.)</summary>
        [JsonProperty("Depth", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Depth { get; set; }
    
        /// <summary>What program type best matches this one?</summary>
        [JsonProperty("Hypar Space Type", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string HyparSpaceType { get; set; } = "unspecified";
    
        /// <summary>How should this requirement be counted? 
        /// 
        /// Use "Item" for individual spaces (e.g. 3 conference rooms),
        /// "Area Total" for spaces where you only care about the total (e.g. 1000 SF of circulation), and 
        /// "Unit" where you want total area divided by a "unit" size (e.g. this space supports 400 people at 120 SF / person)</summary>
        [JsonProperty("Count Type", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ProgramRequirementCountType CountType { get; set; } = Elements.ProgramRequirementCountType.Item;
    
        /// <summary>The Area per Space times the Space Count</summary>
        [JsonProperty("Total Area", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double TotalArea { get; set; }
    
    
    }
}