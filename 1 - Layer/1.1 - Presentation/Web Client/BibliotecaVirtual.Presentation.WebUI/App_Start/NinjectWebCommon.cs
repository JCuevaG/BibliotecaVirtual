[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(BibliotecaVirtual.Presentation.WebUI.App_Start.NinjectWebCommon), "Start")]
[assembly: WebActivatorEx.ApplicationShutdownMethodAttribute(typeof(BibliotecaVirtual.Presentation.WebUI.App_Start.NinjectWebCommon), "Stop")]

namespace BibliotecaVirtual.Presentation.WebUI.App_Start
{
    using System;
    using System.Web;

    using Microsoft.Web.Infrastructure.DynamicModuleHelper;

    using Ninject;
    using Ninject.Web.Common;
    using BibliotecaVirtual.Domain.Interfaces.Services;
    using BibliotecaVirtual.Domain.Services;
    using BibliotecaVirtual.Domain.Interfaces.Repositories;
    using BibliotecaVirtual.Data.Repositories;
    using BibliotecaVirtual.Data.Context;

    public static class NinjectWebCommon 
    {
        private static readonly Bootstrapper bootstrapper = new Bootstrapper();

        /// <summary>
        /// Starts the application
        /// </summary>
        public static void Start() 
        {
            DynamicModuleUtility.RegisterModule(typeof(OnePerRequestHttpModule));
            DynamicModuleUtility.RegisterModule(typeof(NinjectHttpModule));
            bootstrapper.Initialize(CreateKernel);
        }
        
        /// <summary>
        /// Stops the application.
        /// </summary>
        public static void Stop()
        {
            bootstrapper.ShutDown();
        }
        
        /// <summary>
        /// Creates the kernel that will manage your application.
        /// </summary>
        /// <returns>The created kernel.</returns>
        private static IKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            try
            {
                kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
                kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();

                RegisterServices(kernel);
                return kernel;
            }
            catch
            {
                kernel.Dispose();
                throw;
            }
        }

        /// <summary>
        /// Load your modules or register your services here!
        /// </summary>
        /// <param name="kernel">The kernel.</param>
        private static void RegisterServices(IKernel kernel)
        {
            kernel.Bind<BibliotecaVirtualContext>().ToSelf().InRequestScope();

            kernel.Bind(typeof(IServiceBase<>)).To(typeof(ServiceBase<>)).InRequestScope();
            kernel.Bind<ILibroService>().To<LibroService>().InRequestScope();
            kernel.Bind<ICategoriaService>().To<CategoriaService>().InRequestScope();

            kernel.Bind(typeof(IRepositoryBase<>)).To(typeof(RepositoryBase<,>)).InRequestScope();
            kernel.Bind<ILibroRepository>().To<LibroRepository>().InRequestScope().WithConstructorArgument("context", kernel.Get<BibliotecaVirtualContext>());
        }        
    }
}
