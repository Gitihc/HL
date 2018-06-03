using System;
using System.Collections.Generic;
using System.Text;

namespace HL.Domain.Entities
{
   public class User:EntityBase
    {
        /// <summary>
        /// 所属组织
        /// </summary>
        public Guid DepartmentId { get; set; }
        /// <summary>
        /// 登录帐号
        /// </summary>
        public string LoginName { get; set; }
        /// <summary>
        /// 用户密码
        /// </summary>
        public string Password { get; set; }
        /// <summary>
        /// 用户名称
        /// </summary>
        public string VseName { get; set; }
        /// <summary>
        /// 手机号
        /// </summary>
        public string Mobile { get; set; }
        /// <summary>
        /// 电子邮箱
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime GenTime { get; set; }
        /// <summary>
        /// 登录时间
        /// </summary>
        public DateTime? LoginTime { get; set; }
        /// <summary>
        /// 上次登录时间
        /// </summary>
        public DateTime? LastLoginTime { get; set; }
        /// <summary>
        /// 登录次数
        /// </summary>
        public long LoginCount { get; set; }
        /// <summary>
        /// 电子邮箱
        /// </summary>
        public int IsDeleted { get; set; }

    }
}
