using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HH.ZK.Model
{
    public class AccountRegisterInfo
    {
        public string SchoolID { get; set; }

        public string SchoolName { get; set; }

        public ProjectClass? ProjectClass { get; set; }

        public string Name { get; set; }

        public string Mobile { get; set; }

        public int MinGrade { get; set; }

        public int MaxGrade { get; set; }

        public string VerifyCode { get; set; }

        public string Email { get; set; }
    }
}
