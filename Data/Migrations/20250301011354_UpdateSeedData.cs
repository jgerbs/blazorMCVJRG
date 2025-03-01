using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MvcDB.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Player",
                columns: new[] { "PlayerId", "FirstName", "JerseyNumber", "LastName", "Position", "TeamName" },
                values: new object[,]
                {
                    { 5, "Connor", 97, "McDavid", "Center", "Oilers" },
                    { 6, "Nathan", 29, "MacKinnon", "Center", "Sharks" },
                    { 7, "Alex", 8, "Ovechkin", "Left Wing", "Lightening" },
                    { 8, "Sidney", 87, "Crosby", "Center", "Ducks" },
                    { 9, "Patrick", 88, "Kane", "Right Wing", "Blackhawks" },
                    { 10, "Auston", 34, "Matthews", "Center", "Leafs" },
                    { 11, "Steven", 91, "Stamkos", "Center", "Leafs" },
                    { 12, "Carey", 11, "Price", "Goaltender", "Flames" },
                    { 13, "Victor", 77, "Hedman", "Defense", "Oilers" },
                    { 14, "Johnny", 13, "Gaudreau", "Left Wing", "Canucks" },
                    { 15, "Kris", 58, "Letang", "Defense", "Sharks" },
                    { 16, "Tuukka", 40, "Rask", "Goaltender", "Ducks" },
                    { 17, "Mitch", 16, "Marner", "Right Wing", "Blackhawks" },
                    { 18, "Anze", 11, "Kopitar", "Center", "Lightening" },
                    { 19, "Sergei", 72, "Bobrovsky", "Goaltender", "Oilers" },
                    { 20, "Ryan", 17, "O'Reilly", "Center", "Canucks" },
                    { 21, "Marc-Andre", 29, "Fleury", "Goaltender", "Sharks" },
                    { 22, "Mika", 93, "Zibanejad", "Center", "Lightening" },
                    { 23, "John", 74, "Carlson", "Defense", "Ducks" },
                    { 24, "David", 88, "Pastrnak", "Right Wing", "Blackhawks" },
                    { 25, "Roman", 59, "Josi", "Defense", "Leafs" },
                    { 26, "Jonathan", 19, "Toews", "Center", "Flames" },
                    { 27, "Patrice", 37, "Bergeron", "Center", "Oilers" },
                    { 28, "Artemi", 10, "Panarin", "Left Wing", "Canucks" },
                    { 29, "Evgeni", 71, "Malkin", "Center", "Sharks" },
                    { 30, "Sidney", 21, "Hoyt", "Defense", "Blackhawks" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "PlayerId",
                keyValue: 30);
        }
    }
}
