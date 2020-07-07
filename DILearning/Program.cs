using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using DemoLibrary;


namespace DILearning
{
    class Program
    {
        public static void Main(string[] args)
        {
            //BusinessLogic businessLogic = new BusinessLogic();
            var container = ContainerConfig.Configure();

            using(var scope = container.BeginLifetimeScope())
            {
                var app = scope.Resolve<IApplication>();
                app.Run();
            }
            
            Console.ReadLine();
        }
    }
}
