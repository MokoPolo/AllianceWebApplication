using AllianceWebApplication.Context;
using AllianceWebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AllianceWebApplication.Service
{
    public class RaidService : BaseService
    {
        public RaidService(AllianceDbContext context) : base(context)
        { }

        public IEnumerable<RaidModel> GetAll()
        {
            return _context.RaidEvents.Select(a => new RaidModel()
            {
                ID = a.ID,
                Name = a.Name,
                Notes = a.Notes,
                Active = a.Active
            });
        }

        public RaidModel Get(int id)
        {
            var result = _context.RaidEvents.FirstOrDefault(a => a.ID == id);

            return result == null ? null :
                new RaidModel()
                {
                    ID = result.ID,
                    Name = result.Name,
                    Notes = result.Notes,
                    Active = result.Active
                };
        }

        public void Save(RaidModel model)
        {
            RaidEvent data = null;
            if (_context.RaidEvents.Any(r => r.ID == model.ID))
            {
                data = _context.RaidEvents.FirstOrDefault(r => r.ID == model.ID);
            }
            else
            {
                _context.RaidEvents.Add(data);
            }

            data.Name = model.Name;
            data.Notes = model.Notes;
            data.Active = model.Active;
            _context.SaveChanges();
        }
    }
}
