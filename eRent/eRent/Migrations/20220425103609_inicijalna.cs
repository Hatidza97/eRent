using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eRent.Migrations
{
    public partial class inicijalna : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Drzava",
                columns: table => new
                {
                    DrzavaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drzava", x => x.DrzavaID);
                });

            migrationBuilder.CreateTable(
                name: "Kategorija",
                columns: table => new
                {
                    KategorijaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NazivKategorije = table.Column<string>(maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kategorija", x => x.KategorijaID);
                });

            migrationBuilder.CreateTable(
                name: "TipObjekta",
                columns: table => new
                {
                    TipObjektaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tip = table.Column<string>(maxLength: 30, nullable: false),
                    MaxKapacitet = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__TipObjek__B4E3931421868EC0", x => x.TipObjektaID);
                });

            migrationBuilder.CreateTable(
                name: "Uloga",
                columns: table => new
                {
                    UlogaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Uloga", x => x.UlogaID);
                });

            migrationBuilder.CreateTable(
                name: "Grad",
                columns: table => new
                {
                    GradID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(maxLength: 30, nullable: false),
                    DrzavaID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grad", x => x.GradID);
                    table.ForeignKey(
                        name: "fk_grad_drzava",
                        column: x => x.DrzavaID,
                        principalTable: "Drzava",
                        principalColumn: "DrzavaID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Korisnik",
                columns: table => new
                {
                    KorisnikID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(maxLength: 30, nullable: false),
                    Password = table.Column<string>(maxLength: 30, nullable: false),
                    UlogaID = table.Column<int>(nullable: false),
                    Ime = table.Column<string>(maxLength: 30, nullable: false),
                    Prezime = table.Column<string>(maxLength: 30, nullable: false),
                    Email = table.Column<string>(maxLength: 30, nullable: true),
                    Telefon = table.Column<string>(maxLength: 30, nullable: true),
                    Adresa = table.Column<string>(maxLength: 30, nullable: true),
                    Aktivan = table.Column<bool>(nullable: true),
                    GradID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Korisnik", x => x.KorisnikID);
                    table.ForeignKey(
                        name: "fk_korisnik_grad",
                        column: x => x.GradID,
                        principalTable: "Grad",
                        principalColumn: "GradID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_korisnik_uloga",
                        column: x => x.UlogaID,
                        principalTable: "Uloga",
                        principalColumn: "UlogaID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Autorizacija",
                columns: table => new
                {
                    AutorizacijaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KorisnikID = table.Column<int>(nullable: false),
                    DodajFunkcija = table.Column<bool>(nullable: true),
                    BrisiFunkcija = table.Column<bool>(nullable: true),
                    UrediFunkcija = table.Column<bool>(nullable: true),
                    CitajFunkcija = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Autorizacija", x => x.AutorizacijaID);
                    table.ForeignKey(
                        name: "fk_autorizacija_korisnik",
                        column: x => x.KorisnikID,
                        principalTable: "Korisnik",
                        principalColumn: "KorisnikID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Objekat",
                columns: table => new
                {
                    ObjekatID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(maxLength: 30, nullable: false),
                    VlasnikID = table.Column<int>(nullable: false),
                    GradID = table.Column<int>(nullable: false),
                    Adresa = table.Column<string>(maxLength: 30, nullable: false),
                    KategorijaID = table.Column<int>(nullable: false),
                    Aktivan = table.Column<bool>(nullable: false),
                    BrTelefona = table.Column<string>(maxLength: 30, nullable: true),
                    Email = table.Column<string>(maxLength: 30, nullable: true),
                    TipObjektaID = table.Column<int>(nullable: false),
                    Rezervisano = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Objekat", x => x.ObjekatID);
                    table.ForeignKey(
                        name: "fk_kategorija_objekat",
                        column: x => x.KategorijaID,
                        principalTable: "Kategorija",
                        principalColumn: "KategorijaID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_objekat_tip",
                        column: x => x.TipObjektaID,
                        principalTable: "TipObjekta",
                        principalColumn: "TipObjektaID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_vlasnik_objekat",
                        column: x => x.VlasnikID,
                        principalTable: "Korisnik",
                        principalColumn: "KorisnikID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Cjenovnik",
                columns: table => new
                {
                    CjenovnikID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ObjekatID = table.Column<int>(nullable: false),
                    VaziOd = table.Column<DateTime>(type: "date", nullable: false),
                    VaziDo = table.Column<DateTime>(type: "date", nullable: false),
                    Cijena = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cjenovnik", x => x.CjenovnikID);
                    table.ForeignKey(
                        name: "fk_Objekat_Cjenovnik",
                        column: x => x.ObjekatID,
                        principalTable: "Objekat",
                        principalColumn: "ObjekatID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ObjekatSlike",
                columns: table => new
                {
                    ObjekatSlikeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ObjekatID = table.Column<int>(nullable: false),
                    ObjekatSLike = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ObjekatSlike", x => x.ObjekatSlikeID);
                    table.ForeignKey(
                        name: "fk_objekat_slike",
                        column: x => x.ObjekatID,
                        principalTable: "Objekat",
                        principalColumn: "ObjekatID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Rezervacija",
                columns: table => new
                {
                    RezervacijaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ObjekatID = table.Column<int>(nullable: false),
                    GostID = table.Column<int>(nullable: false),
                    DatumRezervacije = table.Column<DateTime>(type: "date", nullable: false),
                    DatumPrijave = table.Column<DateTime>(type: "date", nullable: false),
                    DatumOdjave = table.Column<DateTime>(type: "date", nullable: false),
                    CjenovikID = table.Column<int>(nullable: false),
                    Cijena = table.Column<double>(nullable: false),
                    Vrijednost = table.Column<double>(nullable: false),
                    KorisnikID = table.Column<int>(nullable: false),
                    BrojMjestaDjeca = table.Column<int>(nullable: true),
                    BrojMjestaOdrasli = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rezervacija", x => x.RezervacijaID);
                    table.ForeignKey(
                        name: "fk_rez_gost",
                        column: x => x.GostID,
                        principalTable: "Korisnik",
                        principalColumn: "KorisnikID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_rez_korisnik",
                        column: x => x.KorisnikID,
                        principalTable: "Korisnik",
                        principalColumn: "KorisnikID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_rez_obje",
                        column: x => x.ObjekatID,
                        principalTable: "Objekat",
                        principalColumn: "ObjekatID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Boravak",
                columns: table => new
                {
                    BoravakID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RezervacijaID = table.Column<int>(nullable: false),
                    BoravioOd = table.Column<DateTime>(type: "date", nullable: false),
                    BoravioDo = table.Column<DateTime>(type: "date", nullable: false),
                    Komentar = table.Column<string>(type: "text", nullable: true),
                    Ocjena = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Boravak", x => x.BoravakID);
                    table.ForeignKey(
                        name: "fk_boravak_rezervacija",
                        column: x => x.RezervacijaID,
                        principalTable: "Rezervacija",
                        principalColumn: "RezervacijaID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Autorizacija_KorisnikID",
                table: "Autorizacija",
                column: "KorisnikID");

            migrationBuilder.CreateIndex(
                name: "IX_Boravak_RezervacijaID",
                table: "Boravak",
                column: "RezervacijaID");

            migrationBuilder.CreateIndex(
                name: "IX_Cjenovnik_ObjekatID",
                table: "Cjenovnik",
                column: "ObjekatID");

            migrationBuilder.CreateIndex(
                name: "IX_Grad_DrzavaID",
                table: "Grad",
                column: "DrzavaID");

            migrationBuilder.CreateIndex(
                name: "IX_Korisnik_GradID",
                table: "Korisnik",
                column: "GradID");

            migrationBuilder.CreateIndex(
                name: "IX_Korisnik_UlogaID",
                table: "Korisnik",
                column: "UlogaID");

            migrationBuilder.CreateIndex(
                name: "IX_Objekat_KategorijaID",
                table: "Objekat",
                column: "KategorijaID");

            migrationBuilder.CreateIndex(
                name: "IX_Objekat_TipObjektaID",
                table: "Objekat",
                column: "TipObjektaID");

            migrationBuilder.CreateIndex(
                name: "IX_Objekat_VlasnikID",
                table: "Objekat",
                column: "VlasnikID");

            migrationBuilder.CreateIndex(
                name: "IX_ObjekatSlike_ObjekatID",
                table: "ObjekatSlike",
                column: "ObjekatID");

            migrationBuilder.CreateIndex(
                name: "IX_Rezervacija_GostID",
                table: "Rezervacija",
                column: "GostID");

            migrationBuilder.CreateIndex(
                name: "IX_Rezervacija_KorisnikID",
                table: "Rezervacija",
                column: "KorisnikID");

            migrationBuilder.CreateIndex(
                name: "IX_Rezervacija_ObjekatID",
                table: "Rezervacija",
                column: "ObjekatID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Autorizacija");

            migrationBuilder.DropTable(
                name: "Boravak");

            migrationBuilder.DropTable(
                name: "Cjenovnik");

            migrationBuilder.DropTable(
                name: "ObjekatSlike");

            migrationBuilder.DropTable(
                name: "Rezervacija");

            migrationBuilder.DropTable(
                name: "Objekat");

            migrationBuilder.DropTable(
                name: "Kategorija");

            migrationBuilder.DropTable(
                name: "TipObjekta");

            migrationBuilder.DropTable(
                name: "Korisnik");

            migrationBuilder.DropTable(
                name: "Grad");

            migrationBuilder.DropTable(
                name: "Uloga");

            migrationBuilder.DropTable(
                name: "Drzava");
        }
    }
}
