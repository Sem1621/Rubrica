using Microsoft.EntityFrameworkCore;

namespace Rubrica.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
            
        }
    }
}
