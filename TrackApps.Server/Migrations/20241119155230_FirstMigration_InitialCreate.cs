using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TrackApps.Server.Migrations
{
    /// <inheritdoc />
    public partial class FirstMigration_InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Interviews",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InterviewDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Interviewer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Company = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Position = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Round = table.Column<int>(type: "int", nullable: true),
                    FollowUp = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Interviews", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Interviews",
                columns: new[] { "Id", "Company", "ContactNumber", "FollowUp", "InterviewDate", "Interviewer", "Position", "Round" },
                values: new object[,]
                {
                    { 1, "CYFD", "", null, "2024-11-19", "I1", "DB Admim", 1 },
                    { 2, "Motion Recruitment", "", null, "2024-11-20", "I2", "Full Stack Engineer", 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Interviews");
        }
    }
}
