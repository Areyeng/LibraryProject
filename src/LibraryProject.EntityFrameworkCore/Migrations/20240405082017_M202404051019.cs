using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibraryProject.Migrations
{
    public partial class M202404051019 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookRequests_Person_PersonId",
                table: "BookRequests");

            migrationBuilder.DropForeignKey(
                name: "FK_BookRequests_Person_ReleasedById",
                table: "BookRequests");

            migrationBuilder.DropForeignKey(
                name: "FK_EventRegistrations_Person_PersonId",
                table: "EventRegistrations");

            migrationBuilder.DropForeignKey(
                name: "FK_MyLibraries_Person_PersonId",
                table: "MyLibraries");

            migrationBuilder.DropForeignKey(
                name: "FK_PenaltyFee_Person_PersonId",
                table: "PenaltyFee");

            migrationBuilder.DropForeignKey(
                name: "FK_Person_AbpUsers_UserId",
                table: "Person");

            migrationBuilder.DropForeignKey(
                name: "FK_Person_RoomBooking_RoomBookingId",
                table: "Person");

            migrationBuilder.DropForeignKey(
                name: "FK_RoomBooking_Person_BookerId",
                table: "RoomBooking");

            migrationBuilder.DropForeignKey(
                name: "FK_SettingPreferences_Person_PersonId",
                table: "SettingPreferences");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Person",
                table: "Person");

            migrationBuilder.RenameTable(
                name: "Person",
                newName: "Persons");

            migrationBuilder.RenameIndex(
                name: "IX_Person_UserId",
                table: "Persons",
                newName: "IX_Persons_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Person_RoomBookingId",
                table: "Persons",
                newName: "IX_Persons_RoomBookingId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Persons",
                table: "Persons",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BookRequests_Persons_PersonId",
                table: "BookRequests",
                column: "PersonId",
                principalTable: "Persons",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BookRequests_Persons_ReleasedById",
                table: "BookRequests",
                column: "ReleasedById",
                principalTable: "Persons",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_EventRegistrations_Persons_PersonId",
                table: "EventRegistrations",
                column: "PersonId",
                principalTable: "Persons",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MyLibraries_Persons_PersonId",
                table: "MyLibraries",
                column: "PersonId",
                principalTable: "Persons",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PenaltyFee_Persons_PersonId",
                table: "PenaltyFee",
                column: "PersonId",
                principalTable: "Persons",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Persons_AbpUsers_UserId",
                table: "Persons",
                column: "UserId",
                principalTable: "AbpUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Persons_RoomBooking_RoomBookingId",
                table: "Persons",
                column: "RoomBookingId",
                principalTable: "RoomBooking",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_RoomBooking_Persons_BookerId",
                table: "RoomBooking",
                column: "BookerId",
                principalTable: "Persons",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SettingPreferences_Persons_PersonId",
                table: "SettingPreferences",
                column: "PersonId",
                principalTable: "Persons",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookRequests_Persons_PersonId",
                table: "BookRequests");

            migrationBuilder.DropForeignKey(
                name: "FK_BookRequests_Persons_ReleasedById",
                table: "BookRequests");

            migrationBuilder.DropForeignKey(
                name: "FK_EventRegistrations_Persons_PersonId",
                table: "EventRegistrations");

            migrationBuilder.DropForeignKey(
                name: "FK_MyLibraries_Persons_PersonId",
                table: "MyLibraries");

            migrationBuilder.DropForeignKey(
                name: "FK_PenaltyFee_Persons_PersonId",
                table: "PenaltyFee");

            migrationBuilder.DropForeignKey(
                name: "FK_Persons_AbpUsers_UserId",
                table: "Persons");

            migrationBuilder.DropForeignKey(
                name: "FK_Persons_RoomBooking_RoomBookingId",
                table: "Persons");

            migrationBuilder.DropForeignKey(
                name: "FK_RoomBooking_Persons_BookerId",
                table: "RoomBooking");

            migrationBuilder.DropForeignKey(
                name: "FK_SettingPreferences_Persons_PersonId",
                table: "SettingPreferences");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Persons",
                table: "Persons");

            migrationBuilder.RenameTable(
                name: "Persons",
                newName: "Person");

            migrationBuilder.RenameIndex(
                name: "IX_Persons_UserId",
                table: "Person",
                newName: "IX_Person_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Persons_RoomBookingId",
                table: "Person",
                newName: "IX_Person_RoomBookingId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Person",
                table: "Person",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BookRequests_Person_PersonId",
                table: "BookRequests",
                column: "PersonId",
                principalTable: "Person",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BookRequests_Person_ReleasedById",
                table: "BookRequests",
                column: "ReleasedById",
                principalTable: "Person",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_EventRegistrations_Person_PersonId",
                table: "EventRegistrations",
                column: "PersonId",
                principalTable: "Person",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MyLibraries_Person_PersonId",
                table: "MyLibraries",
                column: "PersonId",
                principalTable: "Person",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PenaltyFee_Person_PersonId",
                table: "PenaltyFee",
                column: "PersonId",
                principalTable: "Person",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Person_AbpUsers_UserId",
                table: "Person",
                column: "UserId",
                principalTable: "AbpUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Person_RoomBooking_RoomBookingId",
                table: "Person",
                column: "RoomBookingId",
                principalTable: "RoomBooking",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_RoomBooking_Person_BookerId",
                table: "RoomBooking",
                column: "BookerId",
                principalTable: "Person",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SettingPreferences_Person_PersonId",
                table: "SettingPreferences",
                column: "PersonId",
                principalTable: "Person",
                principalColumn: "Id");
        }
    }
}
