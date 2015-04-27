using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BackEnd_NG
{
    public class PessoasNG
    {
        public static DataTable ObterPessoas()
        {
            return BackEnd_AD.PessoasAD.ObterPessoas();
        }
    }
}
