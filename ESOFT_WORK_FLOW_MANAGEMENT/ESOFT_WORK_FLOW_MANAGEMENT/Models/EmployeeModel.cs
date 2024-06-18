using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ESOFT_WORK_FLOW_MANAGEMENT.Models
{
    public class EmployeeModel
    {
        private int emp_id;
        private string jobRole;
        private string firstName;
        private string lastName;
        private string contact;
        private OrganizationModel organizeId;
        private string userName;
        private string password;
        private StatusModel status;

        public string FirstName
        {
            get
            {
                return firstName;
            }

            set
            {
                firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }

            set
            {
                lastName = value;
            }
        }

        public string Contact
        {
            get
            {
                return contact;
            }

            set
            {
                contact = value;
            }
        }

        public string UserName
        {
            get
            {
                return userName;
            }

            set
            {
                userName = value;
            }
        }

        public string Uassword
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
            }
        }

        public string JobRole
        {
            get
            {
                return jobRole;
            }

            set
            {
                jobRole = value;
            }
        }

        public int Emp_id
        {
            get
            {
                return emp_id;
            }

            set
            {
                emp_id = value;
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

        public OrganizationModel OrganizeId
        {
            get
            {
                return organizeId;
            }

            set
            {
                organizeId = value;
            }
        }
    }
}