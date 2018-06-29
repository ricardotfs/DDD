using crm.Dominio.Command;
using System;
using System.Collections.Generic;
using System.Text;

namespace crm.Dominio.Dto
{
    public class LeadDto:ICommand
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string SobreNome { get; set; }
        public string Email { get; set; }
        public string Rg { get; set; }
        public string OrgaoEmissor { get; set; }
        public DateTime? DataExpedicao { get; set; }
        public string NomeMae { get; set; }
        public string Score { get; set; }
        public string TelefoneComercial { get; set; }
        public string TelefoneCelular { get; set; }
        public string TelefoneResidencial { get; set; }
        public string WebSite { get; set; }
        public DateTime? DataNascimento { get; set; }
        public string NumeroBanco { get; set; }
        public string Agencia { get; set; }
        public string Conta { get; set; }
        public string Cnpj { get; set; }
        public string NomeEmpresa { get; set; }
        public string Cep { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Twitter { get; set; }
        public string Skype { get; set; }
        public string Youtube { get; set; }
        public string FaceBook { get; set; }
        public string GooglePlus { get; set; }
        public string Linkedin { get; set; }
        public string Instagram { get; set; }
    }
}
