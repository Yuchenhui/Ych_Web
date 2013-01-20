using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using MongoDB.Bson;
using Ych.Model.Enum;

namespace Ych.Model
{
    public class Article
    {

        public ObjectId _id;

        public int ArticleId { get; set; }

        [Display(Name = "Article Title")]
        public string Title { get; set; }

        [Display(Name = "Article Content")]
        public string Content { get; set; }

        [Display(Name = "Article Type")]
        public Guid TypeId { get; set; }

        public DateTime PostDate { get; set; }

        public Guid Poster { get; set; }

        public int Status { get; set; }

        public bool IsOpenComment { get; set; }
    }
}
