using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Modelos
{
    internal class AutenticacaoHelper
    {
        /// <summary>
        /// Método que verifica se as senhas são iguais.
        /// </summary>
        /// <param name="senhaVerdadeira"></param>
        /// <param name="senhaTentativa"></param>
        /// <returns></returns>
        public bool CompararSenhas(string senhaVerdadeira, string senhaTentativa)
        {
            return senhaVerdadeira == senhaTentativa;
        }
    }
}
