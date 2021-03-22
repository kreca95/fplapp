using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FplApp.Models.RequestModels
{
    public class GetPhaseRequest
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int StartEvent { get; set; }
        public int StopEvent { get; set; }
    }
}
