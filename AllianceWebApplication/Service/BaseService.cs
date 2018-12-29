using AllianceWebApplication.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AllianceWebApplication.Service
{
    public class BaseService
    {
        protected AllianceDbContext _context;
        public BaseService (AllianceDbContext context)
        {
            _context = context;
        }
    }
}
