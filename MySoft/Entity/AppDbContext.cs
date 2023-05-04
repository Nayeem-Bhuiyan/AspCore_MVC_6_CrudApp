using Microsoft.EntityFrameworkCore;
using MySoft.Entity.CountryEntity;
using MySoft.Entity.EmployeeEntity;

namespace MySoft.Entity
{
    public class AppDbContext: DbContext //add here :DbContext
    {
        #region ChangeCode
        
        private readonly IHttpContextAccessor _httpContextAccessor;
        internal object tblName;

        public AppDbContext(DbContextOptions<AppDbContext> options, IHttpContextAccessor _httpContextAccessor) : base(options)
        {
            this._httpContextAccessor = _httpContextAccessor;
        }


        //add new line for every new table in entity folder 
        public DbSet<Employee> Employee { get; set; }
        public DbSet<Country> Country { get; set; }
    





        #endregion
    }
}
