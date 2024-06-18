using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ESOFT_WORK_FLOW_MANAGEMENT.Models
{
    public class EntityModel
    {

        private int taskId;
        private WorkFlowModel workflowId;
        private string EntityName;
        private string remark;
        private DateTime assignDate;
        private DateTime endDate;
        private StatusModel status;

        public int TaskId
        {
            get
            {
                return taskId;
            }

            set
            {
                taskId = value;
            }
        }

        public string EntityName1
        {
            get
            {
                return EntityName;
            }

            set
            {
                EntityName = value;
            }
        }

        public string Remark
        {
            get
            {
                return remark;
            }

            set
            {
                remark = value;
            }
        }

        public DateTime AssignDate
        {
            get
            {
                return assignDate;
            }

            set
            {
                assignDate = value;
            }
        }

        public DateTime EndDate
        {
            get
            {
                return endDate;
            }

            set
            {
                endDate = value;
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

        public WorkFlowModel WorkflowId
        {
            get
            {
                return workflowId;
            }

            set
            {
                workflowId = value;
            }
        }
    }
}