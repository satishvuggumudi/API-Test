using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieDBAPI
{
    public class Cast
    {
        public string character { get; set; }
        public string credit_id { get; set; }
        public int id { get; set; }
        public string name { get; set; }
        public string profile_path { get; set; }
        public int order { get; set; }
    }
    public class Crew
    {
        public int id { get; set; }
        public string credit_id { get; set; }
        public string name { get; set; }
        public string department { get; set; }
        public string job { get; set; }
        public string profile_path { get; set; }
    }

    public class GuestStar
    {
        public int id { get; set; }
        public string name { get; set; }
        public string credit_id { get; set; }
        public string character { get; set; }
        public int order { get; set; }
        public string profile_path { get; set; }
    }

    public class CreatedBy
    {
        public int id { get; set; }
        public string name { get; set; }
        public string profile_path { get; set; }
    }

    public class Genre
    {
        public int id { get; set; }
        public string name { get; set; }
    }

    public class Network
    {
        public int id { get; set; }
        public string name { get; set; }
    }

    public class ProductionCompany
    {
        public string name { get; set; }
        public int id { get; set; }
    }

    public class Season
    {
        public string air_date { get; set; }
        public int episode_count { get; set; }
        public int id { get; set; }
        public string poster_path { get; set; }
        public int season_number { get; set; }
    }

    public class RootObject
    {
        public string air_date { get; set; }
        public List<Crew> crew { get; set; }
        public int episode_number { get; set; }
        public List<GuestStar> guest_stars { get; set; }
        public string name { get; set; }
        public string overview { get; set; }
        public int id { get; set; }
        public string production_code { get; set; }
        public int season_number { get; set; }
        public string still_path { get; set; }
        public double vote_average { get; set; }
        public int vote_count { get; set; }
        public List<Cast> cast { get; set; }
        public string backdrop_path { get; set; }
        public List<CreatedBy> created_by { get; set; }
        public List<int> episode_run_time { get; set; }
        public string first_air_date { get; set; }
        public List<Genre> genres { get; set; }
        public string homepage { get; set; }
        public bool in_production { get; set; }
        public List<string> languages { get; set; }
        public string last_air_date { get; set; }
        public List<Network> networks { get; set; }
        public int number_of_episodes { get; set; }
        public int number_of_seasons { get; set; }
        public List<string> origin_country { get; set; }
        public string original_language { get; set; }
        public string original_name { get; set; }
        public double popularity { get; set; }
        public string poster_path { get; set; }
        public List<ProductionCompany> production_companies { get; set; }
        public List<Season> seasons { get; set; }
        public string status { get; set; }
        public string type { get; set; }

    }
}
