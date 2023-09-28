﻿// <auto-generated />
using System;
using Interview.UI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Interview.UI.Migrations
{
    [DbContext(typeof(SqlContext))]
    partial class SqlContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Interview.Entities.Contest", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CandidatesIntroEN")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CandidatesIntroFR")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeadlineCandidate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeadlineInterviewer")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("DepartmentId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("EmailServiceSentFrom")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("GroupNiv")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("InitUserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<TimeSpan?>("InterviewDuration")
                        .HasColumnType("time");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<TimeSpan?>("MaxTime")
                        .HasColumnType("time");

                    b.Property<string>("MembersIntroEN")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MembersIntroFR")
                        .HasColumnType("nvarchar(max)");

                    b.Property<TimeSpan?>("MinTime")
                        .HasColumnType("time");

                    b.Property<string>("NoProcessus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Contests");
                });

            modelBuilder.Entity("Interview.Entities.EmailTemplate", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ContestId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("EmailBody")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmailCC")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmailSubject")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("EmailTypeId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ContestId");

                    b.HasIndex("EmailTypeId");

                    b.ToTable("EmailTemplates");
                });

            modelBuilder.Entity("Interview.Entities.EmailType", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DescEN")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DescFR")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameEN")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameFR")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("EmailTypes");
                });

            modelBuilder.Entity("Interview.Entities.Equity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameEN")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameFR")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserSettingsId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ViewEN")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ViewFR")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Equities");
                });

            modelBuilder.Entity("Interview.Entities.Group", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ContestId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool?>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("NameEn")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameFr")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ContestId");

                    b.ToTable("Groups");
                });

            modelBuilder.Entity("Interview.Entities.GroupOwner", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("GroupId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool?>("HasAccessEE")
                        .HasColumnType("bit");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("GroupId");

                    b.ToTable("GroupsOwners");
                });

            modelBuilder.Entity("Interview.Entities.Interview", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ContactName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("ContestId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("Duration")
                        .HasColumnType("int");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Room")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset?>("StartDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<int?>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ContestId");

                    b.ToTable("Interviews");
                });

            modelBuilder.Entity("Interview.Entities.InterviewUser", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("InterviewId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("RoleId")
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("InterviewId");

                    b.ToTable("InterviewUsers");
                });

            modelBuilder.Entity("Interview.Entities.Role", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool?>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleNameEN")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleNameFR")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserSettingsId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("Interview.Entities.Schedule", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ContestId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool?>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("ScheduleType")
                        .HasColumnType("int");

                    b.Property<Guid?>("ScheduleTypeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("StartValue")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ContestId");

                    b.HasIndex("ScheduleTypeId");

                    b.ToTable("Schedules");
                });

            modelBuilder.Entity("Interview.Entities.ScheduleType", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool?>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("NameEN")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameFR")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("ScheduleId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ScheduleTypes");
                });

            modelBuilder.Entity("Interview.Entities.UserLanguage", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameEN")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameFR")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserSettingsId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("UserLanguages");
                });

            modelBuilder.Entity("Interview.Entities.UserSetting", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ContestId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DateInserted")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("EquityId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool?>("IsExternal")
                        .HasColumnType("bit");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("UserFirstname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("UserLanguageId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("UserLastname")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ContestId");

                    b.HasIndex("EquityId");

                    b.HasIndex("RoleId");

                    b.HasIndex("UserLanguageId");

                    b.ToTable("UserSettings");
                });

            modelBuilder.Entity("Interview.Entities.EmailTemplate", b =>
                {
                    b.HasOne("Interview.Entities.Contest", null)
                        .WithMany("EmailTemplates")
                        .HasForeignKey("ContestId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Interview.Entities.EmailType", null)
                        .WithMany("EmailTemplates")
                        .HasForeignKey("EmailTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Interview.Entities.Group", b =>
                {
                    b.HasOne("Interview.Entities.Contest", null)
                        .WithMany("Groups")
                        .HasForeignKey("ContestId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Interview.Entities.GroupOwner", b =>
                {
                    b.HasOne("Interview.Entities.Group", null)
                        .WithMany("GroupOwners")
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Interview.Entities.Interview", b =>
                {
                    b.HasOne("Interview.Entities.Contest", null)
                        .WithMany("Interviews")
                        .HasForeignKey("ContestId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Interview.Entities.InterviewUser", b =>
                {
                    b.HasOne("Interview.Entities.Interview", null)
                        .WithMany("InterviewUsers")
                        .HasForeignKey("InterviewId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Interview.Entities.Schedule", b =>
                {
                    b.HasOne("Interview.Entities.Contest", null)
                        .WithMany("Schedules")
                        .HasForeignKey("ContestId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Interview.Entities.ScheduleType", null)
                        .WithMany("Schedules")
                        .HasForeignKey("ScheduleTypeId");
                });

            modelBuilder.Entity("Interview.Entities.UserSetting", b =>
                {
                    b.HasOne("Interview.Entities.Contest", null)
                        .WithMany("UserSettings")
                        .HasForeignKey("ContestId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Interview.Entities.Equity", null)
                        .WithMany("UserSettings")
                        .HasForeignKey("EquityId");

                    b.HasOne("Interview.Entities.Role", "Role")
                        .WithMany("UserSettings")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Interview.Entities.UserLanguage", "UserLanguage")
                        .WithMany("UserSettings")
                        .HasForeignKey("UserLanguageId");

                    b.Navigation("Role");

                    b.Navigation("UserLanguage");
                });

            modelBuilder.Entity("Interview.Entities.Contest", b =>
                {
                    b.Navigation("EmailTemplates");

                    b.Navigation("Groups");

                    b.Navigation("Interviews");

                    b.Navigation("Schedules");

                    b.Navigation("UserSettings");
                });

            modelBuilder.Entity("Interview.Entities.EmailType", b =>
                {
                    b.Navigation("EmailTemplates");
                });

            modelBuilder.Entity("Interview.Entities.Equity", b =>
                {
                    b.Navigation("UserSettings");
                });

            modelBuilder.Entity("Interview.Entities.Group", b =>
                {
                    b.Navigation("GroupOwners");
                });

            modelBuilder.Entity("Interview.Entities.Interview", b =>
                {
                    b.Navigation("InterviewUsers");
                });

            modelBuilder.Entity("Interview.Entities.Role", b =>
                {
                    b.Navigation("UserSettings");
                });

            modelBuilder.Entity("Interview.Entities.ScheduleType", b =>
                {
                    b.Navigation("Schedules");
                });

            modelBuilder.Entity("Interview.Entities.UserLanguage", b =>
                {
                    b.Navigation("UserSettings");
                });
#pragma warning restore 612, 618
        }
    }
}
