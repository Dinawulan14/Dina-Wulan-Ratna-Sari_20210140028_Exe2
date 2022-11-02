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
            //1. repeat steps 2,3,4, and 5 varying i from 1 to n-1
            for (int i = 0; i < n - 1; i++)
            {
                //2.menambahkan set temp = arr[i]
                decimal temp = dina[1];
                //3. Set j =i - 1
                int DW = i - 1;
                //4. Repeat until j becomes less than 0 or arr[j] becomes less than or equal to temp:
                //a. Shift the value at index j to index j+1
                //b. Decrement j by 1
                while ((DW >= 0) && (dina[DW] < temp)
                {
                    dina[DW] = temp;
                }



            }
        }
