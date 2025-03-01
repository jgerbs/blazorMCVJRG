using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MvcDB.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class M1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Team",
                columns: table => new
                {
                    TeamName = table.Column<string>(type: "TEXT", maxLength: 30, nullable: false),
                    City = table.Column<string>(type: "TEXT", nullable: false),
                    Province = table.Column<string>(type: "TEXT", nullable: false),
                    Country = table.Column<string>(type: "TEXT", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Team", x => x.TeamName);
                });

            migrationBuilder.CreateTable(
                name: "Player",
                columns: table => new
                {
                    PlayerId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    JerseyNumber = table.Column<int>(type: "INTEGER", nullable: false),
                    FirstName = table.Column<string>(type: "TEXT", nullable: true),
                    LastName = table.Column<string>(type: "TEXT", nullable: true),
                    Position = table.Column<string>(type: "TEXT", nullable: true),
                    TeamName = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Player", x => x.PlayerId);
                    table.ForeignKey(
                        name: "FK_Player_Team_TeamName",
                        column: x => x.TeamName,
                        principalTable: "Team",
                        principalColumn: "TeamName",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Team",
                columns: new[] { "TeamName", "City", "Country", "Province" },
                values: new object[,]
                {
                    { "Blackhawks", "Chicago", "USA", "IL" },
                    { "Canucks", "Vancouver", "Canada", "BC" },
                    { "Ducks", "Anaheim", "USA", "CA" },
                    { "Flames", "Calgary", "Canada", "AB" },
                    { "Leafs", "Toronto", "Canada", "ON" },
                    { "Lightening", "Tampa Bay", "USA", "FL" },
                    { "Oilers", "Edmonton", "Canada", "AB" },
                    { "Sharks", "San Jose", "USA", "CA" }
                });

            migrationBuilder.InsertData(
                table: "Player",
                columns: new[] { "PlayerId", "FirstName", "JerseyNumber", "LastName", "Position", "TeamName" },
                values: new object[,]
                {
                    { 1, "Sven", 47, "Baertschi", "Forward", "Canucks" },
                    { 2, "Hendrik", 33, "Sedin", "Left Wing", "Canucks" },
                    { 3, "John", 12, "Rooster", "Right Wing", "Flames" },
                    { 4, "Bob", 44, "Plumber", "Defense", "Oilers" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Player_TeamName",
                table: "Player",
                column: "TeamName");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Player");

            migrationBuilder.DropTable(
                name: "Team");
        }
    }
}
