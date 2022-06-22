﻿using Newtonsoft.Json;
using QuartersSDK.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace QuartersSDK.Data
{
    public class Error : Exception
    {
            public static string INVALID_TOKEN = "Invalid `refresh_token`";

            [JsonProperty("error")] 
            public string ErrorMessage;

            [JsonProperty("error_description")] 
            public string ErrorDescription;
            public Error() { }

            public Error(string json)
            {
                try
                {
                    var err = JsonConvert.DeserializeObject<Error>(json);
                    this.ErrorMessage = err.ErrorMessage ?? json;
                    this.ErrorDescription = err.ErrorDescription ?? String.Empty;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            public Error(string message, string description)
            {
                this.ErrorMessage = message;
                this.ErrorDescription = description;
            }
    }
}
