using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using MongoDB.Bson;
using Ych.Model.Enum;

namespace Ych.Model
{
    public class ArticleType
    {

        public ObjectId _id;

        [Display(Name = "Type Name")]
        public string TypeName { get; set; }

        public Guid TypeId { get; set; }

        public DateTime CreateDate { get; set; }

        [Display(Name = "Type Name")]
        public int Status { get; set; }

        public Guid ParentId { get; set; }

    }
}
