using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GA.Domain
{
    public interface IArquivoService
    {
        Task<string> LerAquivo(string path, Encoding encoding);
    }
}
