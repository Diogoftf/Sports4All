using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sports4All
{
    class ModelContext : DbContext
    {
        public ModelContext() : base("name=DataBaseContext")
        {

           // Database.SetInitializer<ModelContext>(new DropCreateDatabaseIfModelChanges<ModelContext>());
             Database.SetInitializer<ModelContext>(new CreateDatabaseIfNotExists<ModelContext>());
        }
        public DbSet<Event> Events { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Evaluation> Evaluations { get; set; }
        public DbSet<Park> Parks { get; set; }
        public DbSet<Picture> Pictures { get; set; }
        public DbSet<Reserve> Reserves { get; set; }
        public DbSet<Sport> Sports { get; set; }
        public DbSet<County> Counties { get; set; }
        public DbSet<District> Districts { get; set; }
        public DbSet<Ground> Grounds { get; set; }
        public DbSet<Material> Materials { get; set; }
     

        public DbSet<Classification> Classifications { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Event>().HasKey<int>(s => s.EventId);
            modelBuilder.Entity<User>().HasKey<string>(s => s.Username);
            modelBuilder.Entity<Address>().HasKey<int>(s => s.AddressId);
            modelBuilder.Entity<Evaluation>().HasKey<int>(s => s.EvaluationId);
            modelBuilder.Entity<Park>().HasKey<int>(s => s.ParkId);
            modelBuilder.Entity<Picture>().HasKey<int>(s => s.PictureId);
            modelBuilder.Entity<Reserve>().HasKey<int>(s => s.ReserveId);
            modelBuilder.Entity<Sport>().HasKey<int>(s => s.SportId);
            modelBuilder.Entity<County>().HasKey<int>(s => s.CountyId);
            modelBuilder.Entity<District>().HasKey<int>(s => s.DistrictId);
            modelBuilder.Entity<Ground>().HasKey<int>(s => s.GroundId);
            modelBuilder.Entity<Material>().HasKey<int>(s => s.MaterialId);
            modelBuilder.Entity<Classification>().HasKey<int>(s => s.idClassification);

            //one to many
            modelBuilder.Entity<Evaluation>()
                .HasRequired<Event>(g => g.Event)
                .WithMany(s => s.Evaluations)
                .HasForeignKey<int>(s => s.EventId)
                .WillCascadeOnDelete(false);

            //many to many
            modelBuilder.Entity<Event>()
                .HasMany<User>(s => s.Users)
                .WithMany(c => c.Events)
                .Map(cs =>
                {
                    cs.MapLeftKey("EventRefId");
                    cs.MapRightKey("UserRefId");
                    cs.ToTable("EventsUsers");
                });

            //one to one
            modelBuilder.Entity<Event>()
                .HasRequired(s => s.Reserve)
                .WithRequiredPrincipal(ad => ad.Event);

            //one to many
            modelBuilder.Entity<Evaluation>()
                .HasRequired<User>(g => g.Evaluator)
                .WithMany(s => s.Evaluations)
                .HasForeignKey<string>(s => s.EvaluatorId)
                .WillCascadeOnDelete(false);

            //one to many
            modelBuilder.Entity<User>()
                .HasRequired<Picture>(g => g.Picture)
                .WithMany(s => s.Users)
                .HasForeignKey<int>(s => s.PictureId)
                .WillCascadeOnDelete(false);

            //one to one
            modelBuilder.Entity<User>()
                .HasRequired(s => s.myStats)
                .WithRequiredPrincipal(ad => ad.userId);

            //one to many
            modelBuilder.Entity<Reserve>()
                .HasRequired<User>(g => g.User)
                .WithMany(s => s.Reserves)
                .HasForeignKey<string>(s => s.UserId)
                .WillCascadeOnDelete(false);

            //one to zero or one
            modelBuilder.Entity<Address>()
                .HasOptional(s => s.Park)
                .WithRequired(ad => ad.Adress);

            //one to many
            modelBuilder.Entity<Ground>()
                .HasRequired<Park>(g => g.Park)
                .WithMany(s => s.Grounds)
                .HasForeignKey<int>(s => s.ParkId)
                .WillCascadeOnDelete(false);

            //one to zero or one
            modelBuilder.Entity<Picture>()
                .HasOptional(s => s.Park)
                .WithRequired(ad => ad.Picture);

            //one to zero or one
            modelBuilder.Entity<Picture>()
                .HasOptional(s => s.Ground)
                .WithRequired(ad => ad.Picture);

            //one to zero or one
            modelBuilder.Entity<Picture>()
                .HasOptional(s => s.Sport)
                .WithRequired(ad => ad.Picture);

            //one to many
            modelBuilder.Entity<Reserve>()
                .HasRequired<Sport>(g => g.Sport)
                .WithMany(s => s.Reserves)
                .HasForeignKey<int>(s => s.SportId)
                .WillCascadeOnDelete(false);

            //many to many
            modelBuilder.Entity<Sport>()
                .HasMany<Ground>(s => s.Grounds)
                .WithMany(c => c.Sports)
                .Map(cs =>
                {
                    cs.MapLeftKey("SportRefId");
                    cs.MapRightKey("GroundRefId");
                    cs.ToTable("SportsGrounds");
                });

            //one to many
            modelBuilder.Entity<User>()
                .HasRequired<County>(g => g.County)
                .WithMany(s => s.Users)
                .HasForeignKey<int>(s => s.CountyId)
                .WillCascadeOnDelete(false);

            //one to many
            modelBuilder.Entity<Address>()
                .HasRequired<County>(g => g.County)
                .WithMany(s => s.Addresses)
                .HasForeignKey<int>(s => s.CountyId);

            //one to many
            modelBuilder.Entity<County>()
                .HasRequired<District>(g => g.District)
                .WithMany(s => s.Counties)
                .HasForeignKey<int>(s => s.DistrictId)
                .WillCascadeOnDelete(false);

            //one to many
            modelBuilder.Entity<Reserve>()
                .HasRequired<Ground>(g => g.Ground)
                .WithMany(s => s.Reserves)
                .HasForeignKey<int>(s => s.GroundId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<UserEvaluation>().Map(m =>
            {
                m.MapInheritedProperties();
                m.ToTable("UserEvaluations");
            });

            modelBuilder.Entity<GroundEvaluation>().Map(m =>
            {
                m.MapInheritedProperties();
                m.ToTable("GroundEvaluations");
            });

            modelBuilder.Entity<Evaluation>()
                .Property(p => p.EvaluationId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            //one to many
            modelBuilder.Entity<UserEvaluation>()
                .HasRequired<User>(g => g.Evaluated)
                .WithMany(s => s.UserEvaluations)
                .HasForeignKey<string>(s => s.UserId)
                .WillCascadeOnDelete(false);
            //one to many
            modelBuilder.Entity<GroundEvaluation>()
                .HasRequired<Ground>(g => g.Ground)
                .WithMany(s => s.GroundEvaluations)
                .HasForeignKey<int>(s => s.GroundId)
                .WillCascadeOnDelete(false);


            //one to many
            modelBuilder.Entity<Material>()
                .HasRequired<Park>(g => g.Park)
                .WithMany(s => s.Materials)
                .HasForeignKey<int>(s => s.ParkId);

            //one to many
            modelBuilder.Entity<Material>()
                .HasRequired<Sport>(g => g.Sport)
                .WithMany(s => s.Materials)
                .HasForeignKey<int>(s => s.SportId);
        }


    }
}
