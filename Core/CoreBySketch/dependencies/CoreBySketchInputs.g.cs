// This code was generated by Hypar.
// Edits to this code will be overwritten the next time you run 'hypar init'.
// DO NOT EDIT THIS FILE.

using Elements;
using Elements.GeoJSON;
using Elements.Geometry;
using Elements.Geometry.Solids;
using Elements.Validators;
using Elements.Serialization.JSON;
using Hypar.Functions;
using Hypar.Functions.Execution;
using Hypar.Functions.Execution.AWS;
using Hypar.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using Line = Elements.Geometry.Line;
using Polygon = Elements.Geometry.Polygon;

namespace CoreBySketch
{
    #pragma warning disable // Disable all warnings

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.21.0 (Newtonsoft.Json v12.0.0.0)")]
    
    public  class CoreBySketchInputs : S3Args
    
    {
        [Newtonsoft.Json.JsonConstructor]
        
        public CoreBySketchInputs(Polygon @perimeter, double @coreHeightAboveRoof, string bucketName, string uploadsBucket, Dictionary<string, string> modelInputKeys, string gltfKey, string elementsKey, string ifcKey):
        base(bucketName, uploadsBucket, modelInputKeys, gltfKey, elementsKey, ifcKey)
        {
            var validator = Validator.Instance.GetFirstValidatorForType<CoreBySketchInputs>();
            if(validator != null)
            {
                validator.PreConstruct(new object[]{ @perimeter, @coreHeightAboveRoof});
            }
        
            this.Perimeter = @perimeter;
            this.CoreHeightAboveRoof = @coreHeightAboveRoof;
        
            if(validator != null)
            {
                validator.PostConstruct(this);
            }
        }
    
        /// <summary>Perimeter of the building service core.</summary>
        [Newtonsoft.Json.JsonProperty("Perimeter", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Polygon Perimeter { get; set; }
    
        /// <summary>The projection of the service core above the highest building level.</summary>
        [Newtonsoft.Json.JsonProperty("Core height above roof", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.Range(-1.0D, 5.0D)]
        public double CoreHeightAboveRoof { get; set; } = 2D;
    
    }
}