using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TooEnsure.Lib.Client.Models.Article
{
    public class Post
    {
        private static int currentPostId;
        protected int ID { get; set; }
        public int UserId { get; set; }
        protected DateTime PostDate { get; }
    }
}
