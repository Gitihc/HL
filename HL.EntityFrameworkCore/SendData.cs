using HL.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HL.EntityFrameworkCore
{
    public static class SendData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            //return;
            using (var context = new HLDBContext(serviceProvider.GetRequiredService<DbContextOptions<HLDBContext>>()))
            {
                var ObjUser = context.Set<User>();
                if (ObjUser.Any())
                {
                    return;
                }

                Guid departmentId = Guid.NewGuid();
                //增加一个部门
                context.Set<Department>().Add(
                   new Department
                   {
                       Id = departmentId,
                       DapartmentName = "HL集团总部",
                       ParentId = Guid.Empty
                   }
                );
                Guid UserId = Guid.NewGuid();
                //增加一个超级管理员用户
                ObjUser.Add(
                     new User
                     {
                         LoginName = "admin",
                         Password = "123456", //暂不进行加密
                         VseName = "超级管理员",
                         DepartmentId = departmentId
                     }
                );

                //增加四个基本功能菜单
                context.Set<Menu>().AddRange(
                   new Menu
                   {
                       Name = "组织机构管理",
                       Code= "Department",
                       Index = 0,
                       ParentId = Guid.Empty,
                       Icon = "fa fa-link"
                   },
                   new Menu
                   {
                       Name = "角色管理",
                       Code = "Role",
                       Index = 1,
                       ParentId = Guid.Empty,
                       Icon = "fa fa-link"
                   },
                   new Menu
                   {
                       Name = "用户管理",
                       Code = "User",
                       Index = 2,
                       ParentId = Guid.Empty,
                       Icon = "fa fa-link"
                   },
                   new Menu
                   {
                       Name = "功能管理",
                       Code = "Menu",
                       Index = 3,
                       ParentId = Guid.Empty,
                       Icon = "fa fa-link"
                   }
                );
                context.SaveChanges();
            }
        }
    }
}
