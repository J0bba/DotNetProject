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
    
    public partial class T_Article
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public T_Article()
        {
            this.T_Article_Attach = new HashSet<T_Article_Attach>();
            this.T_Article_Image = new HashSet<T_Article_Image>();
            this.T_Comment = new HashSet<T_Comment>();
            this.T_Translation = new HashSet<T_Translation>();
            this.T_User_Like = new HashSet<T_User_Like>();
        }
    
        public long id { get; set; }
        public string title { get; set; }
        public string content { get; set; }
        public long id_creator { get; set; }
        public System.DateTime created_date { get; set; }
        public bool validated { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_Article_Attach> T_Article_Attach { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_Article_Image> T_Article_Image { get; set; }
        public virtual T_User T_User { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_Comment> T_Comment { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_Translation> T_Translation { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_User_Like> T_User_Like { get; set; }
    }
}