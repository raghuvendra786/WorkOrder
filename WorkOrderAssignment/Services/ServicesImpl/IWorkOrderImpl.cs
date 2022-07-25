using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkOrderAssignment.Repositories;

namespace WorkOrderAssignment.Services.ServicesImpl
{
    public class IWorkOrderImpl : IWorkOrder
    {
        private dataContext _context;
        public IWorkOrderImpl(dataContext context)
        {
            _context = context;
        }

        public List<WorkOrder> GetWorkOrdersByTID(string id)
        {
            List<WorkOrder> woData;

            try
            {
                woData = _context.WO.Where(t => t.technician.TId == id).ToList();
            }
            catch (Exception)
            {

                throw new NotImplementedException();
            }

            return woData;
        }

        public List<WorkOrder> GetWorkOrdersByTime(DateTime dt)
        {
            List<WorkOrder> woData;
            try
            {
                woData = _context.WO.Where(t => t.Duration == dt).ToList();
            }
            catch (Exception)
            {

                throw new NotImplementedException();
            }

            return woData;
        }

       
    }
}
