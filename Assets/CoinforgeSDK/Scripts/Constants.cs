﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CoinforgeSDK {
    public static class Error {

        public static string UNAUTHORIZED_ERROR = "401 Unauthorized";

    }

    public enum Environment {
        sandbox,
		development,
		production
	}


    public static partial class Constants {
        public const string REFRESH_TOKEN_KEY = "CoinforgeRefreshToken";
        public const string GUEST_TOKEN_KEY = "CoinforgeGuestToken";
        public const string GUEST_FIREBASE_TOKEN = "CoinforgeGuestFirebaseToken";
        
    }
}
