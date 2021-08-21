using Microsoft.EntityFrameworkCore;

namespace AnimalShelter.Models
{
  public class AnimalShelterContext : DbContext
  {
    public AnimalShelterContext(DbContextOptions<AnimalShelterContext>options)
      : base(options)
      {
      }

      public DbSet<Animal> Animals { get; set;}

      protected override void OnModelCreating(ModelBuilder builder)
      {
        builder.Entity<Animal>()
          .HasData(
            new Animal { AnimalId = 1, Name = "Egypt", Species = " Chubby Kitty", Age = 1, Gender = "Female" },
            new Animal { AnimalId = 2, Name = "Doja", Species = "Cat", Age = 3, Gender = "Female" },
            new Animal { AnimalId = 3, Name = "John Cena", Species = "WWE WRESTLER", Age = 45, Gender = "Male" },
            new Animal { AnimalId = 4, Name = "Wooly", Species = "Mammoth", Age = 1000, Gender = "Male" },
            new Animal { AnimalId = 5, Name = "Tiger", Species = "Dangerous Kitty", Age = 3, Gender = "Male" }
          );
      }
  }
}