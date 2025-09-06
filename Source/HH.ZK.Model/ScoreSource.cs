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
        汇海主机 = 1,
        手工录入 = 2,
        汇海APP = 3,
        电动计时 = 4,
        IC卡=5,
        其它设备 = 10,
        系统生成 = 11,
        复议生成 = 12,
    }
}
