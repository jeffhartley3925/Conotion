using Conotion.Models.Context;

namespace Conotion.Models
{
	using System;
	using System.Data.Entity;

	public class ConotionContext : DbContext, IConotionContext
	{
		public ConotionContext()
			: base("name=ConotionContext")
		{
		}

		public DbSet<Author> Authors { get; set; }
		public DbSet<Arc> Arcs { get; set; }
		public DbSet<Chord> Chords { get; set; }
		public DbSet<Collaboration> Collaborations { get; set; }
		public DbSet<Composition> Compositions { get; set; }
		public DbSet<Disposition> Dispositions { get; set; }
		public DbSet<Measure> Measures { get; set; }
		public DbSet<Note> Notes { get; set; }
		public DbSet<Staffgroup> Staffgroups { get; set; }
		public DbSet<Staff> Staffs { get; set; }
		public DbSet<Verse> Verses { get; set; }
		public DbSet<Provenance> Provenances { get; set; }
		public DbSet<Instrument> Instruments { get; set; }
		public DbSet<Vector> Vectors { get; set; }
		public DbSet<Key> Keys { get; set; }

		public void Save()
		{
			base.SaveChanges();
		}

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			modelBuilder.Entity<Verse>().ToTable("Lyrics");
		}

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    this.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
	}
}
