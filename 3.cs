using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

public class Hewan
{
    public int id { get; set; }
    public string Nama { get; set; }
    public string Jenis { get; set; }
    public string Golongan { get; set; }

}

public class Program
{
    static void Main(string[] args)
    {
        List<Hewan> list = new List<Hewan>
        {
            new Hewan { id = 1, Nama = "Maine Coon", Jenis = "Kucing", Golongan = "Karnivora" },
            new Hewan { id = 2, Nama = "Elang", Jenis = "Burung", Golongan = "Karnivora" },
            new Hewan { id = 3, Nama = "Parkit", Jenis = "Burung", Golongan = "Herbivora" },
            new Hewan { id = 4, Nama = "Paus", Jenis = "Ikan", Golongan = "Karnivora" },
         };

        Console.WriteLine("List Hewan: ");
        foreach(var hewan in list)
        {
            Console.WriteLine($" id: {hewan.id}, Nama: {hewan.Nama}, Jenis: {hewan.Jenis}, Golongan: {hewan.Golongan}");
        }

       
        Hewan databaru = new Hewan();
        Console.WriteLine("Masukkan Data baru: ");

        Console.Write("Id: ");
        databaru.id = Convert.ToInt32(Console.ReadLine());

        Console.Write("Nama: ");
        databaru.Nama = Console.ReadLine();

        Console.Write("Jenis: ");
        databaru.Jenis = Console.ReadLine();

        Console.Write("Golongan: ");
        databaru.Golongan = Console.ReadLine();

        
        list.Add(databaru);

       
        Console.WriteLine("\nUpdated List Hewan: ");
        foreach (var hewan in list)
        {
            Console.WriteLine($" id: {hewan.id}, Nama: {hewan.Nama}, Jenis: {hewan.Jenis}, Golongan: {hewan.Golongan}");
        }
    }

}

