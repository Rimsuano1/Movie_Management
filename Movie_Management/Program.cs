using System;
using System.Globalization;
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
            int choice;
            Cinema cinema = new Cinema();
            
            cinema.AddMovie(new Movie(1,"John Wick","Action","Chad Stahelski", "01:41:00","10/24/2014",7.4));
            cinema.AddMovie(new Movie(2,"John Wick: Chapter 2","Action","Chad Stahelski", "02:02:00","02/10/2017",7.4));
            cinema.AddMovie(new Movie(3,"John Wick: Chapter 3 - Parabellum","Action","Chad Stahelski", "02:10:00","05/17/2019",7.4));
            cinema.AddMovie(new HotMovie(4,"John Wick","Action","Chad Stahelski", "01:41:00","10/24/2014",7.4));
            cinema.AddMovie(new HotMovie(5,"John Wick: Chapter 2","Action","Chad Stahelski", "02:02:00","02/10/2017",7.4));
            cinema.AddMovie(new HotMovie(6,"John Wick: Chapter 3 - Parabellum","Action","Chad Stahelski", "02:10:00","05/17/2019",7.4));
            cinema.AddMovie(new HotMovie(7,"The Fellowship of the Ring","Action,Adventure","Peter Jackson", "02:58:00","12/19/2001",7.4));
            cinema.AddMovie(new HotMovie(8,"The Fellowship of the Ring 2","Action,Adventure","Peter Jackson", "02:58:00","12/19/2001",7.4));
            
            
            while (true)
            {
                Console.WriteLine("---------- RLMFlix ---------");
                Console.WriteLine("1: Add New Film ");
                Console.WriteLine("2: View List Film  ");
                Console.WriteLine("3: Update information of Firm");
                Console.WriteLine("4: Search Film By Id ");
                Console.WriteLine("5: Delete Film By Id ");
                Console.WriteLine("6: Exit");
                Console.Write("Enter your choice: ");
                choice = int.Parse(Console.ReadLine());
                int id;
                switch (choice)
                {
                    case 1:

                        while (true)
                        {
                            Console.WriteLine(" m: To Add Normal Movie");
                            Console.WriteLine(" h: To Add Hot Movie");
                            Console.WriteLine(" e: To Back Main Menu");
                            Console.WriteLine("Please choose option you want to add movie: ");
                            string option = Console.ReadLine();
                            if (option.Equals("m"))
                            {
                                Console.Write("Enter Id: ");
                                id = int.Parse(Console.ReadLine());
                                Console.Write("Enter film: ");
                                string name = Console.ReadLine();
                                Console.Write("Enter kind: ");
                                string kind = Console.ReadLine();
                                Console.Write("Enter director: ");
                                string director = Console.ReadLine();
                                Console.Write("Enter film duration time: ");
                                string filmDurationTime = Console.ReadLine();
                                Console.Write("Enter release date: ");
                                string releaseDate = Console.ReadLine();
                                Console.Write("Enter tomato rate: ");
                                double tomatoRate = Double.Parse(Console.ReadLine());
                                cinema.AddMovie(new Movie(id, name, kind, director, filmDurationTime, releaseDate, tomatoRate));

                            }else if (option.Equals("h"))
                            {
                                Console.Write("Enter Id: ");
                                id = int.Parse(Console.ReadLine());
                                Console.Write("Enter film: ");
                                string name = Console.ReadLine();
                                Console.Write("Enter kind: ");
                                string kind = Console.ReadLine();
                                Console.Write("Enter director: ");
                                string director = Console.ReadLine();
                                Console.Write("Enter film duration time: ");
                                string filmDurationTime = Console.ReadLine();
                                Console.Write("Enter release date: ");
                                string releaseDate = Console.ReadLine();
                                Console.Write("Enter tomato rate: ");
                                double tomatoRate = Double.Parse(Console.ReadLine());
                                cinema.AddMovie(new HotMovie(id, name, kind, director, filmDurationTime, releaseDate, tomatoRate));
                            }
                            else if (option.Equals("e"))
                            {
                                break;
                            }

                        }
                       
                        break;
                    case 2:
                        Console.WriteLine(cinema.ViewInforMovies());
                        break;
                    case 3:
                        Console.Write("Enter Id: ");
                        id = int.Parse(Console.ReadLine());
                       Console.WriteLine(cinema.UpdateMovieByID(id));
                        break;
                    case 4:
                        Console.Write("Enter Id: ");
                        id = int.Parse(Console.ReadLine());
                        Console.WriteLine(cinema.SearchMovieByID(id));
                        break;
                    case 5:
                        Console.Write("Enter Id: ");
                       id = int.Parse(Console.ReadLine());
                        cinema.DeleteMovieByID(id);
                      
                        break;
                    case 6:
                       return;
                        break;
                  
                }
            }
            
        }
        
    }
}