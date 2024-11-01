using Microsoft.EntityFrameworkCore;
using Users.Domain;

namespace DesafioTecnico_DevJunior
{
    public class UserDBContexst : DbContext
    {
        private IConfiguration _configuration;

        public UserDBContexst(IConfiguration configuration, DbContextOptions options) : base(options)
        {
            _configuration = configuration ?? throw new ArgumentNullException(nameof(configuration));
        }
        public DbSet<User> users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var typeDatabase = _configuration["typeDatabase"];
            var connectionstring = _configuration.GetConnectionString(typeDatabase);

            if (typeDatabase == "SqlServer")
            {
                optionsBuilder.UseSqlServer(connectionstring);
            }
            else if (typeDatabase == "SqlServer")
            {
                optionsBuilder.UseSqlServer(connectionstring);
            }
            else if (typeDatabase == "SqlServer")
            {
                
            }
        }
    }
}
