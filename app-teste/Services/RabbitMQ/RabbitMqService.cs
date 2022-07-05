using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using RabbitMQ.Client;
using RabbitMqConfiguration;
using System.Text;

namespace app_teste.Services.RabbitMQ
{
    public class RabbitMqService
    {
        #region ' Variaveis '
        private readonly ConnectionFactory _factory;
        private readonly RabbitConfiguration _config;

        public RabbitMqService(IOptions<RabbitConfiguration> options)
        {
            _config = options.Value;
            _factory = new ConnectionFactory {
                HostName = "localhost",
                UserName = "guest",
                Password = "guest",
                VirtualHost = "/",
                AutomaticRecoveryEnabled = true
            };
        }
        #endregion

        public void EnviarMensagem(RabbitMqMensagem rabbitMqMensagem)
        {
            using (var conexao = _factory.CreateConnection())
            {
                using (var canal = conexao.CreateModel())
                {
                    canal.QueueDeclare(
                        queue: _config.Queue,
                        durable: false,
                        exclusive: false,
                        autoDelete: false,
                        arguments: null
                        );

                    var mensagemSeriaized = JsonConvert.SerializeObject(rabbitMqMensagem);

                    var mensagemBytes = Encoding.UTF8.GetBytes(mensagemSeriaized);

                    canal.BasicPublish(
                        exchange: "",
                        routingKey: _config.Queue,
                        basicProperties: null,
                        body: mensagemBytes
                        );
                }
            }
        }

    }
}
