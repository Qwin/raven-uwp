﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RavenUWP.Models
{
    public class RavenException
    {
        [JsonProperty("stacktrace")]
        public RavenStacktrace Stacktrace { get; set; }

        [JsonProperty("module")]
        public string Module { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }
}