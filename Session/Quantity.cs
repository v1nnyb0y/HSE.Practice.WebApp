//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Requests
{
    using System;
    using System.Collections.Generic;
    
    public partial class Quantity
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Quantity()
        {
            this.Options = new HashSet<Option>();
        }
    
        public int ID { get; set; }
        public string Name { get; set; }
        public string Postfix { get; set; }
        public string Min { get; set; }
        public string Max { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Option> Options { get; set; }
    }
}
