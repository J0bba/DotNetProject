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
    
    public partial class T_Comment
    {
        public long id { get; set; }
        public string content { get; set; }
        public long id_user { get; set; }
        public long id_article { get; set; }
        public System.DateTime date { get; set; }
    
        public virtual T_Article T_Article { get; set; }
        public virtual T_User T_User { get; set; }
    }
}
