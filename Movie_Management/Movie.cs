using System;
using ManageMovie.Interface;

namespace ManageMovie.Classes
{   
    public class Movie : IMovie
    {
        private int idFilm;
        private string name;
        private string kind;
        private string director;
        private string filmDuration;
        private string releaseDate;
        private double tomatoRate;

        public Movie( int idFilm, string name, string kind, string director, string filmDuration, string releaseDate, double tomatoRate)
        {
            this.IdFilm = idFilm;
            this.Name = name;
            this.Kind = kind;
            this.Director = director;
            this.FilmDuration = filmDuration;
            this.ReleaseDate = releaseDate;
            this.TomatoRate =tomatoRate;
        }

    

        public int IdFilm { get => idFilm; set => idFilm = value; }
        public string Name { get => name; set => name = value; }
        public string Kind { get => kind; set => kind = value; }
        public string Director { get => director; set => director = value; }
        public string FilmDuration { get => filmDuration; set => filmDuration = value; }
        public string ReleaseDate { get => releaseDate; set => releaseDate = value; }
        public virtual double TomatoRate
        {
            get => tomatoRate; 
            set => tomatoRate = value;
        }
        
      
        public string  ViewInforMovies()
        {
            return $"{GetType()} \t ID: {IdFilm} | Name:{Name} | Kind: {Kind} | Director: {Director} | Film Duration: {FilmDuration} | Release Date: {ReleaseDate} | TomatoRate: {TomatoRate}% \n";

        }

       
    }
}