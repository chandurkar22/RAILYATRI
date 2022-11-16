using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Railyatri.Migrations
{
    public partial class addedtrainschedulefk : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TrainSchedule_Trainslist_TrainNumberid",
                table: "TrainSchedule");

            migrationBuilder.DropIndex(
                name: "IX_TrainSchedule_TrainNumberid",
                table: "TrainSchedule");

            migrationBuilder.RenameColumn(
                name: "TrainNumberid",
                table: "TrainSchedule",
                newName: "TrainNumberID");

            migrationBuilder.AddColumn<int>(
                name: "Trainslistid",
                table: "TrainSchedule",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TrainSchedule_Trainslistid",
                table: "TrainSchedule",
                column: "Trainslistid");

            migrationBuilder.AddForeignKey(
                name: "FK_TrainSchedule_Trainslist_Trainslistid",
                table: "TrainSchedule",
                column: "Trainslistid",
                principalTable: "Trainslist",
                principalColumn: "id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TrainSchedule_Trainslist_Trainslistid",
                table: "TrainSchedule");

            migrationBuilder.DropIndex(
                name: "IX_TrainSchedule_Trainslistid",
                table: "TrainSchedule");

            migrationBuilder.DropColumn(
                name: "Trainslistid",
                table: "TrainSchedule");

            migrationBuilder.RenameColumn(
                name: "TrainNumberID",
                table: "TrainSchedule",
                newName: "TrainNumberid");

            migrationBuilder.CreateIndex(
                name: "IX_TrainSchedule_TrainNumberid",
                table: "TrainSchedule",
                column: "TrainNumberid");

            migrationBuilder.AddForeignKey(
                name: "FK_TrainSchedule_Trainslist_TrainNumberid",
                table: "TrainSchedule",
                column: "TrainNumberid",
                principalTable: "Trainslist",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
