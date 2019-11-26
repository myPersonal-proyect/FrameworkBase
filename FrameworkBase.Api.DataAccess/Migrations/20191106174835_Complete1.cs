using Microsoft.EntityFrameworkCore.Migrations;

namespace FrameworkBase.Api.DataAccess.Migrations
{
    public partial class Complete1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_Offices_OfficeId",
                table: "Bookings");

            migrationBuilder.DropForeignKey(
                name: "FK_Office2Room_Offices_OfficeId",
                table: "Office2Room");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Offices",
                table: "Offices");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Office2Room",
                table: "Office2Room");

            migrationBuilder.DropColumn(
                name: "OfficeId",
                table: "Offices");

            migrationBuilder.DropColumn(
                name: "OfficeId",
                table: "Office2Room");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Offices",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Office2Room",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Offices",
                table: "Offices",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Office2Room",
                table: "Office2Room",
                columns: new[] { "Id", "RoomId" });

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_Offices_OfficeId",
                table: "Bookings",
                column: "OfficeId",
                principalTable: "Offices",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Office2Room_Offices_Id",
                table: "Office2Room",
                column: "Id",
                principalTable: "Offices",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_Offices_OfficeId",
                table: "Bookings");

            migrationBuilder.DropForeignKey(
                name: "FK_Office2Room_Offices_Id",
                table: "Office2Room");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Offices",
                table: "Offices");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Office2Room",
                table: "Office2Room");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Offices");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Office2Room");

            migrationBuilder.AddColumn<int>(
                name: "OfficeId",
                table: "Offices",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "OfficeId",
                table: "Office2Room",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Offices",
                table: "Offices",
                column: "OfficeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Office2Room",
                table: "Office2Room",
                columns: new[] { "OfficeId", "RoomId" });

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_Offices_OfficeId",
                table: "Bookings",
                column: "OfficeId",
                principalTable: "Offices",
                principalColumn: "OfficeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Office2Room_Offices_OfficeId",
                table: "Office2Room",
                column: "OfficeId",
                principalTable: "Offices",
                principalColumn: "OfficeId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
