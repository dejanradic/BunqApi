﻿using Newtonsoft.Json;

namespace Sycade.BunqApi.Requests
{
    class CreateSessionServerRequest : IBunqApiRequest
    {
        [JsonProperty("secret")]
        public string Secret { get; }

        public CreateSessionServerRequest(string secret)
        {
            Secret = secret;
        }
    }
}
