using System;

public class Program
{
    private double tambah(double a, double b)
    {

        return (a + b);
    }

    private double kurang(double a, double b)
    {
        return (a - b);
    }

    private double kali(double a, double b)
    {
        return (a * b);
    }

    private double bagi(double a, double b)
    {
        return (a / b);
    }

    public void Main()
    {

        double bil1, bil2;
        char pilihan;
        Console.WriteLine("Pilih meneu calculator:");
        Console.WriteLine("\n");
        Console.WriteLine("1. Penambahan");
        Console.WriteLine("2. Pengurangan");
        Console.WriteLine("3. Perkalian");
        Console.WriteLine("4. Pembagian");
        Console.WriteLine("\n");
        Console.WriteLine("Input nomor menu [1..4]:");
        pilihan = Convert.ToChar(Console.ReadLine());
        Console.WriteLine("\n");

        if (pilihan == '1')
        {
            Console.WriteLine("input nilai a =");
            bil1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("input nilai b =");
            bil2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(" | Hasil Penambahan = " + tambah(bil1, bil2) + "			");

        }

        else if (pilihan == '2')
        {
            Console.WriteLine("input nilai a =");
            bil1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("input nilai b =");
            bil2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(" | Hasil Pengurangan = " + kurang(bil1, bil2) + "			");

        }

        else if (pilihan == '3')
        {
            Console.WriteLine("input nilai a =");
            bil1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("input nilai b =");
            bil2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(" | Hasil Pengurangan = " + kali(bil1, bil2) + "			");

        }

        else if (pilihan == '4')
        {
            Console.WriteLine("input nilai a =");
            bil1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("input nilai b =");
            bil2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(" | Hasil Pengurangan = " + bagi(bil1, bil2) + "			");

        }

        Console.WriteLine("\n");
        Console.WriteLine("\nTekan sembarang key untuk keluar");
        Console.ReadKey();

    }