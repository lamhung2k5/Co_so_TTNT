using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BFS_Alg
{
    internal class Program
    {
        static void Main(String[] args)
        {
            DoThi dt = new DoThi();
            dt.PrintDoThi();
            

            BFSAlg bfs = new BFSAlg();
            bfs.BFSsearch();
            bfs.PrintDuongDi();


            Console.ReadLine();
        }
    }
}
