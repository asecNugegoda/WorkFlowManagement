using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ESOFT_WORK_FLOW_MANAGEMENT.Models
{
    public class OrganizationModel
    {

        private int org_id;
        private string org_name;
        private string adr1;
        private string adr2;
        private string city;

        public int Org_id
        {
            get
            {
                return org_id;
            }

            set
            {
                org_id = value;
            }
        }

        public string Org_name
        {
            get
            {
                return org_name;
            }

            set
            {
                org_name = value;
            }
        }

        public string Adr1
        {
            get
            {
                return adr1;
            }

            set
            {
                adr1 = value;
            }
        }

        public string Adr2
        {
            get
            {
                return adr2;
            }

            set
            {
                adr2 = value;
            }
        }

        public string City
        {
            get
            {
                return city;
            }

            set
            {
                city = value;
            }
        }
    }
}