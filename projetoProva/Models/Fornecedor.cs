using System.ComponentModel.DataAnnotations;

namespace projetoProva.Models
{
    public class Fornecedor
    {
        [Key]
        public int FornecedorId { get; set; }

        [Required(ErrorMessage = "Por favor, informe o nome")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Por favor, informe o e-mail")]
        public string Email { get; set; }

        public string Logradouro { get; set; }

        public string Complemento { get; set; }

        public string Bairro { get; set; }

        public string Cidade { get; set; }

        public List<Produto> Produtos { get; set; }
    }
}
