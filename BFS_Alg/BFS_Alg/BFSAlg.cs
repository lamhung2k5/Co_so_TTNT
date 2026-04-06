using System;
using System.Collections;
using System.Collections.Generic;  
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BFS_Alg
{
    class BFSAlg
    {
        private DoThi dt;
        private Queue<int> q;

        private int[] pre;
        static readonly int NIL = -5;

        public BFSAlg()
        {
            dt = new DoThi();
            q = new Queue<int>();
            pre = new int[dt.SoDinh];

            for(int i = 0; i < dt.SoDinh; i++)
            {
                pre[i] = -2; //i chưa được duyệt
            }

            pre[dt.Start] = NIL;
            q.Enqueue(dt.Start);
        }

        public void BFSsearch()
        {
            //bool kq = false;
            while(!q.Contains(dt.Goal) && q.Count > 0)
            {
                int DinhDangXet = q.Dequeue();
                for(int i = 0; i < dt.SoDinh; i++)
                {
                    if(dt.MaTran[DinhDangXet,i] != 0)
                    {
                        if(pre[i] == -2)
                        {
                            pre[i] = DinhDangXet;
                            q.Enqueue(i);
                        }
                    }
                }
            }
        }

        public void PrintDuongDi()
        {
            Console.WriteLine("mang pre: ");
            for(int i  = 0; i < dt.SoDinh; i++)
            {
                Console.Write(pre[i] + " ");
            }

            Console.WriteLine();
            if(pre[dt.Goal] == -2)
            {
                Console.WriteLine("khong tim duoc duong di");
            }
            else
            {
                int curr = dt.Goal;
                while (curr != dt.Start)
                {
                    Console.Write("{0} <== ", curr);
                    curr = pre[curr];
                }
                Console.Write("{0} ", dt.Start);
            }
        }
    }
}
