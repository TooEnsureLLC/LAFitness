using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TooEnsure.Lib.Client.Models.Pages
{
    public class ArticlePage
    {
        [Required] public string ImageUri { get; set; }
        [Required] public string Title { get; set; }
        [Required] public string Content { get; set; }
    }
}
