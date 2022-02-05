using System.Data.Odbc;

namespace BlazorDapperOdbc.Data
{
    public static class Conexao
    {
        public static async Task<OdbcConnection> AbreConexao(IConfiguration configuration)
        {
            var stringConexao = configuration.GetConnectionString("ConexaoPadrao");

            OdbcConnection Conexao = new (stringConexao);

            await Conexao.OpenAsync();

            return Conexao;
        }

        public static async Task FechaConexao(OdbcConnection conexao)
        {
            await conexao.CloseAsync();
        }
    }
}
