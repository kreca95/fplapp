using FplApp.EfCoreDbCommunication.Interfaces;
using FplApp.Models.Models;
using FplApp.Models.RequestModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FplApp.EfCoreDbCommunication.Implementations
{
    public class PhaseService : IPhaseService
    {
        private readonly FplAppDbContext _dbContext;

        public PhaseService(FplAppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public bool DeletePhase(Phase phase)
        {
            var check = _dbContext.Phases.Remove(phase);
            var count = _dbContext.SaveChanges();
            return count > 0;
        }

        public List<Phase> GetPhases(GetPhaseRequest phase)
        {
            List<Phase> phases = new List<Phase>();
            phases = _dbContext.Phases.ToList();
            //ifovi
            if (phase.Id != 0)
            {
                phases = phases.Where(p => phase.Id == p.Id).ToList();
            }
            if (!string.IsNullOrEmpty(phase.Name))
            {
                phases = phases.Where(x => x.Name == x.Name).ToList();
            }
            return phases;
        }

        public bool InsertPhase(List<Phase> phases)
        {
            _dbContext.Phases.UpdateRange(phases);
            var count = _dbContext.SaveChanges();
            return count > 0;
        }
    }
}
