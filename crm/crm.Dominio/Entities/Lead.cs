using crm.Dominio.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace crm.Dominio.Entities
{
    public class Lead
    {
        public Lead(Nome nome,EMAIL email,string rg,string orgaoEmissor,DateTime? dataExpedicao,
            string nomeMae,string score,string telComercial,string telCelular,string telResidencial,
            WebSite webSite,DateTime? dataNascimento,Banco banco, CNPJ cnpj,string nomeEmpresa,
            Endereco endereco,RedesSociais redesSociais)
        {
            Nome = nome;
            Email = email;
            Rg = rg;
            OrgaoEmissor = orgaoEmissor;
            DataExpedicao = dataExpedicao;
            NomeMae = nomeMae;
            Score = score;
            TelefoneResidencial = telResidencial;
            TelefoneComercial = telComercial;
            TelefoneCelular = telCelular;
            WebSite = webSite;
            DataNascimento = dataExpedicao;
            Cnpj = cnpj;
            NomeEmpresa = nomeEmpresa;
            Enderco = endereco;
            RedesSociais = redesSociais;        
        }
        public int Id { get; set; }
        public Nome Nome { get; private set; }
        public EMAIL Email { get; set; }
        public string Rg { get; set; }
        public string OrgaoEmissor { get; set; }
        public DateTime? DataExpedicao { get; set; }
        public string NomeMae { get; set; }
        public string Score { get; set; }
        public string TelefoneComercial { get; set; }
        public string TelefoneCelular { get; set; }
        public string TelefoneResidencial { get; set; }
        public WebSite WebSite { get; set; }
        public DateTime? DataNascimento { get; set; }    
        public CNPJ Cnpj { get; set; }
        public string NomeEmpresa { get; set; }
        public Endereco Enderco { get; set; }
        public RedesSociais RedesSociais { get; set; }
    }
}
