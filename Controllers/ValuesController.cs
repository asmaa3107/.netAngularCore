using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using fullControl.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace fullControl.Controllers {
    [Route ("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase {

        cmsContext _context;
        public ValuesController (cmsContext context) {
            _context = context;
        }
        // GET api/values
        [HttpGet]
        public async Task<IEnumerable<ArticleData>> Get () {
            var result = from a in _context.Article
            join al in _context.ArticleLanguage
            on a.ArticleId equals al.FkArticleId

            where al.LangName == "ar"
            select new ArticleData {
                ArticleId = a.ArticleId,
                ArticleTitle = al.Title,
                ImagePath = a.ImagePath,
                published = a.IsPublished
            };
            //for one table
            //return _context.Article.ToList();
            return await result.ToListAsync<ArticleData> ();
        }

        // GET api/values/5
        [HttpGet ("{id}")]
        public async Task<ArticleData> Get (int id) {
            ArticleData reslt = await (from ar in _context.Article from arl in _context.ArticleLanguage 
            where ar.ArticleId == id &&ar.ArticleId==arl.FkArticleId&&
                arl.LangName == "ar"
                orderby ar.ArticleId select new ArticleData () {
                    ArticleId = ar.ArticleId,
                        ArticleTitle = arl.Title,
                        published = ar.IsPublished,
                        ImagePath = ar.ImagePath
                }).FirstOrDefaultAsync ();
                
            return reslt;
        }

        // POST api/values
        [HttpPost]
        public void Post ([FromBody] string value) { }

        // PUT api/values/5
        [HttpPut ("{id}")]
        public void Put (int id, [FromBody] string value) { }

        // DELETE api/values/5
        [HttpDelete ("{id}")]
        public void Delete (int id) { }

        // GET api/values
        //[HttpGet]
        //public ActionResult<IEnumerable<string>> Get1()
        //{
        //    return new string[] { "value1", "value2" };
        //}

    } //class controller

    #region Classes
    public class ArticleData {
        public int? ArticleId { get; set; }
        public string ArticleTitle { get; set; }
        public bool? published { get; set; }
        public string ImagePath { get; set; }
    }

    #endregion
} //namespace