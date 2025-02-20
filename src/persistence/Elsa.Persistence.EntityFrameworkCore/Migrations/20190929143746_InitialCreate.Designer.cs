﻿// <auto-generated />
using System;
using Elsa.Persistence.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Elsa.Persistence.EntityFrameworkCore.Migrations
{
    [DbContext(typeof(ElsaContext))]
    [Migration("20190929143746_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity("Elsa.Persistence.EntityFrameworkCore.Documents.WorkflowDefinitionVersionDocument", b =>
                {
                    b.Property<string>("Id");

                    b.Property<string>("Activities");

                    b.Property<string>("Connections");

                    b.Property<string>("DefinitionId");

                    b.Property<string>("Description");

                    b.Property<bool>("IsDisabled");

                    b.Property<bool>("IsLatest");

                    b.Property<bool>("IsPublished");

                    b.Property<bool>("IsSingleton");

                    b.Property<string>("Name");

                    b.Property<string>("Variables");

                    b.Property<int>("Version");

                    b.HasKey("Id");

                    b.ToTable("WorkflowDefinitionVersions");
                });

            modelBuilder.Entity("Elsa.Persistence.EntityFrameworkCore.Documents.WorkflowInstanceDocument", b =>
                {
                    b.Property<string>("Id");

                    b.Property<DateTime?>("AbortedAt");

                    b.Property<string>("Activities");

                    b.Property<string>("BlockingActivities");

                    b.Property<string>("CorrelationId");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("DefinitionId");

                    b.Property<string>("ExecutionLog");

                    b.Property<string>("Fault");

                    b.Property<DateTime?>("FaultedAt");

                    b.Property<DateTime?>("FinishedAt");

                    b.Property<string>("Input");

                    b.Property<string>("Scopes");

                    b.Property<DateTime?>("StartedAt");

                    b.Property<string>("Status")
                        .IsRequired();

                    b.Property<int>("Version");

                    b.HasKey("Id");

                    b.ToTable("WorkflowInstances");
                });
#pragma warning restore 612, 618
        }
    }
}
