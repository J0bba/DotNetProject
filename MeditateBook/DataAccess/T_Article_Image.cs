//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MeditateBook.DataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class T_Article_Image
    {
        public long id { get; set; }
        public long id_article { get; set; }
        public string image_path { get; set; }
        public string name { get; set; }
    
        public virtual T_Article T_Article { get; set; }
    }
}
