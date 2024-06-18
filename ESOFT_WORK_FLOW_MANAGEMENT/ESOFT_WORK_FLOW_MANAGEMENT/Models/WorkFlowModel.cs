using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ESOFT_WORK_FLOW_MANAGEMENT.Models
{
    public class WorkFlowModel
    {

        private int workFlowId;
        private string workFlowName;
        private DateTime createDate;
        private DateTime endDate;
        private StatusModel status;

        public int WorkFlowId
        {
            get
            {
                return workFlowId;
            }

            set
            {
                workFlowId = value;
            }
        }

        public string WorkFlowName
        {
            get
            {
                return workFlowName;
            }

            set
            {
                workFlowName = value;
            }
        }

        public DateTime CreateDate
        {
            get
            {
                return createDate;
            }

            set
            {
                createDate = value;
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
    }
}