using System;
using System.Collections.Generic;
using System.Linq;

namespace C_Sharp_Data_Structure
{
    class Program
    {
        // Reference: https://docs.microsoft.com/en-us/dotnet/standard/collections/
        static void Main(string[] args)
        {
            DictionaryExamples();
        }

        private static void DictionaryExamples()
        {
            DictionaryHelper dictionaryExample = new DictionaryHelper();
            Dictionary<string, int> keyValuePairs = dictionaryExample.Add();

            Console.WriteLine("\n\nPrinting for Dictionary - Invoking Add()");
            dictionaryExample.Print(keyValuePairs);

            Console.WriteLine("\n\nPrinting for Dictionary - Invoking RemoveByKey()");
            dictionaryExample.Print(dictionaryExample.RemoveByKey(keyValuePairs.Keys.FirstOrDefault(), keyValuePairs));

            Console.WriteLine("\n\nPrinting for Dictionary - Invoking ChecksIfKeyExistsInDictionary()");
            dictionaryExample.ChecksIfKeyExistsInDictionary(keyValuePairs.Keys.FirstOrDefault(), keyValuePairs);

            Console.WriteLine("\n\nPrinting for Dictionary - Invoking ChecksIfValueExistsInDictionary()");
            dictionaryExample.ChecksIfValueExistsInDictionary(keyValuePairs.Values.FirstOrDefault(), keyValuePairs);

            Console.WriteLine("\n\nPrinting for Dictionary - Invoking GetKeyValuePairForKey()");
            KeyValuePair<string, int> keyValuePair = dictionaryExample.GetKeyValuePairForKey(keyValuePairs.Keys.FirstOrDefault(), keyValuePairs);
        }
    }

    /// <summary>
    /// Dictionary is generally used to store key/value pairs
    /// 
    /// No 2 identical key can exists in the Dictionary
    /// </summary>
    public class DictionaryHelper
    {
        // Add key value pair to dictionary
        public Dictionary<string, int> Add()
        {
            Dictionary<string, int> dictionary = new Dictionary<string, int>();

            dictionary.Add("key 1", 123);
            dictionary.Add("key 2", 456);
            dictionary.Add("key 3", 789);

            return dictionary;
        }

        // Print each element in dictionary
        public void Print(Dictionary<string, int> keyValuePairs)
        {
            foreach (KeyValuePair<string, int> ele2 in keyValuePairs)
            {
                Console.WriteLine("{0} and {1}", ele2.Key, ele2.Value);
            }
        }

        // Removing element in dictionary by key
        public Dictionary<string, int> RemoveByKey(string key, Dictionary<string, int> keyValuePairs)
        {
            keyValuePairs.Remove(key);

            return keyValuePairs;
        }

        // Checks whether key exists in dictionary
        public void ChecksIfKeyExistsInDictionary(string key, Dictionary<string, int> keyValuePairs)
        {
            if (keyValuePairs.ContainsKey(key) == true)
            {
                Console.WriteLine("Key is found...!!");
            }
        }

        // Checks whether value exists in dictionary
        public void ChecksIfValueExistsInDictionary(int value, Dictionary<string, int> keyValuePairs)
        {
            if (keyValuePairs.ContainsValue(value) == true)
            {
                Console.WriteLine("Value is found...!!");
            }
        }

        // Get KeyValuePair from dictionary if key exists
        public KeyValuePair<string, int> GetKeyValuePairForKey(string key, Dictionary<string, int> keyValuePairs)
        {
            return new KeyValuePair<string, int>(key, keyValuePairs[key]);
        }
    }
}
