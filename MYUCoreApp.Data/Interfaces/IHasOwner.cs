using System;
using System.Collections.Generic;
using System.Text;

namespace MYUCoreApp.Data.Interfaces
{
    public interface IHasOwner<T>
    {
        T OwnerId { set; get; }


    }
}
