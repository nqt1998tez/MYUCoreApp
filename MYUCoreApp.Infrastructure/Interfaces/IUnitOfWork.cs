using System;
using System.Collections.Generic;
using System.Text;

namespace MYUCoreApp.Infrastructure.Interfaces
{
    public interface IUnitOfWork:IDisposable
    {
        /// <summary>
        /// Call save change  from db Context
        /// </summary>
        void Commit();
    }
}
