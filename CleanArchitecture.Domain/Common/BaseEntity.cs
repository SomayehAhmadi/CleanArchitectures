﻿namespace CleanArchitecture.Domain.Common;

public abstract class BaseEntity
{
    public long Id { get; set; }
    public DateTimeOffset DateCreated { get; set; }
    public DateTimeOffset? DateUpdated { get; set; }
    public DateTimeOffset? DateDeleted { get; set; }
}