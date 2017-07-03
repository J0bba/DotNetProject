using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MeditateBook.Models
{
    public class EditArticleModels
    {
    }

    public class EditArticleModel
    {
        [Required]
        [Display(Name = "Title")]
        public string Title { get; set; }

        [Required]
        [Display(Name = "Content")]
        public string Content { get; set; }
    }

    public class TradArticleModel
    {
        public string content = "";
        public string title = "";
        
        public TradArticleModel(DBO.Article article)
        {
            this.content = article.Content;
            this.title = article.Title;
        }

        public TradArticleModel()
        {
        }

        [Required]
        [Display(Name = "Title")]
        public long Id { get; set; }

        [Required]
        [Display(Name = "Title")]
        public string Title { get; set; }

        [Required]
        [Display(Name = "Content")]
        public string Content { get; set; }
    }
}