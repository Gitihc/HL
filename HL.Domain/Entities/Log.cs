using System;
using System.Collections.Generic;
using System.Text;

namespace HL.Domain.Entities
{
 public   class Log :EntityBase
    {
        /// <summary>
        /// 操作类型
        /// </summary>
        public int OpType { get; set; }
        /// <summary>
        /// 操作内容
        /// </summary>
        public int Content { get; set; }
        /// <summary>
        /// 操作人
        /// </summary>
        public Guid OpUserId { get; set; }
        /// <summary>
        /// 操作时间
        /// </summary>
        public DateTime GenTime { get; set; }
    }
}
