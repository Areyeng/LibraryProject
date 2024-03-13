using System.ComponentModel;

namespace LibraryProject.Domain.Enums
{

    public enum RefListGenre : long
    {
        [Description("Fiction")]
        Fiction = 1,
        [Description("NonFiction")]
        NonFiction = 2,
        [Description("ChildrensGenre")]
        ChildrensGenre = 3,
        [Description("Poetry")]
        Poetry = 4,
        [Description("Drama")]
        Drama = 5,
        [Description("Comics")]
        Comics = 6,
        [Description("Mystery")]
        Mystery = 7,
        [Description("Romance")]
        Romance = 8,
        [Description("ScienceFiction")]
        ScienceFiction = 9,
        [Description("Fantasy")]
        Fantasy = 10,
        [Description("HistoricalFiction")]
        HistoricalFiction = 11,
        [Description("Biography")]
        Biography = 12,
        [Description("History")]
        History = 13,
        [Description("PersonalDevelopmen")]
        PersonalDevelopment = 14,
        [Description("Science")]
        Science = 15,

    }
}
