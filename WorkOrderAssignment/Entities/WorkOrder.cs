using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WorkOrderAssignment
{
    public class WorkOrder
    {
        [Key]
        public String OId { get; set; }

        public String PostalAddress { get; set; }

        public DateTime Duration { get; set; }

        public Technician technician { get; set; }

       

    }
}
