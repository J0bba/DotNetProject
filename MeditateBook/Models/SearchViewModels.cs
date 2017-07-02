using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MeditateBook.Models
{

    public class SearchViewModel
    {
        public string searchedText { get; set; }
        public List<DBO.Article> Results { get; set; }
    }
}
