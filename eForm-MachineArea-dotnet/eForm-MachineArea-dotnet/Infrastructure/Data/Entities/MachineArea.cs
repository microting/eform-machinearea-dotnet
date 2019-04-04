using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Microting.eFormApi.BasePn.Infrastructure.Database.Base;

namespace Microting.eFormMachineAreaBase.Infrastructure.Data.Entities
{
    public class MachineArea : BaseEntity
    {
        public MachineArea()
        {
            this.MachineAreaSites = new HashSet<MachineAreaSite>();
        }
        
        [ForeignKey("Machine")]
        public int MachineId { get; set; }

        public virtual Machine Machine { get; set; }

        [ForeignKey("Area")]
        public int AreaId { get; set; }

        public virtual Area Area { get; set; }
        
        public virtual ICollection<MachineAreaSite> MachineAreaSites { get; set; }

    }
}