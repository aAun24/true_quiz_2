using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace TrueQuizTwo.Models
{
    public partial class TrueContext : DbContext
    {
        public TrueContext()
        {
        }

        public TrueContext(DbContextOptions<TrueContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Address> Address { get; set; }
        public virtual DbSet<Khet> Khet { get; set; }
        public virtual DbSet<Khwang> Khwang { get; set; }
        public virtual DbSet<Province> Province { get; set; }
        public virtual DbSet<User> User { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=AAUN24;Database=True;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Address>(entity =>
            {
                entity.Property(e => e.AddressId)
                    .HasColumnName("addressId")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.KhetId)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.KhwangId)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.ProvinceId)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.UserId)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Zipcode).HasColumnName("zipcode");
            });

            modelBuilder.Entity<Khet>(entity =>
            {
                entity.Property(e => e.KhetId)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.KhetName).HasMaxLength(50);

                entity.Property(e => e.ProvinceId)
                    .HasMaxLength(10)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Khwang>(entity =>
            {
                entity.Property(e => e.KhwangId)
                    .HasColumnName("khwangId")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.KhetId)
                    .IsRequired()
                    .HasColumnName("khetId")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.KhwangName)
                    .IsRequired()
                    .HasColumnName("khwangName")
                    .HasMaxLength(50);

                entity.Property(e => e.ProvinceId)
                    .IsRequired()
                    .HasColumnName("provinceId")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Zipcode).HasColumnName("zipcode");
            });

            modelBuilder.Entity<Province>(entity =>
            {
                entity.Property(e => e.ProvinceId)
                    .HasColumnName("provinceId")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.ProvinceName)
                    .HasColumnName("provinceName")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.No)
                    .HasName("PK_User_1");

                entity.Property(e => e.No).ValueGeneratedNever();

                entity.Property(e => e.AddressId)
                    .IsRequired()
                    .HasColumnName("address_id")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.CreateBy)
                    .IsRequired()
                    .HasColumnName("create_by")
                    .HasMaxLength(45)
                    .IsFixedLength();

                entity.Property(e => e.CreateDate)
                    .HasColumnName("create_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(45)
                    .IsFixedLength();

                entity.Property(e => e.Firstname)
                    .IsRequired()
                    .HasColumnName("firstname")
                    .HasMaxLength(45)
                    .IsFixedLength();

                entity.Property(e => e.Lastname)
                    .IsRequired()
                    .HasColumnName("lastname")
                    .HasMaxLength(45)
                    .IsFixedLength();

                entity.Property(e => e.LateUpdateBy)
                    .IsRequired()
                    .HasColumnName("late_update_by")
                    .HasMaxLength(45)
                    .IsFixedLength();

                entity.Property(e => e.LateUpdateDate)
                    .HasColumnName("late_update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Phone).HasColumnName("phone");

                entity.Property(e => e.Uername)
                    .IsRequired()
                    .HasColumnName("uername")
                    .HasMaxLength(45)
                    .IsFixedLength();

                entity.Property(e => e.Userid)
                    .IsRequired()
                    .HasColumnName("userid")
                    .HasMaxLength(10)
                    .IsFixedLength();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
