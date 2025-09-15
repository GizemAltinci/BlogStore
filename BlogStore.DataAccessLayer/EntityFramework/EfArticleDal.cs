using BlogStore.DataAccessLayer.Abstract;
using BlogStore.DataAccessLayer.Context;
using BlogStore.DataAccessLayer.Repositories;
using BlogStore.EntityLayer.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogStore.DataAccessLayer.EntityFramework
{
    public class EfArticleDal : GenericRepository<Article>, IArticleDal
    {
        private readonly BlogContext _context;
        public EfArticleDal(BlogContext context) : base(context)
        {
            _context = context;
        }

        public AppUser GetAppUserByArticleId(int id)
        {
            string userId = _context.Articles.Where(x => x.ArticleId == id).Select(y => y.AppUserId).FirstOrDefault();
            var userValue = _context.Users.Where(x => x.Id == userId).FirstOrDefault();
            return userValue;
            //Bu metot, verilen bir makale ID’si üzerinden önce AppUserId'yi alıyor, sonra Users tablosuna gidip bu ID’ye sahip kullanıcıyı buluyor ve döndürüyor.
        }

        public List<Article> GetArticlesByAppUser(string id)
        {
            return _context.Articles.Where(x=>x.AppUserId == id).ToList();
        }

        public List<Article> GetArticlesWithCategories()
        {
            return _context.Articles.Include(x=>x.Category).ToList();
        }

        public List<Article> GetTop3PopulerArticles()
        {
            //Veritabanındaki Articles tablosuna git, ArticleId'ye göre azalan sırala, ilk 3 taneyi al ve geri döndür.
            var values =_context.Articles.OrderByDescending(x=>x.ArticleId).Take(3).ToList();
            return values;
            
        }
    }
}
