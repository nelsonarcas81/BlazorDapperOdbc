using BlazorDapperOdbc.Data;
using BlazorDapperOdbc.Services;
using Microsoft.AspNetCore.Components;

namespace BlazorDapperOdbc.Pages.Equipes
{
    public partial class Lista
    {
        private IEnumerable<Equipe> ListaEquipe { get; set; }
        
        [Inject]
        private NavigationManager NavigationManager { get; set; }

        [Inject]
        private IEquipeService EquipeService { get; set; }

        protected override async Task OnInitializedAsync()
        {
            ListaEquipe = await EquipeService.ListaEquipes();
        }

        private void BuscaRegistro(string Id)
        {
            if (string.IsNullOrEmpty(Id))
            {
                NavigationManager.NavigateTo($"/equipe/{false}");
            }
            else 
            {
                NavigationManager.NavigateTo($"/equipe/{Id}/{false}");
            }

        }
        private void ExcluirRegistro(string Id)
        {
            NavigationManager.NavigateTo($"/equipe/{Id}/{true}");
        }

    }
}
