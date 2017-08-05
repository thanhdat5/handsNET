using System;

namespace handsNET.Data.Infrastructure
{
    public interface IDbFactory : IDisposable
    {
        handsNETDbContext Init();
    }
}