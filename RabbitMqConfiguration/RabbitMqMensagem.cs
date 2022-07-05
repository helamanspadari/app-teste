using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RabbitMqConfiguration
{
    public class RabbitMqMensagem
    {
        public DateTime DthMensagem { get; set; }
        public string Origem { get; set; }
        public string Destino { get; set; }
        public string Conteudo { get; set; }
    }
}
