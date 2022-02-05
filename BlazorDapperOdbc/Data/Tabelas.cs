using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorDapperOdbc.Data
{
    public record Equipe
    {
        [Column("id")]
        public string Id { get; set; } = "";

        [Column("descricao")]
        public string Descricao { get; set; }

        [Column("dtcadastro")]
        public DateTime DtCadastro {get; set;}
    }
}
