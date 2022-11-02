using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dina_Wulan_Ratna_Sari_20210140028_Exe2
{
    class Program
    {
        //deklarasi array int 20-2x15+10+20+28 = 48
        //definisikan array dengan ukuran maksimum 48
        private decimal[] dina = new decimal[48];
        //variable ukuran array
        private decimal n;
        //fungsi untuk menginputkan ukuran array
        public void read()
        {
            while (true)
            {
                Console.WriteLine("Masukkan jumlah Element/Data Array :");
                string s = Console.ReadLine();
                n = decimal.Parse(s);
                if (n <= 48)
                    break;
                else
                    Console.WriteLine("\nArray maksimum 48 element/data. \n");
            }
            Console.WriteLine("");
            Console.WriteLine("======================");
            Console.WriteLine("Masukkan Array Elements");
            Console.WriteLine("\n====================");

            //menggunakan perulangan for untuk melakukan pengecekan
            for (int i = 0; i < n; i++)
            {
                Console.Write("<" + (i + 1) + ">");
                string s1 = Console.ReadLine();
                dina[i] = (int)decimal.Parse(s1);
            }
        }
        public void display()
        {
            //menampilkan array yang tersusun
            Console.WriteLine("");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Element array yang telah tersusun");
            Console.WriteLine("---------------------------------");
            for (int DW = 0; DW < n; DW++)
            {
                Console.WriteLine((Convert.ToDecimal(dina[DW])));
            }
            Console.WriteLine("");
        }
        public void Insertionsortarray()
        {

        }
