using Kuvio.Kernel.Core.Common;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Beachlist.Core.Beach
{
    public class Beach : CosmosDbRootEntity
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public Beach(string name, string description, double latitude, double longitude)
        {
            Id = Guid.NewGuid().ToString();
            Name = name;
            Description = description;
            Latitude = latitude;
            Longitude = longitude;
        }
    }


}
