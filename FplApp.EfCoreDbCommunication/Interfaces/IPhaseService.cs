using FplApp.Models.Models;
using FplApp.Models.RequestModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FplApp.EfCoreDbCommunication.Interfaces
{
    public interface IPhaseService
    {
        bool InsertPhase(List<Phase> phases);
        bool DeletePhase(Phase phase);
        List<Phase> GetPhases(GetPhaseRequest getPhaseRequest);

    }
}
