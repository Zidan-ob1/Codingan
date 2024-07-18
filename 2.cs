using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

public class Hewan
{
    public int id { get; set; }
    public string Nama { get; set; }
    public string Jenis {  get; set; }
    public string Golongan { get; set; }
   
}

public class Program
{
    static void Main(String[] args)
    {
       Hewan[] objek = new Hewan[4];


        Hewan number1 = new Hewan { id = 1, Nama = "Maine Coon", Jenis = "Kucing", Golongan = "Karnivora" };
        Hewan number2 = new Hewan { id = 2, Nama = "Elang", Jenis = "Burung", Golongan = "Karnivora" };
        Hewan number3 = new Hewan { id = 3, Nama = "Parkit", Jenis = "Burung", Golongan = "Herbivora" };
        Hewan number4 = new Hewan { id = 4, Nama = "Paus", Jenis = "Ikan", Golongan = "Karnivora" };

        objek[0] = number1;
        objek[1] = number2;
        objek[2] = number3;
        objek[3] = number4;

        foreach (Hewan binatang in objek)
        {
            Console.WriteLine($"id: {binatang.id}, Nama: {binatang.Nama}, Golongan: {binatang.Golongan}, Jenis: {binatang.Jenis}");
    
        }  
    }
}

