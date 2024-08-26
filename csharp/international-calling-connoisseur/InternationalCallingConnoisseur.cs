using System;
using System.Collections.Generic;
using System.Linq;

public static class DialingCodes
{
    public static Dictionary<int, string> GetEmptyDictionary()
    {
        return new Dictionary<int, string>();
    }

    public static Dictionary<int, string> GetExistingDictionary()
    {
        return new Dictionary<int, string>()
        {
            [1] = "United States of America",
            [55] = "Brazil",
            [91] = "India"
        };
    }

    public static Dictionary<int, string> AddCountryToEmptyDictionary(int countryCode, string countryName)
    {
        return new Dictionary<int, string>()
        {
            [countryCode] = countryName
        };
    }

    public static Dictionary<int, string> AddCountryToExistingDictionary(
        Dictionary<int, string> existingDictionary, int countryCode, string countryName)
    {
        existingDictionary[countryCode] = countryName;
        return existingDictionary;
    }

    public static string GetCountryNameFromDictionary(
        Dictionary<int, string> existingDictionary, int countryCode)
    {
        
        if(existingDictionary.ContainsKey(countryCode)) return existingDictionary[countryCode];

        return "";
    }

    public static bool CheckCodeExists(Dictionary<int, string> existingDictionary, int countryCode)
    {
        return existingDictionary.ContainsKey(countryCode);
    }

    public static Dictionary<int, string> UpdateDictionary(
        Dictionary<int, string> existingDictionary, int countryCode, string countryName)
    {
        if(existingDictionary.ContainsKey(countryCode)) existingDictionary[countryCode] = countryName;
        
         return existingDictionary;
    }

    public static Dictionary<int, string> RemoveCountryFromDictionary(
        Dictionary<int, string> existingDictionary, int countryCode)
    {
        var dict = existingDictionary;
        dict.Remove(countryCode);
        return dict;
    }

    public static string FindLongestCountryName(Dictionary<int, string> existingDictionary)
    {
        try
        {
            return existingDictionary.Values.OrderByDescending(p => p.Length).First();
        }
        catch{
            return "";
        }

    }
}