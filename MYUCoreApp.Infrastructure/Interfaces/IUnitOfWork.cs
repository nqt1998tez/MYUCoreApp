using System;

namespace MYUCoreApp.Infrastructure.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        /// <summary>
        /// Call save change  from db Context
        /// </summary>
        void Commit();
    }
}
