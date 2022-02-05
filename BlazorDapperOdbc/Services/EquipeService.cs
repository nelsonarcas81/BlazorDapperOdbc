using BlazorDapperOdbc.Data;
using Dapper;
using System.Data.Odbc;

namespace BlazorDapperOdbc.Services
{
    public class EquipeService : IEquipeService
    {
        private readonly IConfiguration _configuration;

        public EquipeService(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public async Task<IEnumerable<Equipe>> ListaEquipes()
        {
            OdbcConnection conexaoBD = await Conexao.AbreConexao(_configuration);

            var ComandoSql = "Select id, descricao, dtcadastro from equipe";

            var Retorno = conexaoBD.Query<Equipe>(ComandoSql);

            await Conexao.FechaConexao(conexaoBD);

            return Retorno;
        }
        public async Task<Equipe> EquipePorId(string Id)
        {
            OdbcConnection conexaoBD = await Conexao.AbreConexao(_configuration);

            var ComandoSql = $"Select id, descricao, dtcadastro from equipe where id = '{Id}'";

            var Retorno = await conexaoBD.QuerySingleOrDefaultAsync<Equipe>(ComandoSql);

            await Conexao.FechaConexao(conexaoBD);

            return Retorno;
        }

        public async Task<Equipe> Adicionar(Equipe equipe)
        {
            equipe.Id = Util.GeraGuid();

            var ComandoSql = $"INSERT INTO equipe (id, descricao, dtcadastro) " +
            $" values ('{equipe.Id}', '{equipe.Descricao}', '{equipe.DtCadastro:yyyy-MM-dd}')";

            OdbcConnection conexaoBD = await Conexao.AbreConexao(_configuration);

            try
            {
                await conexaoBD.ExecuteAsync(ComandoSql);
            }
            catch (Exception)
            {
                throw;
            }
            finally 
            {
                await Conexao.FechaConexao(conexaoBD);
            }

            return equipe;
        }

        public async Task<Equipe> Apagar(string Id)
        {
            var equipe = await EquipePorId(Id);

            if (equipe == null)
            {
                return null;
            }

            var ComandoSql = $"DELETE FROM equipe where id = '{Id}'";

            OdbcConnection conexaoBD = await Conexao.AbreConexao(_configuration);

            try
            {
                await conexaoBD.ExecuteAsync(ComandoSql);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                await Conexao.FechaConexao(conexaoBD);
            }

            return equipe;

        }

        public async Task<Equipe> Atualizar(Equipe equipe, string Id)
        {
            var ComandoSql = "UPDATE equipe " +
                $"set descricao = '{equipe.Descricao}', " +
                $"dtcadastro = '{equipe.DtCadastro:yyyy-MM-dd}' " +
                $"where id = '{Id}'";

            OdbcConnection conexaoBD = await Conexao.AbreConexao(_configuration);

            try
            {
                await conexaoBD.ExecuteAsync(ComandoSql);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                await Conexao.FechaConexao(conexaoBD);
            }

            return equipe;

        }
    }
}
