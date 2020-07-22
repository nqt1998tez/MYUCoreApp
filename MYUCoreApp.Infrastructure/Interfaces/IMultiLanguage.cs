using System;
using System.Collections.Generic;
using System.Text;

namespace MYUCoreApp.Infrastructure.Interfaces
{
    public interface IMultiLanguage<T>
    {
        T LanguageId { get; set; }

    }
}
