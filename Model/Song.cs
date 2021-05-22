using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class Song
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public Guid AlbumID { get; set; }

        public float Duration { get; set; }
    }
}
