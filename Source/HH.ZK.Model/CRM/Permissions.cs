using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace HH.ZK.Model.CRM
{
    /// <summary>
    /// 操作员的权限枚举
    /// </summary>
    public enum Permission
    {
        #region 基本资料
        /// <summary>
        /// 区域资料
        /// </summary>
        Division = 1,
        /// <summary>
        /// 学校资料
        /// </summary>
        Facility = 2,
        /// <summary>
        /// 学生资料
        /// </summary>
        StudentClass = 3,
        /// <summary>
        /// 学生资料
        /// </summary>
        Student = 4,
        /// <summary>
        /// 学生资料
        /// </summary>
        StudentPhoto = 5,
        #endregion

        #region 计划相关
        /// <summary>
        /// 系统参数
        /// </summary>
        SystemOptions = 100,
        /// <summary>
        /// 学生分组
        /// </summary>
        StudentGroup = 101,
        /// <summary>
        /// 学生成绩
        /// </summary>
        StudentScore = 102,
        /// <summary>
        /// 总分
        /// </summary>
        总分 = 103,
        /// <summary>
        /// 成绩仲裁
        /// </summary>
        Discussion = 106,
        #endregion
    }
}