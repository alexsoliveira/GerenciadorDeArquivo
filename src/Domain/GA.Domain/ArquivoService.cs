using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace GA.Domain
{
    public class ArquivoService : IArquivoService
    {
        public async Task<string> LerAquivo(string path, Encoding encoding)
        {
            try
            {
                using (var sr = new StreamReader(path, encoding))
                {

                }

                return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }            
        }        
    }
}
