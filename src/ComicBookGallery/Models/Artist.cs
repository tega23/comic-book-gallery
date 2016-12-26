using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ComicBookGallery.Models
{
    public class Artist
    {
        public static int Total { get; set; }
        public Artist()
        {
            Total += 1;
        }
        public string Name { get; set; }
        public string Role { get; set; }
    }
}