using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using RabbitMqConfiguration;
using System;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using RabbitMqAPI.Services;

namespace RabbitMqAPI.Consumer
{
    public class RabbitConsumer : BackgroundService
    {
        private readonly RabbitConfiguration _config;
        private readonly IConnection _conexao;
        private readonly IModel _canal;
        private readonly IServiceProvider _serviceProvider;

        public RabbitConsumer(IOptions<RabbitConfiguration> options, IServiceProvider serviceProvider)
        {
            _config = options.Value;
            _serviceProvider = serviceProvider;

            var factory = new ConnectionFactory
            {
                HostName = "localhost",
                UserName = "guest",
                Password = "guest",
                VirtualHost = "/",
                AutomaticRecoveryEnabled = true
            };

            _conexao = factory.CreateConnection();
            _canal = _conexao.CreateModel();
            _canal.QueueDeclare(
                 queue: _config.Queue,
                 durable: false,
                 exclusive: false,
                 autoDelete: false,
                 arguments: null
                );
        }


        protected override Task ExecuteAsync(CancellationToken stoppingToken)
        {
            var consumer = new EventingBasicConsumer(_canal);

            consumer.Received += (sender, eventArgs) =>
            {
                var contentArray = eventArgs.Body.ToArray();
                var contentString = Encoding.UTF8.GetString(contentArray);
                var mensagem = JsonConvert.DeserializeObject<RabbitMqMensagem>(contentString);

                NotificarUsuario(mensagem);

                _canal.BasicAck(eventArgs.DeliveryTag, false);
            };

            _canal.BasicConsume(_config.Queue, false, consumer);

            return Task.CompletedTask;
        }

        protected void NotificarUsuario(RabbitMqMensagem mensagem)
        {
            using(var scope = _serviceProvider.CreateScope())
            {
                var notificacao = scope.ServiceProvider.GetRequiredService<NotificacaoService>();

                notificacao.NotificarUsuario(mensagem.DthMensagem, mensagem.Conteudo);
            }
        }

    }
}
