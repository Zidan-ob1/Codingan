using System;
using System.Collections.Generic;

    public class Laptop
    {
        public int id { get; set; }
        public string name { get; set; }
        public string merek { get; set; }
    }

    public class Program
    {

        static void Main(string[] args)
        {
            
            List<Laptop> list = new List<Laptop>
            {
            new Laptop { id = 1, name = "Thinkpad", merek = "Lenovo",},
            new Laptop { id = 2, name = "MacBook Pro", merek = "Apple"},
            new Laptop { id = 3, name = "VivoBook Ultra", merek = "Asus"},
            new Laptop { id = 4, name = "Zepyhrus G14", merek = "ROG"}
            };
            
            Console.WriteLine("List Laptop: "); //menampilkan data
            foreach (var laptop in list)
            {
                Console.WriteLine($"id: {laptop.id}, name: {laptop.name}, merek: {laptop.merek}");
            }

            Laptop newlaptop = new Laptop { id = 5, name = "Aspire 3", merek = "Acer" };
            list.Add(newlaptop);
            Console.WriteLine("\nTambah New Laptop: ");
            foreach (var laptop in list)
            {
                Console.WriteLine($"id: {laptop.id}, name: {laptop.name}, merek: {laptop.merek}");
            }

            
            list.RemoveAll(z => z.id == 3);
            Console.WriteLine("\nSetelah dihapus id ke-3 : ");
            foreach (var laptop in list)
            {
                Console.WriteLine($"id: {laptop.id}, name: {laptop.name}, merek: {laptop.merek}");
            }

            
            Laptop UpdateLaptop1 = list.Find(z => z.id == 2);
            if (UpdateLaptop1 != null)
            {
                UpdateLaptop1.name = "Macbook Air M2";
                UpdateLaptop1.merek = "Apple";
            }
            Console.WriteLine("\nHasil Update List Id 2: ");
            foreach (var laptop in list)
            {
                Console.WriteLine($"id: {laptop.id}, name: {laptop.name}, merek: {laptop.merek}");
            }

        }
    
    }  
