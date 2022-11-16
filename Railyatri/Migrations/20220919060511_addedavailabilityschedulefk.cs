using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Railyatri.Migrations
{
    public partial class addedavailabilityschedulefk : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AvailabilitySchedule_Trainslist_TrainNumberid",
                table: "AvailabilitySchedule");

            migrationBuilder.DropIndex(
                name: "IX_AvailabilitySchedule_TrainNumberid",
                table: "AvailabilitySchedule");

            migrationBuilder.RenameColumn(
                name: "TrainNumberid",
                table: "AvailabilitySchedule",
                newName: "TrainNumberID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TrainNumberID",
                table: "AvailabilitySchedule",
                newName: "TrainNumberid");

            migrationBuilder.CreateIndex(
                name: "IX_AvailabilitySchedule_TrainNumberid",
                table: "AvailabilitySchedule",
                column: "TrainNumberid");

            migrationBuilder.AddForeignKey(
                name: "FK_AvailabilitySchedule_Trainslist_TrainNumberid",
                table: "AvailabilitySchedule",
                column: "TrainNumberid",
                principalTable: "Trainslist",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
