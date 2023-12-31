using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using WebApplication1.Models;

namespace WebApplication1.Service
{
	public class messageDBService
	{
		public WebApplication1.Models.db1Entities db =new Models.db1Entities();
		public List<Article> GetData()
		{
			return(db.Articles.ToList());
		}

		public void DBCreate(string Article_title, string Content)
		{
			Article New = new Article();
			New.Title=Article_title;
			New.Content=Content;
			New.time=DateTime.Now;
			db.Articles.Add(New);
			db.SaveChanges();
		}
	}
}