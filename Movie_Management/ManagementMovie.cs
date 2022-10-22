using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ManageMovie.Classes;

namespace Movie_Management
{
    public class ManagementMovie
    {
        private static List<Movie> movies = new List<Movie>();
        public void FilmAdd()
        {
            movies.Add(new Film(1,"John Wich","F001","Action","Chad Stahelski", "R","Null",DateTime.Parse("01:41:00"),DateTime.Parse("10/24/2014"),7.4));
            movies.Add(new Film(2,"John Wick: Chapter 2","F002","Action","Chad Stahelski", "R","Null",DateTime.Parse("02:02:00"),DateTime.Parse("02/10/2017"),7.4));
            movies.Add(new Film(3,"John Wick: Chapter 3 - Parabellum","F003","Action","Chad Stahelski", "R","Null",DateTime.Parse("02:10:00"),DateTime.Parse("05/17/2019"),7.4));
            movies.Add(new Film(4,"The Fellowship of the Ring","F004","Action,Adventure","Peter Jackson", "PG-13","novels",DateTime.Parse("02:58:00"),DateTime.Parse("12/19/2001"),7.4));
            movies.Add(new Film(5,"The Fellowship of the Ring 2","F004","Action,Adventure","Peter Jackson", "PG-13","novels",DateTime.Parse("02:58:00"),DateTime.Parse("12/19/2001"),7.4));

        }
        public void AddFilm()
        {
            Movie movie = new Movie();
            //Increment Id
            movie.Id = movies.Count + 1;
            InputIdFlim:
            //Input Name of film
            Console.Write("Enter ID film : ");
            movie.IdFilm = Console.ReadLine();
            foreach (Film iFilm in movies)
            {
                if (iFilm.IdFilm.Equals(movie.IdFilm))
                {
                    Console.WriteLine("This id already exists");
                    goto InputIdFlim;
                }
            }
            //Input Name of film
            Console.Write("Enter Name : ");
            movie.Name = Console.ReadLine();
            //Input Kind
            Console.Write("Enter Kind of Film: ");
            movie.Kind = Console.ReadLine();
            //Input Director
            Console.Write("Enter Director of film: ");
            movie.Director = Console.ReadLine();
            //Input Film classification
            Console.WriteLine("--------------MPA film ratings-------------");
            Console.WriteLine("|1:G – General Audiences                  |");
            Console.WriteLine("|2:PG – Parental Guidance Suggested       |");
            Console.WriteLine("|3:PG-13 – Parents Strongly Cautioned     |");
            Console.WriteLine("|4:R – Restricted                         |");
            Console.WriteLine("|5:NC-17 – Adults Only                    |");
            Console.WriteLine("|6:Other                                  |");
            Console.WriteLine("-------------------------------------------");
            Console.Write("Enter Film Classification: ");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    movie.FilmClassification = "G";
                    break;
                case 2:
                    movie.FilmClassification = "PG";
                    break;
                case 3:
                    movie.FilmClassification = "PG-13";
                    break;
                case 4:
                    movie.FilmClassification = "R";
                    break;
                case 5:
                    movie.FilmClassification = "NR-17";
                    break;
                case 6:
                    
                    movie.FilmClassification = Console.ReadLine();
                    break;
            }

            //Input Film Adaptation
            Console.WriteLine("--------------Adaptation film -------------");
            Console.WriteLine("|1:Book adaptations                       |");
            Console.WriteLine("|2:Comic book adaptations                 |");
            Console.WriteLine("|3:Musical adaptations                    |");
            Console.WriteLine("|4:Play adaptations                       |");
            Console.WriteLine("|5:Television adaptations                 |");
            Console.WriteLine("|6:Video game adaptations                 |");
            Console.WriteLine("|7.Other                                  |");
            Console.WriteLine("-------------------------------------------");
            Console.Write("Enter Film Classification: ");
            choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    movie.FilmAdaptation = "Book";
                    break;
                case 2:
                    movie.FilmAdaptation = "Comic book";
                    break;
                case 3:
                    movie.FilmAdaptation = "Musical";
                    break;
                case 4:
                    movie.FilmAdaptation = "Play";
                    break;
                case 5:
                    movie.FilmAdaptation = "Television";
                    break;
                case 6:
                    movie.FilmAdaptation = "Video game";
                    break;
                case 7:
                    Console.Write("Input the source to be adapted: ");
                    movie.FilmAdaptation = Console.ReadLine();
                    break;
            }
            InputFilmDuration:
            //Input Film duration
            string[] formatTimes= {"h:mm:ss","hh:mm:ss","h:m:s","mm:ss","m:ss","mm:s","h","hh","h:mm",} ;
            Console.Write("Enter Film Duration: ");
            string filmDurationTime = Console.ReadLine();
            DateTime dateValue;
       
            try
            {
                if (DateTime.TryParseExact(filmDurationTime, formatTimes, new CultureInfo("en-US"),
                        DateTimeStyles.None, out dateValue))
                {
                    movie.FilmDuration = DateTime.Parse(filmDurationTime);
                    
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Wrong");
                goto InputFilmDuration;
            }

            InputFilmReleaseTime:
            DateTime dateValue2;
            string[] formatDateTime= {"dd/mm/yyyy","d/m/yyyy","dd/m/yyyy","d/mm/yyyy" };
            Console.Write("Enter Film Release Time: ");
            string filmReleaseTime = Console.ReadLine();
            //Input Release date
            try
            {
                DateTime parsedDateTime;
                if (DateTime.TryParseExact(filmReleaseTime, formatDateTime, new CultureInfo("en-US"),
                        DateTimeStyles.None, out parsedDateTime))
                {
                    movie.ReleaseDate = DateTime.Parse(filmReleaseTime);
                }
                else
                {
                    goto InputFilmReleaseTime;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The date is not in the correct format!");
                Console.WriteLine("Should be dd/mm/yyyy"); 
                goto InputFilmReleaseTime;
            }

            InputImDbPoints:
            //Input Imdb points
            Console.Write("Enter Imdb points: ");
            movie.TomatoPoints = double.Parse(Console.ReadLine());
            if (movie.TomatoPoints > 10)
            {
                Console.WriteLine("ImdbPoints cannot greater than 10");
                goto  InputImDbPoints;
            }
            //Add to list film
            movies.Add(movie);
            Console.WriteLine("Successfully inserted");
        }
        public void SearchFilmByID(string search)
        {
            bool found = false;
            
            foreach (Movie i in movies)
            {
                if (i.IdFilm.Equals(search))
                {
                    var table = new Table();

                    table.SetHeaders("No", "ID Film", "Name", "Kind", "Director", "MPAA","Film Adaptation","Film Duration", "Release Date","Imdb");
                    table.AddRow($"{i.Id}", i.IdFilm, i.Name, i.Kind, i.Director, i.FilmClassification,i.FilmAdaptation,i.FilmDuration.ToString("hh:mm:ss"),i.ReleaseDate.ToString("dd/MM/yyyy"),i.TomatoPoints.ToString());
                    Console.WriteLine(table.ToString());
                    found = true;
                    break;
                }
            }
            if (!found)
            {
                Console.WriteLine("No Film was found!");
            }        
        }
        
        public void ViewListFilm()
        {
            var table = new Table();

            table.SetHeaders("No", "ID Film", "Name", "Kind", "Director", "MPAA","Film Adaptation","Film Duration", "Release Date","Imdb");

            foreach (Movie i in movies)
            {
                table.AddRow($"{i.Id}", i.IdFilm, i.Name, i.Kind, i.Director, i.FilmClassification,i.FilmAdaptation,i.FilmDuration.ToString("hh:mm:ss"),i.ReleaseDate.ToString("dd/MM/yyyy"),i.TomatoPoints.ToString());
            }
            Console.WriteLine(table.ToString());
            
        }
        public void DeleteFilmByID(string search)
        {
            SearchFilmByID(search);
            var itemToRemove = movies.FirstOrDefault(r => r.IdFilm ==search);
            if (itemToRemove != null)
            {
                movies.Remove(itemToRemove);
                Console.WriteLine("Successfully Deleted"); 
            }
        }
        public void UpdateFilmByID(string search)
        {
             bool found = false;
            
            foreach (Movie i in movies)
            {
                if (i.IdFilm.Equals(search))
                {
                    var table = new Table();

                    table.SetHeaders("No", "ID Film", "Name", "Kind", "Director", "MPAA","Film Adaptation","Film Duration", "Release Date","Imdb");
                    table.AddRow($"{i.Id}", i.IdFilm, i.Name, i.Kind, i.Director, i.FilmClassification,i.FilmAdaptation,i.FilmDuration.ToString("hh:mm:ss"),i.ReleaseDate.ToString("dd/MM/yyyy"),i.TomatoPoints.ToString());
                    Console.WriteLine(table.ToString());
                    found = true;
                    //Input Name of film
                    Console.Write("Enter Name : ");
                    i.Name = Console.ReadLine();
                    //Input Kind
                    Console.Write("Enter Kind of Film: ");
                    i.Kind = Console.ReadLine();
                    //Input Dicertor
                    Console.Write("Enter Director of film: ");
                    i.Director = Console.ReadLine();
                    //Input Film classification
                    Console.Write("Enter Film Classification: ");
                    i.FilmClassification = Console.ReadLine();
                    //Input film adaptation
                    Console.Write("Enter Film Adaption: ");
                    i.FilmAdaptation = Console.ReadLine();
                    //Input Film duration
                    Console.Write("Enter Film Duration: ");
                    i.FilmDuration = DateTime.Parse(Console.ReadLine());
                    //Input Release date
                    Console.Write("Enter Film  Release Date: ");
                    i.ReleaseDate = DateTime.Parse(Console.ReadLine());
                    //Input Imdb points
                    Console.Write("Enter Imdb points: ");
                    i.TomatoPoints = double.Parse(Console.ReadLine());
                    break;
                }
            }
            if (!found)
            {
                Console.WriteLine("No Film was found!");
            }
        }
        public void SoftFilmByID()
        {
            List<Movie> sortedList = movies.OrderBy(o=>o.ReleaseDate).ToList();
            sortedList.Reverse();
            var table = new Table();

            table.SetHeaders("No", "ID Film", "Name", "Kind", "Director", "MPAA","Film Adaptation","Film Duration", "Release Date","Imdb");
            
            foreach (Movie i in sortedList)
            {
                table.AddRow($"{i.Id}", i.IdFilm, i.Name, i.Kind, i.Director, i.FilmClassification,i.FilmAdaptation,i.FilmDuration.ToString("hh:mm:ss"),i.ReleaseDate.ToString("dd/MM/yyyy"),i.TomatoPoints.ToString());
            }
            Console.WriteLine(table.ToString());        
        }
    }
}