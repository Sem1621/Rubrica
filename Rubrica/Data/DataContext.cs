﻿using Microsoft.EntityFrameworkCore;
using Models;

namespace Rubrica.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
            
        }
        
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Utente> Utente { get; set; }
        public DbSet<TipoContatto> TipoContatto {get; set; }
    }
}
