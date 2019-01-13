﻿// <auto-generated />
using System;
using B03.EE.BlanckeK.Api;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace B03.EE.BlanckeK.Api.Migrations
{
    [DbContext(typeof(QuizContext))]
    [Migration("20190113163905_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("B03.EE.BlanckeK.Lib.Models.Answer", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AnswerText");

                    b.Property<bool>("IsCorrectAnswer");

                    b.Property<string>("QuestionId");

                    b.HasKey("Id");

                    b.HasIndex("QuestionId");

                    b.ToTable("Answer");

                    b.HasData(
                        new
                        {
                            Id = "1",
                            AnswerText = "Correct antwoord op eerste vraag",
                            IsCorrectAnswer = true,
                            QuestionId = "1"
                        },
                        new
                        {
                            Id = "2",
                            AnswerText = "Eerste foutieve antwoord op eerste vraag",
                            IsCorrectAnswer = false,
                            QuestionId = "1"
                        },
                        new
                        {
                            Id = "3",
                            AnswerText = "tweede foutieve antwoord op eerste vraag",
                            IsCorrectAnswer = false,
                            QuestionId = "1"
                        },
                        new
                        {
                            Id = "4",
                            AnswerText = "derde foutieve antwoord op eerste vraag",
                            IsCorrectAnswer = false,
                            QuestionId = "1"
                        },
                        new
                        {
                            Id = "5",
                            AnswerText = "Eerste foutieve antwoord op tweede vraag",
                            IsCorrectAnswer = false,
                            QuestionId = "2"
                        },
                        new
                        {
                            Id = "6",
                            AnswerText = "Tweede foutieve antwoord op tweede vraag",
                            IsCorrectAnswer = false,
                            QuestionId = "2"
                        },
                        new
                        {
                            Id = "7",
                            AnswerText = "Juiste antwoord op tweede vraag",
                            IsCorrectAnswer = true,
                            QuestionId = "2"
                        },
                        new
                        {
                            Id = "8",
                            AnswerText = "derde foutieve antwoord op tweede vraag",
                            IsCorrectAnswer = false,
                            QuestionId = "2"
                        },
                        new
                        {
                            Id = "9",
                            AnswerText = "Correct antwoord op derde vraag",
                            IsCorrectAnswer = true,
                            QuestionId = "3"
                        },
                        new
                        {
                            Id = "10",
                            AnswerText = "Eerste foutieve antwoord op derde vraag",
                            IsCorrectAnswer = false,
                            QuestionId = "3"
                        },
                        new
                        {
                            Id = "11",
                            AnswerText = "tweede foutieve antwoord op derde vraag",
                            IsCorrectAnswer = false,
                            QuestionId = "3"
                        },
                        new
                        {
                            Id = "12",
                            AnswerText = "derde foutieve antwoord op derde vraag",
                            IsCorrectAnswer = false,
                            QuestionId = "3"
                        });
                });

            modelBuilder.Entity("B03.EE.BlanckeK.Lib.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");

                    b.HasData(
                        new
                        {
                            Id = "KennyBlancke@icloud.com",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "20aa8e78-32ee-48bc-80aa-0ae437d5adb3",
                            EmailConfirmed = false,
                            FirstName = "Kenny",
                            LastName = "Blancke",
                            LockoutEnabled = false,
                            PhoneNumberConfirmed = false,
                            TwoFactorEnabled = false
                        });
                });

            modelBuilder.Entity("B03.EE.BlanckeK.Lib.Models.Question", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("QuestionText");

                    b.Property<string>("QuizId");

                    b.Property<int>("SortId");

                    b.HasKey("Id");

                    b.HasIndex("QuizId");

                    b.ToTable("Questions");

                    b.HasData(
                        new
                        {
                            Id = "1",
                            QuestionText = "Eerste vraag?",
                            QuizId = "1",
                            SortId = 1
                        },
                        new
                        {
                            Id = "2",
                            QuestionText = "Tweede vraag?",
                            QuizId = "1",
                            SortId = 2
                        },
                        new
                        {
                            Id = "3",
                            QuestionText = "Derde vraag?",
                            QuizId = "1",
                            SortId = 3
                        });
                });

            modelBuilder.Entity("B03.EE.BlanckeK.Lib.Models.Quiz", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ApplicationUserId");

                    b.Property<string>("QuizName");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationUserId");

                    b.ToTable("Quiz");

                    b.HasData(
                        new
                        {
                            Id = "1",
                            ApplicationUserId = "KennyBlancke@icloud.com",
                            QuizName = "Eerste quiz"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("B03.EE.BlanckeK.Lib.Models.Answer", b =>
                {
                    b.HasOne("B03.EE.BlanckeK.Lib.Models.Question")
                        .WithMany("AnswerList")
                        .HasForeignKey("QuestionId");
                });

            modelBuilder.Entity("B03.EE.BlanckeK.Lib.Models.Question", b =>
                {
                    b.HasOne("B03.EE.BlanckeK.Lib.Models.Quiz")
                        .WithMany("Questions")
                        .HasForeignKey("QuizId");
                });

            modelBuilder.Entity("B03.EE.BlanckeK.Lib.Models.Quiz", b =>
                {
                    b.HasOne("B03.EE.BlanckeK.Lib.Models.ApplicationUser")
                        .WithMany("Quizzes")
                        .HasForeignKey("ApplicationUserId");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("B03.EE.BlanckeK.Lib.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("B03.EE.BlanckeK.Lib.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("B03.EE.BlanckeK.Lib.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("B03.EE.BlanckeK.Lib.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}