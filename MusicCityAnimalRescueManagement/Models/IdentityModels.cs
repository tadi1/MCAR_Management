using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using MusicCityAnimalRescueManagement.Models.AccountEntries;
using MusicCityAnimalRescueManagement.Models.Animals;
using MusicCityAnimalRescueManagement.ViewModels;

namespace MusicCityAnimalRescueManagement.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public DbSet<NewAnimalViewModel> NewAnimalViewModels { get; set; }
        public DbSet<AccountingViewModel> AccountingViewModels { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Animal> Animals { get; set; }
        public DbSet<AnimalTypes> AnimalTypes { get; set; }
        public DbSet<ExpenseEntry> ExpenseEntries { get; set; }
        public DbSet<AccountType> AccountTypes { get; set; }
        public DbSet<Equipment.InventoryItem> Inventories { get; set; }
        public DbSet<Equipment.EquipmentTypes> EquipmentTypes { get; set; }
        public DbSet<IncomeEntry> IncomeEntries { get; set; }
    }
}