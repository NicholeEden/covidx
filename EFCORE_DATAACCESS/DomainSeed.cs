using EFCORE_DATAACCESS.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace EFCORE_DATAACCESS
{
    public static class DomainSeed
    {
        #region City

        public static void SeedingCity(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<City>().HasData(
                new City { CityId = 1, CityName = "Gqeberha" });
        }

        #endregion City

        #region Suburb

        public static void SeedingSuburb(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Suburb>().HasData(
                new Suburb { SuburbId = 1, SuburbName = "Adcock Vale", PostalCode = "6001", CityId = 1 },
                new Suburb { SuburbId = 2, SuburbName = "Algoa Park", PostalCode = "6001", CityId = 1 },
                new Suburb { SuburbId = 3, SuburbName = "Arcadia", PostalCode = "6059", CityId = 1 },
                new Suburb { SuburbId = 4, SuburbName = "Aspen Heights", PostalCode = "6059", CityId = 1 },
                new Suburb { SuburbId = 5, SuburbName = "Ben Kamma", PostalCode = "6025", CityId = 1 },
                new Suburb { SuburbId = 6, SuburbName = "Bethelsdorp", PostalCode = "6059", CityId = 1 },
                new Suburb { SuburbId = 7, SuburbName = "Beverly Grove", PostalCode = "6070", CityId = 1 },
                new Suburb { SuburbId = 8, SuburbName = "Beverly Hills", PostalCode = "6020", CityId = 1 },
                new Suburb { SuburbId = 9, SuburbName = "Bloemendal", PostalCode = "6059", CityId = 1 },
                new Suburb { SuburbId = 10, SuburbName = "Bluewater BAY", PostalCode = "6210", CityId = 1 },
                new Suburb { SuburbId = 11, SuburbName = "Boast Village", PostalCode = "6200", CityId = 1 },
                new Suburb { SuburbId = 12, SuburbName = "Booysens Park", PostalCode = "6059", CityId = 1 },
                new Suburb { SuburbId = 13, SuburbName = "Bramhope", PostalCode = "6025", CityId = 1 },
                new Suburb { SuburbId = 14, SuburbName = "Brentwood Park", PostalCode = "6025", CityId = 1 },
                new Suburb { SuburbId = 15, SuburbName = "Bridgemead", PostalCode = "6025", CityId = 1 },
                new Suburb { SuburbId = 16, SuburbName = "Broadwood", PostalCode = "6070", CityId = 1 },
                new Suburb { SuburbId = 17, SuburbName = "Brymore", PostalCode = "6025", CityId = 1 },
                new Suburb { SuburbId = 18, SuburbName = "Cadles", PostalCode = "6001", CityId = 1 },
                new Suburb { SuburbId = 19, SuburbName = "Castle Hill", PostalCode = "6001", CityId = 1 },
                  new Suburb { SuburbId = 20, SuburbName = "Centralhil", PostalCode = "6001", CityId = 1 },

                new Suburb { SuburbId = 21, SuburbName = "Central", PostalCode = "6001", CityId = 1 },
                new Suburb { SuburbId = 22, SuburbName = "Charlo", PostalCode = "6070", CityId = 1 },
                new Suburb { SuburbId = 23, SuburbName = "Chatty", PostalCode = "6059", CityId = 1 },
                new Suburb { SuburbId = 24, SuburbName = "Cleary Park", PostalCode = "6059", CityId = 1 },
                new Suburb { SuburbId = 25, SuburbName = "Collen Glen", PostalCode = "6001", CityId = 1 },
                new Suburb { SuburbId = 26, SuburbName = "Cotswold", PostalCode = "6045", CityId = 1 },
                new Suburb { SuburbId = 27, SuburbName = "Cradock Place", PostalCode = "6001", CityId = 1 },
                new Suburb { SuburbId = 28, SuburbName = "Cradockplek", PostalCode = "6001", CityId = 1 },
                new Suburb { SuburbId = 29, SuburbName = "Craigbain", PostalCode = "6001", CityId = 1 },
                  new Suburb { SuburbId = 30, SuburbName = "Crestview", PostalCode = "6025", CityId = 1 },
                new Suburb { SuburbId = 31, SuburbName = "Dowerville", PostalCode = "6059", CityId = 1 },
                new Suburb { SuburbId = 32, SuburbName = "Emerald Hill", PostalCode = "6070", CityId = 1 },
                new Suburb { SuburbId = 33, SuburbName = "Essexvale", PostalCode = "6070", CityId = 1 },
                new Suburb { SuburbId = 34, SuburbName = "Fairview", PostalCode = "6070", CityId = 1 },
                new Suburb { SuburbId = 35, SuburbName = "Ferguson", PostalCode = "6045", CityId = 1 },
                new Suburb { SuburbId = 36, SuburbName = "Fernglen", PostalCode = "6045", CityId = 1 },
                new Suburb { SuburbId = 37, SuburbName = "Fernwood Park", PostalCode = "6059", CityId = 1 },
                new Suburb { SuburbId = 38, SuburbName = "Forest Hill", PostalCode = "6001", CityId = 1 },
                new Suburb { SuburbId = 39, SuburbName = "Framesby", PostalCode = "6045", CityId = 1 },
                  new Suburb { SuburbId = 40, SuburbName = "Francis Evatt Park", PostalCode = "6045", CityId = 1 },

                new Suburb { SuburbId = 41, SuburbName = "Gambleville", PostalCode = "6025", CityId = 1 },
                new Suburb { SuburbId = 42, SuburbName = "Gelvan Park", PostalCode = "6020", CityId = 1 },
                new Suburb { SuburbId = 43, SuburbName = "Gelvandale", PostalCode = "6020", CityId = 1 },
                new Suburb { SuburbId = 44, SuburbName = "Glen Hurd", PostalCode = "6045", CityId = 1 },
                new Suburb { SuburbId = 45, SuburbName = "Glen Kamma", PostalCode = "6025", CityId = 1 },
                new Suburb { SuburbId = 46, SuburbName = "Gledinningvale", PostalCode = "6001", CityId = 1 },
                new Suburb { SuburbId = 47, SuburbName = "Glenroy Park", PostalCode = "6025", CityId = 1 },
                new Suburb { SuburbId = 48, SuburbName = "Goldwater", PostalCode = "6070", CityId = 1 },
                new Suburb { SuburbId = 49, SuburbName = "Greenacres", PostalCode = "6045", CityId = 1 },
                  new Suburb { SuburbId = 50, SuburbName = "Greenbushes", PostalCode = "6001", CityId = 1 },
                new Suburb { SuburbId = 51, SuburbName = "Greenshields Park", PostalCode = "6070", CityId = 1 },
                new Suburb { SuburbId = 52, SuburbName = "Heath Park", PostalCode = "6059", CityId = 1 },
                new Suburb { SuburbId = 53, SuburbName = "Helenvale", PostalCode = "6020", CityId = 1 },
                new Suburb { SuburbId = 54, SuburbName = "Hillside", PostalCode = "6059", CityId = 1 },
                new Suburb { SuburbId = 55, SuburbName = "Holland Park", PostalCode = "6001", CityId = 1 },
                new Suburb { SuburbId = 56, SuburbName = "Humerail", PostalCode = "6001", CityId = 1 },
                new Suburb { SuburbId = 57, SuburbName = "Humewood", PostalCode = "6001", CityId = 1 },
                new Suburb { SuburbId = 58, SuburbName = "Hunters Retreat", PostalCode = "6025", CityId = 1 },
                new Suburb { SuburbId = 59, SuburbName = "Kabega", PostalCode = "6025", CityId = 1 },
                new Suburb { SuburbId = 60, SuburbName = "Kamma Creek", PostalCode = "6070", CityId = 1 },

                new Suburb { SuburbId = 61, SuburbName = "Kamma Park", PostalCode = "6070", CityId = 1 },
                new Suburb { SuburbId = 62, SuburbName = "Kamma Ridge", PostalCode = "6025", CityId = 1 },
                new Suburb { SuburbId = 63, SuburbName = "Kamvelihle", PostalCode = "6211", CityId = 1 },
                new Suburb { SuburbId = 64, SuburbName = "Kemsley Park", PostalCode = "6001", CityId = 1 },
                new Suburb { SuburbId = 65, SuburbName = "Kensington", PostalCode = "6001", CityId = 1 },
                new Suburb { SuburbId = 66, SuburbName = "Korsten", PostalCode = "6020", CityId = 1 },
                new Suburb { SuburbId = 67, SuburbName = "Kunene Park", PostalCode = "6025", CityId = 1 },
                new Suburb { SuburbId = 68, SuburbName = "Kwaford", PostalCode = "6200", CityId = 1 },
                new Suburb { SuburbId = 69, SuburbName = "Kwazakhele", PostalCode = "6205", CityId = 1 },
                  new Suburb { SuburbId = 70, SuburbName = "Linkside", PostalCode = "6001", CityId = 1 },

                  new Suburb { SuburbId = 71, SuburbName = "Linton Grange", PostalCode = "6025", CityId = 1 },
                new Suburb { SuburbId = 72, SuburbName = "Listerwood", PostalCode = "6001", CityId = 1 },
                new Suburb { SuburbId = 73, SuburbName = "Lorraine", PostalCode = "6070", CityId = 1 },
                new Suburb { SuburbId = 74, SuburbName = "Lorraine Manor", PostalCode = "6070", CityId = 1 },
                new Suburb { SuburbId = 75, SuburbName = "Lovemore Heights", PostalCode = "6070", CityId = 1 },
                new Suburb { SuburbId = 76, SuburbName = "Lovemore Park", PostalCode = "6070", CityId = 1 },
                new Suburb { SuburbId = 77, SuburbName = "Macleanville", PostalCode = "6001", CityId = 1 },
                new Suburb { SuburbId = 78, SuburbName = "Malabar", PostalCode = "6020", CityId = 1 },
                new Suburb { SuburbId = 79, SuburbName = "Mangold Park", PostalCode = "6070", CityId = 1 },
                new Suburb { SuburbId = 80, SuburbName = "Mcnamee Village", PostalCode = "6200", CityId = 1 },

                new Suburb { SuburbId = 81, SuburbName = "Mill Park", PostalCode = "6001", CityId = 1 },
                new Suburb { SuburbId = 82, SuburbName = "Millard Grange", PostalCode = "6001", CityId = 1 },
                new Suburb { SuburbId = 83, SuburbName = "Miramar", PostalCode = "6070", CityId = 1 },
                new Suburb { SuburbId = 84, SuburbName = "Missionvale", PostalCode = "6059", CityId = 1 },
                new Suburb { SuburbId = 85, SuburbName = "Moregrove", PostalCode = "6025", CityId = 1 },
                new Suburb { SuburbId = 86, SuburbName = "Morningside", PostalCode = "6025", CityId = 1 },
                new Suburb { SuburbId = 87, SuburbName = "Motherwell", PostalCode = "6001", CityId = 1 },
                new Suburb { SuburbId = 88, SuburbName = "Mount Croix", PostalCode = "6001", CityId = 1 },
                new Suburb { SuburbId = 89, SuburbName = "Mount Pleasant", PostalCode = "6070", CityId = 1 },
                new Suburb { SuburbId = 90, SuburbName = "Neave", PostalCode = "6001", CityId = 1 },

                 new Suburb { SuburbId = 91, SuburbName = "New Brighton", PostalCode = "6200", CityId = 1 },
                new Suburb { SuburbId = 92, SuburbName = "Newton Park", PostalCode = "6045", CityId = 1 },
                new Suburb { SuburbId = 93, SuburbName = "Normanville", PostalCode = "6059", CityId = 1 },
                new Suburb { SuburbId = 94, SuburbName = "North End", PostalCode = "6001", CityId = 1 },
                new Suburb { SuburbId = 95, SuburbName = "Palm Ridge", PostalCode = "6059", CityId = 1 },
                new Suburb { SuburbId = 96, SuburbName = "Pari Park", PostalCode = "6070", CityId = 1 },
                new Suburb { SuburbId = 97, SuburbName = "Park Drive", PostalCode = "6001", CityId = 1 },
                new Suburb { SuburbId = 98, SuburbName = "Parkside", PostalCode = "6020", CityId = 1 },
                new Suburb { SuburbId = 99, SuburbName = "Parsons Vlei", PostalCode = "6025", CityId = 1 },
                new Suburb { SuburbId = 100, SuburbName = "Parsons Hill", PostalCode = "6001", CityId = 1 },

                new Suburb { SuburbId = 101, SuburbName = "Perridgevale", PostalCode = "6001", CityId = 1 },
                new Suburb { SuburbId = 102, SuburbName = "Pinegrove", PostalCode = "6070", CityId = 1 },
                new Suburb { SuburbId = 103, SuburbName = "Providentia", PostalCode = "6070", CityId = 1 },
                new Suburb { SuburbId = 104, SuburbName = "Redhouse", PostalCode = "6201", CityId = 1 },
                new Suburb { SuburbId = 105, SuburbName = "Retiefville", PostalCode = "6001", CityId = 1 },
                new Suburb { SuburbId = 106, SuburbName = "Richmond Hill", PostalCode = "6001", CityId = 1 },
                new Suburb { SuburbId = 107, SuburbName = "Richmond Park", PostalCode = "6001", CityId = 1 },
                new Suburb { SuburbId = 108, SuburbName = "Rowallan Park", PostalCode = "6025", CityId = 1 },
                new Suburb { SuburbId = 109, SuburbName = "Rufanevale", PostalCode = "6001", CityId = 1 },
                new Suburb { SuburbId = 110, SuburbName = "Salisbury Park", PostalCode = "6070", CityId = 1 },

                new Suburb { SuburbId = 111, SuburbName = "Salsoneville", PostalCode = "6059", CityId = 1 },
                new Suburb { SuburbId = 112, SuburbName = "Salt Lake", PostalCode = "6059", CityId = 1 },
                new Suburb { SuburbId = 113, SuburbName = "Saltville", PostalCode = "6059", CityId = 1 },
                new Suburb { SuburbId = 114, SuburbName = "Sanctor", PostalCode = "6059", CityId = 1 },
                new Suburb { SuburbId = 115, SuburbName = "Schauderville", PostalCode = "6020", CityId = 1 },
                new Suburb { SuburbId = 116, SuburbName = "Sea View", PostalCode = "6070", CityId = 1 },
                new Suburb { SuburbId = 117, SuburbName = "Sherwood", PostalCode = "6025", CityId = 1 },
                new Suburb { SuburbId = 118, SuburbName = "Sidwell", PostalCode = "6001", CityId = 1 },
                new Suburb { SuburbId = 119, SuburbName = "South End", PostalCode = "6001", CityId = 1 },
                new Suburb { SuburbId = 120, SuburbName = "Springdale", PostalCode = "6020", CityId = 1 },

                 new Suburb { SuburbId = 121, SuburbName = "Springfield", PostalCode = "6070", CityId = 1 },
                new Suburb { SuburbId = 122, SuburbName = "ST Georges", PostalCode = "6001", CityId = 1 },
                new Suburb { SuburbId = 123, SuburbName = "Stella Londt Park", PostalCode = "6045", CityId = 1 },
                new Suburb { SuburbId = 124, SuburbName = "Steytler", PostalCode = "6001", CityId = 1 },
                new Suburb { SuburbId = 125, SuburbName = "Struandale", PostalCode = "6001", CityId = 1 },
                new Suburb { SuburbId = 126, SuburbName = "Summerstrand", PostalCode = "6001", CityId = 1 },
                new Suburb { SuburbId = 127, SuburbName = "Summerwood", PostalCode = "6001", CityId = 1 },
                new Suburb { SuburbId = 128, SuburbName = "Sunridge Park", PostalCode = "6045", CityId = 1 },
                new Suburb { SuburbId = 129, SuburbName = "Swartkops", PostalCode = "6210", CityId = 1 },
                new Suburb { SuburbId = 130, SuburbName = "Sydenham", PostalCode = "6001", CityId = 1 },

                new Suburb { SuburbId = 131, SuburbName = "Taybank", PostalCode = "6025", CityId = 1 },
                new Suburb { SuburbId = 132, SuburbName = "Theescombe", PostalCode = "6070", CityId = 1 },
                new Suburb { SuburbId = 133, SuburbName = "Timothy Valley", PostalCode = "6059", CityId = 1 },
                new Suburb { SuburbId = 134, SuburbName = "Treehaven", PostalCode = "6025", CityId = 1 },
                new Suburb { SuburbId = 135, SuburbName = "Trevolen", PostalCode = "6070", CityId = 1 },
                new Suburb { SuburbId = 136, SuburbName = "Vikingvale", PostalCode = "6025", CityId = 1 },
                new Suburb { SuburbId = 137, SuburbName = "Walmer", PostalCode = "6070", CityId = 1 },
                new Suburb { SuburbId = 138, SuburbName = "Walmer Downs", PostalCode = "6070", CityId = 1 },
                new Suburb { SuburbId = 139, SuburbName = "Walmer Heights", PostalCode = "6070", CityId = 1 },
                new Suburb { SuburbId = 140, SuburbName = "Wells Estate", PostalCode = "6211", CityId = 1 },

                  new Suburb { SuburbId = 141, SuburbName = "Westering", PostalCode = "6025", CityId = 1 },
                  new Suburb { SuburbId = 142, SuburbName = "Westview", PostalCode = "6045", CityId = 1 },
                    new Suburb { SuburbId = 143, SuburbName = "Weybridge Park", PostalCode = "6070", CityId = 1 },
                  new Suburb { SuburbId = 144, SuburbName = "Woodlands", PostalCode = "6070", CityId = 1 },
                   new Suburb { SuburbId = 145, SuburbName = "Woolhope", PostalCode = "6020", CityId = 1 },
                  new Suburb { SuburbId = 146, SuburbName = "Young Park", PostalCode = "6001", CityId = 1 },
                  new Suburb { SuburbId = 147, SuburbName = "Zwide", PostalCode = "6201", CityId = 1 }

                );
        }

        #endregion Suburb

        #region MedicalAidScheme

        public static void SeedingMedicalAidScheme(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MedicalAidScheme>().HasData(
                new MedicalAidScheme { MedicalAidSchemeId = 1, Description = "BestMed" },
                new MedicalAidScheme { MedicalAidSchemeId = 2, Description = "Bonitas" },
                new MedicalAidScheme { MedicalAidSchemeId = 3, Description = "Discovery Health" }
                 );
        }

        #endregion MedicalAidScheme

        #region MedicalAidPlan

        public static void SeedingMedicalAidPlan(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MedicalAidPlan>().HasData(
                 new MedicalAidPlan { MedicalAidPlanId = 1, Description = "Beat 1", MedicalAidSchemeId = 1 },
                new MedicalAidPlan { MedicalAidPlanId = 2, Description = "Beat 2", MedicalAidSchemeId = 1 },
                new MedicalAidPlan { MedicalAidPlanId = 3, Description = "Beat 3", MedicalAidSchemeId = 1 },
                new MedicalAidPlan { MedicalAidPlanId = 4, Description = "Beat 4", MedicalAidSchemeId = 1 },
                new MedicalAidPlan { MedicalAidPlanId = 5, Description = "Pulse 1", MedicalAidSchemeId = 1 },
                new MedicalAidPlan { MedicalAidPlanId = 6, Description = "Pulse 2", MedicalAidSchemeId = 1 },
                new MedicalAidPlan { MedicalAidPlanId = 7, Description = "Pace 1", MedicalAidSchemeId = 1 },
                new MedicalAidPlan { MedicalAidPlanId = 8, Description = "Pace 2", MedicalAidSchemeId = 1 },
                new MedicalAidPlan { MedicalAidPlanId = 9, Description = "Pace 3", MedicalAidSchemeId = 1 },
                new MedicalAidPlan { MedicalAidPlanId = 10, Description = "Pace 4", MedicalAidSchemeId = 1 },

                new MedicalAidPlan { MedicalAidPlanId = 11, Description = "BonStart", MedicalAidSchemeId = 2 },
                new MedicalAidPlan { MedicalAidPlanId = 12, Description = "Primary", MedicalAidSchemeId = 2 },
                new MedicalAidPlan { MedicalAidPlanId = 13, Description = "Primary Select", MedicalAidSchemeId = 2 },
                new MedicalAidPlan { MedicalAidPlanId = 14, Description = "Standard", MedicalAidSchemeId = 2 },
                new MedicalAidPlan { MedicalAidPlanId = 15, Description = "Standard Select", MedicalAidSchemeId = 2 },
               new MedicalAidPlan { MedicalAidPlanId = 16, Description = "BonFit Select", MedicalAidSchemeId = 2 },
                new MedicalAidPlan { MedicalAidPlanId = 17, Description = "BonSave", MedicalAidSchemeId = 2 },
                 new MedicalAidPlan { MedicalAidPlanId = 18, Description = "BonComplete", MedicalAidSchemeId = 2 },
                  new MedicalAidPlan { MedicalAidPlanId = 19, Description = "BonClassic", MedicalAidSchemeId = 2 },
                   new MedicalAidPlan { MedicalAidPlanId = 20, Description = "BonFitComprehensive", MedicalAidSchemeId = 2 },
                    new MedicalAidPlan { MedicalAidPlanId = 21, Description = "Hospital Standard", MedicalAidSchemeId = 2 },
                     new MedicalAidPlan { MedicalAidPlanId = 22, Description = "BonEssential", MedicalAidSchemeId = 2 },
                      new MedicalAidPlan { MedicalAidPlanId = 23, Description = "BonEssentialSelect", MedicalAidSchemeId = 2 },
                       new MedicalAidPlan { MedicalAidPlanId = 24, Description = "BonCap", MedicalAidSchemeId = 2 },

                          new MedicalAidPlan { MedicalAidPlanId = 25, Description = "Executive", MedicalAidSchemeId = 3 },
                          new MedicalAidPlan { MedicalAidPlanId = 26, Description = "Classic Comprehensive", MedicalAidSchemeId = 3 },
                          new MedicalAidPlan { MedicalAidPlanId = 27, Description = "Classic Data Comprehensive", MedicalAidSchemeId = 3 },
                          new MedicalAidPlan { MedicalAidPlanId = 28, Description = "Classic Smart Comprehensive", MedicalAidSchemeId = 3 },
                           new MedicalAidPlan { MedicalAidPlanId = 29, Description = "Essential Comprehensive", MedicalAidSchemeId = 3 },
                            new MedicalAidPlan { MedicalAidPlanId = 30, Description = "Essential Data", MedicalAidSchemeId = 3 },
                             new MedicalAidPlan { MedicalAidPlanId = 31, Description = "Classic Priority", MedicalAidSchemeId = 3 },
                              new MedicalAidPlan { MedicalAidPlanId = 32, Description = "Essential Priority", MedicalAidSchemeId = 3 },

                               new MedicalAidPlan { MedicalAidPlanId = 33, Description = "Classic Saver", MedicalAidSchemeId = 3 },
                            new MedicalAidPlan { MedicalAidPlanId = 34, Description = "Classic Delta Saver", MedicalAidSchemeId = 3 },
                             new MedicalAidPlan { MedicalAidPlanId = 35, Description = "Essential Saver", MedicalAidSchemeId = 3 },
                              new MedicalAidPlan { MedicalAidPlanId = 36, Description = "Essential Delta Saver", MedicalAidSchemeId = 3 },

                                new MedicalAidPlan { MedicalAidPlanId = 37, Description = "Coastal Saver", MedicalAidSchemeId = 3 },
                            new MedicalAidPlan { MedicalAidPlanId = 38, Description = "Classic Smart", MedicalAidSchemeId = 3 },
                             new MedicalAidPlan { MedicalAidPlanId = 39, Description = "Essential Smart", MedicalAidSchemeId = 3 },
                              new MedicalAidPlan { MedicalAidPlanId = 40, Description = "Classic Core", MedicalAidSchemeId = 3 },

                                new MedicalAidPlan { MedicalAidPlanId = 41, Description = "Classic Delta Core", MedicalAidSchemeId = 3 },
                            new MedicalAidPlan { MedicalAidPlanId = 42, Description = "Essential Core", MedicalAidSchemeId = 3 },
                             new MedicalAidPlan { MedicalAidPlanId = 43, Description = "Essential Delta Core", MedicalAidSchemeId = 3 },
                              new MedicalAidPlan { MedicalAidPlanId = 44, Description = "Coastal Core", MedicalAidSchemeId = 3 },
                              new MedicalAidPlan { MedicalAidPlanId = 45, Description = "Keycare Plus", MedicalAidSchemeId = 3 },
                             new MedicalAidPlan { MedicalAidPlanId = 46, Description = "Keycare Smart", MedicalAidSchemeId = 3 },
                              new MedicalAidPlan { MedicalAidPlanId = 47, Description = "Keycare Core", MedicalAidSchemeId = 3 }

                );
        }

        #endregion MedicalAidPlan

        #region DependentType

        public static void SeedingDependentType(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DependentType>().HasData(
                new DependentType { DependentTypeId = 1001, Description = "Spouse" },
                 new DependentType { DependentTypeId = 1002, Description = "Child" },
                  new DependentType { DependentTypeId = 1003, Description = "Parent" },
                  new DependentType { DependentTypeId = 1004, Description = "Grandparent" },
                  new DependentType { DependentTypeId = 1005, Description = "Cousin" },
                  new DependentType { DependentTypeId = 1006, Description = "Sibling" },
                   new DependentType { DependentTypeId = 1007, Description = "Grandchild" }
                 );
        }

        #endregion DependentType

        #region Patients

        public static void SeedingPatients(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Patient>().HasData(
                new Patient
                {
                    PatientId = 1,
                    Idnumber = "5503180225083",
                    Dob = Convert.ToDateTime("1955/03/18"),
                    FirstName = "Charmaine",
                    LastName = "Meintjies",
                    MobileNumber = "0832458796",
                    AddressLine1 = "19 Admirality Way",
                    SuburbId = 126,
                    MedicalAidStatus = true
                    ,
                    MedicalAidPlanId = 8,
                    MedicalAidNo = "285465885",
                    PersonResponsible = "Charmaine Meintjies",
                    DependencyCode = "00",
                    UserID = "03cec2e5-888a-4a7c-a435-03eb22b0fbe6",
                    Gender = CovidEnums.Gender.Female
                },
                 new Patient
                 {
                     PatientId = 2,
                     Idnumber = "8012010225083",
                     Dob = Convert.ToDateTime("1980/12/01"),
                     FirstName = "Jacob",
                     LastName = "Moloi",
                     MobileNumber = "0822458796",
                     AddressLine1 = "24 7th Avenue",
                     SuburbId = 127,
                     MedicalAidStatus = false,
                     MedicalAidPlanId = null,
                     PersonResponsible = "Jacob Moloi",
                     UserID = "4021c065-e9dc-4eac-a55a-c4da9aa92ff3",
                     Gender = CovidEnums.Gender.Male
                 },
                  new Patient
                  {
                      PatientId = 3,
                      Idnumber = "8002200225083",
                      Dob = Convert.ToDateTime("1980/02/20"),
                      FirstName = "David",
                      LastName = "Greeff",
                      MobileNumber = "0712458796",
                      AddressLine1 = "1 Harbor Cottages",
                      AddressLine2 = "Sayre Crescent",
                      SuburbId = 56,
                      MedicalAidStatus = false,
                      MedicalAidPlanId = null,
                      PersonResponsible = "David Greeff",
                      UserID = "c6b10bd1-3b3d-471d-bc80-6124281b0ac1",
                      Gender = CovidEnums.Gender.Male
                  },

                    new Patient
                    {
                        PatientId = 4,
                        Idnumber = "7606030225083",
                        Dob = Convert.ToDateTime("1976/06/03"),
                        FirstName = "Kopano",
                        LastName = "Sithole",
                        MobileNumber = "0722458796",
                        AddressLine1 = "27 Aspen Complex",
                        AddressLine2 = "La Roche Drive",
                        SuburbId = 57,
                        MedicalAidStatus = false,
                        MedicalAidPlanId = null,
                        PersonResponsible = "Kopano Sithole",
                        UserID = "e36685da-9d7e-4caf-8cb8-b51962676845",
                        Gender = CovidEnums.Gender.Male
                    },

                        new Patient
                        {
                            PatientId = 5,
                            Idnumber = "8509020225083",
                            Dob = Convert.ToDateTime("1985/09/02"),
                            FirstName = "Karien",
                            LastName = "Momberg",
                            MobileNumber = "0732458796",
                            AddressLine1 = "6 Rubin Crescent",
                            SuburbId = 126,
                            MedicalAidStatus = false,
                            MedicalAidPlanId = null,
                            PersonResponsible = "Karien Momberg",
                            UserID = "67395a1f-9011-4a3d-8c07-efec7d97b240",
                            Gender = CovidEnums.Gender.Female
                        },
                          new Patient
                          {
                              PatientId = 6,
                              Idnumber = "7512020225083",
                              Dob = Convert.ToDateTime("1975/12/02"),
                              FirstName = "Felicity",
                              LastName = "Daniels",
                              MobileNumber = "0612458796",
                              AddressLine1 = "28 7th Avenue",
                              SuburbId = 127,
                              MedicalAidStatus = false,
                              MedicalAidPlanId = null,
                              PersonResponsible = "Felicity Daniels",
                              UserID = "391f693d-644d-4935-95ae-c8e50062b987",
                              Gender = CovidEnums.Gender.Female
                          },

                            new Patient
                            {
                                PatientId = 7,
                                Idnumber = "6008090225083",
                                Dob = Convert.ToDateTime("1960/08/09"),
                                FirstName = "Errol",
                                LastName = "Pieterse",
                                MobileNumber = "0612458796",
                                AddressLine1 = "37 The Beaches",
                                AddressLine2 = "Beach Road",
                                SuburbId = 56,
                                MedicalAidStatus = false,
                                MedicalAidPlanId = null,
                                PersonResponsible = "Errol Pieterse",
                                UserID = "233ca6e9-9697-4f03-9b01-d20e4db76b41",
                                Gender = CovidEnums.Gender.Male
                            },

                              new Patient
                              {
                                  PatientId = 8,
                                  Idnumber = "6412120225083",
                                  Dob = Convert.ToDateTime("1964/12/12"),
                                  FirstName = "Alyce",
                                  LastName = "Morapedi",
                                  MobileNumber = "0632458796",
                                  AddressLine1 = "12 Marshall Road",
                                  SuburbId = 57,
                                  MedicalAidStatus = true,
                                  MedicalAidPlanId = 17,
                                  MedicalAidNo = "395465885",
                                  DependencyCode = "00",
                                  PersonResponsible = "Alyce Morapedi",
                                  UserID = "1320196b-a77c-429c-b10e-bd2260e3979c",
                                  Gender = CovidEnums.Gender.Female
                              },
                                 new Patient
                                 {
                                     PatientId = 9,
                                     Idnumber = "8302090225083",
                                     Dob = Convert.ToDateTime("1983/02/20"),
                                     FirstName = "Asha",
                                     LastName = "Sharma",
                                     MobileNumber = "0812458796",
                                     AddressLine1 = "13 Congo Avenue",
                                     SuburbId = 84,
                                     MedicalAidStatus = true,
                                     MedicalAidPlanId = 44,
                                     MedicalAidNo = "175465885",
                                     DependencyCode = "00",
                                     PersonResponsible = "Asha Sharma",
                                     UserID = "def67f92-1208-48d3-a001-fd66ed0ed827",
                                     Gender = CovidEnums.Gender.Female
                                 },
                                   new Patient
                                   {
                                       PatientId = 10,
                                       Idnumber = "5008100225083",
                                       Dob = Convert.ToDateTime("1950/08/10"),
                                       FirstName = "Carlos",
                                       LastName = "Perestrelo",
                                       MobileNumber = "0842458796",
                                       AddressLine1 = "29 Peace Street",
                                       SuburbId = 84,
                                       MedicalAidStatus = false,
                                       MedicalAidPlanId = null,
                                       PersonResponsible = "Carlos Perestrelo",
                                       UserID = "42412d47-3da8-4e21-beef-83555c3a7186",
                                       Gender = CovidEnums.Gender.Male
                                   },
                                    new Patient
                                    {
                                        PatientId = 11,
                                        Idnumber = "7112150225083",
                                        Dob = Convert.ToDateTime("1971/12/15"),
                                        FirstName = "Kabelo",
                                        LastName = "Padi",
                                        MobileNumber = "0742458796",
                                        AddressLine1 = "7 Jacks Road",
                                        SuburbId = 84,
                                        MedicalAidStatus = false,
                                        PersonResponsible = "Kabelo Padi",
                                        MedicalAidPlanId = null,
                                        UserID = "30fb49a6-9b10-468b-9181-457568111ae1",
                                        Gender = CovidEnums.Gender.Male
                                    },
                                     new Patient
                                     {
                                         PatientId = 12,
                                         Idnumber = "9110120225083",
                                         Dob = Convert.ToDateTime("1991/10/12"),
                                         FirstName = "Pulane",
                                         LastName = "Masemola",
                                         MobileNumber = "0642458796",
                                         AddressLine1 = "45 Columbia Crescent",
                                         SuburbId = 84,
                                         MedicalAidStatus = true,
                                         MedicalAidPlanId = 1,
                                         MedicalAidNo = "465465885",
                                         DependencyCode = "00",
                                         PersonResponsible = "Pulane Masemola",
                                         UserID = "bc6d851f-4321-4b32-86ec-6a305f3d77bb",
                                         Gender = CovidEnums.Gender.Female
                                     }

                 );
        }

        #endregion Patients

        #region Dependents

        public static void SeedingDependents(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Dependent>().HasData(
              new Dependent
              {
                  DependentId = 91,
                  MainMemberId = 1,
                  FirstName = "Dalene",
                  LastName = "Meintjies",
                  MobileNumber = "0832458796",
                  AddressLine1 = "19 Admirality Way",
                  SuburbId = 126,
                  MedicalAidStatus = true,
                  MedicalAidPlanId = 8,
                  MedicalAidNo = "285465885",
                  PersonResponsible = "Charmaine Meintjies",
                  DependentTypeId = 1006,//sibling
                  Idnumber = "5803180224083",
                  Dob = Convert.ToDateTime("1958/03/18"),
                  Gender = CovidEnums.Gender.Female,
                  EmailAddress ="daleen@gmail.com"
              },
                new Dependent
                {
                    DependentId = 92,
                    MainMemberId = 1,//charmaine
                    FirstName = "Vince",
                    LastName = "Meintjies",
                    MobileNumber = "0832458796",
                    AddressLine1 = "19 Admirality Way",
                    SuburbId = 126,
                    MedicalAidStatus = true,
                    MedicalAidPlanId = 8,
                    MedicalAidNo = "285465885",
                    PersonResponsible = "Charmaine Meintjies",
                    DependentTypeId = 1007,//gtandchild
                    Idnumber = "1205050225083",
                    Dob = Convert.ToDateTime("2012/05/05"),
                    Gender = CovidEnums.Gender.Male,
                    EmailAddress ="charmaine@gmail.com"
                },
                      new Dependent
                      {
                          DependentId = 93,
                          MainMemberId = 1,//charmaine
                          FirstName = "Vanessa",
                          LastName = "Meintjies",
                          MobileNumber = "0832458796",
                          AddressLine1 = "19 Admirality Way",
                          SuburbId = 126,
                          MedicalAidStatus = true,
                          MedicalAidPlanId = 8,
                          MedicalAidNo = "285465885",
                          PersonResponsible = "Charmaine Meintjies",
                          DependentTypeId = 1007,//grandchild
                          Idnumber = "1607070225083",
                          Dob = Convert.ToDateTime("2016/07/07"),
                          Gender = CovidEnums.Gender.Female,
                          EmailAddress = "charmaine@gmail.com"
                      },

                       new Dependent
                       {
                           DependentId = 94,
                           MainMemberId = 1,//charmaine
                           FirstName = "Daniel",
                           LastName = "Meintjies",
                           MobileNumber = "0832458796",
                           AddressLine1 = "19 Admirality Way",
                           SuburbId = 126,
                           MedicalAidStatus = true,
                           MedicalAidPlanId = 8,
                           MedicalAidNo = "285465885",
                           PersonResponsible = "Charmaine Meintjies",
                           DependentTypeId = 1006,//sibling
                           Idnumber = "5309130225083",
                           Dob = Convert.ToDateTime("1953/09/13"),
                           Gender = CovidEnums.Gender.Male,
                           EmailAddress = "charmaine@gmail.com"
                       },

                       new Dependent
                       {
                           DependentId = 95,
                           MainMemberId = 2,//jacob
                           FirstName = "Lesedi",
                           LastName = "Moloi",
                           MobileNumber = "0772458796",
                           AddressLine1 = "24 7th Avenue",
                           SuburbId = 127,
                           MedicalAidStatus = false,
                           PersonResponsible = "Jacob Moloi",
                           DependentTypeId = 1002,//child
                           Idnumber = "8307070225083",
                           Dob = Convert.ToDateTime("1983/07/07"),
                           Gender = CovidEnums.Gender.Female,
                           MedicalAidPlanId = null,//40 is a placeholder since medicalaid doesnt want to be null, it is null on migration,
                           EmailAddress ="lesedi@gmail.com"
                       },
                        new Dependent
                        {
                            DependentId = 96,
                            MainMemberId = 2,//jacob
                            FirstName = "Thabo",
                            LastName = "Moloi",
                            MobileNumber = "0822458796",
                            AddressLine1 = "24 7th Avenue",
                            SuburbId = 127,
                            MedicalAidStatus = false,
                            PersonResponsible = "Jacob Moloi",
                            DependentTypeId = 1007,//child
                            Idnumber = "1107090225083",
                            Dob = Convert.ToDateTime("2011/07/09"),
                            Gender = CovidEnums.Gender.Male,
                            MedicalAidPlanId = null,
                            EmailAddress = "jacob@gmail.com"
                        }

                 );
        }

        #endregion Dependents

        #region Nurses

        public static void SeedingNurses(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Nurse>().HasData(
                new Nurse
                {
                    NurseId = 1,
                    FirstName = "Dorothy",
                    LastName = "Daniels",
                    Idnumber = "7503180225083",
                    YearQualified = Convert.ToDateTime("1992/04/04"),
                    Rank = CovidEnums.Rank.Specialized,
                    SuburbId = 126,
                    MobileNumber = "0512458796",
                    UserID = "7c805a02-1b05-4def-b38d-0a91c402167c"
                },

                  new Nurse
                  {
                      NurseId = 2,
                      FirstName = "Lindile",
                      LastName = "Hadebe",
                      Idnumber = "7603180225083",
                      YearQualified = Convert.ToDateTime("1997/02/15"),
                      Rank = CovidEnums.Rank.Specialized,
                      SuburbId = 73,
                      MobileNumber = "0522458796",
                      UserID = "431f6523-88b4-463e-a09e-6e174e09f6fa"
                  },

                        new Nurse
                        {
                            NurseId = 3,
                            FirstName = "Marcel",
                            LastName = "Van Niekerk",
                            Idnumber = "7703180225083",
                            YearQualified = Convert.ToDateTime("2003/05/07"),
                            Rank = CovidEnums.Rank.General,
                            SuburbId = 43,
                            MobileNumber = "0532458796",
                            UserID = "6605428b-3b95-4072-9e26-23b357a21117"
                        }

                 );
        }

        #endregion Nurses

        #region NursesPrefferedSuburbs

        public static void SeedingNursePreferredSuburbs(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SuburbsPreffered>().HasData(
                new SuburbsPreffered { NurseId = 1, SuburbId = 126 },//dorothy
                      new SuburbsPreffered { NurseId = 1, SuburbId = 127 },
                 new SuburbsPreffered { NurseId = 1, SuburbId = 56 },
                  new SuburbsPreffered { NurseId = 1, SuburbId = 57 },
                  new SuburbsPreffered { NurseId = 3, SuburbId = 91 }//marcel

                 );
        }

        #endregion NursesPrefferedSuburbs

        #region SeedLabUser

        public static void SeedingLabUser(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LabUser>().HasData(
               new LabUser
               {
                   LabUserId = 1,
                   FirstName = "Mandla",
                   LastName = "Khumalo",
                   Idnumber = "79052520225083",
                   MobileNumber = "0912458796",
                   UserID = "b99be5c3-fb63-4c73-b846-83af447ff43e"
               }

                 );
        }

        #endregion SeedLabUser

        #region SeedCalenderEvents

        public static void SeedingCalenderEvents(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CalendarEvent>().HasData(
               new CalendarEvent
               {
                   ID = 1,
                   Title = "19 Admirality Way",
                   Description = "19 Admirality Way" + " " + "Summerstrand",
                   Start = Convert.ToDateTime("12/11/2021 10:00:00"),
                   End = Convert.ToDateTime("12/11/2021 12:00:00"),
                   AllDay = false
               },
                new CalendarEvent
                {
                    ID = 2,
                    Title = "19 Admirality Way",
                    Description = "19 Admirality Way" + " " + "Summerstrand",
                    Start = Convert.ToDateTime("12/11/2021 10:00:00"),
                    End = Convert.ToDateTime("12/11/2021 12:00:00"),
                    AllDay = false
                },
                  new CalendarEvent
                  {
                      ID = 3,
                      Title = "19 Admirality Way",
                      Description = "19 Admirality Way" + " " + "Summerstrand",
                      Start = Convert.ToDateTime("12/11/2021 10:00:00"),
                      End = Convert.ToDateTime("12/11/2021 12:00:00"),
                      AllDay = false
                  },
                   new CalendarEvent
                   {
                       ID = 4,
                       Title = "19 Admirality Way",
                       Description = "19 Admirality Way" + " " + "Summerstrand",
                       Start = Convert.ToDateTime("12/11/2021 10:00:00"),
                       End = Convert.ToDateTime("12/11/2021 12:00:00"),
                       AllDay = false
                   },
                    new CalendarEvent
                    {
                        ID = 5,
                        Title = "19 Admirality Way",
                        Description = "19 Admirality Way" + " " + "Summerstrand",
                        Start = Convert.ToDateTime("12/11/2021 10:00:00"),
                        End = Convert.ToDateTime("12/11/2021 12:00:00"),
                        AllDay = false
                    },
                       new CalendarEvent
                       {
                           ID = 6,
                           Title = "1 Harbor Cottages",
                           Description = "1 Harbor Cottages" + " " + "Humerail",
                           Start = Convert.ToDateTime("13/11/2021 10:00:00"),
                           End = Convert.ToDateTime("13/11/2021 12:00:00"),
                           AllDay = false
                       }
                   




                    

                 );
        }

        #endregion SeedCalenderEvents










        #region SeedTestRequests

        public static void SeedingTestRequests(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TestRequest>().HasData(
               new TestRequest
               {
                   TestRequestId = 1,
                   RequestDate = Convert.ToDateTime("2021-11-11 08:00:00"),
                   RequestStatus = CovidEnums.TestRequestStatus.Scheduled,
                   PatientId = 1,//Charmaine
                   DependentId = null,
                   TestAddress1 = "19 Admirality Way",
                   TestAddress2 = null,
                   SuburbId = 126,
                   DateAssigned = Convert.ToDateTime("12/11/2021"),
                   NurseId = 1, //Dorothy
                   StartTime = Convert.ToDateTime("12/11/2021 10:00:00"),
                   EndTime = Convert.ToDateTime("12/11/2021 12:00:00"),
                   CalenderEventID = 1
                   //10- 12,

               },

                 new TestRequest
                 {
                     TestRequestId = 2,
                     RequestDate = Convert.ToDateTime("2021-11-11 08:00:00"),
                     RequestStatus = CovidEnums.TestRequestStatus.Scheduled,
                     PatientId = 1,
                     DependentId = 91,
                     TestAddress1 = "19 Admirality Way",
                     TestAddress2 = null,
                     SuburbId = 126,
                     DateAssigned = Convert.ToDateTime("12/11/2021"),
                     NurseId = 1, //Dorothy
                     StartTime = Convert.ToDateTime("12/11/2021 10:00:00"),
                     EndTime = Convert.ToDateTime("12/11/2021 12:00:00"),
                     CalenderEventID = 2
                     //10- 12
                 },

                    new TestRequest
                    {
                        TestRequestId = 3,
                        RequestDate = Convert.ToDateTime("2021-11-11 08:00:00"),
                        RequestStatus = CovidEnums.TestRequestStatus.Scheduled,
                        PatientId = 1,//Charmaine
                        DependentId = 92, //Vince
                        TestAddress1 = "19 Admirality Way",
                        TestAddress2 = null,
                        SuburbId = 126,
                        DateAssigned = Convert.ToDateTime("12/11/2021"),
                        NurseId = 1, //Dorothy
                        StartTime = Convert.ToDateTime("12/11/2021 10:00:00"),
                        EndTime = Convert.ToDateTime("12/11/2021 12:00:00"),
                        CalenderEventID = 3
                        //10- 12
                    },
                      new TestRequest
                      {
                          TestRequestId = 4,
                          RequestDate = Convert.ToDateTime("2021-11-11 08:00:00"),
                          RequestStatus = CovidEnums.TestRequestStatus.Scheduled,
                          PatientId = 1,
                          DependentId = 93, //VAnessa
                          TestAddress1 = "19 Admirality Way",
                          TestAddress2 = null,
                          SuburbId = 126,
                          DateAssigned = Convert.ToDateTime("12/11/2021"),
                          NurseId = 1, //Dorothy
                          StartTime = Convert.ToDateTime("12/11/2021 10:00:00"),
                          EndTime = Convert.ToDateTime("12/11/2021 12:00:00"),
                          CalenderEventID = 4
                          //10- 12
                      },

                        new TestRequest
                        {
                            TestRequestId = 5,
                            RequestDate = Convert.ToDateTime("2021-11-11 08:00:00"),
                            RequestStatus = CovidEnums.TestRequestStatus.Scheduled,
                            PatientId = 1,//Charmaine
                            DependentId = 94, //VAnessa
                            TestAddress1 = "19 Admirality Way",
                            TestAddress2 = null,
                            SuburbId = 126,
                            DateAssigned = Convert.ToDateTime("12/11/2021"),
                            NurseId = 1, //Dorothy
                            StartTime = Convert.ToDateTime("12/11/2021 10:00:00"),
                            EndTime = Convert.ToDateTime("12/11/2021 12:00:00"),
                            CalenderEventID = 5
                            //10- 12
                        },
                        new TestRequest
                        {
                            TestRequestId = 6,
                            RequestDate = Convert.ToDateTime("2021-11-11 08:00:00"),
                            RequestStatus = CovidEnums.TestRequestStatus.Scheduled,
                            PatientId = 3,//Dawid
                            DependentId = null,
                            TestAddress1 = "1 Harbor Cottages",
                            TestAddress2 = "Sayre Crescent",
                            SuburbId = 56,
                            DateAssigned = Convert.ToDateTime("13/11/2021"),
                            NurseId = 1, //Dorothy
                            StartTime = Convert.ToDateTime("13/11/2021 14:00:00"),
                            EndTime = Convert.ToDateTime("13/11/2021 16:00:00"),
                            CalenderEventID = 6
                            //10- 12,
                            //14- 16pm
                        },

                          new TestRequest
                          {
                              TestRequestId = 7,
                              RequestDate = Convert.ToDateTime("2021-11-12 08:00:00"),
                              RequestStatus = CovidEnums.TestRequestStatus.New,
                              PatientId = 4,//Kopano
                              DependentId = null,
                              TestAddress1 = "27 Aspen Complex",
                              TestAddress2 = "La Roche Drive",
                              SuburbId = 57,
                              DateAssigned = null,
                              NurseId = null
                              
                          },

                           new TestRequest
                           {
                               TestRequestId = 8,
                               RequestDate = Convert.ToDateTime("2021-11-12 08:00:00"),
                               RequestStatus = CovidEnums.TestRequestStatus.New,
                               PatientId = 5,//Karien
                               DependentId = null,
                               TestAddress1 = "6 Rubin Crescent",
                               TestAddress2 = null,
                               SuburbId = 126,
                               DateAssigned = null,
                               NurseId = null
                               
                           },

                               new TestRequest
                               {
                                   TestRequestId = 9,
                                   RequestDate = Convert.ToDateTime("2021-11-12 08:00:00"),
                                   RequestStatus = CovidEnums.TestRequestStatus.New,
                                   PatientId = 6,//Felcity
                                   DependentId = null,
                                   TestAddress1 = "28 7th Avenue",
                                   TestAddress2 = null,
                                   SuburbId = 127,
                                   DateAssigned = null,
                                   NurseId = null
                                   
                               },

                                    new TestRequest
                                    {
                                        TestRequestId = 10,
                                        RequestDate = Convert.ToDateTime("2021-11-12 08:00:00"),
                                        RequestStatus = CovidEnums.TestRequestStatus.New,
                                        PatientId = 7,//Errol
                                        DependentId = null,
                                        TestAddress1 = "37 The Beaches",
                                        TestAddress2 = "Beach Road",
                                        SuburbId = 56,
                                        DateAssigned = null,
                                        NurseId = null
                                        
                                    },

                                     new TestRequest
                                     {
                                         TestRequestId = 11,
                                         RequestDate = Convert.ToDateTime("2021-11-12 08:00:00"),
                                         RequestStatus = CovidEnums.TestRequestStatus.New,
                                         PatientId = 8,//Alyce
                                         DependentId = null,
                                         TestAddress1 = "12 Marshall Road",
                                         TestAddress2 = null,
                                         SuburbId = 57,
                                         DateAssigned = null,
                                         NurseId = null
                                        
                                     },

                                         new TestRequest
                                         {
                                             TestRequestId = 12,
                                             RequestDate = Convert.ToDateTime("2021-11-12 08:00:00"),
                                             RequestStatus = CovidEnums.TestRequestStatus.New,
                                             PatientId = 9,//Asha
                                             DependentId = null,
                                             TestAddress1 = "13 Congo Avenue",
                                             TestAddress2 = null,
                                             SuburbId = 84,
                                             DateAssigned = null,
                                             NurseId = null
                                             
                                         },

                                          new TestRequest
                                          {
                                              TestRequestId = 13,
                                              RequestDate = Convert.ToDateTime("2021-11-12 08:00:00"),
                                              RequestStatus = CovidEnums.TestRequestStatus.New,
                                              PatientId = 10,//Carlos
                                              DependentId = null,
                                              TestAddress1 = "29 Peace Street",
                                              TestAddress2 = null,
                                              SuburbId = 84,
                                              DateAssigned = null,
                                              NurseId = null
                                            
                                          },

                                                    new TestRequest
                                                    {
                                                        TestRequestId = 14,
                                                        RequestDate = Convert.ToDateTime("2021-11-12 08:00:00"),
                                                        RequestStatus = CovidEnums.TestRequestStatus.New,
                                                        PatientId = 11,//Kabelo
                                                        DependentId = null,
                                                        TestAddress1 = "7 Jacks Road",
                                                        TestAddress2 = null,
                                                        SuburbId = 84,
                                                        DateAssigned = null,
                                                        NurseId = null
                                                        
                                                    },

                                                    new TestRequest
                                                    {
                                                        TestRequestId = 15,
                                                        RequestDate = Convert.ToDateTime("2021-11-12 08:00:00"),
                                                        RequestStatus = CovidEnums.TestRequestStatus.Scheduled,
                                                        PatientId = 12,//Pulane
                                                        DependentId = null,
                                                        TestAddress1 = "45 Columbia Crescent",
                                                        TestAddress2 = null,
                                                        SuburbId = 84,
                                                        DateAssigned = Convert.ToDateTime("13/11/2021"),
                                                        NurseId = 2, //Lindile,
                                                        StartTime = Convert.ToDateTime("13/11/2021 08:00:00"),
                                                        EndTime = Convert.ToDateTime("13/11/2021 10:00:00"),
                                                        CalenderEventID = null

                                                    },

                                                       //CLOSED TEST REQUESTS
                                                       new TestRequest
                                                       {
                                                           TestRequestId = 16,
                                                           RequestDate = Convert.ToDateTime("2021-01-31 10:00:00"),
                                                           RequestStatus = CovidEnums.TestRequestStatus.Closed,
                                                           PatientId = 1,//Charmaine
                                                           DependentId = null,
                                                           TestAddress1 = "19 Admirality Way",
                                                           TestAddress2 = null,
                                                           SuburbId = 126,
                                                           DateAssigned = Convert.ToDateTime("2021-02-01"),
                                                           NurseId = 1, //Dorothy
                                                           StartTime = Convert.ToDateTime("01/02/2021 10:00:00"),
                                                           EndTime = Convert.ToDateTime("01/02/2021 12:00:00"),
                                                           //10- 12,

                                                       },

                                                         new TestRequest
                                                         {
                                                             TestRequestId = 17,
                                                             RequestDate = Convert.ToDateTime("2021-01-31 10:00:00"),
                                                             RequestStatus = CovidEnums.TestRequestStatus.Closed,
                                                             PatientId = 1,//Charmaine
                                                             DependentId = 91,//Daleen
                                                             TestAddress1 = "19 Admirality Way",
                                                             TestAddress2 = null,
                                                             SuburbId = 126,
                                                             DateAssigned = Convert.ToDateTime("2021-02-01"),
                                                             NurseId = 1, //Dorothy
                                                             StartTime = Convert.ToDateTime("01/02/2021 10:00:00"),
                                                             EndTime = Convert.ToDateTime("01/02/2021 12:00:00"),

                                                         },

                                                              new TestRequest
                                                              {
                                                                  TestRequestId = 18,
                                                                  RequestDate = Convert.ToDateTime("2021-01-31 10:00:00"),
                                                                  RequestStatus = CovidEnums.TestRequestStatus.Closed,
                                                                  PatientId = 1,//Charmaine
                                                                  DependentId = 92,//Vince
                                                                  TestAddress1 = "19 Admirality Way",
                                                                  TestAddress2 = null,
                                                                  SuburbId = 126,
                                                                  DateAssigned = Convert.ToDateTime("2021-02-01"),
                                                                  NurseId = 1,
                                                                  StartTime = Convert.ToDateTime("01/02/2021 10:00:00"),
                                                                  EndTime = Convert.ToDateTime("01/02/2021 12:00:00"),//Dorothy
                                                                                                                      //10:00 -12:00
                                                              },

                                                              new TestRequest
                                                              {
                                                                  TestRequestId = 19,
                                                                  RequestDate = Convert.ToDateTime("2021-01-31 10:00:00"),
                                                                  RequestStatus = CovidEnums.TestRequestStatus.Closed,
                                                                  PatientId = 1,//Charmaine
                                                                  DependentId = 93,//Vanessa
                                                                  TestAddress1 = "19 Admirality Way",
                                                                  TestAddress2 = null,
                                                                  SuburbId = 126,
                                                                  DateAssigned = Convert.ToDateTime("2021-02-01"),
                                                                  NurseId = 1,
                                                                  StartTime = Convert.ToDateTime("01/02/2021 10:00:00"),
                                                                  EndTime = Convert.ToDateTime("01/02/2021 12:00:00"),//Dorothy
                                                                  //10:00 -12:00
                                                              },

                                                                new TestRequest
                                                                {
                                                                    TestRequestId = 20,
                                                                    RequestDate = Convert.ToDateTime("2021-01-31 10:00:00"),
                                                                    RequestStatus = CovidEnums.TestRequestStatus.Closed,
                                                                    PatientId = 1,//Charmaine
                                                                    DependentId = 94,//Daniel
                                                                    TestAddress1 = "19 Admirality Way",
                                                                    TestAddress2 = null,
                                                                    SuburbId = 126,
                                                                    DateAssigned = Convert.ToDateTime("2021-02-01"),
                                                                    NurseId = 1, //Dorothy
                                                                    StartTime = Convert.ToDateTime("01/02/2021 10:00:00"),
                                                                    EndTime = Convert.ToDateTime("01/02/2021 12:00:00"),
                                                                    //10:00 -12:00
                                                                },

                                                                 new TestRequest
                                                                 {
                                                                     TestRequestId = 21,
                                                                     RequestDate = Convert.ToDateTime("2021-02-12  10:00:00"),
                                                                     RequestStatus = CovidEnums.TestRequestStatus.Closed,
                                                                     PatientId = 3,//David
                                                                     DependentId = null,
                                                                     TestAddress1 = "1 Harbor Cottages",
                                                                     TestAddress2 = "Sayre Crescent",
                                                                     SuburbId = 56,
                                                                     DateAssigned = Convert.ToDateTime("2021-02-13"),
                                                                     NurseId = 3, //Marcel
                                                                     StartTime = Convert.ToDateTime("13/02/2021 12:00:00"),
                                                                     EndTime = Convert.ToDateTime("13/02/2021 14:00:00"),
                                                                     //12:00 -14:00
                                                                 },

                                                                   new TestRequest
                                                                   {
                                                                       TestRequestId = 22,
                                                                       RequestDate = Convert.ToDateTime("2021-02-12 10:00:00"),
                                                                       RequestStatus = CovidEnums.TestRequestStatus.Closed,
                                                                       PatientId = 4,//Kopano
                                                                       DependentId = null,
                                                                       TestAddress1 = "27 Aspen Complex",
                                                                       TestAddress2 = "La Roche Drive",
                                                                       SuburbId = 57,
                                                                       DateAssigned = Convert.ToDateTime("2021-02-13"),
                                                                       NurseId = 1, //Dorothy
                                                                       StartTime = Convert.ToDateTime("13/02/2021 10:00:00"),
                                                                       EndTime = Convert.ToDateTime("13/02/2021 12:00:00"),
                                                                       //10:00 -12:00
                                                                   },

                                                                     new TestRequest
                                                                     {
                                                                         TestRequestId = 23,
                                                                         RequestDate = Convert.ToDateTime("2021-02-12 10:00:00"),
                                                                         RequestStatus = CovidEnums.TestRequestStatus.Closed,
                                                                         PatientId = 5,//Karien
                                                                         DependentId = null,
                                                                         TestAddress1 = "6 Rubin Crescent",
                                                                         TestAddress2 = null,
                                                                         SuburbId = 126,
                                                                         DateAssigned = Convert.ToDateTime("2021-02-13"),
                                                                         NurseId = 1, //Dorothy
                                                                         StartTime = Convert.ToDateTime("13/02/2021 10:00:00"),
                                                                         EndTime = Convert.ToDateTime("13/02/2021 12:00:00"),
                                                                         //10:00 -12:00
                                                                     },

                                                                        new TestRequest
                                                                        {
                                                                            TestRequestId = 24,
                                                                            RequestDate = Convert.ToDateTime("2021-02-12 10:00:00"),
                                                                            RequestStatus = CovidEnums.TestRequestStatus.Closed,
                                                                            PatientId = 6,//Felicity
                                                                            DependentId = null,
                                                                            TestAddress1 = "28 7th Avenue",
                                                                            TestAddress2 = null,
                                                                            SuburbId = 127,
                                                                            DateAssigned = Convert.ToDateTime("2021-02-13"),
                                                                            NurseId = 1, //Dorothy
                                                                            StartTime = Convert.ToDateTime("13/02/2021 10:00:00"),
                                                                            EndTime = Convert.ToDateTime("13/02/2021 12:00:00"),
                                                                            //10:00 -12:00
                                                                        },

                                                                           new TestRequest
                                                                           {
                                                                               TestRequestId = 25,
                                                                               RequestDate = Convert.ToDateTime("2021-02-12 10:00:00"),
                                                                               RequestStatus = CovidEnums.TestRequestStatus.Closed,
                                                                               PatientId = 7,//Errol
                                                                               DependentId = null,
                                                                               TestAddress1 = "37 The Beaches",
                                                                               TestAddress2 = "Beach Road",
                                                                               SuburbId = 56,
                                                                               DateAssigned = Convert.ToDateTime("2021-02-13"),
                                                                               NurseId = 3, //Marcel
                                                                               StartTime = Convert.ToDateTime("13/02/2021 12:00:00"),
                                                                               EndTime = Convert.ToDateTime("13/02/2021 14:00:00"),
                                                                               //12:00 -14:00
                                                                           },
                                                                             new TestRequest
                                                                             {
                                                                                 TestRequestId = 26,
                                                                                 RequestDate = Convert.ToDateTime("2021-02-12 10:00"),
                                                                                 RequestStatus = CovidEnums.TestRequestStatus.Closed,
                                                                                 PatientId = 8,//Alyce
                                                                                 DependentId = null,
                                                                                 TestAddress1 = "12 Marshall Road",
                                                                                 TestAddress2 = null,
                                                                                 SuburbId = 57,
                                                                                 DateAssigned = Convert.ToDateTime("2021-02-13"),
                                                                                 NurseId = 3, //Marcel
                                                                                 StartTime = Convert.ToDateTime("13/02/2021 12:00:00"),
                                                                                 EndTime = Convert.ToDateTime("13/02/2021 14:00:00"),
                                                                                 //12:00 -14:00
                                                                             },
                                                                             new TestRequest
                                                                             {
                                                                                 TestRequestId = 27,
                                                                                 RequestDate = Convert.ToDateTime("2021-02-12 10:00:00"),
                                                                                 RequestStatus = CovidEnums.TestRequestStatus.Closed,
                                                                                 PatientId = 9,//Asha
                                                                                 DependentId = null,
                                                                                 TestAddress1 = "13 Congo Avenue",
                                                                                 TestAddress2 = null,
                                                                                 SuburbId = 84,
                                                                                 DateAssigned = Convert.ToDateTime("2021-02-13"),
                                                                                 NurseId = 3, //Marcel
                                                                                 StartTime = Convert.ToDateTime("13/02/2021 12:00:00"),
                                                                                 EndTime = Convert.ToDateTime("13/02/2021 14:00:00"),
                                                                                 //12:00 -14:00
                                                                             },

                                                                                    new TestRequest
                                                                                    {
                                                                                        TestRequestId = 28,
                                                                                        RequestDate = Convert.ToDateTime("2021-02-12 10:00:00"),
                                                                                        RequestStatus = CovidEnums.TestRequestStatus.Closed,
                                                                                        PatientId = 10,//Carlos
                                                                                        DependentId = null,
                                                                                        TestAddress1 = "29 Peace Street",
                                                                                        TestAddress2 = null,
                                                                                        SuburbId = 84,
                                                                                        DateAssigned = Convert.ToDateTime("2021-02-13"),
                                                                                        NurseId = 3, //Marcel
                                                                                        StartTime = Convert.ToDateTime("13/02/2021 12:00:00"),
                                                                                        EndTime = Convert.ToDateTime("13/02/2021 14:00:00"),
                                                                                        //12:00 -14:00
                                                                                    },

                                                                                      new TestRequest
                                                                                      {
                                                                                          TestRequestId = 29,
                                                                                          RequestDate = Convert.ToDateTime("2021-02-27 10:00:00"),
                                                                                          RequestStatus = CovidEnums.TestRequestStatus.Closed,
                                                                                          PatientId = 11,//Kabelo
                                                                                          DependentId = null,
                                                                                          TestAddress1 = "7 Jacks Road",
                                                                                          TestAddress2 = null,
                                                                                          SuburbId = 84,
                                                                                          DateAssigned = Convert.ToDateTime("2021-02-28"),
                                                                                          NurseId = 1, //Dorothy
                                                                                          StartTime = Convert.ToDateTime("28/02/2021 14:00:00"),
                                                                                          EndTime = Convert.ToDateTime("28/02/2021 16:00:00"),
                                                                                          //14:00 -16:00
                                                                                      },
                                                                                              new TestRequest
                                                                                              {
                                                                                                  TestRequestId = 30,
                                                                                                  RequestDate = Convert.ToDateTime("2021-02-27 10:00:00"),
                                                                                                  RequestStatus = CovidEnums.TestRequestStatus.Closed,
                                                                                                  PatientId = 12,//Pulane
                                                                                                  DependentId = null,
                                                                                                  TestAddress1 = "45 Columbia Crescent",
                                                                                                  TestAddress2 = null,
                                                                                                  SuburbId = 84,
                                                                                                  DateAssigned = Convert.ToDateTime("2021-02-28"),
                                                                                                  NurseId = 1, //dorothy
                                                                                                  StartTime = Convert.ToDateTime("28/02/2021 14:00:00"),
                                                                                                  EndTime = Convert.ToDateTime("28/02/2021 16:00:00"),
                                                                                                  //14:00 -16:00
                                                                                              }

                 );
        }

        #endregion SeedTestRequests



        #region SeedTests

        public static void SeedingTests(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Test>().HasData(
               new Test
               {
                   TestId = 1,
                   TestRequestId = 16,
                   LabUserId = 1,
                   BarCode = "COV-ABC-1010-01",
                   TestResult = "Positive",
                   Temperature = 37.5,
                   BloodPressure = "124/79",
                   OxygenLevel =95,
                   ResultDate = Convert.ToDateTime("2021-02-03 08:00:00"),
                   TestDate = Convert.ToDateTime("2021-02-01"),
                   TestTime = Convert.ToDateTime("2021-02-01 10:15:00")

               },
                new Test
                {
                    TestId = 2,
                    TestRequestId = 17,
                    LabUserId = 1,
                    BarCode = "COV-ABC-1010-02",
                    TestResult = "Positive",
                    Temperature = 38.2,
                    BloodPressure = "120/80",
                    OxygenLevel = 97,
                    ResultDate = Convert.ToDateTime("2021-02-03 08:05:00"),
                    TestDate = Convert.ToDateTime("2021-02-01"),
                    TestTime = Convert.ToDateTime("2021-02-01 10:35:00")

                },
                new Test
                {
                    TestId = 3,
                    TestRequestId = 18,
                    LabUserId = 1,
                    BarCode = "COV-ABC-1010-03",
                    TestResult = "Negative",
                    Temperature = 34.6,
                    BloodPressure = "124/79",
                    OxygenLevel = 99,
                    ResultDate = Convert.ToDateTime("2021-02-03 08:05:00"),
                    TestDate = Convert.ToDateTime("2021-02-01"),
                    TestTime = Convert.ToDateTime("2021-02-01 10:48:00")


                },
                  new Test
                  {
                      TestId = 4,
                      TestRequestId = 19,
                      LabUserId = 1,
                      BarCode = "COV-ABC-1010-04",
                      TestResult = "Negative",
                      Temperature = 35.8,
                      BloodPressure = "120/80",
                      OxygenLevel = 99,
                      ResultDate = Convert.ToDateTime("2021-02-03 08:05:00"),
                      TestDate = Convert.ToDateTime("2021-02-01"),
                      TestTime = Convert.ToDateTime("2021-02-01 11:10:00")


                  },
                   new Test
                   {
                       TestId = 5,
                       TestRequestId = 20,
                       LabUserId = 1,
                       BarCode = "COV-ABC-1010-05",
                       TestResult = "Positive",
                       Temperature = 37.9,
                       BloodPressure = "124/79",
                       OxygenLevel = 90,
                       ResultDate = Convert.ToDateTime("2021-02-03 08:12:00"),
                       TestDate = Convert.ToDateTime("2021-02-01"),
                       TestTime = Convert.ToDateTime("2021-02-01 11:29:00")

                   },

                     new Test
                     {
                         TestId = 6,
                         TestRequestId = 21,
                         LabUserId = 1,
                         BarCode = "COV-ABC-1020-01",
                         TestResult = "Negative",
                         Temperature = 35.1,
                         BloodPressure = "120/80",
                         OxygenLevel = 100,
                         ResultDate = Convert.ToDateTime("2021-02-15 09:12:00"),
                         TestDate = Convert.ToDateTime("2021-02-13"),
                         TestTime = Convert.ToDateTime("2021-02-13 12:11:00")

                     },
                      new Test
                      {
                          TestId = 7,
                          TestRequestId = 22,
                          LabUserId = 1,
                          BarCode = "COV-ABC-1020-02",
                          TestResult = "Positive",
                          Temperature = 36.9,
                          BloodPressure = "124/79",
                          OxygenLevel = 92,
                          ResultDate = Convert.ToDateTime("2021-02-15 08:12:00"),
                          TestDate = Convert.ToDateTime("2021-02-13"),
                          TestTime = Convert.ToDateTime("2021-02-13 10:11:00")

                      },
                       new Test
                       {
                           TestId = 8,
                           TestRequestId = 23,
                           LabUserId = 1,
                           BarCode = "COV-ABC-1020-03",
                           TestResult = "Positive",
                           Temperature = 37.4,
                           BloodPressure = "120/80",
                           OxygenLevel = 91,
                           ResultDate = Convert.ToDateTime("2021-02-15 08:12:00"),
                           TestDate = Convert.ToDateTime("2021-02-13"),
                           TestTime = Convert.ToDateTime("2021-02-13 10:37:00")

                       },
                        new Test
                        {
                            TestId = 9,
                            TestRequestId = 24,
                            LabUserId = 1,
                            BarCode = "COV-ABC-1020-04",
                            TestResult = "Positive",
                            Temperature = 38.1,
                            BloodPressure = "124/79",
                            OxygenLevel = 93,
                            ResultDate = Convert.ToDateTime("2021-02-15 08:19:00"),
                            TestDate = Convert.ToDateTime("2021-02-13"),
                            TestTime = Convert.ToDateTime("2021-02-13 11:01:00")

                        },
                         new Test
                         {
                             TestId = 10,
                             TestRequestId = 25,
                             LabUserId = 1,
                             BarCode = "COV-ABC-1020-05",
                             TestResult = "Negative",
                             Temperature = 34.5,
                             BloodPressure = "120/80",
                             OxygenLevel = 100,
                             ResultDate = Convert.ToDateTime("2021-02-15 09:17:00"),
                             TestDate = Convert.ToDateTime("2021-02-13"),
                             TestTime = Convert.ToDateTime("2021-02-13 12:55:00")

                         },
                          new Test
                          {
                              TestId = 11,
                              TestRequestId = 26,
                              LabUserId = 1,
                              BarCode = "COV-ABC-1020-06",
                              TestResult = "Positive",
                              Temperature = 37.2,
                              BloodPressure = "124/79",
                              OxygenLevel = 91,
                              ResultDate = Convert.ToDateTime("2021-02-15 09:12:00"),
                              TestDate = Convert.ToDateTime("2021-02-13"),
                              TestTime = Convert.ToDateTime("2021-02-13 13:11:00")

                          },
                           new Test
                           {
                               TestId = 12,
                               TestRequestId = 27,
                               LabUserId = 1,
                               BarCode = "COV-ABC-1030-07",
                               TestResult = "Negative",
                               Temperature = 34.2,
                               BloodPressure = "120/80",
                               OxygenLevel = 99,
                               ResultDate = Convert.ToDateTime("2021-02-15 09:12:00"),
                               TestDate = Convert.ToDateTime("2021-02-13"),
                               TestTime = Convert.ToDateTime("2021-02-13 13:29:00")

                           },
                            new Test
                            {
                                TestId = 13,
                                TestRequestId = 28,
                                LabUserId = 1,
                                BarCode = "COV-ABC-1030-08",
                                TestResult = "Positive",
                                Temperature = 38.2,
                                BloodPressure = "124/79",
                                OxygenLevel = 92,
                                ResultDate = Convert.ToDateTime("2021-02-15 09:12:00"),
                                TestDate = Convert.ToDateTime("2021-02-13"),
                                TestTime = Convert.ToDateTime("2021-02-13 13:46:00")

                            },
                             new Test
                             {
                                 TestId = 14,
                                 TestRequestId = 29,
                                 LabUserId = 1,
                                 BarCode = "COV-ABC-1030-09",
                                 TestResult = "Positive",
                                 Temperature = 37.9,
                                 BloodPressure = "120/80",
                                 OxygenLevel = 93,
                                 ResultDate = Convert.ToDateTime("2021-03-01 07:12:00"),
                                 TestDate = Convert.ToDateTime("2021-02-28"),
                                 TestTime = Convert.ToDateTime("2021-02-28 14:20:00")

                             },
                                new Test
                                {
                                    TestId = 15,
                                    TestRequestId = 30,
                                    LabUserId = 1,
                                    BarCode = "COV-ABC-1030-09",
                                    TestResult = "Positive",
                                    Temperature = 38.5,
                                    BloodPressure = "124/79",
                                    OxygenLevel = 94,
                                    ResultDate = Convert.ToDateTime("2021-03-01 07:28:00"),
                                    TestDate = Convert.ToDateTime("2021-02-28"),
                                    TestTime = Convert.ToDateTime("2021-02-28 14:41:00")

                                }



                 );
        }

        #endregion SeedTests
    }
}