using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ESOFT_WORK_FLOW_MANAGEMENT.Models
{
    public class EmployeeEntityModel
    {

        private List<EntityModel> entity;
        private EmployeeModel emoloyee;
        private StatusModel status;
        private int entityCount = 5;

        public List<EntityModel> Entity
        {
            get
            {
                return entity;
            }

            set
            {
                entity = value;
            }
        }

        public EmployeeModel Emoloyee
        {
            get
            {
                return emoloyee;
            }

            set
            {
                emoloyee = value;
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

        public int EntityCount
        {
            get
            {
                return entityCount;
            }

            set
            {
                entityCount = value;
            }
        }

    }
}