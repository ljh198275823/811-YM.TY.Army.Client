using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HH.ZK.Model
{
    public enum ScoreSource
    {
        文件导入 = 0,
        主机 = 1,
        AI设备 = 2,
        手工录入 = 9,
        其它设备 = 10,
        系统生成 = 11,
    }
}
