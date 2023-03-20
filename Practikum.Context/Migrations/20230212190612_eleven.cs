using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Practikum.Context.Migrations
{
    public partial class eleven : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Children_Clients_ClientId",
                table: "Children");

            migrationBuilder.AlterColumn<int>(
                name: "ClientId",
                table: "Children",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Children_Clients_ClientId",
                table: "Children",
                column: "ClientId",
                principalTable: "Clients",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Children_Clients_ClientId",
                table: "Children");

            migrationBuilder.AlterColumn<int>(
                name: "ClientId",
                table: "Children",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Children_Clients_ClientId",
                table: "Children",
                column: "ClientId",
                principalTable: "Clients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
