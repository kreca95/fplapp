using FplApp.EfCoreDbCommunication.Interfaces;
using FplApp.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FplApp.EfCoreDbCommunication.Implementations
{
    public class ImportFplData : IImportFplData
    {
        private readonly FplAppDbContext fplAppDbContext;

        public ImportFplData(FplAppDbContext fplAppDbContext)
        {
            this.fplAppDbContext = fplAppDbContext;
        }
        bool IImportFplData.ImportFplData(FplFullInfoResponse fplFullInfoResponse)
        {
            fplAppDbContext.Add(fplFullInfoResponse);
            var check = fplAppDbContext.SaveChanges();
            return check > 0;
        }
    }
}
