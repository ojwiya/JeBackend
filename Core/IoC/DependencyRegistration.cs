using JeBackend.Core.Interfaces;
using JeBackend.Core.Services;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeBackend.Core.IoC
{
    public class DependencyRegistration: Ninject.Modules.NinjectModule
    {
            public override void Load()
            {
                Ninject.IKernel kernal = new StandardKernel();  
                Bind<IRestaurantService>().To<RestaurantService>();
            }

    }
}
