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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class autoservice_kpEntities : DbContext
    {
        public autoservice_kpEntities()
            : base("name=autoservice_kpEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AutoserviceNikit> AutoserviceNikit { get; set; }
        public virtual DbSet<CompanyNikit> CompanyNikit { get; set; }
        public virtual DbSet<ContractsNikit> ContractsNikit { get; set; }
        public virtual DbSet<RoleNikit> RoleNikit { get; set; }
    }
}
