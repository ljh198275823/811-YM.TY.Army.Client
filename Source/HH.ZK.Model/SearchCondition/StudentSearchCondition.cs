using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HH.ZK.Model.SearchCondition
{
    public class StudentSearchCondition : LJH.GeneralLibrary.SearchCondition
    {
        public Guid? DivisionID { get; set; }

        public string FacilityID { get; set; }

        public string ClassName { get; set; }

        public string StudentID { get; set; }

        public string StudentIDLike { get; set; }

        public List<string> StudentIDS { get; set; }

        public string StudentID_IDNumber_CardID { get; set; }

        public Sex? Sex { get; set; }

        public bool? HasPhoto { get; set; }

        public bool? HasFaceFeature { get; set; }

        public string Name { get; set; }

        public List<StudentState> States { get; set; }

        public Guid? GroupID { get; set; }

        public bool? Grouped { get; set; }

        public string PhysicalItems { get; set; }

        public string AnyPhysicalItems { get; set; } //学生只要包括其中一项考试科目就符合条件

        public bool? Checked { get; set; } //获取或设置是否已经检录

        public bool? StudentUploaded { get; set; }
    }
}
