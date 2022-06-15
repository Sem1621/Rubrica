using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Rubrica.Migrations
{
    public partial class SecondaMigrazione : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Contacts");

            migrationBuilder.DropColumn(
                name: "Surname",
                table: "Contacts");

            migrationBuilder.AddColumn<int>(
                name: "tipoContattoId",
                table: "Contacts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "utenteId",
                table: "Contacts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "TipoContatto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    telefono = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoContatto", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Utente",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Utente", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_tipoContattoId",
                table: "Contacts",
                column: "tipoContattoId");

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_utenteId",
                table: "Contacts",
                column: "utenteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Contacts_TipoContatto_tipoContattoId",
                table: "Contacts",
                column: "tipoContattoId",
                principalTable: "TipoContatto",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Contacts_Utente_utenteId",
                table: "Contacts",
                column: "utenteId",
                principalTable: "Utente",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contacts_TipoContatto_tipoContattoId",
                table: "Contacts");

            migrationBuilder.DropForeignKey(
                name: "FK_Contacts_Utente_utenteId",
                table: "Contacts");

            migrationBuilder.DropTable(
                name: "TipoContatto");

            migrationBuilder.DropTable(
                name: "Utente");

            migrationBuilder.DropIndex(
                name: "IX_Contacts_tipoContattoId",
                table: "Contacts");

            migrationBuilder.DropIndex(
                name: "IX_Contacts_utenteId",
                table: "Contacts");

            migrationBuilder.DropColumn(
                name: "tipoContattoId",
                table: "Contacts");

            migrationBuilder.DropColumn(
                name: "utenteId",
                table: "Contacts");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Contacts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Surname",
                table: "Contacts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
