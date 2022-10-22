using System;
using System.Text;
using ManageMovie.Classes;
using Movie_Management;

namespace ManageMovie
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            MenuFilm();
        }
        private static void MenuFilm()
        {
            int choice=0;
            ManagementMovie manageMovie = new ManagementMovie();
            manageMovie.FilmAdd();
            string search;
            
            while (choice!=7)
            {
                Console.WriteLine("---------- RLMFlix ---------");
                Console.WriteLine("1: Add New Film ");
                Console.WriteLine("2: View List Film  ");
                Console.WriteLine("3: Update information of Firm");
                Console.WriteLine("4: Soft Film ");
                Console.WriteLine("5: Search Film ");
                Console.WriteLine("6: Delete Film ");
                Console.WriteLine("7: Back to Main Menu");
                Console.Write("Enter your choice: ");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        try
                        {
                            StringBuilder sb = new StringBuilder();
                            manageMovie.AddFilm();
                          
                        }
                        catch (Exception e)
                        {
                            
                        }
                       
                        break;
                    case 2:
                        manageMovie.ViewListFilm();
                        break;
                    case 3:
                        Console.Write("Input Id film to search: ");
                        search = Console.ReadLine();
                        manageMovie.UpdateFilmByID(search);
                        break;
                    case 4:
                        manageMovie.SoftFilmByID();
                        break;
                    case 5:
                        Console.Write("Input Id film to search: ");
                        search = Console.ReadLine();
                        manageMovie.SearchFilmByID(search);
                        break;
                    case 6:
                        Console.Write("Input Id film to search: ");
                        search = Console.ReadLine();
                        manageMovie.DeleteFilmByID(search);
                        break;
                   case 7:
                       Console.WriteLine("-------------------------------");
                        Console.WriteLine("Goodbye.");
                        break;
                }
            }
            
        }
        
    }
}