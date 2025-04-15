using System;
using modul8_103022300064;

class Program
{
    static void Main(string[] args)
    {
        BankTransferConfig bankTransferConfig = new BankTransferConfig();
        int input;
        int amountTransfer;
        Console.WriteLine("Pilih Bahasa (English atau Indonesia) = ");
        bankTransferConfig.lang = Console.ReadLine();

        if (bankTransferConfig.lang.Equals("en"))
        {
            Console.WriteLine("Please insert the amount of money to transfer =  ");
            input = Convert.ToInt32(Console.ReadLine());
            if (input <= bankTransferConfig.threshold)
            {
                amountTransfer = bankTransferConfig.low_fee;
                Console.WriteLine($"Transfer fee = {amountTransfer} dan Total amount = {input + amountTransfer}");

            }
            else
            {
                amountTransfer = bankTransferConfig.high_fee;
                Console.WriteLine($"Transfer fee = {amountTransfer} dan Total amount = {input + amountTransfer}");
            }
        }
        else
        {
            Console.WriteLine("Masukkan jumlah uang yang akan di-transfer =  ");
            input = Convert.ToInt32(Console.ReadLine());
            if (input <= bankTransferConfig.threshold)
            {
                amountTransfer = bankTransferConfig.low_fee;
                Console.WriteLine($"Transfer fee = {amountTransfer} dan Total amount = {input + amountTransfer}");

            }
            else
            {
                amountTransfer = bankTransferConfig.high_fee;
                Console.WriteLine($"Transfer fee = {amountTransfer} dan Total amount = {input + amountTransfer}");
            }
        }
        



        Console.WriteLine("\nTekan sembarang tombol untuk keluar...");
        Console.ReadKey();
    }
}
