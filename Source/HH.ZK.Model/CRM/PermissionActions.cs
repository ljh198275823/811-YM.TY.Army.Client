using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HH.ZK.Model.CRM
{
    /// <summary>
    /// 表示权限的动作
    /// </summary>
    [Flags]
    public enum PermissionActions
    {
        /// <summary>
        /// 没有指定
        /// </summary>
        None = 0,
        /// <summary>
        /// 查看
        /// </summary>
        Read = 0x01,
        /// <summary>
        /// 新增编辑
        /// </summary>
        Edit = 0x02,
        /// <summary>
        /// 删除
        /// </summary>
        Delete = 0x04,
        /// <summary>
        /// 导入
        /// </summary>
        ImportScore = 0x100,
        /// <summary>
        /// 检录
        /// </summary>
        CheckStudent = 0x200,
        /// <summary>
        /// 采集
        /// </summary>
        CollectScore = 0x400,
    }
}
        
