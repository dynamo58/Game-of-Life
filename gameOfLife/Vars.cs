using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gameOfLife
{
    class Vars
    {
        public int cellNum { get; set; }
        public bool[,] cellState { get; set; }
        public int[] surviveConds { get; set; }
        public int[] bornConds { get; set; }

        //public static int cellNum = 20;
        //public static bool[,] cellState = new bool[cellNum, cellNum];
        //public static int[] surviveConds = new int[] { 2, 3 };
        //public static int[] bornConds = new int[] { 3 };
    }
}
