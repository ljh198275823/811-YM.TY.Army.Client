using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HH.ZK.Model
{
    public enum StudentState
    {
        正常考试 = 0,
        //下面的是中考使用的
        尖子生免考 = 11,
        疾病免考 = 12,
        残疾免考 = 13,
        择考 = 14,
        缓考 = 15,
        免试 = 16,
        免修 = 17,
        回往生 = 18,
        弃考 = 99,
    }
}
