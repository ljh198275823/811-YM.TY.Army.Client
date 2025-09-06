using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace HH.ZK.Model.Security
{
    /// <summary>
    /// 操作员的权限枚举
    /// </summary>
    public enum Permission
    {
        #region 基本资料
        /// <summary>
        /// 查看系统选项
        /// </summary>
        [OperatorRight(Catalog = "基本资料", Actions = PermissionActions.Read | PermissionActions.Edit, Description = "系统选项")]
        SystemOptions = 1,
        /// <summary>
        /// 测试项目
        /// </summary>
        [OperatorRight(Catalog = "基本资料", Actions = PermissionActions.Read | PermissionActions.Edit | PermissionActions.Export, Description = "测试项目")]
        PhysicalItem = 2,
        /// <summary>
        /// 评分标准
        /// </summary>
        [OperatorRight(Catalog = "基本资料", Actions = PermissionActions.Read | PermissionActions.Edit | PermissionActions.Export | PermissionActions.Import, Description = "评分标准")]
        Standard = 3,
        /// <summary>
        /// 区域资料
        /// </summary>
        [OperatorRight(Catalog = "基本资料", Actions = PermissionActions.Read | PermissionActions.Edit | PermissionActions.Export, Description = "区域信息")]
        Division = 4,
        /// <summary>
        /// 学校资料
        /// </summary>
        [OperatorRight(Catalog = "基本资料", Actions = PermissionActions.Read | PermissionActions.Edit | PermissionActions.Export | PermissionActions.Import | PermissionActions.Delete, Description = "学校信息")]
        Facility = 5,
        /// <summary>
        /// 学生资料
        /// </summary>
        [OperatorRight(Catalog = "基本资料", Actions = PermissionActions.Read | PermissionActions.Edit | PermissionActions.Delete | PermissionActions.Export | PermissionActions.Import, Description = "学生信息")]
        Student = 6,
        /// <summary>
        /// 学生照片
        /// </summary>
        [OperatorRight(Catalog = "基本资料", Actions = PermissionActions.Read | PermissionActions.Edit | PermissionActions.Export | PermissionActions.Import, Description = "学生照片")]
        StudentPhoto = 7,
        /// <summary>
        /// 学生分组
        /// </summary>
        [OperatorRight(Catalog = "基本资料", Actions = PermissionActions.Read | PermissionActions.Edit | PermissionActions.Export | PermissionActions.Import | PermissionActions.Delete, Description = "学生分组信息")]
        StudentGroup = 8,
        /// <summary>
        /// 学生成绩
        /// </summary>
        [OperatorRight(Catalog = "基本资料", Actions = PermissionActions.Read | PermissionActions.增加成绩 | PermissionActions.修改成绩 | PermissionActions.作废成绩 | PermissionActions.仲裁成绩 | PermissionActions.Export | PermissionActions.Import | PermissionActions.Collect, Description = "学生成绩")]
        StudentScore = 9,
        /// <summary>
        /// 总分
        /// </summary>
        [OperatorRight(Catalog = "基本资料", Actions = PermissionActions.Read, Description = "总分")]
        总分 = 10,
        /// <summary>
        /// 操作日志
        /// </summary>
        [OperatorRight(Catalog = "基本资料", Actions = PermissionActions.Read | PermissionActions.Export, Description = "操作日志")]
        Log = 11,
        /// <summary>
        /// 成绩复议
        /// </summary>
        [OperatorRight(Catalog = "基本资料", Actions = PermissionActions.Read | PermissionActions.Export, Description = "成绩复议记录")]
        DiscussionReport = 12,
        /// <summary>
        /// 考试视频
        /// </summary>
        [OperatorRight(Catalog = "基本资料", Actions = PermissionActions.Read | PermissionActions.Export, Description = "考试视频")]
        Video = 13,
        /// <summary>
        /// 学生检录报表
        /// </summary>
        [OperatorRight(Catalog = "基本资料", Actions = PermissionActions.Read | PermissionActions.Export, Description = "学生检录记录")]
        StudentCheckLog = 14,
        /// <summary>
        /// 人工修改成绩记录
        /// </summary>
        [OperatorRight(Catalog = "基本资料", Actions = PermissionActions.Read | PermissionActions.Export, Description = "人工修改成绩记录")]
        StudentScoreLog = 15,
        /// <summary>
        /// 违规成绩记录
        /// </summary>
        [OperatorRight(Catalog = "基本资料", Actions = PermissionActions.Read | PermissionActions.Export, Description = "违规成绩记录")]
        IllegalStudentScore = 16,
        #endregion
    }
}