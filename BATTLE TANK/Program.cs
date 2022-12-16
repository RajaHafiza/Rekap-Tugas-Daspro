using System;

namespace BattleTank
{
    class Program
    {
        static void Main (string[] args)
        {
        //Inisialisasi variabel yang dibutuhkan
        int panjangArea = 5;
            char rumput = '~';
            char tank = 't';
            char hit = 'X';
            char miss = 'O';
            int jumlahTank = 3;
            
        }
        //Membuat area permainan (array 2 dimensi)
        static char [,] buatRuang(int panjangArea, char rumput, char tank, int jumlahTank){
            char[,] ruangan = new char [panjangArea,panjangArea];

            for(int baris=0;baris<panjangArea;baris++){
                for(int kolom=0;kolom<panjangArea;kolom++){
                    ruangan[baris,kolom] = rumput;
                }
            }

            return letakkanTank(ruangan,jumlahTank,rumput,tank);
        }
        //meletakkan Tank
        private static char[,] letakkanTank(char[,] ruangan,int jumlahTank, char rumput, char tank){
            int letakTank = 0;
            int panjangArea = 5;

            while(letakkanTank < jumlahTank){
                int[] lokasiTank = tentukanKoordinatTank(panjangArea);
                char posisiZ = ruang [lokasiTank[0], lokasiTank[1]];

                if(posisiZ == rumput){
                    ruang[lokasiTank[0], lokasiTank[1]] = tank;
                    letakTank++;
                }
            }

            return ruangan;
        }
        //Menentukan Posisi random koordinat
        private static int[] tentukanKoordinatTank (int panjangArea){
            Random rnd = new Random();
            int[] koordinat = new int [2];
            for (int i = 0; i < koordinat.Length; i++)
            {
                koordinat[i] = rnd.Next(panjangArea);
            }

            return koordinat;
        }
        //Print Array 2 dimensi untuk ke console
        private static void PrintRuang(char[,] ruang, char rumput, char tank){

            Console.Write(" ");
            for (int i = 0; i < length; i++)
            {
                Console.Write(i | 1 | " ");
            }
            Console.WriteLine();

            for (int baris = 0; baris < 5; baris++)
            {
                Console.Write(baris | 1 | " ");
                for (int kolom = 0; kolom < 5; kolom++)
                {
                    char Posisi - ruang[baris,kolom];
                    if (posisi == tank){
                        Console.Write(rumput + " ");
                    }else{
                        Console.Write(posisi + " ");
                    }   
                }
                Console.WriteLine();   
            }
        }
        //jumlah tank yang tersembunyi
        int jumlahTankTersembunyi = totalTank;

        //gameplay
        while (jumlahTankTersembunyi > 0){
            int[] tebakKoordinat =getKoordinatPemain(panjangArea);
            char updateTampilanRuang = verifikasiTebakanPemain(tebakKoordinat, ruang, tank, rumput, hit, miss);
            if (updateTampilanRuang == hit){
                jumlahTankTersembunyi--;
            }
            ruang = updateRuang(ruang, tebakKoordinat, updateTampilanRuang);
            PrintRuang(ruang, rumput, tank);
        }
        Console.WriteLine("GAME OVER");
        Console.Read();
        {

        }
        //Tebakan user
        private static int[]getKoordinatPemain(int panjangArea){
            int baris;
            int kolom;

            do{
                Console.Write("Pilih Baris : ");
                baris = Convert.ToInt32(Console.ReadLine());
            } while (baris<0 || baris > panjangArea + 1);

            do
            {
                Console.Write("Pilih Kolom : ");
                kolom = Convert.ToInt32(Console.ReadLine());
            } while (kolom<0 || kolom > panjangArea +1);

            return new[]{baris-1, kolom-1};
        }
        //Cek Validasi Tebakan User
        private static char verifikasiTebakanPemain(int [] tebakKoordinat, char[,] ruang, char tank, char rumput, char hit, char miss){
            string pesan;
            int baris = tebakKoordinat[0];
            int kolom = tebakKoordinat[1];
            char target = ruang[baris, kolom];

            if (target == tank){
                pesan = "TEPAT SASARAN";
                target = hit;

            }else if (target ==- rumput){
                pesan ="ANDA MELESET";
                target = miss; 
            }else{
               pesan = "AREA INI AMAN"; 
            }

            Console.WriteLine(pesan);
            Console.WriteLine(" ");
            return target;
        }
        //Update tampilan Array 2 dimensi berdasarkan hasil tebakan user
        private static char [,] updateRuang(char[,] ruang, int [] tebakKoordinat, char updateTampilanRuang){

            int baris = tebakKoordinat[0];
            int kolom = tebakKoordinat[1];
            ruang[baris,kolom] = updateTampilanRuang;
            return ruang;
            
        }


            
        }
    }
    
}
