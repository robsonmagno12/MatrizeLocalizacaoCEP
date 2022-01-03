using System.ComponentModel.DataAnnotations;

namespace Mix.Models
{
    class cepModel
    {
        [Key]
        [Required]
        public int Id { get; set; }
        public int Cep { get; set; }
        public string Logradouro { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Localidade { get; set; }
        public string Uf { get; set; }
        public int Unidade { get; set; }
        public int Ibge { get; set; }
        public string Gia { get; set; }
    }
}
