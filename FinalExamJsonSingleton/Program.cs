using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace FinalExamJsonSingleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // create data
            PlayerSettings player = new PlayerSettings();
            MySingleton mySingleton = MySingleton.GetInstance();
            mySingleton.Save(player);

            PlayerSettings loadedSettings = mySingleton.Load();
            Console.WriteLine(": " + loadedSettings.player_name);
            Console.WriteLine("level: " + loadedSettings.level);
            Console.WriteLine(": " + loadedSettings.player_name);
            Console.WriteLine(": " + loadedSettings.player_name);
        }
    }

    public class MySingleton
    {
        private MySingleton() { }

        private static MySingleton instance = new MySingleton();

        public static MySingleton GetInstance()
        {
            return instance;
        }

        public PlayerSettings Load(string path = "c:/temp/playerStats.json")
        {
            StreamReader reader = new StreamReader(path);
            string data = reader.ReadToEnd();
            reader.Close();
            return JsonConvert.DeserializeObject<PlayerSettings>(data);
        }

        public void Save(PlayerSettings obj, string path = "c:/temp/playerStats.json")
        {
            string data = JsonConvert.SerializeObject(obj);
            StreamWriter writer = new StreamWriter(path);
            writer.Write(data);
            writer.Close();
        }
    }

    public class PlayerSettings
    {
        public string player_name;
        public int level;
        public int hp;
        public string[] inventory;
        public string liscense_key;

        public PlayerSettings()
        {
            this.player_name = "dschuh";
            this.level = 4;
            this.hp = 99;
            this.inventory = new string[]
            {
                "spear",
                "water bottle",
                "hammer",
                "sonic screwdriver",
                "cannonball",
                "wood",
                "Scooby snack",
                "Hydra",
                "poisonous potato",
                "dead bush",
                "repair powder"
            };
            this.liscense_key = "DFGU99-1454";
        }
    }
}
