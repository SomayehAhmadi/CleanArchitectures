﻿namespace CleanArchitecture.Domain.Entities.EnumType
{
    public enum LaunchMethods
    {
        None = 0,
        Unknown = 1,
        Winch = 2,
        Aerotow = 4,
        TowPlane = 8,
        OnTow = 16,
        Self = 32
    }
}
