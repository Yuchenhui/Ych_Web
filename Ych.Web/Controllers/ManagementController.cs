using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MongoDB.Bson;
using MongoDB.Driver.Builders;
using Ych.Base;
using Ych.Interface;
using Ych.Model;
using Ych.Model.Enum;
using Ych.Service;

namespace Ych.Web.Controllers
{
    public class ManagementController : Controller
    {
        //
        // GET: /Management/


        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Articles()
        {
            return View();
        }

        public ActionResult CreateArticle()
        {
            var typeCollection = Ych.Base.MongoDb.Instance.GetCollection<ArticleType>();
            var info = typeCollection.FindAllAs<ArticleType>();
            SelectList selectList = new SelectList(info.ToList(),"TypeId","TypeName");
            ViewBag.TypeList = selectList;
            ViewBag.StatusList = CreateStatusList();
            return View();
        }

        [HttpPost]
        public ActionResult ArticlePost(Article article)
        {
            var collection = Ych.Base.MongoDb.Instance.GetCollection<Article>();
            article.PostDate = DateTime.Now;
            article.IsOpenComment = true;
            //var collection = Ych.Base.MongoDb.Instance.GetCollection<Article>();
            var result = collection.Insert(article);
            return View(result.Ok);
        }

        private SelectList CreateStatusList()
        {
            Dictionary<int,string> statusList= new Dictionary<int, string>();
            statusList.Add(1, "Publish");
            statusList.Add(2, "Delete");
            statusList.Add(3, "Locked");
            statusList.Add(4, "Hidden");
            return new SelectList(statusList,"key","value");
        }

        public ActionResult Accounts()
        {
            return View();
        }

        public ActionResult CreateAccount()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AccountPost(Account account)
        {
            IAccount iAccount = new AccountService();
            account.Password = account.Password.ToPassword();
            return Json(iAccount.CreateAccount(account));
        }

    }
}
