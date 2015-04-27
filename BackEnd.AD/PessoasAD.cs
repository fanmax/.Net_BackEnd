using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BackEnd_AD
{
    public class PessoasAD
    {
        public static DataTable ObterPessoas()
        {
            DBUtil dbUtil = new DBUtil();
            String sql = @"Select * from dbo.pessoa";
            DataTable dtPessoas = dbUtil.Obter<SqlConnection>(sql);
            return dtPessoas;
        }
    }
}
