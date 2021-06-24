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
using System;
using System.Collections.Generic;
using System.Linq;
using Line = Elements.Geometry.Line;
using Polygon = Elements.Geometry.Polygon;

namespace EnvelopeBySite
{
    #pragma warning disable // Disable all warnings

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.21.0 (Newtonsoft.Json v12.0.0.0)")]
    
    public  class EnvelopeBySiteInputs : S3Args
    
    {
        [Newtonsoft.Json.JsonConstructor]
        
        public EnvelopeBySiteInputs(double @buildingHeight, double @foundationDepth, bool @useSetbacks, double @siteSetback, double @setbackInterval, double @setbackDepth, double @minimumTierArea, string bucketName, string uploadsBucket, Dictionary<string, string> modelInputKeys, string gltfKey, string elementsKey, string ifcKey):
        base(bucketName, uploadsBucket, modelInputKeys, gltfKey, elementsKey, ifcKey)
        {
            var validator = Validator.Instance.GetFirstValidatorForType<EnvelopeBySiteInputs>();
            if(validator != null)
            {
                validator.PreConstruct(new object[]{ @buildingHeight, @foundationDepth, @useSetbacks, @siteSetback, @setbackInterval, @setbackDepth, @minimumTierArea});
            }
        
            this.BuildingHeight = @buildingHeight;
            this.FoundationDepth = @foundationDepth;
            this.UseSetbacks = @useSetbacks;
            this.SiteSetback = @siteSetback;
            this.SetbackInterval = @setbackInterval;
            this.SetbackDepth = @setbackDepth;
            this.MinimumTierArea = @minimumTierArea;
        
            if(validator != null)
            {
                validator.PostConstruct(this);
            }
        }
    
        /// <summary>Overall height of the building from grade.</summary>
        [Newtonsoft.Json.JsonProperty("Building Height", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.Range(5D, 100D)]
        public double BuildingHeight { get; set; } = 20D;
    
        /// <summary>Depth of the building envelope below grade.</summary>
        [Newtonsoft.Json.JsonProperty("Foundation Depth", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.Range(5D, 20D)]
        public double FoundationDepth { get; set; } = 10D;
    
        [Newtonsoft.Json.JsonProperty("Use Setbacks", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool UseSetbacks { get; set; } = true;
    
        /// <summary>Distance from site boundary to building envelope.</summary>
        [Newtonsoft.Json.JsonProperty("Site Setback", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.Range(0D, 30D)]
        public double SiteSetback { get; set; } = 0D;
    
        /// <summary>Vertical distance between envelope setbacks.</summary>
        [Newtonsoft.Json.JsonProperty("Setback Interval", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.Range(10D, 30D)]
        public double SetbackInterval { get; set; } = 20D;
    
        /// <summary>Offset depth from previous setback.</summary>
        [Newtonsoft.Json.JsonProperty("Setback Depth", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.Range(1D, 3D)]
        public double SetbackDepth { get; set; } = 1D;
    
        /// <summary>Minimum area allowed for a setback tier.</summary>
        [Newtonsoft.Json.JsonProperty("Minimum Tier Area", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.Range(10D, 100D)]
        public double MinimumTierArea { get; set; } = 50D;
    
    
    }
}