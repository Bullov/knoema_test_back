using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    [Table("all_data")]
    public partial class AllData
    {
        [Column("country_code")]
        public int? CountryCode { get; set; }
        [Column("subject_code")]
        [StringLength(255)]
        public string SubjectCode { get; set; }
        [Column("country_series_specific_notes")]
        public string CountrySeriesSpecificNotes { get; set; }
        [Column("estimates_start_after")]
        public double? EstimatesStartAfter { get; set; }
        [Column("1980")]
        public double? _1980 { get; set; }
        [Column("1981")]
        public double? _1981 { get; set; }
        [Column("1982")]
        public double? _1982 { get; set; }
        [Column("1983")]
        public double? _1983 { get; set; }
        [Column("1984")]
        public double? _1984 { get; set; }
        [Column("1985")]
        public double? _1985 { get; set; }
        [Column("1986")]
        public double? _1986 { get; set; }
        [Column("1987")]
        public double? _1987 { get; set; }
        [Column("1988")]
        public double? _1988 { get; set; }
        [Column("1989")]
        public double? _1989 { get; set; }
        [Column("1990")]
        public double? _1990 { get; set; }
        [Column("1991")]
        public double? _1991 { get; set; }
        [Column("1992")]
        public double? _1992 { get; set; }
        [Column("1993")]
        public double? _1993 { get; set; }
        [Column("1994")]
        public double? _1994 { get; set; }
        [Column("1995")]
        public double? _1995 { get; set; }
        [Column("1996")]
        public double? _1996 { get; set; }
        [Column("1997")]
        public double? _1997 { get; set; }
        [Column("1998")]
        public double? _1998 { get; set; }
        [Column("1999")]
        public double? _1999 { get; set; }
        [Column("2000")]
        public double? _2000 { get; set; }
        [Column("2001")]
        public double? _2001 { get; set; }
        [Column("2002")]
        public double? _2002 { get; set; }
        [Column("2003")]
        public double? _2003 { get; set; }
        [Column("2004")]
        public double? _2004 { get; set; }
        [Column("2005")]
        public double? _2005 { get; set; }
        [Column("2006")]
        public double? _2006 { get; set; }
        [Column("2007")]
        public double? _2007 { get; set; }
        [Column("2008")]
        public double? _2008 { get; set; }
        [Column("2009")]
        public double? _2009 { get; set; }
        [Column("2010")]
        public double? _2010 { get; set; }
        [Column("2011")]
        public double? _2011 { get; set; }
        [Column("2012")]
        public double? _2012 { get; set; }
        [Column("2013")]
        public double? _2013 { get; set; }
        [Column("2014")]
        public double? _2014 { get; set; }
        [Column("2015")]
        public double? _2015 { get; set; }
        [Column("2016")]
        public double? _2016 { get; set; }
        [Column("2017")]
        public double? _2017 { get; set; }
        [Column("2018")]
        public double? _2018 { get; set; }
        [Column("2019")]
        public double? _2019 { get; set; }
        [Column("2020")]
        public double? _2020 { get; set; }
        [Column("2021")]
        public double? _2021 { get; set; }
        [Column("2022")]
        public double? _2022 { get; set; }
        [Column("2023")]
        public double? _2023 { get; set; }
        [Column("2024")]
        public double? _2024 { get; set; }

        [ForeignKey(nameof(CountryCode))]
        public virtual Countries CountryCodeNavigation { get; set; }
        [ForeignKey(nameof(SubjectCode))]
        public virtual Subjects SubjectCodeNavigation { get; set; }
    }
}
