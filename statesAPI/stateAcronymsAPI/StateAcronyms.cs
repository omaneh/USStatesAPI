using System;
using stateAcronymsAPI.Models;
using System.Collections.Generic;

namespace stateAcronymsAPI
{
    public class StatesDataStore
    {
        public List<stateDto> State { get; set; }

        public static StatesDataStore Current { get; } = new StatesDataStore();


        public StatesDataStore()
        {
            State = new List<stateDto>()
            {
            new stateDto()
            {
                Id = 1,
                Name = "Alabama",
                stateAcryonym = "AL",
                StatePopulation = 5_074_296,
                Region = StateRegion.South
            },
            new stateDto()
            {
                Id = 2,
                Name = "Alaska",
                stateAcryonym = "AK",
                StatePopulation = 731_721,
                Region = StateRegion.West
            },
            new stateDto
            {
                Id = 3,
                Name = "Arizona",
                stateAcryonym = "AZ",
                StatePopulation = 7_408_017,
                Region = StateRegion.Southwest
            },
            new stateDto()
            {
                Id = 4,
                Name = "California",
                stateAcryonym = "CA",
                StatePopulation = 38_959_247,
                Region = StateRegion.West
            },
            new stateDto()
            {
                Id = 5,
                Name = "Colorado",
                stateAcryonym = "CO",
                StatePopulation = 5_855_078,
                Region = StateRegion.West
            },
            new stateDto()
            {
                Id = 6,
                Name = "Conneticut",
                stateAcryonym = "CT",
                StatePopulation = 3_609_924,
                Region = StateRegion.NewEngland
            },
            new stateDto()
            {
                Id = 7,
                Name = "Delaware",
                stateAcryonym = "DE",
                StatePopulation = 1_012_615,
                Region = StateRegion.MiddleAtlantic
            },
            new stateDto()
            {
                Id = 8,
                Name = "Arkansas",
                stateAcryonym = "AR",
                StatePopulation = 3_042_231,
                Region = StateRegion.South
            },
            new stateDto()
            {
                Id = 9,
                Name = "Florida",
                stateAcryonym = "FL",
                StatePopulation = 22_040_323,
                Region = StateRegion.South
            },
            new stateDto()
            {
                Id = 10,
                Name = "Georgia",
                stateAcryonym = "GA",
                StatePopulation = 10_852_484,
                Region = StateRegion.South
            },
            new stateDto()
            {
                Id = 11,
                Name = "Hawaii",
                stateAcryonym = "HI",
                StatePopulation = 1_433_336,
                Region = StateRegion.West
            },
            new stateDto()
            {
                Id = 12,
                Name = "Idaho",
                stateAcryonym = "ID",
                StatePopulation = 1_981_332,
                Region = StateRegion.West
            },
            new stateDto()
            {
                Id = 13,
                Name = "Illinois",
                stateAcryonym = "IL",
                StatePopulation = 12_518_144,
                Region = StateRegion.Midwest
            },
            new stateDto()
            {
                Id = 14,
                Name = "Indiana",
                stateAcryonym = "IN",
                StatePopulation = 6_831_167,
                Region = StateRegion.Midwest
            },
            new stateDto()
            {
                Id = 15,
                Name = "Iowa",
                stateAcryonym = "IA",
                StatePopulation = 3_196_911,
                Region = StateRegion.Midwest
            },
            new stateDto()
            {
                Id = 16,
                Name = "Kansas",
                stateAcryonym = "KS",
                StatePopulation = 2_928_419,
                Region = StateRegion.Midwest
            },
            new stateDto()
            {
                Id = 17,
                Name = "Kentucky",
                stateAcryonym = "KY",
                StatePopulation = 4_519_315,
                Region = StateRegion.South
            },
            new stateDto()
            {
                Id = 18,
                Name = "Louisiana",
                stateAcryonym = "LA",
                StatePopulation = 4_576_882,
                Region = StateRegion.South
            },
            new stateDto()
            {
                Id = 19,
                Name = "Maine",
                stateAcryonym = "ME",
                StatePopulation = 1_381_441,
                Region = StateRegion.NewEngland
            },
            new stateDto()
            {
                Id = 20,
                Name = "Maryland",
                stateAcryonym = "MD",
                StatePopulation = 6_157_731,
                Region = StateRegion.MiddleAtlantic
            },
            new stateDto()
            {
                Id = 21,
                Name = "Massachusetts",
                stateAcryonym = "MA",
                StatePopulation = 6_962_372,
                Region = StateRegion.NewEngland
            },
            new stateDto()
            {
                Id = 22,
                Name = "Michigan",
                stateAcryonym = "MI",
                StatePopulation = 10_032_720,
                Region = StateRegion.Midwest
            },
            new stateDto()
            {
                Id = 23,
                Name = "Minnesota",
                stateAcryonym = "MN",
                StatePopulation = 5_702_253,
                Region = StateRegion.Midwest
            },
            new stateDto()
            {
                Id = 24,
                Name = "Mississippi",
                stateAcryonym = "MS",
                StatePopulation = 2_940_820,
                Region = StateRegion.South
            },
            new stateDto()
            {
                Id = 25,
                Name = "Missoui",
                stateAcryonym = "MO",
                StatePopulation = 6_180_523,
                Region = StateRegion.South
            },
            new stateDto()
            {
                Id = 26,
                Name = "Montana",
                stateAcryonym = "MT",
                StatePopulation = 1_125_473,
                Region = StateRegion.West
            },
            new stateDto()
            {
                Id = 27,
                Name = "Nebraska",
                stateAcryonym = "NE",
                StatePopulation = 1_966_441,
                Region = StateRegion.Midwest
            },
            new stateDto()
            {
                Id = 28,
                Name = "Nevada",
                stateAcryonym = "NV",
                StatePopulation = 3_201_212,
                Region = StateRegion.West
            },
            new stateDto()
            {
                Id = 29,
                Name = "New Hampshire",
                stateAcryonym = "NH",
                StatePopulation = 1_405_243,
                Region = StateRegion.NewEngland
            },
            new stateDto()
            {
                Id = 30,
                Name = "New Jersey",
                stateAcryonym = "NJ",
                StatePopulation = 9_242_109,
                Region = StateRegion.MiddleAtlantic
            },
            new stateDto()
            {
                Id = 31,
                Name = "New Mexico",
                stateAcryonym = "NM",
                StatePopulation = 2_113_550,
                Region = StateRegion.Southwest
            },
            new stateDto()
            {
                Id = 32,
                Name = "New York",
                stateAcryonym = "NY",
                StatePopulation = 19_415_392,
                Region = StateRegion.MiddleAtlantic
            },
            new stateDto()
            {
                Id = 33,
                Name = "North Carolina",
                stateAcryonym = "NC",
                StatePopulation = 10_678_831,
                Region = StateRegion.South
            },
            new stateDto()
            {
                Id = 34,
                Name = "North Dakota",
                stateAcryonym = "ND",
                StatePopulation = 770_221,
                Region = StateRegion.Midwest
            },
            new stateDto()
            {
                Id = 35,
                Name = "Ohio",
                stateAcryonym = "OH",
                StatePopulation = 11_767_059,
                Region = StateRegion.Midwest
            },
            new stateDto()
            {
                Id = 36,
                Name = "Oklahoma",
                stateAcryonym = "OK",
                StatePopulation = 4_018_931,
                Region = StateRegion.Southwest
            },
            new stateDto()
            {
                Id = 37,
                Name = "Oregon",
                stateAcryonym = "OR",
                StatePopulation = 4_259_743,
                Region = StateRegion.West
            },
            new stateDto()
            {
                Id = 38,
                Name = "Pennsylvania",
                stateAcryonym = "PA",
                StatePopulation = 12_916_089,
                Region = StateRegion.MiddleAtlantic
            },
            new stateDto()
            {
                Id = 39,
                Name = "Rhode Island",
                stateAcryonym = "RI",
                StatePopulation = 1_094_843,
                Region = StateRegion.NewEngland
            },
            new stateDto()
            {
                Id = 40,
                Name = "South Carolina",
                stateAcryonym = "SC",
                StatePopulation = 3_042_231,
                Region = StateRegion.South
            },
            new stateDto()
            {
                Id = 41,
                Name = "South Dakota",
                stateAcryonym = "SD",
                StatePopulation = 905_404,
                Region = StateRegion.Midwest
            },
            new stateDto()
            {
                Id = 42,
                Name = "Tennessee",
                stateAcryonym = "TN",
                StatePopulation = 7_059_618,
                Region = StateRegion.South
            },
            new stateDto()
            {
                Id = 43,
                Name = "Texas",
                stateAcryonym = "TX",
                StatePopulation = 29_947_238,
                Region = StateRegion.Southwest
            },
            new stateDto()
            {
                Id = 44,
                Name = "Utah",
                stateAcryonym = "UT",
                StatePopulation = 3_426_431,
                Region = StateRegion.West
            },
            new stateDto()
            {
                Id = 45,
                Name = "Vermont",
                stateAcryonym = "VT",
                StatePopulation =  647_378,
                Region = StateRegion.NewEngland
            },
            new stateDto()
            {
                Id = 46,
                Name = "Virgina",
                stateAcryonym = "VA",
                StatePopulation = 8_662_151,
                Region = StateRegion.South
            },
            new stateDto()
            {
                Id = 47,
                Name = "Washington",
                stateAcryonym = "WA",
                StatePopulation = 7_765_004,
                Region = StateRegion.West
            },
            new stateDto()
            {
                Id = 48,
                Name = "West Virgina",
                stateAcryonym = "WV",
                StatePopulation = 1_773_866,
                Region = StateRegion.South
            },
            new stateDto()
            {
                Id = 49,
                Name = "Wisconsin",
                stateAcryonym = "WI",
                StatePopulation = 5_903_573,
                Region = StateRegion.Midwest
            },
            new stateDto()
            {
                Id = 50,
                Name = "Wyoming",
                stateAcryonym = "WY",
                StatePopulation = 581_813,
                Region = StateRegion.West
            }
        };

        }
    }
}

