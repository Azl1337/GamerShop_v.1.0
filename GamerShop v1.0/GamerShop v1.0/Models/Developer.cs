//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GamerShop_v1._0.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Developer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Developer()
        {
            this.Games = new HashSet<Game>();
        }
    
        public byte IdDeveloper { get; set; }
        public string NameDevCorp { get; set; }
        public string DevDescription { get; set; }
        public string DevDirectorLastName { get; set; }
        public string DevDirectorName { get; set; }
        public string DevDirectorPatronymic { get; set; }
        public Nullable<System.DateTime> DateOfDevCorpWasFounded { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Game> Games { get; set; }
    }
}