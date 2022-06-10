﻿using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuartersSDK.Data
{
    public class APIParams
    {
        public string BASE_URL { get; private set; }
        public string APP_KEY { get; private set; }
        public string URL_SCHEMA { get; private set; }
        public string SDK_VERSION { get; private set; }
        public string APP_ID { get; private set; }
        public string API_ENDPOINT { get; private set; }
        public string BUY_ENDPOINT { get; private set; }
        public string DASHBOARD_URL { get; private set; }
        public string ApiURL { get { return $"{BASE_URL}{API_ENDPOINT}"; } }
        public string BuyURL { get { return $"{BASE_URL}{BUY_ENDPOINT}"; } }
        public string ApiTokenURL { get { return $"{BASE_URL}/api/oauth2/token"; } }
        public APIParams(IConfigurationSection confSection)
        {
            APP_ID = confSection.GetSection("APP_ID").Value;
            DASHBOARD_URL = confSection.GetSection("DASHBOARD_URL").Value;
            BASE_URL = confSection.GetSection("BASE_URL").Value;
            APP_KEY = confSection.GetSection("APP_KEY").Value;
            URL_SCHEMA = confSection.GetSection("URL_SCHEMA").Value;
            API_ENDPOINT = confSection.GetSection("API_ENDPOINT").Value;
            BUY_ENDPOINT = confSection.GetSection("BUY_ENDPOINT").Value;
            SDK_VERSION = confSection.GetSection("SDK_VERSION").Value;
        }

    }
}