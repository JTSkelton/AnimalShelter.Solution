using Microsoft.EntityFrameworkCore;

namespace AnimalShelter.Models
{
    public class AnimalShelterContext : DbContext
    {
        public AnimalShelterContext(DbContextOptions<AnimalShelterContext> options)
            : base(options)
        {
        }

        public DbSet<Animal> Animals { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
        builder.Entity<Animal>()
            .HasData(
                new Animal { AnimalId = 1, Name = "Bigyouth", Species = "Cat", Age = 3, Gender = "Male" },
                new Animal { AnimalId = 2, Name = "Razz", Species = "Cat", Age = 15, Gender = "Male" },
                new Animal { AnimalId = 3, Name = "Bubbles", Species = "GoldFish", Age = 2, Gender = "Female" },
                new Animal { AnimalId = 4, Name = "Jasper", Species = "Dog", Age = 4, Gender = "Male" },
                new Animal { AnimalId = 5, Name = "Roy", Species = "Gecko", Age = 1, Gender = "Male" }
            );
        }
    }
    
}