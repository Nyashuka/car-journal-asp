using CarJournal.Domain;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarJournal.Infrastructure.Persistence.Trackings;

public class TrackingConfiguration : IEntityTypeConfiguration<Tracking>
{
    public void Configure(EntityTypeBuilder<Tracking> builder)
    {
        builder.ToTable("Trackings");

        builder.HasKey(t => t.Id);

        builder.Property(t => t.Id)
            .ValueGeneratedOnAdd();

        builder.Property(t => t.Name)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(t => t.MessageForReminder)
            .HasMaxLength(250);

        builder.Property(t => t.TrackingType)
            .IsRequired()
            .HasConversion<int>();

        builder.Property(t => t.UserCarId)
            .IsRequired();

        builder.Property(t => t.EndDate)
            .IsRequired(false);

        builder.Property(t => t.MileageAtStart)
            .IsRequired(false);

        builder.Property(t => t.TotalMileage)
            .IsRequired(false);

        builder.Property(t => t.LimitMileage)
            .IsRequired(false);

        builder.Property(t => t.CreatedAt)
            .IsRequired();

        builder.Property(t => t.UpdatedAt)
            .IsRequired();

        builder.HasOne(t => t.UserCar)
            .WithMany()
            .HasForeignKey(t => t.UserCarId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}