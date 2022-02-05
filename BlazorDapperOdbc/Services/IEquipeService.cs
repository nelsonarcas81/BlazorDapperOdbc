using BlazorDapperOdbc.Data;
using System.Linq.Expressions;

namespace BlazorDapperOdbc.Services
{
    public interface IEquipeService
    {
        Task<IEnumerable<Equipe>> ListaEquipes();
        Task<Equipe> EquipePorId(string Id);
        Task<Equipe> Adicionar (Equipe equipe);
        Task<Equipe> Atualizar(Equipe equipe, string Id);
        Task<Equipe> Apagar(string Id);
    }
}
