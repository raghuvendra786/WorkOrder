using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorkOrderAssignment.Services
{
    public interface IWorkOrder
    {
        List<WorkOrder> GetWorkOrdersByTime(DateTime dt);
        List<WorkOrder> GetWorkOrdersByTID(string id);

    }
}
