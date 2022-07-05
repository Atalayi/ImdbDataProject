using System;
using System.Collections.Generic;

#nullable disable

namespace ImdbDataProject.Models
{
    public partial class Tblmovie
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Picture { get; set; }
        public string Explanation { get; set; }
        public string Director { get; set; }
        public string Writer { get; set; }
        public string Stars { get; set; }
    }
}
