
using System.Data.Entity;

namespace WebApi_ShopBanDoTheThao_2024.Models
{
    public class TodoContext : DbContext
    {
        public TodoContext()
                    : base("name=TodoContext")
        {

        }

        public DbSet<TodoItem> TodoItems { get; set; } = null!;
    }
}
