using Application.Core.Services.Cars;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Configuration.ModelBinderProviders.JsonBinder.Internal;

namespace WebApi.ViewModels
{
    public class ManageCarViewModel
    {
        [FromJson]
        public ManageCarDto Car { get; set; }
        public IFormFile MainImage { get; set; }
        public IEnumerable<IFormFile> Images { get; set; }
    }
}
