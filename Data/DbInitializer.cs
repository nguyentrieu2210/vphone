using Microsoft.EntityFrameworkCore;
using vphone.Models;

namespace vphone.Data
{
    public class DbInitializer
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new QLQuanDTContext(serviceProvider.GetRequiredService<DbContextOptions<QLQuanDTContext>>()))
            {
                context.Database.EnsureCreated();   
                if(context.Users.Any())
                {
                    return;
                }
                var users = new User[]
                {
                    new User{Id = 1, Name = "NguyenVanTRieu", Email="admin@gmail.com", Password = "123456", Address="Xuan Truong", Phone="0123456789"},
                    new User{Id = 2, Name = "NguyenDanhTruong", Email="truong@gmail.com", Password = "123456", Address="Ha Noi", Phone="0123456789"},
                };
                foreach (var user in users)
                {
                    context.Users.Add(user);
                }
                context.SaveChanges();
            }
        }
    }
}
