using AllianceWebApplication.Context;
using AllianceWebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AllianceWebApplication.Service
{
    public class MemberService : BaseService
    {
        public MemberService(AllianceDbContext context) : base (context)
        { }

        public IEnumerable<MemberModel> GetAll()
        {
            return _context.AllianceMembers.Select(a => new MemberModel()
            {
                Active = a.Active,
                ID = a.ID,
                Name = a.Name
            });
        }

        public MemberModel Get(int id)
        {
            var result = _context.AllianceMembers.FirstOrDefault(a => a.ID == id);//;.Select(a => new MemberModel()

            return result == null ? null :
                new MemberModel() {
                Active = result.Active,
                ID = result.ID,
                Name = result.Name
            };
        }
    }
}
