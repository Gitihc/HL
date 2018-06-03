using System;
using System.Collections.Generic;
using System.Text;

namespace HL.Domain.Entities
{
   public class Role:EntityBase
    {
        /// <summary>
        /// 父级角色ID
        /// </summary>
        public Guid ParentId { get; set; }
        /// <summary>
        /// 角色名称
        /// </summary>
        public string RoleName { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime GenTime { get; set; }
        /// <summary>
        /// 角色描述
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// 创建者
        /// </summary>
        public Guid Creator { get; set; }
    }
}
