using System;
using System.Collections.Generic;

namespace TebakKata
{
    class Program
    {
        static string katamisteri = "si kancil";
        static int kesempatan = 5;
        static List<string>tebakanpemain = new List<string> {};
        static void Main(string[] args)
        {
            Intro();
            PlayGame();
            //EndGame();
        }
        static void Intro()
        {
            Console.WriteLine("Selamat datang, hari ini kita akan bermain tebak film");
            Console.WriteLine($"anda memiliki kesempatan sebanyak {kesempatan} kali untuk menebak");
            Console.WriteLine($"Petunjuknya adalah sebuah filmanimasi hewan {katamisteri.Length}");
            Console.WriteLine(tebak nama film tersebut);
            Console.ReadKey():
            Console.WriteLine();          
        }
        static void PlayGame(){
            while(kesempatan > 0)
            {
                Console.Write("apa karakter tebakan mu?(a-z) :");
                string input = Console.ReadLine();
                tebakanpemain.Add(input);
                if (jawaban(katamisteri,tebakanpemain))
                {
                    Console.WriteLine("selamat,tebakan anda benar");
                    Console.WriteLine($"film yang dimaksud adalah : {katamisteri}");
                    break;
                }else{if (katamisteri.Contains(input))
                {
                    Console.WriteLine("huruf itu ada di dalam kata ini");
                    Console.WriteLine("silahkan tebak huruf lainnya");
                    Console.WriteLine(cekhuruf(katamisteri, tebakanpemain));
                }else{
                    Console.WriteLine("huruf tidak ada");
                    kesempatan--;
                    Console.WriteLine($"kesempatan anda tinggal{kesempatan}");
                }
                //showend();
                //break;
                }

                if (kesempatan==0)
                {
                    //Console.WriteLine("Maaf kesempatan anda telah habis");
                    //Console.WriteLine("Jawabannya adalah : {katamisteri}");
                    EndGame();
                    break;
                }
                static bool jawaban (string katamisteri, List<string> list){
                    bool status = false
                    for (int i = 0; i <katamisteri.Length; i++)
                    {
                      string c = Convert.ToString(katamisteri[i]);
                      if (list.Contains(c))
                      {
                        status = true;
                      }else{
                        return status = false;
                      }
                    }
                    return status;
                }
                static string cekhuruf(string katamisteri, List<string> list){
                string x = "";
                for(int i = 0; i < katamisteri, Lenght; i++)
                {
                    string c = Convert.ToString(katamisteri[i]);
                    if (List.Contains (c))
                    {
                        x = x + c;
                    }else{
                        x = x + ".";
                    }
                }
                return x;
        }
        static void EndGame(){
            Console.WriteLine("Permainan Selesai");
            Console.WriteLine($"jawabannya {katamisteri}");
        }
    }
}