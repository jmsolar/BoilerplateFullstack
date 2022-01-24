using System;

namespace BoilerplateFullstack.Domain.Entities.Base
{
    public abstract class BaseEntity
    {
        public Guid Id { get; set; }
    }
}
