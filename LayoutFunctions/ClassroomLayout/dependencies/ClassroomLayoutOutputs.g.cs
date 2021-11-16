// This code was generated by Hypar.
// Edits to this code will be overwritten the next time you run 'hypar init'.
// DO NOT EDIT THIS FILE.

using Elements;
using Elements.GeoJSON;
using Elements.Geometry;
using Hypar.Functions;
using Hypar.Functions.Execution;
using Hypar.Functions.Execution.AWS;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Collections.Generic;

namespace ClassroomLayout
{
    public class ClassroomLayoutOutputs: ResultsBase
    {
		/// <summary>
		/// Total count of seats
		/// </summary>
		[JsonProperty("Total count of desk seats")]
		public double TotalCountOfDeskSeats {get; set;}



        /// <summary>
        /// Construct a ClassroomLayoutOutputs with default inputs.
        /// This should be used for testing only.
        /// </summary>
        public ClassroomLayoutOutputs() : base()
        {

        }


        /// <summary>
        /// Construct a ClassroomLayoutOutputs specifying all inputs.
        /// </summary>
        /// <returns></returns>
        [JsonConstructor]
        public ClassroomLayoutOutputs(double totalCountOfDeskSeats): base()
        {
			this.TotalCountOfDeskSeats = totalCountOfDeskSeats;

		}

		public override string ToString()
		{
			var json = JsonConvert.SerializeObject(this);
			return json;
		}
	}
}