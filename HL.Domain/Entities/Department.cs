using System;
using System.Collections.Generic;
using System.Text;

namespace HL.Domain.Entities
{
   public class Department:EntityBase
    {
        /// <summary>
        /// 父级部门标识
        /// </summary>
        public Guid? ParentId { get; set; }

        /// <summary>
        /// 部门名称
        /// </summary>
        public string DapartmentName { get; set; }

        /// <summary>
        /// 部门编号
        /// </summary>
        public string DapartmentCode { get; set; }

        /// <summary>
        /// 部门负责人
        /// </summary>
        public Guid? Mange { get; set; }

        /// <summary>
        /// 联系电话
        /// </summary>
        public string ContactNumber { get; set; }

        /// <summary>
        /// 创建人
        /// </summary>
        public Guid? Ceator { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime GenTime { get; set; }
        /// <summary>
        /// 是否已删除
        /// </summary>
        public int IsDeleted { get; set; }
    }
}
