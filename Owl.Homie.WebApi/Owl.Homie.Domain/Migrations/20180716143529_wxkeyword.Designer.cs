﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Owl.Homie.Domain;

namespace Owl.Homie.Domain.Migrations
{
    [DbContext(typeof(HomieDbContext))]
    [Migration("20180716143529_wxkeyword")]
    partial class wxkeyword
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.0-rtm-30799")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Owl.Homie.Domain.Bro", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccountStatus");

                    b.Property<int>("BeUrged");

                    b.Property<int>("Index");

                    b.Property<bool>("IsNext");

                    b.Property<string>("Name");

                    b.Property<string>("NickName");

                    b.Property<string>("WxKeyWord");

                    b.Property<string>("Wx_avatarUrl");

                    b.Property<string>("Wx_city");

                    b.Property<string>("Wx_country");

                    b.Property<int>("Wx_gender");

                    b.Property<string>("Wx_nickName");

                    b.Property<string>("Wx_openId");

                    b.Property<string>("Wx_province");

                    b.HasKey("Id");

                    b.ToTable("Bro");
                });
#pragma warning restore 612, 618
        }
    }
}