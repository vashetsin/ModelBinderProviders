﻿using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Configuration.ModelBinderProviders.JsonBinder.Internal
{
    internal class JsonModelBinderProvider : IModelBinderProvider
    {
        public IModelBinder GetBinder(ModelBinderProviderContext context)
        {
            if (context == null) throw new ArgumentNullException(nameof(context));

            if (context.Metadata.IsComplexType)
            {
                var propName = context.Metadata.PropertyName;
                var propInfo = context.Metadata.ContainerType?.GetProperty(propName);
                if (propName == null || propInfo == null)
                    return null;
                // Look for FromJson attributes
                var attribute = propInfo.GetCustomAttributes(typeof(FromJsonAttribute), false).FirstOrDefault();
                if (attribute != null)
                    return new JsonModelBinder(context.Metadata.ModelType, attribute as IJsonAttribute);
            }
            return null;
        }
    }
}
