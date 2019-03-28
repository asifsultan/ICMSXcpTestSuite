using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICMS_XCP
{
    class ThirdPage
    {
        public string EmployeeNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string Title { get; set; }
        public string UnitOfAssignmnet{ get; set; }
        public string WorkPhone { get; set; }
        public string Extension { get; set; }
        public string MobileNumber { get; set; }
        public string WorkHours { get; set; }
        public string RDO { get; set; }
        public string Department { get; set; }
        public string SFName { get; set; }
        public string SMName { get; set; }
        public string SLN { get; set; }
        public string SPhoneNumber { get; set; }
        public string SameAsReportingParty { get; set; }
        public string NOC { get; set; }

        public ThirdPage(string employeeNumber, string firstName, string midName, string lastName,  string title,string uoa,
            string wp, string ext, string mn, string wh, string rdo, string dept, string sfn, string smn, string sln, string sph,string sas,string noc)
        {
            this.EmployeeNumber = employeeNumber;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.MiddleName = midName;
            this.Title = title;
            this.UnitOfAssignmnet = uoa;
            this.WorkPhone = wp;
            this.MobileNumber = mn;
            this.Extension = ext;
            this.WorkHours = wh;
            this.RDO = rdo;
            this.Department = dept;
            this.SFName = sfn;
            this.SMName = smn;
            this.SLN = sln;
            this.SPhoneNumber = sph;
            this.SameAsReportingParty = sas;
            this.NOC = noc;
        }
    }
}
