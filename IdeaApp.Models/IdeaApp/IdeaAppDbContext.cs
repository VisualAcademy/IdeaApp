using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace IdeaApp.Models
{
    public class IdeaAppDbContext : DbContext
    {
        public IdeaAppDbContext()
        {
            // Empty
        }

        public IdeaAppDbContext(DbContextOptions<IdeaAppDbContext> options)
            : base(options)
        {
            // 공식과 같은 코드 
        }

        protected override void OnConfiguring(
            DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // 닷넷 프레임워크 기반에서 호출되는 코드 영역: 
                // App.Config 또는 Web.Config의 연결 문자열 사용
                string connectionString = ConfigurationManager.ConnectionStrings[
                    "ConnectionString"].ConnectionString;
                optionsBuilder.UseSqlServer(connectionString);
            }
        }

        /// <summary>
        /// 아이디어 앱에 대한 참조(Idea 모델 클래스 <=> Ideas 테이블)
        /// </summary>
        public DbSet<Idea> Ideas { get; set; }
    }
}
