using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class Album
    {


        public Guid ID { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public DateTime ReleaseDate { get; set; }
        public List<Song> Songs { get; set; }
    }
}
