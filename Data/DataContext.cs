using Microsoft.EntityFrameworkCore;

namespace CertMaker5000.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
             
        }
    }
}
