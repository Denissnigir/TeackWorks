//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TeackWorks.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class NewOrder
    {
        public int Id { get; set; }
        public Nullable<int> ServiceTypeId { get; set; }
        public Nullable<int> ServiceId { get; set; }
        public Nullable<int> ClientId { get; set; }
        public string PhoneNumber { get; set; }
    
        public virtual Client Client { get; set; }
        public virtual Service Service { get; set; }
        public virtual TypeService TypeService { get; set; }
    }
}
