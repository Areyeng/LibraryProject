using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibraryProject.Migrations
{
    public partial class UpdatingModels7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "RoomBookingId",
                table: "Persons",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "LibraryRoom",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoomNumber = table.Column<int>(type: "int", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorUserId = table.Column<long>(type: "bigint", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierUserId = table.Column<long>(type: "bigint", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeleterUserId = table.Column<long>(type: "bigint", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LibraryRoom", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PenaltyFee",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BookId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PersonId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Fee = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    dateOverdue = table.Column<int>(type: "int", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorUserId = table.Column<long>(type: "bigint", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierUserId = table.Column<long>(type: "bigint", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeleterUserId = table.Column<long>(type: "bigint", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PenaltyFee", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PenaltyFee_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PenaltyFee_Persons_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Persons",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "RoomBooking",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BookerId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    RoomId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorUserId = table.Column<long>(type: "bigint", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierUserId = table.Column<long>(type: "bigint", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeleterUserId = table.Column<long>(type: "bigint", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomBooking", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RoomBooking_LibraryRoom_RoomId",
                        column: x => x.RoomId,
                        principalTable: "LibraryRoom",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_RoomBooking_Persons_BookerId",
                        column: x => x.BookerId,
                        principalTable: "Persons",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "RoomSlot",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    timeDisplay = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RoomBookingId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorUserId = table.Column<long>(type: "bigint", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierUserId = table.Column<long>(type: "bigint", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeleterUserId = table.Column<long>(type: "bigint", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomSlot", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RoomSlot_RoomBooking_RoomBookingId",
                        column: x => x.RoomBookingId,
                        principalTable: "RoomBooking",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Persons_RoomBookingId",
                table: "Persons",
                column: "RoomBookingId");

            migrationBuilder.CreateIndex(
                name: "IX_PenaltyFee_BookId",
                table: "PenaltyFee",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_PenaltyFee_PersonId",
                table: "PenaltyFee",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_RoomBooking_BookerId",
                table: "RoomBooking",
                column: "BookerId");

            migrationBuilder.CreateIndex(
                name: "IX_RoomBooking_RoomId",
                table: "RoomBooking",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_RoomSlot_RoomBookingId",
                table: "RoomSlot",
                column: "RoomBookingId");

            migrationBuilder.AddForeignKey(
                name: "FK_Persons_RoomBooking_RoomBookingId",
                table: "Persons",
                column: "RoomBookingId",
                principalTable: "RoomBooking",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Persons_RoomBooking_RoomBookingId",
                table: "Persons");

            migrationBuilder.DropTable(
                name: "PenaltyFee");

            migrationBuilder.DropTable(
                name: "RoomSlot");

            migrationBuilder.DropTable(
                name: "RoomBooking");

            migrationBuilder.DropTable(
                name: "LibraryRoom");

            migrationBuilder.DropIndex(
                name: "IX_Persons_RoomBookingId",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "RoomBookingId",
                table: "Persons");
        }
    }
}
