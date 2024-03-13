using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibraryProject.Migrations
{
    public partial class updatePerson : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Persons_AbpRoles_RoleId",
                table: "Persons");

            migrationBuilder.DropForeignKey(
                name: "FK_Persons_AbpUsers_UserId",
                table: "Persons");

            migrationBuilder.AlterColumn<long>(
                name: "UserId",
                table: "Persons",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "RoleId",
                table: "Persons",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Persons_AbpRoles_RoleId",
                table: "Persons",
                column: "RoleId",
                principalTable: "AbpRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Persons_AbpUsers_UserId",
                table: "Persons",
                column: "UserId",
                principalTable: "AbpUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Persons_AbpRoles_RoleId",
                table: "Persons");

            migrationBuilder.DropForeignKey(
                name: "FK_Persons_AbpUsers_UserId",
                table: "Persons");

            migrationBuilder.AlterColumn<long>(
                name: "UserId",
                table: "Persons",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<int>(
                name: "RoleId",
                table: "Persons",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Persons_AbpRoles_RoleId",
                table: "Persons",
                column: "RoleId",
                principalTable: "AbpRoles",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Persons_AbpUsers_UserId",
                table: "Persons",
                column: "UserId",
                principalTable: "AbpUsers",
                principalColumn: "Id");
        }
    }
}
