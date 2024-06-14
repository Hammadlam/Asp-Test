using E_Store.Models;
using Microsoft.EntityFrameworkCore;

public class mydb : DbContext
{
    public mydb(DbContextOptions<mydb> options) : base(options) {
    
    }


    //Model class
    public DbSet<products> Products { get; set; }

    public DbSet<users> Users { get; set; }
    //public DbSet<Subjects> Subjects { get; set; }
    //public DbSet<Question> Questions { get; set; }
    //public DbSet<UserResponse> UserResponses { get; set; }
    //public DbSet<Result> Results { get; set; }
}