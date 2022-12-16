using System;
namespace soal2uts
{
    class Program
    {
        static void Main(string[] args){
            Console.Clear();
            Random rnd=new Random();
            int rNo=rnd.Next(0,100);
            bool guessed=false;
            int guesses=0;
            while(!guessed){
                Console.Write("Tebak angka antara 1-100 : ");
                int Inis=Convert.ToInt32(Console.ReadLine());
                guesses+=1;
                if(Inis==rNo){
                    Console.WriteLine("TEBAKAN ANDA BENAR");
                    Console.WriteLine("SAMPAI JUMPA");
                    break;
                }else if(Inis<rNo){
                    Console.WriteLine("Kurang tepat. Nilai terlalu rendah.");
                }else if(Inis>rNo){
                    Console.WriteLine("Kurang tepat.Nilai terlalu tinggi.");
                }
            }
        }
    }
}

