using JeBackend.Core.Interfaces;
using JeBackend.Core.Services;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Api
{
public class NinjectRegistrations : NinjectModule
        {
            public override void Load()
            {
                Bind<IRestaurantService>().To<RestaurantService>();
            }

            

        }
 
}