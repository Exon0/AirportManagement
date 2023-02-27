using AM.ApplicationCore.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Infrastructure.Configurations
{
    public class PlaneConfuguration:IEntityTypeConfiguration<Plane>
    {
       
public void Configure(EntityTypeBuilder<Plane> builder)
        {
            builder.HasKey(P => P.PlaneId);
            builder.ToTable("MyPlanes");//rename table
            builder.Property(P => P.Capacity).HasColumnName("PlaneCapacity");//rename column
        }
    }
}
