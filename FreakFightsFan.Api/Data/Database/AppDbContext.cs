﻿using FreakFightsFan.Api.Abstractions;
using FreakFightsFan.Api.Data.Entities;
using FreakFightsFan.Shared.Features.Fights.Helpers;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace FreakFightsFan.Api.Data.Database;

public class AppDbContext(
    DbContextOptions<AppDbContext> options,
    IClock clock)
    : DbContext(options)
{
    public DbSet<Federation> Federations { get; set; }
    public DbSet<Event> Events { get; set; }
    public DbSet<Fight> Fights { get; set; }
    public DbSet<Team> Teams { get; set; }
    public DbSet<TeamFighter> TeamFighters { get; set; }
    public DbSet<Fighter> Fighters { get; set; }
    public DbSet<Image> Images { get; set; }
    public DbSet<MyDictionary> MyDictionaries { get; set; }
    public DbSet<MyDictionaryItem> MyDictionaryItems { get; set; }
    public DbSet<User> Users { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        var date = clock.Current();

        modelBuilder.Entity<User>().HasData(new List<User>
        {
            new()
            {
                Id = 1,
                Email = "freakfightsfan@gmail.com",
                UserName = "SuperAdmin",
                Password =
                    "AQAAAAIAAYagAAAAECWFTp9uY78qPzaRu0d3uaJNo3WOlRpwCuCyDLH+yg/TowsjzlMGxMurTnvyZaYSxA==",
                EmailConfirmed = true,
                EmailConfirmationToken = null,
                IsSuperAdmin = true,
                IsAdmin = true,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 2,
                Email = "freakfightsfan1@gmail.com",
                UserName = "Admin",
                Password =
                    "AQAAAAIAAYagAAAAECWFTp9uY78qPzaRu0d3uaJNo3WOlRpwCuCyDLH+yg/TowsjzlMGxMurTnvyZaYSxA==",
                EmailConfirmed = true,
                EmailConfirmationToken = null,
                IsSuperAdmin = false,
                IsAdmin = true,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 3,
                Email = "freakfightsfan2@gmail.com",
                UserName = "User",
                Password =
                    "AQAAAAIAAYagAAAAECWFTp9uY78qPzaRu0d3uaJNo3WOlRpwCuCyDLH+yg/TowsjzlMGxMurTnvyZaYSxA==",
                EmailConfirmed = true,
                EmailConfirmationToken = null,
                IsSuperAdmin = false,
                IsAdmin = false,
                Created = date,
                Modified = date
            }
        });

        modelBuilder.Entity<MyDictionary>().HasData(new List<MyDictionary>
        {
            new()
            {
                Id = 1,
                Code = "CITY",
                Name = "Cities",
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 2,
                Code = "HALL",
                Name = "Halls",
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 3,
                Code = "FIGHT_TYPE",
                Name = "Fight Type",
                Created = date,
                Modified = date
            }
        });

        modelBuilder.Entity<MyDictionaryItem>().HasData(new List<MyDictionaryItem>
        {
            // CITY
            new()
            {
                Id = 1,
                DictionaryId = 1,
                Code = "KOSZALIN",
                Name = "Koszalin",
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 2,
                DictionaryId = 1,
                Code = "POZNAN",
                Name = "Poznań",
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 3,
                DictionaryId = 1,
                Code = "LODZ",
                Name = "Łódź",
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 4,
                DictionaryId = 1,
                Code = "CZESTOCHOWA",
                Name = "Częstochowa",
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 5,
                DictionaryId = 1,
                Code = "GDANSK_SOPOT",
                Name = "Gdańsk/Sopot",
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 6,
                DictionaryId = 1,
                Code = "NIEPORAZ",
                Name = "Nieporaz",
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 7,
                DictionaryId = 1,
                Code = "GLIWICE",
                Name = "Gliwice",
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 8,
                DictionaryId = 1,
                Code = "KRAKOW",
                Name = "Kraków",
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 9,
                DictionaryId = 1,
                Code = "NEWCASTLE",
                Name = "Newcastle",
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 10,
                DictionaryId = 1,
                Code = "WROCLAW",
                Name = "Wrocław",
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 11,
                DictionaryId = 1,
                Code = "SZCZECIN",
                Name = "Szczecin",
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 24,
                DictionaryId = 1,
                Code = "GDYNIA",
                Name = "Gdynia",
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 26,
                DictionaryId = 1,
                Code = "RADOM",
                Name = "Radom",
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 29,
                DictionaryId = 1,
                Code = "TORUN",
                Name = "Toruń",
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 31,
                DictionaryId = 1,
                Code = "WARSZAWA",
                Name = "Warszawa",
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 33,
                DictionaryId = 1,
                Code = "KATOWICE",
                Name = "Katowice",
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 36,
                DictionaryId = 1,
                Code = "PLOCK",
                Name = "Płock",
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 38,
                DictionaryId = 1,
                Code = "ZIELONA_GORA",
                Name = "Zielona Góra",
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 41,
                DictionaryId = 1,
                Code = "JASIONKA",
                Name = "Jasionka",
                Created = date,
                Modified = date
            },

            // HALL
            new()
            {
                Id = 12,
                DictionaryId = 2,
                Code = "HWS_KOSZALIN",
                Name = "Hala Widowiskowo-Sportowa",
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 13,
                DictionaryId = 2,
                Code = "HWSA_POZNAN",
                Name = "Hala widowiskowo-sportowa Arena",
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 14,
                DictionaryId = 2,
                Code = "AA_LODZ",
                Name = "Atlas Arena",
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 15,
                DictionaryId = 2,
                Code = "HS_CZESTOCHOWA",
                Name = "Hala Sportowa",
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 16,
                DictionaryId = 2,
                Code = "EA_GDANSK_SOPOT",
                Name = "Ergo Arena",
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 17,
                DictionaryId = 2,
                Code = "AS_NIEPORAZ",
                Name = "Alvernia Studios",
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 18,
                DictionaryId = 2,
                Code = "DTBHHL_LODZ",
                Name = "DoubleTree by Hilton Hotel Łódź",
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 19,
                DictionaryId = 2,
                Code = "AG_GLIWICE",
                Name = "Arena Gliwice",
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 20,
                DictionaryId = 2,
                Code = "TA_KRAKOW",
                Name = "Tauron Arena",
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 21,
                DictionaryId = 2,
                Code = "UA_NEWCASTLE",
                Name = "Utilita Arena",
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 22,
                DictionaryId = 2,
                Code = "HS_WROCLAW",
                Name = "Hala Stulecia",
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 23,
                DictionaryId = 2,
                Code = "NA_SZCZECIN",
                Name = "Netto Arena",
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 25,
                DictionaryId = 2,
                Code = "GA_GDYNIA",
                Name = "Gdynia Arena",
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 27,
                DictionaryId = 2,
                Code = "RCS_RADOM",
                Name = "Radomskie Centrum Sportu",
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 28,
                DictionaryId = 2,
                Code = "HO_WROCLAW",
                Name = "Hala „Orbita”",
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 30,
                DictionaryId = 2,
                Code = "AT_TORUN",
                Name = "Arena Toruń",
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 32,
                DictionaryId = 2,
                Code = "FSO_WARSZAWA",
                Name = "Fabryka Samochodów Osobowych",
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 34,
                DictionaryId = 2,
                Code = "S_KATOWICE",
                Name = "Spodek",
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 35,
                DictionaryId = 2,
                Code = "COST_WARSZAWA",
                Name = "COS Torwar",
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 37,
                DictionaryId = 2,
                Code = "OA_PLOCK",
                Name = "Orlen Arena",
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 39,
                DictionaryId = 2,
                Code = "HCRS_ZIELONA_GORA",
                Name = "Hala CRS",
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 40,
                DictionaryId = 2,
                Code = "WKDZIK_WARSZAWA",
                Name = "WK DZIK",
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 42,
                DictionaryId = 2,
                Code = "G2AA_JASIONKA",
                Name = "G2A Arena",
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 43,
                DictionaryId = 2,
                Code = "FCS_CZESTOCHOWA",
                Name = "Fitness Club Scout",
                Created = date,
                Modified = date
            },

            // FIGHT_TYPE
            new()
            {
                Id = 44,
                DictionaryId = 3,
                Code = "MAIN_EVENT",
                Name = "Main Event",
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 45,
                DictionaryId = 3,
                Code = "COMAIN_EVENT",
                Name = "Co-Main Event",
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 46,
                DictionaryId = 3,
                Code = "MAIN_CARD",
                Name = "Main Card",
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 47,
                DictionaryId = 3,
                Code = "PRELIMINARY_CARD",
                Name = "Preliminary Card",
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 48,
                DictionaryId = 3,
                Code = "SUPER_FIGHT",
                Name = "Super Fight",
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 49,
                DictionaryId = 3,
                Code = "ADDITIONAL_FIGHT",
                Name = "Additional Fight",
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 50,
                DictionaryId = 3,
                Code = "EXTRA_FIGHT",
                Name = "Extra Fight",
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 51,
                DictionaryId = 3,
                Code = "SUPER_FREAK_FIGHT",
                Name = "Super Freak Fight",
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 52,
                DictionaryId = 3,
                Code = "BONUS_FIGHT",
                Name = "Bonus Fight",
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 53,
                DictionaryId = 3,
                Code = "HALLOWEEN_FIGHT",
                Name = "Halloween Fight",
                Created = date,
                Modified = date
            }
        });

        modelBuilder.Entity<Fighter>().HasData(new List<Fighter>
        {
            // Fame 1: Boxdel vs. Guzik
            new()
            {
                Id = 1,
                Created = date,
                Modified = date,
                FirstName = "Michał",
                LastName = "Bogawski",
                Nickname = "Łysy Bogas",
                InstagramUrl = "https://www.instagram.com/bogas_official"
            },
            new()
            {
                Id = 2,
                Created = date,
                Modified = date,
                FirstName = "Sebastian",
                LastName = "Ztrolowany",
                Nickname = "Nowak",
                InstagramUrl = "https://www.instagram.com/ztrolowanyt/"
            },
            new()
            {
                Id = 3,
                Created = date,
                Modified = date,
                FirstName = "Marek",
                LastName = "Wilczak",
                Nickname = "Maro",
                InstagramUrl = "https://www.instagram.com/wilczaktrenuje/"
            },
            new()
            {
                Id = 4,
                Created = date,
                Modified = date,
                FirstName = "Łukasz",
                LastName = "Lupa",
                Nickname = "Lupa",
                InstagramUrl = "https://www.instagram.com/lupa_k.o/"
            },
            new()
            {
                Id = 5,
                Created = date,
                Modified = date,
                FirstName = "Hubert",
                LastName = "Korczak",
                Nickname = "Ken",
                InstagramUrl = "https://www.instagram.com/travelwithmops/"
            },
            new()
            {
                Id = 6,
                Created = date,
                Modified = date,
                FirstName = "Krystian",
                LastName = "Wilczak",
                Nickname = "Krycha",
                InstagramUrl = "https://www.instagram.com/krystian.wilczak/"
            },
            new()
            {
                Id = 7,
                Created = date,
                Modified = date,
                FirstName = "Michał",
                LastName = "Handke",
                Nickname = "Handke",
                InstagramUrl = "https://www.instagram.com/handke_michal_/"
            },
            new()
            {
                Id = 8,
                Created = date,
                Modified = date,
                FirstName = "Maksymilian",
                LastName = "Wiewiórka",
                Nickname = "Wiewiór",
                InstagramUrl = "https://www.instagram.com/wiewior_official/"
            },
            new()
            {
                Id = 9,
                Created = date,
                Modified = date,
                FirstName = "Dawid",
                LastName = "Ambroziak",
                Nickname = "Ambro",
                InstagramUrl = "https://www.instagram.com/dawambro/"
            },
            new()
            {
                Id = 10,
                Created = date,
                Modified = date,
                FirstName = "Dawid",
                LastName = "Ozdoba",
                Nickname = "Surfer",
                InstagramUrl = "https://www.instagram.com/dawidozdobateam/"
            },
            new()
            {
                Id = 11,
                Created = date,
                Modified = date,
                FirstName = "Piotr",
                LastName = "Celej",
                Nickname = "Celej",
                InstagramUrl = "https://www.instagram.com/piotr_celej/"
            },
            new()
            {
                Id = 12,
                Created = date,
                Modified = date,
                FirstName = "Krzysztof",
                LastName = "Olczak",
                Nickname = "Olczak",
                InstagramUrl = null
            },
            new()
            {
                Id = 13,
                Created = date,
                Modified = date,
                FirstName = "Daniel",
                LastName = "Zwierzyński",
                Nickname = "Magical",
                InstagramUrl = "https://www.instagram.com/danielmagical/"
            },
            new()
            {
                Id = 14,
                Created = date,
                Modified = date,
                FirstName = "Adrian",
                LastName = "Polański",
                Nickname = "Polak",
                InstagramUrl = "https://www.instagram.com/adrianpolak/"
            },
            new()
            {
                Id = 15,
                Created = date,
                Modified = date,
                FirstName = "Michał",
                LastName = "Baron",
                Nickname = "Boxdel",
                InstagramUrl = "https://www.instagram.com/boxdel/"
            },
            new()
            {
                Id = 16,
                Created = date,
                Modified = date,
                FirstName = "Jakub",
                LastName = "Szymański",
                Nickname = "Guzik",
                InstagramUrl = "https://www.instagram.com/guzikyt/"
            },

            // Fame 2: Rafonix vs. Magical
            new()
            {
                Id = 17,
                Created = date,
                Modified = date,
                FirstName = "Kamil",
                LastName = "Stępiński",
                Nickname = "Kasti",
                InstagramUrl = "https://www.instagram.com/kamilkasti/"
            },
            new()
            {
                Id = 18,
                Created = date,
                Modified = date,
                FirstName = "Artur",
                LastName = "Walczak",
                Nickname = "Waluś",
                InstagramUrl = "https://www.instagram.com/artur_walus_walczak/"
            },
            new()
            {
                Id = 19,
                Created = date,
                Modified = date,
                FirstName = "Piotr",
                LastName = "Czapiewski",
                Nickname = "Czapi",
                InstagramUrl = "https://www.instagram.com/czapistrong_mman/"
            },
            new()
            {
                Id = 20,
                Created = date,
                Modified = date,
                FirstName = "Piotr",
                LastName = "Tyburski",
                Nickname = "Tybori",
                InstagramUrl = "https://www.instagram.com/piotr_loveislandpolska/"
            },
            new()
            {
                Id = 21,
                Created = date,
                Modified = date,
                FirstName = "Paweł ",
                LastName = "Tyburski",
                Nickname = "Księżniczka",
                InstagramUrl = "https://www.instagram.com/pablotybori/"
            },
            new()
            {
                Id = 22,
                Created = date,
                Modified = date,
                FirstName = "Piotr",
                LastName = "Kluk",
                Nickname = "Kluk",
                InstagramUrl = "https://www.instagram.com/pietrokluk/"
            },
            new()
            {
                Id = 23,
                Created = date,
                Modified = date,
                FirstName = "Paweł",
                LastName = "Kluk",
                Nickname = "Kluk",
                InstagramUrl = "https://www.instagram.com/szef8989/"
            },
            new()
            {
                Id = 24,
                Created = date,
                Modified = date,
                FirstName = "Piotr",
                LastName = "Witczak",
                Nickname = "Bonus BGC",
                InstagramUrl = "https://www.instagram.com/bonusbgc_official/"
            },
            new()
            {
                Id = 25,
                Created = date,
                Modified = date,
                FirstName = "Amadeusz",
                LastName = "Roślik",
                Nickname = "Ferrari",
                InstagramUrl = "https://www.instagram.com/amadeusznolove/"
            },
            new()
            {
                Id = 26,
                Created = date,
                Modified = date,
                FirstName = "Sylwester",
                LastName = "Tkocz",
                Nickname = "Bystrzak",
                InstagramUrl = "https://www.instagram.com/bystrzaktv/"
            },
            new()
            {
                Id = 27,
                Created = date,
                Modified = date,
                FirstName = "Marek",
                LastName = "Hoffmann",
                Nickname = "AdBuster",
                InstagramUrl = "https://www.instagram.com/adbunio/"
            },
            new()
            {
                Id = 28,
                Created = date,
                Modified = date,
                FirstName = "Dawid",
                LastName = "Malczyński",
                Nickname = "Bocian",
                InstagramUrl = "https://www.instagram.com/dawid.malczynski/"
            },
            new()
            {
                Id = 29,
                Created = date,
                Modified = date,
                FirstName = "Marcin",
                LastName = "Krasucki",
                Nickname = "Rafonix",
                InstagramUrl = "https://www.instagram.com/rafonixofficial/"
            },

            // Fame 3: IsAmU vs. DeeJayPallaside
            new()
            {
                Id = 30,
                Created = date,
                Modified = date,
                FirstName = "Kamil",
                LastName = "Hassan",
                Nickname = "Hassi",
                InstagramUrl = "https://www.instagram.com/kamilhassi/"
            },
            new()
            {
                Id = 31,
                Created = date,
                Modified = date,
                FirstName = "Krzysztof",
                LastName = "Ciesielski",
                Nickname = "Bodychrist",
                InstagramUrl = "https://www.instagram.com/bodychrist.official/"
            },
            new()
            {
                Id = 32,
                Created = date,
                Modified = date,
                FirstName = "Marcin",
                LastName = "Wójcik",
                Nickname = "Mnich Terminator",
                InstagramUrl = "https://www.instagram.com/projekt_jasnowidz/"
            },
            new()
            {
                Id = 33,
                Created = date,
                Modified = date,
                FirstName = "Bartosz",
                LastName = "Brzeziński",
                Nickname = "Ruby",
                InstagramUrl = "https://www.instagram.com/ruby_nolove_official/"
            },
            new()
            {
                Id = 34,
                Created = date,
                Modified = date,
                FirstName = "Kasjusz",
                LastName = "Życiński",
                Nickname = "Don Kasjo",
                InstagramUrl = "https://www.instagram.com/donkasjo/"
            },
            new()
            {
                Id = 35,
                Created = date,
                Modified = date,
                FirstName = "Filip",
                LastName = "Marcinek",
                Nickname = "Filipek",
                InstagramUrl = "https://www.instagram.com/filipek1995/"
            },
            new()
            {
                Id = 36,
                Created = date,
                Modified = date,
                FirstName = "Patryk",
                LastName = "Karaś",
                Nickname = "Ryba",
                InstagramUrl = "https://www.instagram.com/ryba_free/"
            },
            new()
            {
                Id = 37,
                Created = date,
                Modified = date,
                FirstName = "Szymon",
                LastName = "Wrzesień",
                Nickname = "Taxi Złotówa",
                InstagramUrl = "https://www.instagram.com/taxizlotowa/"
            },
            new()
            {
                Id = 38,
                Created = date,
                Modified = date,
                FirstName = "Marta",
                LastName = "Linkiewicz",
                Nickname = "Linkimaster",
                InstagramUrl = "https://www.instagram.com/linkimaster/"
            },
            new()
            {
                Id = 39,
                Created = date,
                Modified = date,
                FirstName = "Monika",
                LastName = "Godlewska",
                Nickname = "Esmeralda",
                InstagramUrl = "https://www.instagram.com/esmeraldagodlewska_official/"
            },
            new()
            {
                Id = 40,
                Created = date,
                Modified = date,
                FirstName = "Szymon",
                LastName = "IsAmU",
                Nickname = "Kasprzyk",
                InstagramUrl = "https://www.instagram.com/isamupt/"
            },
            new()
            {
                Id = 41,
                Created = date,
                Modified = date,
                FirstName = "Daniel",
                LastName = "Pawlak",
                Nickname = "DeeJayPallaside",
                InstagramUrl = "https://www.instagram.com/deejaypallaside/"
            },

            // Fame 4: Linkimaster vs. Lil Masti
            new()
            {
                Id = 42,
                Created = date,
                Modified = date,
                FirstName = "Krystian",
                LastName = "Brzeziński",
                Nickname = "Jongmen",
                InstagramUrl = "https://www.instagram.com/jongmen_official/"
            },
            new()
            {
                Id = 43,
                Created = date,
                Modified = date,
                FirstName = "Łukasz",
                LastName = "Imiełowski",
                Nickname = "Tomb",
                InstagramUrl = "https://www.instagram.com/king.tomb/"
            },
            new()
            {
                Id = 44,
                Created = date,
                Modified = date,
                FirstName = "Patryk",
                LastName = "Woziński",
                Nickname = "Kizo",
                InstagramUrl = "https://www.instagram.com/kizo_wnik_058/"
            },
            new()
            {
                Id = 45,
                Created = date,
                Modified = date,
                FirstName = "Marcin",
                LastName = "Makowski",
                Nickname = "Mielonidas",
                InstagramUrl = "https://www.instagram.com/mielonidas/"
            },
            new()
            {
                Id = 46,
                Created = date,
                Modified = date,
                FirstName = "Jakub",
                LastName = "Flas",
                Nickname = "Kubańczyk",
                InstagramUrl = "https://www.instagram.com/kubanczyk.official/"
            },
            new()
            {
                Id = 47,
                Created = date,
                Modified = date,
                FirstName = "Adrian",
                LastName = "Salamon",
                Nickname = "Medusa",
                InstagramUrl = "https://www.instagram.com/medusaoficjalnie/"
            },
            new()
            {
                Id = 48,
                Created = date,
                Modified = date,
                FirstName = "Piotr",
                LastName = "Knaś",
                Nickname = "Knaziuu",
                InstagramUrl = null
            },
            new()
            {
                Id = 49,
                Created = date,
                Modified = date,
                FirstName = "Aniela",
                LastName = "Bogusz",
                Nickname = "Lil Masti",
                InstagramUrl = "https://www.instagram.com/lilmasti/"
            },

            // Fame 5: Bonus BGC vs. Najman
            new()
            {
                Id = 50,
                Created = date,
                Modified = date,
                FirstName = "Oleh",
                LastName = "Riaszeńczew",
                Nickname = "Oleg",
                InstagramUrl = "https://www.instagram.com/just_oleg.official/"
            },
            new()
            {
                Id = 51,
                Created = date,
                Modified = date,
                FirstName = "Ewelina",
                LastName = "Kubiak",
                Nickname = "Ewelona",
                InstagramUrl = "https://www.instagram.com/ewel0na/"
            },
            new()
            {
                Id = 52,
                Created = date,
                Modified = date,
                FirstName = "Tomasz",
                LastName = "Olejnik",
                Nickname = "Olejnik",
                InstagramUrl = "https://www.instagram.com/tomek_olejnik/"
            },
            new()
            {
                Id = 53,
                Created = date,
                Modified = date,
                FirstName = "Mateusz",
                LastName = "Krzyżanowski",
                Nickname = "Mini Majk",
                InstagramUrl = "https://www.instagram.com/_minimajk/"
            },
            new()
            {
                Id = 54,
                Created = date,
                Modified = date,
                FirstName = "Marek",
                LastName = "Kruszel",
                Nickname = "Lord Kruszwil",
                InstagramUrl = "https://www.instagram.com/kruszwil/"
            },
            new()
            {
                Id = 55,
                Created = date,
                Modified = date,
                FirstName = "Marcin",
                LastName = "Malczyński",
                Nickname = "Malczyński",
                InstagramUrl = "https://www.instagram.com/marcinmalczynski/"
            },
            new()
            {
                Id = 56,
                Created = date,
                Modified = date,
                FirstName = "Marcin",
                LastName = "Najman",
                Nickname = "El Testosteron",
                InstagramUrl = "https://www.instagram.com/marcin.najman/"
            },

            // Fame 6: Zusje vs. Linkimaster
            new()
            {
                Id = 57,
                Created = date,
                Modified = date,
                FirstName = "Maciej",
                LastName = "Szewczyk",
                Nickname = "Szewcu",
                InstagramUrl = "https://www.instagram.com/szewcowaty/"
            },
            new()
            {
                Id = 58,
                Created = date,
                Modified = date,
                FirstName = "Alan",
                LastName = "Kwieciński",
                Nickname = "Kwieciński",
                InstagramUrl = "https://www.instagram.com/alan.kwiecinski92/"
            },
            new()
            {
                Id = 59,
                Created = date,
                Modified = date,
                FirstName = "Arkadiusz",
                LastName = "Tańcula",
                Nickname = "AroY",
                InstagramUrl = "https://www.instagram.com/arkadiusz_tancula/"
            },
            new()
            {
                Id = 60,
                Created = date,
                Modified = date,
                FirstName = "Bartosz",
                LastName = "Kubik",
                Nickname = "Qbik",
                InstagramUrl = "https://www.instagram.com/qbik95/"
            },
            new()
            {
                Id = 61,
                Created = date,
                Modified = date,
                FirstName = "Cyprian",
                LastName = "Racicki",
                Nickname = "Cypis",
                InstagramUrl = "https://www.instagram.com/cypis89/"
            },
            new()
            {
                Id = 62,
                Created = date,
                Modified = date,
                FirstName = "Maciej",
                LastName = "Rataj",
                Nickname = "Rataj",
                InstagramUrl = "https://www.instagram.com/m_rataaj/"
            },
            new()
            {
                Id = 63,
                Created = date,
                Modified = date,
                FirstName = "Mateusz",
                LastName = "Łapot",
                Nickname = "L-Pro",
                InstagramUrl = "https://www.instagram.com/lpro.official/"
            },
            new()
            {
                Id = 64,
                Created = date,
                Modified = date,
                FirstName = "Piotr",
                LastName = "Piechowiak",
                Nickname = "Bestia",
                InstagramUrl = "https://www.instagram.com/piotr.piechowiak/"
            },
            new()
            {
                Id = 65,
                Created = date,
                Modified = date,
                FirstName = "Wojciech",
                LastName = "Gola",
                Nickname = "Gola",
                InstagramUrl = "https://www.instagram.com/wojtekgola/"
            },
            new()
            {
                Id = 66,
                Created = date,
                Modified = date,
                FirstName = "Kamila",
                LastName = "Smogulecka",
                Nickname = "Zusje",
                InstagramUrl = "https://www.instagram.com/zusjeofficial/"
            },

            // Fame 7: Popek vs. Stifler
            new()
            {
                Id = 67,
                Created = date,
                Modified = date,
                FirstName = "Dariusz",
                LastName = "Kaźmierczuk",
                Nickname = "Daro Lew",
                InstagramUrl = "https://www.instagram.com/daroo_lew/"
            },
            new()
            {
                Id = 68,
                Created = date,
                Modified = date,
                FirstName = "Mariusz",
                LastName = "Słoński",
                Nickname = "Hejter",
                InstagramUrl = "https://www.instagram.com/hejter_96/"
            },
            new()
            {
                Id = 69,
                Created = date,
                Modified = date,
                FirstName = "Marta",
                LastName = "Rentel",
                Nickname = "Martirenti",
                InstagramUrl = "https://www.instagram.com/martirenti/"
            },
            new()
            {
                Id = 70,
                Created = date,
                Modified = date,
                FirstName = "Paweł",
                LastName = "Mikołajuw",
                Nickname = "Popek Monster",
                InstagramUrl = "https://www.instagram.com/popek_oficjalnie/"
            },
            new()
            {
                Id = 71,
                Created = date,
                Modified = date,
                FirstName = "Damian",
                LastName = "Zduńczyk",
                Nickname = "Stifler",
                InstagramUrl = "https://www.instagram.com/stifler16cm/"
            },

            // Fame 8: Dubiel vs. Blonsky
            new()
            {
                Id = 72,
                Created = date,
                Modified = date,
                FirstName = "Gamou",
                LastName = "Fall",
                Nickname = "Gamou",
                InstagramUrl = "https://www.instagram.com/iamgamoufall/"
            },
            new()
            {
                Id = 73,
                Created = date,
                Modified = date,
                FirstName = "Piotr",
                LastName = "Pająk",
                Nickname = "Pająk",
                InstagramUrl = "https://www.instagram.com/podroze_wojownika_youtube/"
            },
            new()
            {
                Id = 74,
                Created = date,
                Modified = date,
                FirstName = "Patryk",
                LastName = "Baran",
                Nickname = "Mortalcio",
                InstagramUrl = "https://www.instagram.com/mortalcioyt/"
            },
            new()
            {
                Id = 75,
                Created = date,
                Modified = date,
                FirstName = "Dagmara",
                LastName = "Szewczyk",
                Nickname = "Szewczyk",
                InstagramUrl = "https://www.instagram.com/dagmara_szewczyk/"
            },
            new()
            {
                Id = 76,
                Created = date,
                Modified = date,
                FirstName = "Piotr",
                LastName = "Szeliga",
                Nickname = "Szeli",
                InstagramUrl = "https://www.instagram.com/szeli_aesthetic/"
            },
            new()
            {
                Id = 77,
                Created = date,
                Modified = date,
                FirstName = "Gabriel",
                LastName = "Al-Sulwi",
                Nickname = "Arab",
                InstagramUrl = "https://www.instagram.com/arab_na_ficie/"
            },
            new()
            {
                Id = 78,
                Created = date,
                Modified = date,
                FirstName = "Michał",
                LastName = "Sobolewski",
                Nickname = "Sobota",
                InstagramUrl = "https://www.instagram.com/sobota_flow/"
            },
            new()
            {
                Id = 79,
                Created = date,
                Modified = date,
                FirstName = "Marcin",
                LastName = "Dubiel",
                Nickname = "Dubiel",
                InstagramUrl = "https://www.instagram.com/marcindubiel/"
            },
            new()
            {
                Id = 80,
                Created = date,
                Modified = date,
                FirstName = "Kacper",
                LastName = "Błoński",
                Nickname = "Crusher",
                InstagramUrl = "https://www.instagram.com/kacperblonsky/"
            },

            // Fame 9: Let’s Play
            new()
            {
                Id = 81,
                Created = date,
                Modified = date,
                FirstName = "Karolina",
                LastName = "Brzuszczyńska",
                Nickname = "Way of Blonde",
                InstagramUrl = "https://www.instagram.com/way.of.blonde/"
            },
            new()
            {
                Id = 82,
                Created = date,
                Modified = date,
                FirstName = "Anna",
                LastName = "Andrzejewska",
                Nickname = "Anna IFBB PRO",
                InstagramUrl = "https://www.instagram.com/anabodyfitness_/"
            },
            new()
            {
                Id = 83,
                Created = date,
                Modified = date,
                FirstName = "Mikołaj",
                LastName = "Rdzanek",
                Nickname = "Vandal",
                InstagramUrl = "https://www.instagram.com/vandalekk/"
            },
            new()
            {
                Id = 84,
                Created = date,
                Modified = date,
                FirstName = "Jakub",
                LastName = "Postaremczak",
                Nickname = "Kuba Post",
                InstagramUrl = "https://www.instagram.com/kubapost_/"
            },
            new()
            {
                Id = 85,
                Created = date,
                Modified = date,
                FirstName = "Filip",
                LastName = "Zabielski",
                Nickname = "Zabielski",
                InstagramUrl = "https://www.instagram.com/filipzabielski/"
            },
            new()
            {
                Id = 86,
                Created = date,
                Modified = date,
                FirstName = "Patryk",
                LastName = "Domke",
                Nickname = "Patrykos",
                InstagramUrl = "https://www.instagram.com/patrykos.official/"
            },
            new()
            {
                Id = 87,
                Created = date,
                Modified = date,
                FirstName = "Paweł",
                LastName = "Sikora",
                Nickname = "Ponczek",
                InstagramUrl = "https://www.instagram.com/ponczek_endomorfik/"
            },
            new()
            {
                Id = 88,
                Created = date,
                Modified = date,
                FirstName = "Kamila",
                LastName = "Wybrańczyk",
                Nickname = "Kamiszka",
                InstagramUrl = "https://www.instagram.com/kamiszkolandia/"
            },
            new()
            {
                Id = 89,
                Created = date,
                Modified = date,
                FirstName = "Sylwester",
                LastName = "Wardęga",
                Nickname = "Wardęga",
                InstagramUrl = "https://www.instagram.com/sawardega_wataha/"
            },

            // Fame 10: Don Kasjo vs. Parke
            new()
            {
                Id = 90,
                Created = date,
                Modified = date,
                FirstName = "Piotr",
                LastName = "Szczurek",
                Nickname = "Miejski Drwal",
                InstagramUrl = "https://www.instagram.com/miejski_drwal_insta/"
            },
            new()
            {
                Id = 91,
                Created = date,
                Modified = date,
                FirstName = "Michał",
                LastName = "Gała",
                Nickname = "Gała",
                InstagramUrl = "https://www.instagram.com/michalgala_official/"
            },
            new()
            {
                Id = 92,
                Created = date,
                Modified = date,
                FirstName = "Mikołaj",
                LastName = "Śmieszek",
                Nickname = "Śmieszek",
                InstagramUrl = "https://www.instagram.com/smieszekmikollaj/"
            },
            new()
            {
                Id = 93,
                Created = date,
                Modified = date,
                FirstName = "Mateusz",
                LastName = "Gąsiewski",
                Nickname = "Haribo",
                InstagramUrl = "https://www.instagram.com/matek_haribo/"
            },
            new()
            {
                Id = 94,
                Created = date,
                Modified = date,
                FirstName = "Mateusz",
                LastName = "Murański",
                Nickname = "Muran",
                InstagramUrl = "https://www.instagram.com/mateusz_muranski/"
            },
            new()
            {
                Id = 95,
                Created = date,
                Modified = date,
                FirstName = "Cezary",
                LastName = "Czaro",
                Nickname = "Nykiel",
                InstagramUrl = "https://www.instagram.com/czaronykiel/"
            },
            new()
            {
                Id = 96,
                Created = date,
                Modified = date,
                FirstName = "Norman",
                LastName = "Parke",
                Nickname = "Stormin",
                InstagramUrl = "https://www.instagram.com/storminnorman6116/"
            },

            // Fame 11: Fight Club
            new()
            {
                Id = 97,
                Created = date,
                Modified = date,
                FirstName = "Jakub",
                LastName = "Kaczmarski",
                Nickname = "Dragon",
                InstagramUrl = "https://www.instagram.com/dragon_xmma/"
            },
            new()
            {
                Id = 98,
                Created = date,
                Modified = date,
                FirstName = "Roger",
                LastName = "Irlik",
                Nickname = "Irlik",
                InstagramUrl = "https://www.instagram.com/rogerirlik/"
            },
            new()
            {
                Id = 99,
                Created = date,
                Modified = date,
                FirstName = "Adrian",
                LastName = "Wieliczko",
                Nickname = "Pitbull",
                InstagramUrl = "https://www.instagram.com/adrian_wieliczko/"
            },
            new()
            {
                Id = 100,
                Created = date,
                Modified = date,
                FirstName = "Gracjan",
                LastName = "Miś",
                Nickname = "Miś",
                InstagramUrl = "https://www.instagram.com/grackoo.m/"
            },
            new()
            {
                Id = 101,
                Created = date,
                Modified = date,
                FirstName = "Krzysztof",
                LastName = "Ferenc",
                Nickname = "Fericze",
                InstagramUrl = "https://www.instagram.com/wujaszek_fericze_kanapowcy_ttv/"
            },
            new()
            {
                Id = 102,
                Created = date,
                Modified = date,
                FirstName = "Patrycja",
                LastName = "Wieja",
                Nickname = "MeLady",
                InstagramUrl = "https://www.instagram.com/patrycjawiejaa/"
            },
            new()
            {
                Id = 103,
                Created = date,
                Modified = date,
                FirstName = "Aleksandr",
                LastName = "Muzheiko",
                Nickname = "Sasha",
                InstagramUrl = "https://www.instagram.com/aleksandrmuzheiko/"
            },
            new()
            {
                Id = 104,
                Created = date,
                Modified = date,
                FirstName = "Norbert",
                LastName = "Smoliński",
                Nickname = "Smolasty",
                InstagramUrl = "https://www.instagram.com/smolasty/"
            },
            new()
            {
                Id = 105,
                Created = date,
                Modified = date,
                FirstName = "Piotr",
                LastName = "Kołaczyński",
                Nickname = "Miły Pan",
                InstagramUrl = "https://www.instagram.com/najmilszypan/"
            },
            new()
            {
                Id = 106,
                Created = date,
                Modified = date,
                FirstName = "Maksym",
                LastName = "Ziółkowski",
                Nickname = "Maksymalnie",
                InstagramUrl = "https://www.instagram.com/maksym_ziolkowski/"
            },
            new()
            {
                Id = 107,
                Created = date,
                Modified = date,
                FirstName = "Mikołaj",
                LastName = "Magdziarz",
                Nickname = "Mixer",
                InstagramUrl = "https://www.instagram.com/therealmixer/"
            },
            new()
            {
                Id = 108,
                Created = date,
                Modified = date,
                FirstName = "Piotr",
                LastName = "Węgrzyn",
                Nickname = "Popo",
                InstagramUrl = "https://www.instagram.com/popo_667/"
            },
            new()
            {
                Id = 109,
                Created = date,
                Modified = date,
                FirstName = "Daniel",
                LastName = "Ferreri",
                Nickname = "Danny",
                InstagramUrl = "https://www.instagram.com/danny.ferreri/"
            },
            new()
            {
                Id = 110,
                Created = date,
                Modified = date,
                FirstName = "Wojciech",
                LastName = "Przeździecki",
                Nickname = "OjWojtek",
                InstagramUrl = "https://www.instagram.com/ojwojtek/"
            },
            new()
            {
                Id = 111,
                Created = date,
                Modified = date,
                FirstName = "Borys",
                LastName = "Mańkowski",
                Nickname = "The Tasmanian Devil",
                InstagramUrl = "https://www.instagram.com/mankowski.borys/"
            },

            // Fame 12: Don Kasjo vs. Polish Zombie
            new()
            {
                Id = 112,
                Created = date,
                Modified = date,
                FirstName = "Kornel",
                LastName = "Regel",
                Nickname = "Koro",
                InstagramUrl = "https://www.instagram.com/koroo97/"
            },
            new()
            {
                Id = 113,
                Created = date,
                Modified = date,
                FirstName = "Krzysztof",
                LastName = "Radzikowski",
                Nickname = "Radzik",
                InstagramUrl = "https://www.instagram.com/krzysztofradzikowski/"
            },
            new()
            {
                Id = 114,
                Created = date,
                Modified = date,
                FirstName = "Mateusz",
                LastName = "Janusz",
                Nickname = "Matt Fit Lovers",
                InstagramUrl = "https://www.instagram.com/fit.lovers/"
            },
            new()
            {
                Id = 115,
                Created = date,
                Modified = date,
                FirstName = "Marcin",
                LastName = "Wrzosek",
                Nickname = "The Polish Zombie",
                InstagramUrl = "https://www.instagram.com/polishzombiemma/"
            },
            new()
            {
                Id = 116,
                Created = date,
                Modified = date,
                FirstName = "Jacek",
                LastName = "Murański",
                Nickname = "Muran",
                InstagramUrl = "https://www.instagram.com/jaca_muran_muranski_official_/"
            },

            // Fame 13: Nitro vs. Unboxall
            new()
            {
                Id = 117,
                Created = date,
                Modified = date,
                FirstName = "Rafał",
                LastName = "Górniak",
                Nickname = "Takefun",
                InstagramUrl = "https://www.instagram.com/takefun/"
            },
            new()
            {
                Id = 118,
                Created = date,
                Modified = date,
                FirstName = "Jakub",
                LastName = "Piotrowicz",
                Nickname = "Japczan",
                InstagramUrl = "https://www.instagram.com/japczanek/"
            },
            new()
            {
                Id = 119,
                Created = date,
                Modified = date,
                FirstName = "Robert",
                LastName = "Pasut",
                Nickname = "Sutonator",
                InstagramUrl = "https://www.instagram.com/pasutabstra/"
            },
            new()
            {
                Id = 120,
                Created = date,
                Modified = date,
                FirstName = "Sergiusz",
                LastName = "Górski",
                Nickname = "Nitro",
                InstagramUrl = "https://www.instagram.com/thenitrozyniak/"
            },
            new()
            {
                Id = 121,
                Created = date,
                Modified = date,
                FirstName = "Paweł",
                LastName = "Smektalski",
                Nickname = "Unboxall",
                InstagramUrl = "https://www.instagram.com/theunboxall/"
            },

            // Fame 14: Gimper vs. Tromba
            new()
            {
                Id = 122,
                Created = date,
                Modified = date,
                FirstName = "Katarzyna",
                LastName = "Alexander",
                Nickname = "Laluna",
                InstagramUrl = "https://www.instagram.com/lala_laluna_official/"
            },
            new()
            {
                Id = 123,
                Created = date,
                Modified = date,
                FirstName = "Wiktoria",
                LastName = "Jaroniewska",
                Nickname = "Wiki",
                InstagramUrl = "https://www.instagram.com/wiktoriajaroniewskablog/"
            },
            new()
            {
                Id = 124,
                Created = date,
                Modified = date,
                FirstName = "Adam",
                LastName = "AJ",
                Nickname = "Josef",
                InstagramUrl = "https://www.instagram.com/ajthepolishamerican/"
            },
            new()
            {
                Id = 125,
                Created = date,
                Modified = date,
                FirstName = "Agata",
                LastName = "Fąk",
                Nickname = "Fagata",
                InstagramUrl = "https://www.instagram.com/fagataaa/"
            },
            new()
            {
                Id = 126,
                Created = date,
                Modified = date,
                FirstName = "Monika",
                LastName = "Kociołek",
                Nickname = "Mona",
                InstagramUrl = "https://www.instagram.com/monika.kociolek/"
            },
            new()
            {
                Id = 127,
                Created = date,
                Modified = date,
                FirstName = "Marcin",
                LastName = "Majkut",
                Nickname = "Xayoo",
                InstagramUrl = "https://www.instagram.com/xayoo777/"
            },
            new()
            {
                Id = 128,
                Created = date,
                Modified = date,
                FirstName = "Tomasz",
                LastName = "Działowy",
                Nickname = "Gimper",
                InstagramUrl = "https://www.instagram.com/gimperowski/"
            },
            new()
            {
                Id = 129,
                Created = date,
                Modified = date,
                FirstName = "Mateusz",
                LastName = "Trąbka",
                Nickname = "Tromba",
                InstagramUrl = "https://www.instagram.com/trombabomba/"
            },

            // Fame 15: Zemsta
            new()
            {
                Id = 130,
                Created = date,
                Modified = date,
                FirstName = "Radosław",
                LastName = "Kapias",
                Nickname = "Warjat Radek",
                InstagramUrl = "https://www.instagram.com/warjatradek/"
            },
            new()
            {
                Id = 131,
                Created = date,
                Modified = date,
                FirstName = "Patryk",
                LastName = "Woźniak",
                Nickname = "Woźniak",
                InstagramUrl = "https://www.instagram.com/xpatlyk/"
            },
            new()
            {
                Id = 132,
                Created = date,
                Modified = date,
                FirstName = "Jamil",
                LastName = "Neffati",
                Nickname = "Neffati Brothers",
                InstagramUrl = "https://www.instagram.com/neffati.jamil/"
            },
            new()
            {
                Id = 133,
                Created = date,
                Modified = date,
                FirstName = "Jamel",
                LastName = "Neffati",
                Nickname = "Neffati Brothers",
                InstagramUrl = "https://www.instagram.com/iamneffatijamel/"
            },
            new()
            {
                Id = 134,
                Created = date,
                Modified = date,
                FirstName = "Franciszek",
                LastName = "Rusiecki",
                Nickname = "Franio",
                InstagramUrl = "https://www.instagram.com/franio00/"
            },
            new()
            {
                Id = 135,
                Created = date,
                Modified = date,
                FirstName = "Jakub",
                LastName = "Frączek",
                Nickname = "Paramaxil",
                InstagramUrl = "https://www.instagram.com/paramaxil_/"
            },
            new()
            {
                Id = 136,
                Created = date,
                Modified = date,
                FirstName = "Mariusz",
                LastName = "Golling",
                Nickname = "Sarius",
                InstagramUrl = "https://www.instagram.com/mariuszsarius/"
            },
            new()
            {
                Id = 137,
                Created = date,
                Modified = date,
                FirstName = "Mikołaj",
                LastName = "Tylko",
                Nickname = "Konopskyy",
                InstagramUrl = "https://www.instagram.com/konopskyy_/"
            },

            // Fame 16: Tromba vs. Dubiel
            new()
            {
                Id = 138,
                Created = date,
                Modified = date,
                FirstName = "Natan",
                LastName = "Marcoń",
                Nickname = "Bóg Estetyki",
                InstagramUrl = "https://www.instagram.com/natan.marcon/"
            },
            new()
            {
                Id = 139,
                Created = date,
                Modified = date,
                FirstName = "Radosław",
                LastName = "Wiejski Koks",
                Nickname = "Paszko",
                InstagramUrl = "https://www.instagram.com/wiejskikoks/"
            },
            new()
            {
                Id = 140,
                Created = date,
                Modified = date,
                FirstName = "Dawid",
                LastName = "Rzeźnik",
                Nickname = "Dzinold",
                InstagramUrl = "https://www.instagram.com/mrdzinold/"
            },
            new()
            {
                Id = 141,
                Created = date,
                Modified = date,
                FirstName = "Szymon",
                LastName = "Besser",
                Nickname = "Szymool",
                InstagramUrl = null
            },
            new()
            {
                Id = 142,
                Created = date,
                Modified = date,
                FirstName = "Patryk",
                LastName = "Bandurski",
                Nickname = "Bandura",
                InstagramUrl = "https://www.instagram.com/bandura_cartel/"
            },

            // Fame 17: Ferrari vs. Łaszczyk
            new()
            {
                Id = 143,
                Created = date,
                Modified = date,
                FirstName = "Klaudia",
                LastName = "Kołodziejczyk",
                Nickname = "Sheeya",
                InstagramUrl = "https://www.instagram.com/xsheeya/"
            },
            new()
            {
                Id = 144,
                Created = date,
                Modified = date,
                FirstName = "Robert",
                LastName = "Karaś",
                Nickname = "Karaś",
                InstagramUrl = "https://www.instagram.com/robert_karas_teamkaras/"
            },
            new()
            {
                Id = 145,
                Created = date,
                Modified = date,
                FirstName = "Cezary",
                LastName = "Jóźwik",
                Nickname = "Czarmageddon",
                InstagramUrl = "https://www.instagram.com/czarek_/"
            },
            new()
            {
                Id = 146,
                Created = date,
                Modified = date,
                FirstName = "Wacław",
                LastName = "Osiecki",
                Nickname = "Wac Toja",
                InstagramUrl = "https://www.instagram.com/wactoja/"
            },
            new()
            {
                Id = 147,
                Created = date,
                Modified = date,
                FirstName = "Sebastian",
                LastName = "Fabijański",
                Nickname = "Alterboy",
                InstagramUrl = "https://www.instagram.com/sebastian.fabijanski.official/"
            },
            new()
            {
                Id = 148,
                Created = date,
                Modified = date,
                FirstName = "Kamil",
                LastName = "Łaszczyk",
                Nickname = "Szczurek",
                InstagramUrl = "https://www.instagram.com/kamil.laszczyk/"
            },
            new()
            {
                Id = 149,
                Created = date,
                Modified = date,
                FirstName = "Paweł",
                LastName = "Jóźwiak",
                Nickname = "Prezes FEN",
                InstagramUrl = "https://www.instagram.com/pawel.jozwiak_official/"
            },

            // Fame 18: Crusher vs. Ferrari
            new()
            {
                Id = 150,
                Created = date,
                Modified = date,
                FirstName = "Mateusz",
                LastName = "Spysiński",
                Nickname = "Spysiński",
                InstagramUrl = "https://www.instagram.com/mateusz_spysinski/"
            },
            new()
            {
                Id = 151,
                Created = date,
                Modified = date,
                FirstName = "Elizabeth",
                LastName = "Anorue",
                Nickname = "Lizi",
                InstagramUrl = "https://www.instagram.com/llleasy_/"
            },
            new()
            {
                Id = 152,
                Created = date,
                Modified = date,
                FirstName = "Dominika",
                LastName = "Rybak",
                Nickname = "Rybak",
                InstagramUrl = "https://www.instagram.com/cruelllademon/"
            },
            new()
            {
                Id = 153,
                Created = date,
                Modified = date,
                FirstName = "Michał",
                LastName = "Pasternak",
                Nickname = "Wampir",
                InstagramUrl = "https://www.instagram.com/michal_wampir_pasternak_/"
            },
            new()
            {
                Id = 154,
                Created = date,
                Modified = date,
                FirstName = "Tomasz",
                LastName = "Gromadzki",
                Nickname = "Zadyma",
                InstagramUrl = "https://www.instagram.com/tomek_zadyma/"
            },
            new()
            {
                Id = 155,
                Created = date,
                Modified = date,
                FirstName = "Ewa",
                LastName = "Brodnicka",
                Nickname = "Kleo",
                InstagramUrl = "https://www.instagram.com/ewabrodnicka_/"
            },

            // Fame 19: Tańcula vs. Ferrari
            new()
            {
                Id = 156,
                Created = date,
                Modified = date,
                FirstName = "Przemysław",
                LastName = "Szyszka",
                Nickname = "Szyszka",
                InstagramUrl = "https://www.instagram.com/szyszka.team/"
            },
            new()
            {
                Id = 157,
                Created = date,
                Modified = date,
                FirstName = "Norbert",
                LastName = "Daszkiewicz",
                Nickname = "Daszkiewicz",
                InstagramUrl = "https://www.instagram.com/norbert.daszkiewicz/"
            },
            new()
            {
                Id = 158,
                Created = date,
                Modified = date,
                FirstName = "Jakub",
                LastName = "Nowaczkiewicz",
                Nickname = "Nowaczkiewicz",
                InstagramUrl = "https://www.instagram.com/kubanowaczkiewicz/"
            },
            new()
            {
                Id = 159,
                Created = date,
                Modified = date,
                FirstName = "Alberto",
                LastName = "Simao",
                Nickname = "Alberto",
                InstagramUrl = "https://www.instagram.com/albertoloki_93/"
            },

            // Fame UK 1: Gowland vs. McKenna
            new()
            {
                Id = 160,
                Created = date,
                Modified = date,
                FirstName = "Casey",
                LastName = "Barker",
                Nickname = "Barker",
                InstagramUrl = "https://www.instagram.com/caaseybarker/"
            },
            new()
            {
                Id = 161,
                Created = date,
                Modified = date,
                FirstName = "Callum",
                LastName = "Markie",
                Nickname = "Markie",
                InstagramUrl = "https://www.instagram.com/callummarkie/"
            },
            new()
            {
                Id = 162,
                Created = date,
                Modified = date,
                FirstName = "Mike",
                LastName = "Fox",
                Nickname = "Fox",
                InstagramUrl = "https://www.instagram.com/mikefox_official/"
            },
            new()
            {
                Id = 163,
                Created = date,
                Modified = date,
                FirstName = "Andrew",
                LastName = "Henderson",
                Nickname = "Henderson",
                InstagramUrl = "https://www.instagram.com/andrewhenderson/"
            },
            new()
            {
                Id = 164,
                Created = date,
                Modified = date,
                FirstName = "Daniel",
                LastName = "O’Reilly",
                Nickname = "Dapper Laughs",
                InstagramUrl = "https://www.instagram.com/dappersinstagram/"
            },
            new()
            {
                Id = 165,
                Created = date,
                Modified = date,
                FirstName = "Michael",
                LastName = "Harvey Jr.",
                Nickname = "MC Harvey",
                InstagramUrl = null
            },
            new()
            {
                Id = 166,
                Created = date,
                Modified = date,
                FirstName = "Alistair",
                LastName = "Law",
                Nickname = "Ally",
                InstagramUrl = "https://www.instagram.com/mrallylaw/"
            },
            new()
            {
                Id = 167,
                Created = date,
                Modified = date,
                FirstName = "Joseph",
                LastName = "Henderson",
                Nickname = "Hendo",
                InstagramUrl = null
            },
            new()
            {
                Id = 168,
                Created = date,
                Modified = date,
                FirstName = "Ashley",
                LastName = "Marie",
                Nickname = "AshleyMariee",
                InstagramUrl = "https://www.instagram.com/ashleymarie/"
            },
            new()
            {
                Id = 169,
                Created = date,
                Modified = date,
                FirstName = "Georgia",
                LastName = "Harrison",
                Nickname = "Harrison",
                InstagramUrl = "https://www.instagram.com/georgialouiseharrison/"
            },
            new()
            {
                Id = 170,
                Created = date,
                Modified = date,
                FirstName = "Joel",
                LastName = "Morris",
                Nickname = "JMX",
                InstagramUrl = "https://www.instagram.com/jmx/"
            },
            new()
            {
                Id = 171,
                Created = date,
                Modified = date,
                FirstName = "Sam",
                LastName = "Gowland",
                Nickname = "Gowland",
                InstagramUrl = "https://www.instagram.com/samgowland/"
            },
            new()
            {
                Id = 172,
                Created = date,
                Modified = date,
                FirstName = "Marty",
                LastName = "McKenna",
                Nickname = "McKenna",
                InstagramUrl = "https://www.instagram.com/marty_gshore/"
            },

            // Hype S01E01: Rafonix vs. Hejter
            new()
            {
                Id = 173,
                Created = date,
                Modified = date,
                FirstName = "Norbert",
                LastName = "Krasnodębski",
                Nickname = "One Norbi",
                InstagramUrl = "https://www.instagram.com/onenorbi/"
            },
            new()
            {
                Id = 174,
                Created = date,
                Modified = date,
                FirstName = "Oskar",
                LastName = "Lesiak",
                Nickname = "Blecki",
                InstagramUrl = "https://www.instagram.com/blecki_02/"
            },
            new()
            {
                Id = 175,
                Created = date,
                Modified = date,
                FirstName = "Jakub",
                LastName = "Droździel",
                Nickname = "Kuba Trenuje",
                InstagramUrl = "https://www.instagram.com/kubatrenuje_/"
            },
            new()
            {
                Id = 176,
                Created = date,
                Modified = date,
                FirstName = "Krystian",
                LastName = "Bartocha",
                Nickname = "Krissu",
                InstagramUrl = "https://www.instagram.com/krissu.toja/"
            },
            new()
            {
                Id = 177,
                Created = date,
                Modified = date,
                FirstName = "Jakub",
                LastName = "Barczyk",
                Nickname = "Bary",
                InstagramUrl = "https://www.instagram.com/simply_bary/"
            },
            new()
            {
                Id = 178,
                Created = date,
                Modified = date,
                FirstName = "Damian",
                LastName = "Kalbarczyk",
                Nickname = "Kalbar",
                InstagramUrl = "https://www.instagram.com/kalbartoja/"
            },
            new()
            {
                Id = 179,
                Created = date,
                Modified = date,
                FirstName = "Mateusz",
                LastName = "Zakrzewski",
                Nickname = "Zakrzew",
                InstagramUrl = "https://www.instagram.com/zakrzew_wk/"
            },
            new()
            {
                Id = 180,
                Created = date,
                Modified = date,
                FirstName = "Albert",
                LastName = "Ghambaryan",
                Nickname = "Bercik",
                InstagramUrl = "https://www.instagram.com/bercik2000/"
            },
            new()
            {
                Id = 181,
                Created = date,
                Modified = date,
                FirstName = "Patryk",
                LastName = "Malinowski",
                Nickname = "Taksi ZRT",
                InstagramUrl = "https://www.instagram.com/taksinozrt/"
            },
            new()
            {
                Id = 182,
                Created = date,
                Modified = date,
                FirstName = "Władysław",
                LastName = "Zijajew",
                Nickname = "Władek",
                InstagramUrl = "https://www.instagram.com/wladek_jestem/"
            },
            new()
            {
                Id = 183,
                Created = date,
                Modified = date,
                FirstName = "Adam",
                LastName = "Woźnicki",
                Nickname = "Adix",
                InstagramUrl = "https://www.instagram.com/_adix6_/"
            },
            new()
            {
                Id = 184,
                Created = date,
                Modified = date,
                FirstName = "Paweł",
                LastName = "Szwed",
                Nickname = "Pavlloo",
                InstagramUrl = "https://www.instagram.com/pavlloo/"
            },

            // Fame Friday Arena 1: Alberto vs. Kubańczyk
            new()
            {
                Id = 185,
                Created = date,
                Modified = date,
                FirstName = "Piotr",
                LastName = "Bylina",
                Nickname = "Edzio",
                InstagramUrl = "https://www.instagram.com/edzioo/"
            },
            new()
            {
                Id = 186,
                Created = date,
                Modified = date,
                FirstName = "Olga",
                LastName = "Sałacka",
                Nickname = "Nanami Chan",
                InstagramUrl = "https://www.instagram.com/olga_salacka_/"
            },
            new()
            {
                Id = 187,
                Created = date,
                Modified = date,
                FirstName = "Dominik",
                LastName = "Jax",
                Nickname = "Jaxu",
                InstagramUrl = "https://www.instagram.com/dominik_loveneverlies/"
            },
            new()
            {
                Id = 188,
                Created = date,
                Modified = date,
                FirstName = "Piotr",
                LastName = "Świerczewski",
                Nickname = "Świr",
                InstagramUrl = "https://www.instagram.com/piotrswierczewski7/"
            },
            new()
            {
                Id = 189,
                Created = date,
                Modified = date,
                FirstName = "Jose",
                LastName = "Simao",
                Nickname = "Josef Bratan",
                InstagramUrl = "https://www.instagram.com/josefbratan/"
            },

            // Fame Friday Arena 2: Prezes FEN vs. Boxdel 2
            new()
            {
                Id = 190,
                Created = date,
                Modified = date,
                FirstName = "Roger",
                LastName = "Salla",
                Nickname = "Roger",
                InstagramUrl = "https://www.instagram.com/rogeiro20/"
            },
            new()
            {
                Id = 191,
                Created = date,
                Modified = date,
                FirstName = "Andrzej",
                LastName = "Czysz",
                Nickname = "Endi",
                InstagramUrl = "https://www.instagram.com/endifit/"
            },
            new()
            {
                Id = 192,
                Created = date,
                Modified = date,
                FirstName = "Łukasz",
                LastName = "Samoń",
                Nickname = "Mandzio",
                InstagramUrl = "https://www.instagram.com/xmandzio/"
            },
            new()
            {
                Id = 193,
                Created = date,
                Modified = date,
                FirstName = "Karol",
                LastName = "Dąbrowski",
                Nickname = "Karolek",
                InstagramUrl = "https://www.instagram.com/thekaroleq95"
            },
            new()
            {
                Id = 194,
                Created = date,
                Modified = date,
                FirstName = "Piotr",
                LastName = "Lisek",
                Nickname = "Lisek",
                InstagramUrl = "https://www.instagram.com/piotr.lisek.pv/"
            },
            new()
            {
                Id = 195,
                Created = date,
                Modified = date,
                FirstName = "Martyna",
                LastName = "Janusz",
                Nickname = "Brylantynka",
                InstagramUrl = "https://www.instagram.com/brylantynka/"
            },
            new()
            {
                Id = 196,
                Created = date,
                Modified = date,
                FirstName = "Dominik",
                LastName = "Zadora",
                Nickname = "Japoński Drwal",
                InstagramUrl = "https://www.instagram.com/zadzior_freak_fighter/"
            },
            new()
            {
                Id = 197,
                Created = date,
                Modified = date,
                FirstName = "Daniel",
                LastName = "Ostaszewski",
                Nickname = "Ostry",
                InstagramUrl = "https://www.instagram.com/megaostry/"
            },

            // Fame: Reborn
            new()
            {
                Id = 198,
                Created = date,
                Modified = date,
                FirstName = "Iga",
                LastName = "Kozińska",
                Nickname = "Kozińska",
                InstagramUrl = "https://www.instagram.com/igakozinska/"
            },
            new()
            {
                Id = 199,
                Created = date,
                Modified = date,
                FirstName = "Weronika",
                LastName = "Malinowska",
                Nickname = "Malinowska",
                InstagramUrl = "https://www.instagram.com/weronika.malinowskaa/"
            },
            new()
            {
                Id = 200,
                Created = date,
                Modified = date,
                FirstName = "Ádám",
                LastName = "Bártfai",
                Nickname = "Adam Security",
                InstagramUrl = "https://www.instagram.com/bartfaiadam7/"
            },
            new()
            {
                Id = 201,
                Created = date,
                Modified = date,
                FirstName = "Grzegorz",
                LastName = "Gancewski",
                Nickname = "Greg",
                InstagramUrl = "https://www.instagram.com/gr3gor_g3/"
            },
            new()
            {
                Id = 202,
                Created = date,
                Modified = date,
                FirstName = "Jakub",
                LastName = "Maślanka",
                Nickname = "Maślana",
                InstagramUrl = "https://www.instagram.com/kubamaslanka_/"
            },
            new()
            {
                Id = 203,
                Created = date,
                Modified = date,
                FirstName = "Natalia",
                LastName = "Korgol",
                Nickname = "Navcia",
                InstagramUrl = "https://www.instagram.com/navvvia/"
            },
            new()
            {
                Id = 204,
                Created = date,
                Modified = date,
                FirstName = "Norbert",
                LastName = "Gierczak",
                Nickname = "Dis",
                InstagramUrl = "https://www.instagram.com/disstream/"
            },
            new()
            {
                Id = 205,
                Created = date,
                Modified = date,
                FirstName = "Maciej",
                LastName = "Sulęcki",
                Nickname = "Striczu",
                InstagramUrl = "https://www.instagram.com/maciej.sulecki/"
            },

            // Prime 1: Zadyma
            new()
            {
                Id = 206,
                Created = date,
                Modified = date,
                FirstName = "Paweł",
                LastName = "Całkowski",
                Nickname = "Całkowski",
                InstagramUrl = null
            },
            new()
            {
                Id = 207,
                Created = date,
                Modified = date,
                FirstName = "Sergiusz",
                LastName = "Zając",
                Nickname = "Zając",
                InstagramUrl = "https://www.instagram.com/sergiusz.zajac.ko"
            },
            new()
            {
                Id = 208,
                Created = date,
                Modified = date,
                FirstName = "Adrian",
                LastName = "Cios",
                Nickname = "Cios",
                InstagramUrl = "https://www.instagram.com/mr_cios/"
            },
            new()
            {
                Id = 209,
                Created = date,
                Modified = date,
                FirstName = "Wiola",
                LastName = "Kotelecka",
                Nickname = "Wiolka",
                InstagramUrl = "https://www.instagram.com/viola.wiolin/"
            },
            new()
            {
                Id = 210,
                Created = date,
                Modified = date,
                FirstName = "Oliwia",
                LastName = "Sadkowska",
                Nickname = "Sadkowska",
                InstagramUrl = "https://www.instagram.com/sadkowskaoliwia/"
            },
            new()
            {
                Id = 211,
                Created = date,
                Modified = date,
                FirstName = "Jakub",
                LastName = "Rygiel",
                Nickname = "Hecman",
                InstagramUrl = "https://www.instagram.com/hecman_official/"
            },
            new()
            {
                Id = 212,
                Created = date,
                Modified = date,
                FirstName = "Rafał",
                LastName = "Pazik",
                Nickname = "Pazik",
                InstagramUrl = "https://www.instagram.com/rafalpazik/"
            },
            new()
            {
                Id = 213,
                Created = date,
                Modified = date,
                FirstName = "Jakub",
                LastName = "Lasik",
                Nickname = "Lasik",
                InstagramUrl = "https://www.instagram.com/kubalasik_official/"
            },
            new()
            {
                Id = 214,
                Created = date,
                Modified = date,
                FirstName = "Adrian",
                LastName = "Salwa",
                Nickname = "Puszbarber",
                InstagramUrl = "https://www.instagram.com/puszbarber/"
            },
            new()
            {
                Id = 215,
                Created = date,
                Modified = date,
                FirstName = "Julia",
                LastName = "Pelc",
                Nickname = "Queen of the Black",
                InstagramUrl = null
            },
            new()
            {
                Id = 216,
                Created = date,
                Modified = date,
                FirstName = "Aleksandra",
                LastName = "Okrzesik",
                Nickname = "Okrzesik",
                InstagramUrl = "https://www.instagram.com/ola_okrzesik/"
            },
            new()
            {
                Id = 217,
                Created = date,
                Modified = date,
                FirstName = "Jan",
                LastName = "Kapela",
                Nickname = "Jaś Kapela",
                InstagramUrl = "https://www.instagram.com/jas.kapela/"
            },
            new()
            {
                Id = 218,
                Created = date,
                Modified = date,
                FirstName = "Ziemowit Piast",
                LastName = "Kossakowski",
                Nickname = "Kossakowski",
                InstagramUrl = null
            },
            new()
            {
                Id = 219,
                Created = date,
                Modified = date,
                FirstName = "Dawid",
                LastName = "Narożny",
                Nickname = "Narożny",
                InstagramUrl = "https://www.instagram.com/piekniimlodzidawidnarozny/"
            },
            new()
            {
                Id = 220,
                Created = date,
                Modified = date,
                FirstName = "Łukasz",
                LastName = "Wawrzyniak",
                Nickname = "Kamerzysta",
                InstagramUrl = "https://www.instagram.com/kamerzysta69/"
            },

            // Prime 2: Kosmos
            new()
            {
                Id = 221,
                Created = date,
                Modified = date,
                FirstName = "Szymon",
                LastName = "Pilanc",
                Nickname = "Goryl",
                InstagramUrl = "https://www.instagram.com/goryl.w.akcjii/"
            },
            new()
            {
                Id = 222,
                Created = date,
                Modified = date,
                FirstName = "Kacper",
                LastName = "Kabara",
                Nickname = "Kajmano",
                InstagramUrl = "https://www.instagram.com/kajmano_dtw/"
            },
            new()
            {
                Id = 223,
                Created = date,
                Modified = date,
                FirstName = "Mateusz",
                LastName = "Mil",
                Nickname = "Milu",
                InstagramUrl = "https://www.instagram.com/mil.mateusz/"
            },
            new()
            {
                Id = 224,
                Created = date,
                Modified = date,
                FirstName = "Mikołaj",
                LastName = "Jędruszczak",
                Nickname = "Jędruszczak",
                InstagramUrl = "https://www.instagram.com/mikolaj_jedruszczak_official/"
            },
            new()
            {
                Id = 225,
                Created = date,
                Modified = date,
                FirstName = "Konrad",
                LastName = "Skolimowski",
                Nickname = "Skolim",
                InstagramUrl = "https://www.instagram.com/skolim__/"
            },
            new()
            {
                Id = 226,
                Created = date,
                Modified = date,
                FirstName = "Michał",
                LastName = "Gorzelańczyk",
                Nickname = "Bagietka",
                InstagramUrl = "https://www.instagram.com/bagietka.michael/"
            },
            new()
            {
                Id = 227,
                Created = date,
                Modified = date,
                FirstName = "Jan",
                LastName = "Patecki",
                Nickname = "Pacio",
                InstagramUrl = "https://www.instagram.com/pacioig/"
            },
            new()
            {
                Id = 228,
                Created = date,
                Modified = date,
                FirstName = "Adam",
                LastName = "Soroko",
                Nickname = "Soroko",
                InstagramUrl = "https://www.instagram.com/sorokoadam13/"
            },
            new()
            {
                Id = 229,
                Created = date,
                Modified = date,
                FirstName = "Piotr",
                LastName = "Kaluski",
                Nickname = "Peter",
                InstagramUrl = "https://www.instagram.com/peter_kaluski/"
            },
            new()
            {
                Id = 230,
                Created = date,
                Modified = date,
                FirstName = "Klaudia",
                LastName = "Kapuśniak",
                Nickname = "Klaudusiek",
                InstagramUrl = "https://www.instagram.com/klaudusiekk/"
            },
            new()
            {
                Id = 231,
                Created = date,
                Modified = date,
                FirstName = "Serigne",
                LastName = "Ousmane Dia",
                Nickname = "Bombardier",
                InstagramUrl = "https://www.instagram.com/bombardier_officiel/"
            },
            new()
            {
                Id = 232,
                Created = date,
                Modified = date,
                FirstName = "Grzegorz",
                LastName = "Szulakowski",
                Nickname = "Szuli",
                InstagramUrl = "https://www.instagram.com/szuli_mma/"
            },

            // Prime 3: Street Fighter
            new()
            {
                Id = 233,
                Created = date,
                Modified = date,
                FirstName = "Mateusz",
                LastName = "Leśniak",
                Nickname = "Tarzan",
                InstagramUrl = "https://www.instagram.com/_tarzan_g/"
            },
            new()
            {
                Id = 234,
                Created = date,
                Modified = date,
                FirstName = "Michał",
                LastName = "Cichy",
                Nickname = "Zadymiarz",
                InstagramUrl = "https://www.instagram.com/michalcichymma/"
            },
            new()
            {
                Id = 235,
                Created = date,
                Modified = date,
                FirstName = "Magdalena",
                LastName = "Lubacz",
                Nickname = "Maluba",
                InstagramUrl = "https://www.instagram.com/malubaaa/"
            },
            new()
            {
                Id = 236,
                Created = date,
                Modified = date,
                FirstName = "Maciej",
                LastName = "Jarema",
                Nickname = "Big Jack",
                InstagramUrl = "https://www.instagram.com/_bigjack69/"
            },
            new()
            {
                Id = 237,
                Created = date,
                Modified = date,
                FirstName = "Jan",
                LastName = "Kempisty",
                Nickname = "Little Johnny",
                InstagramUrl = "https://www.instagram.com/old_johnny86/"
            },
            new()
            {
                Id = 238,
                Created = date,
                Modified = date,
                FirstName = "Iliya",
                LastName = "Dzhybladze",
                Nickname = "McKsiąże",
                InstagramUrl = "https://www.instagram.com/mcksiaze/"
            },
            new()
            {
                Id = 239,
                Created = date,
                Modified = date,
                FirstName = "Jakub",
                LastName = "Armada",
                Nickname = "Kubaoxo",
                InstagramUrl = "https://www.instagram.com/kubaoxo/"
            },
            new()
            {
                Id = 240,
                Created = date,
                Modified = date,
                FirstName = "Patryk",
                LastName = "Śliwa",
                Nickname = "Robalini",
                InstagramUrl = "https://www.instagram.com/robalini69/"
            },
            new()
            {
                Id = 241,
                Created = date,
                Modified = date,
                FirstName = "Daniel",
                LastName = "Rutkowski",
                Nickname = "Rutek",
                InstagramUrl = "https://www.instagram.com/daniel_rutkowski/"
            },
            new()
            {
                Id = 242,
                Created = date,
                Modified = date,
                FirstName = "Paulina",
                LastName = "Hornik",
                Nickname = "Hornik",
                InstagramUrl = "https://www.instagram.com/paulina.hornik/"
            },
            new()
            {
                Id = 243,
                Created = date,
                Modified = date,
                FirstName = "Martyna",
                LastName = "Zbirańska",
                Nickname = "Pysia",
                InstagramUrl = "https://www.instagram.com/martyna.pysia/"
            },

            // Prime 4: Królestwo
            new()
            {
                Id = 244,
                Created = date,
                Modified = date,
                FirstName = "Rafał",
                LastName = "Gawron",
                Nickname = "Sportowy Świr",
                InstagramUrl = "https://www.instagram.com/sportowy_swir_rafal_gawron/"
            },
            new()
            {
                Id = 245,
                Created = date,
                Modified = date,
                FirstName = "Emilian",
                LastName = "Bayer",
                Nickname = "Księciunio",
                InstagramUrl = "https://www.instagram.com/ksieciunio_music/"
            },
            new()
            {
                Id = 246,
                Created = date,
                Modified = date,
                FirstName = "Ewa",
                LastName = "Piątkowska",
                Nickname = "Tygrysica",
                InstagramUrl = "https://www.instagram.com/ewa.piatkowska/"
            },
            new()
            {
                Id = 247,
                Created = date,
                Modified = date,
                FirstName = "Artur",
                LastName = "Sowiński",
                Nickname = "Kornik",
                InstagramUrl = "https://www.instagram.com/kornik_ksw/"
            },
            new()
            {
                Id = 248,
                Created = date,
                Modified = date,
                FirstName = "Adam",
                LastName = "Okniński",
                Nickname = "Młody Łowca Skór",
                InstagramUrl = "https://www.instagram.com/adam_okninski/"
            },

            // Prime 5: Don Kasjo vs. Zadora
            new()
            {
                Id = 249,
                Created = date,
                Modified = date,
                FirstName = "Ronaldo",
                LastName = "Miranda",
                Nickname = "Czarny Polak",
                InstagramUrl = "https://www.instagram.com/czarny_polak_/"
            },
            new()
            {
                Id = 250,
                Created = date,
                Modified = date,
                FirstName = "Kacper",
                LastName = "Miklasz",
                Nickname = "Polish Machine",
                InstagramUrl = "https://www.instagram.com/polish_machine_mma/"
            },
            new()
            {
                Id = 251,
                Created = date,
                Modified = date,
                FirstName = "Daniel",
                LastName = "Więcławski",
                Nickname = "Hunter",
                InstagramUrl = "https://www.instagram.com/wiecekcsw_hunter/"
            },
            new()
            {
                Id = 252,
                Created = date,
                Modified = date,
                FirstName = "Łukasz",
                LastName = "Karpiński",
                Nickname = "Karpiński",
                InstagramUrl = "https://www.instagram.com/lukaskarpinski/"
            },
            new()
            {
                Id = 253,
                Created = date,
                Modified = date,
                FirstName = "Damian",
                LastName = "Kasprzak",
                Nickname = "The Karpi",
                InstagramUrl = "https://www.instagram.com/the_karpi/"
            },
            new()
            {
                Id = 254,
                Created = date,
                Modified = date,
                FirstName = "Paweł",
                LastName = "Trybała",
                Nickname = "Trybson",
                InstagramUrl = "https://www.instagram.com/pawel_trybson_trybala/"
            },
            new()
            {
                Id = 255,
                Created = date,
                Modified = date,
                FirstName = "Patryk",
                LastName = "Masiak",
                Nickname = "Wielki B",
                InstagramUrl = "https://www.instagram.com/wielki.bu/"
            },
            new()
            {
                Id = 256,
                Created = date,
                Modified = date,
                FirstName = "Ernest",
                LastName = "Ivanda",
                Nickname = "Red",
                InstagramUrl = "https://www.instagram.com/redoficjalnie/"
            },

            // Prime 6: Premium
            new()
            {
                Id = 257,
                Created = date,
                Modified = date,
                FirstName = "Erwin",
                LastName = "Burzyński",
                Nickname = "Burzyński",
                InstagramUrl = "https://www.instagram.com/erwinburzynski/"
            },
            new()
            {
                Id = 258,
                Created = date,
                Modified = date,
                FirstName = "Mateusz",
                LastName = "Górski",
                Nickname = "Mister Mati",
                InstagramUrl = "https://www.instagram.com/mister_matii/"
            },
            new()
            {
                Id = 259,
                Created = date,
                Modified = date,
                FirstName = "Artur",
                LastName = "Głuchowski",
                Nickname = "Głuchy",
                InstagramUrl = "https://www.instagram.com/arturgluchowski/"
            },
            new()
            {
                Id = 260,
                Created = date,
                Modified = date,
                FirstName = "Patrycja",
                LastName = "Izydorczyk",
                Nickname = "Izydorczyk",
                InstagramUrl = "https://www.instagram.com/patrycja.izydorczyk/"
            },
            new()
            {
                Id = 261,
                Created = date,
                Modified = date,
                FirstName = "Aleksandra",
                LastName = "Daniel",
                Nickname = "Ms. Danielka",
                InstagramUrl = "https://www.instagram.com/ms.danielka/"
            },
            new()
            {
                Id = 262,
                Created = date,
                Modified = date,
                FirstName = "Damian",
                LastName = "Graf",
                Nickname = "Dzik",
                InstagramUrl = "https://www.instagram.com/dzik_ws/"
            },
            new()
            {
                Id = 263,
                Created = date,
                Modified = date,
                FirstName = "Rafał",
                LastName = "Jackiewicz",
                Nickname = "Jeb",
                InstagramUrl = "https://www.instagram.com/jeb_majster/"
            },
            new()
            {
                Id = 264,
                Created = date,
                Modified = date,
                FirstName = "Dominik",
                LastName = "Skowyra",
                Nickname = "Skowyra",
                InstagramUrl = "https://www.instagram.com/dominik.skowyra/"
            },
            new()
            {
                Id = 265,
                Created = date,
                Modified = date,
                FirstName = "Grzegorz",
                LastName = "Głuszcz",
                Nickname = "Hellboy",
                InstagramUrl = "https://www.instagram.com/grzegorz_hellboy_gluszcz/"
            },
            new()
            {
                Id = 266,
                Created = date,
                Modified = date,
                FirstName = "Alexander",
                LastName = "Gross",
                Nickname = "The Bestia",
                InstagramUrl = "https://www.instagram.com/thebestia97/"
            },
            new()
            {
                Id = 267,
                Created = date,
                Modified = date,
                FirstName = "Maciej",
                LastName = "Wiewiórka",
                Nickname = "Stary Wiewiór",
                InstagramUrl = "https://www.instagram.com/stary_wiewior/"
            },

            // High League 1: Lexy vs. Natsu
            new()
            {
                Id = 268,
                Created = date,
                Modified = date,
                FirstName = "Przemysław",
                LastName = "Kolarczyk",
                Nickname = "Kolar",
                InstagramUrl = "https://www.instagram.com/k0l4r/"
            },
            new()
            {
                Id = 269,
                Created = date,
                Modified = date,
                FirstName = "Jakub",
                LastName = "Olewiński",
                Nickname = "Carlito",
                InstagramUrl = "https://www.instagram.com/kubatocarlito/"
            },
            new()
            {
                Id = 270,
                Created = date,
                Modified = date,
                FirstName = "Łukasz",
                LastName = "Wdowiak",
                Nickname = "Lukas TV",
                InstagramUrl = "https://www.instagram.com/lukas.tv/"
            },
            new()
            {
                Id = 271,
                Created = date,
                Modified = date,
                FirstName = "Sebastian",
                LastName = "Szabunio",
                Nickname = "Bunio",
                InstagramUrl = "https://www.instagram.com/buniosb/"
            },
            new()
            {
                Id = 272,
                Created = date,
                Modified = date,
                FirstName = "Kamil",
                LastName = "Kossakowski",
                Nickname = "Kossakowski",
                InstagramUrl = "https://www.instagram.com/kamil_kossakowski"
            },
            new()
            {
                Id = 273,
                Created = date,
                Modified = date,
                FirstName = "Gabriel",
                LastName = "Bystrzycki",
                Nickname = "Cesarz Narcyz",
                InstagramUrl = "https://www.instagram.com/cesarz_narcyz/"
            },
            new()
            {
                Id = 274,
                Created = date,
                Modified = date,
                FirstName = "Lexy",
                LastName = "Chaplin",
                Nickname = "Chaplin",
                InstagramUrl = "https://www.instagram.com/lexychaplin/"
            },
            new()
            {
                Id = 275,
                Created = date,
                Modified = date,
                FirstName = "Natalia",
                LastName = "Karczmarczyk",
                Nickname = "Natsu",
                InstagramUrl = "https://www.instagram.com/natalia.karczmarczyk/"
            },

            // High League 2: pashaBiceps vs. Owca
            new()
            {
                Id = 276,
                Created = date,
                Modified = date,
                FirstName = "Konrad",
                LastName = "Karwat",
                Nickname = "Karwat",
                InstagramUrl = "https://www.instagram.com/konradkarwat/"
            },
            new()
            {
                Id = 277,
                Created = date,
                Modified = date,
                FirstName = "Hubert",
                LastName = "Węzka",
                Nickname = "Dredziasty",
                InstagramUrl = "https://www.instagram.com/dredziasty.dred/"
            },
            new()
            {
                Id = 278,
                Created = date,
                Modified = date,
                FirstName = "Piotr",
                LastName = "Czupryn",
                Nickname = "czuuX",
                InstagramUrl = "https://www.instagram.com/czuux/"
            },
            new()
            {
                Id = 279,
                Created = date,
                Modified = date,
                FirstName = "Denis",
                LastName = "Załęcki",
                Nickname = "Bad Boy",
                InstagramUrl = "https://www.instagram.com/bad_boy_denis_/"
            },
            new()
            {
                Id = 280,
                Created = date,
                Modified = date,
                FirstName = "Maciej",
                LastName = "Zoniuk",
                Nickname = "Zony",
                InstagramUrl = "https://www.instagram.com/zony_2.0/"
            },
            new()
            {
                Id = 281,
                Created = date,
                Modified = date,
                FirstName = "Jarosław",
                LastName = "Jarząbkowski",
                Nickname = "pashaBiceps",
                InstagramUrl = "https://www.instagram.com/pashabiceps/"
            },
            new()
            {
                Id = 282,
                Created = date,
                Modified = date,
                FirstName = "Michał",
                LastName = "Owczarzak",
                Nickname = "Owca",
                InstagramUrl = "https://www.instagram.com/owcawk/"
            },

            // High League 3: Alberto vs. Dubiel
            new()
            {
                Id = 283,
                Created = date,
                Modified = date,
                FirstName = "Alan",
                LastName = "Godziński",
                Nickname = "Alan Człowieku",
                InstagramUrl = "https://www.instagram.com/alanczlowiekuuu/"
            },
            new()
            {
                Id = 284,
                Created = date,
                Modified = date,
                FirstName = "Paweł",
                LastName = "Bomba",
                Nickname = "Scarface",
                InstagramUrl = "https://www.instagram.com/bombascarface2.0/"
            },
            new()
            {
                Id = 285,
                Created = date,
                Modified = date,
                FirstName = "Dawid",
                LastName = "Załęcki",
                Nickname = "Crazy",
                InstagramUrl = "https://www.instagram.com/dawid.crazy.zalecki/"
            },
            new()
            {
                Id = 286,
                Created = date,
                Modified = date,
                FirstName = "Robert",
                LastName = "Orzechowski",
                Nickname = "Robur",
                InstagramUrl = "https://www.instagram.com/robercik_dynamit/"
            },
            new()
            {
                Id = 287,
                Created = date,
                Modified = date,
                FirstName = "Robert",
                LastName = "Burneika",
                Nickname = "Hardkorowy Koksu",
                InstagramUrl = "https://www.instagram.com/robertburneikaofficial/"
            },

            // High League 3: Extra
            new()
            {
                Id = 288,
                Created = date,
                Modified = date,
                FirstName = "Mateusz",
                LastName = "Kubiszyn",
                Nickname = "Don Diego",
                InstagramUrl = "https://www.instagram.com/dondiego_kubiszyn/"
            },

            // High League 4: Natsu vs. Lexy 2
            new()
            {
                Id = 289,
                Created = date,
                Modified = date,
                FirstName = "Radosław",
                LastName = "Słodkiewicz",
                Nickname = "Słodkiewicz",
                InstagramUrl = "https://www.instagram.com/radek_slodkiewicz/"
            },
            new()
            {
                Id = 290,
                Created = date,
                Modified = date,
                FirstName = "Jakub",
                LastName = "Krawczyk-Holak",
                Nickname = "Holak",
                InstagramUrl = "https://www.instagram.com/holak_amg/"
            },
            new()
            {
                Id = 291,
                Created = date,
                Modified = date,
                FirstName = "Jakub",
                LastName = "Świtała",
                Nickname = "Kubx",
                InstagramUrl = "https://www.instagram.com/kubxfn/"
            },
            new()
            {
                Id = 292,
                Created = date,
                Modified = date,
                FirstName = "Krystian",
                LastName = "Maciaszczyk",
                Nickname = "Macias",
                InstagramUrl = "https://www.instagram.com/yungmaciasww/"
            },
            new()
            {
                Id = 293,
                Created = date,
                Modified = date,
                FirstName = "Maja",
                LastName = "Staśko",
                Nickname = "Staśko",
                InstagramUrl = "https://www.instagram.com/majakstasko/"
            },
            new()
            {
                Id = 294,
                Created = date,
                Modified = date,
                FirstName = "Ewa",
                LastName = "Wyszatycka",
                Nickname = "Mrs. Honey",
                InstagramUrl = "https://www.instagram.com/mrs.honey/"
            },
            new()
            {
                Id = 295,
                Created = date,
                Modified = date,
                FirstName = "Salim",
                LastName = "Chiboub",
                Nickname = "Chiboub",
                InstagramUrl = "https://www.instagram.com/salim_chiboub_official/"
            },
            new()
            {
                Id = 296,
                Created = date,
                Modified = date,
                FirstName = "Artur",
                LastName = "Szpilka",
                Nickname = "Szpila",
                InstagramUrl = "https://www.instagram.com/artur_szpilka/"
            },

            // High League 5: Alberto vs. Tybori
            new()
            {
                Id = 297,
                Created = date,
                Modified = date,
                FirstName = "Wojciech",
                LastName = "Sobierajski",
                Nickname = "Rekordzista",
                InstagramUrl = "https://www.instagram.com/wojciech_sobierajski/"
            },
            new()
            {
                Id = 298,
                Created = date,
                Modified = date,
                FirstName = "Przemysław",
                LastName = "Skulski",
                Nickname = "Sequento",
                InstagramUrl = "https://www.instagram.com/skulak_95/"
            },
            new()
            {
                Id = 299,
                Created = date,
                Modified = date,
                FirstName = "Andrzej",
                LastName = "Gazda",
                Nickname = "Andrew",
                InstagramUrl = "https://www.instagram.com/andrew_gazda/"
            },
            new()
            {
                Id = 300,
                Created = date,
                Modified = date,
                FirstName = "Vaso",
                LastName = "Bakočević",
                Nickname = "Psychopath",
                InstagramUrl = "https://www.instagram.com/vaso_psycho/"
            },
            new()
            {
                Id = 301,
                Created = date,
                Modified = date,
                FirstName = "Dawid",
                LastName = "Porwisiak",
                Nickname = "Diables",
                InstagramUrl = "https://www.instagram.com/xdiables/"
            },
            new()
            {
                Id = 302,
                Created = date,
                Modified = date,
                FirstName = "Paweł",
                LastName = "Lehmann",
                Nickname = "Leh",
                InstagramUrl = "https://www.instagram.com/lehtv/"
            },
            new()
            {
                Id = 303,
                Created = date,
                Modified = date,
                FirstName = "Maria",
                LastName = "Graczykowska",
                Nickname = "Masza",
                InstagramUrl = "https://www.instagram.com/maszagraczykowska/"
            },
            new()
            {
                Id = 304,
                Created = date,
                Modified = date,
                FirstName = "Damian",
                LastName = "Janikowski",
                Nickname = "Janikowski",
                InstagramUrl = "https://www.instagram.com/damian.janikowski/"
            },

            // High League 6: pashaBiceps vs. Dubiel
            new()
            {
                Id = 305,
                Created = date,
                Modified = date,
                FirstName = "Tomasz",
                LastName = "Matysiak",
                Nickname = "Szalony Reporter",
                InstagramUrl = "https://www.instagram.com/szalony.reporter/"
            },
            new()
            {
                Id = 306,
                Created = date,
                Modified = date,
                FirstName = "Kacper",
                LastName = "Bociański",
                Nickname = "Ludwiczek",
                InstagramUrl = "https://www.instagram.com/ludwiczek_top/"
            },
            new()
            {
                Id = 307,
                Created = date,
                Modified = date,
                FirstName = "Denis",
                LastName = "Labryga",
                Nickname = "Labryga",
                InstagramUrl = "https://www.instagram.com/denis_labryga/"
            },

            // Clout MMA 1
            new()
            {
                Id = 308,
                Created = date,
                Modified = date,
                FirstName = "Mariusz",
                LastName = "Sobczak",
                Nickname = "Super Mario",
                InstagramUrl = "https://www.instagram.com/supermariotrener/"
            },
            new()
            {
                Id = 309,
                Created = date,
                Modified = date,
                FirstName = "Dominik",
                LastName = "Pudzianowski",
                Nickname = "Pudzianowski",
                InstagramUrl = "https://www.instagram.com/pudzianowskid/"
            },
            new()
            {
                Id = 310,
                Created = date,
                Modified = date,
                FirstName = "Błażej",
                LastName = "Augustyn",
                Nickname = "Augustyn",
                InstagramUrl = "https://www.instagram.com/blazejaugustyn/"
            },
            new()
            {
                Id = 311,
                Created = date,
                Modified = date,
                FirstName = "Piotr",
                LastName = "Lizakowski",
                Nickname = "Lizak",
                InstagramUrl = "https://www.instagram.com/piotr_lizakowski/"
            },
            new()
            {
                Id = 312,
                Created = date,
                Modified = date,
                FirstName = "Michał",
                LastName = "Waleszczyński",
                Nickname = "Potężny Tłumacz",
                InstagramUrl = "https://www.instagram.com/michal_waleszczynski_lis/"
            },
            new()
            {
                Id = 313,
                Created = date,
                Modified = date,
                FirstName = "Cezary",
                LastName = "Gołębiewski",
                Nickname = "Czarek Czaruje",
                InstagramUrl = "https://www.instagram.com/czarek_czaruje/"
            },
            new()
            {
                Id = 314,
                Created = date,
                Modified = date,
                FirstName = "Nikola",
                LastName = "Biela",
                Nickname = "Nikita",
                InstagramUrl = "https://www.instagram.com/nikitkaaa_oficjalnie/"
            },
            new()
            {
                Id = 315,
                Created = date,
                Modified = date,
                FirstName = "Monika",
                LastName = "Laskowska",
                Nickname = "Najlepsza Polska Dziennikarka",
                InstagramUrl = "https://www.instagram.com/monikadorotalaskowska/"
            },
            new()
            {
                Id = 316,
                Created = date,
                Modified = date,
                FirstName = "Łukasz",
                LastName = "Malankowski",
                Nickname = "Magical Jr",
                InstagramUrl = "https://www.instagram.com/lukaszmagical/"
            },
            new()
            {
                Id = 317,
                Created = date,
                Modified = date,
                FirstName = "Tomasz",
                LastName = "Sarara",
                Nickname = "Sarara",
                InstagramUrl = "https://www.instagram.com/tomasz_sarara/"
            },
            new()
            {
                Id = 318,
                Created = date,
                Modified = date,
                FirstName = "Jay",
                LastName = "Silva",
                Nickname = "Silva",
                InstagramUrl = "https://www.instagram.com/jaysilvamma/"
            },
            new()
            {
                Id = 319,
                Created = date,
                Modified = date,
                FirstName = "Tomasz",
                LastName = "Hajto",
                Nickname = "Hajto",
                InstagramUrl = "https://www.instagram.com/tomaszhajto7/"
            },
            new()
            {
                Id = 320,
                Created = date,
                Modified = date,
                FirstName = "Zbigniew",
                LastName = "Bartman",
                Nickname = "Bartman",
                InstagramUrl = "https://www.instagram.com/zbigniew_bartman/"
            },
            new()
            {
                Id = 321,
                Created = date,
                Modified = date,
                FirstName = "Andrzej",
                LastName = "Fonfara",
                Nickname = "Fonfara",
                InstagramUrl = "https://www.instagram.com/andrzejfonfara/"
            },

            // Clout MMA 2
            new()
            {
                Id = 322,
                Created = date,
                Modified = date,
                FirstName = "Błażej",
                LastName = "Skrzypek",
                Nickname = "Skrzypas",
                InstagramUrl = "https://www.instagram.com/skrzypas__/"
            },
            new()
            {
                Id = 323,
                Created = date,
                Modified = date,
                FirstName = "Agnieszka",
                LastName = "Bobek",
                Nickname = "Bobek",
                InstagramUrl = "https://www.instagram.com/agv.b/"
            },
            new()
            {
                Id = 324,
                Created = date,
                Modified = date,
                FirstName = "Anthony",
                LastName = "Chaplin",
                Nickname = "Toni",
                InstagramUrl = "https://www.instagram.com/anthony.chaplin06/"
            },
            new()
            {
                Id = 325,
                Created = date,
                Modified = date,
                FirstName = "Marcel",
                LastName = "Gawroński",
                Nickname = "Gawronek",
                InstagramUrl = "https://www.instagram.com/gawronek007/"
            },
            new()
            {
                Id = 326,
                Created = date,
                Modified = date,
                FirstName = "Rafał",
                LastName = "Borkowski",
                Nickname = "Boro na 10",
                InstagramUrl = "https://www.instagram.com/boroo_na_10/"
            },
            new()
            {
                Id = 327,
                Created = date,
                Modified = date,
                FirstName = "Gustav",
                LastName = "Carvalho",
                Nickname = "Gustaw Carvalho",
                InstagramUrl = "https://www.instagram.com/gustaw_carvalho/"
            },
            new()
            {
                Id = 328,
                Created = date,
                Modified = date,
                FirstName = "Radosław",
                LastName = "Kalisz",
                Nickname = "Radar",
                InstagramUrl = "https://www.instagram.com/radaroficjalnie/"
            },
            new()
            {
                Id = 329,
                Created = date,
                Modified = date,
                FirstName = "Kacper",
                LastName = "Kurek",
                Nickname = "Kurek",
                InstagramUrl = "https://www.instagram.com/kapo_oficjalnie/"
            },
            new()
            {
                Id = 330,
                Created = date,
                Modified = date,
                FirstName = "Mateusz",
                LastName = "Szczypior",
                Nickname = "Mavs",
                InstagramUrl = "https://www.instagram.com/mavs_mati/"
            },
            new()
            {
                Id = 331,
                Created = date,
                Modified = date,
                FirstName = "Fabian",
                LastName = "Baner",
                Nickname = "Banersky",
                InstagramUrl = "https://www.instagram.com/banersky/"
            },
            new()
            {
                Id = 332,
                Created = date,
                Modified = date,
                FirstName = "Szymon",
                LastName = "Patyna",
                Nickname = "Lord Szymass",
                InstagramUrl = "https://www.instagram.com/lord_szymass/"
            },
            new()
            {
                Id = 333,
                Created = date,
                Modified = date,
                FirstName = "Krystian",
                LastName = "Bajor",
                Nickname = "Świstak",
                InstagramUrl = "https://www.instagram.com/swistako_/"
            },
            new()
            {
                Id = 334,
                Created = date,
                Modified = date,
                FirstName = "Denis",
                LastName = "Zakrzewski",
                Nickname = "Tona",
                InstagramUrl = "https://www.instagram.com/t0na___/"
            },
            new()
            {
                Id = 335,
                Created = date,
                Modified = date,
                FirstName = "Marcin Dawid",
                LastName = "Szwed",
                Nickname = "Szwed",
                InstagramUrl = "https://www.instagram.com/szwedos94/"
            },
            new()
            {
                Id = 336,
                Created = date,
                Modified = date,
                FirstName = "Alan",
                LastName = "Sanchez",
                Nickname = "Sanchez",
                InstagramUrl = "https://www.instagram.com/mlodyantena/"
            },
            new()
            {
                Id = 337,
                Created = date,
                Modified = date,
                FirstName = "Albert",
                LastName = "Sosnowski",
                Nickname = "Sosnowski",
                InstagramUrl = "https://www.instagram.com/albert_dragon_sosnowski/"
            },
            new()
            {
                Id = 338,
                Created = date,
                Modified = date,
                FirstName = "Remigiusz",
                LastName = "Gruchała",
                Nickname = "Remi",
                InstagramUrl = "https://www.instagram.com/xxremas/"
            },
            new()
            {
                Id = 339,
                Created = date,
                Modified = date,
                FirstName = "Małgorzata",
                LastName = "Zwierzyńska",
                Nickname = "Gosia Magical",
                InstagramUrl = "https://www.instagram.com/gosiamagical.official/"
            },
            new()
            {
                Id = 340,
                Created = date,
                Modified = date,
                FirstName = "Kamil",
                LastName = "Minda",
                Nickname = "Minda",
                InstagramUrl = "https://www.instagram.com/kamil_minda/"
            },
            new()
            {
                Id = 341,
                Created = date,
                Modified = date,
                FirstName = "Daniel",
                LastName = "Omielańczuk",
                Nickname = "Omielańczuk",
                InstagramUrl = "https://www.instagram.com/danielomielanczuk/"
            },

            // FFF 1: Najman vs. Trybson
            new()
            {
                Id = 342,
                Created = date,
                Modified = date,
                FirstName = "Jakub",
                LastName = "Ciążyński",
                Nickname = "Ciążyński",
                InstagramUrl = null
            },
            new()
            {
                Id = 343,
                Created = date,
                Modified = date,
                FirstName = "Paweł",
                LastName = "Jasionowicz",
                Nickname = "Jasionowicz",
                InstagramUrl = null
            },
            new()
            {
                Id = 344,
                Created = date,
                Modified = date,
                FirstName = "Patryk",
                LastName = "Kimuła",
                Nickname = "Kimuła",
                InstagramUrl = null
            },
            new()
            {
                Id = 345,
                Created = date,
                Modified = date,
                FirstName = "Jakub",
                LastName = "Kiesiak",
                Nickname = "Kiesiak",
                InstagramUrl = null
            },
            new()
            {
                Id = 346,
                Created = date,
                Modified = date,
                FirstName = "Kamil",
                LastName = "Korzeniowski",
                Nickname = "Korzeniowski",
                InstagramUrl = "https://www.instagram.com/korzeniowski_mma/"
            },
            new()
            {
                Id = 347,
                Created = date,
                Modified = date,
                FirstName = "Filip",
                LastName = "Bątkowski",
                Nickname = "Bątkowski",
                InstagramUrl = null
            },
            new()
            {
                Id = 348,
                Created = date,
                Modified = date,
                FirstName = "Mateusz",
                LastName = "Stawski",
                Nickname = "Graduado Camarao",
                InstagramUrl = null
            },
            new()
            {
                Id = 349,
                Created = date,
                Modified = date,
                FirstName = "Tomasz",
                LastName = "Łomnicki",
                Nickname = "Fit Dzik",
                InstagramUrl = "https://www.instagram.com/fitdzik_official/"
            },
            new()
            {
                Id = 350,
                Created = date,
                Modified = date,
                FirstName = "Rafał",
                LastName = "Kryla",
                Nickname = "Tito",
                InstagramUrl = "https://www.instagram.com/rafaltito/"
            },
            new()
            {
                Id = 351,
                Created = date,
                Modified = date,
                FirstName = "Grzegorz",
                LastName = "Chmielewski",
                Nickname = "Greg Collins",
                InstagramUrl = "https://www.instagram.com/grzegorz_greg_collins/"
            },
            new()
            {
                Id = 352,
                Created = date,
                Modified = date,
                FirstName = "Krystian",
                LastName = "Pudzianowski",
                Nickname = "Pudzianowski",
                InstagramUrl = "https://www.instagram.com/pudzianowski_krystian/"
            },

            // FFF 2: Świerczewski vs. Greg Collins
            new()
            {
                Id = 353,
                Created = date,
                Modified = date,
                FirstName = "Klaudia",
                LastName = "Pawicka",
                Nickname = "Pawicka",
                InstagramUrl = null
            },
            new()
            {
                Id = 354,
                Created = date,
                Modified = date,
                FirstName = "Justyna",
                LastName = "Haba",
                Nickname = "Lara Croft",
                InstagramUrl = null
            },
            new()
            {
                Id = 355,
                Created = date,
                Modified = date,
                FirstName = "Hubert",
                LastName = "Sulewski",
                Nickname = "Sulewski",
                InstagramUrl = null
            },
            new()
            {
                Id = 356,
                Created = date,
                Modified = date,
                FirstName = "Damian",
                LastName = "Osytek",
                Nickname = "Rest",
                InstagramUrl = "https://www.instagram.com/rescikdixon37/"
            },
            new()
            {
                Id = 357,
                Created = date,
                Modified = date,
                FirstName = "Patrycja",
                LastName = "Zahorska",
                Nickname = "Lady Squat",
                InstagramUrl = "https://www.instagram.com/patrycja_zahorska/"
            },
            new()
            {
                Id = 358,
                Created = date,
                Modified = date,
                FirstName = "Damian",
                LastName = "Kostrzewa",
                Nickname = "Kostrzewa",
                InstagramUrl = "https://www.instagram.com/damian_kostrzewa_/"
            },
            new()
            {
                Id = 359,
                Created = date,
                Modified = date,
                FirstName = "Tomasz",
                LastName = "Słodkiewicz",
                Nickname = "Słodkiewicz",
                InstagramUrl = "https://www.instagram.com/tomasz_slodkiewicz_/"
            },
            new()
            {
                Id = 360,
                Created = date,
                Modified = date,
                FirstName = "Dariusz",
                LastName = "Działek",
                Nickname = "DJ Decks",
                InstagramUrl = "https://www.instagram.com/djdecks/"
            },

            // Bita Śmietanka 1
            new()
            {
                Id = 361,
                Created = date,
                Modified = date,
                FirstName = "Jan",
                LastName = "Starzyński",
                Nickname = "CPT Babka Lukiego",
                InstagramUrl = null
            },
            new()
            {
                Id = 362,
                Created = date,
                Modified = date,
                FirstName = "Tomasz",
                LastName = "Hajduk",
                Nickname = "Hajdook",
                InstagramUrl = "https://www.instagram.com/hajdook/"
            },
            new()
            {
                Id = 363,
                Created = date,
                Modified = date,
                FirstName = "Rasaq",
                LastName = "Rasaq",
                Nickname = "Rasaq",
                InstagramUrl = null
            },
            new()
            {
                Id = 364,
                Created = date,
                Modified = date,
                FirstName = "Oliwia",
                LastName = "Gapa",
                Nickname = "Tywionka",
                InstagramUrl = "https://www.instagram.com/tywionkaa/"
            },
            new()
            {
                Id = 365,
                Created = date,
                Modified = date,
                FirstName = "Daria",
                LastName = "Anielska-Mazur",
                Nickname = "Eanitright",
                InstagramUrl = null
            },
            new()
            {
                Id = 366,
                Created = date,
                Modified = date,
                FirstName = "Miłosz",
                LastName = "Boras",
                Nickname = "Dejvid",
                InstagramUrl = "https://www.instagram.com/dejvid_upo/"
            },
            new()
            {
                Id = 367,
                Created = date,
                Modified = date,
                FirstName = "Aleks",
                LastName = "Kohimo",
                Nickname = "Kohimo",
                InstagramUrl = null
            },
            new()
            {
                Id = 368,
                Created = date,
                Modified = date,
                FirstName = "Michał",
                LastName = "Wojowski",
                Nickname = "Młodziutki",
                InstagramUrl = "https://www.instagram.com/mlodziutki7/"
            },
            new()
            {
                Id = 369,
                Created = date,
                Modified = date,
                FirstName = "Jakub",
                LastName = "Matuszyk",
                Nickname = "Jaszczurowy",
                InstagramUrl = "https://www.instagram.com/jaszczurowy_12/"
            }, // ok
            new()
            {
                Id = 370,
                Created = date,
                Modified = date,
                FirstName = "Dominik",
                LastName = "Stokłosa",
                Nickname = "MokrySuchar",
                InstagramUrl = "https://www.instagram.com/mokrysuchar/"
            },
            new()
            {
                Id = 371,
                Created = date,
                Modified = date,
                FirstName = "Maksymilian",
                LastName = "Wysocki",
                Nickname = "Vysotzky",
                InstagramUrl = "https://www.instagram.com/vstzky/"
            },
            new()
            {
                Id = 372,
                Created = date,
                Modified = date,
                FirstName = "Michał",
                LastName = "Dąbrowski",
                Nickname = "Scetovichek",
                InstagramUrl = "https://www.instagram.com/scetovichek/"
            },

            // Bita Śmietanka 2
            new()
            {
                Id = 373,
                Created = date,
                Modified = date,
                FirstName = "Oliwier",
                LastName = "Oware",
                Nickname = "xOliTroli",
                InstagramUrl = "https://www.instagram.com/xolitroli/"
            },
            new()
            {
                Id = 374,
                Created = date,
                Modified = date,
                FirstName = "Kacper",
                LastName = "Kędzierski",
                Nickname = "01kacpl",
                InstagramUrl = "https://www.instagram.com/01kac/"
            },
            new()
            {
                Id = 375,
                Created = date,
                Modified = date,
                FirstName = "Tymoteusz",
                LastName = "Dzik",
                Nickname = "fakerpl_",
                InstagramUrl = "https://www.instagram.com/fakerpl_/"
            },
            new()
            {
                Id = 376,
                Created = date,
                Modified = date,
                FirstName = "Mateusz",
                LastName = "Kosiorek",
                Nickname = "Matixoxo",
                InstagramUrl = "https://www.instagram.com/matixoxoo_/"
            },
            new()
            {
                Id = 377,
                Created = date,
                Modified = date,
                FirstName = "Wiktoria",
                LastName = "Natanek",
                Nickname = "Wikulenta",
                InstagramUrl = "https://www.instagram.com/wikulenta"
            },
            new()
            {
                Id = 378,
                Created = date,
                Modified = date,
                FirstName = "Zuzanna",
                LastName = "Komorowska",
                Nickname = "Meesyka",
                InstagramUrl = "https://www.instagram.com/meesyka_"
            },
            new()
            {
                Id = 379,
                Created = date,
                Modified = date,
                FirstName = "Jakub",
                LastName = "Rokicki",
                Nickname = "Cinkrof",
                InstagramUrl = "https://www.instagram.com/cinkroflol/"
            },
            new()
            {
                Id = 380,
                Created = date,
                Modified = date,
                FirstName = "Patryk",
                LastName = "Czopur",
                Nickname = "LukiSteve",
                InstagramUrl = "https://www.instagram.com/lukisteve_/"
            },
            new()
            {
                Id = 381,
                Created = date,
                Modified = date,
                FirstName = "Artur",
                LastName = "Gębicz",
                Nickname = "Rybson",
                InstagramUrl = "https://www.instagram.com/rybsonlol/"
            },
            new()
            {
                Id = 382,
                Created = date,
                Modified = date,
                FirstName = "Aleksander",
                LastName = "Kardaś",
                Nickname = "RandomBruce",
                InstagramUrl = "https://www.instagram.com/aleksander.kardas/"
            },

            // Elite Fighters 1: Muran vs. Warszawski Dresik
            new()
            {
                Id = 383,
                Created = date,
                Modified = date,
                FirstName = "Paweł",
                LastName = "Szulc",
                Nickname = "Szulc",
                InstagramUrl = "https://www.instagram.com/pawelszulc2k/"
            },
            new()
            {
                Id = 384,
                Created = date,
                Modified = date,
                FirstName = "Marcin",
                LastName = "Dąbrowski",
                Nickname = "Marcintus",
                InstagramUrl = "https://www.instagram.com/rick_akuku/"
            },
            new()
            {
                Id = 385,
                Created = date,
                Modified = date,
                FirstName = "Igor",
                LastName = "Zając",
                Nickname = "Izet",
                InstagramUrl = "https://www.instagram.com/izet.sp/"
            },
            new()
            {
                Id = 386,
                Created = date,
                Modified = date,
                FirstName = "Julita",
                LastName = "Juchnowicz",
                Nickname = "Juchnowicz",
                InstagramUrl = "https://www.instagram.com/julita_juchnowicz/"
            },
            new()
            {
                Id = 387,
                Created = date,
                Modified = date,
                FirstName = "Filip",
                LastName = "Ćwiek",
                Nickname = "Ćwiek",
                InstagramUrl = "https://www.instagram.com/f_o.g__/"
            },
            new()
            {
                Id = 388,
                Created = date,
                Modified = date,
                FirstName = "Bartosz",
                LastName = "Kubiak",
                Nickname = "Fit.pl",
                InstagramUrl = "https://www.instagram.com/fit.pl/"
            },
            new()
            {
                Id = 389,
                Created = date,
                Modified = date,
                FirstName = "Michał",
                LastName = "Dryja",
                Nickname = "Mundek",
                InstagramUrl = "https://www.instagram.com/mundek.dryja/"
            },
            new()
            {
                Id = 390,
                Created = date,
                Modified = date,
                FirstName = "Maciej",
                LastName = "Szwech",
                Nickname = "Szwechu",
                InstagramUrl = "https://www.instagram.com/maciek_szwech/"
            },
            new()
            {
                Id = 391,
                Created = date,
                Modified = date,
                FirstName = "Miłosz",
                LastName = "Włodkowski",
                Nickname = "Modlicha",
                InstagramUrl = "https://www.instagram.com/modlicha_00/"
            },
            new()
            {
                Id = 392,
                Created = date,
                Modified = date,
                FirstName = "Norbert",
                LastName = "Grązka",
                Nickname = "Neted",
                InstagramUrl = "https://www.instagram.com/__neted__/"
            },
            new()
            {
                Id = 393,
                Created = date,
                Modified = date,
                FirstName = "Piotr",
                LastName = "Kowalski",
                Nickname = "Kung Fu Panda",
                InstagramUrl = "https://www.instagram.com/kungfupanda1312/"
            },
            new()
            {
                Id = 394,
                Created = date,
                Modified = date,
                FirstName = "Ewa",
                LastName = "Piekut",
                Nickname = "Eva",
                InstagramUrl = "https://www.instagram.com/madamepiekut/"
            },
            new()
            {
                Id = 395,
                Created = date,
                Modified = date,
                FirstName = "Weronika",
                LastName = "Piątek",
                Nickname = "IAmWero",
                InstagramUrl = "https://www.instagram.com/iamwero/"
            },
            new()
            {
                Id = 396,
                Created = date,
                Modified = date,
                FirstName = "Norbert",
                LastName = "Janecki",
                Nickname = "Warszawski Dresik",
                InstagramUrl = "https://www.instagram.com/warszawski_dresik/"
            },

            // MMA-VIP 1: Najman vs. Złotówa
            new()
            {
                Id = 397,
                Created = date,
                Modified = date,
                FirstName = "Krystian",
                LastName = "Rosa",
                Nickname = "Rosa",
                InstagramUrl = "https://www.instagram.com/_krystian_rosa/"
            },
            new()
            {
                Id = 398,
                Created = date,
                Modified = date,
                FirstName = "Adrian",
                LastName = "Sulikowski",
                Nickname = "Sulikowski",
                InstagramUrl = "https://www.instagram.com/adrian_suli_21/"
            },
            new()
            {
                Id = 399,
                Created = date,
                Modified = date,
                FirstName = "Mateusz",
                LastName = "Kisiel",
                Nickname = "Rolnik Zabijacz",
                InstagramUrl = null
            },
            new()
            {
                Id = 400,
                Created = date,
                Modified = date,
                FirstName = "Sebastian",
                LastName = "Tronina",
                Nickname = "Tronina",
                InstagramUrl = "https://www.instagram.com/pikus14/"
            },
            new()
            {
                Id = 401,
                Created = date,
                Modified = date,
                FirstName = "Przemysław",
                LastName = "Opalach",
                Nickname = "The Spartan",
                InstagramUrl = "https://www.instagram.com/przemyslaw.opalach/"
            },
            new()
            {
                Id = 402,
                Created = date,
                Modified = date,
                FirstName = "Konrad",
                LastName = "Cyrankowski",
                Nickname = "Cyrankowski",
                InstagramUrl = "https://www.instagram.com/kadode_zmartwychwstal/"
            },
            new()
            {
                Id = 403,
                Created = date,
                Modified = date,
                FirstName = "Marcin",
                LastName = "Rekowski",
                Nickname = "Rex",
                InstagramUrl = "https://www.instagram.com/rex.marcin.rekowski/"
            },
            new()
            {
                Id = 404,
                Created = date,
                Modified = date,
                FirstName = "Patryk",
                LastName = "Kowoll",
                Nickname = "Gołota",
                InstagramUrl = "https://www.instagram.com/patrykkowoll/"
            },
            new()
            {
                Id = 405,
                Created = date,
                Modified = date,
                FirstName = "Edward",
                LastName = "Mazur",
                Nickname = "Mazur",
                InstagramUrl = "https://www.instagram.com/edwardmazur/"
            },
            new()
            {
                Id = 406,
                Created = date,
                Modified = date,
                FirstName = "Dominik",
                LastName = "Tyman",
                Nickname = "Guma",
                InstagramUrl = "https://www.instagram.com/dominik.tyman/"
            },

            // MMA-VIP 2: Igrzyska Rozkminiaczy
            new()
            {
                Id = 407,
                Created = date,
                Modified = date,
                FirstName = "Krystian",
                LastName = "Stefanów",
                Nickname = "Kiki",
                InstagramUrl = "https://www.instagram.com/kikii_206/"
            },
            new()
            {
                Id = 408,
                Created = date,
                Modified = date,
                FirstName = "Oliwier",
                LastName = "Gajewski",
                Nickname = "Detailer",
                InstagramUrl = "https://www.instagram.com/oliwier_detailer/"
            },
            new()
            {
                Id = 409,
                Created = date,
                Modified = date,
                FirstName = "Tomas",
                LastName = "Vaicickas",
                Nickname = "Vaicickas",
                InstagramUrl = "https://www.instagram.com/tomas_vaicickas/"
            },
            new()
            {
                Id = 410,
                Created = date,
                Modified = date,
                FirstName = "Daniel",
                LastName = "Kaczmarek",
                Nickname = "Kaczmarek",
                InstagramUrl = "https://www.instagram.com/danielkaczmarek333/"
            },
            new()
            {
                Id = 411,
                Created = date,
                Modified = date,
                FirstName = "Kamil",
                LastName = "Wieczorek",
                Nickname = "Wieczorek",
                InstagramUrl = "https://www.instagram.com/kamilwieczorek304/"
            },
            new()
            {
                Id = 412,
                Created = date,
                Modified = date,
                FirstName = "Alan",
                LastName = "Gruchała",
                Nickname = "Psychotrop",
                InstagramUrl = "https://www.instagram.com/sajko.666/"
            },
            new()
            {
                Id = 413,
                Created = date,
                Modified = date,
                FirstName = "Ryszard",
                LastName = "Dąbrowski",
                Nickname = "Szczena",
                InstagramUrl = "https://www.instagram.com/ryszarddabrowski/"
            },
            new()
            {
                Id = 414,
                Created = date,
                Modified = date,
                FirstName = "Tomasz",
                LastName = "Galewski",
                Nickname = "Chic",
                InstagramUrl = "https://www.instagram.com/chic_performance/"
            },
            new()
            {
                Id = 415,
                Created = date,
                Modified = date,
                FirstName = "Andrzej",
                LastName = "Żuromski",
                Nickname = "Żurom",
                InstagramUrl = "https://www.instagram.com/zuromtv/"
            },
            new()
            {
                Id = 416,
                Created = date,
                Modified = date,
                FirstName = "Rafał",
                LastName = "Podejma",
                Nickname = "Antykonfident",
                InstagramUrl = "https://www.instagram.com/antykonfident_official/"
            },

            // MMA-VIP 3: Galaktyka Osobliwości
            new()
            {
                Id = 417,
                Created = date,
                Modified = date,
                FirstName = "Paweł",
                LastName = "Jendruczko",
                Nickname = "Scarface",
                InstagramUrl = null
            },
            new()
            {
                Id = 418,
                Created = date,
                Modified = date,
                FirstName = "Urszula",
                LastName = "Siekacz",
                Nickname = "ArmPowerGirl",
                InstagramUrl = "https://www.instagram.com/armpowergirl/"
            },
            new()
            {
                Id = 419,
                Created = date,
                Modified = date,
                FirstName = "Piotr",
                LastName = "Lisowski",
                Nickname = "Mua Boy",
                InstagramUrl = "https://www.instagram.com/muaboyx2/"
            },
            new()
            {
                Id = 420,
                Created = date,
                Modified = date,
                FirstName = "Piotr",
                LastName = "Szczygieł",
                Nickname = "Henio",
                InstagramUrl = "https://www.instagram.com/piotrek22222/"
            },
            new()
            {
                Id = 421,
                Created = date,
                Modified = date,
                FirstName = "Kamil",
                LastName = "Gmosiński",
                Nickname = "Gmosek",
                InstagramUrl = "https://www.instagram.com/kamilgmosinski/"
            },
            new()
            {
                Id = 422,
                Created = date,
                Modified = date,
                FirstName = "Maciej",
                LastName = "Gandziarowski",
                Nickname = "GSP",
                InstagramUrl = "https://www.instagram.com/gun_d_the_mahatma/"
            },
            new()
            {
                Id = 423,
                Created = date,
                Modified = date,
                FirstName = "Wojciech",
                LastName = "Ochnicki",
                Nickname = "Kazik Klimat Kartel",
                InstagramUrl = "https://www.instagram.com/kazikklimatstreettv/"
            },
            new()
            {
                Id = 424,
                Created = date,
                Modified = date,
                FirstName = "Michał",
                LastName = "Przybyłowicz",
                Nickname = "Polski Ken",
                InstagramUrl = "https://www.instagram.com/polski_ken/"
            },
            new()
            {
                Id = 425,
                Created = date,
                Modified = date,
                FirstName = "Wiktoria",
                LastName = "Domżalska",
                Nickname = "Domża",
                InstagramUrl = "https://www.instagram.com/omgitsdomza/"
            },
            new()
            {
                Id = 426,
                Created = date,
                Modified = date,
                FirstName = "Marek",
                LastName = "Molak",
                Nickname = "Molak",
                InstagramUrl = "https://www.instagram.com/marek_molak/"
            },
            new()
            {
                Id = 427,
                Created = date,
                Modified = date,
                FirstName = "Kornel",
                LastName = "Zapadka",
                Nickname = "Korniko",
                InstagramUrl = "https://www.instagram.com/kornelzapadka/"
            },

            // MMA-VIP 4: Imperium Potępionych
            new()
            {
                Id = 428,
                Created = date,
                Modified = date,
                FirstName = "Paulina",
                LastName = "Koziej",
                Nickname = "Paris",
                InstagramUrl = "https://www.instagram.com/w.pogoni.za.wschodem.slonca/"
            },
            new()
            {
                Id = 429,
                Created = date,
                Modified = date,
                FirstName = "Sandra",
                LastName = "Szymoszyn",
                Nickname = "Szymoszyn",
                InstagramUrl = "https://www.instagram.com/szefowa_sandra/"
            },
            new()
            {
                Id = 430,
                Created = date,
                Modified = date,
                FirstName = "Roman",
                LastName = "Lachowolski",
                Nickname = "Bosski",
                InstagramUrl = "https://www.instagram.com/bosskiroman/"
            },
            new()
            {
                Id = 431,
                Created = date,
                Modified = date,
                FirstName = "Damian",
                LastName = "Nagana",
                Nickname = "Nagana",
                InstagramUrl = "https://www.instagram.com/damian_nagana_official/"
            },
            new()
            {
                Id = 432,
                Created = date,
                Modified = date,
                FirstName = "Mirosław",
                LastName = "Dąbrowski",
                Nickname = "Misiek z Nadarzyna",
                InstagramUrl = "https://www.instagram.com/misiek_nadarzyn/"
            }
        });


        modelBuilder.Entity<Federation>().HasData(new List<Federation>
        {
            new() { Id = 1, Name = "Fame MMA", Created = date, Modified = date },
            new() { Id = 2, Name = "Prime Show MMA", Created = date, Modified = date },
            new() { Id = 3, Name = "High League", Created = date, Modified = date },
            new() { Id = 4, Name = "Clout MMA", Created = date, Modified = date },
            new() { Id = 5, Name = "Free Fight Federation", Created = date, Modified = date },
            new() { Id = 6, Name = "Bita Śmietanka", Created = date, Modified = date },
            new() { Id = 7, Name = "Elite Fighters", Created = date, Modified = date },
            new() { Id = 8, Name = "MMA VIP", Created = date, Modified = date }
        });

        modelBuilder.Entity<Event>().HasData(new List<Event>
        {
            // Fame MMA
            new()
            {
                Id = 1,
                FederationId = 1,
                CityId = 1,
                HallId = 12,
                Name = "Fame 1: Boxdel vs. Guzik",
                Date = new DateTime(2018, 6, 30),
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 2,
                FederationId = 1,
                CityId = 2,
                HallId = 13,
                Name = "Fame 2: Rafonix vs. Magical",
                Date = new DateTime(2018, 10, 13),
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 3,
                FederationId = 1,
                CityId = 3,
                HallId = 14,
                Name = "Fame 3: IsAmU vs. DeeJayPallaside",
                Date = new DateTime(2019, 3, 30),
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 4,
                FederationId = 1,
                CityId = 4,
                HallId = 15,
                Name = "Fame 4: Linkimaster vs. Lil Masti",
                Date = new DateTime(2019, 6, 22),
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 5,
                FederationId = 1,
                CityId = 5,
                HallId = 16,
                Name = "Fame 5: Bonus BGC vs. Najman",
                Date = new DateTime(2019, 10, 26),
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 6,
                FederationId = 1,
                CityId = 6,
                HallId = 17,
                Name = "Fame 6: Zusje vs. Linkimaster",
                Date = new DateTime(2020, 3, 28),
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 7,
                FederationId = 1,
                CityId = 3,
                HallId = 18,
                Name = "Fame 7: Popek vs. Stifler",
                Date = new DateTime(2020, 9, 5),
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 8,
                FederationId = 1,
                CityId = 3,
                HallId = 18,
                Name = "Fame 8: Dubiel vs. Blonsky",
                Date = new DateTime(2020, 11, 21),
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 9,
                FederationId = 1,
                CityId = 3,
                HallId = 18,
                Name = "Fame 9: Let’s Play",
                Date = new DateTime(2021, 3, 6),
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 10,
                FederationId = 1,
                CityId = 3,
                HallId = 18,
                Name = "Fame 10: Don Kasjo vs. Parke",
                Date = new DateTime(2021, 5, 15),
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 11,
                FederationId = 1,
                CityId = 7,
                HallId = 19,
                Name = "Fame 11: Fight Club",
                Date = new DateTime(2021, 10, 2),
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 12,
                FederationId = 1,
                CityId = 5,
                HallId = 16,
                Name = "Fame 12: Don Kasjo vs. Polish Zombie",
                Date = new DateTime(2021, 11, 20),
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 13,
                FederationId = 1,
                CityId = 7,
                HallId = 19,
                Name = "Fame 13: Nitro vs. Unboxall",
                Date = new DateTime(2022, 3, 26),
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 14,
                FederationId = 1,
                CityId = 8,
                HallId = 20,
                Name = "Fame 14: Gimper vs. Tromba",
                Date = new DateTime(2022, 5, 14),
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 15,
                FederationId = 1,
                CityId = 3,
                HallId = 14,
                Name = "Fame 15: Zemsta",
                Date = new DateTime(2022, 8, 26),
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 16,
                FederationId = 1,
                CityId = 7,
                HallId = 19,
                Name = "Fame 16: Tromba vs. Dubiel",
                Date = new DateTime(2022, 11, 5),
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 17,
                FederationId = 1,
                CityId = 8,
                HallId = 20,
                Name = "Fame 17: Ferrari vs. Łaszczyk",
                Date = new DateTime(2023, 2, 3),
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 18,
                FederationId = 1,
                CityId = 3,
                HallId = 14,
                Name = "Fame 18: Crusher vs. Ferrari",
                Date = new DateTime(2023, 5, 20),
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 19,
                FederationId = 1,
                CityId = 8,
                HallId = 20,
                Name = "Fame 19: Tańcula vs. Ferrari",
                Date = new DateTime(2023, 9, 2),
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 20,
                FederationId = 1,
                CityId = 9,
                HallId = 21,
                Name = "Fame UK 1: Gowland vs. McKenna",
                Date = new DateTime(2019, 12, 14),
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 21,
                FederationId = 1,
                CityId = 3,
                HallId = 18,
                Name = "Hype S01E01: Rafonix vs. Hejter",
                Date = new DateTime(2021, 4, 17),
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 22,
                FederationId = 1,
                CityId = 10,
                HallId = 22,
                Name = "Fame Friday Arena 1: Alberto vs. Kubańczyk",
                Date = new DateTime(2023, 7, 21),
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 23,
                FederationId = 1,
                CityId = 11,
                HallId = 23,
                Name = "Fame Friday Arena 2: Prezes FEN vs. Boxdel 2",
                Date = new DateTime(2023, 9, 29),
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 24,
                FederationId = 1,
                CityId = 3,
                HallId = 14,
                Name = "Fame: Reborn",
                Date = new DateTime(2023, 12, 9),
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 25,
                FederationId = 2,
                CityId = 3,
                HallId = 14,
                Name = "Prime 1: Zadyma",
                Date = new DateTime(2022, 2, 19),
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 26,
                FederationId = 2,
                CityId = 24,
                HallId = 25,
                Name = "Prime 2: Kosmos",
                Date = new DateTime(2022, 7, 9),
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 27,
                FederationId = 2,
                CityId = 26,
                HallId = 27,
                Name = "Prime 3: Street Fighter",
                Date = new DateTime(2022, 10, 1),
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 28,
                FederationId = 2,
                CityId = 11,
                HallId = 23,
                Name = "Prime 4: Królestwo",
                Date = new DateTime(2022, 11, 26),
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 29,
                FederationId = 2,
                CityId = 10,
                HallId = 28,
                Name = "Prime 5: Don Kasjo vs. Zadora",
                Date = new DateTime(2023, 7, 1),
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 30,
                FederationId = 2,
                CityId = 29,
                HallId = 30,
                Name = "Prime 6: Premium",
                Date = new DateTime(2023, 10, 21),
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 31,
                FederationId = 3,
                CityId = 5,
                HallId = 16,
                Name = "High League 1: Lexy vs. Natsu",
                Date = new DateTime(2021, 8, 28),
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 32,
                FederationId = 3,
                CityId = 8,
                HallId = 20,
                Name = "High League 2: pashaBiceps vs. Owca",
                Date = new DateTime(2022, 2, 5),
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 33,
                FederationId = 3,
                CityId = 5,
                HallId = 16,
                Name = "High League 3: Alberto vs. Dubiel",
                Date = new DateTime(2022, 6, 4),
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 34,
                FederationId = 3,
                CityId = 31,
                HallId = 32,
                Name = "High League 3: Extra",
                Date = new DateTime(2022, 6, 20),
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 35,
                FederationId = 3,
                CityId = 7,
                HallId = 19,
                Name = "High League 4: Natsu vs. Lexy 2",
                Date = new DateTime(2022, 9, 17),
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 36,
                FederationId = 3,
                CityId = 3,
                HallId = 14,
                Name = "High League 5: Alberto vs. Tybori",
                Date = new DateTime(2022, 12, 10),
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 37,
                FederationId = 3,
                CityId = 33,
                HallId = 34,
                Name = "High League 6: pashaBiceps vs. Dubiel",
                Date = new DateTime(2023, 3, 18),
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 38,
                FederationId = 4,
                CityId = 31,
                HallId = 35,
                Name = "Clout MMA 1",
                Date = new DateTime(2023, 8, 5),
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 39,
                FederationId = 4,
                CityId = 36,
                HallId = 37,
                Name = "Clout MMA 2",
                Date = new DateTime(2023, 10, 28),
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 40,
                FederationId = 5,
                CityId = 38,
                HallId = 39,
                Name = "FFF 1: Najman vs. Trybson",
                Date = new DateTime(2019, 6, 8),
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 41,
                FederationId = 5,
                CityId = 38,
                HallId = 39,
                Name = "FFF 2: Świerczewski vs. Greg Collins",
                Date = new DateTime(2019, 12, 21),
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 42,
                FederationId = 6,
                CityId = 31,
                HallId = 40,
                Name = "Bita Śmietanka 1",
                Date = new DateTime(2023, 8, 19),
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 43,
                FederationId = 6,
                CityId = 31,
                HallId = 40,
                Name = "Bita Śmietanka 2",
                Date = new DateTime(2023, 12, 16),
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 44,
                FederationId = 7,
                CityId = 41,
                HallId = 42,
                Name = "Elite Fighters 1: Muran vs. Warszawski Dresik",
                Date = new DateTime(2021, 7, 31),
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 45,
                FederationId = 8,
                CityId = 6,
                HallId = 17,
                Name = "MMA-VIP 1: Najman vs. Złotówa",
                Date = new DateTime(2021, 2, 13),
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 46,
                FederationId = 8,
                CityId = 4,
                HallId = 43,
                Name = "MMA-VIP 2: Igrzyska Rozkminiaczy",
                Date = new DateTime(2021, 6, 18),
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 47,
                FederationId = 8,
                CityId = 4,
                HallId = 43,
                Name = "MMA-VIP 3: Galaktyka Osobliwości",
                Date = new DateTime(2021, 10, 29),
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 48,
                FederationId = 8,
                CityId = 31,
                HallId = null,
                Name = "MMA-VIP 4: Imperium Potępionych",
                Date = new DateTime(2022, 3, 5),
                Created = date,
                Modified = date
            }
        });

        modelBuilder.Entity<Fight>().HasData(new List<Fight>
        {
            // Fame 1: Boxdel vs. Guzik - https://www.instagram.com/p/Bkfp-DhFjCC/?hl=pl
            new()
            {
                Id = 1,
                EventId = 1,
                TypeId = 46,
                OrderNumber = 1,
                Created = date,
                Modified = date,
                VideoUrl = "https://www.youtube.com/watch?v=RJmrHnZREuc&ab_channel=FAMEMMA"
            },
            new()
            {
                Id = 2,
                EventId = 1,
                TypeId = 46,
                OrderNumber = 2,
                Created = date,
                Modified = date,
                VideoUrl = "https://www.youtube.com/watch?v=yg7NZ7Q_VHU&ab_channel=FAMEMMA"
            },
            new()
            {
                Id = 3,
                EventId = 1,
                TypeId = 46,
                OrderNumber = 3,
                Created = date,
                Modified = date,
                VideoUrl = "https://www.youtube.com/watch?v=k3a8eQbOQCs&ab_channel=FAMEMMA"
            },
            new()
            {
                Id = 4,
                EventId = 1,
                TypeId = 46,
                OrderNumber = 4,
                Created = date,
                Modified = date,
                VideoUrl = "https://www.youtube.com/watch?v=GRhM7xCHPDM&ab_channel=FAMEMMA"
            },
            new()
            {
                Id = 5,
                EventId = 1,
                TypeId = 46,
                OrderNumber = 5,
                Created = date,
                Modified = date,
                VideoUrl = "https://www.youtube.com/watch?v=wghJm2H15zo&ab_channel=FAMEMMA"
            },
            new()
            {
                Id = 6,
                EventId = 1,
                TypeId = 46,
                OrderNumber = 6,
                Created = date,
                Modified = date,
                VideoUrl = "https://www.youtube.com/watch?v=EWrpMB7X1tg&ab_channel=FAMEMMA"
            },
            new()
            {
                Id = 7,
                EventId = 1,
                TypeId = 45,
                OrderNumber = 7,
                Created = date,
                Modified = date,
                VideoUrl = "https://www.youtube.com/watch?v=M9BUm0q5R4A&ab_channel=FAMEMMA"
            },
            new()
            {
                Id = 8,
                EventId = 1,
                TypeId = 44,
                OrderNumber = 8,
                Created = date,
                Modified = date,
                VideoUrl = "https://www.youtube.com/watch?v=tIrIPVxxoLM&ab_channel=FAMEMMA"
            },

            // Fame 2: Rafonix vs. Magical
            new()
            {
                Id = 9,
                EventId = 2,
                TypeId = 46,
                OrderNumber = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 10,
                EventId = 2,
                TypeId = 46,
                OrderNumber = 2,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 11,
                EventId = 2,
                TypeId = 46,
                OrderNumber = 3,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 12,
                EventId = 2,
                TypeId = 46,
                OrderNumber = 4,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 13,
                EventId = 2,
                TypeId = 46,
                OrderNumber = 5,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 14,
                EventId = 2,
                TypeId = 46,
                OrderNumber = 6,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 15,
                EventId = 2,
                TypeId = 45,
                OrderNumber = 7,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 16,
                EventId = 2,
                TypeId = 44,
                OrderNumber = 8,
                Created = date,
                Modified = date
            },

            // Fame 3: IsAmU vs. DeeJayPallaside
            new()
            {
                Id = 17,
                EventId = 3,
                TypeId = 46,
                OrderNumber = 1,
                Created = date,
                Modified = date,
                VideoUrl = "https://www.youtube.com/watch?v=Ck6cz-9fqy4&ab_channel=FAMEMMA"
            },
            new()
            {
                Id = 18,
                EventId = 3,
                TypeId = 46,
                OrderNumber = 2,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 19,
                EventId = 3,
                TypeId = 46,
                OrderNumber = 3,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 20,
                EventId = 3,
                TypeId = 46,
                OrderNumber = 4,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 21,
                EventId = 3,
                TypeId = 46,
                OrderNumber = 5,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 22,
                EventId = 3,
                TypeId = 46,
                OrderNumber = 6,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 23,
                EventId = 3,
                TypeId = 46,
                OrderNumber = 7,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 24,
                EventId = 3,
                TypeId = 45,
                OrderNumber = 8,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 25,
                EventId = 3,
                TypeId = 44,
                OrderNumber = 9,
                Created = date,
                Modified = date
            },

            // Fame 4: Linkimaster vs. Lil Masti
            new()
            {
                Id = 26,
                EventId = 4,
                TypeId = 46,
                OrderNumber = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 27,
                EventId = 4,
                TypeId = 46,
                OrderNumber = 2,
                Created = date,
                Modified = date,
                VideoUrl = "https://www.youtube.com/watch?v=OCTHH8EA59U&ab_channel=FAMEMMA"
            },
            new()
            {
                Id = 28,
                EventId = 4,
                TypeId = 46,
                OrderNumber = 3,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 29,
                EventId = 4,
                TypeId = 46,
                OrderNumber = 4,
                Created = date,
                Modified = date,
                VideoUrl = "https://www.youtube.com/watch?v=9cDUs-_k0xM&ab_channel=FAMEMMA"
            },
            new()
            {
                Id = 30,
                EventId = 4,
                TypeId = 46,
                OrderNumber = 5,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 31,
                EventId = 4,
                TypeId = 46,
                OrderNumber = 6,
                Created = date,
                Modified = date,
                VideoUrl = "https://www.youtube.com/watch?v=a2vvX8attvA&ab_channel=FAMEMMA"
            },
            new()
            {
                Id = 32,
                EventId = 4,
                TypeId = 45,
                OrderNumber = 7,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 33,
                EventId = 4,
                TypeId = 44,
                OrderNumber = 8,
                Created = date,
                Modified = date,
                VideoUrl = "https://www.youtube.com/watch?v=ioXCRMuMgWE&ab_channel=FAMEMMA"
            },

            // Fame 5: Bonus BGC vs. Najman - https://www.instagram.com/p/B4FzXhRgiPF/?hl=pl
            new()
            {
                Id = 34,
                EventId = 5,
                TypeId = 46,
                OrderNumber = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 35,
                EventId = 5,
                TypeId = 46,
                OrderNumber = 2,
                Created = date,
                Modified = date,
                VideoUrl = "https://www.youtube.com/watch?v=LYnvEk6JuWc&ab_channel=FAMEMMA"
            },
            new()
            {
                Id = 36,
                EventId = 5,
                TypeId = 46,
                OrderNumber = 3,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 37,
                EventId = 5,
                TypeId = 46,
                OrderNumber = 4,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 38,
                EventId = 5,
                TypeId = 46,
                OrderNumber = 5,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 39,
                EventId = 5,
                TypeId = 51,
                OrderNumber = 6,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 40,
                EventId = 5,
                TypeId = 45,
                OrderNumber = 7,
                Created = date,
                Modified = date,
                VideoUrl = "https://www.youtube.com/watch?v=bOzrVXyBINU&ab_channel=FAMEMMA"
            },
            new()
            {
                Id = 41,
                EventId = 5,
                TypeId = 44,
                OrderNumber = 8,
                Created = date,
                Modified = date
            },

            // Fame 6: Zusje vs. Linkimaster - https://www.instagram.com/p/B-SWo4ijySf/?hl=pl
            new()
            {
                Id = 42,
                EventId = 6,
                TypeId = 46,
                OrderNumber = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 43,
                EventId = 6,
                TypeId = 46,
                OrderNumber = 2,
                Created = date,
                Modified = date,
                VideoUrl = "https://www.youtube.com/watch?v=mLfZkGGfCcU&ab_channel=FAMEMMA"
            },
            new()
            {
                Id = 44,
                EventId = 6,
                TypeId = 46,
                OrderNumber = 3,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 45,
                EventId = 6,
                TypeId = 46,
                OrderNumber = 4,
                Created = date,
                Modified = date,
                VideoUrl = "https://www.youtube.com/watch?v=Q6Vz-VkqGQI&ab_channel=FAMEMMA"
            },
            new()
            {
                Id = 46,
                EventId = 6,
                TypeId = 46,
                OrderNumber = 5,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 47,
                EventId = 6,
                TypeId = 46,
                OrderNumber = 6,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 48,
                EventId = 6,
                TypeId = 45,
                OrderNumber = 7,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 49,
                EventId = 6,
                TypeId = 44,
                OrderNumber = 8,
                Created = date,
                Modified = date
            },

            // Fame 7: Popek vs. Stifler
            new()
            {
                Id = 50,
                EventId = 7,
                TypeId = 47,
                OrderNumber = 1,
                Created = date,
                Modified = date,
                VideoUrl = "https://www.youtube.com/watch?v=IZZPItZV8AE&ab_channel=FAMEMMA"
            },
            new()
            {
                Id = 51,
                EventId = 7,
                TypeId = 47,
                OrderNumber = 2,
                Created = date,
                Modified = date,
                VideoUrl = "https://www.youtube.com/watch?v=IZZPItZV8AE&ab_channel=FAMEMMA"
            },
            new()
            {
                Id = 52,
                EventId = 7,
                TypeId = 46,
                OrderNumber = 3,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 53,
                EventId = 7,
                TypeId = 46,
                OrderNumber = 4,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 54,
                EventId = 7,
                TypeId = 46,
                OrderNumber = 5,
                Created = date,
                Modified = date,
                VideoUrl = "https://www.youtube.com/watch?v=4CxtRKOUpPo&ab_channel=FAMEMMA"
            },
            new()
            {
                Id = 55,
                EventId = 7,
                TypeId = 46,
                OrderNumber = 6,
                Created = date,
                Modified = date,
                VideoUrl = "https://www.youtube.com/watch?v=jVf0NC5qeIE&ab_channel=FAMEMMA"
            },
            new()
            {
                Id = 56,
                EventId = 7,
                TypeId = 46,
                OrderNumber = 7,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 57,
                EventId = 7,
                TypeId = 46,
                OrderNumber = 8,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 58,
                EventId = 7,
                TypeId = 45,
                OrderNumber = 9,
                Created = date,
                Modified = date,
                VideoUrl = "https://www.youtube.com/watch?v=5dZAbcm-ku8&ab_channel=FAMEMMA"
            },
            new()
            {
                Id = 59,
                EventId = 7,
                TypeId = 44,
                OrderNumber = 10,
                Created = date,
                Modified = date,
                VideoUrl = "https://www.youtube.com/watch?v=Ti7MHwvMoUc&ab_channel=FAMEMMA"
            },

            // Fame 8: Dubiel vs. Blonsky - https://www.instagram.com/p/CH3SUK5j9Af/?hl=pl
            new()
            {
                Id = 60,
                EventId = 8,
                TypeId = 47,
                OrderNumber = 1,
                Created = date,
                Modified = date,
                VideoUrl = "https://www.youtube.com/watch?v=F-CHZr-j7Jc&ab_channel=FAMEMMA"
            },
            new()
            {
                Id = 61,
                EventId = 8,
                TypeId = 47,
                OrderNumber = 2,
                Created = date,
                Modified = date,
                VideoUrl = "https://www.youtube.com/watch?v=EoizbbZ862I&ab_channel=FAMEMMA"
            },
            new()
            {
                Id = 62,
                EventId = 8,
                TypeId = 46,
                OrderNumber = 3,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 63,
                EventId = 8,
                TypeId = 46,
                OrderNumber = 4,
                Created = date,
                Modified = date,
                VideoUrl = "https://www.youtube.com/watch?v=3qVyaSR-w-g&ab_channel=FAMEMMA"
            },
            new()
            {
                Id = 64,
                EventId = 8,
                TypeId = 46,
                OrderNumber = 5,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 65,
                EventId = 8,
                TypeId = 46,
                OrderNumber = 6,
                Created = date,
                Modified = date,
                VideoUrl = "https://www.youtube.com/watch?v=TtSPwB5GsDE&ab_channel=FAMEMMA"
            },
            new()
            {
                Id = 66,
                EventId = 8,
                TypeId = 46,
                OrderNumber = 7,
                Created = date,
                Modified = date,
                VideoUrl = "https://www.youtube.com/watch?v=p8c_ON4KXmw&ab_channel=FAMEMMA"
            },
            new()
            {
                Id = 67,
                EventId = 8,
                TypeId = 46,
                OrderNumber = 8,
                Created = date,
                Modified = date,
                VideoUrl = "https://www.youtube.com/watch?v=PAwLMfKVXgo&ab_channel=FAMEMMA"
            },
            new()
            {
                Id = 68,
                EventId = 8,
                TypeId = 45,
                OrderNumber = 9,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 69,
                EventId = 8,
                TypeId = 44,
                OrderNumber = 10,
                Created = date,
                Modified = date,
                VideoUrl = "https://www.youtube.com/watch?v=ioXCRMuMgWE&ab_channel=FAMEMMA"
            },

            // Fame 9: Let’s Play - https://www.instagram.com/p/CME61-IjeXY/?hl=pl
            new()
            {
                Id = 70,
                EventId = 9,
                TypeId = 47,
                OrderNumber = 1,
                Created = date,
                Modified = date,
                VideoUrl = "https://www.youtube.com/watch?v=EL1R-a5ueHc&ab_channel=FAMEMMA"
            },
            new()
            {
                Id = 71,
                EventId = 9,
                TypeId = 47,
                OrderNumber = 2,
                Created = date,
                Modified = date,
                VideoUrl = "https://www.youtube.com/watch?v=EL1R-a5ueHc&ab_channel=FAMEMMA"
            },
            new()
            {
                Id = 72,
                EventId = 9,
                TypeId = 46,
                OrderNumber = 3,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 73,
                EventId = 9,
                TypeId = 46,
                OrderNumber = 4,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 74,
                EventId = 9,
                TypeId = 46,
                OrderNumber = 5,
                Created = date,
                Modified = date,
                VideoUrl = "https://www.youtube.com/watch?v=Ti7MHwvMoUc&ab_channel=FAMEMMA"
            },
            new()
            {
                Id = 75,
                EventId = 9,
                TypeId = 46,
                OrderNumber = 6,
                Created = date,
                Modified = date,
                VideoUrl = "https://www.youtube.com/watch?v=Ti7MHwvMoUc&ab_channel=FAMEMMA"
            },
            new()
            {
                Id = 76,
                EventId = 9,
                TypeId = 46,
                OrderNumber = 7,
                Created = date,
                Modified = date,
                VideoUrl = "https://www.youtube.com/watch?v=e2w_iGuxEw4&ab_channel=FAMEMMA"
            },
            new()
            {
                Id = 77,
                EventId = 9,
                TypeId = 46,
                OrderNumber = 8,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 78,
                EventId = 9,
                TypeId = 45,
                OrderNumber = 9,
                Created = date,
                Modified = date,
                VideoUrl = "https://www.youtube.com/watch?v=Vzvow8FGYoU&t=1s&ab_channel=FAMEMMA"
            },
            new()
            {
                Id = 79,
                EventId = 9,
                TypeId = 44,
                OrderNumber = 10,
                Created = date,
                Modified = date
            },

            // Fame 10: Don Kasjo vs. Parke - https://www.instagram.com/p/CO5o6QSDnEC/?hl=pl
            new()
            {
                Id = 80,
                EventId = 10,
                TypeId = 47,
                OrderNumber = 1,
                Created = date,
                Modified = date,
                VideoUrl = "https://www.youtube.com/watch?v=vWNTVkENQwM&ab_channel=FAMEMMA"
            },
            new()
            {
                Id = 81,
                EventId = 10,
                TypeId = 47,
                OrderNumber = 2,
                Created = date,
                Modified = date,
                VideoUrl = "https://www.youtube.com/watch?v=vWNTVkENQwM&ab_channel=FAMEMMA"
            },
            new()
            {
                Id = 82,
                EventId = 10,
                TypeId = 46,
                OrderNumber = 3,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 83,
                EventId = 10,
                TypeId = 46,
                OrderNumber = 4,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 84,
                EventId = 10,
                TypeId = 46,
                OrderNumber = 5,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 85,
                EventId = 10,
                TypeId = 46,
                OrderNumber = 6,
                Created = date,
                Modified = date,
                VideoUrl = "https://www.youtube.com/watch?v=SKie_bCUows&ab_channel=FAMEMMA"
            },
            new()
            {
                Id = 86,
                EventId = 10,
                TypeId = 46,
                OrderNumber = 7,
                Created = date,
                Modified = date,
                VideoUrl = "https://www.youtube.com/watch?v=Ti7MHwvMoUc&ab_channel=FAMEMMA"
            },
            new()
            {
                Id = 87,
                EventId = 10,
                TypeId = 46,
                OrderNumber = 8,
                Created = date,
                Modified = date,
                VideoUrl = "https://www.youtube.com/watch?v=kwKvx4iQ9SI&ab_channel=FAMEMMA"
            },
            new()
            {
                Id = 88,
                EventId = 10,
                TypeId = 45,
                OrderNumber = 9,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 89,
                EventId = 10,
                TypeId = 44,
                OrderNumber = 10,
                Created = date,
                Modified = date
            },

            // Fame 11: Fight Club - https://www.instagram.com/p/CUiQ57XsgIb/?hl=pl
            new()
            {
                Id = 90,
                EventId = 11,
                TypeId = 47,
                OrderNumber = 1,
                Created = date,
                Modified = date,
                VideoUrl = "https://www.youtube.com/watch?v=s8jVDUnFf5U&ab_channel=FAMEMMA"
            },
            new()
            {
                Id = 91,
                EventId = 11,
                TypeId = 47,
                OrderNumber = 2,
                Created = date,
                Modified = date,
                VideoUrl = "https://www.youtube.com/watch?v=s8jVDUnFf5U&ab_channel=FAMEMMA"
            },
            new()
            {
                Id = 92,
                EventId = 11,
                TypeId = 47,
                OrderNumber = 3,
                Created = date,
                Modified = date,
                VideoUrl = "https://www.youtube.com/watch?v=s8jVDUnFf5U&ab_channel=FAMEMMA"
            },
            new()
            {
                Id = 93,
                EventId = 11,
                TypeId = 47,
                OrderNumber = 4,
                Created = date,
                Modified = date,
                VideoUrl = "https://www.youtube.com/watch?v=s8jVDUnFf5U&ab_channel=FAMEMMA"
            },
            new()
            {
                Id = 94,
                EventId = 11,
                TypeId = 46,
                OrderNumber = 5,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 95,
                EventId = 11,
                TypeId = 46,
                OrderNumber = 6,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 96,
                EventId = 11,
                TypeId = 46,
                OrderNumber = 7,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 97,
                EventId = 11,
                TypeId = 46,
                OrderNumber = 8,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 98,
                EventId = 11,
                TypeId = 46,
                OrderNumber = 9,
                Created = date,
                Modified = date,
                VideoUrl = "https://www.youtube.com/watch?v=Ti7MHwvMoUc&ab_channel=FAMEMMA"
            },
            new()
            {
                Id = 99,
                EventId = 11,
                TypeId = 46,
                OrderNumber = 10,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 100,
                EventId = 11,
                TypeId = 45,
                OrderNumber = 11,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 101,
                EventId = 11,
                TypeId = 45,
                OrderNumber = 12,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 102,
                EventId = 11,
                TypeId = 44,
                OrderNumber = 13,
                Created = date,
                Modified = date
            },

            // Fame 12: Don Kasjo vs. Polish Zombie - https://www.instagram.com/p/CWgiwrcsL8E/?hl=pl
            new()
            {
                Id = 103,
                EventId = 12,
                TypeId = 47,
                OrderNumber = 1,
                Created = date,
                Modified = date,
                VideoUrl = "https://www.youtube.com/watch?v=T3TV7VBCM-M&ab_channel=FAMEMMA"
            },
            new()
            {
                Id = 104,
                EventId = 12,
                TypeId = 47,
                OrderNumber = 2,
                Created = date,
                Modified = date,
                VideoUrl = "https://www.youtube.com/watch?v=T3TV7VBCM-M&ab_channel=FAMEMMA"
            },
            new()
            {
                Id = 105,
                EventId = 12,
                TypeId = 47,
                OrderNumber = 3,
                Created = date,
                Modified = date,
                VideoUrl = "https://www.youtube.com/watch?v=T3TV7VBCM-M&ab_channel=FAMEMMA"
            },
            new()
            {
                Id = 106,
                EventId = 12,
                TypeId = 46,
                OrderNumber = 4,
                Created = date,
                Modified = date,
                VideoUrl = "https://www.youtube.com/watch?v=ZPyVyWnGdwU&ab_channel=FAMEMMA"
            },
            new()
            {
                Id = 107,
                EventId = 12,
                TypeId = 46,
                OrderNumber = 5,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 108,
                EventId = 12,
                TypeId = 46,
                OrderNumber = 6,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 109,
                EventId = 12,
                TypeId = 46,
                OrderNumber = 7,
                Created = date,
                Modified = date,
                VideoUrl = "https://www.youtube.com/watch?v=ZPyVyWnGdwU&ab_channel=FAMEMMA"
            },
            new()
            {
                Id = 110,
                EventId = 12,
                TypeId = 45,
                OrderNumber = 8,
                Created = date,
                Modified = date,
                VideoUrl = "https://www.youtube.com/watch?v=ZPyVyWnGdwU&ab_channel=FAMEMMA"
            },
            new()
            {
                Id = 111,
                EventId = 12,
                TypeId = 44,
                OrderNumber = 9,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 112,
                EventId = 12,
                TypeId = 49,
                OrderNumber = 10,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 113,
                EventId = 12,
                TypeId = 50,
                OrderNumber = 11,
                Created = date,
                Modified = date,
                VideoUrl = "https://www.youtube.com/watch?v=ioXCRMuMgWE&ab_channel=FAMEMMA"
            },

            // Fame 13: Nitro vs. Unboxall - https://www.instagram.com/p/CbkyEc-sZkL/?hl=pl
            new()
            {
                Id = 114,
                EventId = 13,
                TypeId = 47,
                OrderNumber = 1,
                Created = date,
                Modified = date,
                VideoUrl = "https://www.youtube.com/watch?v=zikm9zt5sXQ&t=4125s&ab_channel=FAMEMMA"
            },
            new()
            {
                Id = 115,
                EventId = 13,
                TypeId = 47,
                OrderNumber = 2,
                Created = date,
                Modified = date,
                VideoUrl = "https://www.youtube.com/watch?v=zikm9zt5sXQ&t=4125s&ab_channel=FAMEMMA"
            },
            new()
            {
                Id = 116,
                EventId = 13,
                TypeId = 46,
                OrderNumber = 3,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 117,
                EventId = 13,
                TypeId = 46,
                OrderNumber = 4,
                Created = date,
                Modified = date,
                VideoUrl = "https://www.youtube.com/watch?v=44-B4JkMddc&ab_channel=FAMEMMA"
            },
            new()
            {
                Id = 118,
                EventId = 13,
                TypeId = 46,
                OrderNumber = 5,
                Created = date,
                Modified = date,
                VideoUrl = "https://www.youtube.com/watch?v=zn1D1sF8JHg&ab_channel=FAMEMMA"
            },
            new()
            {
                Id = 119,
                EventId = 13,
                TypeId = 46,
                OrderNumber = 6,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 120,
                EventId = 13,
                TypeId = 46,
                OrderNumber = 7,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 121,
                EventId = 13,
                TypeId = 45,
                OrderNumber = 8,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 122,
                EventId = 13,
                TypeId = 44,
                OrderNumber = 9,
                Created = date,
                Modified = date
            },

            // Fame 14: Gimper vs. Tromba - https://www.instagram.com/p/CdjBGS7MG6P/?hl=pl
            new()
            {
                Id = 123,
                EventId = 14,
                TypeId = 47,
                OrderNumber = 1,
                Created = date,
                Modified = date,
                VideoUrl = "https://www.youtube.com/watch?v=raVNraN7F0A&t=4384s&ab_channel=FAMEMMA"
            },
            new()
            {
                Id = 124,
                EventId = 14,
                TypeId = 47,
                OrderNumber = 2,
                Created = date,
                Modified = date,
                VideoUrl = "https://www.youtube.com/watch?v=raVNraN7F0A&t=4384s&ab_channel=FAMEMMA"
            },
            new()
            {
                Id = 125,
                EventId = 14,
                TypeId = 46,
                OrderNumber = 3,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 126,
                EventId = 14,
                TypeId = 46,
                OrderNumber = 4,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 127,
                EventId = 14,
                TypeId = 46,
                OrderNumber = 5,
                Created = date,
                Modified = date,
                VideoUrl = "https://www.youtube.com/watch?v=mFPkF908m4U&ab_channel=FAMEMMA"
            },
            new()
            {
                Id = 128,
                EventId = 14,
                TypeId = 46,
                OrderNumber = 6,
                Created = date,
                Modified = date,
                VideoUrl = "https://www.youtube.com/watch?v=6YyAcXnWzio&ab_channel=FAMEMMA"
            },
            new()
            {
                Id = 129,
                EventId = 14,
                TypeId = 45,
                OrderNumber = 7,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 130,
                EventId = 14,
                TypeId = 45,
                OrderNumber = 8,
                Created = date,
                Modified = date,
                VideoUrl = "https://www.youtube.com/watch?v=ioXCRMuMgWE&ab_channel=FAMEMMA"
            },
            new()
            {
                Id = 131,
                EventId = 14,
                TypeId = 44,
                OrderNumber = 9,
                Created = date,
                Modified = date,
                VideoUrl = "https://www.youtube.com/watch?v=zn1D1sF8JHg&ab_channel=FAMEMMA"
            },

            // Fame 15: Zemsta - https://www.instagram.com/p/Chuid0fD_tb/?hl=pl
            new()
            {
                Id = 132,
                EventId = 15,
                TypeId = 47,
                OrderNumber = 1,
                Created = date,
                Modified = date,
                VideoUrl = "https://www.youtube.com/watch?v=yy0uNyt8Zrg&t=4783s&ab_channel=FAMEMMA"
            },
            new()
            {
                Id = 133,
                EventId = 15,
                TypeId = 47,
                OrderNumber = 2,
                Created = date,
                Modified = date,
                VideoUrl = "https://www.youtube.com/watch?v=yy0uNyt8Zrg&t=4783s&ab_channel=FAMEMMA"
            },
            new()
            {
                Id = 134,
                EventId = 15,
                TypeId = 46,
                OrderNumber = 3,
                Created = date,
                Modified = date,
                VideoUrl = "https://www.youtube.com/watch?v=snBfIaEJlew&ab_channel=FAMEMMA"
            },
            new()
            {
                Id = 135,
                EventId = 15,
                TypeId = 46,
                OrderNumber = 4,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 136,
                EventId = 15,
                TypeId = 46,
                OrderNumber = 5,
                Created = date,
                Modified = date,
                VideoUrl = "https://www.youtube.com/watch?v=zn1D1sF8JHg&ab_channel=FAMEMMA"
            },
            new()
            {
                Id = 137,
                EventId = 15,
                TypeId = 46,
                OrderNumber = 6,
                Created = date,
                Modified = date,
                VideoUrl = "https://www.youtube.com/watch?v=zn1D1sF8JHg&ab_channel=FAMEMMA"
            },
            new()
            {
                Id = 138,
                EventId = 15,
                TypeId = 46,
                OrderNumber = 7,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 139,
                EventId = 15,
                TypeId = 45,
                OrderNumber = 8,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 140,
                EventId = 15,
                TypeId = 44,
                OrderNumber = 9,
                Created = date,
                Modified = date
            },

            // Fame 16: Tromba vs. Dubiel - https://www.instagram.com/p/CklrG4bjSgV/?hl=pl
            new()
            {
                Id = 141,
                EventId = 16,
                TypeId = 47,
                OrderNumber = 1,
                Created = date,
                Modified = date,
                VideoUrl = "https://www.youtube.com/watch?v=nG_TSJi2BlU&ab_channel=FAMEMMA"
            },
            new()
            {
                Id = 142,
                EventId = 16,
                TypeId = 47,
                OrderNumber = 2,
                Created = date,
                Modified = date,
                VideoUrl = "https://www.youtube.com/watch?v=nG_TSJi2BlU&ab_channel=FAMEMMA"
            },
            new()
            {
                Id = 143,
                EventId = 16,
                TypeId = 46,
                OrderNumber = 3,
                Created = date,
                Modified = date,
                VideoUrl = "https://www.youtube.com/watch?v=SnTjjqPEIWc&ab_channel=FAMEMMA"
            },
            new()
            {
                Id = 144,
                EventId = 16,
                TypeId = 46,
                OrderNumber = 4,
                Created = date,
                Modified = date,
                VideoUrl = "https://www.youtube.com/watch?v=44-B4JkMddc&ab_channel=FAMEMMA"
            },
            new()
            {
                Id = 145,
                EventId = 16,
                TypeId = 46,
                OrderNumber = 5,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 146,
                EventId = 16,
                TypeId = 46,
                OrderNumber = 6,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 147,
                EventId = 16,
                TypeId = 46,
                OrderNumber = 7,
                Created = date,
                Modified = date,
                VideoUrl = "https://www.youtube.com/watch?v=44-B4JkMddc&ab_channel=FAMEMMA"
            },
            new()
            {
                Id = 148,
                EventId = 16,
                TypeId = 46,
                OrderNumber = 8,
                Created = date,
                Modified = date,
                VideoUrl = "https://www.youtube.com/watch?v=mLfz85zWeEA&ab_channel=FAMEMMA"
            },
            new()
            {
                Id = 149,
                EventId = 16,
                TypeId = 45,
                OrderNumber = 9,
                Created = date,
                Modified = date,
                VideoUrl = "https://www.youtube.com/watch?v=fKasH9qjLGw&ab_channel=FAMEMMA"
            },
            new()
            {
                Id = 150,
                EventId = 16,
                TypeId = 44,
                OrderNumber = 10,
                Created = date,
                Modified = date
            },

            // Fame 17: Ferrari vs. Łaszczyk - https://www.instagram.com/p/CoNc8JzMB80/?hl=pl
            new()
            {
                Id = 151,
                EventId = 17,
                TypeId = 47,
                OrderNumber = 1,
                Created = date,
                Modified = date,
                VideoUrl = "https://www.youtube.com/watch?v=8KsZ2Tf3RPE&ab_channel=FAMEMMA"
            },
            new()
            {
                Id = 152,
                EventId = 17,
                TypeId = 46,
                OrderNumber = 2,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 153,
                EventId = 17,
                TypeId = 46,
                OrderNumber = 3,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 154,
                EventId = 17,
                TypeId = 46,
                OrderNumber = 4,
                Created = date,
                Modified = date,
                VideoUrl = "https://www.youtube.com/watch?v=uQKD_LoPbVw&ab_channel=FAMEMMA"
            },
            new()
            {
                Id = 155,
                EventId = 17,
                TypeId = 46,
                OrderNumber = 5,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 156,
                EventId = 17,
                TypeId = 46,
                OrderNumber = 6,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 157,
                EventId = 17,
                TypeId = 45,
                OrderNumber = 7,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 158,
                EventId = 17,
                TypeId = 44,
                OrderNumber = 8,
                Created = date,
                Modified = date,
                VideoUrl = "https://www.youtube.com/watch?v=mqYuAdOa65s&ab_channel=FAMEMMA"
            },
            new()
            {
                Id = 159,
                EventId = 17,
                TypeId = 48,
                OrderNumber = 9,
                Created = date,
                Modified = date,
                VideoUrl = "https://www.youtube.com/watch?v=gtQo24Hydqk&t=21s&ab_channel=FAMEMMA"
            },

            // Fame 18: Crusher vs. Ferrari - https://www.instagram.com/p/Csd9OEnMrpY/?hl=pl
            new()
            {
                Id = 160,
                EventId = 18,
                TypeId = 47,
                OrderNumber = 1,
                Created = date,
                Modified = date,
                VideoUrl = "https://www.youtube.com/watch?v=i6AQEC9PkE0&ab_channel=FAMEMMA"
            },
            new()
            {
                Id = 161,
                EventId = 18,
                TypeId = 47,
                OrderNumber = 2,
                Created = date,
                Modified = date,
                VideoUrl = "https://www.youtube.com/watch?v=i6AQEC9PkE0&ab_channel=FAMEMMA"
            },
            new()
            {
                Id = 162,
                EventId = 18,
                TypeId = 46,
                OrderNumber = 3,
                Created = date,
                Modified = date,
                VideoUrl = "https://www.youtube.com/watch?v=Hkc4NvaXG6U&ab_channel=FAMEMMA"
            },
            new()
            {
                Id = 163,
                EventId = 18,
                TypeId = 46,
                OrderNumber = 4,
                Created = date,
                Modified = date,
                VideoUrl = "https://www.youtube.com/watch?v=shKk1kUfcz8&ab_channel=FAMEMMA"
            },
            new()
            {
                Id = 164,
                EventId = 18,
                TypeId = 46,
                OrderNumber = 5,
                Created = date,
                Modified = date,
                VideoUrl = "https://www.youtube.com/watch?v=sr_POb5I28k&ab_channel=FAMEMMA"
            },
            new()
            {
                Id = 165,
                EventId = 18,
                TypeId = 46,
                OrderNumber = 6,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 166,
                EventId = 18,
                TypeId = 46,
                OrderNumber = 7,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 167,
                EventId = 18,
                TypeId = 45,
                OrderNumber = 8,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 168,
                EventId = 18,
                TypeId = 44,
                OrderNumber = 9,
                Created = date,
                Modified = date,
                VideoUrl = "https://www.youtube.com/watch?v=EDfp36qWCpk&ab_channel=FAMEMMA"
            },

            // Fame 19: Tańcula vs. Ferrari - https://www.instagram.com/p/CwsorWLMGue/?hl=pl
            new()
            {
                Id = 169,
                EventId = 19,
                TypeId = 47,
                OrderNumber = 1,
                Created = date,
                Modified = date,
                VideoUrl = "https://www.youtube.com/watch?v=ObjqteutY7Q&t=5361s&ab_channel=FAMEMMA"
            },
            new()
            {
                Id = 170,
                EventId = 19,
                TypeId = 47,
                OrderNumber = 2,
                Created = date,
                Modified = date,
                VideoUrl = "https://www.youtube.com/watch?v=ObjqteutY7Q&t=5361s&ab_channel=FAMEMMA"
            },
            new()
            {
                Id = 171,
                EventId = 19,
                TypeId = 46,
                OrderNumber = 3,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 172,
                EventId = 19,
                TypeId = 46,
                OrderNumber = 4,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 173,
                EventId = 19,
                TypeId = 46,
                OrderNumber = 5,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 174,
                EventId = 19,
                TypeId = 46,
                OrderNumber = 6,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 175,
                EventId = 19,
                TypeId = 46,
                OrderNumber = 7,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 176,
                EventId = 19,
                TypeId = 45,
                OrderNumber = 8,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 177,
                EventId = 19,
                TypeId = 45,
                OrderNumber = 9,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 178,
                EventId = 19,
                TypeId = 44,
                OrderNumber = 10,
                Created = date,
                Modified = date
            },

            // Fame UK 1: Gowland vs. McKenna
            new()
            {
                Id = 179,
                EventId = 20,
                TypeId = 46,
                OrderNumber = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 180,
                EventId = 20,
                TypeId = 46,
                OrderNumber = 2,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 181,
                EventId = 20,
                TypeId = 46,
                OrderNumber = 3,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 182,
                EventId = 20,
                TypeId = 46,
                OrderNumber = 4,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 183,
                EventId = 20,
                TypeId = 46,
                OrderNumber = 5,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 184,
                EventId = 20,
                TypeId = 46,
                OrderNumber = 6,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 185,
                EventId = 20,
                TypeId = 45,
                OrderNumber = 7,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 186,
                EventId = 20,
                TypeId = 44,
                OrderNumber = 8,
                Created = date,
                Modified = date
            },

            // Hype S01E01: Rafonix vs. Hejter - https://www.instagram.com/p/CNxggwAD5uq/?hl=pl
            new()
            {
                Id = 187,
                EventId = 21,
                TypeId = 46,
                OrderNumber = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 188,
                EventId = 21,
                TypeId = 46,
                OrderNumber = 2,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 189,
                EventId = 21,
                TypeId = 46,
                OrderNumber = 3,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 190,
                EventId = 21,
                TypeId = 46,
                OrderNumber = 4,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 191,
                EventId = 21,
                TypeId = 46,
                OrderNumber = 6,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 192,
                EventId = 21,
                TypeId = 46,
                OrderNumber = 7,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 193,
                EventId = 21,
                TypeId = 48,
                OrderNumber = 5,
                Created = date,
                Modified = date
            },

            // Fame Friday Arena 1: Alberto vs. Kubańczyk - https://www.instagram.com/p/Cu91BWqMosf/?hl=pl
            new()
            {
                Id = 194,
                EventId = 22,
                TypeId = 47,
                OrderNumber = 1,
                Created = date,
                Modified = date,
                VideoUrl = "https://www.youtube.com/watch?v=_z2zs3nb57k&ab_channel=FAMEMMA"
            },
            new()
            {
                Id = 195,
                EventId = 22,
                TypeId = 47,
                OrderNumber = 2,
                Created = date,
                Modified = date,
                VideoUrl = "https://www.youtube.com/watch?v=_z2zs3nb57k&ab_channel=FAMEMMA"
            },
            new()
            {
                Id = 196,
                EventId = 22,
                TypeId = 46,
                OrderNumber = 3,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 197,
                EventId = 22,
                TypeId = 46,
                OrderNumber = 4,
                Created = date,
                Modified = date,
                VideoUrl = "https://www.youtube.com/watch?v=fVAtTRrKT6s&ab_channel=FAMEMMA"
            },
            new()
            {
                Id = 198,
                EventId = 22,
                TypeId = 46,
                OrderNumber = 5,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 199,
                EventId = 22,
                TypeId = 46,
                OrderNumber = 6,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 200,
                EventId = 22,
                TypeId = 46,
                OrderNumber = 7,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 201,
                EventId = 22,
                TypeId = 45,
                OrderNumber = 8,
                Created = date,
                Modified = date,
                VideoUrl = "https://www.youtube.com/watch?v=VD92IuW_utI&ab_channel=FAMEMMA"
            },
            new()
            {
                Id = 202,
                EventId = 22,
                TypeId = 45,
                OrderNumber = 9,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 203,
                EventId = 22,
                TypeId = 44,
                OrderNumber = 10,
                Created = date,
                Modified = date
            },

            // Fame Friday Arena 2: Prezes FEN vs. Boxdel 2 - https://www.instagram.com/p/CxyLFrYMJWz/?hl=pl
            new()
            {
                Id = 204,
                EventId = 23,
                TypeId = 47,
                OrderNumber = 1,
                Created = date,
                Modified = date,
                VideoUrl = "https://www.youtube.com/watch?v=dnjMyrEFids&t=4788s&ab_channel=FAMEMMA"
            },
            new()
            {
                Id = 205,
                EventId = 23,
                TypeId = 47,
                OrderNumber = 2,
                Created = date,
                Modified = date,
                VideoUrl = "https://www.youtube.com/watch?v=dnjMyrEFids&t=4788s&ab_channel=FAMEMMA"
            },
            new()
            {
                Id = 206,
                EventId = 23,
                TypeId = 46,
                OrderNumber = 3,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 207,
                EventId = 23,
                TypeId = 46,
                OrderNumber = 4,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 208,
                EventId = 23,
                TypeId = 46,
                OrderNumber = 5,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 209,
                EventId = 23,
                TypeId = 46,
                OrderNumber = 6,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 210,
                EventId = 23,
                TypeId = 46,
                OrderNumber = 7,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 211,
                EventId = 23,
                TypeId = 46,
                OrderNumber = 8,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 212,
                EventId = 23,
                TypeId = 45,
                OrderNumber = 9,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 213,
                EventId = 23,
                TypeId = 45,
                OrderNumber = 10,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 214,
                EventId = 23,
                TypeId = 44,
                OrderNumber = 11,
                Created = date,
                Modified = date
            },

            // Fame: Reborn - https://www.instagram.com/p/C0ovr_9MDUu/?hl=pl
            new()
            {
                Id = 215,
                EventId = 24,
                TypeId = 47,
                OrderNumber = 1,
                Created = date,
                Modified = date,
                VideoUrl = "https://www.youtube.com/watch?v=0aEeU5yF8qg&t=3703s&ab_channel=FAMEMMA"
            },
            new()
            {
                Id = 216,
                EventId = 24,
                TypeId = 47,
                OrderNumber = 2,
                Created = date,
                Modified = date,
                VideoUrl = "https://www.youtube.com/watch?v=0aEeU5yF8qg&t=3703s&ab_channel=FAMEMMA"
            },
            new()
            {
                Id = 217,
                EventId = 24,
                TypeId = 46,
                OrderNumber = 3,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 218,
                EventId = 24,
                TypeId = 46,
                OrderNumber = 4,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 219,
                EventId = 24,
                TypeId = 46,
                OrderNumber = 5,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 220,
                EventId = 24,
                TypeId = 46,
                OrderNumber = 6,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 221,
                EventId = 24,
                TypeId = 46,
                OrderNumber = 7,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 222,
                EventId = 24,
                TypeId = 46,
                OrderNumber = 8,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 223,
                EventId = 24,
                TypeId = 46,
                OrderNumber = 9,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 224,
                EventId = 24,
                TypeId = 46,
                OrderNumber = 10,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 225,
                EventId = 24,
                TypeId = 45,
                OrderNumber = 11,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 226,
                EventId = 24,
                TypeId = 44,
                OrderNumber = 12,
                Created = date,
                Modified = date
            },

            // Prime 1: Zadyma - https://www.instagram.com/p/CZ92vbascP1/
            new()
            {
                Id = 227,
                EventId = 25,
                TypeId = 47,
                OrderNumber = 1,
                Created = date,
                Modified = date,
                VideoUrl = "https://www.youtube.com/watch?v=0MfU11WqnLQ&ab_channel=PRIMESHOWMMA"
            },
            new()
            {
                Id = 228,
                EventId = 25,
                TypeId = 47,
                OrderNumber = 2,
                Created = date,
                Modified = date,
                VideoUrl = "https://www.youtube.com/watch?v=0MfU11WqnLQ&ab_channel=PRIMESHOWMMA"
            },
            new()
            {
                Id = 229,
                EventId = 25,
                TypeId = 46,
                OrderNumber = 3,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 230,
                EventId = 25,
                TypeId = 46,
                OrderNumber = 4,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 231,
                EventId = 25,
                TypeId = 46,
                OrderNumber = 5,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 232,
                EventId = 25,
                TypeId = 46,
                OrderNumber = 6,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 233,
                EventId = 25,
                TypeId = 46,
                OrderNumber = 7,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 234,
                EventId = 25,
                TypeId = 46,
                OrderNumber = 8,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 235,
                EventId = 25,
                TypeId = 46,
                OrderNumber = 9,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 236,
                EventId = 25,
                TypeId = 46,
                OrderNumber = 10,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 237,
                EventId = 25,
                TypeId = 45,
                OrderNumber = 11,
                Created = date,
                Modified = date,
                VideoUrl = "https://www.youtube.com/watch?v=QZyNbbSo5z0&ab_channel=PRIMESHOWMMA"
            },
            new()
            {
                Id = 238,
                EventId = 25,
                TypeId = 44,
                OrderNumber = 12,
                Created = date,
                Modified = date
            },

            // Prime 2: Kosmos - https://www.instagram.com/p/CfyOjsSDdU7/
            new()
            {
                Id = 239,
                EventId = 26,
                TypeId = 47,
                OrderNumber = 1,
                Created = date,
                Modified = date,
                VideoUrl = "https://www.youtube.com/watch?v=Td_CMTYWXGY&ab_channel=PRIMESHOWMMA"
            },
            new()
            {
                Id = 240,
                EventId = 26,
                TypeId = 47,
                OrderNumber = 2,
                Created = date,
                Modified = date,
                VideoUrl = "https://www.youtube.com/watch?v=Td_CMTYWXGY&ab_channel=PRIMESHOWMMA"
            },
            new()
            {
                Id = 241,
                EventId = 26,
                TypeId = 46,
                OrderNumber = 3,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 242,
                EventId = 26,
                TypeId = 46,
                OrderNumber = 4,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 243,
                EventId = 26,
                TypeId = 46,
                OrderNumber = 5,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 244,
                EventId = 26,
                TypeId = 46,
                OrderNumber = 6,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 245,
                EventId = 26,
                TypeId = 46,
                OrderNumber = 7,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 246,
                EventId = 26,
                TypeId = 46,
                OrderNumber = 8,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 247,
                EventId = 26,
                TypeId = 46,
                OrderNumber = 9,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 248,
                EventId = 26,
                TypeId = 46,
                OrderNumber = 10,
                Created = date,
                Modified = date,
                VideoUrl = "https://www.youtube.com/watch?v=ZvlEa3EjCt4&ab_channel=PRIMESHOWMMA"
            },
            new()
            {
                Id = 249,
                EventId = 26,
                TypeId = 45,
                OrderNumber = 11,
                Created = date,
                Modified = date,
                VideoUrl = "https://www.youtube.com/watch?v=DzAGFBRRF38&ab_channel=PRIMESHOWMMA"
            },
            new()
            {
                Id = 250,
                EventId = 26,
                TypeId = 44,
                OrderNumber = 12,
                Created = date,
                Modified = date,
                VideoUrl = "https://www.youtube.com/watch?v=EPdKOAK-a-Q&ab_channel=PRIMESHOWMMA"
            },

            // Prime 3: Street Fighter - https://www.instagram.com/p/CjKlDJyj38z/
            new()
            {
                Id = 251,
                EventId = 27,
                TypeId = 47,
                OrderNumber = 1,
                Created = date,
                Modified = date,
                VideoUrl = "https://www.youtube.com/watch?v=_pNUqyYjgm4&ab_channel=PRIMESHOWMMA"
            },
            new()
            {
                Id = 252,
                EventId = 27,
                TypeId = 47,
                OrderNumber = 2,
                Created = date,
                Modified = date,
                VideoUrl = "https://www.youtube.com/watch?v=_pNUqyYjgm4&ab_channel=PRIMESHOWMMA"
            },
            new()
            {
                Id = 253,
                EventId = 27,
                TypeId = 46,
                OrderNumber = 3,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 254,
                EventId = 27,
                TypeId = 46,
                OrderNumber = 4,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 255,
                EventId = 27,
                TypeId = 46,
                OrderNumber = 5,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 256,
                EventId = 27,
                TypeId = 46,
                OrderNumber = 6,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 257,
                EventId = 27,
                TypeId = 46,
                OrderNumber = 7,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 258,
                EventId = 27,
                TypeId = 46,
                OrderNumber = 8,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 259,
                EventId = 27,
                TypeId = 46,
                OrderNumber = 9,
                Created = date,
                Modified = date,
                VideoUrl = "https://www.youtube.com/watch?v=Rskxxuxwer0&ab_channel=PRIMESHOWMMA"
            },
            new()
            {
                Id = 260,
                EventId = 27,
                TypeId = 45,
                OrderNumber = 10,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 261,
                EventId = 27,
                TypeId = 44,
                OrderNumber = 11,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 262,
                EventId = 27,
                TypeId = 50,
                OrderNumber = 12,
                Created = date,
                Modified = date
            },

            // Prime 4: Królestwo - https://www.instagram.com/p/ClbamxvD8Sp/
            new()
            {
                Id = 263,
                EventId = 28,
                TypeId = 47,
                OrderNumber = 1,
                Created = date,
                Modified = date,
                VideoUrl = "https://www.youtube.com/watch?v=VfCxsq-hNvc&ab_channel=PRIMESHOWMMA"
            },
            new()
            {
                Id = 264,
                EventId = 28,
                TypeId = 46,
                OrderNumber = 2,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 265,
                EventId = 28,
                TypeId = 46,
                OrderNumber = 3,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 266,
                EventId = 28,
                TypeId = 46,
                OrderNumber = 4,
                Created = date,
                Modified = date,
                VideoUrl = "https://www.youtube.com/watch?v=1mK0MDEMgZI&ab_channel=PRIMESHOWMMA"
            },
            new()
            {
                Id = 267,
                EventId = 28,
                TypeId = 46,
                OrderNumber = 5,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 268,
                EventId = 28,
                TypeId = 46,
                OrderNumber = 6,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 269,
                EventId = 28,
                TypeId = 46,
                OrderNumber = 7,
                Created = date,
                Modified = date,
                VideoUrl = "https://www.youtube.com/watch?v=5j0rk87iMiA&ab_channel=PRIMESHOWMMA"
            },
            new()
            {
                Id = 270,
                EventId = 28,
                TypeId = 45,
                OrderNumber = 8,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 271,
                EventId = 28,
                TypeId = 45,
                OrderNumber = 9,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 272,
                EventId = 28,
                TypeId = 44,
                OrderNumber = 10,
                Created = date,
                Modified = date,
                VideoUrl = "https://www.youtube.com/watch?v=Yzm_WZThccM&ab_channel=PRIMESHOWMMA"
            },

            // Prime 5: Don Kasjo vs. Zadora - https://www.instagram.com/p/CuKQaAjtte5/
            new()
            {
                Id = 273,
                EventId = 29,
                TypeId = 47,
                OrderNumber = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 274,
                EventId = 29,
                TypeId = 47,
                OrderNumber = 2,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 275,
                EventId = 29,
                TypeId = 46,
                OrderNumber = 3,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 276,
                EventId = 29,
                TypeId = 46,
                OrderNumber = 4,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 277,
                EventId = 29,
                TypeId = 46,
                OrderNumber = 5,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 278,
                EventId = 29,
                TypeId = 46,
                OrderNumber = 6,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 279,
                EventId = 29,
                TypeId = 46,
                OrderNumber = 7,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 280,
                EventId = 29,
                TypeId = 45,
                OrderNumber = 8,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 281,
                EventId = 29,
                TypeId = 45,
                OrderNumber = 9,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 282,
                EventId = 29,
                TypeId = 48,
                OrderNumber = 10,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 283,
                EventId = 29,
                TypeId = 44,
                OrderNumber = 11,
                Created = date,
                Modified = date
            },

            // Prime 6: Premium - https://www.instagram.com/p/CyqpYTSNGVC/
            new()
            {
                Id = 284,
                EventId = 30,
                TypeId = 47,
                OrderNumber = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 285,
                EventId = 30,
                TypeId = 47,
                OrderNumber = 2,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 286,
                EventId = 30,
                TypeId = 46,
                OrderNumber = 3,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 287,
                EventId = 30,
                TypeId = 46,
                OrderNumber = 4,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 288,
                EventId = 30,
                TypeId = 46,
                OrderNumber = 5,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 289,
                EventId = 30,
                TypeId = 46,
                OrderNumber = 6,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 290,
                EventId = 30,
                TypeId = 46,
                OrderNumber = 7,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 291,
                EventId = 30,
                TypeId = 46,
                OrderNumber = 8,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 292,
                EventId = 30,
                TypeId = 46,
                OrderNumber = 9,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 293,
                EventId = 30,
                TypeId = 45,
                OrderNumber = 10,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 294,
                EventId = 30,
                TypeId = 44,
                OrderNumber = 11,
                Created = date,
                Modified = date
            },

            // High League 1: Lexy vs. Natsu - https://www.instagram.com/p/CR9RvVdCis6/
            new()
            {
                Id = 295,
                EventId = 31,
                TypeId = 46,
                OrderNumber = 1,
                Created = date,
                Modified = date,
                VideoUrl = "https://www.youtube.com/watch?v=e3I0465UtVY&ab_channel=HIGHLeague"
            },
            new()
            {
                Id = 296,
                EventId = 31,
                TypeId = 46,
                OrderNumber = 2,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 297,
                EventId = 31,
                TypeId = 46,
                OrderNumber = 3,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 298,
                EventId = 31,
                TypeId = 46,
                OrderNumber = 4,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 299,
                EventId = 31,
                TypeId = 46,
                OrderNumber = 5,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 300,
                EventId = 31,
                TypeId = 46,
                OrderNumber = 6,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 301,
                EventId = 31,
                TypeId = 45,
                OrderNumber = 7,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 302,
                EventId = 31,
                TypeId = 44,
                OrderNumber = 8,
                Created = date,
                Modified = date
            },

            // High League 2: pashaBiceps vs. Owca - https://www.instagram.com/p/CYjlDPsIraz/?img_index=2
            new()
            {
                Id = 303,
                EventId = 32,
                TypeId = 46,
                OrderNumber = 1,
                Created = date,
                Modified = date,
                VideoUrl = "https://www.youtube.com/watch?v=yHPKWN012Ec&ab_channel=HIGHLeague"
            },
            new()
            {
                Id = 304,
                EventId = 32,
                TypeId = 46,
                OrderNumber = 2,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 305,
                EventId = 32,
                TypeId = 46,
                OrderNumber = 3,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 306,
                EventId = 32,
                TypeId = 46,
                OrderNumber = 4,
                Created = date,
                Modified = date,
                VideoUrl = "https://www.youtube.com/watch?v=hk4g563BB4Y&ab_channel=HIGHLeague"
            },
            new()
            {
                Id = 307,
                EventId = 32,
                TypeId = 46,
                OrderNumber = 5,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 308,
                EventId = 32,
                TypeId = 46,
                OrderNumber = 6,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 309,
                EventId = 32,
                TypeId = 45,
                OrderNumber = 7,
                Created = date,
                Modified = date,
                VideoUrl = "https://www.youtube.com/watch?v=ZsEbWWItyKg&t=3s&ab_channel=HIGHLeague"
            },
            new()
            {
                Id = 310,
                EventId = 32,
                TypeId = 44,
                OrderNumber = 8,
                Created = date,
                Modified = date
            },

            // High League 3: Alberto vs. Dubiel - https://www.instagram.com/p/CdOLkqVKrr5/?img_index=2
            new()
            {
                Id = 311,
                EventId = 33,
                TypeId = 46,
                OrderNumber = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 312,
                EventId = 33,
                TypeId = 46,
                OrderNumber = 2,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 313,
                EventId = 33,
                TypeId = 46,
                OrderNumber = 3,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 314,
                EventId = 33,
                TypeId = 46,
                OrderNumber = 4,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 315,
                EventId = 33,
                TypeId = 46,
                OrderNumber = 5,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 316,
                EventId = 33,
                TypeId = 46,
                OrderNumber = 6,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 317,
                EventId = 33,
                TypeId = 45,
                OrderNumber = 7,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 318,
                EventId = 33,
                TypeId = 44,
                OrderNumber = 8,
                Created = date,
                Modified = date
            },

            // High League 3: Extra - https://www.instagram.com/p/CeoeEYmLEsi/
            new()
            {
                Id = 319,
                EventId = 34,
                TypeId = 50,
                OrderNumber = 1,
                Created = date,
                Modified = date,
                VideoUrl = "https://www.youtube.com/watch?v=LOBclPbWdWE&ab_channel=HIGHLeague"
            },

            // High League 4: Natsu vs. Lexy 2 - https://www.instagram.com/p/CindDXFL_wL/?img_index=2
            new()
            {
                Id = 320,
                EventId = 35,
                TypeId = 46,
                OrderNumber = 1,
                Created = date,
                Modified = date,
                VideoUrl = "https://www.youtube.com/watch?v=5owvuLcTfBA&ab_channel=HIGHLeague"
            },
            new()
            {
                Id = 321,
                EventId = 35,
                TypeId = 46,
                OrderNumber = 2,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 322,
                EventId = 35,
                TypeId = 46,
                OrderNumber = 3,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 323,
                EventId = 35,
                TypeId = 46,
                OrderNumber = 4,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 324,
                EventId = 35,
                TypeId = 46,
                OrderNumber = 5,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 325,
                EventId = 35,
                TypeId = 46,
                OrderNumber = 6,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 326,
                EventId = 35,
                TypeId = 46,
                OrderNumber = 7,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 327,
                EventId = 35,
                TypeId = 45,
                OrderNumber = 8,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 328,
                EventId = 35,
                TypeId = 44,
                OrderNumber = 9,
                Created = date,
                Modified = date
            },

            // High League 5: Alberto vs. Tybori - https://www.instagram.com/p/Cl_Yw6JoSL6/?img_index=2
            new()
            {
                Id = 329,
                EventId = 36,
                TypeId = 46,
                OrderNumber = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 330,
                EventId = 36,
                TypeId = 46,
                OrderNumber = 2,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 331,
                EventId = 36,
                TypeId = 46,
                OrderNumber = 3,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 332,
                EventId = 36,
                TypeId = 46,
                OrderNumber = 4,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 333,
                EventId = 36,
                TypeId = 46,
                OrderNumber = 5,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 334,
                EventId = 36,
                TypeId = 46,
                OrderNumber = 6,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 335,
                EventId = 36,
                TypeId = 46,
                OrderNumber = 7,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 336,
                EventId = 36,
                TypeId = 46,
                OrderNumber = 8,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 337,
                EventId = 36,
                TypeId = 45,
                OrderNumber = 9,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 338,
                EventId = 36,
                TypeId = 44,
                OrderNumber = 10,
                Created = date,
                Modified = date
            },

            // High League 6: pashaBiceps vs. Dubiel - https://www.instagram.com/p/Cp8NZqcrw09/?img_index=2
            new()
            {
                Id = 339,
                EventId = 37,
                TypeId = 46,
                OrderNumber = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 340,
                EventId = 37,
                TypeId = 46,
                OrderNumber = 2,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 341,
                EventId = 37,
                TypeId = 46,
                OrderNumber = 3,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 342,
                EventId = 37,
                TypeId = 46,
                OrderNumber = 4,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 343,
                EventId = 37,
                TypeId = 46,
                OrderNumber = 5,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 344,
                EventId = 37,
                TypeId = 46,
                OrderNumber = 6,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 345,
                EventId = 37,
                TypeId = 45,
                OrderNumber = 7,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 346,
                EventId = 37,
                TypeId = 45,
                OrderNumber = 8,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 347,
                EventId = 37,
                TypeId = 44,
                OrderNumber = 9,
                Created = date,
                Modified = date
            },

            // Clout MMA 1 - https://www.instagram.com/p/Cy8A3uuosZQ/
            new()
            {
                Id = 348,
                EventId = 38,
                TypeId = 47,
                OrderNumber = 1,
                Created = date,
                Modified = date,
                VideoUrl = "https://www.youtube.com/watch?v=YJxRsx_Ux6w&t=16s&ab_channel=CLOUTMMA"
            },
            new()
            {
                Id = 349,
                EventId = 38,
                TypeId = 47,
                OrderNumber = 2,
                Created = date,
                Modified = date,
                VideoUrl = "https://www.youtube.com/watch?v=YJxRsx_Ux6w&t=16s&ab_channel=CLOUTMMA"
            },
            new()
            {
                Id = 350,
                EventId = 38,
                TypeId = 46,
                OrderNumber = 3,
                Created = date,
                Modified = date,
                VideoUrl = "https://www.youtube.com/watch?v=YJxRsx_Ux6w&t=16s&ab_channel=CLOUTMMA"
            },
            new()
            {
                Id = 351,
                EventId = 38,
                TypeId = 46,
                OrderNumber = 4,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 352,
                EventId = 38,
                TypeId = 46,
                OrderNumber = 5,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 353,
                EventId = 38,
                TypeId = 46,
                OrderNumber = 6,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 354,
                EventId = 38,
                TypeId = 46,
                OrderNumber = 7,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 355,
                EventId = 38,
                TypeId = 46,
                OrderNumber = 8,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 356,
                EventId = 38,
                TypeId = 46,
                OrderNumber = 9,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 357,
                EventId = 38,
                TypeId = 46,
                OrderNumber = 10,
                Created = date,
                Modified = date,
                VideoUrl = "https://www.youtube.com/watch?v=DQHgW747pXc&ab_channel=CLOUTMMA"
            },
            new()
            {
                Id = 358,
                EventId = 38,
                TypeId = 45,
                OrderNumber = 11,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 359,
                EventId = 38,
                TypeId = 45,
                OrderNumber = 12,
                Created = date,
                Modified = date,
                VideoUrl = "https://www.youtube.com/watch?v=RRUV6oSsDHI&ab_channel=CLOUTMMA"
            },
            new()
            {
                Id = 360,
                EventId = 38,
                TypeId = 44,
                OrderNumber = 13,
                Created = date,
                Modified = date,
                VideoUrl = "https://www.youtube.com/watch?v=iw9Arq4ZlUY&ab_channel=CLOUTMMA"
            },

            // Clout MMA 2 - https://www.instagram.com/p/CvkZ6ttt-7h/?img_index=2
            new()
            {
                Id = 361,
                EventId = 39,
                TypeId = 47,
                OrderNumber = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 362,
                EventId = 39,
                TypeId = 47,
                OrderNumber = 2,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 363,
                EventId = 39,
                TypeId = 46,
                OrderNumber = 3,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 364,
                EventId = 39,
                TypeId = 46,
                OrderNumber = 4,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 365,
                EventId = 39,
                TypeId = 46,
                OrderNumber = 5,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 366,
                EventId = 39,
                TypeId = 46,
                OrderNumber = 6,
                Created = date,
                Modified = date,
                VideoUrl = "https://www.youtube.com/watch?v=RRUV6oSsDHI&ab_channel=CLOUTMMA"
            },
            new()
            {
                Id = 367,
                EventId = 39,
                TypeId = 46,
                OrderNumber = 7,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 368,
                EventId = 39,
                TypeId = 46,
                OrderNumber = 8,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 369,
                EventId = 39,
                TypeId = 45,
                OrderNumber = 9,
                Created = date,
                Modified = date,
                VideoUrl = "https://www.youtube.com/watch?v=iw9Arq4ZlUY&ab_channel=CLOUTMMA"
            },
            new()
            {
                Id = 370,
                EventId = 39,
                TypeId = 52,
                OrderNumber = 10,
                Created = date,
                Modified = date,
                VideoUrl = "https://www.youtube.com/watch?v=-U1uyqDABsM&ab_channel=CLOUTMMA"
            },
            new()
            {
                Id = 371,
                EventId = 39,
                TypeId = 44,
                OrderNumber = 11,
                Created = date,
                Modified = date,
                VideoUrl = "https://www.youtube.com/watch?v=0MzjJ_GDxp0&ab_channel=CLOUTMMA"
            },
            new()
            {
                Id = 372,
                EventId = 39,
                TypeId = 53,
                OrderNumber = 12,
                Created = date,
                Modified = date,
                VideoUrl = "https://www.youtube.com/watch?v=iw9Arq4ZlUY&ab_channel=CLOUTMMA"
            },

            // FFF 1: Najman vs. Trybson - https://www.facebook.com/FreeFightFederation/photos/a.2676453509093105/2751053878299734/
            new()
            {
                Id = 373,
                EventId = 40,
                TypeId = 46,
                OrderNumber = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 374,
                EventId = 40,
                TypeId = 46,
                OrderNumber = 2,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 375,
                EventId = 40,
                TypeId = 46,
                OrderNumber = 3,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 376,
                EventId = 40,
                TypeId = 46,
                OrderNumber = 4,
                Created = date,
                Modified = date,
                VideoUrl = "https://www.youtube.com/watch?v=xQLrp5ZiDSo&ab_channel=FFFMMA"
            },
            new()
            {
                Id = 377,
                EventId = 40,
                TypeId = 46,
                OrderNumber = 5,
                Created = date,
                Modified = date,
                VideoUrl = "https://www.youtube.com/watch?v=EoQ72EC9LM0&ab_channel=FFFMMA"
            },
            new()
            {
                Id = 378,
                EventId = 40,
                TypeId = 46,
                OrderNumber = 6,
                Created = date,
                Modified = date,
                VideoUrl = "https://www.youtube.com/watch?v=wyFs-zSJ9wI&ab_channel=FFFMMA"
            },
            new()
            {
                Id = 379,
                EventId = 40,
                TypeId = 46,
                OrderNumber = 7,
                Created = date,
                Modified = date,
                VideoUrl = "https://www.youtube.com/watch?v=Q5EXTMdk0e0&ab_channel=FFFMMA"
            },

            // FFF 2: Świerczewski vs. Greg Collins - https://www.facebook.com/FreeFightFederation/photos/a.2681512241920565/3322812084457241/
            new()
            {
                Id = 380,
                EventId = 41,
                TypeId = 46,
                OrderNumber = 1,
                Created = date,
                Modified = date,
                VideoUrl = "https://www.youtube.com/watch?v=H1hlBpSfPg4&ab_channel=FFFMMA"
            },
            new()
            {
                Id = 381,
                EventId = 41,
                TypeId = 46,
                OrderNumber = 2,
                Created = date,
                Modified = date,
                VideoUrl = "https://www.youtube.com/watch?v=nDefJRuaKGY&ab_channel=FFFMMA"
            },
            new()
            {
                Id = 382,
                EventId = 41,
                TypeId = 46,
                OrderNumber = 3,
                Created = date,
                Modified = date,
                VideoUrl = "https://www.youtube.com/watch?v=ig24s0EjRok&ab_channel=FFFMMA"
            },
            new()
            {
                Id = 383,
                EventId = 41,
                TypeId = 46,
                OrderNumber = 4,
                Created = date,
                Modified = date,
                VideoUrl = "https://www.youtube.com/watch?v=-aY1FOA-IxY&ab_channel=FFFMMA"
            },
            new()
            {
                Id = 384,
                EventId = 41,
                TypeId = 46,
                OrderNumber = 5,
                Created = date,
                Modified = date,
                VideoUrl = "https://www.youtube.com/watch?v=hWHAV4fDEZA&ab_channel=FFFMMA"
            },
            new()
            {
                Id = 385,
                EventId = 41,
                TypeId = 46,
                OrderNumber = 6,
                Created = date,
                Modified = date,
                VideoUrl = "https://www.youtube.com/watch?v=kt_LhKNo1Oc&ab_channel=FFFMMA"
            },
            new()
            {
                Id = 386,
                EventId = 41,
                TypeId = 46,
                OrderNumber = 7,
                Created = date,
                Modified = date,
                VideoUrl = "https://www.youtube.com/watch?v=_ib8XxaFYfU&ab_channel=FFFMMA"
            },

            // Bita Śmietanka 1 - https://twitter.com/XayooPodloga/status/1692625614841291201/photo/1
            new()
            {
                Id = 387,
                EventId = 42,
                TypeId = 46,
                OrderNumber = 1,
                Created = date,
                Modified = date,
                VideoUrl = "https://www.youtube.com/watch?v=Yc8ydVkWTIQ&ab_channel=Xayoo"
            },
            new()
            {
                Id = 388,
                EventId = 42,
                TypeId = 46,
                OrderNumber = 2,
                Created = date,
                Modified = date,
                VideoUrl = "https://www.youtube.com/watch?v=Yc8ydVkWTIQ&ab_channel=Xayoo"
            },
            new()
            {
                Id = 389,
                EventId = 42,
                TypeId = 46,
                OrderNumber = 3,
                Created = date,
                Modified = date,
                VideoUrl = "https://www.youtube.com/watch?v=Yc8ydVkWTIQ&ab_channel=Xayoo"
            },
            new()
            {
                Id = 390,
                EventId = 42,
                TypeId = 46,
                OrderNumber = 4,
                Created = date,
                Modified = date,
                VideoUrl = "https://www.youtube.com/watch?v=Yc8ydVkWTIQ&ab_channel=Xayoo"
            },
            new()
            {
                Id = 391,
                EventId = 42,
                TypeId = 46,
                OrderNumber = 5,
                Created = date,
                Modified = date,
                VideoUrl = "https://www.youtube.com/watch?v=Yc8ydVkWTIQ&ab_channel=Xayoo"
            },
            new()
            {
                Id = 392,
                EventId = 42,
                TypeId = 45,
                OrderNumber = 6,
                Created = date,
                Modified = date,
                VideoUrl = "https://www.youtube.com/watch?v=Yc8ydVkWTIQ&ab_channel=Xayoo"
            },
            new()
            {
                Id = 393,
                EventId = 42,
                TypeId = 44,
                OrderNumber = 7,
                Created = date,
                Modified = date,
                VideoUrl = "https://www.youtube.com/watch?v=Yc8ydVkWTIQ&ab_channel=Xayoo"
            },

            // Bita Śmietanka 2 - https://twitter.com/XayooPodloga/status/1734649695673205216/photo/1
            new()
            {
                Id = 394,
                EventId = 43,
                TypeId = 46,
                OrderNumber = 1,
                Created = date,
                Modified = date,
                VideoUrl = "https://www.youtube.com/watch?v=FNWa26YFLxg&t=5568s&ab_channel=Xayoo"
            },
            new()
            {
                Id = 395,
                EventId = 43,
                TypeId = 46,
                OrderNumber = 2,
                Created = date,
                Modified = date,
                VideoUrl = "https://www.youtube.com/watch?v=FNWa26YFLxg&t=5568s&ab_channel=Xayoo"
            },
            new()
            {
                Id = 396,
                EventId = 43,
                TypeId = 46,
                OrderNumber = 3,
                Created = date,
                Modified = date,
                VideoUrl = "https://www.youtube.com/watch?v=FNWa26YFLxg&t=5568s&ab_channel=Xayoo"
            },
            new()
            {
                Id = 397,
                EventId = 43,
                TypeId = 46,
                OrderNumber = 4,
                Created = date,
                Modified = date,
                VideoUrl = "https://www.youtube.com/watch?v=FNWa26YFLxg&t=5568s&ab_channel=Xayoo"
            },
            new()
            {
                Id = 398,
                EventId = 43,
                TypeId = 46,
                OrderNumber = 5,
                Created = date,
                Modified = date,
                VideoUrl = "https://www.youtube.com/watch?v=FNWa26YFLxg&t=5568s&ab_channel=Xayoo"
            },
            new()
            {
                Id = 399,
                EventId = 43,
                TypeId = 46,
                OrderNumber = 6,
                Created = date,
                Modified = date,
                VideoUrl = "https://www.youtube.com/watch?v=FNWa26YFLxg&t=5568s&ab_channel=Xayoo"
            },
            new()
            {
                Id = 400,
                EventId = 43,
                TypeId = 46,
                OrderNumber = 7,
                Created = date,
                Modified = date,
                VideoUrl = "https://www.youtube.com/watch?v=FNWa26YFLxg&t=5568s&ab_channel=Xayoo"
            },
            new()
            {
                Id = 401,
                EventId = 43,
                TypeId = 46,
                OrderNumber = 8,
                Created = date,
                Modified = date,
                VideoUrl = "https://www.youtube.com/watch?v=FNWa26YFLxg&t=5568s&ab_channel=Xayoo"
            },
            new()
            {
                Id = 402,
                EventId = 43,
                TypeId = 45,
                OrderNumber = 9,
                Created = date,
                Modified = date,
                VideoUrl = "https://www.youtube.com/watch?v=FNWa26YFLxg&t=5568s&ab_channel=Xayoo"
            },
            new()
            {
                Id = 403,
                EventId = 43,
                TypeId = 44,
                OrderNumber = 10,
                Created = date,
                Modified = date,
                VideoUrl = "https://www.youtube.com/watch?v=FNWa26YFLxg&t=5568s&ab_channel=Xayoo"
            },

            // Elite Fighters 1: Muran vs. Warszawski Dresik - https://www.instagram.com/p/CR_MVpcjmQ_/
            new()
            {
                Id = 404,
                EventId = 44,
                TypeId = 46,
                OrderNumber = 1,
                Created = date,
                Modified = date,
                VideoUrl = "https://www.youtube.com/watch?v=_cR0bUU8Vzk&ab_channel=EliteFighters"
            },
            new()
            {
                Id = 405,
                EventId = 44,
                TypeId = 46,
                OrderNumber = 2,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 406,
                EventId = 44,
                TypeId = 46,
                OrderNumber = 3,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 407,
                EventId = 44,
                TypeId = 46,
                OrderNumber = 4,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 408,
                EventId = 44,
                TypeId = 46,
                OrderNumber = 5,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 409,
                EventId = 44,
                TypeId = 46,
                OrderNumber = 6,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 410,
                EventId = 44,
                TypeId = 51,
                OrderNumber = 7,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 411,
                EventId = 44,
                TypeId = 45,
                OrderNumber = 8,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 412,
                EventId = 44,
                TypeId = 44,
                OrderNumber = 9,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 413,
                EventId = 44,
                TypeId = 48,
                OrderNumber = 10,
                Created = date,
                Modified = date
            },

            // MMA-VIP 1: Najman vs. Złotówa - https://www.instagram.com/p/CLB8INWhVAq/
            new()
            {
                Id = 414,
                EventId = 45,
                TypeId = 46,
                OrderNumber = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 415,
                EventId = 45,
                TypeId = 46,
                OrderNumber = 2,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 416,
                EventId = 45,
                TypeId = 46,
                OrderNumber = 3,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 417,
                EventId = 45,
                TypeId = 46,
                OrderNumber = 4,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 418,
                EventId = 45,
                TypeId = 46,
                OrderNumber = 5,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 419,
                EventId = 45,
                TypeId = 45,
                OrderNumber = 6,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 420,
                EventId = 45,
                TypeId = 44,
                OrderNumber = 7,
                Created = date,
                Modified = date
            },

            // MMA-VIP 2: Igrzyska Rozkminiaczy - https://www.instagram.com/p/CQMYRpSphHC/
            new()
            {
                Id = 421,
                EventId = 46,
                TypeId = 46,
                OrderNumber = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 422,
                EventId = 46,
                TypeId = 46,
                OrderNumber = 2,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 423,
                EventId = 46,
                TypeId = 46,
                OrderNumber = 3,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 424,
                EventId = 46,
                TypeId = 46,
                OrderNumber = 4,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 425,
                EventId = 46,
                TypeId = 46,
                OrderNumber = 5,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 426,
                EventId = 46,
                TypeId = 46,
                OrderNumber = 6,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 427,
                EventId = 46,
                TypeId = 46,
                OrderNumber = 7,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 428,
                EventId = 46,
                TypeId = 45,
                OrderNumber = 8,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 429,
                EventId = 46,
                TypeId = 44,
                OrderNumber = 9,
                Created = date,
                Modified = date
            },

            // MMA-VIP 3: Galaktyka Osobliwości - https://www.instagram.com/p/CVnkKrQoCaA/
            new()
            {
                Id = 430,
                EventId = 47,
                TypeId = 46,
                OrderNumber = 1,
                Created = date,
                Modified = date,
                VideoUrl = "https://www.youtube.com/watch?v=ewU-o-lHmA0&ab_channel=MMA-VIPOfficial"
            },
            new()
            {
                Id = 431,
                EventId = 47,
                TypeId = 46,
                OrderNumber = 2,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 432,
                EventId = 47,
                TypeId = 46,
                OrderNumber = 3,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 433,
                EventId = 47,
                TypeId = 46,
                OrderNumber = 4,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 434,
                EventId = 47,
                TypeId = 46,
                OrderNumber = 5,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 435,
                EventId = 47,
                TypeId = 46,
                OrderNumber = 6,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 436,
                EventId = 47,
                TypeId = 45,
                OrderNumber = 7,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 437,
                EventId = 47,
                TypeId = 44,
                OrderNumber = 8,
                Created = date,
                Modified = date,
                VideoUrl = "https://www.youtube.com/watch?v=qeKRvVEG7T0&ab_channel=MMA-VIPOfficial"
            },

            // MMA-VIP 4: Imperium Potępionych - https://www.instagram.com/p/Cauz4R9oZbZ/
            new()
            {
                Id = 438,
                EventId = 48,
                TypeId = 46,
                OrderNumber = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 439,
                EventId = 48,
                TypeId = 46,
                OrderNumber = 2,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 440,
                EventId = 48,
                TypeId = 46,
                OrderNumber = 3,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 441,
                EventId = 48,
                TypeId = 46,
                OrderNumber = 4,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 442,
                EventId = 48,
                TypeId = 46,
                OrderNumber = 5,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 443,
                EventId = 48,
                TypeId = 46,
                OrderNumber = 6,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 444,
                EventId = 48,
                TypeId = 45,
                OrderNumber = 7,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 445,
                EventId = 48,
                TypeId = 44,
                OrderNumber = 8,
                Created = date,
                Modified = date,
                VideoUrl = "https://www.youtube.com/watch?v=EsFEai1nc-w&ab_channel=MMA-VIPOfficial"
            }
        });

        modelBuilder.Entity<Team>().HasData(new List<Team>
        {
            // Fame 1: Boxdel vs. Guzik
            new()
            {
                Id = 1,
                FightId = 1,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 2,
                FightId = 1,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 3,
                FightId = 2,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 4,
                FightId = 2,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 5,
                FightId = 3,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 6,
                FightId = 3,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 7,
                FightId = 4,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 8,
                FightId = 4,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 9,
                FightId = 5,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 10,
                FightId = 5,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 11,
                FightId = 6,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 12,
                FightId = 6,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 13,
                FightId = 7,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 14,
                FightId = 7,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 15,
                FightId = 8,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 16,
                FightId = 8,
                Number = 1,
                Created = date,
                Modified = date
            },

            // Fame 2: Rafonix vs. Magical
            new()
            {
                Id = 17,
                FightId = 9,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 18,
                FightId = 9,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 19,
                FightId = 10,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 20,
                FightId = 10,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 21,
                FightId = 11,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 22,
                FightId = 11,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 23,
                FightId = 12,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 24,
                FightId = 12,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 25,
                FightId = 13,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 26,
                FightId = 13,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 27,
                FightId = 14,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 28,
                FightId = 14,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 29,
                FightId = 15,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 30,
                FightId = 15,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 31,
                FightId = 16,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 32,
                FightId = 16,
                Number = 1,
                Created = date,
                Modified = date
            },

            // Fame 3: IsAmU vs. DeeJayPallaside
            new()
            {
                Id = 33,
                FightId = 17,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 34,
                FightId = 17,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 35,
                FightId = 18,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 36,
                FightId = 18,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 37,
                FightId = 19,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 38,
                FightId = 19,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 39,
                FightId = 20,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 40,
                FightId = 20,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 41,
                FightId = 21,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 42,
                FightId = 21,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 43,
                FightId = 22,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 44,
                FightId = 22,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 45,
                FightId = 23,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 46,
                FightId = 23,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 47,
                FightId = 24,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 48,
                FightId = 24,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 49,
                FightId = 25,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 50,
                FightId = 25,
                Number = 1,
                Created = date,
                Modified = date
            },

            // Fame 4: Linkimaster vs. Lil Masti
            new()
            {
                Id = 51,
                FightId = 26,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 52,
                FightId = 26,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 53,
                FightId = 27,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 54,
                FightId = 27,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 55,
                FightId = 28,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 56,
                FightId = 28,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 57,
                FightId = 29,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 58,
                FightId = 29,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 59,
                FightId = 30,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 60,
                FightId = 30,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 61,
                FightId = 31,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 62,
                FightId = 31,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 63,
                FightId = 32,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 64,
                FightId = 32,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 65,
                FightId = 33,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 66,
                FightId = 33,
                Number = 1,
                Created = date,
                Modified = date
            },

            // Fame 5: Bonus BGC vs. Najman
            new()
            {
                Id = 67,
                FightId = 34,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 68,
                FightId = 34,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 69,
                FightId = 35,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 70,
                FightId = 35,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 71,
                FightId = 36,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 72,
                FightId = 36,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 73,
                FightId = 37,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 74,
                FightId = 37,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 75,
                FightId = 38,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 76,
                FightId = 38,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 77,
                FightId = 39,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 78,
                FightId = 39,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 79,
                FightId = 40,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 80,
                FightId = 40,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 81,
                FightId = 41,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 82,
                FightId = 41,
                Number = 1,
                Created = date,
                Modified = date
            },

            // Fame 6: Zusje vs. Linkimaster
            new()
            {
                Id = 83,
                FightId = 42,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 84,
                FightId = 42,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 85,
                FightId = 43,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 86,
                FightId = 43,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 87,
                FightId = 44,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 88,
                FightId = 44,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 89,
                FightId = 45,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 90,
                FightId = 45,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 91,
                FightId = 46,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 92,
                FightId = 46,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 93,
                FightId = 47,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 94,
                FightId = 47,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 95,
                FightId = 48,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 96,
                FightId = 48,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 97,
                FightId = 49,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 98,
                FightId = 49,
                Number = 1,
                Created = date,
                Modified = date
            },

            // Fame 7: Popek vs. Stifler
            new()
            {
                Id = 99,
                FightId = 50,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 100,
                FightId = 50,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 101,
                FightId = 51,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 102,
                FightId = 51,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 103,
                FightId = 52,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 104,
                FightId = 52,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 105,
                FightId = 53,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 106,
                FightId = 53,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 107,
                FightId = 54,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 108,
                FightId = 54,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 109,
                FightId = 55,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 110,
                FightId = 55,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 111,
                FightId = 56,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 112,
                FightId = 56,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 113,
                FightId = 57,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 114,
                FightId = 57,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 115,
                FightId = 58,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 116,
                FightId = 58,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 117,
                FightId = 59,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 118,
                FightId = 59,
                Number = 1,
                Created = date,
                Modified = date
            },

            // Fame 8: Dubiel vs. Blonsky
            new()
            {
                Id = 119,
                FightId = 60,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 120,
                FightId = 60,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 121,
                FightId = 61,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 122,
                FightId = 61,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 123,
                FightId = 62,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 124,
                FightId = 62,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 125,
                FightId = 63,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 126,
                FightId = 63,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 127,
                FightId = 64,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 128,
                FightId = 64,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 129,
                FightId = 65,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 130,
                FightId = 65,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 131,
                FightId = 66,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 132,
                FightId = 66,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 133,
                FightId = 67,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 134,
                FightId = 67,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 135,
                FightId = 68,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 136,
                FightId = 68,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 137,
                FightId = 69,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 138,
                FightId = 69,
                Number = 1,
                Created = date,
                Modified = date
            },

            // Fame 9: Let’s Play
            new()
            {
                Id = 139,
                FightId = 70,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 140,
                FightId = 70,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 141,
                FightId = 71,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 142,
                FightId = 71,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 143,
                FightId = 72,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 144,
                FightId = 72,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 145,
                FightId = 73,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 146,
                FightId = 73,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 147,
                FightId = 74,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 148,
                FightId = 74,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 149,
                FightId = 75,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 150,
                FightId = 75,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 151,
                FightId = 76,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 152,
                FightId = 76,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 153,
                FightId = 77,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 154,
                FightId = 77,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 155,
                FightId = 78,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 156,
                FightId = 78,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 157,
                FightId = 79,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 158,
                FightId = 79,
                Number = 1,
                Created = date,
                Modified = date
            },

            // Fame 10: Don Kasjo vs. Parke
            new()
            {
                Id = 159,
                FightId = 80,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 160,
                FightId = 80,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 161,
                FightId = 81,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 162,
                FightId = 81,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 163,
                FightId = 82,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 164,
                FightId = 82,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 165,
                FightId = 83,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 166,
                FightId = 83,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 167,
                FightId = 84,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 168,
                FightId = 84,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 169,
                FightId = 85,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 170,
                FightId = 85,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 171,
                FightId = 86,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 172,
                FightId = 86,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 173,
                FightId = 87,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 174,
                FightId = 87,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 175,
                FightId = 88,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 176,
                FightId = 88,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 177,
                FightId = 89,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 178,
                FightId = 89,
                Number = 1,
                Created = date,
                Modified = date
            },

            // Fame 11: Fight Club
            new()
            {
                Id = 179,
                FightId = 90,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 180,
                FightId = 90,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 181,
                FightId = 91,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 182,
                FightId = 91,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 183,
                FightId = 92,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 184,
                FightId = 92,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 185,
                FightId = 93,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 186,
                FightId = 93,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 187,
                FightId = 94,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 188,
                FightId = 94,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 189,
                FightId = 95,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 190,
                FightId = 95,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 191,
                FightId = 96,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 192,
                FightId = 96,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 193,
                FightId = 97,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 194,
                FightId = 97,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 195,
                FightId = 98,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 196,
                FightId = 98,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 197,
                FightId = 99,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 198,
                FightId = 99,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 199,
                FightId = 100,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 200,
                FightId = 100,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 201,
                FightId = 101,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 202,
                FightId = 101,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 203,
                FightId = 102,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 204,
                FightId = 102,
                Number = 1,
                Created = date,
                Modified = date
            },

            // Fame 12: Don Kasjo vs. Polish Zombie
            new()
            {
                Id = 205,
                FightId = 103,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 206,
                FightId = 103,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 207,
                FightId = 104,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 208,
                FightId = 104,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 209,
                FightId = 105,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 210,
                FightId = 105,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 211,
                FightId = 106,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 212,
                FightId = 106,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 213,
                FightId = 107,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 214,
                FightId = 107,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 215,
                FightId = 108,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 216,
                FightId = 108,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 217,
                FightId = 109,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 218,
                FightId = 109,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 219,
                FightId = 110,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 220,
                FightId = 110,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 221,
                FightId = 111,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 222,
                FightId = 111,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 223,
                FightId = 112,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 224,
                FightId = 112,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 225,
                FightId = 113,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 226,
                FightId = 113,
                Number = 1,
                Created = date,
                Modified = date
            },

            // Fame 13: Nitro vs. Unboxall
            new()
            {
                Id = 227,
                FightId = 114,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 228,
                FightId = 114,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 229,
                FightId = 115,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 230,
                FightId = 115,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 231,
                FightId = 116,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 232,
                FightId = 116,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 233,
                FightId = 117,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 234,
                FightId = 117,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 235,
                FightId = 118,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 236,
                FightId = 118,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 237,
                FightId = 119,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 238,
                FightId = 119,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 239,
                FightId = 120,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 240,
                FightId = 120,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 241,
                FightId = 121,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 242,
                FightId = 121,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 243,
                FightId = 122,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 244,
                FightId = 122,
                Number = 1,
                Created = date,
                Modified = date
            },

            // Fame 14: Gimper vs. Tromba
            new()
            {
                Id = 245,
                FightId = 123,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 246,
                FightId = 123,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 247,
                FightId = 124,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 248,
                FightId = 124,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 249,
                FightId = 125,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 250,
                FightId = 125,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 251,
                FightId = 126,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 252,
                FightId = 126,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 253,
                FightId = 127,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 254,
                FightId = 127,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 255,
                FightId = 128,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 256,
                FightId = 128,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 257,
                FightId = 129,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 258,
                FightId = 129,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 259,
                FightId = 130,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 260,
                FightId = 130,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 261,
                FightId = 131,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 262,
                FightId = 131,
                Number = 1,
                Created = date,
                Modified = date
            },

            // Fame 15: Zemsta
            new()
            {
                Id = 263,
                FightId = 132,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 264,
                FightId = 132,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 265,
                FightId = 133,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 266,
                FightId = 133,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 267,
                FightId = 134,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 268,
                FightId = 134,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 269,
                FightId = 135,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 270,
                FightId = 135,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 271,
                FightId = 136,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 272,
                FightId = 136,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 273,
                FightId = 137,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 274,
                FightId = 137,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 275,
                FightId = 138,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 276,
                FightId = 138,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 277,
                FightId = 139,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 278,
                FightId = 139,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 279,
                FightId = 140,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 280,
                FightId = 140,
                Number = 1,
                Created = date,
                Modified = date
            },

            // Fame 16: Tromba vs. Dubiel
            new()
            {
                Id = 281,
                FightId = 141,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 282,
                FightId = 141,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 283,
                FightId = 142,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 284,
                FightId = 142,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 285,
                FightId = 143,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 286,
                FightId = 143,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 287,
                FightId = 144,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 288,
                FightId = 144,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 289,
                FightId = 145,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 290,
                FightId = 145,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 291,
                FightId = 146,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 292,
                FightId = 146,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 293,
                FightId = 147,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 294,
                FightId = 147,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 295,
                FightId = 148,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 296,
                FightId = 148,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 297,
                FightId = 149,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 298,
                FightId = 149,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 299,
                FightId = 150,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 300,
                FightId = 150,
                Number = 1,
                Created = date,
                Modified = date
            },

            // Fame 17: Ferrari vs. Łaszczyk
            new()
            {
                Id = 301,
                FightId = 151,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 302,
                FightId = 151,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 303,
                FightId = 152,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 304,
                FightId = 152,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 305,
                FightId = 153,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 306,
                FightId = 153,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 307,
                FightId = 154,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 308,
                FightId = 154,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 309,
                FightId = 155,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 310,
                FightId = 155,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 311,
                FightId = 156,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 312,
                FightId = 156,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 313,
                FightId = 157,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 314,
                FightId = 157,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 315,
                FightId = 158,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 316,
                FightId = 158,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 317,
                FightId = 159,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 318,
                FightId = 159,
                Number = 1,
                Created = date,
                Modified = date
            },

            // Fame 18: Crusher vs. Ferrari
            new()
            {
                Id = 319,
                FightId = 160,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 320,
                FightId = 160,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 321,
                FightId = 161,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 322,
                FightId = 161,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 323,
                FightId = 162,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 324,
                FightId = 162,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 325,
                FightId = 163,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 326,
                FightId = 163,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 327,
                FightId = 164,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 328,
                FightId = 164,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 329,
                FightId = 165,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 330,
                FightId = 165,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 331,
                FightId = 166,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 332,
                FightId = 166,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 333,
                FightId = 167,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 334,
                FightId = 167,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 335,
                FightId = 168,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 336,
                FightId = 168,
                Number = 1,
                Created = date,
                Modified = date
            },

            // Fame 19: Tańcula vs. Ferrari
            new()
            {
                Id = 337,
                FightId = 169,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 338,
                FightId = 169,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 339,
                FightId = 170,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 340,
                FightId = 170,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 341,
                FightId = 171,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 342,
                FightId = 171,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 343,
                FightId = 172,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 344,
                FightId = 172,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 345,
                FightId = 173,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 346,
                FightId = 173,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 347,
                FightId = 174,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 348,
                FightId = 174,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 349,
                FightId = 175,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 350,
                FightId = 175,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 351,
                FightId = 176,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 352,
                FightId = 176,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 353,
                FightId = 177,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 354,
                FightId = 177,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 355,
                FightId = 178,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 356,
                FightId = 178,
                Number = 1,
                Created = date,
                Modified = date
            },

            // Fame UK 1: Gowland vs. McKenna
            new()
            {
                Id = 357,
                FightId = 179,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 358,
                FightId = 179,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 359,
                FightId = 180,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 360,
                FightId = 180,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 361,
                FightId = 181,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 362,
                FightId = 181,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 363,
                FightId = 182,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 364,
                FightId = 182,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 365,
                FightId = 183,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 366,
                FightId = 183,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 367,
                FightId = 184,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 368,
                FightId = 184,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 369,
                FightId = 185,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 370,
                FightId = 185,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 371,
                FightId = 186,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 372,
                FightId = 186,
                Number = 1,
                Created = date,
                Modified = date
            },

            // Hype S01E01: Rafonix vs. Hejter
            new()
            {
                Id = 373,
                FightId = 187,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 374,
                FightId = 187,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 375,
                FightId = 188,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 376,
                FightId = 188,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 377,
                FightId = 189,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 378,
                FightId = 189,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 379,
                FightId = 190,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 380,
                FightId = 190,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 381,
                FightId = 191,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 382,
                FightId = 191,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 383,
                FightId = 192,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 384,
                FightId = 192,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 385,
                FightId = 193,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 386,
                FightId = 193,
                Number = 1,
                Created = date,
                Modified = date
            },

            // Fame Friday Arena 1: Alberto vs. Kubańczyk
            new()
            {
                Id = 387,
                FightId = 194,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 388,
                FightId = 194,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 389,
                FightId = 195,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 390,
                FightId = 195,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 391,
                FightId = 196,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 392,
                FightId = 196,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 393,
                FightId = 197,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 394,
                FightId = 197,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 395,
                FightId = 198,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 396,
                FightId = 198,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 397,
                FightId = 199,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 398,
                FightId = 199,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 399,
                FightId = 200,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 400,
                FightId = 200,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 401,
                FightId = 201,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 402,
                FightId = 201,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 403,
                FightId = 202,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 404,
                FightId = 202,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 405,
                FightId = 203,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 406,
                FightId = 203,
                Number = 1,
                Created = date,
                Modified = date
            },

            // Fame Friday Arena 2: Prezes FEN vs. Boxdel 2
            new()
            {
                Id = 407,
                FightId = 204,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 408,
                FightId = 204,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 409,
                FightId = 205,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 410,
                FightId = 205,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 411,
                FightId = 206,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 412,
                FightId = 206,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 413,
                FightId = 207,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 414,
                FightId = 207,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 415,
                FightId = 208,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 416,
                FightId = 208,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 417,
                FightId = 209,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 418,
                FightId = 209,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 419,
                FightId = 210,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 420,
                FightId = 210,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 421,
                FightId = 211,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 422,
                FightId = 211,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 423,
                FightId = 212,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 424,
                FightId = 212,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 425,
                FightId = 213,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 426,
                FightId = 213,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 427,
                FightId = 214,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 428,
                FightId = 214,
                Number = 1,
                Created = date,
                Modified = date
            },

            // Fame: Reborn
            new()
            {
                Id = 429,
                FightId = 215,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 430,
                FightId = 215,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 431,
                FightId = 216,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 432,
                FightId = 216,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 433,
                FightId = 217,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 434,
                FightId = 217,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 435,
                FightId = 218,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 436,
                FightId = 218,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 437,
                FightId = 219,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 438,
                FightId = 219,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 439,
                FightId = 220,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 440,
                FightId = 220,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 441,
                FightId = 221,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 442,
                FightId = 221,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 443,
                FightId = 222,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 444,
                FightId = 222,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 445,
                FightId = 223,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 446,
                FightId = 223,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 447,
                FightId = 224,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 448,
                FightId = 224,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 449,
                FightId = 225,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 450,
                FightId = 225,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 451,
                FightId = 226,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 452,
                FightId = 226,
                Number = 1,
                Created = date,
                Modified = date
            },

            // Prime 1: Zadyma
            new()
            {
                Id = 453,
                FightId = 227,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 454,
                FightId = 227,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 455,
                FightId = 228,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 456,
                FightId = 228,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 457,
                FightId = 229,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 458,
                FightId = 229,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 459,
                FightId = 230,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 460,
                FightId = 230,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 461,
                FightId = 231,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 462,
                FightId = 231,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 463,
                FightId = 232,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 464,
                FightId = 232,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 465,
                FightId = 233,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 466,
                FightId = 233,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 467,
                FightId = 234,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 468,
                FightId = 234,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 469,
                FightId = 235,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 470,
                FightId = 235,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 471,
                FightId = 236,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 472,
                FightId = 236,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 473,
                FightId = 237,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 474,
                FightId = 237,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 475,
                FightId = 238,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 476,
                FightId = 238,
                Number = 1,
                Created = date,
                Modified = date
            },

            // Prime 2: Kosmos
            new()
            {
                Id = 477,
                FightId = 239,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 478,
                FightId = 239,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 479,
                FightId = 240,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 480,
                FightId = 240,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 481,
                FightId = 241,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 482,
                FightId = 241,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 483,
                FightId = 242,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 484,
                FightId = 242,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 485,
                FightId = 243,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 486,
                FightId = 243,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 487,
                FightId = 244,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 488,
                FightId = 244,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 489,
                FightId = 245,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 490,
                FightId = 245,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 491,
                FightId = 246,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 492,
                FightId = 246,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 493,
                FightId = 247,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 494,
                FightId = 247,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 495,
                FightId = 248,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 496,
                FightId = 248,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 497,
                FightId = 249,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 498,
                FightId = 249,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 499,
                FightId = 250,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 500,
                FightId = 250,
                Number = 1,
                Created = date,
                Modified = date
            },

            // Prime 3: Street Fighter
            new()
            {
                Id = 501,
                FightId = 251,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 502,
                FightId = 251,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 503,
                FightId = 252,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 504,
                FightId = 252,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 505,
                FightId = 253,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 506,
                FightId = 253,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 507,
                FightId = 254,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 508,
                FightId = 254,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 509,
                FightId = 255,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 510,
                FightId = 255,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 511,
                FightId = 256,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 512,
                FightId = 256,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 513,
                FightId = 257,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 514,
                FightId = 257,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 515,
                FightId = 258,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 516,
                FightId = 258,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 517,
                FightId = 259,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 518,
                FightId = 259,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 519,
                FightId = 260,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 520,
                FightId = 260,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 521,
                FightId = 261,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 522,
                FightId = 261,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 523,
                FightId = 262,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 524,
                FightId = 262,
                Number = 1,
                Created = date,
                Modified = date
            },

            // Prime 4: Królestwo
            new()
            {
                Id = 525,
                FightId = 263,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 526,
                FightId = 263,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 527,
                FightId = 264,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 528,
                FightId = 264,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 529,
                FightId = 265,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 530,
                FightId = 265,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 531,
                FightId = 266,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 532,
                FightId = 266,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 533,
                FightId = 267,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 534,
                FightId = 267,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 535,
                FightId = 268,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 536,
                FightId = 268,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 537,
                FightId = 269,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 538,
                FightId = 269,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 539,
                FightId = 270,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 540,
                FightId = 270,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 541,
                FightId = 271,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 542,
                FightId = 271,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 543,
                FightId = 272,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 544,
                FightId = 272,
                Number = 1,
                Created = date,
                Modified = date
            },

            // Prime 5: Don Kasjo vs. Zadora
            new()
            {
                Id = 545,
                FightId = 273,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 546,
                FightId = 273,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 547,
                FightId = 274,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 548,
                FightId = 274,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 549,
                FightId = 275,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 550,
                FightId = 275,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 551,
                FightId = 276,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 552,
                FightId = 276,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 553,
                FightId = 277,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 554,
                FightId = 277,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 555,
                FightId = 278,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 556,
                FightId = 278,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 557,
                FightId = 279,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 558,
                FightId = 279,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 559,
                FightId = 280,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 560,
                FightId = 280,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 561,
                FightId = 281,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 562,
                FightId = 281,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 563,
                FightId = 282,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 564,
                FightId = 282,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 565,
                FightId = 283,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 566,
                FightId = 283,
                Number = 1,
                Created = date,
                Modified = date
            },

            // Prime 6: Premium
            new()
            {
                Id = 567,
                FightId = 284,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 568,
                FightId = 284,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 569,
                FightId = 285,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 570,
                FightId = 285,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 571,
                FightId = 286,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 572,
                FightId = 286,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 573,
                FightId = 287,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 574,
                FightId = 287,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 575,
                FightId = 288,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 576,
                FightId = 288,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 577,
                FightId = 289,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 578,
                FightId = 289,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 579,
                FightId = 290,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 580,
                FightId = 290,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 581,
                FightId = 291,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 582,
                FightId = 291,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 583,
                FightId = 292,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 584,
                FightId = 292,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 585,
                FightId = 293,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 586,
                FightId = 293,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 587,
                FightId = 294,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 588,
                FightId = 294,
                Number = 1,
                Created = date,
                Modified = date
            },

            // High League 1: Lexy vs. Natsu
            new()
            {
                Id = 589,
                FightId = 295,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 590,
                FightId = 295,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 591,
                FightId = 296,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 592,
                FightId = 296,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 593,
                FightId = 297,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 594,
                FightId = 297,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 595,
                FightId = 297,
                Number = 2,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 596,
                FightId = 298,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 597,
                FightId = 298,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 598,
                FightId = 299,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 599,
                FightId = 299,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 600,
                FightId = 300,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 601,
                FightId = 300,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 602,
                FightId = 301,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 603,
                FightId = 301,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 604,
                FightId = 302,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 605,
                FightId = 302,
                Number = 1,
                Created = date,
                Modified = date
            },

            // High League 2: pashaBiceps vs. Owca
            new()
            {
                Id = 606,
                FightId = 303,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 607,
                FightId = 303,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 608,
                FightId = 304,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 609,
                FightId = 304,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 610,
                FightId = 305,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 611,
                FightId = 305,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 612,
                FightId = 306,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 613,
                FightId = 306,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 614,
                FightId = 307,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 615,
                FightId = 307,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 616,
                FightId = 308,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 617,
                FightId = 308,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 618,
                FightId = 309,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 619,
                FightId = 309,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 620,
                FightId = 310,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 621,
                FightId = 310,
                Number = 1,
                Created = date,
                Modified = date
            },

            // High League 3: Alberto vs. Dubiel
            new()
            {
                Id = 622,
                FightId = 311,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 623,
                FightId = 311,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 624,
                FightId = 312,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 625,
                FightId = 312,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 626,
                FightId = 313,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 627,
                FightId = 313,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 628,
                FightId = 314,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 629,
                FightId = 314,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 630,
                FightId = 315,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 631,
                FightId = 315,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 632,
                FightId = 316,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 633,
                FightId = 316,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 634,
                FightId = 317,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 635,
                FightId = 317,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 636,
                FightId = 318,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 637,
                FightId = 318,
                Number = 1,
                Created = date,
                Modified = date
            },

            // High League 3: Extra
            new()
            {
                Id = 638,
                FightId = 319,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 639,
                FightId = 319,
                Number = 1,
                Created = date,
                Modified = date
            },

            // High League 4: Natsu vs. Lexy 2
            new()
            {
                Id = 640,
                FightId = 320,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 641,
                FightId = 320,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 642,
                FightId = 321,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 643,
                FightId = 321,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 644,
                FightId = 322,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 645,
                FightId = 322,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 646,
                FightId = 323,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 647,
                FightId = 323,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 648,
                FightId = 324,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 649,
                FightId = 324,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 650,
                FightId = 325,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 651,
                FightId = 325,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 652,
                FightId = 326,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 653,
                FightId = 326,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 654,
                FightId = 327,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 655,
                FightId = 327,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 656,
                FightId = 328,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 657,
                FightId = 328,
                Number = 1,
                Created = date,
                Modified = date
            },

            // High League 5: Alberto vs. Tybori
            new()
            {
                Id = 658,
                FightId = 329,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 659,
                FightId = 329,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 660,
                FightId = 330,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 661,
                FightId = 330,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 662,
                FightId = 331,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 663,
                FightId = 331,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 664,
                FightId = 332,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 665,
                FightId = 332,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 666,
                FightId = 333,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 667,
                FightId = 333,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 668,
                FightId = 334,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 669,
                FightId = 334,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 670,
                FightId = 335,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 671,
                FightId = 335,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 672,
                FightId = 336,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 673,
                FightId = 336,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 674,
                FightId = 337,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 675,
                FightId = 337,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 676,
                FightId = 338,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 677,
                FightId = 338,
                Number = 1,
                Created = date,
                Modified = date
            },

            // High League 6: pashaBiceps vs. Dubiel
            new()
            {
                Id = 678,
                FightId = 339,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 679,
                FightId = 339,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 680,
                FightId = 340,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 681,
                FightId = 340,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 682,
                FightId = 341,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 683,
                FightId = 341,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 684,
                FightId = 342,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 685,
                FightId = 342,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 686,
                FightId = 343,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 687,
                FightId = 343,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 688,
                FightId = 344,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 689,
                FightId = 344,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 690,
                FightId = 345,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 691,
                FightId = 345,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 692,
                FightId = 346,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 693,
                FightId = 346,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 694,
                FightId = 347,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 695,
                FightId = 347,
                Number = 1,
                Created = date,
                Modified = date
            },

            // Clout MMA 1
            new()
            {
                Id = 696,
                FightId = 348,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 697,
                FightId = 348,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 698,
                FightId = 349,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 699,
                FightId = 349,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 700,
                FightId = 350,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 701,
                FightId = 350,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 702,
                FightId = 351,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 703,
                FightId = 351,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 704,
                FightId = 352,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 705,
                FightId = 352,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 706,
                FightId = 353,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 707,
                FightId = 353,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 708,
                FightId = 354,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 709,
                FightId = 354,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 710,
                FightId = 355,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 711,
                FightId = 355,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 712,
                FightId = 356,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 713,
                FightId = 356,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 714,
                FightId = 357,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 715,
                FightId = 357,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 716,
                FightId = 358,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 717,
                FightId = 358,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 718,
                FightId = 359,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 719,
                FightId = 359,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 720,
                FightId = 360,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 721,
                FightId = 360,
                Number = 1,
                Created = date,
                Modified = date
            },

            // Clout MMA 2
            new()
            {
                Id = 722,
                FightId = 361,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 723,
                FightId = 361,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 724,
                FightId = 362,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 725,
                FightId = 362,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 726,
                FightId = 363,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 727,
                FightId = 363,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 728,
                FightId = 364,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 729,
                FightId = 364,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 730,
                FightId = 365,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 731,
                FightId = 365,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 732,
                FightId = 366,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 733,
                FightId = 366,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 734,
                FightId = 367,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 735,
                FightId = 367,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 736,
                FightId = 368,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 737,
                FightId = 368,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 738,
                FightId = 369,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 739,
                FightId = 369,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 740,
                FightId = 370,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 741,
                FightId = 370,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 742,
                FightId = 371,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 743,
                FightId = 371,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 744,
                FightId = 372,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 745,
                FightId = 372,
                Number = 1,
                Created = date,
                Modified = date
            },

            // FFF 1: Najman vs. Trybson
            new()
            {
                Id = 746,
                FightId = 373,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 747,
                FightId = 373,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 748,
                FightId = 374,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 749,
                FightId = 374,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 750,
                FightId = 375,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 751,
                FightId = 375,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 752,
                FightId = 376,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 753,
                FightId = 376,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 754,
                FightId = 377,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 755,
                FightId = 377,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 756,
                FightId = 378,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 757,
                FightId = 378,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 758,
                FightId = 379,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 759,
                FightId = 379,
                Number = 1,
                Created = date,
                Modified = date
            },

            // FFF 2: Świerczewski vs. Greg Collins
            new()
            {
                Id = 760,
                FightId = 380,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 761,
                FightId = 380,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 762,
                FightId = 381,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 763,
                FightId = 381,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 764,
                FightId = 382,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 765,
                FightId = 382,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 766,
                FightId = 383,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 767,
                FightId = 383,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 768,
                FightId = 384,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 769,
                FightId = 384,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 770,
                FightId = 385,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 771,
                FightId = 385,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 772,
                FightId = 386,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 773,
                FightId = 386,
                Number = 1,
                Created = date,
                Modified = date
            },

            // Bita Śmietanka 1
            new()
            {
                Id = 774,
                FightId = 387,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 775,
                FightId = 387,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 776,
                FightId = 388,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 777,
                FightId = 388,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 778,
                FightId = 389,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 779,
                FightId = 389,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 780,
                FightId = 390,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 781,
                FightId = 390,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 782,
                FightId = 391,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 783,
                FightId = 391,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 784,
                FightId = 392,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 785,
                FightId = 392,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 786,
                FightId = 393,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 787,
                FightId = 393,
                Number = 1,
                Created = date,
                Modified = date
            },

            // Bita Śmietanka 2
            new()
            {
                Id = 788,
                FightId = 394,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 789,
                FightId = 394,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 790,
                FightId = 395,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 791,
                FightId = 395,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 792,
                FightId = 396,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 793,
                FightId = 396,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 794,
                FightId = 397,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 795,
                FightId = 397,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 796,
                FightId = 398,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 797,
                FightId = 398,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 798,
                FightId = 399,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 799,
                FightId = 399,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 800,
                FightId = 400,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 801,
                FightId = 400,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 802,
                FightId = 401,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 803,
                FightId = 401,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 804,
                FightId = 402,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 805,
                FightId = 402,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 806,
                FightId = 403,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 807,
                FightId = 403,
                Number = 1,
                Created = date,
                Modified = date
            },

            // Elite Fighters 1: Muran vs. Warszawski Dresik
            new()
            {
                Id = 808,
                FightId = 404,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 809,
                FightId = 404,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 810,
                FightId = 405,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 811,
                FightId = 405,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 812,
                FightId = 406,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 813,
                FightId = 406,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 814,
                FightId = 407,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 815,
                FightId = 407,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 816,
                FightId = 408,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 817,
                FightId = 408,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 818,
                FightId = 409,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 819,
                FightId = 409,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 820,
                FightId = 410,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 821,
                FightId = 410,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 822,
                FightId = 411,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 823,
                FightId = 411,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 824,
                FightId = 412,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 825,
                FightId = 412,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 826,
                FightId = 413,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 827,
                FightId = 413,
                Number = 1,
                Created = date,
                Modified = date
            },

            // MMA-VIP 1: Najman vs. Złotówa
            new()
            {
                Id = 828,
                FightId = 414,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 829,
                FightId = 414,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 830,
                FightId = 415,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 831,
                FightId = 415,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 832,
                FightId = 416,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 833,
                FightId = 416,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 834,
                FightId = 417,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 835,
                FightId = 417,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 836,
                FightId = 418,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 837,
                FightId = 418,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 838,
                FightId = 419,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 839,
                FightId = 419,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 840,
                FightId = 420,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 841,
                FightId = 420,
                Number = 1,
                Created = date,
                Modified = date
            },

            // MMA-VIP 2: Igrzyska Rozkminiaczy
            new()
            {
                Id = 842,
                FightId = 421,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 843,
                FightId = 421,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 844,
                FightId = 422,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 845,
                FightId = 422,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 846,
                FightId = 423,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 847,
                FightId = 423,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 848,
                FightId = 424,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 849,
                FightId = 424,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 850,
                FightId = 425,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 851,
                FightId = 425,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 852,
                FightId = 426,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 853,
                FightId = 426,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 854,
                FightId = 427,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 855,
                FightId = 427,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 856,
                FightId = 428,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 857,
                FightId = 428,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 858,
                FightId = 429,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 859,
                FightId = 429,
                Number = 1,
                Created = date,
                Modified = date
            },

            // MMA-VIP 3: Galaktyka Osobliwości
            new()
            {
                Id = 860,
                FightId = 430,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 861,
                FightId = 430,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 862,
                FightId = 431,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 863,
                FightId = 431,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 864,
                FightId = 432,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 865,
                FightId = 432,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 866,
                FightId = 433,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 867,
                FightId = 433,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 868,
                FightId = 434,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 869,
                FightId = 434,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 870,
                FightId = 435,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 871,
                FightId = 435,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 872,
                FightId = 436,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 873,
                FightId = 436,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 874,
                FightId = 437,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 875,
                FightId = 437,
                Number = 1,
                Created = date,
                Modified = date
            },

            // MMA-VIP 4: Imperium Potępionych
            new()
            {
                Id = 876,
                FightId = 438,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 877,
                FightId = 438,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 878,
                FightId = 439,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 879,
                FightId = 439,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 880,
                FightId = 440,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 881,
                FightId = 440,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 882,
                FightId = 441,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 883,
                FightId = 441,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 884,
                FightId = 442,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 885,
                FightId = 442,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 886,
                FightId = 443,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 887,
                FightId = 443,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 888,
                FightId = 444,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 889,
                FightId = 444,
                Number = 1,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 890,
                FightId = 445,
                Number = 0,
                Created = date,
                Modified = date
            },
            new()
            {
                Id = 891,
                FightId = 445,
                Number = 1,
                Created = date,
                Modified = date
            }
        });

        modelBuilder.Entity<TeamFighter>().HasData(new List<TeamFighter>
        {
            // Fame 1: Boxdel vs. Guzik
            new() { Id = 1, TeamId = 1, FighterId = 1, FightResult = FightResult.Loss },
            new() { Id = 2, TeamId = 2, FighterId = 2, FightResult = FightResult.Win },
            new() { Id = 3, TeamId = 3, FighterId = 3, FightResult = FightResult.Loss },
            new() { Id = 4, TeamId = 4, FighterId = 4, FightResult = FightResult.Win },
            new() { Id = 5, TeamId = 5, FighterId = 5, FightResult = FightResult.Loss },
            new() { Id = 6, TeamId = 6, FighterId = 6, FightResult = FightResult.Win },
            new() { Id = 7, TeamId = 7, FighterId = 7, FightResult = FightResult.Win },
            new() { Id = 8, TeamId = 8, FighterId = 8, FightResult = FightResult.Loss },
            new() { Id = 9, TeamId = 9, FighterId = 9, FightResult = FightResult.Win },
            new() { Id = 10, TeamId = 10, FighterId = 10, FightResult = FightResult.Loss },
            new() { Id = 11, TeamId = 11, FighterId = 11, FightResult = FightResult.Loss },
            new() { Id = 12, TeamId = 12, FighterId = 12, FightResult = FightResult.Win },
            new() { Id = 13, TeamId = 13, FighterId = 13, FightResult = FightResult.Loss },
            new() { Id = 14, TeamId = 14, FighterId = 14, FightResult = FightResult.Win },
            new() { Id = 15, TeamId = 15, FighterId = 15, FightResult = FightResult.Win },
            new() { Id = 16, TeamId = 16, FighterId = 16, FightResult = FightResult.Loss },

            // Fame 2: Rafonix vs. Magical
            new() { Id = 17, TeamId = 17, FighterId = 17, FightResult = FightResult.Win },
            new() { Id = 18, TeamId = 18, FighterId = 4, FightResult = FightResult.Loss },
            new() { Id = 19, TeamId = 19, FighterId = 18, FightResult = FightResult.Win },
            new() { Id = 20, TeamId = 20, FighterId = 19, FightResult = FightResult.Loss },
            new() { Id = 21, TeamId = 21, FighterId = 20, FightResult = FightResult.Win },
            new() { Id = 22, TeamId = 21, FighterId = 21, FightResult = FightResult.Win },
            new() { Id = 23, TeamId = 22, FighterId = 22, FightResult = FightResult.Loss },
            new() { Id = 24, TeamId = 22, FighterId = 23, FightResult = FightResult.Loss },
            new() { Id = 25, TeamId = 23, FighterId = 24, FightResult = FightResult.Loss },
            new() { Id = 26, TeamId = 24, FighterId = 2, FightResult = FightResult.Win },
            new() { Id = 27, TeamId = 25, FighterId = 25, FightResult = FightResult.Win },
            new() { Id = 28, TeamId = 26, FighterId = 26, FightResult = FightResult.Loss },
            new() { Id = 29, TeamId = 27, FighterId = 27, FightResult = FightResult.Win },
            new() { Id = 30, TeamId = 28, FighterId = 10, FightResult = FightResult.Loss },
            new() { Id = 31, TeamId = 29, FighterId = 28, FightResult = FightResult.Win },
            new() { Id = 32, TeamId = 30, FighterId = 14, FightResult = FightResult.Loss },
            new() { Id = 33, TeamId = 31, FighterId = 29, FightResult = FightResult.Win },
            new() { Id = 34, TeamId = 32, FighterId = 13, FightResult = FightResult.Loss },

            // Fame 3: IsAmU vs. DeeJayPallaside
            new() { Id = 35, TeamId = 33, FighterId = 8, FightResult = FightResult.Win },
            new() { Id = 36, TeamId = 34, FighterId = 30, FightResult = FightResult.Loss },
            new() { Id = 37, TeamId = 35, FighterId = 31, FightResult = FightResult.Loss },
            new() { Id = 38, TeamId = 36, FighterId = 32, FightResult = FightResult.Win },
            new() { Id = 39, TeamId = 37, FighterId = 6, FightResult = FightResult.Win },
            new() { Id = 40, TeamId = 38, FighterId = 33, FightResult = FightResult.Loss },
            new() { Id = 41, TeamId = 39, FighterId = 14, FightResult = FightResult.Loss },
            new() { Id = 42, TeamId = 40, FighterId = 34, FightResult = FightResult.Win },
            new() { Id = 43, TeamId = 41, FighterId = 35, FightResult = FightResult.Loss },
            new() { Id = 44, TeamId = 42, FighterId = 36, FightResult = FightResult.Win },
            new() { Id = 45, TeamId = 43, FighterId = 24, FightResult = FightResult.Loss },
            new() { Id = 46, TeamId = 44, FighterId = 37, FightResult = FightResult.Win },
            new() { Id = 47, TeamId = 45, FighterId = 38, FightResult = FightResult.Win },
            new() { Id = 48, TeamId = 46, FighterId = 39, FightResult = FightResult.Loss },
            new() { Id = 49, TeamId = 47, FighterId = 28, FightResult = FightResult.Win },
            new() { Id = 50, TeamId = 48, FighterId = 25, FightResult = FightResult.Loss },
            new() { Id = 51, TeamId = 49, FighterId = 40, FightResult = FightResult.Win },
            new() { Id = 52, TeamId = 50, FighterId = 41, FightResult = FightResult.Loss },

            // Fame 4: Linkimaster vs. Lil Masti
            new() { Id = 53, TeamId = 51, FighterId = 42, FightResult = FightResult.Win },
            new() { Id = 54, TeamId = 52, FighterId = 17, FightResult = FightResult.Loss },
            new() { Id = 55, TeamId = 53, FighterId = 35, FightResult = FightResult.Win },
            new() { Id = 56, TeamId = 54, FighterId = 43, FightResult = FightResult.Loss },
            new() { Id = 57, TeamId = 55, FighterId = 44, FightResult = FightResult.Loss },
            new() { Id = 58, TeamId = 56, FighterId = 45, FightResult = FightResult.Win },
            new() { Id = 59, TeamId = 57, FighterId = 9, FightResult = FightResult.Loss },
            new() { Id = 60, TeamId = 58, FighterId = 34, FightResult = FightResult.Win },
            new() { Id = 61, TeamId = 59, FighterId = 15, FightResult = FightResult.Loss },
            new() { Id = 62, TeamId = 60, FighterId = 46, FightResult = FightResult.Win },
            new() { Id = 63, TeamId = 61, FighterId = 14, FightResult = FightResult.Win },
            new() { Id = 64, TeamId = 62, FighterId = 25, FightResult = FightResult.Loss },
            new() { Id = 65, TeamId = 63, FighterId = 47, FightResult = FightResult.Win },
            new() { Id = 66, TeamId = 64, FighterId = 48, FightResult = FightResult.Loss },
            new() { Id = 67, TeamId = 65, FighterId = 38, FightResult = FightResult.Loss },
            new() { Id = 68, TeamId = 66, FighterId = 49, FightResult = FightResult.Win },

            // Fame 5: Bonus BGC vs. Najman
            new() { Id = 69, TeamId = 67, FighterId = 30, FightResult = FightResult.Win },
            new() { Id = 70, TeamId = 68, FighterId = 50, FightResult = FightResult.Loss },
            new() { Id = 71, TeamId = 69, FighterId = 6, FightResult = FightResult.Loss },
            new() { Id = 72, TeamId = 70, FighterId = 17, FightResult = FightResult.Win },
            new() { Id = 73, TeamId = 71, FighterId = 51, FightResult = FightResult.Win },
            new() { Id = 74, TeamId = 72, FighterId = 39, FightResult = FightResult.Loss },
            new() { Id = 75, TeamId = 73, FighterId = 28, FightResult = FightResult.Win },
            new() { Id = 76, TeamId = 74, FighterId = 52, FightResult = FightResult.Loss },
            new() { Id = 77, TeamId = 75, FighterId = 40, FightResult = FightResult.Win },
            new() { Id = 78, TeamId = 76, FighterId = 29, FightResult = FightResult.Loss },
            new() { Id = 79, TeamId = 77, FighterId = 53, FightResult = FightResult.Loss },
            new() { Id = 80, TeamId = 78, FighterId = 54, FightResult = FightResult.Win },
            new() { Id = 81, TeamId = 79, FighterId = 55, FightResult = FightResult.Win },
            new() { Id = 82, TeamId = 80, FighterId = 27, FightResult = FightResult.Loss },
            new() { Id = 83, TeamId = 81, FighterId = 24, FightResult = FightResult.Loss },
            new() { Id = 84, TeamId = 82, FighterId = 56, FightResult = FightResult.Win },

            // Fame 6: Zusje vs. Linkimaster
            new() { Id = 85, TeamId = 83, FighterId = 9, FightResult = FightResult.Win },
            new() { Id = 86, TeamId = 84, FighterId = 57, FightResult = FightResult.Loss },
            new() { Id = 87, TeamId = 85, FighterId = 58, FightResult = FightResult.Loss },
            new() { Id = 88, TeamId = 86, FighterId = 59, FightResult = FightResult.Win },
            new() { Id = 89, TeamId = 87, FighterId = 60, FightResult = FightResult.Loss },
            new() { Id = 90, TeamId = 88, FighterId = 61, FightResult = FightResult.Win },
            new() { Id = 91, TeamId = 89, FighterId = 62, FightResult = FightResult.Loss },
            new() { Id = 92, TeamId = 90, FighterId = 34, FightResult = FightResult.Win },
            new() { Id = 93, TeamId = 91, FighterId = 46, FightResult = FightResult.Win },
            new() { Id = 94, TeamId = 92, FighterId = 63, FightResult = FightResult.Loss },
            new() { Id = 95, TeamId = 93, FighterId = 64, FightResult = FightResult.Win },
            new() { Id = 96, TeamId = 94, FighterId = 56, FightResult = FightResult.Loss },
            new() { Id = 97, TeamId = 95, FighterId = 65, FightResult = FightResult.Win },
            new() { Id = 98, TeamId = 96, FighterId = 29, FightResult = FightResult.Loss },
            new() { Id = 99, TeamId = 97, FighterId = 66, FightResult = FightResult.Loss },
            new() { Id = 100, TeamId = 98, FighterId = 38, FightResult = FightResult.Win },

            // Fame 7: Popek vs. Stifler
            new() { Id = 101, TeamId = 99, FighterId = 2, FightResult = FightResult.Loss },
            new() { Id = 102, TeamId = 100, FighterId = 62, FightResult = FightResult.Win },
            new() { Id = 103, TeamId = 101, FighterId = 45, FightResult = FightResult.Loss },
            new() { Id = 104, TeamId = 102, FighterId = 4, FightResult = FightResult.Win },
            new() { Id = 105, TeamId = 103, FighterId = 56, FightResult = FightResult.Win },
            new() { Id = 106, TeamId = 104, FighterId = 67, FightResult = FightResult.Loss },
            new() { Id = 107, TeamId = 105, FighterId = 52, FightResult = FightResult.Loss },
            new() { Id = 108, TeamId = 106, FighterId = 68, FightResult = FightResult.Win },
            new() { Id = 109, TeamId = 107, FighterId = 8, FightResult = FightResult.Win },
            new() { Id = 110, TeamId = 108, FighterId = 30, FightResult = FightResult.Loss },
            new() { Id = 111, TeamId = 109, FighterId = 59, FightResult = FightResult.Loss },
            new() { Id = 112, TeamId = 110, FighterId = 21, FightResult = FightResult.Win },
            new() { Id = 113, TeamId = 111, FighterId = 38, FightResult = FightResult.Win },
            new() { Id = 114, TeamId = 112, FighterId = 69, FightResult = FightResult.Loss },
            new() { Id = 115, TeamId = 113, FighterId = 28, FightResult = FightResult.Win },
            new() { Id = 116, TeamId = 114, FighterId = 65, FightResult = FightResult.Loss },
            new() { Id = 117, TeamId = 115, FighterId = 14, FightResult = FightResult.Win },
            new() { Id = 118, TeamId = 116, FighterId = 25, FightResult = FightResult.Loss },
            new() { Id = 119, TeamId = 117, FighterId = 70, FightResult = FightResult.Win },
            new() { Id = 120, TeamId = 118, FighterId = 71, FightResult = FightResult.Loss },

            // Fame 8: Dubiel vs. Blonsky
            new() { Id = 121, TeamId = 119, FighterId = 72, FightResult = FightResult.Win },
            new() { Id = 122, TeamId = 120, FighterId = 57, FightResult = FightResult.Loss },
            new() { Id = 123, TeamId = 121, FighterId = 73, FightResult = FightResult.Loss },
            new() { Id = 124, TeamId = 122, FighterId = 58, FightResult = FightResult.Win },
            new() { Id = 125, TeamId = 123, FighterId = 74, FightResult = FightResult.Win },
            new() { Id = 126, TeamId = 124, FighterId = 68, FightResult = FightResult.Loss },
            new() { Id = 127, TeamId = 125, FighterId = 66, FightResult = FightResult.Win },
            new() { Id = 128, TeamId = 126, FighterId = 75, FightResult = FightResult.Loss },
            new() { Id = 129, TeamId = 127, FighterId = 76, FightResult = FightResult.Loss },
            new() { Id = 130, TeamId = 128, FighterId = 64, FightResult = FightResult.Win },
            new() { Id = 131, TeamId = 129, FighterId = 21, FightResult = FightResult.Loss },
            new() { Id = 132, TeamId = 130, FighterId = 77, FightResult = FightResult.Win },
            new() { Id = 133, TeamId = 131, FighterId = 25, FightResult = FightResult.Loss },
            new() { Id = 134, TeamId = 132, FighterId = 8, FightResult = FightResult.Win },
            new() { Id = 135, TeamId = 133, FighterId = 78, FightResult = FightResult.Loss },
            new() { Id = 136, TeamId = 134, FighterId = 35, FightResult = FightResult.Win },
            new() { Id = 137, TeamId = 135, FighterId = 34, FightResult = FightResult.Win },
            new() { Id = 138, TeamId = 136, FighterId = 56, FightResult = FightResult.Loss },
            new() { Id = 139, TeamId = 137, FighterId = 79, FightResult = FightResult.Loss },
            new() { Id = 140, TeamId = 138, FighterId = 80, FightResult = FightResult.Win },

            // Fame 9: Let’s Play
            new() { Id = 141, TeamId = 139, FighterId = 36, FightResult = FightResult.Win },
            new() { Id = 142, TeamId = 140, FighterId = 50, FightResult = FightResult.Loss },
            new() { Id = 143, TeamId = 141, FighterId = 6, FightResult = FightResult.Win },
            new() { Id = 144, TeamId = 142, FighterId = 74, FightResult = FightResult.Loss },
            new() { Id = 145, TeamId = 143, FighterId = 81, FightResult = FightResult.Win },
            new() { Id = 146, TeamId = 144, FighterId = 82, FightResult = FightResult.Loss },
            new() { Id = 147, TeamId = 145, FighterId = 83, FightResult = FightResult.Loss },
            new() { Id = 148, TeamId = 146, FighterId = 84, FightResult = FightResult.Win },
            new() { Id = 149, TeamId = 147, FighterId = 68, FightResult = FightResult.Loss },
            new() { Id = 150, TeamId = 148, FighterId = 85, FightResult = FightResult.Win },
            new() { Id = 151, TeamId = 149, FighterId = 86, FightResult = FightResult.Loss },
            new() { Id = 152, TeamId = 150, FighterId = 87, FightResult = FightResult.Win },
            new() { Id = 153, TeamId = 151, FighterId = 66, FightResult = FightResult.Loss },
            new() { Id = 154, TeamId = 152, FighterId = 88, FightResult = FightResult.Win },
            new() { Id = 155, TeamId = 153, FighterId = 55, FightResult = FightResult.Loss },
            new() { Id = 156, TeamId = 154, FighterId = 46, FightResult = FightResult.Win },
            new() { Id = 157, TeamId = 155, FighterId = 80, FightResult = FightResult.Win },
            new() { Id = 158, TeamId = 156, FighterId = 89, FightResult = FightResult.Loss },
            new() { Id = 159, TeamId = 157, FighterId = 44, FightResult = FightResult.Loss },
            new() { Id = 160, TeamId = 158, FighterId = 77, FightResult = FightResult.Win },

            // Fame 10: Don Kasjo vs. Parke
            new() { Id = 161, TeamId = 159, FighterId = 9, FightResult = FightResult.Loss },
            new() { Id = 162, TeamId = 160, FighterId = 90, FightResult = FightResult.Win },
            new() { Id = 163, TeamId = 161, FighterId = 91, FightResult = FightResult.Win },
            new() { Id = 164, TeamId = 162, FighterId = 92, FightResult = FightResult.Loss },
            new() { Id = 165, TeamId = 163, FighterId = 77, FightResult = FightResult.Win },
            new() { Id = 166, TeamId = 164, FighterId = 4, FightResult = FightResult.Loss },
            new() { Id = 167, TeamId = 165, FighterId = 25, FightResult = FightResult.Win },
            new() { Id = 168, TeamId = 166, FighterId = 93, FightResult = FightResult.Loss },
            new() { Id = 169, TeamId = 167, FighterId = 58, FightResult = FightResult.Loss },
            new() { Id = 170, TeamId = 168, FighterId = 73, FightResult = FightResult.Win },
            new() { Id = 171, TeamId = 169, FighterId = 59, FightResult = FightResult.Win },
            new() { Id = 172, TeamId = 170, FighterId = 94, FightResult = FightResult.Loss },
            new() { Id = 173, TeamId = 171, FighterId = 38, FightResult = FightResult.Win },
            new() { Id = 174, TeamId = 172, FighterId = 88, FightResult = FightResult.Loss },
            new() { Id = 175, TeamId = 173, FighterId = 28, FightResult = FightResult.Loss },
            new() { Id = 176, TeamId = 174, FighterId = 14, FightResult = FightResult.Win },
            new() { Id = 177, TeamId = 175, FighterId = 79, FightResult = FightResult.Win },
            new() { Id = 178, TeamId = 176, FighterId = 95, FightResult = FightResult.Loss },
            new() { Id = 179, TeamId = 177, FighterId = 34, FightResult = FightResult.Loss },
            new() { Id = 180, TeamId = 178, FighterId = 96, FightResult = FightResult.Win },

            // Fame 11: Fight Club
            new() { Id = 181, TeamId = 179, FighterId = 97, FightResult = FightResult.Win },
            new() { Id = 182, TeamId = 180, FighterId = 98, FightResult = FightResult.Loss },
            new() { Id = 183, TeamId = 181, FighterId = 99, FightResult = FightResult.Win },
            new() { Id = 184, TeamId = 182, FighterId = 100, FightResult = FightResult.Loss },
            new() { Id = 185, TeamId = 183, FighterId = 76, FightResult = FightResult.Win },
            new() { Id = 186, TeamId = 184, FighterId = 101, FightResult = FightResult.Loss },
            new() { Id = 187, TeamId = 185, FighterId = 81, FightResult = FightResult.Win },
            new() { Id = 188, TeamId = 186, FighterId = 102, FightResult = FightResult.Loss },
            new() { Id = 189, TeamId = 187, FighterId = 6, FightResult = FightResult.Win },
            new() { Id = 190, TeamId = 188, FighterId = 103, FightResult = FightResult.Loss },
            new() { Id = 191, TeamId = 189, FighterId = 55, FightResult = FightResult.Loss },
            new() { Id = 192, TeamId = 190, FighterId = 59, FightResult = FightResult.Win },
            new() { Id = 193, TeamId = 191, FighterId = 104, FightResult = FightResult.Loss },
            new() { Id = 194, TeamId = 192, FighterId = 105, FightResult = FightResult.Win },
            new() { Id = 195, TeamId = 193, FighterId = 85, FightResult = FightResult.Draw },
            new() { Id = 196, TeamId = 194, FighterId = 106, FightResult = FightResult.Draw },
            new() { Id = 197, TeamId = 195, FighterId = 35, FightResult = FightResult.Loss },
            new() { Id = 198, TeamId = 196, FighterId = 25, FightResult = FightResult.Win },
            new() { Id = 199, TeamId = 197, FighterId = 107, FightResult = FightResult.Loss },
            new() { Id = 200, TeamId = 198, FighterId = 108, FightResult = FightResult.Win },
            new() { Id = 201, TeamId = 199, FighterId = 89, FightResult = FightResult.Loss },
            new() { Id = 202, TeamId = 200, FighterId = 109, FightResult = FightResult.Win },
            new() { Id = 203, TeamId = 201, FighterId = 79, FightResult = FightResult.Win },
            new() { Id = 204, TeamId = 202, FighterId = 110, FightResult = FightResult.Loss },
            new() { Id = 205, TeamId = 203, FighterId = 111, FightResult = FightResult.Win },
            new() { Id = 206, TeamId = 204, FighterId = 96, FightResult = FightResult.Loss },

            // Fame 12: Don Kasjo vs. Polish Zombie
            new() { Id = 207, TeamId = 205, FighterId = 97, FightResult = FightResult.Loss },
            new() { Id = 208, TeamId = 206, FighterId = 99, FightResult = FightResult.Win },
            new() { Id = 209, TeamId = 207, FighterId = 36, FightResult = FightResult.Loss },
            new() { Id = 210, TeamId = 208, FighterId = 112, FightResult = FightResult.Win },
            new() { Id = 211, TeamId = 209, FighterId = 88, FightResult = FightResult.Loss },
            new() { Id = 212, TeamId = 210, FighterId = 82, FightResult = FightResult.Win },
            new() { Id = 213, TeamId = 211, FighterId = 6, FightResult = FightResult.Win },
            new() { Id = 214, TeamId = 212, FighterId = 57, FightResult = FightResult.Loss },
            new() { Id = 215, TeamId = 213, FighterId = 64, FightResult = FightResult.Win },
            new() { Id = 216, TeamId = 214, FighterId = 113, FightResult = FightResult.Loss },
            new() { Id = 217, TeamId = 215, FighterId = 66, FightResult = FightResult.Win },
            new() { Id = 218, TeamId = 216, FighterId = 69, FightResult = FightResult.Loss },
            new() { Id = 219, TeamId = 217, FighterId = 14, FightResult = FightResult.Loss },
            new() { Id = 220, TeamId = 218, FighterId = 8, FightResult = FightResult.Win },
            new() { Id = 221, TeamId = 219, FighterId = 80, FightResult = FightResult.Win },
            new() { Id = 222, TeamId = 220, FighterId = 114, FightResult = FightResult.Loss },
            new() { Id = 223, TeamId = 221, FighterId = 34, FightResult = FightResult.Win },
            new() { Id = 224, TeamId = 222, FighterId = 115, FightResult = FightResult.Loss },
            new() { Id = 225, TeamId = 223, FighterId = 34, FightResult = FightResult.Win },
            new() { Id = 226, TeamId = 224, FighterId = 15, FightResult = FightResult.Loss },
            new() { Id = 227, TeamId = 225, FighterId = 59, FightResult = FightResult.Win },
            new() { Id = 228, TeamId = 226, FighterId = 116, FightResult = FightResult.Loss },

            // Fame 13: Nitro vs. Unboxall
            new() { Id = 229, TeamId = 227, FighterId = 84, FightResult = FightResult.Loss },
            new() { Id = 230, TeamId = 228, FighterId = 86, FightResult = FightResult.Win },
            new() { Id = 231, TeamId = 229, FighterId = 68, FightResult = FightResult.NoContest },
            new() { Id = 232, TeamId = 230, FighterId = 117, FightResult = FightResult.NoContest },
            new() { Id = 233, TeamId = 231, FighterId = 28, FightResult = FightResult.Win },
            new() { Id = 234, TeamId = 232, FighterId = 87, FightResult = FightResult.Loss },
            new() { Id = 235, TeamId = 233, FighterId = 77, FightResult = FightResult.Loss },
            new() { Id = 236, TeamId = 234, FighterId = 76, FightResult = FightResult.Win },
            new() { Id = 237, TeamId = 235, FighterId = 118, FightResult = FightResult.Loss },
            new() { Id = 238, TeamId = 236, FighterId = 119, FightResult = FightResult.Win },
            new() { Id = 239, TeamId = 237, FighterId = 38, FightResult = FightResult.Win },
            new() { Id = 240, TeamId = 238, FighterId = 81, FightResult = FightResult.Loss },
            new() { Id = 241, TeamId = 239, FighterId = 14, FightResult = FightResult.Win },
            new() { Id = 242, TeamId = 240, FighterId = 25, FightResult = FightResult.Loss },
            new() { Id = 243, TeamId = 241, FighterId = 96, FightResult = FightResult.Win },
            new() { Id = 244, TeamId = 242, FighterId = 70, FightResult = FightResult.Loss },
            new() { Id = 245, TeamId = 243, FighterId = 120, FightResult = FightResult.Loss },
            new() { Id = 246, TeamId = 244, FighterId = 121, FightResult = FightResult.Win },

            // Fame 14: Gimper vs. Tromba
            new() { Id = 247, TeamId = 245, FighterId = 122, FightResult = FightResult.Loss },
            new() { Id = 248, TeamId = 246, FighterId = 123, FightResult = FightResult.Win },
            new() { Id = 249, TeamId = 247, FighterId = 28, FightResult = FightResult.Win },
            new() { Id = 250, TeamId = 248, FighterId = 68, FightResult = FightResult.Loss },
            new() { Id = 251, TeamId = 249, FighterId = 58, FightResult = FightResult.Loss },
            new() { Id = 252, TeamId = 250, FighterId = 94, FightResult = FightResult.Win },
            new() { Id = 253, TeamId = 251, FighterId = 124, FightResult = FightResult.Win },
            new() { Id = 254, TeamId = 252, FighterId = 114, FightResult = FightResult.Loss },
            new() { Id = 255, TeamId = 253, FighterId = 8, FightResult = FightResult.Win },
            new() { Id = 256, TeamId = 254, FighterId = 6, FightResult = FightResult.Loss },
            new() { Id = 257, TeamId = 255, FighterId = 96, FightResult = FightResult.Win },
            new() { Id = 258, TeamId = 256, FighterId = 76, FightResult = FightResult.Loss },
            new() { Id = 259, TeamId = 257, FighterId = 125, FightResult = FightResult.Win },
            new() { Id = 260, TeamId = 258, FighterId = 126, FightResult = FightResult.Loss },
            new() { Id = 261, TeamId = 259, FighterId = 120, FightResult = FightResult.Loss },
            new() { Id = 262, TeamId = 260, FighterId = 127, FightResult = FightResult.Win },
            new() { Id = 263, TeamId = 261, FighterId = 128, FightResult = FightResult.Loss },
            new() { Id = 264, TeamId = 262, FighterId = 129, FightResult = FightResult.Win },

            // Fame 15: Zemsta
            new() { Id = 265, TeamId = 263, FighterId = 130, FightResult = FightResult.Loss },
            new() { Id = 266, TeamId = 263, FighterId = 131, FightResult = FightResult.Loss },
            new() { Id = 267, TeamId = 264, FighterId = 132, FightResult = FightResult.Win },
            new() { Id = 268, TeamId = 264, FighterId = 133, FightResult = FightResult.Win },
            new() { Id = 269, TeamId = 265, FighterId = 117, FightResult = FightResult.Loss },
            new() { Id = 270, TeamId = 266, FighterId = 85, FightResult = FightResult.Win },
            new() { Id = 271, TeamId = 267, FighterId = 134, FightResult = FightResult.Win },
            new() { Id = 272, TeamId = 268, FighterId = 135, FightResult = FightResult.Loss },
            new() { Id = 273, TeamId = 269, FighterId = 59, FightResult = FightResult.Win },
            new() { Id = 274, TeamId = 270, FighterId = 94, FightResult = FightResult.Loss },
            new() { Id = 275, TeamId = 271, FighterId = 59, FightResult = FightResult.Win },
            new() { Id = 276, TeamId = 272, FighterId = 116, FightResult = FightResult.Loss },
            new() { Id = 277, TeamId = 273, FighterId = 80, FightResult = FightResult.Loss },
            new() { Id = 278, TeamId = 274, FighterId = 79, FightResult = FightResult.Win },
            new() { Id = 279, TeamId = 275, FighterId = 136, FightResult = FightResult.Loss },
            new() { Id = 280, TeamId = 276, FighterId = 115, FightResult = FightResult.Win },
            new() { Id = 281, TeamId = 277, FighterId = 127, FightResult = FightResult.Win },
            new() { Id = 282, TeamId = 278, FighterId = 137, FightResult = FightResult.Loss },
            new() { Id = 283, TeamId = 279, FighterId = 38, FightResult = FightResult.Loss },
            new() { Id = 284, TeamId = 280, FighterId = 49, FightResult = FightResult.Win },

            // Fame 16: Tromba vs. Dubiel
            new() { Id = 285, TeamId = 281, FighterId = 138, FightResult = FightResult.Loss },
            new() { Id = 286, TeamId = 282, FighterId = 139, FightResult = FightResult.Win },
            new() { Id = 287, TeamId = 283, FighterId = 69, FightResult = FightResult.Loss },
            new() { Id = 288, TeamId = 284, FighterId = 123, FightResult = FightResult.Win },
            new() { Id = 289, TeamId = 285, FighterId = 140, FightResult = FightResult.Win },
            new() { Id = 290, TeamId = 286, FighterId = 141, FightResult = FightResult.Loss },
            new() { Id = 291, TeamId = 287, FighterId = 67, FightResult = FightResult.Loss },
            new() { Id = 292, TeamId = 288, FighterId = 35, FightResult = FightResult.Win },
            new() { Id = 293, TeamId = 289, FighterId = 86, FightResult = FightResult.Loss },
            new() { Id = 294, TeamId = 290, FighterId = 14, FightResult = FightResult.Win },
            new() { Id = 295, TeamId = 291, FighterId = 114, FightResult = FightResult.Win },
            new() { Id = 296, TeamId = 292, FighterId = 6, FightResult = FightResult.Loss },
            new() { Id = 297, TeamId = 293, FighterId = 68, FightResult = FightResult.Loss },
            new() { Id = 298, TeamId = 294, FighterId = 25, FightResult = FightResult.Win },
            new() { Id = 299, TeamId = 295, FighterId = 142, FightResult = FightResult.Win },
            new() { Id = 300, TeamId = 296, FighterId = 58, FightResult = FightResult.Loss },
            new() { Id = 301, TeamId = 297, FighterId = 119, FightResult = FightResult.Win },
            new() { Id = 302, TeamId = 298, FighterId = 116, FightResult = FightResult.Loss },
            new() { Id = 303, TeamId = 299, FighterId = 129, FightResult = FightResult.Loss },
            new() { Id = 304, TeamId = 300, FighterId = 79, FightResult = FightResult.Win },

            // Fame 17: Ferrari vs. Łaszczyk
            new() { Id = 305, TeamId = 301, FighterId = 143, FightResult = FightResult.Win },
            new() { Id = 306, TeamId = 302, FighterId = 123, FightResult = FightResult.Loss },
            new() { Id = 307, TeamId = 303, FighterId = 107, FightResult = FightResult.Loss },
            new() { Id = 308, TeamId = 304, FighterId = 29, FightResult = FightResult.Win },
            new() { Id = 309, TeamId = 305, FighterId = 76, FightResult = FightResult.Win },
            new() { Id = 310, TeamId = 306, FighterId = 115, FightResult = FightResult.Loss },
            new() { Id = 311, TeamId = 307, FighterId = 35, FightResult = FightResult.Loss },
            new() { Id = 312, TeamId = 308, FighterId = 144, FightResult = FightResult.Win },
            new() { Id = 313, TeamId = 309, FighterId = 8, FightResult = FightResult.Loss },
            new() { Id = 314, TeamId = 310, FighterId = 58, FightResult = FightResult.Win },
            new() { Id = 315, TeamId = 311, FighterId = 145, FightResult = FightResult.Loss },
            new() { Id = 316, TeamId = 312, FighterId = 128, FightResult = FightResult.Win },
            new() { Id = 317, TeamId = 313, FighterId = 146, FightResult = FightResult.Win },
            new() { Id = 318, TeamId = 314, FighterId = 147, FightResult = FightResult.Loss },
            new() { Id = 319, TeamId = 315, FighterId = 25, FightResult = FightResult.Loss },
            new() { Id = 320, TeamId = 316, FighterId = 148, FightResult = FightResult.Win },
            new() { Id = 321, TeamId = 317, FighterId = 149, FightResult = FightResult.Loss },
            new() { Id = 322, TeamId = 318, FighterId = 15, FightResult = FightResult.Win },

            // Fame 18: Crusher vs. Ferrari
            new() { Id = 323, TeamId = 319, FighterId = 150, FightResult = FightResult.Loss },
            new() { Id = 324, TeamId = 320, FighterId = 135, FightResult = FightResult.Win },
            new() { Id = 325, TeamId = 321, FighterId = 151, FightResult = FightResult.Loss },
            new() { Id = 326, TeamId = 322, FighterId = 152, FightResult = FightResult.Win },
            new() { Id = 327, TeamId = 323, FighterId = 138, FightResult = FightResult.Loss },
            new() { Id = 328, TeamId = 324, FighterId = 67, FightResult = FightResult.Win },
            new() { Id = 329, TeamId = 325, FighterId = 153, FightResult = FightResult.Win },
            new() { Id = 330, TeamId = 326, FighterId = 76, FightResult = FightResult.Loss },
            new() { Id = 331, TeamId = 327, FighterId = 154, FightResult = FightResult.Win },
            new() { Id = 332, TeamId = 328, FighterId = 58, FightResult = FightResult.Loss },
            new() { Id = 333, TeamId = 329, FighterId = 8, FightResult = FightResult.Win },
            new() { Id = 334, TeamId = 330, FighterId = 59, FightResult = FightResult.Loss },
            new() { Id = 335, TeamId = 331, FighterId = 119, FightResult = FightResult.Loss },
            new() { Id = 336, TeamId = 332, FighterId = 140, FightResult = FightResult.Win },
            new() { Id = 337, TeamId = 333, FighterId = 38, FightResult = FightResult.Loss },
            new() { Id = 338, TeamId = 334, FighterId = 155, FightResult = FightResult.Win },
            new() { Id = 339, TeamId = 335, FighterId = 80, FightResult = FightResult.Loss },
            new() { Id = 340, TeamId = 336, FighterId = 25, FightResult = FightResult.Win },

            // Fame 19: Tańcula vs. Ferrari
            new() { Id = 341, TeamId = 337, FighterId = 138, FightResult = FightResult.Win },
            new() { Id = 342, TeamId = 338, FighterId = 68, FightResult = FightResult.Loss },
            new() { Id = 343, TeamId = 339, FighterId = 143, FightResult = FightResult.Win },
            new() { Id = 344, TeamId = 340, FighterId = 152, FightResult = FightResult.Loss },
            new() { Id = 345, TeamId = 341, FighterId = 156, FightResult = FightResult.Loss },
            new() { Id = 346, TeamId = 342, FighterId = 157, FightResult = FightResult.Win },
            new() { Id = 347, TeamId = 343, FighterId = 20, FightResult = FightResult.Loss },
            new() { Id = 348, TeamId = 344, FighterId = 154, FightResult = FightResult.Win },
            new() { Id = 349, TeamId = 345, FighterId = 158, FightResult = FightResult.Win },
            new() { Id = 350, TeamId = 346, FighterId = 144, FightResult = FightResult.Loss },
            new() { Id = 351, TeamId = 347, FighterId = 76, FightResult = FightResult.Loss },
            new() { Id = 352, TeamId = 348, FighterId = 115, FightResult = FightResult.Win },
            new() { Id = 353, TeamId = 349, FighterId = 147, FightResult = FightResult.Loss },
            new() { Id = 354, TeamId = 350, FighterId = 35, FightResult = FightResult.Win },
            new() { Id = 355, TeamId = 351, FighterId = 21, FightResult = FightResult.Win },
            new() { Id = 356, TeamId = 352, FighterId = 159, FightResult = FightResult.Loss },
            new() { Id = 357, TeamId = 353, FighterId = 127, FightResult = FightResult.Win },
            new() { Id = 358, TeamId = 354, FighterId = 134, FightResult = FightResult.Loss },
            new() { Id = 359, TeamId = 355, FighterId = 59, FightResult = FightResult.Win },
            new() { Id = 360, TeamId = 356, FighterId = 25, FightResult = FightResult.Loss },

            // Fame UK 1: Gowland vs. McKenna
            new() { Id = 361, TeamId = 357, FighterId = 160, FightResult = FightResult.Win },
            new() { Id = 362, TeamId = 358, FighterId = 161, FightResult = FightResult.Loss },
            new() { Id = 363, TeamId = 359, FighterId = 162, FightResult = FightResult.Loss },
            new() { Id = 364, TeamId = 360, FighterId = 163, FightResult = FightResult.Win },
            new() { Id = 365, TeamId = 361, FighterId = 164, FightResult = FightResult.Loss },
            new() { Id = 366, TeamId = 362, FighterId = 165, FightResult = FightResult.Win },
            new() { Id = 367, TeamId = 363, FighterId = 166, FightResult = FightResult.Loss },
            new() { Id = 368, TeamId = 364, FighterId = 167, FightResult = FightResult.Win },
            new() { Id = 369, TeamId = 365, FighterId = 168, FightResult = FightResult.Loss },
            new() { Id = 370, TeamId = 366, FighterId = 169, FightResult = FightResult.Win },
            new() { Id = 371, TeamId = 367, FighterId = 28, FightResult = FightResult.Loss },
            new() { Id = 372, TeamId = 368, FighterId = 14, FightResult = FightResult.Win },
            new() { Id = 373, TeamId = 369, FighterId = 170, FightResult = FightResult.Win },
            new() { Id = 374, TeamId = 370, FighterId = 65, FightResult = FightResult.Loss },
            new() { Id = 375, TeamId = 371, FighterId = 171, FightResult = FightResult.Win },
            new() { Id = 376, TeamId = 372, FighterId = 172, FightResult = FightResult.Loss },

            // Hype S01E01: Rafonix vs. Hejter
            new() { Id = 377, TeamId = 373, FighterId = 173, FightResult = FightResult.Loss },
            new() { Id = 378, TeamId = 374, FighterId = 174, FightResult = FightResult.Win },
            new() { Id = 379, TeamId = 375, FighterId = 175, FightResult = FightResult.Win },
            new() { Id = 380, TeamId = 376, FighterId = 176, FightResult = FightResult.Loss },
            new() { Id = 381, TeamId = 377, FighterId = 177, FightResult = FightResult.Loss },
            new() { Id = 382, TeamId = 378, FighterId = 178, FightResult = FightResult.Win },
            new() { Id = 383, TeamId = 379, FighterId = 179, FightResult = FightResult.Win },
            new() { Id = 384, TeamId = 380, FighterId = 180, FightResult = FightResult.Loss },
            new() { Id = 385, TeamId = 381, FighterId = 181, FightResult = FightResult.Win },
            new() { Id = 386, TeamId = 382, FighterId = 182, FightResult = FightResult.Loss },
            new() { Id = 387, TeamId = 383, FighterId = 183, FightResult = FightResult.Loss },
            new() { Id = 388, TeamId = 384, FighterId = 184, FightResult = FightResult.Win },
            new() { Id = 389, TeamId = 385, FighterId = 29, FightResult = FightResult.Loss },
            new() { Id = 390, TeamId = 386, FighterId = 68, FightResult = FightResult.Win },

            // Fame Friday Arena 1: Alberto vs. Kubańczyk
            new() { Id = 391, TeamId = 387, FighterId = 185, FightResult = FightResult.Loss },
            new() { Id = 392, TeamId = 388, FighterId = 112, FightResult = FightResult.Win },
            new() { Id = 393, TeamId = 389, FighterId = 28, FightResult = FightResult.Loss },
            new() { Id = 394, TeamId = 390, FighterId = 103, FightResult = FightResult.Win },
            new() { Id = 395, TeamId = 391, FighterId = 151, FightResult = FightResult.Win },
            new() { Id = 396, TeamId = 392, FighterId = 186, FightResult = FightResult.Loss },
            new() { Id = 397, TeamId = 393, FighterId = 20, FightResult = FightResult.Draw },
            new() { Id = 398, TeamId = 394, FighterId = 154, FightResult = FightResult.Draw },
            new() { Id = 399, TeamId = 395, FighterId = 187, FightResult = FightResult.Win },
            new() { Id = 400, TeamId = 396, FighterId = 47, FightResult = FightResult.Loss },
            new() { Id = 401, TeamId = 397, FighterId = 188, FightResult = FightResult.Win },
            new() { Id = 402, TeamId = 398, FighterId = 67, FightResult = FightResult.Loss },
            new() { Id = 403, TeamId = 399, FighterId = 21, FightResult = FightResult.Loss },
            new() { Id = 404, TeamId = 400, FighterId = 153, FightResult = FightResult.Win },
            new() { Id = 405, TeamId = 401, FighterId = 158, FightResult = FightResult.Loss },
            new() { Id = 406, TeamId = 402, FighterId = 189, FightResult = FightResult.Win },
            new() { Id = 407, TeamId = 403, FighterId = 35, FightResult = FightResult.Loss },
            new() { Id = 408, TeamId = 404, FighterId = 79, FightResult = FightResult.Win },
            new() { Id = 409, TeamId = 405, FighterId = 46, FightResult = FightResult.Win },
            new() { Id = 410, TeamId = 406, FighterId = 159, FightResult = FightResult.Loss },

            // Fame Friday Arena 2: Prezes FEN vs. Boxdel 2
            new() { Id = 411, TeamId = 407, FighterId = 190, FightResult = FightResult.Win },
            new() { Id = 412, TeamId = 408, FighterId = 191, FightResult = FightResult.Loss },
            new() { Id = 413, TeamId = 409, FighterId = 192, FightResult = FightResult.Loss },
            new() { Id = 414, TeamId = 410, FighterId = 193, FightResult = FightResult.Win },
            new() { Id = 415, TeamId = 411, FighterId = 194, FightResult = FightResult.Win },
            new() { Id = 416, TeamId = 412, FighterId = 67, FightResult = FightResult.Loss },
            new() { Id = 417, TeamId = 413, FighterId = 85, FightResult = FightResult.Win },
            new() { Id = 418, TeamId = 414, FighterId = 119, FightResult = FightResult.Loss },
            new() { Id = 419, TeamId = 415, FighterId = 125, FightResult = FightResult.Win },
            new() { Id = 420, TeamId = 416, FighterId = 195, FightResult = FightResult.Loss },
            new() { Id = 421, TeamId = 417, FighterId = 127, FightResult = FightResult.Win },
            new() { Id = 422, TeamId = 418, FighterId = 29, FightResult = FightResult.Loss },
            new() { Id = 423, TeamId = 419, FighterId = 58, FightResult = FightResult.Win },
            new() { Id = 424, TeamId = 420, FighterId = 196, FightResult = FightResult.Loss },
            new() { Id = 425, TeamId = 421, FighterId = 14, FightResult = FightResult.Win },
            new() { Id = 426, TeamId = 422, FighterId = 59, FightResult = FightResult.Loss },
            new() { Id = 427, TeamId = 423, FighterId = 8, FightResult = FightResult.Win },
            new() { Id = 428, TeamId = 424, FighterId = 189, FightResult = FightResult.Loss },
            new() { Id = 429, TeamId = 425, FighterId = 80, FightResult = FightResult.Win },
            new() { Id = 430, TeamId = 426, FighterId = 197, FightResult = FightResult.Loss },
            new() { Id = 431, TeamId = 427, FighterId = 149, FightResult = FightResult.Loss },
            new() { Id = 432, TeamId = 428, FighterId = 15, FightResult = FightResult.Win },

            // Fame: Reborn
            new() { Id = 433, TeamId = 429, FighterId = 154, FightResult = FightResult.Loss },
            new() { Id = 434, TeamId = 430, FighterId = 115, FightResult = FightResult.Win },
            new() { Id = 435, TeamId = 431, FighterId = 198, FightResult = FightResult.Loss },
            new() { Id = 436, TeamId = 432, FighterId = 199, FightResult = FightResult.Win },
            new() { Id = 437, TeamId = 433, FighterId = 16, FightResult = FightResult.Win },
            new() { Id = 438, TeamId = 434, FighterId = 200, FightResult = FightResult.Loss },
            new() { Id = 439, TeamId = 435, FighterId = 201, FightResult = FightResult.Win },
            new() { Id = 440, TeamId = 436, FighterId = 202, FightResult = FightResult.Loss },
            new() { Id = 441, TeamId = 437, FighterId = 203, FightResult = FightResult.Loss },
            new() { Id = 442, TeamId = 438, FighterId = 151, FightResult = FightResult.Win },
            new() { Id = 443, TeamId = 439, FighterId = 196, FightResult = FightResult.Loss },
            new() { Id = 444, TeamId = 440, FighterId = 153, FightResult = FightResult.Win },
            new() { Id = 445, TeamId = 441, FighterId = 204, FightResult = FightResult.Loss },
            new() { Id = 446, TeamId = 442, FighterId = 67, FightResult = FightResult.Win },
            new() { Id = 447, TeamId = 443, FighterId = 112, FightResult = FightResult.Loss },
            new() { Id = 448, TeamId = 444, FighterId = 25, FightResult = FightResult.Win },
            new() { Id = 449, TeamId = 445, FighterId = 205, FightResult = FightResult.Loss },
            new() { Id = 450, TeamId = 446, FighterId = 96, FightResult = FightResult.Win },
            new() { Id = 451, TeamId = 447, FighterId = 138, FightResult = FightResult.Loss },
            new() { Id = 452, TeamId = 448, FighterId = 14, FightResult = FightResult.Win },
            new() { Id = 453, TeamId = 449, FighterId = 76, FightResult = FightResult.Loss },
            new() { Id = 454, TeamId = 450, FighterId = 142, FightResult = FightResult.Win },
            new() { Id = 455, TeamId = 451, FighterId = 147, FightResult = FightResult.Win },
            new() { Id = 456, TeamId = 451, FighterId = 52, FightResult = FightResult.Loss },
            new() { Id = 457, TeamId = 452, FighterId = 89, FightResult = FightResult.Loss },
            new() { Id = 458, TeamId = 452, FighterId = 65, FightResult = FightResult.Win },

            // Prime 1: Zadyma
            new() { Id = 459, TeamId = 453, FighterId = 206, FightResult = FightResult.Loss },
            new() { Id = 460, TeamId = 454, FighterId = 207, FightResult = FightResult.Win },
            new() { Id = 461, TeamId = 455, FighterId = 9, FightResult = FightResult.Win },
            new() { Id = 462, TeamId = 456, FighterId = 208, FightResult = FightResult.Loss },
            new() { Id = 463, TeamId = 457, FighterId = 209, FightResult = FightResult.Win },
            new() { Id = 464, TeamId = 458, FighterId = 210, FightResult = FightResult.Loss },
            new() { Id = 465, TeamId = 459, FighterId = 2, FightResult = FightResult.Win },
            new() { Id = 466, TeamId = 460, FighterId = 211, FightResult = FightResult.Loss },
            new() { Id = 467, TeamId = 461, FighterId = 212, FightResult = FightResult.Loss },
            new() { Id = 468, TeamId = 461, FighterId = 213, FightResult = FightResult.Loss },
            new() { Id = 469, TeamId = 462, FighterId = 58, FightResult = FightResult.Win },
            new() { Id = 470, TeamId = 463, FighterId = 78, FightResult = FightResult.Win },
            new() { Id = 471, TeamId = 464, FighterId = 214, FightResult = FightResult.Loss },
            new() { Id = 472, TeamId = 465, FighterId = 215, FightResult = FightResult.Loss },
            new() { Id = 473, TeamId = 466, FighterId = 216, FightResult = FightResult.Win },
            new() { Id = 474, TeamId = 467, FighterId = 21, FightResult = FightResult.Win },
            new() { Id = 475, TeamId = 468, FighterId = 4, FightResult = FightResult.Loss },
            new() { Id = 476, TeamId = 469, FighterId = 217, FightResult = FightResult.Win },
            new() { Id = 477, TeamId = 470, FighterId = 218, FightResult = FightResult.Loss },
            new() { Id = 478, TeamId = 471, FighterId = 47, FightResult = FightResult.Win },
            new() { Id = 479, TeamId = 472, FighterId = 219, FightResult = FightResult.Loss },
            new() { Id = 480, TeamId = 473, FighterId = 34, FightResult = FightResult.Win },
            new() { Id = 481, TeamId = 474, FighterId = 94, FightResult = FightResult.Loss },
            new() { Id = 482, TeamId = 475, FighterId = 54, FightResult = FightResult.Loss },
            new() { Id = 483, TeamId = 476, FighterId = 220, FightResult = FightResult.Win },

            // Prime 2: Kosmos
            new() { Id = 484, TeamId = 477, FighterId = 221, FightResult = FightResult.Loss },
            new() { Id = 485, TeamId = 478, FighterId = 222, FightResult = FightResult.Win },
            new() { Id = 486, TeamId = 479, FighterId = 2, FightResult = FightResult.Win },
            new() { Id = 487, TeamId = 480, FighterId = 45, FightResult = FightResult.Loss },
            new() { Id = 488, TeamId = 481, FighterId = 223, FightResult = FightResult.Win },
            new() { Id = 489, TeamId = 482, FighterId = 224, FightResult = FightResult.Loss },
            new() { Id = 490, TeamId = 483, FighterId = 9, FightResult = FightResult.Win },
            new() { Id = 491, TeamId = 484, FighterId = 211, FightResult = FightResult.Loss },
            new() { Id = 492, TeamId = 485, FighterId = 62, FightResult = FightResult.Win },
            new() { Id = 493, TeamId = 486, FighterId = 83, FightResult = FightResult.Loss },
            new() { Id = 494, TeamId = 487, FighterId = 217, FightResult = FightResult.Loss },
            new() { Id = 495, TeamId = 488, FighterId = 225, FightResult = FightResult.Win },
            new() { Id = 496, TeamId = 489, FighterId = 226, FightResult = FightResult.Win },
            new() { Id = 497, TeamId = 490, FighterId = 227, FightResult = FightResult.Loss },
            new() { Id = 498, TeamId = 491, FighterId = 21, FightResult = FightResult.Win },
            new() { Id = 499, TeamId = 492, FighterId = 228, FightResult = FightResult.Loss },
            new() { Id = 500, TeamId = 493, FighterId = 115, FightResult = FightResult.Win },
            new() { Id = 501, TeamId = 494, FighterId = 229, FightResult = FightResult.Loss },
            new() { Id = 502, TeamId = 495, FighterId = 152, FightResult = FightResult.Win },
            new() { Id = 503, TeamId = 496, FighterId = 230, FightResult = FightResult.Loss },
            new() { Id = 504, TeamId = 497, FighterId = 71, FightResult = FightResult.Loss },
            new() { Id = 505, TeamId = 498, FighterId = 231, FightResult = FightResult.Win },
            new() { Id = 506, TeamId = 499, FighterId = 96, FightResult = FightResult.Win },
            new() { Id = 507, TeamId = 500, FighterId = 232, FightResult = FightResult.Loss },

            // Prime 3: Street Fighter
            new() { Id = 508, TeamId = 501, FighterId = 222, FightResult = FightResult.Win },
            new() { Id = 509, TeamId = 502, FighterId = 233, FightResult = FightResult.Loss },
            new() { Id = 510, TeamId = 503, FighterId = 208, FightResult = FightResult.Loss },
            new() { Id = 511, TeamId = 504, FighterId = 234, FightResult = FightResult.Win },
            new() { Id = 512, TeamId = 505, FighterId = 235, FightResult = FightResult.Win },
            new() { Id = 513, TeamId = 506, FighterId = 209, FightResult = FightResult.Loss },
            new() { Id = 514, TeamId = 507, FighterId = 83, FightResult = FightResult.Win },
            new() { Id = 515, TeamId = 508, FighterId = 52, FightResult = FightResult.Loss },
            new() { Id = 516, TeamId = 509, FighterId = 236, FightResult = FightResult.Win },
            new() { Id = 517, TeamId = 510, FighterId = 237, FightResult = FightResult.Loss },
            new() { Id = 518, TeamId = 511, FighterId = 2, FightResult = FightResult.Win },
            new() { Id = 519, TeamId = 512, FighterId = 62, FightResult = FightResult.Loss },
            new() { Id = 520, TeamId = 513, FighterId = 238, FightResult = FightResult.Loss },
            new() { Id = 521, TeamId = 514, FighterId = 239, FightResult = FightResult.Win },
            new() { Id = 522, TeamId = 515, FighterId = 75, FightResult = FightResult.Loss },
            new() { Id = 523, TeamId = 516, FighterId = 152, FightResult = FightResult.Win },
            new() { Id = 524, TeamId = 517, FighterId = 240, FightResult = FightResult.Loss },
            new() { Id = 525, TeamId = 518, FighterId = 226, FightResult = FightResult.Win },
            new() { Id = 526, TeamId = 519, FighterId = 241, FightResult = FightResult.Win },
            new() { Id = 527, TeamId = 520, FighterId = 73, FightResult = FightResult.Loss },
            new() { Id = 528, TeamId = 521, FighterId = 242, FightResult = FightResult.Win },
            new() { Id = 529, TeamId = 522, FighterId = 243, FightResult = FightResult.Loss },
            new() { Id = 530, TeamId = 523, FighterId = 220, FightResult = FightResult.Win },
            new() { Id = 531, TeamId = 524, FighterId = 213, FightResult = FightResult.Loss },

            // Prime 4: Królestwo
            new() { Id = 532, TeamId = 525, FighterId = 103, FightResult = FightResult.Win },
            new() { Id = 533, TeamId = 526, FighterId = 208, FightResult = FightResult.Loss },
            new() { Id = 534, TeamId = 527, FighterId = 229, FightResult = FightResult.Win },
            new() { Id = 535, TeamId = 528, FighterId = 244, FightResult = FightResult.Loss },
            new() { Id = 536, TeamId = 529, FighterId = 225, FightResult = FightResult.Win },
            new() { Id = 537, TeamId = 530, FighterId = 245, FightResult = FightResult.Loss },
            new() { Id = 538, TeamId = 531, FighterId = 240, FightResult = FightResult.Loss },
            new() { Id = 539, TeamId = 532, FighterId = 52, FightResult = FightResult.Win },
            new() { Id = 540, TeamId = 533, FighterId = 246, FightResult = FightResult.Win },
            new() { Id = 541, TeamId = 534, FighterId = 82, FightResult = FightResult.Loss },
            new() { Id = 542, TeamId = 535, FighterId = 228, FightResult = FightResult.Win },
            new() { Id = 543, TeamId = 536, FighterId = 71, FightResult = FightResult.Loss },
            new() { Id = 544, TeamId = 537, FighterId = 247, FightResult = FightResult.Win },
            new() { Id = 545, TeamId = 538, FighterId = 248, FightResult = FightResult.Loss },
            new() { Id = 546, TeamId = 539, FighterId = 226, FightResult = FightResult.Loss },
            new() { Id = 547, TeamId = 540, FighterId = 220, FightResult = FightResult.Win },
            new() { Id = 548, TeamId = 541, FighterId = 66, FightResult = FightResult.Win },
            new() { Id = 549, TeamId = 542, FighterId = 39, FightResult = FightResult.Loss },
            new() { Id = 550, TeamId = 543, FighterId = 34, FightResult = FightResult.Win },
            new() { Id = 551, TeamId = 544, FighterId = 70, FightResult = FightResult.Loss },

            // Prime 5: Don Kasjo vs. Zadora
            new() { Id = 552, TeamId = 545, FighterId = 249, FightResult = FightResult.Win },
            new() { Id = 553, TeamId = 546, FighterId = 52, FightResult = FightResult.Loss },
            new() { Id = 554, TeamId = 547, FighterId = 250, FightResult = FightResult.Win },
            new() { Id = 555, TeamId = 548, FighterId = 251, FightResult = FightResult.Loss },
            new() { Id = 556, TeamId = 549, FighterId = 252, FightResult = FightResult.Loss },
            new() { Id = 557, TeamId = 550, FighterId = 253, FightResult = FightResult.Win },
            new() { Id = 558, TeamId = 551, FighterId = 232, FightResult = FightResult.Win },
            new() { Id = 559, TeamId = 552, FighterId = 254, FightResult = FightResult.Loss },
            new() { Id = 560, TeamId = 553, FighterId = 2, FightResult = FightResult.NoContest },
            new() { Id = 561, TeamId = 554, FighterId = 233, FightResult = FightResult.NoContest },
            new() { Id = 562, TeamId = 555, FighterId = 255, FightResult = FightResult.Win },
            new() { Id = 563, TeamId = 556, FighterId = 4, FightResult = FightResult.Loss },
            new() { Id = 564, TeamId = 557, FighterId = 246, FightResult = FightResult.Win },
            new() { Id = 565, TeamId = 558, FighterId = 214, FightResult = FightResult.Loss },
            new() { Id = 566, TeamId = 559, FighterId = 149, FightResult = FightResult.Win },
            new() { Id = 567, TeamId = 560, FighterId = 116, FightResult = FightResult.Loss },
            new() { Id = 568, TeamId = 561, FighterId = 226, FightResult = FightResult.Win },
            new() { Id = 569, TeamId = 562, FighterId = 217, FightResult = FightResult.Loss },
            new() { Id = 570, TeamId = 563, FighterId = 149, FightResult = FightResult.Win },
            new() { Id = 571, TeamId = 564, FighterId = 256, FightResult = FightResult.Loss },
            new() { Id = 572, TeamId = 565, FighterId = 34, FightResult = FightResult.Loss },
            new() { Id = 573, TeamId = 566, FighterId = 196, FightResult = FightResult.Win },

            // Prime 6: Premium
            new() { Id = 574, TeamId = 567, FighterId = 257, FightResult = FightResult.Win },
            new() { Id = 575, TeamId = 568, FighterId = 258, FightResult = FightResult.Loss },
            new() { Id = 576, TeamId = 569, FighterId = 250, FightResult = FightResult.Win },
            new() { Id = 577, TeamId = 570, FighterId = 259, FightResult = FightResult.Loss },
            new() { Id = 578, TeamId = 571, FighterId = 253, FightResult = FightResult.Win },
            new() { Id = 579, TeamId = 572, FighterId = 249, FightResult = FightResult.Loss },
            new() { Id = 580, TeamId = 573, FighterId = 260, FightResult = FightResult.Loss },
            new() { Id = 581, TeamId = 574, FighterId = 261, FightResult = FightResult.Win },
            new() { Id = 582, TeamId = 575, FighterId = 62, FightResult = FightResult.Loss },
            new() { Id = 583, TeamId = 576, FighterId = 262, FightResult = FightResult.Win },
            new() { Id = 584, TeamId = 577, FighterId = 232, FightResult = FightResult.Win },
            new() { Id = 585, TeamId = 578, FighterId = 263, FightResult = FightResult.Loss },
            new() { Id = 586, TeamId = 579, FighterId = 226, FightResult = FightResult.Win },
            new() { Id = 587, TeamId = 580, FighterId = 52, FightResult = FightResult.Loss },
            new() { Id = 588, TeamId = 581, FighterId = 9, FightResult = FightResult.Win },
            new() { Id = 589, TeamId = 581, FighterId = 264, FightResult = FightResult.Win },
            new() { Id = 590, TeamId = 582, FighterId = 265, FightResult = FightResult.Loss },
            new() { Id = 591, TeamId = 582, FighterId = 266, FightResult = FightResult.Loss },
            new() { Id = 592, TeamId = 583, FighterId = 233, FightResult = FightResult.Win },
            new() { Id = 593, TeamId = 584, FighterId = 228, FightResult = FightResult.Loss },
            new() { Id = 594, TeamId = 585, FighterId = 116, FightResult = FightResult.Win },
            new() { Id = 595, TeamId = 586, FighterId = 267, FightResult = FightResult.Loss },
            new() { Id = 596, TeamId = 587, FighterId = 34, FightResult = FightResult.Loss },
            new() { Id = 597, TeamId = 588, FighterId = 21, FightResult = FightResult.Win },

            // High League 1: Lexy vs. Natsu
            new() { Id = 598, TeamId = 589, FighterId = 158, FightResult = FightResult.Win },
            new() { Id = 599, TeamId = 590, FighterId = 268, FightResult = FightResult.Loss },
            new() { Id = 600, TeamId = 591, FighterId = 236, FightResult = FightResult.Win },
            new() { Id = 601, TeamId = 592, FighterId = 269, FightResult = FightResult.Loss },
            new() { Id = 602, TeamId = 593, FighterId = 270, FightResult = FightResult.Win },
            new() { Id = 603, TeamId = 594, FighterId = 271, FightResult = FightResult.Loss },
            new() { Id = 604, TeamId = 595, FighterId = 272, FightResult = FightResult.Loss },
            new() { Id = 605, TeamId = 596, FighterId = 189, FightResult = FightResult.Win },
            new() { Id = 606, TeamId = 597, FighterId = 273, FightResult = FightResult.Loss },
            new() { Id = 607, TeamId = 598, FighterId = 24, FightResult = FightResult.Loss },
            new() { Id = 608, TeamId = 599, FighterId = 118, FightResult = FightResult.Win },
            new() { Id = 609, TeamId = 600, FighterId = 47, FightResult = FightResult.Win },
            new() { Id = 610, TeamId = 601, FighterId = 62, FightResult = FightResult.Loss },
            new() { Id = 611, TeamId = 602, FighterId = 155, FightResult = FightResult.Loss },
            new() { Id = 612, TeamId = 603, FighterId = 49, FightResult = FightResult.Win },
            new() { Id = 613, TeamId = 604, FighterId = 274, FightResult = FightResult.Loss },
            new() { Id = 614, TeamId = 605, FighterId = 275, FightResult = FightResult.Win },

            // High League 2: pashaBiceps vs. Owca
            new() { Id = 615, TeamId = 606, FighterId = 276, FightResult = FightResult.Win },
            new() { Id = 616, TeamId = 607, FighterId = 233, FightResult = FightResult.Loss },
            new() { Id = 617, TeamId = 608, FighterId = 158, FightResult = FightResult.Win },
            new() { Id = 618, TeamId = 609, FighterId = 277, FightResult = FightResult.Loss },
            new() { Id = 619, TeamId = 610, FighterId = 278, FightResult = FightResult.Loss },
            new() { Id = 620, TeamId = 611, FighterId = 185, FightResult = FightResult.Win },
            new() { Id = 621, TeamId = 612, FighterId = 58, FightResult = FightResult.Loss },
            new() { Id = 622, TeamId = 613, FighterId = 279, FightResult = FightResult.Win },
            new() { Id = 623, TeamId = 614, FighterId = 53, FightResult = FightResult.Win },
            new() { Id = 624, TeamId = 615, FighterId = 236, FightResult = FightResult.Loss },
            new() { Id = 625, TeamId = 616, FighterId = 204, FightResult = FightResult.Win },
            new() { Id = 626, TeamId = 617, FighterId = 280, FightResult = FightResult.Loss },
            new() { Id = 627, TeamId = 618, FighterId = 274, FightResult = FightResult.Win },
            new() { Id = 628, TeamId = 619, FighterId = 125, FightResult = FightResult.Loss },
            new() { Id = 629, TeamId = 620, FighterId = 281, FightResult = FightResult.Win },
            new() { Id = 630, TeamId = 621, FighterId = 282, FightResult = FightResult.Loss },

            // High League 3: Alberto vs. Dubiel
            new() { Id = 631, TeamId = 622, FighterId = 268, FightResult = FightResult.Loss },
            new() { Id = 632, TeamId = 623, FighterId = 283, FightResult = FightResult.Win },
            new() { Id = 633, TeamId = 624, FighterId = 233, FightResult = FightResult.Win },
            new() { Id = 634, TeamId = 625, FighterId = 284, FightResult = FightResult.Loss },
            new() { Id = 635, TeamId = 626, FighterId = 270, FightResult = FightResult.Loss },
            new() { Id = 636, TeamId = 627, FighterId = 272, FightResult = FightResult.Win },
            new() { Id = 637, TeamId = 628, FighterId = 155, FightResult = FightResult.Win },
            new() { Id = 638, TeamId = 629, FighterId = 88, FightResult = FightResult.Loss },
            new() { Id = 639, TeamId = 630, FighterId = 58, FightResult = FightResult.Loss },
            new() { Id = 640, TeamId = 631, FighterId = 285, FightResult = FightResult.Win },
            new() { Id = 641, TeamId = 632, FighterId = 49, FightResult = FightResult.Win },
            new() { Id = 642, TeamId = 633, FighterId = 66, FightResult = FightResult.Loss },
            new() { Id = 643, TeamId = 634, FighterId = 286, FightResult = FightResult.Win },
            new() { Id = 644, TeamId = 635, FighterId = 287, FightResult = FightResult.Loss },
            new() { Id = 645, TeamId = 636, FighterId = 159, FightResult = FightResult.Win },
            new() { Id = 646, TeamId = 637, FighterId = 79, FightResult = FightResult.Loss },

            // High League 3: Extra
            new() { Id = 647, TeamId = 638, FighterId = 279, FightResult = FightResult.Loss },
            new() { Id = 648, TeamId = 639, FighterId = 288, FightResult = FightResult.Win },

            // High League 4: Natsu vs. Lexy 2
            new() { Id = 649, TeamId = 640, FighterId = 276, FightResult = FightResult.Win },
            new() { Id = 650, TeamId = 641, FighterId = 289, FightResult = FightResult.Loss },
            new() { Id = 651, TeamId = 642, FighterId = 290, FightResult = FightResult.Win },
            new() { Id = 652, TeamId = 643, FighterId = 291, FightResult = FightResult.Loss },
            new() { Id = 653, TeamId = 644, FighterId = 189, FightResult = FightResult.Win },
            new() { Id = 654, TeamId = 645, FighterId = 292, FightResult = FightResult.Loss },
            new() { Id = 655, TeamId = 646, FighterId = 158, FightResult = FightResult.Win },
            new() { Id = 656, TeamId = 647, FighterId = 95, FightResult = FightResult.Loss },
            new() { Id = 657, TeamId = 648, FighterId = 293, FightResult = FightResult.Win },
            new() { Id = 658, TeamId = 649, FighterId = 294, FightResult = FightResult.Loss },
            new() { Id = 659, TeamId = 650, FighterId = 25, FightResult = FightResult.Win },
            new() { Id = 660, TeamId = 651, FighterId = 284, FightResult = FightResult.Loss },
            new() { Id = 661, TeamId = 652, FighterId = 53, FightResult = FightResult.Win },
            new() { Id = 662, TeamId = 653, FighterId = 295, FightResult = FightResult.Loss },
            new() { Id = 663, TeamId = 654, FighterId = 296, FightResult = FightResult.Win },
            new() { Id = 664, TeamId = 655, FighterId = 279, FightResult = FightResult.Loss },
            new() { Id = 665, TeamId = 656, FighterId = 275, FightResult = FightResult.Loss },
            new() { Id = 666, TeamId = 657, FighterId = 274, FightResult = FightResult.Win },

            // High League 5: Alberto vs. Tybori
            new() { Id = 667, TeamId = 658, FighterId = 30, FightResult = FightResult.Loss },
            new() { Id = 668, TeamId = 659, FighterId = 297, FightResult = FightResult.Win },
            new() { Id = 669, TeamId = 660, FighterId = 298, FightResult = FightResult.Loss },
            new() { Id = 670, TeamId = 661, FighterId = 299, FightResult = FightResult.Win },
            new() { Id = 671, TeamId = 662, FighterId = 285, FightResult = FightResult.Win },
            new() { Id = 672, TeamId = 663, FighterId = 300, FightResult = FightResult.Loss },
            new() { Id = 673, TeamId = 664, FighterId = 301, FightResult = FightResult.Loss },
            new() { Id = 674, TeamId = 665, FighterId = 302, FightResult = FightResult.Win },
            new() { Id = 675, TeamId = 666, FighterId = 280, FightResult = FightResult.Win },
            new() { Id = 676, TeamId = 667, FighterId = 290, FightResult = FightResult.Loss },
            new() { Id = 677, TeamId = 668, FighterId = 293, FightResult = FightResult.Win },
            new() { Id = 678, TeamId = 669, FighterId = 303, FightResult = FightResult.Loss },
            new() { Id = 679, TeamId = 670, FighterId = 304, FightResult = FightResult.Win },
            new() { Id = 680, TeamId = 671, FighterId = 288, FightResult = FightResult.Loss },
            new() { Id = 681, TeamId = 672, FighterId = 94, FightResult = FightResult.Loss },
            new() { Id = 682, TeamId = 673, FighterId = 284, FightResult = FightResult.Win },
            new() { Id = 683, TeamId = 674, FighterId = 275, FightResult = FightResult.Loss },
            new() { Id = 684, TeamId = 675, FighterId = 125, FightResult = FightResult.Win },
            new() { Id = 685, TeamId = 676, FighterId = 159, FightResult = FightResult.Loss },
            new() { Id = 686, TeamId = 677, FighterId = 21, FightResult = FightResult.Win },

            // High League 6: pashaBiceps vs. Dubiel
            new() { Id = 687, TeamId = 678, FighterId = 93, FightResult = FightResult.Loss },
            new() { Id = 688, TeamId = 679, FighterId = 190, FightResult = FightResult.Win },
            new() { Id = 689, TeamId = 680, FighterId = 305, FightResult = FightResult.Win },
            new() { Id = 690, TeamId = 681, FighterId = 234, FightResult = FightResult.Loss },
            new() { Id = 691, TeamId = 682, FighterId = 67, FightResult = FightResult.Win },
            new() { Id = 692, TeamId = 683, FighterId = 306, FightResult = FightResult.Loss },
            new() { Id = 693, TeamId = 684, FighterId = 279, FightResult = FightResult.Loss },
            new() { Id = 694, TeamId = 685, FighterId = 21, FightResult = FightResult.Win },
            new() { Id = 695, TeamId = 686, FighterId = 276, FightResult = FightResult.Loss },
            new() { Id = 696, TeamId = 687, FighterId = 307, FightResult = FightResult.Win },
            new() { Id = 697, TeamId = 688, FighterId = 288, FightResult = FightResult.Win },
            new() { Id = 698, TeamId = 689, FighterId = 285, FightResult = FightResult.Loss },
            new() { Id = 699, TeamId = 690, FighterId = 56, FightResult = FightResult.Win },
            new() { Id = 700, TeamId = 691, FighterId = 149, FightResult = FightResult.Loss },
            new() { Id = 701, TeamId = 692, FighterId = 274, FightResult = FightResult.Win },
            new() { Id = 702, TeamId = 693, FighterId = 242, FightResult = FightResult.Loss },
            new() { Id = 703, TeamId = 694, FighterId = 281, FightResult = FightResult.Loss },
            new() { Id = 704, TeamId = 695, FighterId = 79, FightResult = FightResult.Win },

            // Clout MMA 1
            new() { Id = 705, TeamId = 696, FighterId = 306, FightResult = FightResult.Loss },
            new() { Id = 706, TeamId = 697, FighterId = 308, FightResult = FightResult.Win },
            new() { Id = 707, TeamId = 698, FighterId = 73, FightResult = FightResult.Loss },
            new() { Id = 708, TeamId = 699, FighterId = 297, FightResult = FightResult.Win },
            new() { Id = 709, TeamId = 700, FighterId = 309, FightResult = FightResult.Loss },
            new() { Id = 710, TeamId = 701, FighterId = 310, FightResult = FightResult.Win },
            new() { Id = 711, TeamId = 702, FighterId = 311, FightResult = FightResult.Win },
            new() { Id = 712, TeamId = 703, FighterId = 264, FightResult = FightResult.Loss },
            new() { Id = 713, TeamId = 704, FighterId = 276, FightResult = FightResult.Win },
            new() { Id = 714, TeamId = 705, FighterId = 312, FightResult = FightResult.Loss },
            new() { Id = 715, TeamId = 706, FighterId = 305, FightResult = FightResult.Loss },
            new() { Id = 716, TeamId = 707, FighterId = 313, FightResult = FightResult.Win },
            new() { Id = 717, TeamId = 708, FighterId = 314, FightResult = FightResult.Loss },
            new() { Id = 718, TeamId = 709, FighterId = 315, FightResult = FightResult.Win },
            new() { Id = 719, TeamId = 710, FighterId = 242, FightResult = FightResult.Win },
            new() { Id = 720, TeamId = 711, FighterId = 294, FightResult = FightResult.Loss },
            new() { Id = 721, TeamId = 712, FighterId = 208, FightResult = FightResult.Win },
            new() { Id = 722, TeamId = 713, FighterId = 316, FightResult = FightResult.Loss },
            new() { Id = 723, TeamId = 714, FighterId = 307, FightResult = FightResult.Win },
            new() { Id = 724, TeamId = 715, FighterId = 285, FightResult = FightResult.Loss },
            new() { Id = 725, TeamId = 716, FighterId = 317, FightResult = FightResult.Win },
            new() { Id = 726, TeamId = 717, FighterId = 318, FightResult = FightResult.Loss },
            new() { Id = 727, TeamId = 718, FighterId = 319, FightResult = FightResult.Loss },
            new() { Id = 728, TeamId = 719, FighterId = 320, FightResult = FightResult.Win },
            new() { Id = 729, TeamId = 720, FighterId = 321, FightResult = FightResult.Win },
            new() { Id = 730, TeamId = 721, FighterId = 56, FightResult = FightResult.Loss },

            // Clout MMA 2
            new() { Id = 731, TeamId = 722, FighterId = 308, FightResult = FightResult.Loss },
            new() { Id = 732, TeamId = 723, FighterId = 322, FightResult = FightResult.Win },
            new() { Id = 733, TeamId = 724, FighterId = 276, FightResult = FightResult.Win },
            new() { Id = 734, TeamId = 725, FighterId = 101, FightResult = FightResult.Loss },
            new() { Id = 735, TeamId = 726, FighterId = 122, FightResult = FightResult.Win },
            new() { Id = 736, TeamId = 727, FighterId = 323, FightResult = FightResult.Loss },
            new() { Id = 737, TeamId = 728, FighterId = 324, FightResult = FightResult.Loss },
            new() { Id = 738, TeamId = 729, FighterId = 325, FightResult = FightResult.Win },
            new() { Id = 739, TeamId = 730, FighterId = 56, FightResult = FightResult.Loss },
            new() { Id = 740, TeamId = 731, FighterId = 311, FightResult = FightResult.Win },
            new() { Id = 741, TeamId = 732, FighterId = 326, FightResult = FightResult.Win },
            new() { Id = 742, TeamId = 733, FighterId = 327, FightResult = FightResult.Loss },
            new() { Id = 743, TeamId = 733, FighterId = 328, FightResult = FightResult.Loss },
            new() { Id = 744, TeamId = 733, FighterId = 329, FightResult = FightResult.Loss },
            new() { Id = 745, TeamId = 733, FighterId = 330, FightResult = FightResult.Loss },
            new() { Id = 746, TeamId = 733, FighterId = 331, FightResult = FightResult.Loss },
            new() { Id = 747, TeamId = 733, FighterId = 332, FightResult = FightResult.Loss },
            new() { Id = 748, TeamId = 733, FighterId = 333, FightResult = FightResult.Loss },
            new() { Id = 749, TeamId = 733, FighterId = 334, FightResult = FightResult.Loss },
            new() { Id = 750, TeamId = 733, FighterId = 335, FightResult = FightResult.Loss },
            new() { Id = 751, TeamId = 733, FighterId = 336, FightResult = FightResult.Loss },
            new() { Id = 752, TeamId = 734, FighterId = 337, FightResult = FightResult.Win },
            new() { Id = 753, TeamId = 735, FighterId = 338, FightResult = FightResult.Loss },
            new() { Id = 754, TeamId = 736, FighterId = 317, FightResult = FightResult.Draw },
            new() { Id = 755, TeamId = 737, FighterId = 285, FightResult = FightResult.Draw },
            new() { Id = 756, TeamId = 738, FighterId = 307, FightResult = FightResult.Win },
            new() { Id = 757, TeamId = 739, FighterId = 340, FightResult = FightResult.Loss },
            new() { Id = 758, TeamId = 740, FighterId = 56, FightResult = FightResult.Loss },
            new() { Id = 759, TeamId = 741, FighterId = 208, FightResult = FightResult.Win },
            new() { Id = 760, TeamId = 742, FighterId = 341, FightResult = FightResult.Win },
            new() { Id = 761, TeamId = 743, FighterId = 279, FightResult = FightResult.Loss },
            new() { Id = 762, TeamId = 744, FighterId = 339, FightResult = FightResult.Win },
            new() { Id = 763, TeamId = 745, FighterId = 314, FightResult = FightResult.Loss },

            // FFF 1: Najman vs. Trybson
            new() { Id = 764, TeamId = 746, FighterId = 342, FightResult = FightResult.Loss },
            new() { Id = 765, TeamId = 747, FighterId = 343, FightResult = FightResult.Win },
            new() { Id = 766, TeamId = 748, FighterId = 344, FightResult = FightResult.Loss },
            new() { Id = 767, TeamId = 749, FighterId = 345, FightResult = FightResult.Win },
            new() { Id = 768, TeamId = 750, FighterId = 346, FightResult = FightResult.Loss },
            new() { Id = 769, TeamId = 751, FighterId = 347, FightResult = FightResult.Win },
            new() { Id = 770, TeamId = 752, FighterId = 348, FightResult = FightResult.Win },
            new() { Id = 771, TeamId = 753, FighterId = 349, FightResult = FightResult.Loss },
            new() { Id = 772, TeamId = 754, FighterId = 350, FightResult = FightResult.Win },
            new() { Id = 773, TeamId = 755, FighterId = 351, FightResult = FightResult.Loss },
            new() { Id = 774, TeamId = 756, FighterId = 352, FightResult = FightResult.Win },
            new() { Id = 775, TeamId = 757, FighterId = 289, FightResult = FightResult.Loss },
            new() { Id = 776, TeamId = 758, FighterId = 56, FightResult = FightResult.Loss },
            new() { Id = 777, TeamId = 759, FighterId = 254, FightResult = FightResult.Win },

            // FFF 2: Świerczewski vs. Greg Collins
            new() { Id = 778, TeamId = 760, FighterId = 353, FightResult = FightResult.Loss },
            new() { Id = 779, TeamId = 761, FighterId = 354, FightResult = FightResult.Win },
            new() { Id = 780, TeamId = 762, FighterId = 355, FightResult = FightResult.Win },
            new() { Id = 781, TeamId = 763, FighterId = 347, FightResult = FightResult.Loss },
            new() { Id = 782, TeamId = 764, FighterId = 350, FightResult = FightResult.Win },
            new() { Id = 783, TeamId = 765, FighterId = 356, FightResult = FightResult.Loss },
            new() { Id = 784, TeamId = 766, FighterId = 81, FightResult = FightResult.Win },
            new() { Id = 785, TeamId = 767, FighterId = 357, FightResult = FightResult.Loss },
            new() { Id = 786, TeamId = 768, FighterId = 254, FightResult = FightResult.Win },
            new() { Id = 787, TeamId = 769, FighterId = 358, FightResult = FightResult.Loss },
            new() { Id = 788, TeamId = 770, FighterId = 359, FightResult = FightResult.Loss },
            new() { Id = 789, TeamId = 771, FighterId = 360, FightResult = FightResult.Win },
            new() { Id = 790, TeamId = 772, FighterId = 351, FightResult = FightResult.Loss },
            new() { Id = 791, TeamId = 773, FighterId = 188, FightResult = FightResult.Win },

            // Bita Śmietanka 1
            new() { Id = 792, TeamId = 774, FighterId = 226, FightResult = FightResult.Win },
            new() { Id = 793, TeamId = 775, FighterId = 361, FightResult = FightResult.Loss },
            new() { Id = 794, TeamId = 776, FighterId = 362, FightResult = FightResult.Win },
            new() { Id = 795, TeamId = 777, FighterId = 363, FightResult = FightResult.Loss },
            new() { Id = 796, TeamId = 778, FighterId = 364, FightResult = FightResult.Win },
            new() { Id = 797, TeamId = 779, FighterId = 365, FightResult = FightResult.Loss },
            new() { Id = 798, TeamId = 780, FighterId = 366, FightResult = FightResult.Loss },
            new() { Id = 799, TeamId = 781, FighterId = 367, FightResult = FightResult.Win },
            new() { Id = 800, TeamId = 782, FighterId = 368, FightResult = FightResult.Loss },
            new() { Id = 801, TeamId = 783, FighterId = 369, FightResult = FightResult.Win },
            new() { Id = 802, TeamId = 784, FighterId = 370, FightResult = FightResult.Draw },
            new() { Id = 803, TeamId = 785, FighterId = 371, FightResult = FightResult.Draw },
            new() { Id = 804, TeamId = 786, FighterId = 127, FightResult = FightResult.Win },
            new() { Id = 805, TeamId = 787, FighterId = 372, FightResult = FightResult.Loss },

            // Bita Śmietanka 2
            new() { Id = 806, TeamId = 788, FighterId = 373, FightResult = FightResult.Loss },
            new() { Id = 807, TeamId = 789, FighterId = 361, FightResult = FightResult.Win },
            new() { Id = 808, TeamId = 790, FighterId = 374, FightResult = FightResult.Win },
            new() { Id = 809, TeamId = 791, FighterId = 375, FightResult = FightResult.Loss },
            new() { Id = 810, TeamId = 792, FighterId = 366, FightResult = FightResult.Win },
            new() { Id = 811, TeamId = 793, FighterId = 376, FightResult = FightResult.Loss },
            new() { Id = 812, TeamId = 794, FighterId = 377, FightResult = FightResult.Loss },
            new() { Id = 813, TeamId = 795, FighterId = 378, FightResult = FightResult.Win },
            new() { Id = 814, TeamId = 796, FighterId = 226, FightResult = FightResult.Win },
            new() { Id = 815, TeamId = 797, FighterId = 369, FightResult = FightResult.Loss },
            new() { Id = 816, TeamId = 798, FighterId = 368, FightResult = FightResult.Win },
            new() { Id = 817, TeamId = 799, FighterId = 379, FightResult = FightResult.Loss },
            new() { Id = 818, TeamId = 800, FighterId = 380, FightResult = FightResult.Win },
            new() { Id = 819, TeamId = 801, FighterId = 372, FightResult = FightResult.Loss },
            new() { Id = 820, TeamId = 802, FighterId = 381, FightResult = FightResult.Win },
            new() { Id = 821, TeamId = 803, FighterId = 382, FightResult = FightResult.Loss },
            new() { Id = 822, TeamId = 804, FighterId = 371, FightResult = FightResult.Win },
            new() { Id = 823, TeamId = 805, FighterId = 89, FightResult = FightResult.Loss },
            new() { Id = 824, TeamId = 806, FighterId = 127, FightResult = FightResult.Loss },
            new() { Id = 825, TeamId = 807, FighterId = 15, FightResult = FightResult.Win },

            // Elite Fighters 1: Muran vs. Warszawski Dresik
            new() { Id = 826, TeamId = 808, FighterId = 383, FightResult = FightResult.Win },
            new() { Id = 827, TeamId = 809, FighterId = 213, FightResult = FightResult.Loss },
            new() { Id = 828, TeamId = 810, FighterId = 384, FightResult = FightResult.Loss },
            new() { Id = 829, TeamId = 811, FighterId = 385, FightResult = FightResult.Win },
            new() { Id = 830, TeamId = 812, FighterId = 215, FightResult = FightResult.Loss },
            new() { Id = 831, TeamId = 813, FighterId = 386, FightResult = FightResult.Win },
            new() { Id = 832, TeamId = 814, FighterId = 233, FightResult = FightResult.Win },
            new() { Id = 833, TeamId = 815, FighterId = 387, FightResult = FightResult.Loss },
            new() { Id = 834, TeamId = 816, FighterId = 31, FightResult = FightResult.Win },
            new() { Id = 835, TeamId = 817, FighterId = 240, FightResult = FightResult.Loss },
            new() { Id = 836, TeamId = 818, FighterId = 388, FightResult = FightResult.Loss },
            new() { Id = 837, TeamId = 819, FighterId = 389, FightResult = FightResult.Win },
            new() { Id = 838, TeamId = 820, FighterId = 390, FightResult = FightResult.Win },
            new() { Id = 839, TeamId = 820, FighterId = 391, FightResult = FightResult.Win },
            new() { Id = 840, TeamId = 820, FighterId = 392, FightResult = FightResult.Win },
            new() { Id = 841, TeamId = 821, FighterId = 393, FightResult = FightResult.Loss },
            new() { Id = 842, TeamId = 822, FighterId = 394, FightResult = FightResult.Win },
            new() { Id = 843, TeamId = 823, FighterId = 395, FightResult = FightResult.Loss },
            new() { Id = 844, TeamId = 824, FighterId = 94, FightResult = FightResult.Win },
            new() { Id = 845, TeamId = 825, FighterId = 396, FightResult = FightResult.Loss },
            new() { Id = 846, TeamId = 826, FighterId = 94, FightResult = FightResult.Win },
            new() { Id = 847, TeamId = 827, FighterId = 45, FightResult = FightResult.Loss },

            // MMA-VIP 1: Najman vs. Złotówa
            new() { Id = 848, TeamId = 828, FighterId = 397, FightResult = FightResult.Win },
            new() { Id = 849, TeamId = 829, FighterId = 398, FightResult = FightResult.Loss },
            new() { Id = 850, TeamId = 830, FighterId = 399, FightResult = FightResult.Win },
            new() { Id = 851, TeamId = 831, FighterId = 400, FightResult = FightResult.Loss },
            new() { Id = 852, TeamId = 832, FighterId = 401, FightResult = FightResult.Win },
            new() { Id = 853, TeamId = 833, FighterId = 402, FightResult = FightResult.Loss },
            new() { Id = 854, TeamId = 834, FighterId = 403, FightResult = FightResult.Loss },
            new() { Id = 855, TeamId = 835, FighterId = 404, FightResult = FightResult.Win },
            new() { Id = 856, TeamId = 836, FighterId = 405, FightResult = FightResult.Win },
            new() { Id = 857, TeamId = 837, FighterId = 406, FightResult = FightResult.Loss },
            new() { Id = 858, TeamId = 838, FighterId = 208, FightResult = FightResult.Loss },
            new() { Id = 859, TeamId = 839, FighterId = 349, FightResult = FightResult.Win },
            new() { Id = 860, TeamId = 840, FighterId = 56, FightResult = FightResult.Loss },
            new() { Id = 861, TeamId = 841, FighterId = 37, FightResult = FightResult.Win },

            // MMA-VIP 2: Igrzyska Rozkminiaczy
            new() { Id = 862, TeamId = 842, FighterId = 406, FightResult = FightResult.Win },
            new() { Id = 863, TeamId = 843, FighterId = 407, FightResult = FightResult.Loss },
            new() { Id = 864, TeamId = 844, FighterId = 400, FightResult = FightResult.Loss },
            new() { Id = 865, TeamId = 845, FighterId = 408, FightResult = FightResult.Win },
            new() { Id = 866, TeamId = 846, FighterId = 250, FightResult = FightResult.Win },
            new() { Id = 867, TeamId = 847, FighterId = 409, FightResult = FightResult.Loss },
            new() { Id = 868, TeamId = 848, FighterId = 410, FightResult = FightResult.Loss },
            new() { Id = 869, TeamId = 849, FighterId = 411, FightResult = FightResult.Win },
            new() { Id = 870, TeamId = 850, FighterId = 399, FightResult = FightResult.Loss },
            new() { Id = 871, TeamId = 851, FighterId = 208, FightResult = FightResult.Win },
            new() { Id = 872, TeamId = 852, FighterId = 37, FightResult = FightResult.Win },
            new() { Id = 873, TeamId = 853, FighterId = 67, FightResult = FightResult.Loss },
            new() { Id = 874, TeamId = 854, FighterId = 412, FightResult = FightResult.Loss },
            new() { Id = 875, TeamId = 855, FighterId = 413, FightResult = FightResult.Win },
            new() { Id = 876, TeamId = 856, FighterId = 352, FightResult = FightResult.Win },
            new() { Id = 877, TeamId = 857, FighterId = 414, FightResult = FightResult.Loss },
            new() { Id = 878, TeamId = 858, FighterId = 415, FightResult = FightResult.Loss },
            new() { Id = 879, TeamId = 859, FighterId = 416, FightResult = FightResult.Win },

            // MMA-VIP 3: Galaktyka Osobliwości
            new() { Id = 880, TeamId = 860, FighterId = 338, FightResult = FightResult.Win },
            new() { Id = 881, TeamId = 861, FighterId = 417, FightResult = FightResult.Loss },
            new() { Id = 882, TeamId = 862, FighterId = 418, FightResult = FightResult.Loss },
            new() { Id = 883, TeamId = 863, FighterId = 419, FightResult = FightResult.Win },
            new() { Id = 884, TeamId = 864, FighterId = 420, FightResult = FightResult.Loss },
            new() { Id = 885, TeamId = 865, FighterId = 421, FightResult = FightResult.Win },
            new() { Id = 886, TeamId = 866, FighterId = 422, FightResult = FightResult.Win },
            new() { Id = 887, TeamId = 867, FighterId = 423, FightResult = FightResult.Loss },
            new() { Id = 888, TeamId = 868, FighterId = 424, FightResult = FightResult.Win },
            new() { Id = 889, TeamId = 869, FighterId = 425, FightResult = FightResult.Loss },
            new() { Id = 890, TeamId = 870, FighterId = 67, FightResult = FightResult.Loss },
            new() { Id = 891, TeamId = 871, FighterId = 426, FightResult = FightResult.Win },
            new() { Id = 892, TeamId = 872, FighterId = 153, FightResult = FightResult.Win },
            new() { Id = 893, TeamId = 873, FighterId = 427, FightResult = FightResult.Loss },
            new() { Id = 894, TeamId = 874, FighterId = 56, FightResult = FightResult.Win },
            new() { Id = 895, TeamId = 875, FighterId = 413, FightResult = FightResult.Loss },

            // MMA-VIP 4: Imperium Potępionych
            new() { Id = 896, TeamId = 876, FighterId = 428, FightResult = FightResult.Win },
            new() { Id = 897, TeamId = 877, FighterId = 429, FightResult = FightResult.Loss },
            new() { Id = 898, TeamId = 878, FighterId = 430, FightResult = FightResult.Win },
            new() { Id = 899, TeamId = 879, FighterId = 422, FightResult = FightResult.Loss },
            new() { Id = 900, TeamId = 880, FighterId = 423, FightResult = FightResult.Loss },
            new() { Id = 901, TeamId = 881, FighterId = 263, FightResult = FightResult.Win },
            new() { Id = 902, TeamId = 882, FighterId = 24, FightResult = FightResult.Loss },
            new() { Id = 903, TeamId = 883, FighterId = 431, FightResult = FightResult.Win },
            new() { Id = 904, TeamId = 884, FighterId = 415, FightResult = FightResult.Loss },
            new() { Id = 905, TeamId = 885, FighterId = 414, FightResult = FightResult.Win },
            new() { Id = 906, TeamId = 886, FighterId = 424, FightResult = FightResult.Loss },
            new() { Id = 907, TeamId = 887, FighterId = 419, FightResult = FightResult.Win },
            new() { Id = 908, TeamId = 888, FighterId = 153, FightResult = FightResult.Win },
            new() { Id = 909, TeamId = 889, FighterId = 250, FightResult = FightResult.Loss },
            new() { Id = 910, TeamId = 890, FighterId = 56, FightResult = FightResult.Win },
            new() { Id = 911, TeamId = 891, FighterId = 432, FightResult = FightResult.Loss }
        });
    }
}