using System.Collections.Generic;

namespace WebApplication1.Models
{
    public class SubjectWithSelectedCountriesData : Subjects
    {
        public List<AllDataWithCountryName> Data { get; set; }

    }
}
