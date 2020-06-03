using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("api")]
    public class ApplicationController : ControllerBase
    {
        private readonly ApplicationContext applicationContext;

        public ApplicationController(ApplicationContext context)
        {
            applicationContext = context;
        }

        [HttpGet]
        [Route("getCountries")]
        public IEnumerable<Countries> Get()
        {
            return applicationContext.Countries.ToList();
        }

        [HttpGet]
        [Route("getSubjects")]
        public IEnumerable<Subjects> GetSubjects()
        {
            return applicationContext.Subjects.ToList();
        }

        [HttpPost]
        [Route("getData")]
        public IEnumerable<SubjectWithSelectedCountriesData> GetData([FromBody] FilterParams filters)
        {
            var result = new List<SubjectWithSelectedCountriesData>();
            var subjectCodes = filters.subjectCodes;
            subjectCodes.ForEach(code =>
            {
                var subjectData = applicationContext.Subjects.Find(code);

                var data = applicationContext.AllData
                .Where(data => data.SubjectCode.Equals(code) && filters.countryCodes.Contains(data.CountryCode))
                .Select(data => new AllDataWithCountryName
                {
                    CountryName = data.CountryCodeNavigation.CountryName,
                    _1980 = data._1980,
                    _1981 = data._1981,
                    _1982 = data._1982,
                    _1983 = data._1983,
                    _1984 = data._1984,
                    _1985 = data._1985,
                    _1986 = data._1986,
                    _1987 = data._1987,
                    _1988 = data._1988,
                    _1989 = data._1989,
                    _1990 = data._1990,
                    _1991 = data._1991,
                    _1992 = data._1992,
                    _1993 = data._1993,
                    _1994 = data._1994,
                    _1995 = data._1995,
                    _1996 = data._1996,
                    _1997 = data._1997,
                    _1998 = data._1998,
                    _1999 = data._1999,
                    _2000 = data._2000,
                    _2001 = data._2001,
                    _2002 = data._2002,
                    _2003 = data._2003,
                    _2004 = data._2004,
                    _2005 = data._2005,
                    _2006 = data._2006,
                    _2007 = data._2007,
                    _2008 = data._2008,
                    _2009 = data._2009,
                    _2010 = data._2010,
                    _2011 = data._2011,
                    _2012 = data._2012,
                    _2013 = data._2013,
                    _2014 = data._2014,
                    _2015 = data._2015,
                    _2016 = data._2016,
                    _2017 = data._2017,
                    _2018 = data._2018,
                    _2019 = data._2019,
                    _2020 = data._2020,
                    _2021 = data._2021,
                    _2022 = data._2022,
                    _2023 = data._2023,
                    _2024 = data._2024,
                }).ToList();

                result.Add(new SubjectWithSelectedCountriesData
                {
                    Data = data,
                    Code = subjectData.Code,
                    Description = subjectData.Description,
                    Units = subjectData.Units,
                    Scale = subjectData.Scale,
                    Notes = subjectData.Notes
                });

            });
            return result;
        }
    }
}
