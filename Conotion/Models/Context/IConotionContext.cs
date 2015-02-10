using System.Data.Entity;

namespace Conotion.Models.Context
{
    public interface IConotionContext
    {
        DbSet<Author> Authors { get; set; }
        DbSet<Arc> Arcs { get; set; }
        DbSet<Chord> Chords { get; set; }
        DbSet<Collaboration> Collaborations { get; set; }
        DbSet<Composition> Compositions { get; set; }
        DbSet<Disposition> Dispositions { get; set; }
        DbSet<Measure> Measures { get; set; }
        DbSet<Note> Notes { get; set; }
        DbSet<Staffgroup> Staffgroups { get; set; }
        DbSet<Staff> Staffs { get; set; }
        DbSet<Verse> Verses { get; set; }
        DbSet<Provenance> Provenances { get; set; }
        DbSet<Instrument> Instruments { get; set; }
        DbSet<Vector> Vectors { get; set; }
        DbSet<Key> Keys { get; set; }

        void Save();
        void Dispose();

    }
}