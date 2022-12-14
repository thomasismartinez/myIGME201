using System;
using System.Collections.Generic;
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
        }
    }

    public class PlayerStats
    {
        private PlayerStats() { }
        private static PlayerStats stats = new PlayerStats();
        public static PlayerStats Stats
        {
            get { return stats; }
        }

        // file directory
        private string dir = "c:/temp/playerStats.json";

        // player stats
        private string player_name;
        private int level;
        private int hp;
        private List<string> inventory;
        private string license_key;

        // load stats from file
        public void Load()
        {

        }

        // save stats to file
        public void Save()
        {

        }

        // print stats to console
        public void PrintStats()
        {

        }
    }
}
