//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NikitKursa4
{
    using System;
    using System.Collections.Generic;
    
    public partial class CompanyNikit
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CompanyNikit()
        {
            this.ContractsNikit = new HashSet<ContractsNikit>();
        }
    
        public int Id { get; set; }
        public string Service { get; set; }
        public Nullable<System.DateTime> Duration { get; set; }
        public string Photo { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContractsNikit> ContractsNikit { get; set; }
    }
}
