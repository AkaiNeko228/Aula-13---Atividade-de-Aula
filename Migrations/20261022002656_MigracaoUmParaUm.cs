using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RpgApi.Migrations
{
    /// <inheritdoc />
    public partial class MigracaoUmParaUm : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.AddColumn<int>(
                name: "Derrotas",
                table: "TB_PERSONAGENS",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Disputas",
                table: "TB_PERSONAGENS",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Vitorias",
                table: "TB_PERSONAGENS",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PersonagemId",
                table: "TB_ARMAS",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 1,
                column: "PersonagemId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 2,
                column: "PersonagemId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 3,
                column: "PersonagemId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 4,
                column: "PersonagemId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 5,
                column: "PersonagemId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 6,
                column: "PersonagemId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 7,
                column: "PersonagemId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Derrotas", "Disputas", "Vitorias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Derrotas", "Disputas", "Vitorias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Derrotas", "Disputas", "Vitorias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Derrotas", "Disputas", "Vitorias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Derrotas", "Disputas", "Vitorias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Derrotas", "Disputas", "Vitorias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Derrotas", "Disputas", "Vitorias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "TB_USUARIOS",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 239, 0, 65, 220, 154, 77, 233, 133, 149, 137, 232, 52, 195, 90, 227, 30, 48, 154, 210, 231, 41, 32, 166, 233, 110, 189, 80, 165, 94, 116, 242, 171, 244, 231, 176, 13, 207, 217, 60, 251, 0, 228, 53, 165, 250, 136, 234, 178, 76, 196, 38, 229, 49, 244, 168, 89, 177, 37, 138, 208, 140, 165, 101, 25 }, new byte[] { 181, 234, 164, 94, 251, 99, 59, 141, 213, 52, 158, 53, 146, 134, 126, 166, 135, 165, 165, 88, 186, 137, 200, 82, 147, 182, 181, 220, 65, 48, 91, 87, 200, 11, 42, 122, 22, 60, 68, 189, 213, 37, 76, 83, 185, 127, 174, 75, 230, 95, 208, 97, 181, 124, 158, 0, 39, 185, 197, 190, 238, 56, 195, 233, 34, 57, 206, 47, 46, 120, 162, 199, 25, 144, 40, 141, 188, 27, 106, 63, 211, 191, 237, 9, 214, 253, 236, 65, 113, 134, 84, 13, 130, 212, 2, 48, 251, 201, 232, 24, 55, 48, 194, 103, 238, 149, 4, 183, 81, 87, 56, 115, 28, 136, 5, 187, 207, 221, 44, 161, 207, 68, 231, 223, 68, 143, 214, 127 } });

            migrationBuilder.CreateIndex(
                name: "IX_TB_ARMAS_PersonagemId",
                table: "TB_ARMAS",
                column: "PersonagemId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_TB_ARMAS_TB_PERSONAGENS_PersonagemId",
                table: "TB_ARMAS",
                column: "PersonagemId",
                principalTable: "TB_PERSONAGENS",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TB_ARMAS_TB_PERSONAGENS_PersonagemId",
                table: "TB_ARMAS");

            migrationBuilder.DropIndex(
                name: "IX_TB_ARMAS_PersonagemId",
                table: "TB_ARMAS");

            migrationBuilder.DropColumn(
                name: "Derrotas",
                table: "TB_PERSONAGENS");

            migrationBuilder.DropColumn(
                name: "Disputas",
                table: "TB_PERSONAGENS");

            migrationBuilder.DropColumn(
                name: "Vitorias",
                table: "TB_PERSONAGENS");

            migrationBuilder.DropColumn(
                name: "PersonagemId",
                table: "TB_ARMAS");

            migrationBuilder.InsertData(
                table: "TB_ARMAS",
                columns: new[] { "Id", "Dano", "Nome" },
                values: new object[,]
                {
                    { 8, 26, "MP9" },
                    { 9, 30, "FAMAS" },
                    { 10, 26, "Bizon" },
                    { 11, 35, "USP-S" },
                    { 12, 35, "P250" },
                    { 13, 29, "MAC-10" },
                    { 14, 29, "MP7" },
                    { 15, 88, "SSG-08(Scout)" }
                });

            migrationBuilder.UpdateData(
                table: "TB_USUARIOS",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 133, 108, 114, 216, 146, 161, 4, 134, 194, 135, 147, 221, 8, 155, 127, 110, 115, 12, 242, 187, 141, 26, 226, 206, 18, 128, 40, 94, 114, 172, 107, 219, 174, 43, 162, 255, 195, 209, 86, 174, 230, 134, 133, 116, 196, 139, 172, 191, 90, 212, 26, 125, 1, 55, 230, 190, 189, 42, 74, 146, 141, 134, 202, 94 }, new byte[] { 51, 108, 5, 217, 238, 168, 201, 225, 157, 125, 211, 178, 215, 117, 191, 214, 132, 18, 126, 162, 132, 205, 167, 187, 6, 183, 7, 127, 210, 176, 104, 229, 143, 111, 138, 148, 135, 167, 32, 217, 189, 86, 106, 123, 55, 20, 163, 155, 119, 61, 155, 7, 225, 28, 11, 60, 89, 102, 43, 101, 148, 141, 62, 255, 180, 155, 59, 42, 97, 113, 95, 53, 122, 200, 203, 172, 195, 127, 211, 197, 15, 252, 57, 119, 255, 49, 205, 13, 105, 15, 1, 57, 12, 164, 145, 59, 166, 157, 48, 192, 109, 238, 141, 251, 88, 75, 241, 238, 229, 81, 27, 198, 100, 255, 23, 214, 163, 52, 53, 138, 166, 15, 126, 239, 179, 35, 81, 65 } });
        }
    }
}
