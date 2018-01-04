using Autofac;
using System;

namespace autofac_tutorial
{
    class Program
    {
        private static IContainer Container { get; set; }

        static void Main(string[] args)
        {

            var builder = new ContainerBuilder();

            builder.RegisterType<ConsoleOutput>().As<IOutput>();
            builder.RegisterType<SystemIOFileReader>().As<IFileReader>();

            Container = builder.Build();

            Console.WriteLine("Gimme filepath:");
            string filePath = Console.ReadLine();

            ReadFileContents(filePath);

            Console.ReadKey();
        }



        private static void ReadFileContents(string filePath)
        {
            using (var scope = Container.BeginLifetimeScope())
            {
                var reader = scope.Resolve<IFileReader>();
                var output = scope.Resolve<IOutput>();

                output.Output(reader.ReadFile(filePath));
            }
        }
    }
}
