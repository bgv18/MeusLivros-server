using MeusLivros.Domain;
using MeusLivros.Service.Interface;
using RabbitMQ.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace MeusLivros.Service.Service
{
    public class LivroService : ILivro
    {
        public bool CreateLivro(Livro livro)
        {
            var factory = new ConnectionFactory()
            {
                HostName = "localhost"
            };

            using (var connection = factory.CreateConnection())
            {
                using(var channel = connection.CreateModel())
                {
                    channel.QueueDeclare(queue: "createLivro",
                                         durable: false,
                                         exclusive: false,
                                         autoDelete: false,
                                         arguments: null);

                    var body = Encoding.UTF8.GetBytes(JsonSerializer.Serialize(livro));

                    channel.BasicPublish(exchange: "",
                                         routingKey: "createLivro",
                                         basicProperties: null, 
                                         body: body);
                    Console.WriteLine("Mensagem enviada!");
                    return true;
                }
            }
            
        }
    }
}
