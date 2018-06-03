using System;
using System.Collections.Generic;
using System.Text;

namespace HL.Domain.Entities
{
   public class Menu:EntityBase
    {

        /// <summary>
        /// 上级菜单id
        /// </summary>
        public Guid ParentId { get; set; }
        /// <summary>
        /// 菜单名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 菜单编号
        /// </summary>
        public string Code { get; set; }
        /// <summary>
        /// 菜单类型
        /// </summary>
        public int Type { get; set; }
        /// <summary>
        /// 链接地址
        /// </summary>
        public string Link { get; set; }
        /// <summary>
        /// 图标
        /// </summary>
        public string Icon { get; set; }

        /// <summary>
        /// 是否启用
        /// </summary>
        public int IsEnable { get; set; }

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

        /// <summary>
        /// 页面按钮
        /// </summary>
        public String ButtonList { get; set; }
    }
}
