using crm.Dominio.Command;
using crm.Dominio.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace crm.Dominio.Handlres
{
    public class LeadHandlers : IHandler<LeadDto>
    {
        public ICommandResult Create(LeadDto obj)
        {
            throw new NotImplementedException();
        }

        public ICommandResult Update(LeadDto obj)
        {
            throw new NotImplementedException();
        }
    }
}
