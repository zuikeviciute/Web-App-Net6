using System;
using System.Collections.Generic;
using System.Linq;

using ChinookContext;
using ChinookEntities;

namespace Project.Models
{
    public class TracksViewModel
    {
        public List<Track> Tracks {get; set;}
        public List<Album> Albums {get; set;}
        public List<Artist> Artists {get; set;}
        public String albumTitle {get; set;}
        public String artistName {get; set;}
    }
}