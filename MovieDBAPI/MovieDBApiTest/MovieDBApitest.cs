using MovieDBAPI;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieDBApiTest
{
    public class MovieDBApitest
    {
        [Test]
        public void ToConfirmThatTheActorIsNotInSeason6Epsode1()
        {
            string url = String.Format(BaseUrl.ApiUrl + "1399/season/6/episode/1?api_key=41aed1d29b4834fc33585bf83b92123b");
            var data = ReadJsonData.GetJsonDataFromUrl<RootObject>(url);

            Assert.IsTrue(data != null, "The service did not return any respose");
            Crew nellTigerInCrew = data.crew
                .FirstOrDefault(crew =>
                { return crew.name == "Nell Tiger Free"; });

            Assert.IsTrue(nellTigerInCrew == null, "Nell Tiger Free was not expected in the crew");

            GuestStar nellTigerInGuest = data.guest_stars
                .FirstOrDefault(guest =>
                { return guest.name == "Nell Tiger Free"; });

            Assert.IsTrue(nellTigerInGuest == null, "Nell Tiger Free was not expected in the guest stars list");

        }


        [Test]

        public void ToConfirmThatTheActorIsInSeason5Epsode1AsMaincastMemberButNotAsAGuestActor()
        {
            string url = String.Format(BaseUrl.ApiUrl + "1399/season/5/episode/1/credits?api_key=41aed1d29b4834fc33585bf83b92123b");
            var data = ReadJsonData.GetJsonDataFromUrl<RootObject>(url);

            Assert.IsTrue(data != null, "The service did not return any respose");
            Cast nellTigerInCast = data.cast
                .FirstOrDefault(cast =>
                { return cast.name == "Nell Tiger Free"; });

            Assert.IsTrue(nellTigerInCast != null, "Nell Tiger Free was expected in the crew");

            GuestStar nellTigerInGuest = data.guest_stars
                .FirstOrDefault(guest =>
                { return guest.name == "Nell Tiger Free"; });

            Assert.IsTrue(nellTigerInGuest == null, "Nell Tiger Free was not expected in the guest stars list");

        }


        [Test]

        public void ToConfirmThatTheActorIsInSeason5Epsode2AsMaincastMemberAndAsAGuestActor()
        {
            string url = String.Format(BaseUrl.ApiUrl + "1399/season/5/episode/2/credits?api_key=41aed1d29b4834fc33585bf83b92123b");
            var data = ReadJsonData.GetJsonDataFromUrl<RootObject>(url);

            Assert.IsTrue(data != null, "The service did not return any respose");
            Cast nellTigerInCast = data.cast
                .FirstOrDefault(cast =>
                { return cast.name == "Nell Tiger Free"; });

            Assert.IsTrue(nellTigerInCast != null, "Nell Tiger Free was expected in the Cast");

            GuestStar nellTigerInGuest = data.guest_stars
                .FirstOrDefault(guest =>
                { return guest.name == "Nell Tiger Free"; });

            Assert.IsTrue(nellTigerInGuest != null, "Nell Tiger Free was  expected in the guest stars list");

        }

        [Test]
        public void EpisodePerSeasonIsCorrect()
        {
            string url = String.Format(BaseUrl.ApiUrl + "1399?api_key=41aed1d29b4834fc33585bf83b92123b");
            var data = ReadJsonData.GetJsonDataFromUrl<RootObject>(url);

            Season season1 = GetSeason(data, 1);
            Assert.IsTrue(season1.episode_count != 8, "The episode count is not equal to 8");

            Season season2 = GetSeason(data, 2);
            Assert.IsTrue(season2.episode_count != 13, "The episode count is not equal to 13");

            Season season3 = GetSeason(data, 3);
            Assert.IsTrue(season3.episode_count != 13, "The episode count is not equal to 13");

            Season season4 = GetSeason(data, 4);
            Assert.IsTrue(season4.episode_count != 13, "The episode count is not equal to 13");

            Season season5 = GetSeason(data, 5);
            Assert.IsTrue(season5.episode_count != 16, "The episode count is not equal to 16");

        }

        private Season GetSeason(RootObject data, int seasonNumber)
        {
            Season selectedSeason =
                 data.seasons
                   .FirstOrDefault(season =>
                   { return season.season_number == seasonNumber; });
            return selectedSeason;
        }

    }
}
