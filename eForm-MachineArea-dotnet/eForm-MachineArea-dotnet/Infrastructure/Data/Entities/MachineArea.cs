using System.ComponentModel.DataAnnotations.Schema;

namespace Microting.eFormMachineAreaBase.Infrastructure.Data.Entities
{
    public class MachineArea : BaseEntity
    {
        [ForeignKey("Machine")]
        public int MachineId { get; set; }

        public virtual Machine Machine { get; set; }

        [ForeignKey("Area")]
        public int AreaId { get; set; }

        public virtual Area Area { get; set; }
        
        public int Verseion { get; set; }
    }
}