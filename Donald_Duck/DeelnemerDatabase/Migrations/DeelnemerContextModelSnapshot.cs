﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using DeelnemerDatabase;

namespace DeelnemerDatabase.Migrations
{
    [DbContext(typeof(DeelnemerContext))]
    partial class DeelnemerContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DeelnemerDatabase.PersonCreated", b =>
                {
                    b.Property<int>("Id");

                    b.Property<int>("BSN");

                    b.Property<DateTime>("BirthDate");

                    b.Property<DateTime>("DeceasedOnDate");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.HasKey("Id");

                    b.ToTable("Deelnemers");
                });
        }
    }
}
