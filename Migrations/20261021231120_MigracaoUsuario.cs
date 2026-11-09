using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RpgApi.Migrations
{
    /// <inheritdoc />
    public partial class MigracaoUsuario : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Dano", "Nome" },
                values: new object[] { 30, "Glock-18" });

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Dano", "Nome" },
                values: new object[] { 36, "AK-47" });

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Dano", "Nome" },
                values: new object[] { 38, "M4A1-S" });

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Dano", "Nome" },
                values: new object[] { 53, "Desert Eagle" });

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Dano", "Nome" },
                values: new object[] { 115, "AWP" });

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Dano", "Nome" },
                values: new object[] { 35, "Negev" });

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Dano", "Nome" },
                values: new object[] { 26, "P90" });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Dano", "Nome" },
                values: new object[] { 35, "Arco e Flecha" });

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Dano", "Nome" },
                values: new object[] { 33, "Espada" });

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Dano", "Nome" },
                values: new object[] { 31, "Machado" });

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Dano", "Nome" },
                values: new object[] { 30, "Punho" });

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Dano", "Nome" },
                values: new object[] { 34, "Chicote" });

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Dano", "Nome" },
                values: new object[] { 33, "Foice" });

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Dano", "Nome" },
                values: new object[] { 32, "Cajado" });

            migrationBuilder.UpdateData(
                table: "TB_USUARIOS",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 93, 248, 68, 245, 116, 162, 90, 0, 137, 152, 10, 226, 102, 237, 241, 229, 201, 229, 75, 164, 86, 223, 134, 191, 147, 195, 22, 21, 75, 167, 241, 250, 134, 7, 183, 45, 48, 98, 235, 34, 83, 194, 85, 44, 12, 65, 6, 48, 82, 135, 18, 73, 98, 179, 151, 118, 180, 55, 165, 225, 77, 7, 7, 165 }, new byte[] { 7, 180, 89, 64, 218, 0, 227, 78, 203, 13, 254, 141, 129, 54, 85, 130, 11, 111, 231, 77, 112, 228, 238, 232, 17, 233, 198, 168, 133, 11, 252, 83, 81, 108, 85, 165, 204, 20, 58, 191, 219, 56, 91, 153, 246, 118, 139, 12, 115, 56, 187, 76, 143, 252, 25, 110, 149, 49, 123, 252, 44, 69, 136, 170, 68, 10, 245, 44, 140, 217, 59, 12, 210, 131, 192, 45, 202, 95, 20, 163, 30, 28, 77, 187, 152, 207, 104, 32, 33, 127, 98, 249, 209, 85, 92, 152, 2, 75, 7, 209, 128, 4, 73, 102, 145, 16, 5, 182, 142, 175, 161, 17, 84, 17, 226, 77, 64, 221, 127, 12, 50, 233, 209, 100, 138, 190, 56, 151 } });
        }
    }
}
