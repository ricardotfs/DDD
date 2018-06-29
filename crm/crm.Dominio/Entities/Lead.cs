using crm.Dominio.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace crm.Dominio.Entities
{
    public class Lead
    {
        public Lead(Nome nome, EMAIL email, string rg, string orgaoEmissor, DateTime? dataExpedicao,
            string nomeMae, string score, string telComercial, string telCelular, string telResidencial,
            WebSite webSite, DateTime? dataNascimento, Banco banco, CNPJ cnpj, string nomeEmpresa,
            Endereco endereco, RedesSociais redesSociais)
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
        public int Id { get; private set; }
        public Nome Nome { get; private set; }
        public EMAIL Email { get; private set; }
        public string Rg { get; private set; }
        public string OrgaoEmissor { get; private set; }
        public DateTime? DataExpedicao { get; private set; }
        public string NomeMae { get; private set; }
        public string Score { get; private set; }
        public string TelefoneComercial { get; private set; }
        public string TelefoneCelular { get; private set; }
        public string TelefoneResidencial { get; private set; }
        public WebSite WebSite { get; private set; }
        public DateTime? DataNascimento { get; private set; }
        public CNPJ Cnpj { get; private set; }
        public string NomeEmpresa { get; private set; }
        public Endereco Enderco { get; private set; }
        public RedesSociais RedesSociais { get; private set; }
    }
}