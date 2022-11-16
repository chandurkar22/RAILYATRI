using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Railyatri.Migrations
{
    public partial class TrainDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Trainslist",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Trainname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrainNumber = table.Column<int>(type: "int", nullable: false),
                    FromStation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ToStation = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trainslist", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "AvailabilitySchedule",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TrainNumberid = table.Column<int>(type: "int", nullable: false),
                    Class = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AvailabilitySchedule", x => x.id);
                    table.ForeignKey(
                        name: "FK_AvailabilitySchedule_Trainslist_TrainNumberid",
                        column: x => x.TrainNumberid,
                        principalTable: "Trainslist",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TrainSchedule",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TrainNumberid = table.Column<int>(type: "int", nullable: false),
                    DepartureTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ArrivalTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainSchedule", x => x.id);
                    table.ForeignKey(
                        name: "FK_TrainSchedule_Trainslist_TrainNumberid",
                        column: x => x.TrainNumberid,
                        principalTable: "Trainslist",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AvailabilitySchedule_TrainNumberid",
                table: "AvailabilitySchedule",
                column: "TrainNumberid");

            migrationBuilder.CreateIndex(
                name: "IX_TrainSchedule_TrainNumberid",
                table: "TrainSchedule",
                column: "TrainNumberid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AvailabilitySchedule");

            migrationBuilder.DropTable(
                name: "TrainSchedule");

            migrationBuilder.DropTable(
                name: "Trainslist");
        }
    }
}
