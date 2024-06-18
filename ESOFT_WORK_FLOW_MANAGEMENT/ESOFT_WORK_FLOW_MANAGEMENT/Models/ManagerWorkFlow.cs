using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ESOFT_WORK_FLOW_MANAGEMENT.Models
{
    public class ManagerWorkFlow
    {

        private List<WorkFlowModel> workflow;
        private EmployeeModel manager;
        private StatusModel status;
        private int workLoadCount = 5;

        public List<WorkFlowModel> Workflow
        {
            get
            {
                return workflow;
            }

            set
            {
                workflow = value;
            }
        }

        public EmployeeModel Manager
        {
            get
            {
                return manager;
            }

            set
            {
                manager = value;
            }
        }

        public StatusModel Status
        {
            get
            {
                return status;
            }

            set
            {
                status = value;
            }
        }

        public int WorkLoadCount
        {
            get
            {
                return workLoadCount;
            }

            set
            {
                workLoadCount = value;
            }
        }

        
    }
}