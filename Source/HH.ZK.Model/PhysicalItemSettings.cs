using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HH.ZK.Model
{
    public class PhysicalItemSettings
    {
        #region 公共属性
        public List<PhysicalItem> Items { get; set; }
        #endregion

        #region 公共方法
        public PhysicalItem GetPhysicalItem(int pi)
        {
            return Items?.SingleOrDefault(it => it.ID == pi);
        }

        public PhysicalItem GetPhysicalItem(string pname)
        {
            if (string.IsNullOrEmpty(pname)) return null;
            if (Items == null || Items.Count == 0) return null;
            var pi = Items.SingleOrDefault(it => it.Name == pname);
            if (pi != null) return pi;
            if (Items.Count(it => it.Name.Contains(pname)) == 1)
            {
                return Items.First(it => it.Name.Contains(pname));
            }
            if (Items.Count(it => pname.Contains(it.Name)) == 1)
            {
                return Items.First(it => pname.Contains(it.Name));
            }
            return null;
        }

        public string GetName(int pid)
        {
            if (Items == null || Items.Count == 0) return null;
            var pi = Items.SingleOrDefault(it => it.ID == pid);
            return pi?.Name;
        }

        public string GetNames(string pids)
        {
            if (Items == null || Items.Count == 0) return null;
            if (string.IsNullOrEmpty(pids)) return null;
            var strs = pids.Split(',');
            if (strs != null && strs.Length > 0)
            {
                string temp = string.Empty;
                foreach (var pi in Items)
                {
                    if (strs.Contains(pi.ID.ToString())) temp += pi.Name + ",";
                }
                temp = temp.TrimEnd(',');
                return temp;
            }
            return null;
        }

        public string GetShortNames(string pids, string split)
        {
            if (Items == null || Items.Count == 0) return null;
            if (string.IsNullOrEmpty(pids)) return null;
            var strs = pids.Split(',');
            List<PhysicalItem> pis = new List<PhysicalItem>();
            if (strs != null && strs.Length > 0)
            {
                foreach (var pi in Items)
                {
                    if (strs.Contains(pi.ID.ToString())) pis.Add(pi);
                }
            }
            if (pis.Count > 0) return string.Join(split ?? string.Empty, pis.Select(it => string.IsNullOrEmpty(it.ShortName) ? it.Name : it.ShortName));
            return null;
        }

        public int GetSortNumbers(string pids)
        {
            if (Items == null || Items.Count == 0) return 10000;
            if (string.IsNullOrEmpty(pids)) return 10000;
            int ret = 0;
            var strs = pids.Split(',').Where(it => !string.IsNullOrEmpty(it)).ToList();
            if (strs != null && strs.Count > 0)
            {
                foreach (var str in strs)
                {
                    var temp1 = Items.FindIndex(it => it.ID.ToString() == str);
                    if (temp1 >= 0) ret += temp1;
                }
            }
            return ret;
        }
        #endregion
    }
}
