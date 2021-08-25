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

namespace FloorsBySketch
{
    public class FloorsBySketchOutputs: ResultsBase
    {
		/// <summary>
		/// The total floor area
		/// </summary>
		[JsonProperty("Area")]
		public double Area {get;}



        /// <summary>
        /// Construct a FloorsBySketchOutputs with default inputs.
        /// This should be used for testing only.
        /// </summary>
        public FloorsBySketchOutputs() : base()
        {

        }


        /// <summary>
        /// Construct a FloorsBySketchOutputs specifying all inputs.
        /// </summary>
        /// <returns></returns>
        [JsonConstructor]
        public FloorsBySketchOutputs(double area): base()
        {
			this.Area = area;

		}

		public override string ToString()
		{
			var json = JsonConvert.SerializeObject(this);
			return json;
		}
	}
}