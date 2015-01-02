using System;
using System.Collections.Generic;
using System.Web.Http.Dependencies;
using Microsoft.Practices.Unity;

namespace BeerUAPI
{
    public class ScopeContainer : IDependencyScope
    {
        protected IUnityContainer container;

        public ScopeContainer(IUnityContainer container)
        {
            if (container == null)
            {
                throw new ArgumentNullException("container");
            }
            this.container = container;
        }

        public object GetService(Type serviceType)
        {
            if (container.IsRegistered(serviceType))
            {
                return container.Resolve(serviceType);
            }
            return null;
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            if (container.IsRegistered(serviceType))
            {
                return container.ResolveAll(serviceType);
            }
            return new List<object>();
        }

        public void Dispose()
        {
            container.Dispose();
        }
    }

    internal class IoCContainer : ScopeContainer, IDependencyResolver
    {
        public IoCContainer(IUnityContainer container)
            : base(container)
        {
        }

        public IDependencyScope BeginScope()
        {
            IUnityContainer child = container.CreateChildContainer();
            return new ScopeContainer(child);
        }
    }
}