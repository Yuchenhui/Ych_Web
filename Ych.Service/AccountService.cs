using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ych.Base;
using Ych.Interface;
using Ych.Model;

namespace Ych.Service
{
    public class AccountService : IAccount
    {
        public bool CreateAccount(Account account)
        {
            var collection = MongoDb.Instance.GetCollection<Account>();
            var result = collection.Insert(account);
            return result.Ok;
        }
    }
}
