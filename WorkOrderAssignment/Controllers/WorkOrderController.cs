using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WorkOrderAssignment.Services;

namespace WorkOrderAssignment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorkOrderController : ControllerBase 
    {
        IWorkOrder _iworkorder;
        public WorkOrderController(IWorkOrder workOrder)
        {
            _iworkorder = workOrder;
        }

        [HttpGet]
        [Route("[action]/{dt:DateTime}")]
        public IActionResult getWorkOrderByDuration(DateTime dt)
        {
            try
            {
                var workOrders = _iworkorder.GetWorkOrdersByTime(dt);
                if (workOrders == null)
                    return NotFound();
                else
                    return Ok(workOrders);
            }
            catch (Exception)
            {

                throw;
            }
        }
        [HttpGet]
        [Route("[action]/{id}")]
        public IActionResult getWorkOrderByTechID(String id)
        {
            try
            {
                var workOrders = _iworkorder.GetWorkOrdersByTID(id);
                if (workOrders == null)
                    return NotFound();
                else
                    return Ok(workOrders);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}