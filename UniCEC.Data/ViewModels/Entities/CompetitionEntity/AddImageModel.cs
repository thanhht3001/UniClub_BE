using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using UniCEC.Data.ViewModels.Entities.Competition;

namespace UniCEC.Data.ViewModels.Entities.CompetitionEntity
{
    public class AddImageModel 
    {
       
        public string Name { get; set; }
        [JsonPropertyName("base64_string_img")]
        public string Base64StringImg { get; set;}
       
    }
}
