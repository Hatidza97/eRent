using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace eRent.Database
{
    public partial class MobisContext : DbContext
    {
        public MobisContext()
        {
        }

        public MobisContext(DbContextOptions<MobisContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Autorizacija> Autorizacijas { get; set; }
        public virtual DbSet<Boravak> Boravaks { get; set; }
        public virtual DbSet<Cjenovnik> Cjenovniks { get; set; }
        public virtual DbSet<Drzava> Drzavas { get; set; }
        public virtual DbSet<Grad> Grads { get; set; }
        public virtual DbSet<Kategorija> Kategorijas { get; set; }
        public virtual DbSet<Korisnik> Korisniks { get; set; }
        public virtual DbSet<Objekat> Objekats { get; set; }
        public virtual DbSet<ObjekatSlike> ObjekatSlikes { get; set; }
        public virtual DbSet<Rezervacija> Rezervacijas { get; set; }
        public virtual DbSet<TipObjektum> TipObjekta { get; set; }
        public virtual DbSet<Uloga> Ulogas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=localhost; Initial Catalog=Mobis1;user=admin;Password=admin123!");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Autorizacija>(entity =>
            {
                entity.ToTable("Autorizacija");

                entity.Property(e => e.AutorizacijaId).HasColumnName("AutorizacijaID");

                entity.Property(e => e.KorisnikId).HasColumnName("KorisnikID");

                entity.HasOne(d => d.Korisnik)
                    .WithMany(p => p.Autorizacijas)
                    .HasForeignKey(d => d.KorisnikId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_autorizacija_korisnik");
            });

            modelBuilder.Entity<Boravak>(entity =>
            {
                entity.ToTable("Boravak");

                entity.Property(e => e.BoravakId).HasColumnName("BoravakID");

                entity.Property(e => e.BoravioDo).HasColumnType("date");

                entity.Property(e => e.BoravioOd).HasColumnType("date");

                entity.Property(e => e.Komentar).HasColumnType("text");

                entity.Property(e => e.RezervacijaId).HasColumnName("RezervacijaID");

                entity.HasOne(d => d.Rezervacija)
                    .WithMany(p => p.Boravaks)
                    .HasForeignKey(d => d.RezervacijaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_boravak_rezervacija");
            });

            modelBuilder.Entity<Cjenovnik>(entity =>
            {
                entity.ToTable("Cjenovnik");

                entity.Property(e => e.CjenovnikId).HasColumnName("CjenovnikID");

                entity.Property(e => e.ObjekatId).HasColumnName("ObjekatID");

                entity.Property(e => e.VaziDo).HasColumnType("date");

                entity.Property(e => e.VaziOd).HasColumnType("date");

                entity.HasOne(d => d.Objekat)
                    .WithMany(p => p.Cjenovniks)
                    .HasForeignKey(d => d.ObjekatId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Objekat_Cjenovnik");
            });

            modelBuilder.Entity<Drzava>(entity =>
            {
                entity.ToTable("Drzava");

                entity.Property(e => e.DrzavaId).HasColumnName("DrzavaID");

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<Grad>(entity =>
            {
                entity.ToTable("Grad");

                entity.Property(e => e.GradId).HasColumnName("GradID");

                entity.Property(e => e.DrzavaId).HasColumnName("DrzavaID");

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.HasOne(d => d.Drzava)
                    .WithMany(p => p.Grads)
                    .HasForeignKey(d => d.DrzavaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_grad_drzava");
            });

            modelBuilder.Entity<Kategorija>(entity =>
            {
                entity.ToTable("Kategorija");

                entity.Property(e => e.KategorijaId).HasColumnName("KategorijaID");

                entity.Property(e => e.NazivKategorije)
                    .IsRequired()
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<Korisnik>(entity =>
            {
                entity.ToTable("Korisnik");

                entity.Property(e => e.KorisnikId).HasColumnName("KorisnikID");

                entity.Property(e => e.Adresa).HasMaxLength(30);

                entity.Property(e => e.Email).HasMaxLength(30);

                entity.Property(e => e.GradId).HasColumnName("GradID");

                entity.Property(e => e.Ime)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.Prezime)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.Telefon).HasMaxLength(30);

                entity.Property(e => e.UlogaId).HasColumnName("UlogaID");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.HasOne(d => d.Grad)
                    .WithMany(p => p.Korisniks)
                    .HasForeignKey(d => d.GradId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_korisnik_grad");

                entity.HasOne(d => d.Uloga)
                    .WithMany(p => p.Korisniks)
                    .HasForeignKey(d => d.UlogaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_korisnik_uloga");
            });

            modelBuilder.Entity<Objekat>(entity =>
            {
                entity.ToTable("Objekat");

                entity.Property(e => e.ObjekatId).HasColumnName("ObjekatID");

                entity.Property(e => e.Adresa)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.BrTelefona).HasMaxLength(30);

                entity.Property(e => e.Email).HasMaxLength(30);

                entity.Property(e => e.GradId).HasColumnName("GradID");

                entity.Property(e => e.KategorijaId).HasColumnName("KategorijaID");

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.TipObjektaId).HasColumnName("TipObjektaID");

                entity.Property(e => e.VlasnikId).HasColumnName("VlasnikID");

                entity.HasOne(d => d.Kategorija)
                    .WithMany(p => p.Objekats)
                    .HasForeignKey(d => d.KategorijaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_kategorija_objekat");

                entity.HasOne(d => d.TipObjekta)
                    .WithMany(p => p.Objekats)
                    .HasForeignKey(d => d.TipObjektaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_objekat_tip");

                entity.HasOne(d => d.Vlasnik)
                    .WithMany(p => p.Objekats)
                    .HasForeignKey(d => d.VlasnikId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_vlasnik_objekat");
            });

            modelBuilder.Entity<ObjekatSlike>(entity =>
            {
                entity.ToTable("ObjekatSlike");

                entity.Property(e => e.ObjekatSlikeId).HasColumnName("ObjekatSlikeID");

                entity.Property(e => e.ObjekatId).HasColumnName("ObjekatID");

                entity.Property(e => e.ObjekatSlike1).HasColumnName("ObjekatSLike");

                entity.HasOne(d => d.Objekat)
                    .WithMany(p => p.ObjekatSlikes)
                    .HasForeignKey(d => d.ObjekatId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_objekat_slike");
            });

            modelBuilder.Entity<Rezervacija>(entity =>
            {
                entity.ToTable("Rezervacija");

                entity.Property(e => e.RezervacijaId).HasColumnName("RezervacijaID");

                entity.Property(e => e.CjenovnikId).HasColumnName("CjenovikID");

                entity.Property(e => e.DatumOdjave).HasColumnType("date");

                entity.Property(e => e.DatumPrijave).HasColumnType("date");

                entity.Property(e => e.DatumRezervacije).HasColumnType("date");

                entity.Property(e => e.GostId).HasColumnName("GostID");

                entity.Property(e => e.KorisnikId).HasColumnName("KorisnikID");

                entity.Property(e => e.ObjekatId).HasColumnName("ObjekatID");

                entity.HasOne(d => d.Gost)
                    .WithMany(p => p.RezervacijaGosts)
                    .HasForeignKey(d => d.GostId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_rez_gost");

                entity.HasOne(d => d.Korisnik)
                    .WithMany(p => p.RezervacijaKorisniks)
                    .HasForeignKey(d => d.KorisnikId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_rez_korisnik");

                entity.HasOne(d => d.Objekat)
                    .WithMany(p => p.Rezervacijas)
                    .HasForeignKey(d => d.ObjekatId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_rez_obje");
            });

            modelBuilder.Entity<TipObjektum>(entity =>
            {
                entity.HasKey(e => e.TipObjektaId)
                    .HasName("PK__TipObjek__B4E3931421868EC0");

                entity.Property(e => e.TipObjektaId).HasColumnName("TipObjektaID");

                entity.Property(e => e.Tip)
                    .IsRequired()
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<Uloga>(entity =>
            {
                entity.ToTable("Uloga");

                entity.Property(e => e.UlogaId).HasColumnName("UlogaID");

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(30);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
