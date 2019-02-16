using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Microting.eFormMachineAreaBase.Infrastructure.Data.Entities
{
    public class MachineAreaTimeRegistration : BaseEntity
    {
        [ForeignKey("Machine")]
        public int MachineId { get; set; }
        
        public virtual Machine Machine { get; set; }
        
        [ForeignKey("Area")]
        public int AreaId { get; set; }
        
        public virtual Area Area { get; set; }
        
        public DateTime DoneAt { get; set; }
        
        public int SDKCaseId { get; set; }
        
        public int SDKFieldValueId { get; set; }
        
        public int TimeInSeconds { get; set; }
        
        public int TimeInMinutes { get; set; }
        
        public int TimeInHours { get; set; }
        
        public int SDKSiteId { get; set; }
        
        public int Version { get; set; }

    }
}