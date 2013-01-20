using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MongoDB.Bson;
using System.ComponentModel.DataAnnotations;

namespace Ych.Model
{
    public class Account
    {
        private Account()
        {
            CreateDate = DateTime.Now;
            AccountId = Guid.NewGuid();
        }

        public ObjectId _id;

        public Guid AccountId { get; set; }
        [Display(Name = "Login Name:")]
        public string LoginName { get; set; }
        [Display(Name = "Password:")]
        public string Password { get; set; }

        public DateTime CreateDate { get; set; }
    }
}
