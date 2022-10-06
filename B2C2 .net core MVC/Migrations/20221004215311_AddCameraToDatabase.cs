using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace B2C2_.net_core_MVC.Migrations
{
    public partial class AddCameraToDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cameras",
                columns: table => new
                {
                    CameraId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CameraMerk = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CameraType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CameraRichting = table.Column<int>(type: "int", nullable: false),
                    Latitude = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Longitude = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GeplaatstDoor = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cameras", x => x.CameraId);
                });

            migrationBuilder.CreateTable(
                name: "Fotos",
                columns: table => new
                {
                    FotoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FotoLink = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FotoGeplaatstDoor = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fotos", x => x.FotoId);
                });

            migrationBuilder.CreateTable(
                name: "Gebruikers",
                columns: table => new
                {
                    GebruikerID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GebruikerNaam = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AanmaakDatum = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GeboorteDatum = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Wachtwoord = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmailAdres = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsBeheerder = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gebruikers", x => x.GebruikerID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cameras");

            migrationBuilder.DropTable(
                name: "Fotos");

            migrationBuilder.DropTable(
                name: "Gebruikers");
        }
    }
}
