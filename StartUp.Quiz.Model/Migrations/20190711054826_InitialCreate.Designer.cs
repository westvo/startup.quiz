﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StartUp.Quiz.Model;

namespace StartUp.Quiz.Model.Migrations
{
    [DbContext(typeof(CRMDBContext))]
    [Migration("20190711054826_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("StartUp.Quiz.Model.Entities.Accounts.Account", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("AccountTypeId");

                    b.Property<string>("AddressCity");

                    b.Property<string>("AddressCountry");

                    b.Property<string>("AddressPostalCode");

                    b.Property<string>("AddressState");

                    b.Property<string>("AddressStreet");

                    b.Property<Guid?>("AvatarMediaItemId");

                    b.Property<Guid>("CreatedBy");

                    b.Property<DateTime>("DateCreated");

                    b.Property<string>("Description");

                    b.Property<string>("Emails");

                    b.Property<int>("Flags");

                    b.Property<Guid>("IndustryId");

                    b.Property<DateTime>("LastModified");

                    b.Property<string>("Name");

                    b.Property<Guid?>("OwnerId");

                    b.Property<string>("Phones");

                    b.Property<int>("Rating");

                    b.Property<string>("SocialLinks");

                    b.Property<string>("Website");

                    b.HasKey("Id");

                    b.HasIndex("AccountTypeId");

                    b.HasIndex("IndustryId");

                    b.ToTable("Account");
                });

            modelBuilder.Entity("StartUp.Quiz.Model.Entities.Accounts.AccountAudit", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("AccountId");

                    b.Property<string>("AfterValueString");

                    b.Property<string>("BeforeValueString");

                    b.Property<Guid>("CreatedBy");

                    b.Property<string>("DataType");

                    b.Property<DateTime>("DateCreated");

                    b.Property<string>("FieldName");

                    b.Property<int>("Flags");

                    b.Property<DateTime>("LastModified");

                    b.Property<Guid?>("OwnerId");

                    b.HasKey("Id");

                    b.HasIndex("AccountId");

                    b.ToTable("AccountAudit");
                });

            modelBuilder.Entity("StartUp.Quiz.Model.Entities.Accounts.AccountType", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("CreatedBy");

                    b.Property<DateTime>("DateCreated");

                    b.Property<string>("Description");

                    b.Property<int>("Flags");

                    b.Property<DateTime>("LastModified");

                    b.Property<string>("Name");

                    b.Property<Guid?>("OwnerId");

                    b.HasKey("Id");

                    b.ToTable("AccountType");
                });

            modelBuilder.Entity("StartUp.Quiz.Model.Entities.Accounts.AddressBook", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("AccountId");

                    b.Property<Guid>("ContactId");

                    b.Property<Guid>("CreatedBy");

                    b.Property<DateTime>("DateCreated");

                    b.Property<string>("Department");

                    b.Property<string>("Description");

                    b.Property<int>("Flags");

                    b.Property<DateTime>("LastModified");

                    b.Property<Guid?>("OwnerId");

                    b.Property<Guid?>("ParentContactId");

                    b.Property<string>("Position");

                    b.HasKey("Id");

                    b.HasIndex("AccountId");

                    b.HasIndex("ContactId");

                    b.ToTable("AddressBook");
                });

            modelBuilder.Entity("StartUp.Quiz.Model.Entities.Accounts.Contact", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AddressCity");

                    b.Property<string>("AddressCountry");

                    b.Property<string>("AddressPostalCode");

                    b.Property<string>("AddressState");

                    b.Property<string>("AddressStreet");

                    b.Property<Guid?>("AvatarMediaItemId");

                    b.Property<DateTime?>("Birthday");

                    b.Property<Guid>("CreatedBy");

                    b.Property<DateTime>("DateCreated");

                    b.Property<string>("Description");

                    b.Property<string>("Emails");

                    b.Property<string>("FirstName");

                    b.Property<int>("Flags");

                    b.Property<int?>("Gender");

                    b.Property<DateTime>("LastModified");

                    b.Property<string>("LastName");

                    b.Property<string>("MiddleName");

                    b.Property<string>("Name");

                    b.Property<Guid?>("OwnerId");

                    b.Property<string>("Phones");

                    b.Property<string>("SocialLinks");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.ToTable("Contact");
                });

            modelBuilder.Entity("StartUp.Quiz.Model.Entities.Accounts.ContactAudit", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AfterValueString");

                    b.Property<string>("BeforeValueString");

                    b.Property<Guid>("ContactId");

                    b.Property<Guid>("CreatedBy");

                    b.Property<string>("DataType");

                    b.Property<DateTime>("DateCreated");

                    b.Property<string>("FieldName");

                    b.Property<int>("Flags");

                    b.Property<DateTime>("LastModified");

                    b.Property<Guid?>("OwnerId");

                    b.HasKey("Id");

                    b.HasIndex("ContactId");

                    b.ToTable("ContactAudit");
                });

            modelBuilder.Entity("StartUp.Quiz.Model.Entities.Accounts.Industry", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("CreatedBy");

                    b.Property<DateTime>("DateCreated");

                    b.Property<int>("Flags");

                    b.Property<DateTime>("LastModified");

                    b.Property<string>("Name");

                    b.Property<Guid?>("OwnerId");

                    b.HasKey("Id");

                    b.ToTable("Industry");
                });

            modelBuilder.Entity("StartUp.Quiz.Model.Entities.Quiz.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid?>("CreatedBy");

                    b.Property<DateTime?>("DateCreated");

                    b.Property<string>("Description");

                    b.Property<int?>("Flags");

                    b.Property<DateTime?>("LastModified");

                    b.Property<string>("Name");

                    b.Property<Guid?>("OwnerId");

                    b.Property<Guid?>("ParentId");

                    b.Property<string>("type");

                    b.HasKey("Id");

                    b.HasIndex("ParentId");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("StartUp.Quiz.Model.Entities.Quiz.Question", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("CategoryId");

                    b.Property<Guid>("CreatedBy");

                    b.Property<DateTime>("DateCreated");

                    b.Property<string>("Description");

                    b.Property<int>("Flags");

                    b.Property<DateTime>("LastModified");

                    b.Property<string>("Name");

                    b.Property<Guid?>("OwnerId");

                    b.Property<string>("type");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Question");
                });

            modelBuilder.Entity("StartUp.Quiz.Model.Entities.Quiz.QuestionChoice", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Checked");

                    b.Property<Guid>("CreatedBy");

                    b.Property<DateTime>("DateCreated");

                    b.Property<string>("Description");

                    b.Property<int>("Flags");

                    b.Property<DateTime>("LastModified");

                    b.Property<string>("Name");

                    b.Property<Guid?>("OwnerId");

                    b.Property<Guid>("QuestionId");

                    b.HasKey("Id");

                    b.HasIndex("QuestionId");

                    b.ToTable("QuestionChoice");
                });

            modelBuilder.Entity("StartUp.Quiz.Model.Entities.Quiz.UserQuestionAnswer", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("AccountId");

                    b.Property<bool>("Checked");

                    b.Property<Guid>("CreatedBy");

                    b.Property<DateTime>("DateCreated");

                    b.Property<int>("Flags");

                    b.Property<DateTime>("LastModified");

                    b.Property<Guid?>("OwnerId");

                    b.Property<Guid>("QuestionChoiceId");

                    b.HasKey("Id");

                    b.HasIndex("AccountId");

                    b.HasIndex("QuestionChoiceId");

                    b.ToTable("UserQuestionAnswer");
                });

            modelBuilder.Entity("StartUp.Quiz.Model.Entities.Accounts.Account", b =>
                {
                    b.HasOne("StartUp.Quiz.Model.Entities.Accounts.AccountType", "AccountType")
                        .WithMany("Accounts")
                        .HasForeignKey("AccountTypeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("StartUp.Quiz.Model.Entities.Accounts.Industry", "Industry")
                        .WithMany("Accounts")
                        .HasForeignKey("IndustryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("StartUp.Quiz.Model.Entities.Accounts.AccountAudit", b =>
                {
                    b.HasOne("StartUp.Quiz.Model.Entities.Accounts.Account", "Account")
                        .WithMany("AccountAudits")
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("StartUp.Quiz.Model.Entities.Accounts.AddressBook", b =>
                {
                    b.HasOne("StartUp.Quiz.Model.Entities.Accounts.Account", "Account")
                        .WithMany()
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("StartUp.Quiz.Model.Entities.Accounts.Contact", "Contact")
                        .WithMany("AddressBooks")
                        .HasForeignKey("ContactId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("StartUp.Quiz.Model.Entities.Accounts.ContactAudit", b =>
                {
                    b.HasOne("StartUp.Quiz.Model.Entities.Accounts.Contact", "Contact")
                        .WithMany("ContactAudits")
                        .HasForeignKey("ContactId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("StartUp.Quiz.Model.Entities.Quiz.Category", b =>
                {
                    b.HasOne("StartUp.Quiz.Model.Entities.Quiz.Category", "Parent")
                        .WithMany("Children")
                        .HasForeignKey("ParentId")
                        .OnDelete(DeleteBehavior.SetNull);
                });

            modelBuilder.Entity("StartUp.Quiz.Model.Entities.Quiz.Question", b =>
                {
                    b.HasOne("StartUp.Quiz.Model.Entities.Quiz.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("StartUp.Quiz.Model.Entities.Quiz.QuestionChoice", b =>
                {
                    b.HasOne("StartUp.Quiz.Model.Entities.Quiz.Question", "Question")
                        .WithMany("QuestionChoices")
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("StartUp.Quiz.Model.Entities.Quiz.UserQuestionAnswer", b =>
                {
                    b.HasOne("StartUp.Quiz.Model.Entities.Accounts.Account", "Account")
                        .WithMany()
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("StartUp.Quiz.Model.Entities.Quiz.QuestionChoice", "QuestionChoice")
                        .WithMany()
                        .HasForeignKey("QuestionChoiceId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
