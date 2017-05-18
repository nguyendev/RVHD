using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RVHD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RVHD.Data
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ApplicationDbContext(
                serviceProvider.GetRequiredService<DbContextOptions<ApplicationDbContext>>()))
            {
                // Look for any movies.
                if (context.Category.Any())
                {
                    return;   // DB has been seeded
                }
                context.Category.AddRange(
               new Categories
               {
                   CategoryName = "Đồ điện tử",
                   CategoryDes = "Đồ điện tử",
                   Slug = "do-dien-tu",
                   Icon = "fa fa-desktop",
                   Publish_DT = DateTime.Now,
                   Auth_status = "1",
                   Create_DT = DateTime.Now,
                   Record_Status = 1,
                   Notes = "Example",
                   OrderNo = 1,
                   Color = "#72a0d9",
                   ListCategoryItems = new List<CategoryItems>
                   {
                        new CategoryItems()
                        {
                            Ci_Name ="Máy tính và máy tính xách tay",
                            Ci_Des ="Máy tính và máy tính xách tay",
                            Publish_DT = DateTime.Now,
                            Auth_status = "1",
                            Slug = "may-tinh-va-may-tinh-xach-tay",
                            Create_DT = DateTime.Now,
                            Record_Status = 1,
                            Notes = "Example",
                            OrderNo = 1,
                        },
                        new CategoryItems()
                        {
                            Ci_Name ="Thiết bị gia dụng",
                            Ci_Des ="Thiết bị gia dụng",
                            Publish_DT = DateTime.Now,
                            Auth_status = "1",
                            Slug = "thiet-bi-gia-dung",
                            Create_DT = DateTime.Now,
                            Record_Status = 1,
                            Notes = "Example",
                            OrderNo = 2,
                        },
                        new CategoryItems()
                        {
                            Ci_Name ="Điện thoại di động và máy tính bảng",
                            Ci_Des ="Điện thoại di động và máy tính bảng",
                            Publish_DT = DateTime.Now,
                            Auth_status = "1",
                            Slug = "dien-thoai-di-dong-va-may-tinh-bang",
                            Create_DT = DateTime.Now,
                            Record_Status = 1,
                            Notes = "Example",
                            OrderNo = 3,
                        },
                        new CategoryItems()
                        {
                            Ci_Name ="TV & LCD",
                            Ci_Des ="TV & LCD",
                            Publish_DT = DateTime.Now,
                            Auth_status = "1",
                            Slug = "tv-va-LCD",
                            Create_DT = DateTime.Now,
                            Record_Status = 1,
                            Notes = "Example",
                            OrderNo = 4,
                        }
                    }
               },
               new Categories
               {
                   CategoryName = "Việc làm",
                   CategoryDes = "Việc làm",
                   Slug = "viec-lam",
                   Icon = "fa fa-black-tie",
                   Publish_DT = DateTime.Now,
                   Auth_status = "1",
                   Create_DT = DateTime.Now,
                   Record_Status = 1,
                   Notes = "Example",
                   OrderNo = 2,
                   Color = "#d4849f",
                   ListCategoryItems = new List<CategoryItems>
                   {
                       new CategoryItems()
                       {
                           Ci_Name = "Công việc và tài chính",
                           Ci_Des = "Công việc và tài chính",
                           Publish_DT = DateTime.Now,
                           Auth_status = "1",
                           Slug = "cong-viec-va-tai-chinh",
                           Create_DT = DateTime.Now,
                           Record_Status = 1,
                           Notes = "Example",
                           OrderNo = 1,
                       },
                        new CategoryItems()
                       {
                           Ci_Name = "Giặt và làm sạch",
                           Ci_Des = "Giặt và làm sạch",
                           Publish_DT = DateTime.Now,
                           Auth_status = "1",
                           Slug = "giat-va-lam-sach",
                           Create_DT = DateTime.Now,
                           Record_Status = 1,
                           Notes = "Example",
                           OrderNo = 2,
                       },
                         new CategoryItems()
                       {
                           Ci_Name = "Nhập dữ liệu",
                           Ci_Des = "Nhập dữ liệu",
                           Publish_DT = DateTime.Now,
                           Auth_status = "1",
                           Slug = "nhap-du-lieu",
                           Create_DT = DateTime.Now,
                           Record_Status = 1,
                           Notes = "Example",
                           OrderNo = 3,
                       },
                         new CategoryItems()
                       {
                           Ci_Name = "Lập trình và thiết kế",
                           Ci_Des = "Lập trình và thiết kế",
                           Publish_DT = DateTime.Now,
                           Auth_status = "1",
                           Slug = "lap-trinh-thiet-ke",
                           Create_DT = DateTime.Now,
                           Record_Status = 1,
                           Notes = "Example",
                           OrderNo = 4,
                       },
                         new CategoryItems()
                       {
                           Ci_Name = "Tài chính",
                           Ci_Des = "Tài chính",
                           Publish_DT = DateTime.Now,
                           Auth_status = "1",
                           Slug = "tai-chinh",
                           Create_DT = DateTime.Now,
                           Record_Status = 1,
                           Notes = "Example",
                           OrderNo = 5,
                       },
                   }
               },
               new Categories
               {
                   CategoryName = "Xe",
                   CategoryDes = "Xe",
                   Slug = "xe",
                   Icon = "fa fa-car",
                   Publish_DT = DateTime.Now,
                   Auth_status = "1",
                   Create_DT = DateTime.Now,
                   Record_Status = 1,
                   Notes = "Example",
                   OrderNo = 3,
                   Color = "#a676b8",
                   ListCategoryItems = new List<CategoryItems>
                   {
                       new CategoryItems()
                       {
                           Ci_Name = "Công việc và tài chính",
                           Ci_Des = "Công việc và tài chính",
                           Publish_DT = DateTime.Now,
                           Auth_status = "1",
                           Slug = "cong-viec-va-tai-chinh",
                           Create_DT = DateTime.Now,
                           Record_Status = 1,
                           Notes = "Example",
                           OrderNo = 1,
                       },
                        new CategoryItems()
                       {
                           Ci_Name = "Giặt và làm sạch",
                           Ci_Des = "Giặt và làm sạch",
                           Publish_DT = DateTime.Now,
                           Auth_status = "1",
                           Slug = "giat-va-lam-sach",
                           Create_DT = DateTime.Now,
                           Record_Status = 1,
                           Notes = "Example",
                           OrderNo = 2,
                       },
                         new CategoryItems()
                       {
                           Ci_Name = "Nhập dữ liệu",
                           Ci_Des = "Nhập dữ liệu",
                           Publish_DT = DateTime.Now,
                           Auth_status = "1",
                           Slug = "nhap-du-lieu",
                           Create_DT = DateTime.Now,
                           Record_Status = 1,
                           Notes = "Example",
                           OrderNo = 3,
                       },
                         new CategoryItems()
                       {
                           Ci_Name = "Lập trình và thiết kế",
                           Ci_Des = "Lập trình và thiết kế",
                           Publish_DT = DateTime.Now,
                           Auth_status = "1",
                           Slug = "lap-trinh-thiet-ke",
                           Create_DT = DateTime.Now,
                           Record_Status = 1,
                           Notes = "Example",
                           OrderNo = 4,
                       },
                       new CategoryItems()
                       {
                           Ci_Name = "Tài chính",
                           Ci_Des = "Tài chính",
                           Publish_DT = DateTime.Now,
                           Auth_status = "1",
                           Slug = "tai-chinh",
                           Create_DT = DateTime.Now,
                           Record_Status = 1,
                           Notes = "Example",
                           OrderNo = 5,
                       },
                   }
               },
               new Categories
               {
                   CategoryName = "Bất động sản",
                   CategoryDes = "Bất động sản",
                   Slug = "bat-dong-san",
                   Icon = "fa fa-home",
                   Publish_DT = DateTime.Now,
                   Auth_status = "1",
                   Create_DT = DateTime.Now,
                   Record_Status = 1,
                   Notes = "Example",
                   OrderNo = 4,
                   Color = "#72a0d9",

               },
               new Categories
               {
  
                   CategoryName = "Nhà hàng",
                   CategoryDes = "Nhà hàng",
                   Slug = "nha-hang",
                   Icon = "fa fa-coffee",
                   Publish_DT = DateTime.Now,
                   Auth_status = "1",
                   Create_DT = DateTime.Now,
                   Record_Status = 1,
                   Notes = "Example",
                   OrderNo = 5,
                   Color = "#ffd27d",

               },
               new Categories
               {
                   CategoryName = "Thú cưng, vật nuôi",
                   CategoryDes = "Thú cưng, vật nuôi",
                   Slug = "thu-cung-vat-nuoi",
                   Icon = "fa fa-github-alt",
                   Publish_DT = DateTime.Now,
                   Auth_status = "1",
                   Create_DT = DateTime.Now,
                   Record_Status = 1,
                   Notes = "Example",
                   OrderNo = 6,
                   Color = "#4bb38b",

               },
               new Categories
               {
                   CategoryName = "Dịch vụ",
                   CategoryDes = "Dịch vụ",
                   Slug = "dich-vu",
                   Icon = "fa fa-wrench",
                   Publish_DT = DateTime.Now,
                   Auth_status = "1",
                   Create_DT = DateTime.Now,
                   Record_Status = 1,
                   Notes = "Example",
                   OrderNo = 7,
                   Color = "#435c70",

               },
               new Categories
               {
                   CategoryName = "Du lịch và khách san",
                   CategoryDes = "Du lịch và khách sạn",
                   Slug = "du-lich-khach-san",
                   Icon = "fa fa-plane",
                   Publish_DT = DateTime.Now,
                   Auth_status = "1",
                   Create_DT = DateTime.Now,
                   Record_Status = 1,
                   Notes = "Example",
                   OrderNo = 8,
                   Color = "#e89e09",

               }
             );
              context.SaveChanges();
                 
            }
        }
        //public static async Task CreateExampleAccount(IServiceProvider serviceProvider,
        //    IConfiguration configuration)
        //{
        //    UserManager<BlogMember> userManager = serviceProvider.GetRequiredService<UserManager<BlogMember>>();
        //    RoleManager<IdentityRole> roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
        //    string usernameadmin = configuration["Data:AdminUser:Name"];
        //    string emailadmin = configuration["Data:AdminUser:Email"];
        //    string passwordadmin = configuration["Data:AdminUser:Password"];
        //    string roleadmin = configuration["Data:AdminUser:Role"];

        //    string usernamecollaborator = configuration["Data:CollaboratorUser:Name"];
        //    string emailcollaborator = configuration["Data:CollaboratorUser:Email"];
        //    string passwordcollaborator = configuration["Data:CollaboratorUser:Password"];
        //    string rolecollaborator = configuration["Data:CollaboratorUser:Role"];

        //    string usernameguest = configuration["Data:GuestUser:Name"];
        //    string emailguest = configuration["Data:GuestUser:Email"];
        //    string passwordguest = configuration["Data:GuestUser:Password"];
        //    string roleguest = configuration["Data:GuestUser:Role"];


        //    //Tao tai khoan admin
        //    if (await userManager.FindByNameAsync(usernameadmin) == null)
        //    {
        //        if (await roleManager.FindByNameAsync(roleadmin) == null)
        //        {
        //            await roleManager.CreateAsync(new IdentityRole(roleadmin));
        //        }
        //        BlogMember useradmin = new BlogMember
        //        {
        //            UserName = usernameadmin,
        //            Email = emailadmin,
        //            ImageURL1 = "~/AdminLTE/dist/img/admin.png"

        //        };
        //        IdentityResult result = await userManager
        //        .CreateAsync(useradmin, passwordadmin);
        //        if (result.Succeeded)
        //        {
        //            await userManager.AddToRoleAsync(useradmin, roleadmin);
        //        }
        //    }
        //    //Tao tai khoan collaborator
        //    if (await userManager.FindByNameAsync(usernamecollaborator) == null)
        //    {
        //        if (await roleManager.FindByNameAsync(rolecollaborator) == null)
        //        {
        //            await roleManager.CreateAsync(new IdentityRole(rolecollaborator));
        //        }
        //        BlogMember userco = new BlogMember
        //        {
        //            UserName = usernamecollaborator,
        //            Email = emailcollaborator,
        //            ImageURL1 = "~/AdminLTE/dist/img/user3-160x160.png"
        //        };
        //        IdentityResult result = await userManager
        //        .CreateAsync(userco, passwordcollaborator);
        //        if (result.Succeeded)
        //        {
        //            await userManager.AddToRoleAsync(userco, rolecollaborator);
        //        }
        //    }
        //    //tao tai khoan khach
        //    if (await userManager.FindByNameAsync(usernameguest) == null)
        //    {
        //        if (await roleManager.FindByNameAsync(roleguest) == null)
        //        {
        //            await roleManager.CreateAsync(new IdentityRole(roleguest));
        //        }
        //        BlogMember userguest = new BlogMember
        //        {
        //            UserName = usernameguest,
        //            Email = emailguest,
        //            ImageURL1 = "~/AdminLTE/dist/img/user2-160x160.jpg"
        //        };
        //        IdentityResult result = await userManager
        //        .CreateAsync(userguest, passwordguest);
        //        if (result.Succeeded)
        //        {
        //            await userManager.AddToRoleAsync(userguest, roleguest);
        //        }
        //    }
        //}
    }
}
