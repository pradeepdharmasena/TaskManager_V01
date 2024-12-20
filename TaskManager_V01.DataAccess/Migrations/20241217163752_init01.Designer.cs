﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TaskManager_V01.DataAccess;

#nullable disable

namespace TaskManager_V01.DataAccess.Migrations
{
    [DbContext(typeof(AppDBContext))]
    [Migration("20241217163752_init01")]
    partial class init01
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TaskManager_V01.Models.Comment", b =>
                {
                    b.Property<int>("CommentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CommentId"));

                    b.Property<string>("Body")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Header")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("LastModifiedDateTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("TaskId")
                        .HasColumnType("int");

                    b.Property<int>("WriterAccountID")
                        .HasColumnType("int");

                    b.Property<string>("WriterUserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("CommentId");

                    b.HasIndex("CommentId")
                        .IsUnique();

                    b.HasIndex("TaskId");

                    b.HasIndex("WriterUserId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("TaskManager_V01.Models.Media", b =>
                {
                    b.Property<int>("MediaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MediaId"));

                    b.Property<string>("MediaType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ResourceURL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TaskID")
                        .HasColumnType("int");

                    b.HasKey("MediaId");

                    b.HasIndex("MediaId")
                        .IsUnique();

                    b.HasIndex("TaskID");

                    b.ToTable("Medias");
                });

            modelBuilder.Entity("TaskManager_V01.Models.Project", b =>
                {
                    b.Property<int>("ProjectId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProjectId"));

                    b.Property<DateTime>("CreatedDateTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DeadLine")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OwnerID")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Tittle")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("ProjectId");

                    b.HasIndex("OwnerID");

                    b.HasIndex("Tittle")
                        .IsUnique();

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("TaskManager_V01.Models.Task", b =>
                {
                    b.Property<int>("TaskId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TaskId"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DeadLine")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("EstimatedTime")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("ProjectID")
                        .HasColumnType("int");

                    b.Property<string>("ReporterID")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TaskId");

                    b.HasIndex("ProjectID");

                    b.HasIndex("ReporterID");

                    b.HasIndex("TaskId")
                        .IsUnique();

                    b.ToTable("Tasks");
                });

            modelBuilder.Entity("TaskManager_V01.Models.TaskAssignee", b =>
                {
                    b.Property<int>("TaskId")
                        .HasColumnType("int");

                    b.Property<string>("UserID")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("TaskId", "UserID");

                    b.HasIndex("UserID");

                    b.ToTable("TaskAssignees");
                });

            modelBuilder.Entity("TaskManager_V01.Models.User", b =>
                {
                    b.Property<string>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreatedDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProfileImageURL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("UserAccounts");
                });

            modelBuilder.Entity("TaskManager_V01.Models.Comment", b =>
                {
                    b.HasOne("TaskManager_V01.Models.Task", "Task")
                        .WithMany("Comments")
                        .HasForeignKey("TaskId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TaskManager_V01.Models.User", "Writer")
                        .WithMany()
                        .HasForeignKey("WriterUserId");

                    b.Navigation("Task");

                    b.Navigation("Writer");
                });

            modelBuilder.Entity("TaskManager_V01.Models.Media", b =>
                {
                    b.HasOne("TaskManager_V01.Models.Task", "Task")
                        .WithMany("Medias")
                        .HasForeignKey("TaskID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Task");
                });

            modelBuilder.Entity("TaskManager_V01.Models.Project", b =>
                {
                    b.HasOne("TaskManager_V01.Models.User", "Owner")
                        .WithMany("Projects")
                        .HasForeignKey("OwnerID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Owner");
                });

            modelBuilder.Entity("TaskManager_V01.Models.Task", b =>
                {
                    b.HasOne("TaskManager_V01.Models.Project", "Project")
                        .WithMany("Tasks")
                        .HasForeignKey("ProjectID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TaskManager_V01.Models.User", "Reporter")
                        .WithMany()
                        .HasForeignKey("ReporterID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Project");

                    b.Navigation("Reporter");
                });

            modelBuilder.Entity("TaskManager_V01.Models.TaskAssignee", b =>
                {
                    b.HasOne("TaskManager_V01.Models.Task", "Task")
                        .WithMany()
                        .HasForeignKey("TaskId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TaskManager_V01.Models.User", "UserAccount")
                        .WithMany()
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Task");

                    b.Navigation("UserAccount");
                });

            modelBuilder.Entity("TaskManager_V01.Models.Project", b =>
                {
                    b.Navigation("Tasks");
                });

            modelBuilder.Entity("TaskManager_V01.Models.Task", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("Medias");
                });

            modelBuilder.Entity("TaskManager_V01.Models.User", b =>
                {
                    b.Navigation("Projects");
                });
#pragma warning restore 612, 618
        }
    }
}
