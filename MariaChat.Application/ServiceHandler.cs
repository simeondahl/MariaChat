using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MariaChat.Domain;

namespace MariaChat.Application
{
    /// <summary>
    /// This service handler can be used to register instances of types and then call them again
    /// at a later time. It's a custom made service provider.
    /// </summary>
    public static class ServiceHandler
    {
        private static readonly Dictionary<Type, object> Services = new();

        /// <summary>
        /// Register a service to the handler to create an instance of
        /// and keep track off.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <exception cref="Exception"></exception>
        public static void RegisterService<T>()
        {
            var serviceType = typeof(T);

            var instance = Activator.CreateInstance(serviceType); ;

            if (instance == null)
                throw new Exception($"Could not register '{serviceType}'");

            Services.TryAdd(serviceType, instance);
        }

        /// <summary>
        /// Return the requested service based on the type.
        /// </summary>
        /// <typeparam name="T">Type of service</typeparam>
        /// <returns>The instance</returns>
        /// <exception cref="Exception">If there are no services with the type requested
        /// it will throw an exception.</exception>
        public static T GetService<T>()
        {
            var serviceType = typeof(T);

            Services.TryGetValue(serviceType, out var service);

            if (service == null)
                throw new Exception($"'{serviceType}' is not registered.");

            return (T)service;
        }
    }
}
