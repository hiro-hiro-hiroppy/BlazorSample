using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorEntity.Entity
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int price { get; set; }
        public string Publisher { get; set; }
    }

    public class BookConfiguration : IEntityTypeConfiguration<Book>
    {
        public BookConfiguration(EntityTypeBuilder<Book> builder)
        {
            Configure(builder);
        }

        public void Configure(EntityTypeBuilder<Book> builder)
        {
            //テーブル名の設定
            builder.ToTable("Book");

            //主キーの設定
            builder.HasKey(book => book.Id);
            builder.Property(book => book.Id)
                .ValueGeneratedOnAdd();
        }
    }
}
