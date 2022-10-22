using System;
using ManageMovie.Interface;

namespace ManageMovie.Classes
{   
    public class Movie : IMovie
    {
        private int id;
        private string name;
        private string kind;
        private string idFilm;
        private string director;
        private string filmClassification;
        private string filmAdaptation;
        private DateTime filmDuration;
        private DateTime releaseDate;
        private double tomatoPoints;

        public Movie(int id, string name, string kind, string idFilm, string director, string filmClassification, string filmAdaptation, DateTime filmDuration, DateTime releaseDate, double tomatoPoints)
        {
            this.Id = id;
            this.Name = name;
            this.Kind = kind;
            this.IdFilm = idFilm;
            this.Director = director;
            this.FilmClassification = filmClassification;
            this.FilmAdaptation = filmAdaptation;
            this.FilmDuration = filmDuration;
            this.ReleaseDate = releaseDate;
            this.TomatoPoints = tomatoPoints;
        }

        public Movie()
        {
        }


        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Kind { get => kind; set => kind = value; }
        public string Director { get => director; set => director = value; }
        public string FilmClassification { get => filmClassification; set => filmClassification = value; }
        public string FilmAdaptation { get => filmAdaptation; set => filmAdaptation = value; }
        public DateTime FilmDuration { get => filmDuration; set => filmDuration = value; }
        public DateTime ReleaseDate { get => releaseDate; set => releaseDate = value; }
        public string IdFilm { get => idFilm; set => idFilm = value; }
        public virtual double TomatoPoints { get => tomatoPoints; set => tomatoPoints = value; }
        
      
        public void ViewListFilm()
        {
            var table = new Table();
            table.SetHeaders("No", "ID Film", "Name", "Kind", "Director", "MPAA","Film Adaptation","Film Duration", "Release Date","Imdb");
            table.AddRow($"{Id}", IdFilm, Name, Kind, Director, FilmClassification,FilmAdaptation,FilmDuration.ToString("hh:mm:ss"), ReleaseDate.ToString("dd/MM/yyyy"),TomatoPoints.ToString());
            Console.WriteLine(table.ToString());

        }

       
    }
}