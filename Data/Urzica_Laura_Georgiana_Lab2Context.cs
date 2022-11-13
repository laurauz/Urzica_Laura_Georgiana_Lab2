﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Urzica_Laura_Georgiana_Lab2.Models;

namespace Urzica_Laura_Georgiana_Lab2.Data
{
    public class Urzica_Laura_Georgiana_Lab2Context : DbContext
    {
        public Urzica_Laura_Georgiana_Lab2Context (DbContextOptions<Urzica_Laura_Georgiana_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Urzica_Laura_Georgiana_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Urzica_Laura_Georgiana_Lab2.Models.Publisher> Publisher { get; set; }

        public DbSet<Urzica_Laura_Georgiana_Lab2.Models.Author> Author { get; set; }

        public DbSet<Urzica_Laura_Georgiana_Lab2.Models.Category> Category { get; set; }

        public DbSet<Urzica_Laura_Georgiana_Lab2.Models.Member> Member { get; set; }

        public DbSet<Urzica_Laura_Georgiana_Lab2.Models.Borrowing> Borrowing { get; set; }
    }
}
