using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Configuration.ModelBinderProviders.JsonBinder.Internal
{
    internal interface IJsonAttribute
    {
        object TryConvert(string modelValue, Type targertType, out bool success);
    }
}
