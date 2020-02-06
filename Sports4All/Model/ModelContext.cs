using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace Sports4All
{
    class ModelContext : DbContext
    {
        public ModelContext() : base("name=DataBaseContext")
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<ModelContext>());
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
        public DbSet<Use> Uses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Event>().HasKey(s => s.EventId);
            modelBuilder.Entity<User>().HasKey(s => s.Username);
            modelBuilder.Entity<Address>().HasKey(s => s.AddressId);
            modelBuilder.Entity<Evaluation>().HasKey(s => s.EvaluationId);
            modelBuilder.Entity<Park>().HasKey(s => s.ParkId);
            modelBuilder.Entity<Picture>().HasKey(s => s.PictureId);
            modelBuilder.Entity<Reserve>().HasKey(s => s.ReserveId);
            modelBuilder.Entity<Sport>().HasKey(s => s.SportId);
            modelBuilder.Entity<County>().HasKey(s => s.CountyId);
            modelBuilder.Entity<District>().HasKey(s => s.DistrictId);
            modelBuilder.Entity<Ground>().HasKey(s => s.GroundId);
            modelBuilder.Entity<Material>().HasKey(s => s.MaterialId);
            modelBuilder.Entity<Classification>().HasKey(s => s.ClassificationId);
            modelBuilder.Entity<Use>().HasKey(s => s.UseId);

            modelBuilder.Entity<Evaluation>()
                .HasRequired(g => g.Event)
                .WithMany(s => s.Evaluations)
                .HasForeignKey(s => s.EventId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Event>()
                .HasMany(s => s.Users)
                .WithMany(c => c.Events)
                .Map(cs =>
                {
                    cs.MapLeftKey("EventRefId");
                    cs.MapRightKey("UserRefId");
                    cs.ToTable("EventsUsers");
                });

            modelBuilder.Entity<Event>()
                .HasRequired(s => s.Reserve)
                .WithRequiredPrincipal(ad => ad.Event)
                .WillCascadeOnDelete(true);

            modelBuilder.Entity<Evaluation>()
                .HasRequired(g => g.Evaluator)
                .WithMany(s => s.Evaluations)
                .HasForeignKey(s => s.EvaluatorId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasRequired(g => g.Picture)
                .WithMany(s => s.Users)
                .HasForeignKey(s => s.PictureId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Reserve>()
                .HasRequired(g => g.User)
                .WithMany(s => s.Reserves)
                .HasForeignKey(s => s.UserId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Address>()
                .HasOptional(s => s.Park)
                .WithOptionalPrincipal(ad => ad.Address);

            modelBuilder.Entity<Ground>()
                .HasRequired(g => g.Park)
                .WithMany(s => s.Grounds)
                .HasForeignKey(s => s.ParkId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Picture>()
                .HasOptional(s => s.Park)
                .WithOptionalPrincipal(ad => ad.Picture);

            modelBuilder.Entity<Picture>()
                .HasOptional(s => s.Ground)
                .WithOptionalPrincipal(ad => ad.Picture);

            modelBuilder.Entity<Picture>()
                .HasOptional(s => s.Sport)
                .WithOptionalPrincipal(ad => ad.Picture);

            modelBuilder.Entity<Reserve>()
                .HasRequired(g => g.Sport)
                .WithMany(s => s.Reserves)
                .HasForeignKey(s => s.SportId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Sport>()
                .HasMany(s => s.Grounds)
                .WithMany(c => c.Sports)
                .Map(cs =>
                {
                    cs.MapLeftKey("SportRefId");
                    cs.MapRightKey("GroundRefId");
                    cs.ToTable("SportsGrounds");
                });

            modelBuilder.Entity<User>()
                .HasRequired(g => g.County)
                .WithMany(s => s.Users)
                .HasForeignKey(s => s.CountyId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Address>()
                .HasRequired(g => g.County)
                .WithMany(s => s.Addresses)
                .HasForeignKey(s => s.CountyId);

            modelBuilder.Entity<County>()
                .HasRequired(g => g.District)
                .WithMany(s => s.Counties)
                .HasForeignKey(s => s.DistrictId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Reserve>()
                .HasRequired(g => g.Ground)
                .WithMany(s => s.Reserves)
                .HasForeignKey(s => s.GroundId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<UserEvaluation>().Map(m =>
            {
                m.MapInheritedProperties();
                m.ToTable("UserEvaluations");
            });

            modelBuilder.Entity<ParkEvaluation>().Map(m =>
            {
                m.MapInheritedProperties();
                m.ToTable("ParkEvaluations");
            });

            modelBuilder.Entity<Evaluation>()
                .Property(p => p.EvaluationId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);


            modelBuilder.Entity<UserClassification>().Map(m =>
            {
                m.MapInheritedProperties();
                m.ToTable("UserClassifications");
            });

            modelBuilder.Entity<ParkClassification>().Map(m =>
            {
                m.MapInheritedProperties();
                m.ToTable("ParkClassifications");
            });

            modelBuilder.Entity<Classification>()
                .Property(p => p.ClassificationId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            modelBuilder.Entity<UserClassification>()
                .HasRequired(s => s.User)
                .WithRequiredPrincipal(ad => ad.UserClassification);

            modelBuilder.Entity<ParkClassification>()
                .HasRequired(s => s.Park)
                .WithRequiredPrincipal(ad => ad.ParkClassification);

            modelBuilder.Entity<UserEvaluation>()
                .HasRequired(g => g.Evaluated)
                .WithMany(s => s.UserEvaluations)
                .HasForeignKey(s => s.UserId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ParkEvaluation>()
                .HasRequired(g => g.Park)
                .WithMany(s => s.ParkEvaluations)
                .HasForeignKey(s => s.ParkId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Material>()
                .HasRequired(g => g.Park)
                .WithMany(s => s.Materials)
                .HasForeignKey(s => s.ParkId);

            modelBuilder.Entity<Material>()
                .HasRequired(g => g.Sport)
                .WithMany(s => s.Materials)
                .HasForeignKey(s => s.SportId);

            modelBuilder.Entity<Use>()
                .HasRequired(g => g.Material)
                .WithMany(s => s.Uses)
                .HasForeignKey(s => s.MaterialId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Use>()
                .HasRequired(g => g.Reserve)
                .WithMany(s => s.Uses)
                .HasForeignKey(s => s.ReserveId)
                .WillCascadeOnDelete(true);
        }


    }
}
