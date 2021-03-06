﻿// <auto-generated />
using Ipfs.Engine;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using System;

namespace Ipfs.Engine.Migrations
{
    [DbContext(typeof(Repository))]
    [Migration("20180114223032_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125");

            modelBuilder.Entity("Ipfs.Engine.Repository+Config", b =>
                {
                    b.Property<string>("Name")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Value");

                    b.HasKey("Name");

                    b.ToTable("Configs");
                });
#pragma warning restore 612, 618
        }
    }
}
