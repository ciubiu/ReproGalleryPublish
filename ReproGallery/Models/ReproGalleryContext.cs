using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ReproGallery.Models;

public class ReproGalleryContext : IdentityDbContext
{
    public ReproGalleryContext(DbContextOptions<ReproGalleryContext> options) : base(options)
    {
    }

    public DbSet<Repro> Repros { get; set; }
    public DbSet<Author> Authors { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<GalleryCartItem> GalleryCartItems { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<OrderDetail> OrderDetails { get; set; }

    //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //{
    //    optionsBuilder
    //        .LogTo(Console.WriteLine) // Optional: Configure other logging
    //        .EnableSensitiveDataLogging(); // Enable sensitive data logging
    //}


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Seed data
        modelBuilder.Entity<Author>().HasData(
            new Author { AuthorId = 1, Name = "Arnold Akberg" },
            new Author { AuthorId = 2, Name = "Ernst Jõesaar" },
            new Author { AuthorId = 3, Name = "Andrus Johani" },
            new Author { AuthorId = 4, Name = "Aleksander Krims" },
            new Author { AuthorId = 5, Name = "Malle Leis" },    // 5
            new Author { AuthorId = 6, Name = "Paul Liivak" },
            new Author { AuthorId = 7, Name = "Olav Maran" },
            new Author { AuthorId = 8, Name = "Leili Muuga" },
            new Author { AuthorId = 9, Name = "Naima Neidre" },
            new Author { AuthorId = 10, Name = "Villem Ormisson" }, // 10
            new Author { AuthorId = 11, Name = "Karl Pärsimägi" },
            new Author { AuthorId = 12, Name = "Priit Pangsepp" },
            new Author { AuthorId = 13, Name = "Agu Pihelga" },
            new Author { AuthorId = 14, Name = "Kaljo Põllu" },
            new Author { AuthorId = 15, Name = "Felix Randel" },   // 15
            new Author { AuthorId = 16, Name = "Richard Sagrits" },
            new Author { AuthorId = 17, Name = "Lembit Sarapuu" },
            new Author { AuthorId = 18, Name = "Alexander Georg Schlater" },
            new Author { AuthorId = 19, Name = "Rein Tammik" },
            new Author { AuthorId = 20, Name = "Vive Tolli" },     // 20
            new Author { AuthorId = 21, Name = "Ado Vabbe" },
            new Author { AuthorId = 22, Name = "Aleksander Vardi" },
            new Author { AuthorId = 23, Name = "Aili Vint" },
            new Author { AuthorId = 24, Name = "Tõnis Vint" },
            new Author { AuthorId = 25, Name = "Eduard Wiiralt" }  // 25


        );

        // Seed data
        modelBuilder.Entity<Category>().HasData(
            new Category { CategoryId = 1, Name = "Abstract" },
            new Category { CategoryId = 2, Name = "Figure" },
            new Category { CategoryId = 3, Name = "Landscape" },
            new Category { CategoryId = 4, Name = "Still Life" }
        );

        modelBuilder.Entity<Repro>().HasData(
            new Repro
            {
                ReproId = 1,
                Name = "Kompositsioon",
                ImageUrl = "/img/repro/akberg_a_komposistioon_c_01542.jpg",
                Description = "1925",
                Price = 1.99M,
                AuthorId = 1,
                CategoryId = 1
            },
            new Repro
            {
                ReproId = 2,
                Name = "Mööduv",
                ImageUrl = "/img/repro/j6esaar_m66duv_asc1827.jpg",
                Description = "1971",
                Price = 2.99M,
                AuthorId = 2,
                CategoryId = 3
            },
            new Repro
            {
                ReproId = 3,
                Name = "Päevitajad",
                ImageUrl = "/img/repro/johani_a_paevitajad_c_07076.jpg",
                Description = "1934",
                Price = 3.99M,
                AuthorId = 3,
                CategoryId = 2
            },
            new Repro
            {
                ReproId = 4,
                Name = "Kohvikus ",
                ImageUrl = "/img/repro/krims_a_kohvikus_kaksikportree_c_00633.jpg",
                Description = "Kohvikus (Kaksikportree), 1930",
                Price = 4.99M,
                AuthorId = 4,
                CategoryId = 2
            },
            new Repro
            {
                ReproId = 5,
                Name = "Lilled I",
                ImageUrl = "/img/repro/leis_lilled_i_asc8104.jpg",
                Description = "paber, 1971",
                Price = 5.99M,
                AuthorId = 5,
                CategoryId = 4
            },
            new Repro
            {
                ReproId = 6,
                Name = "Häire!",
                ImageUrl = "/img/repro/leis_m_h2ire_dsc3432.jpg",
                Description = "1968",
                Price = 5.99M,
                AuthorId = 5,
                CategoryId = 1
            },
            new Repro
            {
                ReproId = 7,
                Name = "Lilled LXXVI",
                ImageUrl = "/img/repro/leis_m_lilled_lxxvi_eda9772.jpg",
                Description = "1978",
                Price = 5.99M,
                AuthorId = 5,
                CategoryId = 4
            },
            new Repro
            {
                ReproId = 8,
                Name = "Võrumaa III",
                ImageUrl = "/img/repro/leis_m_v6rumaa_iii_edb7011.jpg",
                Description = "1979",
                Price = 5.99M,
                AuthorId = 5,
                CategoryId = 4
            },
            new Repro
            {
                ReproId = 9,
                Name = "Jõemaastik",
                ImageUrl = "/img/repro/liivak_p_j6emaastik_eda4156.jpg",
                Description = "1926",
                Price = 5.99M,
                AuthorId = 6,
                CategoryId = 3
            },
            new Repro
            {
                ReproId = 10,
                Name = "Vaikelu taimeõli pudeliga",
                ImageUrl = "/img/repro/maran_o_vaikelu_taime6li_pudeliga_edb0765.jpg",
                Description = "1974",
                Price = 5.99M,
                AuthorId = 7,
                CategoryId = 4
            },
            new Repro
            {
                ReproId = 11,
                Name = "Forellid",
                ImageUrl = "/img/repro/muuga_l_forellid_0ds1086.jpg",
                Description = "1960",
                Price = 5.99M,
                AuthorId = 8,
                CategoryId = 4
            },
            new Repro
            {
                ReproId = 12,
                Name = "Natüürmort pipraga",
                ImageUrl = "/img/repro/muuga_l_natuurmort_pipraga_0ds1081.jpg",
                Description = "1966",
                Price = 5.99M,
                AuthorId = 8,
                CategoryId = 4
            },
            new Repro
            {
                ReproId = 13,
                Name = "Tumedusse tõmbujad",
                ImageUrl = "/img/repro/neidre_n_tumedusse_tombujad.jpg",
                Description = "1997",
                Price = 5.99M,
                AuthorId = 9,
                CategoryId = 1
            },
            new Repro
            {
                ReproId = 14,
                Name = "Lilled",
                ImageUrl = "/img/repro/ormisson_v_lilled_0ds6626_x.jpg",
                Description = "1918, 1978",
                Price = 5.99M,
                AuthorId = 10,
                CategoryId = 4
            },
            new Repro
            {
                ReproId = 15,
                Name = "Natüürmort klaveriga",
                ImageUrl = "/img/repro/ormisson_v_natuurmort_klaveriga_0ds6611_t.jpg",
                Description = "1926",
                Price = 5.99M,
                AuthorId = 10,
                CategoryId = 4
            },
            new Repro
            {
                ReproId = 16,
                Name = "Õunad vaibal",
                ImageUrl = "/img/repro/ormisson_v_ounad_vaibal_0ds6652_1.jpg",
                Description = "1927",
                Price = 5.99M,
                AuthorId = 10,
                CategoryId = 4
            },
            new Repro
            {
                ReproId = 17,
                Name = "Interjöör aknaga",
                ImageUrl = "/img/repro/p4rsim4gi_k_interj88r_aknaga_scan_c_01624.jpg",
                Description = "1935",
                Price = 5.99M,
                AuthorId = 11,
                CategoryId = 3
            },
            new Repro
            {
                ReproId = 18,
                Name = "Sinised pilved",
                ImageUrl = "/img/repro/pangsepp_sinised_pilved_slaid_3191.jpg",
                Description = "1996",
                Price = 5.99M,
                AuthorId = 12,
                CategoryId = 2
            },
            new Repro
            {
                ReproId = 19,
                Name = "Vaade aknast",
                ImageUrl = "/img/repro/pihelga_a_vaade_aknast_edb0388.jpg",
                Description = "1960",
                Price = 5.99M,
                AuthorId = 13,
                CategoryId = 3
            },
            new Repro
            {
                ReproId = 20,
                Name = "Päikesevene",
                ImageUrl = "/img/repro/pollu_k_paikesevene_0ds4690.jpg",
                Description = "1968",
                Price = 5.99M,
                AuthorId = 14,
                CategoryId = 2
            },
            new Repro
            {
                ReproId = 21,
                Name = "Kaks naist",
                ImageUrl = "/img/repro/randel_f_kaks_naist_c_01526.jpg",
                Description = "1924",
                Price = 5.99M,
                AuthorId = 15,
                CategoryId = 2
            },
            new Repro
            {
                ReproId = 22,
                Name = "Naised rannal",
                ImageUrl = "/img/repro/randel_f_naised_rannal_c_02266.jpg",
                Description = "1940",
                Price = 5.99M,
                AuthorId = 15,
                CategoryId = 2
            },
            new Repro
            {
                ReproId = 23,
                Name = "Puhkepäev rannal",
                ImageUrl = "/img/repro/sagrits_puhkep2ev_rannal_asc6064.jpg",
                Description = "1946",
                Price = 5.99M,
                AuthorId = 16,
                CategoryId = 3
            },
            new Repro
            {
                ReproId = 24,
                Name = "Tuuline päev",
                ImageUrl = "/img/repro/sagrits_tuuline_p2ev_asc6021.jpg",
                Description = "1953",
                Price = 5.99M,
                AuthorId = 16,
                CategoryId = 3
            },
            new Repro
            {
                ReproId = 25,
                Name = "Vana Tallinn",
                ImageUrl = "/img/repro/sagrits_vana_tallinn_ace3601.jpg",
                Description = "1951",
                Price = 5.99M,
                AuthorId = 16,
                CategoryId = 3
            },
            new Repro
            {
                ReproId = 26,
                Name = "Toidukaupluse müüja",
                ImageUrl = "/img/repro/sarapuu_l_toidukaupluse_muuja_ds71837.jpg",
                Description = "1979",
                Price = 5.99M,
                AuthorId = 17,
                CategoryId = 2
            },
            new Repro
            {
                ReproId = 27,
                Name = "Vaade Tallinnale",
                ImageUrl = "/img/repro/schlater_a_g_vaade_tallinnale_s00251_rgb.jpg",
                Description = "1870",
                Price = 5.99M,
                AuthorId = 18,
                CategoryId = 3
            },
            new Repro
            {
                ReproId = 28,
                Name = "1945-1975",
                ImageUrl = "/img/repro/tammik_r_1945-1975_b00457_rgbgrop.jpg",
                Description = "1975",
                Price = 5.99M,
                AuthorId = 19,
                CategoryId = 2
            },
            new Repro
            {
                ReproId = 29,
                Name = "Rõõmu laul",
                ImageUrl = "/img/repro/tolli_v_roomu_laul_7bh2397.jpg",
                Description = "1970",
                Price = 5.99M,
                AuthorId = 20,
                CategoryId = 1
            },
            new Repro
            {
                ReproId = 30,
                Name = "Naine mandoliiniga",
                ImageUrl = "/img/repro/vabbe_a_naine_mandoliiniga_7bc0215.jpg",
                Description = "1918",
                Price = 5.99M,
                AuthorId = 21,
                CategoryId = 2
            },
            new Repro
            {
                ReproId = 31,
                Name = "Karneval. Kompositsioon figuuriga",
                ImageUrl = "/img/repro/vabbe_kompositsioon_figuuriga_basc_4165_.jpg",
                Description = "1916",
                Price = 5.99M,
                AuthorId = 21,
                CategoryId = 2
            },
            new Repro
            {
                ReproId = 32,
                Name = "Muusika",
                ImageUrl = "/img/repro/vabbe_muusika_basc_4147_.jpg",
                Description = "1919",
                Price = 5.99M,
                AuthorId = 21,
                CategoryId = 1
            },
            new Repro
            {
                ReproId = 33,
                Name = "Aken minu ateljees",
                ImageUrl = "/img/repro/vardi_a_aken_minu_ateljees_c_09299_104.jpg",
                Description = "1960",
                Price = 5.99M,
                AuthorId = 22,
                CategoryId = 4
            },
            new Repro
            {
                ReproId = 34,
                Name = "Naine päikesevarjuga",
                ImageUrl = "/img/repro/vardi_aleksander_naine_paiksevarjuga_s00257.jpg",
                Description = "1939",
                Price = 5.99M,
                AuthorId = 22,
                CategoryId = 2
            },
            new Repro
            {
                ReproId = 35,
                Name = "Variatsioonid III E",
                ImageUrl = "/img/repro/vint_a_variatsioonid_iii_e_edg0038_.jpg",
                Description = "1986",
                Price = 5.99M,
                AuthorId = 23,
                CategoryId = 1
            },
            new Repro
            {
                ReproId = 36,
                Name = "Tüdruk ringis",
                ImageUrl = "/img/repro/vint_tonis_tudruk_ringis_atc0113.jpg",
                Description = "1975",
                Price = 5.99M,
                AuthorId = 24,
                CategoryId = 2
            },
            new Repro
            {
                ReproId = 37,
                Name = "Aktid maastikus",
                ImageUrl = "/img/repro/wiiralt_aktid_maastikus_d_04736.jpg",
                Description = "1934",
                Price = 5.99M,
                AuthorId = 25,
                CategoryId = 2
            }







        );

        


        // No store type was specified for the decimal property 'Price' on entity type 'Repro'.
        // This will cause values to be silently truncated if they do not fit in
        // the default precision and scale.
        // Explicitly specify the SQL server column type that can accommodate all the values
        // in 'OnModelCreating' using 'HasColumnType', specify precision and
        // scale using 'HasPrecision', or configure a value converter using 'HasConversion'.
        modelBuilder.Entity<Repro>()
            .Property(r => r.Price)
            .HasColumnType("decimal(8,2)");

        modelBuilder.Entity<OrderDetail>()
            .Property(od => od.Price)
            .HasColumnType("decimal(10,2)");

        modelBuilder.Entity<Order>()
            .Property(o => o.OrderTotal)
            .HasColumnType("decimal(12,2)");
    }
}
