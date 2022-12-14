// <auto-generated />
using ForumApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ForumApp.Migrations
{
    [DbContext(typeof(ForumAppDbContext))]
    [Migration("20221015164850_tableCreated")]
    partial class tableCreated
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ForumApp.Data.Entities.Post", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasComment("Post id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasMaxLength(1500)
                        .HasColumnType("nvarchar(1500)")
                        .HasComment("Content of post");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit")
                        .HasComment("Boolean is deleted or not");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasComment("Title of post");

                    b.HasKey("Id");

                    b.ToTable("Posts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Content = "My first content",
                            IsActive = true,
                            Title = "My first post"
                        },
                        new
                        {
                            Id = 2,
                            Content = "My second content",
                            IsActive = true,
                            Title = "My second post"
                        },
                        new
                        {
                            Id = 3,
                            Content = "My third content",
                            IsActive = true,
                            Title = "My third post"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
