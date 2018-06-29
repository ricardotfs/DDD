using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace crm.Dominio.ValueObjects
{
    public class WebSite:Base
    {
        public WebSite(string site)
        {
            if (ValidarUrl(site)) { Erros.Add("WebSite.Site inválido."); }
            Site = site;
        }
        public string Site { get; private set; }
        private bool ValidarUrl(string site)
        {
            var regex = new Regex("@([a-zA-Z]{3,})://([\\w-]+\\.)+[\\w-]+(/[\\w- ./?%&=]*)?");
            if (regex.IsMatch(site))
                return true;

            return false;

        }
    }
}
