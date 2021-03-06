using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ListaToDo.Services
{
    public class WriteToFileHostedService : IHostedService, IDisposable
    {
        private readonly IHostEnvironment environment;
        private readonly string filename = "file1.txt";
        private Timer timer;

        public WriteToFileHostedService(IHostEnvironment environment)
        {
            this.environment = environment;

        }


        public Task StartAsync(CancellationToken cancellationToken)
        {
            WriteToFile("Proceso iniciado");
            timer = new Timer(DoWork, null, TimeSpan.Zero, TimeSpan.FromHours(5));
            return Task.CompletedTask;
        }


        private void DoWork(object state)
        {
            WriteToFile("WriteToFileHostedServices: Doing SomeWork at" + DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss"));            
        }


        public Task StopAsync(CancellationToken cancellationToken)
        {
            WriteToFile("Proceso detenido");
            timer.Change(Timeout.Infinite, 0);
            return Task.CompletedTask;
        }

        private void WriteToFile(string message)
        {
            var path = $@"{environment.ContentRootPath}\wwwroot\{filename}";
            using (StreamWriter writer = new StreamWriter(path, append: true))
            {
                writer.WriteLine(message);
            }
        }

        public void Dispose()
        {
            timer?.Dispose();
        }
    }
}