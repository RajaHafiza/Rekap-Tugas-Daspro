using System;

namespace Soal1UTS{
    class Program{
        static void Main(string[] args)
        {
            Console.Clear();
            Console.Write("Nama         : ");
            string nama = Console.ReadLine().ToUpper();
            Console.Write("NIM          : ");
            string nim = Console.ReadLine();
            Console.Write("Konsentrasi  : ");
            string konsentrasi = Console.ReadLine().ToUpper();
            TeknikInformatikaA mhst = new TeknikInformatikaA(nama, nim, konsentrasi);
            mhst.printNameTag();
        }
    }
    class TeknikInformatikaA
    {
        string nama;
        string nim;
        string konsentrasi;

        public TeknikInformatikaA(string Nama, string NIM, string Konsentrasi)
        {
            nama = Nama;
            nim = NIM;
            konsentrasi = Konsentrasi;
        }
        public void printNameTag()
        {
            Console.WriteLine();
            Console.WriteLine("|      -- Mahasiswa Teknik Informatika --      |");
            Console.WriteLine("|            -- Universitas Riau --            |");
            Console.WriteLine("|**********************************************|");
            Console.WriteLine("|Nama :          {0,30}|",nama);
            Console.WriteLine("|NIM  :          {0,30}|",nim);
            Console.WriteLine("|----------------------------------------------|");
            Console.WriteLine("|Konsentrasi :      {0,27}|",konsentrasi);
            Console.WriteLine("|**********************************************|");
        }
    }
}