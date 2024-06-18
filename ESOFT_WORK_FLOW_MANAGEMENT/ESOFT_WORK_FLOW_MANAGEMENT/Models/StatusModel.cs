using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ESOFT_WORK_FLOW_MANAGEMENT.Models
{
    public class StatusModel
    {

        int statusId;
        string type;
        string status;

        public int StatusId
        {
            get
            {
                return statusId;
            }

            set
            {
                statusId = value;
            }
        }

        public string Type
        {
            get
            {
                return type;
            }

            set
            {
                type = value;
            }
        }

        public string Status
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