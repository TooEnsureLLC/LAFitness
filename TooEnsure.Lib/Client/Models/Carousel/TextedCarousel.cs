using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TooEnsure.Lib.Client.Models.Carousel
{
    public class TextedCarousel
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public string BtnText { get; set; }

        public TextedCarousel()
        {
            Console.WriteLine("Texted Carousel Init");
        }
        public TextedCarousel(int id, string text, string btnText) {
            this.Id = id;
            this.Text = text;
            this.BtnText = btnText;
        }
    }

    
}
