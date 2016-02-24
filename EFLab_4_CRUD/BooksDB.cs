namespace EFLab_4_Crud
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class BooksDB : DbContext
    {
        public BooksDB()
            : base("name=BooksDB")
        {
        }

        public virtual DbSet<Author> Authors { get; set; }
        public virtual DbSet<Title> Titles { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>()
                .HasMany(e => e.Titles)
                .WithMany(e => e.Authors)
                .Map(m => m.ToTable("AuthorsISBN").MapLeftKey("AuthorID").MapRightKey("ISBN"));
        }
    }
}
