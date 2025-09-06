using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HH.ZK.Model.CRM
{
    [Flags]
    public enum HHModules
    {
        没有指定 = 0x00,
        学生考试 = 0x01,
        学生体测 = 0x02,
        学生抽测 = 0x04,
        学生视力 = 0x08,
        体育竞赛 = 0x10,
        体育教学 = 0x20,
        在线考试 = 0x40,
        学生体检 = 0x80,
        调查问卷 = 0x200,

        基础信息 = 0x10000,
    }
}
