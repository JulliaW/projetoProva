using System.ComponentModel.DataAnnotations;

namespace projetoProva.Models
{
    public class Produto
    {
        [Key]
        public int ProdutoId { get; set; }

        [Required(ErrorMessage = "Por favor, informe o nome")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Por favor, informe a descrição")]
        public string Descricao { get; set; }

        public Fornecedor fornecedor { get; set; }

    }
}
