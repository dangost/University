using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace Lab01
{
    public class Log
    {
        public int Type { get; set; }
        
        public string Ru { get; set; }
        
        public string En { get; set; }
    }
    
    public class Logging
    {
        public Logging(string _local = null)
        {
            local = _local;
            if (local != null)
            {
                string json = File.ReadAllText("localization.json");
                logs = JsonConvert.DeserializeObject<List<Log>>(json);
            }
        }

        private string local;

        private List<Log> logs;

        public void WriteLog(LogEnum val)
        {
            if (local.ToLower() == "ru")
            {
                Console.WriteLine(logs[(int)val].Ru);
            }
            else if(local.ToLower() == "en")
            {
                Console.WriteLine(logs[(int)val].En);
            }
            
        }
    }
}