// <auto-generated />
using BoxxstepTest.Repository.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BoxxstepTest.Web.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20220213073437_rel")]
    partial class rel
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.14")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BoxxstepTest.Repository.Data.Models.Contact", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Contact");
                });

            modelBuilder.Entity("BoxxstepTest.Repository.Data.Models.Relation", b =>
                {
                    b.Property<long>("ContactId")
                        .HasColumnType("bigint");

                    b.Property<long>("ReportTo")
                        .HasColumnType("bigint");

                    b.HasKey("ContactId", "ReportTo");

                    b.ToTable("Relation");
                });

            modelBuilder.Entity("BoxxstepTest.Repository.Data.Models.Relation", b =>
                {
                    b.HasOne("BoxxstepTest.Repository.Data.Models.Contact", null)
                        .WithMany("Relations")
                        .HasForeignKey("ContactId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BoxxstepTest.Repository.Data.Models.Contact", b =>
                {
                    b.Navigation("Relations");
                });
#pragma warning restore 612, 618
        }
    }
}
