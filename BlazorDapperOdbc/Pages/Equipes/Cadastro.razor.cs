using BlazorDapperOdbc.Data;
using BlazorDapperOdbc.Services;
using Microsoft.AspNetCore.Components;

namespace BlazorDapperOdbc.Pages.Equipes
{
    public partial class Cadastro
    {
        [Parameter]
        public string Id { get; set; }

        [Parameter]
        public bool Excluir { get; set; } = false;

        [Inject]
        private IEquipeService EquipeService { get; set; }

        [Inject]
        private NavigationManager NavigationManager { get; set; }

        public Equipe Equipe { get; set; } = new();
        public bool SomenteLeitura { get; set; } = false;

        protected async override Task OnInitializedAsync()
        {
            if (!string.IsNullOrEmpty(Id))
            {
                Equipe = await EquipeService.EquipePorId(Id);
                SomenteLeitura = true;
            }
            else
            {
                Equipe.DtCadastro = DateTime.Now;
                SomenteLeitura = false;
            }
        }

        private async Task AdicionarEquipe()
        {
            await EquipeService.Adicionar(Equipe);
            RetornarLista();
        }
        private async Task AtualizarEquipe()
        {
            await EquipeService.Atualizar(Equipe, Id);
            RetornarLista();
        }
        private async Task ApagarEquipe()
        {
            await EquipeService.Apagar(Id);
            RetornarLista();
        }

        private void RetornarLista()
        {
            NavigationManager.NavigateTo("/equipe");
        }
    }
}
