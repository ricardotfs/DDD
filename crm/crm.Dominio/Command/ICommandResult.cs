using System;
using System.Collections.Generic;
using System.Text;

namespace crm.Dominio.Command
{
    public interface ICommandResult
    {
        int Id { get; set; }
        bool Success { get; set; }
        string Message { get; set; }
        ICollection<string> Erros { get; set; }
    }
}
