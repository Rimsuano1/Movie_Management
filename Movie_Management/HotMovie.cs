using System;
using ManageMovie.Classes;

namespace Movie_Management
{
    public class HotMovie : Movie
    {
        // public through get set
        public HotMovie(int idFilm, string name,  string kind, string director, string filmDuration, string releaseDate, double tomatoRate):
            base(idFilm,name, kind, director, filmDuration, releaseDate, tomatoRate)
        {
            
        }

        public override double TomatoRate
        {
            get => (base.TomatoRate * 0.1) + base.TomatoRate;
            set => base.TomatoRate = value;
        }
        

    }
}