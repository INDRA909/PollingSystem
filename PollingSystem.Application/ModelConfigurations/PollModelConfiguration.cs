using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PollingSystem.Entities;

namespace PollingSystem.Application.ModelConfigurations
{
    public class PollModelConfiguration :IEntityTypeConfiguration<Poll>
    {
        /// <summary>
        /// Конфигурирование сущности Опроса для БД
        /// </summary>
        /// <param name="builder"></param>
        public void Configure(EntityTypeBuilder<Poll> builder)
        {
            builder.ToTable("Poll");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).IsRequired();
            builder.Property(x => x.QuestionText).IsRequired().HasMaxLength(512);
            builder.HasMany(x => x.Answers);
        }
    }
}
