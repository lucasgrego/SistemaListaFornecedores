namespace SistemaListaFornecedores.Models
{
    public class FornecedoresModel
    {
        public int Id { get; set; }
        public string? NomeFornecedor { get; set; }
        public string? PessoContato { get; set; }
        public string? NomeFantasia { get; set; }
        public string? CEP { get; set; }
        public string? UF { get; set; }
        public string? Municipio { get; set; }
        public string? Logradouro { get; set; }
        public string? Numero { get; set; }
        public string? Pais { get; set; }
        public string? InscricaoMunicipal { get; set; }
        public string? Telefone { get; set; }
        public string? Celular { get; set; }
        public string? CpfCnpj { get; set; }
        public string? Email { get; set; }

        public int? EmpresaId { get; set; }

        public virtual EmpresaModel? Empresa { get; set; }

    }
}
