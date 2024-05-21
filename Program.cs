using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Assighnment2
{
    public class Inventry
    {
                     // Encapsulation
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
    }
                   //Abstraction
    public abstract class Details
    {
       public static List<Inventry> Inventry = new List<Inventry>();

        public abstract void Show();
        public abstract void Add();
        public abstract void Delete();
        public abstract void Update();

        public abstract void finditem();
    }
    // Inheritance 
    public abstract class Metho : Details
    {
                    

        public override void Add()
        {
            Console.WriteLine("1. Enter the Details 2. Back to Main Menu");
          Console.WriteLine("Select the operation:");
            int option=Convert.ToInt32(Console.ReadLine());
            if (option ==1)
            {
                Console.WriteLine ("Enter the Product ID:");
                int Id=Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the name of Product:");
                      string Name=Console.ReadLine();

                Console.WriteLine("Enter the Price of the Product:");
                double Price = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Enter the Quantity of Product:");
                int Quantity = Convert.ToInt32(Console.ReadLine());

                Inventry.Add(new Inventry { Id = Id, Name = Name, Price = Price, Quantity = Quantity });
                Console.WriteLine("Data Added Successfully");
                Add();
            }
            else if (option == 2)
            {
                Menu();
            }
            else
            {
                Console.WriteLine("Enter the correct input");
            }
        }

        public override void Show()
        {
            if (Inventry.Count > 0)
            {
                for (int i = 0; i < Inventry.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. Name of Product: {Inventry[i].Name}, Product Id: {Inventry[i].Id}, Price of the Product: {Inventry[i].Price}, Product Quantity: {Inventry[i].Quantity}");


                }


            }
            else
            {
                Console.WriteLine("Data Not Found");
            }
            Menu();
        }

        public override void Delete()
        {
            //Show();
            Console.WriteLine("1. Enter the product which you want to delete 2. Back to main menu");
            int opt = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("1. Surely do you want to delete" );
            if (opt == 1)
              {
                for (int i = 0; i < Inventry.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. Name of Product: {Inventry[i].Name}, Product Id: {Inventry[i].Id}, Price of the Product: {Inventry[i].Price}, Product Quantity: {Inventry[i].Quantity}");
                }

                int del = Convert.ToInt32(Console.ReadLine());
                Inventry.RemoveAt(del - 1);
                Console.WriteLine("Deleted Data Successfully");
                Menu();
            }
          
        }

        public override void Update()
        {
          //  Show();
            Console.WriteLine("Enter the number of the product to update:");
            int index = Convert.ToInt32(Console.ReadLine()) - 1;

            if (index >= 0 && index < Inventry.Count)
            {
                 Console.WriteLine("Enter new Product ID:");
                Inventry[index].Id = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter new name of Product:");
                Inventry[index].Name = Console.ReadLine();

             Console.WriteLine("Enter new Price of the Product:");
             Inventry[index].Price = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter new Quantity of Product:");
                Inventry[index].Quantity = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Data Updated Successfully");
                Menu();
            }
            else
            {
                Console.WriteLine("Invalid index");
            }
        }
        public override void finditem()
        {
            Console.WriteLine("Search an item by Prduct ID");
            int id = Convert.ToInt32(Console.ReadLine());
            bool found = false;

            for (int i = 0; i < Inventry.Count; i++)
            {
                if (Inventry[i].Id == id)
                {
                    Console.WriteLine($"{i + 1}. Name of Product: {Inventry[i].Name}, Product Id: {Inventry[i].Id}, Price of the Product: {Inventry[i].Price}, Product Quantity: {Inventry[i].Quantity}");
                    found = true;
                    break;
                }
                if (found == false) Console.WriteLine("No Product found!!");
            }
            Menu();
        }
        public void Menu()
        {
            Console.WriteLine("1. Show 2. Add 3. Delete 4. Update 5. Find the item by Product ID 6. Close");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Show();
                    break;
                    case 2:
                    Add();
                    break;
                case 3:
                    Delete();
                    break;
             case 4:
                    Update();
                    break;
                case 5:
                   finditem();
                    ;
                    break;
                case 6:
                    Close(); break;
                  default:
                    Console.WriteLine("Invalid choice. Please select a valid option.");
                    break;
            }

        }
        public void Close()
        { 
        Console.Clear();
        }
        }

    public class InventoryManager : Metho
    {
     
       
    }

    public class Program : InventoryManager
    {
        static void Main(string[] args)
        {
            InventoryManager i1 = new InventoryManager();//object
            Console.WriteLine   ("---------Inventry Management System--------");
            i1.Menu();
 
                }
            }
        }
    


