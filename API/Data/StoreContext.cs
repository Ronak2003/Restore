using System;
using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data;

//DbContext is mediator between data and code
public class StoreContext(DbContextOptions options) : DbContext(options) 
{
    public required DbSet<Product> Products { get; set; }
    
}
