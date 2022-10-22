using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Net.Mail;
using ManageMovie.Interface;
using Microsoft.SqlServer.Server;

namespace ManageMovie.Classes
{
    public class Film : Movie
    {
        
        // public through get set
        public Film(int id, string name, string idFilm, string kind, string director, string filmClassification, string filmAdaptation, DateTime filmDuration, DateTime releaseDate, double tomatoPoints) :
            base(id, name, kind, idFilm,director,filmClassification, filmAdaptation, filmDuration, releaseDate, tomatoPoints)
        {
            this.TomatoPoints = tomatoPoints;
        }
        public override double  TomatoPoints { get => base.TomatoPoints * 100; set => base.TomatoPoints = value; }

        

        //"No", "ID Film", "Name", "Kind", "Director", "Film Classification","Film Adaptation","Film Duration", "Film Release Date","Imdb point","Review"
        

       

        
     
       

        
    }
}