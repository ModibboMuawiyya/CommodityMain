using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CommodityMain.DataAccess.EF
{
    public partial class CommodityContext : DbContext
    {
        public virtual DbSet<commodity> commodities { get; set; }
        public virtual DbSet<commodityprice> commodityprices { get; set; }
        public virtual DbSet<commoditytype> commoditytypes { get; set; }
        public virtual DbSet<exceptionlog> exceptionlogs { get; set; }
        public virtual DbSet<location> locations { get; set; }
        public virtual DbSet<measurement> measurements { get; set; }
        public virtual DbSet<rate> rates { get; set; }
        public virtual DbSet<ratetype> ratetypes { get; set; }

        public CommodityContext(DbContextOptions<CommodityContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            modelBuilder.Entity<commodity>(entity =>
            {
                entity.HasKey(e => e.com_id)
                    .HasName("PRIMARY");

                entity.Property(e => e.date_created).HasDefaultValueSql("current_timestamp()");

                entity.Property(e => e.date_modified).HasDefaultValueSql("current_timestamp()");

                entity.HasOne(d => d.comType)
                    .WithMany(p => p.commodities)
                    .HasForeignKey(d => d.comTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Com_type Relationship");
            });

            modelBuilder.Entity<commodityprice>(entity =>
            {
                entity.HasKey(e => e.priceID)
                    .HasName("PRIMARY");

                entity.Property(e => e.date_modified).HasDefaultValueSql("current_timestamp()");

                entity.Property(e => e.price).HasPrecision(10);

                entity.Property(e => e.unit_measure).HasPrecision(10);

                entity.HasOne(d => d.com)
                    .WithMany(p => p.commodityprices)
                    .HasForeignKey(d => d.com_id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Commodity");

                entity.HasOne(d => d.loc)
                    .WithMany(p => p.commodityprices)
                    .HasForeignKey(d => d.loc_id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("PriceLocation");

                entity.HasOne(d => d.measure)
                    .WithMany(p => p.commodityprices)
                    .HasForeignKey(d => d.measure_id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("PriceMeasurement");
            });

            modelBuilder.Entity<commoditytype>(entity =>
            {
                entity.HasKey(e => e.com_type_ID)
                    .HasName("PRIMARY");

                entity.Property(e => e.date_created).HasDefaultValueSql("current_timestamp()");

                entity.Property(e => e.date_modified).HasDefaultValueSql("current_timestamp()");
            });

            modelBuilder.Entity<exceptionlog>(entity =>
            {
                entity.HasKey(e => e.pkey)
                    .HasName("PRIMARY");

                entity.Property(e => e.date_created).HasDefaultValueSql("current_timestamp()");
            });

            modelBuilder.Entity<location>(entity =>
            {
                entity.HasKey(e => e.loc_id)
                    .HasName("PRIMARY");

                entity.Property(e => e.date_created).HasDefaultValueSql("current_timestamp()");

                entity.Property(e => e.date_modified).HasDefaultValueSql("current_timestamp()");
            });

            modelBuilder.Entity<measurement>(entity =>
            {
                entity.HasKey(e => e.measure_id)
                    .HasName("PRIMARY");

                entity.Property(e => e.date_created).HasDefaultValueSql("current_timestamp()");

                entity.Property(e => e.date_modified).HasDefaultValueSql("current_timestamp()");
            });

            modelBuilder.Entity<rate>(entity =>
            {
                entity.Property(e => e.date_created).HasDefaultValueSql("current_timestamp()");

                entity.Property(e => e.date_modified).HasDefaultValueSql("current_timestamp()");

                entity.Property(e => e.Rate).HasPrecision(6, 2);

                entity.HasOne(d => d.rateType);
                    //.WithMany(p => p.rates)
                    //.HasForeignKey(d => d.rateTypeID)
                    //.OnDelete(DeleteBehavior.ClientSetNull)
                    //.HasConstraintName("Rate and Type Relationship");
            });

            modelBuilder.Entity<ratetype>(entity =>
            {
                entity.Property(e => e.date_created).HasDefaultValueSql("current_timestamp()");

                entity.Property(e => e.date_modified).HasDefaultValueSql("current_timestamp()");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
