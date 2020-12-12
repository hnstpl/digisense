using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Web;
//using DigisenseAPI.Models;

namespace Profile.WebAPI.Models.Profile
{
    public static class DynamicSetProperty
    {
        /// <summary>
        /// this will add properties dynamically
        /// </summary>
        /// <param name="ctmp"></param>
        /// <param name="propertyName"></param>
        /// <param name="propertyValue"></param>
        public static void AddProperty(ExpandoObject ctmp, string propertyName, object propertyValue)
        {
            // ExpandoObject supports IDictionary so we can extend it like this
            var ctmpDict = ctmp as IDictionary<string, object>;
            if (ctmpDict.ContainsKey(propertyName))
                ctmpDict[propertyName] = propertyValue;
            else
                ctmpDict.Add(propertyName, propertyValue);
        }

    }

}