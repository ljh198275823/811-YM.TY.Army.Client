using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HH.ZK.Model
{
    /// <summary>
    /// 表示考试完成情况
    /// </summary>
    public enum TestCompleteState
    {
        未测试 = 0,
        部分科目完成 = 1,
        全部完成 = 2,
        不用测试 = 3,
    }
}
