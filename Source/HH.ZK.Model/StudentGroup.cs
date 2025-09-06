using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HH.ZK.Model
{
    public class StudentGroup : StudentGroupSummary
    {
        #region 公共属性
        /// <summary>
        /// 获取或设置所有
        /// </summary>
        public List<StudentGroupPair> Items { get; set; }
        #endregion

        #region 公共方法
        /// <summary>
        /// 获取组别里面学生分组的数量
        /// </summary>
        public override int ItemsCount
        {
            get { return Items == null ? 0 : Items.Count; }
            set { }
        }

        public void Add(StudentGroupPair pair)
        {
            if (Items == null) Items = new List<StudentGroupPair>();
            pair.GroupID = ID;
            if (!Items.Exists(it => it.ID == pair.ID)) Items.Add(pair);
        }

        public void Add(Student s)
        {
            if (Items == null) Items = new List<StudentGroupPair>();
            if (Items.Exists(it => it.StudentID == s.ID) == false)
            {
                var channel = Items.Count == 0 ? 1 : Items.Max(it => it.Channel ?? 0) + 1;
                Items.Add(new StudentGroupPair() { ID = Guid.NewGuid(), GroupID = this.ID, StudentID = s.ID, Channel = channel });
            }
        }

        public void Remove(StudentGroupPair pair)
        {
            if (Items != null) Items.RemoveAll(it => it.ID == pair.ID);
        }

        public void Remove(Student s)
        {
            if (Items != null) Items.RemoveAll(it => it.StudentID == s.ID);
        }

        public void Clear()
        {
            if (Items != null) Items.Clear();
        }

        public StudentGroup Clone()
        {
            var ret = this.MemberwiseClone() as StudentGroup;
            ret.Items = new List<StudentGroupPair>();
            foreach (var item in Items)
            {
                ret.Items.Add(item.Clone());
            }
            return ret;
        }
        #endregion
    }
}
