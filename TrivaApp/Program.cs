using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace TrivaApp
{
    class TriviaResult
    {
        public string category;
        public string type;
        public string difficulty;
        public string question;
        public string correct_answer;
        public List<string> incorrect_answers;
    }
    class Triva
    {
        public int responce_code;
        public List<TriviaResult> triviaResults;

    }
    /*
     * {"response_code":0,
     * "results":[{"category":"Entertainment: Video Games","type":"multiple","difficulty":"medium"
     * ,"question":"What was the first interactive movie video game?",
     * "correct_answer":"Astron Belt","incorrect_answers":["Dragon&#039;s Lair","Cube Quest","M.A.C.H. 3"]}]}
     */
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
