using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace BloomiBlanket.Models
{
    public class MovieGenreViewModel
    {
        public List<Blanket> Blankets { get; set; }
        public SelectList Fabric{ get; set; }
        public string BlanketFabric { get; set; }
        public string SearchString { get; set; }
    }
}