using AM.ApplicationCore.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

public class PassengerConfiguration : IEntityTypeConfiguration<Passenger>
{

    public void Configure(EntityTypeBuilder<Passenger> builder)
    {
        builder.OwnsOne(p => p.FullName, full =>
        {
            full.Property(f => f.FirstName).HasColumnName("PassFirstName").HasMaxLength(30);
            full.Property(f => f.LastName).HasColumnName("PassLastName").IsRequired();
        });

    }
}
