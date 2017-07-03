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

        [Display(Name = "Image")]
        public String ImagePath { get; set; }

        public List<DBO.ArticleAttach> listAttach;
    }

    public class TradArticleModel
    {
        [Required]
        [Display(Name = "contentOriginal")]
        public string contentOriginal { get; set; }

        [Required]
        [Display(Name = "titleOriginal")]
        public string titleOriginal { get; set; }


        [Required]
        [Display(Name = "IdOriginal")]
        public long IdOriginal { get; set; }

        [Required]
        [Display(Name = "Content")]
        public string Content { get; set; }

        [Required]
        [Display(Name = "Langue")]
        public int Langue { get; set; }

        
        public List<DBO.Language> listLangues;
    }
}