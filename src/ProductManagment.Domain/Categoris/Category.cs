using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace ProductManagment.Categoris;

public class Category:AuditedAggregateRoot<Guid>
{
    public string Name { get; set; }
}