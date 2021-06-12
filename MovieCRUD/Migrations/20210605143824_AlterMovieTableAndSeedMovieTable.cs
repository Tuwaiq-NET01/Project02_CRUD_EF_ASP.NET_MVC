using Microsoft.EntityFrameworkCore.Migrations;

namespace MovieCRUD.Migrations
{
    public partial class AlterMovieTableAndSeedMovieTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "budget",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "revenue",
                table: "Movies");

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "id", "backdrop_path", "imdb_id", "overview", "poster_path", "release_date", "runtime", "title", "vote_average" },
                values: new object[,]
                {
                    { 337404, "/sgHmoqF97bjM1HUyw43FzjzXtEr.jpg", "tt3228774", "In 1970s London amidst the punk rock revolution, a young grifter named Estella is determined to make a name for herself with her designs. She befriends a pair of young thieves who appreciate her appetite for mischief, and together they are able to build a life for themselves on the London streets. One day, Estella’s flair for fashion catches the eye of the Baroness von Hellman, a fashion legend who is devastatingly chic and terrifyingly haute. But their relationship sets in motion a course of events and revelations that will cause Estella to embrace her wicked side and become the raucous, fashionable and revenge-bent Cruella.", "/A0knvX7rlwTyZSKj8H5NiARb45.jpg", "2021-05-26", 134, "Cruella", 8.8000000000000007 },
                    { 791373, "/pcDc2WJAYGJTTvRSEIpRZwM3Ola.jpg", "tt12361974", "Determined to ensure Superman's ultimate sacrifice was not in vain, Bruce Wayne aligns forces with Diana Prince with plans to recruit a team of metahumans to protect the world from an approaching threat of catastrophic proportions.", "/tnAuB8q5vv7Ax9UAEje5Xi4BXik.jpg", "2021-03-18", 242, "Zack Snyder's Justice League", 8.5 },
                    { 259693, "/sWHlCeJ2RunM5eq3FYA4VuTUNqY.jpg", "tt3065204", "Lorraine and Ed Warren travel to north London to help a single mother raising four children alone in a house plagued by malicious spirits.", "/zEqyD0SBt6HL7W9JQoWwtd5Do1T.jpg", "2016-05-13", 134, "The Conjuring 2", 7.2000000000000002 },
                    { 691179, "/hP7dN2B5ztQgSIN5Qvk63MY4EeO.jpg", "tt11337862", "The cast of Friends reunites for a once-in-a-lifetime celebration of the hit series, an unforgettable evening filled with iconic memories, uncontrollable laughter, happy tears, and special guests.", "/bT3c4TSOP8vBmMoXZRDPTII6eDa.jpg", "2021-05-27", 104, "Friends: The Reunion", 8.5 },
                    { 726684, "/rlNnwObbMu5G2FaOUlacnUIdIIA.jpg", "tt12816634", "On school break, Marinette heads to Shanghai to meet Adrien. But after arriving, Marinette loses all her stuff, including the Miraculous that allows her to turn into Ladybug!", "/msI5a9TPnepx47JUb2vl88hb80R.jpg", "2021-04-04", 52, "Miraculous World: Shanghai – The Legend of Ladydragon", 7.7999999999999998 },
                    { 520763, "/z2UtGA1WggESspi6KOXeo66lvLx.jpg", "tt8332922", "Following the events at home, the Abbott family now face the terrors of the outside world. Forced to venture into the unknown, they realize that the creatures that hunt by sound are not the only threats that lurk beyond the sand path.", "/4q2hz2m8hubgvijz8Ez0T2Os2Yv.jpg", "2021-05-21", 97, "A Quiet Place Part II", 7.4000000000000004 },
                    { 615457, "/6zbKgwgaaCyyBXE4Sun4oWQfQmi.jpg", "tt7888964", "Hutch Mansell, a suburban dad, overlooked husband, nothing neighbor — a \"nobody.\" When two thieves break into his home one night, Hutch's unknown long-simmering rage is ignited and propels him on a brutal path that will uncover dark secrets he fought to leave behind.", "/oBgWY00bEFeZ9N25wWVyuQddbAo.jpg", "2021-03-26", 92, "Nobody", 8.5 },
                    { 527774, "/hJuDvwzS0SPlsE6MNFOpznQltDZ.jpg", "tt5109280", "Long ago, in the fantasy world of Kumandra, humans and dragons lived together in harmony. But when an evil force threatened the land, the dragons sacrificed themselves to save humanity. Now, 500 years later, that same evil has returned and it’s up to a lone warrior, Raya, to track down the legendary last dragon to restore the fractured land and its divided people.", "/lPsD10PP4rgUGiGR4CCXA6iY0QQ.jpg", "2021-03-03", 107, "Raya and the Last Dragon", 8.1999999999999993 },
                    { 635302, "/xPpXYnCWfjkt3zzE0dpCNME1pXF.jpg", "tt11032374", "Tanjirō Kamado, joined with Inosuke Hashibira, a boy raised by boars who wears a boar's head, and Zenitsu Agatsuma, a scared boy who reveals his true power when he sleeps, boards the Infinity Train on a new mission with the Fire Hashira, Kyōjurō Rengoku, to defeat a demon who has been tormenting the people and killing the demon slayers who oppose it!", "/h8Rb9gBr48ODIwYUttZNYeMWeUU.jpg", "2020-10-16", 117, "Demon Slayer -Kimetsu no Yaiba- The Movie: Mugen Train", 8.4000000000000004 },
                    { 808023, "/efrdAWS63s8TTWdrI2uNdIhn1dj.jpg", "tt4136456", "A lonesome stranger with nerves of steel must track down and kill a rogue hitman to satisfy an outstanding debt. But the only information he's been given is a time and location where to find his quarry. No name. No description. Nothing.", "/vXHzO26mJaOt4VO7ZFiM6No5ScT.jpg", "2021-04-30", 105, "The Virtuoso", 6.2000000000000002 },
                    { 823855, "/yyWNPhP1HR4BTLErHcZwIUsMBvA.jpg", "tt9013182", "A special crimes investigator forms an unlikely bond with a serial killer to bring down a global child sex trafficking syndicate.", "/m6bUeV4mczG3z2YXXr5XDKPsQzv.jpg", "2021-05-14", 107, "I Am All Girls", 6.9000000000000004 },
                    { 578701, "/iDdpiUnCeXvBmrkBFpL6lKsZt33.jpg", "tt3215824", "A young boy finds himself pursued by two assassins in the Montana wilderness with a survival expert determined to protecting him - and a forest fire threatening to consume them all.", "/xCEg6KowNISWvMh8GvPSxtdf9TO.jpg", "2021-05-05", 100, "Those Who Wish Me Dead", 7.0 },
                    { 567189, "/fPGeS6jgdLovQAKunNHX8l0avCy.jpg", "tt0499097", "An elite Navy SEAL uncovers an international conspiracy while seeking justice for the murder of his pregnant wife.", "/rEm96ib0sPiZBADNKBHKBv5bve9.jpg", "2021-04-29", 109, "Tom Clancy's Without Remorse", 7.2000000000000002 },
                    { 399566, "/inJjDhCjfhh3RtrJWBmmDqeuSYC.jpg", "tt5034838", "In a time when monsters walk the Earth, humanity’s fight for its future sets Godzilla and Kong on a collision course that will see the two most powerful forces of nature on the planet collide in a spectacular battle for the ages.", "/pgqgaUx1cJb5oZQQ5v0tNARCeBp.jpg", "2021-03-24", 113, "Godzilla vs. Kong", 8.0999999999999996 },
                    { 460465, "/mPBI506o7gITnjoSkcyPneK9s8n.jpg", "tt0293429", "Washed-up MMA fighter Cole Young, unaware of his heritage, and hunted by Emperor Shang Tsung's best warrior, Sub-Zero, seeks out and trains with Earth's greatest champions as he prepares to stand against the enemies of Outworld in a high stakes battle for the universe.", "/nkayOAUBUu4mMvyNf9iHSUiPjF1.jpg", "2021-04-07", 110, "Mortal Kombat", 7.5999999999999996 },
                    { 503736, "/9WlJFhOSCPnaaSmsrv0B4zA8iUb.jpg", "tt0993840", "Following a zombie outbreak in Las Vegas, a group of mercenaries take the ultimate gamble: venturing into the quarantine zone to pull off the greatest heist ever attempted.", "/z8CExJekGrEThbpMXAmCFvvgoJR.jpg", "2021-05-14", 148, "Army of the Dead", 6.5999999999999996 },
                    { 637649, "/77tui163estZrQ78NBggqDB4n2C.jpg", "tt11083552", "A cold and mysterious new security guard for a Los Angeles cash truck company surprises his co-workers when he unleashes precision skills during a heist. The crew is left wondering who he is and where he came from. Soon, the marksman's ultimate motive becomes clear as he takes dramatic and irrevocable steps to settle a score.", "/YxopfHpsCV1oF8CZaL4M3Eodqa.jpg", "2021-04-22", 119, "Wrath of Man", 7.9000000000000004 },
                    { 632357, "/wwFBRyekDcKXJwP0mImRJjAnudL.jpg", "tt9419056", "Alice, a young hearing-impaired girl who, after a supposed visitation from the Virgin Mary, is inexplicably able to hear, speak and heal the sick. As word spreads and people from near and far flock to witness her miracles, a disgraced journalist hoping to revive his career visits the small New England town to investigate. When terrifying events begin to happen all around, he starts to question if these phenomena are the works of the Virgin Mary or something much more sinister.", "/bShgiEQoPnWdw4LBrYT5u18JF34.jpg", "2021-03-31", 99, "The Unholy", 7.0999999999999996 },
                    { 573680, "/xrAaJAn3hqkInq5kE1AGJqIGXyT.jpg", "tt7329642", "In the 1930s, a young reverend and his family are forced to confront their worst fears when they discover their new home holds a horrifying secret.", "/xD9mc8JCVXA8T8u4Od7qOUBuGH4.jpg", "2021-04-29", 97, "The Banishing", 6.2999999999999998 },
                    { 717192, "/fejok33Ijc6SppiEU1cfwA9Mo2.jpg", "tt14217100", "Before he built a drug empire, Ferry Bouman returns to his hometown on a revenge mission that finds his loyalty tested — and a love that alters his life.", "/w6n1pu9thpCVHILejsuhKf3tNCV.jpg", "2021-05-14", 106, "Ferry", 7.0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "id",
                keyValue: 259693);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "id",
                keyValue: 337404);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "id",
                keyValue: 399566);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "id",
                keyValue: 460465);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "id",
                keyValue: 503736);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "id",
                keyValue: 520763);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "id",
                keyValue: 527774);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "id",
                keyValue: 567189);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "id",
                keyValue: 573680);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "id",
                keyValue: 578701);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "id",
                keyValue: 615457);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "id",
                keyValue: 632357);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "id",
                keyValue: 635302);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "id",
                keyValue: 637649);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "id",
                keyValue: 691179);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "id",
                keyValue: 717192);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "id",
                keyValue: 726684);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "id",
                keyValue: 791373);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "id",
                keyValue: 808023);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "id",
                keyValue: 823855);

            migrationBuilder.AddColumn<int>(
                name: "budget",
                table: "Movies",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "revenue",
                table: "Movies",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
