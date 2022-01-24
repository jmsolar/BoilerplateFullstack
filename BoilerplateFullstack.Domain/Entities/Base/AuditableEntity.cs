using System;

namespace BoilerplateFullstack.Domain.Entities.Base
{
    public abstract class AuditableEntity : BaseEntity
    {
        public Guid CreatedBy { get; set; }
        public Guid ModifiedBy { get; set; }
        public DateTime Created { get; set; }
        public DateTime LastModified { get; set; }
    }
}
