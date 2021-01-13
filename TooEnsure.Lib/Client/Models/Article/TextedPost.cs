using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TooEnsure.Lib.Client.Models.Article
{
    public class TextedPost
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

        public TextedPost()
        {
            Console.WriteLine("Texted post created");
        }
       public TextedPost(int id, string title, string content)
        {
            this.ID = id;
            this.Title = title;
            this.Content = content;
        }

    }


}
