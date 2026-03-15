using System;

namespace TP_MODUL4_103022400052
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Teknik Table-Driven ===");
            string kelurahan = "Batununggal";
            string kodePos = KodePos.getKodePos(kelurahan);
            Console.WriteLine($"Kode Pos {kelurahan} adalah {kodePos}");
            Console.WriteLine();

            Console.WriteLine("=== Teknik State-Based Construction ===");
            DoorMachine pintu = new DoorMachine();

            pintu.BukaPintu();
            pintu.KunciPintu();
        }
    }
}