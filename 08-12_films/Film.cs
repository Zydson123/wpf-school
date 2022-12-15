using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08._12_pies_hau
{
    public class Film
    {
        public string Name { get; set; }
        public int Rating { get; set; }
        public string Description { get; set; }
        public string Genre { get; set; }
        public bool wasWatched { get; set; }

        public Film(string name, int rating, string description, string genre)
        {
            Name = name;
            Rating = rating;
            Description = description;
            Genre = genre;
            wasWatched = false;
        }

    }
}
