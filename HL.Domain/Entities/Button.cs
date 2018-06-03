using System;
using System.Collections.Generic;
using System.Text;

namespace HL.Domain.Entities
{
  public  class Button:EntityBase
    {
        /// <summary>
        /// 按钮ID
        /// </summary>
        public string ButtonID { get; set; }
        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 标题
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 事件
        /// </summary>
        public string EventName { get; set; }

        /// <summary>
        /// 方法
        /// </summary>
        public string MethodName { get; set; }

        /// <summary>
        /// 类型
        /// </summary>
        public int Type { get; set; }

        /// <summary>
        /// 显示顺序
        /// </summary>
        public int Index { get; set; }


        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime GenTime { get; set; }


        /// <summary>
        /// 创建者
        /// </summary>
        public Guid Creator { get; set; }
    }
}
