using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApi_ShopBanDoTheThao_2024.Models;

namespace WebApi_ShopBanDoTheThao_2024.Data
{
    public class WebApi_ShopBanDoTheThao_2024Context : DbContext
    {
        public WebApi_ShopBanDoTheThao_2024Context (DbContextOptions<WebApi_ShopBanDoTheThao_2024Context> options)
            : base(options)
        {
        }

        public DbSet<WebApi_ShopBanDoTheThao_2024.Models.TodoItem> TodoItem { get; set; } = default!;
    }
}
