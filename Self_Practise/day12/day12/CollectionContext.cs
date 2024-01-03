using Microsoft.EntityFrameworkCore;
using BOL;
namespace DAL;

public class CollectionContext:DbContext{
    //Dbcontext is used to query and save instances of your entities
    
    public DbSet<Student> Students {get;set;}
    //here A DbSet can be used to query and save instances of Student. 
    //LINQ queries against a DbSet will be translated into queries against the database.


    // Provides a simple API surface for configuring DbContextOptions.
    //  Databases (and other extensions) typically define extension methods 
    //  on this object that allow you to configure the database connection (and other options) to 
    //  be used for a context.



}