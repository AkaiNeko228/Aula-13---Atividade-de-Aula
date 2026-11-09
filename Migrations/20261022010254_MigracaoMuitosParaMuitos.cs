using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RpgApi.Migrations
{
    /// <inheritdoc />
    public partial class MigracaoMuitosParaMuitos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TB_HABILIDADE",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false),
                    Dano = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_HABILIDADE", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TB_PERSONAGEM_HABILIDADES",
                columns: table => new
                {
                    PersonagemId = table.Column<int>(type: "int", nullable: false),
                    HabilidadeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_PERSONAGEM_HABILIDADES", x => new { x.PersonagemId, x.HabilidadeId });
                    table.ForeignKey(
                        name: "FK_TB_PERSONAGEM_HABILIDADES_TB_HABILIDADE_HabilidadeId",
                        column: x => x.HabilidadeId,
                        principalTable: "TB_HABILIDADE",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TB_PERSONAGEM_HABILIDADES_TB_PERSONAGENS_PersonagemId",
                        column: x => x.PersonagemId,
                        principalTable: "TB_PERSONAGENS",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "TB_HABILIDADE",
                columns: new[] { "Id", "Dano", "Nome" },
                values: new object[,]
                {
                    { 1, 39, "Adomercer" },
                    { 2, 41, "Congelar" },
                    { 3, 37, "Hipnostizar" }
                });

            migrationBuilder.UpdateData(
                table: "TB_USUARIOS",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 174, 21, 116, 12, 18, 172, 215, 172, 114, 42, 125, 199, 154, 99, 88, 92, 228, 34, 237, 223, 83, 176, 218, 229, 173, 152, 52, 236, 148, 39, 125, 229, 148, 23, 251, 81, 17, 44, 163, 95, 91, 140, 47, 6, 35, 247, 115, 247, 196, 141, 210, 128, 213, 244, 108, 11, 148, 146, 160, 239, 151, 201, 142, 163 }, new byte[] { 217, 38, 119, 117, 126, 184, 169, 219, 34, 53, 192, 51, 124, 134, 141, 118, 80, 118, 2, 32, 239, 184, 68, 52, 224, 24, 140, 3, 168, 139, 124, 148, 184, 25, 60, 201, 177, 217, 3, 235, 17, 175, 251, 7, 227, 169, 49, 164, 93, 95, 61, 75, 2, 243, 17, 90, 237, 115, 99, 71, 4, 151, 16, 134, 139, 163, 201, 239, 56, 104, 130, 27, 193, 62, 222, 151, 253, 187, 148, 182, 220, 216, 148, 247, 170, 228, 199, 228, 112, 214, 29, 247, 123, 42, 122, 18, 107, 197, 100, 2, 64, 86, 131, 189, 255, 147, 163, 202, 129, 165, 186, 218, 60, 117, 223, 149, 79, 116, 125, 20, 110, 194, 135, 84, 141, 241, 189, 87 } });

            migrationBuilder.InsertData(
                table: "TB_PERSONAGEM_HABILIDADES",
                columns: new[] { "HabilidadeId", "PersonagemId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 },
                    { 2, 2 },
                    { 2, 3 },
                    { 3, 3 },
                    { 3, 4 },
                    { 1, 5 },
                    { 2, 6 },
                    { 1, 7 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_TB_PERSONAGEM_HABILIDADES_HabilidadeId",
                table: "TB_PERSONAGEM_HABILIDADES",
                column: "HabilidadeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TB_PERSONAGEM_HABILIDADES");

            migrationBuilder.DropTable(
                name: "TB_HABILIDADE");

            migrationBuilder.UpdateData(
                table: "TB_USUARIOS",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 239, 0, 65, 220, 154, 77, 233, 133, 149, 137, 232, 52, 195, 90, 227, 30, 48, 154, 210, 231, 41, 32, 166, 233, 110, 189, 80, 165, 94, 116, 242, 171, 244, 231, 176, 13, 207, 217, 60, 251, 0, 228, 53, 165, 250, 136, 234, 178, 76, 196, 38, 229, 49, 244, 168, 89, 177, 37, 138, 208, 140, 165, 101, 25 }, new byte[] { 181, 234, 164, 94, 251, 99, 59, 141, 213, 52, 158, 53, 146, 134, 126, 166, 135, 165, 165, 88, 186, 137, 200, 82, 147, 182, 181, 220, 65, 48, 91, 87, 200, 11, 42, 122, 22, 60, 68, 189, 213, 37, 76, 83, 185, 127, 174, 75, 230, 95, 208, 97, 181, 124, 158, 0, 39, 185, 197, 190, 238, 56, 195, 233, 34, 57, 206, 47, 46, 120, 162, 199, 25, 144, 40, 141, 188, 27, 106, 63, 211, 191, 237, 9, 214, 253, 236, 65, 113, 134, 84, 13, 130, 212, 2, 48, 251, 201, 232, 24, 55, 48, 194, 103, 238, 149, 4, 183, 81, 87, 56, 115, 28, 136, 5, 187, 207, 221, 44, 161, 207, 68, 231, 223, 68, 143, 214, 127 } });
        }
    }
}
