using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExamDigraph
{
    // Digraph Adjacency Matrix
    enum EColor
    {
        red,
        blue,
        yellow,
        cyan,
        gray,
        purple,
        orange,
        green
    }
    internal class Program
    {
        static int[,] colorMGraph = new[,]
        {              /*red,blue,yellow,cyan,gray,purple,orange,green
            /* red */   { -1,   1,    -1,  -1,   5,    -1,    -1,   -1 },
            /* blue */  { -1,  -1,     8,   1,  -1,    -1,    -1,   -1 },
            /* yellow */{ -1,  -1,    -1,  -1,  -1,    -1,    -1,    6 },
            /* cyan */  { -1,   1,    -1,  -1,   0,    -1,    -1,   -1 },
            /* gray */  { -1,  -1,    -1,   0,  -1,    -1,     1,   -1 },
            /* purple */{ -1,  -1,     1,  -1,  -1,    -1,    -1,   -1 },
            /* orange */{ -1,  -1,    -1,  -1,  -1,     1,    -1,   -1 },
            /* green */ { -1,  -1,    -1,  -1,  -1,    -1,    -1,   -1 },
        };

        static int[][] colorAGraph = new int[][]
        {
            /* red */   new int[] { (int)EColor.blue , (int)EColor.orange },
            /* blue */  new int[] { (int)EColor.yellow , (int)EColor.cyan },
            /* yellow */new int[] { (int)EColor.green },
            /* cyan */  new int[] { (int)EColor.blue , (int)EColor.gray },
            /* gray */  new int[] { (int)EColor.cyan , (int)EColor.orange },
            /* purple */new int[] { (int)EColor.yellow },
            /* orange */new int[] { (int)EColor.purple },
            /* green */ null
        };

        static int[][] colorWGraph = new int[][]
        {
            /* red */   new int[] { 1, 5 },
            /* blue */  new int[] { 8, 1 },
            /* yellow */new int[] { 6 },
            /* cyan */  new int[] { 1, 0 },
            /* gray */  new int[] { 0, 1 },
            /* purple */new int[] { 1 },
            /* orange */new int[] { 1 },
            /* green */ null
        };
        static void Main(string[] args)
        {
        }
    }
}
