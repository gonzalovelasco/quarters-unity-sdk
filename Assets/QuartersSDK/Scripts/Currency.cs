﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.UI;

namespace QuartersSDK.Currency {
    
    [CreateAssetMenu(fileName = "DefaultCurrency", menuName = "Quarters/Currency", order = 1)]
    public class CurrencyConfig : ScriptableObject {

        public string Code;
        public string DisplayName;

        public Sprite CurrencyLogo;
        public Sprite BrandLogo;


        public CurrencyConfig(string json) {
            
            Assert.IsNotNull(json);
            Assert.IsFalse(json == String.Empty);
            
        
        }


    }
    
    
}
