using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BFS_Alg
{
    class DoThi
    {
        //Khai báo các thành phần
        private int sodinh;
        private int start;
        private int goal;
        private int[,] matran;

        //get,set
        public int SoDinh
        {
            get { return sodinh; }
            set { sodinh = value; }
        }

        public int Start
        {
            get { return start; }
            set { start = value; }
        }

        public int Goal
        {
            get { return goal; }
            set { goal = value; }
        }

        public int[,] MaTran
        {
            get { return matran; }
            set { matran = value; }
        }

        //constructor
        public DoThi()
        {
            this.sodinh = -1;
            this.start = -1;
            this.matran = new int[7, 7];
            ReadDoThi(); // đọc đồ thị từ file
        }

        public void ReadDoThi()
        {
            string TextFile = @"D:\LamTanHung_DA23TTA\BFS_Alg\BFS_Alg\input.txt"; //đường dẫn

            //Đọc file
            if (File.Exists(TextFile))
            {
                //Lấy thông số đỉnh
                string[] Lines = File.ReadAllLines(TextFile);
                string Line0 = Lines[0].Trim(); //Lấy dòng 1 cho biết số đỉnh
                this.sodinh = Convert.ToInt16(Line0); //Ép kiểu, gán số đỉnh cho dòng đầu tiên

                //Lấy thông số đỉnh đầu đỉnh cuối
                string line1 = Lines[1].Trim();
                string[] tam = line1.Split(' '); //tạo mảng từ dòng 2, tách theo dấu cách
                this.start = Convert.ToInt16(tam[0]);
                this.goal = Convert.ToInt16(tam[1]);

                //Đọc ma trân kề
                for(int i  = 0; i < this.sodinh; i++)
                {
                    string linei = Lines[i + 2].Trim();
                    string[]  arr = linei.Split(' ');
                    for(int j = 0; j < this.sodinh; j++)
                    {
                        this.matran[i, j] = Convert.ToInt32(arr[j]);
                        //Console.WriteLine(matran[i, j] + " ");
                    }

                    //Console.WriteLine();
                }
            }
        }

        //hiển thị đồ thị
        public void PrintDoThi()
        {
            Console.WriteLine("So dinh: {0}", this.sodinh);
            Console.WriteLine("start: {0}, goal: {1}", this.start, this.goal);

            for(int i = 0; i < this.sodinh; i++)
            {
                for(int j = 0; j < this.sodinh; j++)
                {
                    Console.Write(this.matran[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

    }
}
