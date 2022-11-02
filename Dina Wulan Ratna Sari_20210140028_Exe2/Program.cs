using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dina_Wulan_Ratna_Sari_20210140028_Exe2
{
    class Program
    {
        //definisikan array dengan ukuran maksimum 48
        private int[] arr = new int[48];
        //variable ukuran array
        private int n;
        //fungsi untuk menginputkan ukuran array
        public void read()
        {
            while (true)
            {
                Console.WriteLine("Masukkan jumlah Element/Data Array :");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if (n <= 48)
                    break;
                else
                    Console.WriteLine("\nArray maksimum 48 element/data. \n");
            }
            }
        }
    }
