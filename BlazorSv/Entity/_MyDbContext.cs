using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace BlazorSv.Entity
{
    /// <summary>
    /// エンティティ定義
    /// 参考URL : https://tsuna-can.hateblo.jp/entry/2021/07/09/130000
    /// </summary>
    public class _MyDbContext : DbContext
    {
        public _MyDbContext() { }
        public _MyDbContext(DbContextOptions<_MyDbContext> options) : base(options) { }

        public DbSet<Book> Books { get; set; }

        /// <summary>
        /// テーブル定義
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            new BookConfiguration(modelBuilder.Entity<Book>());
        }

        /// <summary>
        /// データベースの接続設定
        /// </summary>
        /// <param name="optionsBuilder"></param>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //SQLServer接続設定
            var appSettingsJson = AppSettingsJson.GetAppSettings();
            var connectionString = appSettingsJson["ConnectionStrings:DBConnection"];
            //optionsBuilder.UseSqlServer("Data Source=localhost; Persist Security Info=True;User ID=sa;Password=saPassword1234");
            optionsBuilder.UseSqlServer(connectionString);
            //base.OnConfiguring(optionsBuilder);
        }
    }
}
