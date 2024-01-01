using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using WebApplication1.Models;

namespace WebApplication1.Service
{
	public class messageDBService
	{
		//public WebApplication1.Models.db1Entities db =new Models.db1Entities();
		public WebApplication1.Models.db1Entities1 db = new db1Entities1();
		public List<Article> GetData()
		{
			return(db.Articles.ToList());
		}

		public void DBCreate(string Article_title, string Content)
		{
			Article NewData = new Article();
			NewData.Title=Article_title;
			NewData.Content=Content;
			NewData.time=DateTime.Now;

			db.Articles.Add(NewData);

			db.SaveChanges();
		}
	}
}