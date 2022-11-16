using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Railyatri.Migrations
{
    public partial class updateavailabilityschedulefk : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TrainNumberID",
                table: "AvailabilitySchedule",
                newName: "TrainslistId");

            migrationBuilder.CreateIndex(
                name: "IX_AvailabilitySchedule_TrainslistId",
                table: "AvailabilitySchedule",
                column: "TrainslistId");

            migrationBuilder.AddForeignKey(
                name: "FK_AvailabilitySchedule_Trainslist_TrainslistId",
                table: "AvailabilitySchedule",
                column: "TrainslistId",
                principalTable: "Trainslist",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AvailabilitySchedule_Trainslist_TrainslistId",
                table: "AvailabilitySchedule");

            migrationBuilder.DropIndex(
                name: "IX_AvailabilitySchedule_TrainslistId",
                table: "AvailabilitySchedule");

            migrationBuilder.RenameColumn(
                name: "TrainslistId",
                table: "AvailabilitySchedule",
                newName: "TrainNumberID");
        }
    }
}
