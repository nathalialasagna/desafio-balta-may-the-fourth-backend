using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MayTheFourth.Migrations
{
    /// <inheritdoc />
    public partial class Teste : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Filme_FilmeId",
                table: "FilmePlaneta");

            migrationBuilder.DropForeignKey(
                name: "FK_PlanetaFilme_PlanetaId",
                table: "FilmePlaneta");

            migrationBuilder.DropForeignKey(
                name: "FK_VeiculoFilme_VeiculoId",
                table: "FilmePlaneta");

            migrationBuilder.DropForeignKey(
                name: "FK_Planeta_Personagem",
                table: "Personagem");

            migrationBuilder.DropTable(
                name: "FilmePersonagem");

            migrationBuilder.DropTable(
                name: "NavesEstelaresFilme");

            migrationBuilder.DropTable(
                name: "PersonagemFilme");

            migrationBuilder.DropTable(
                name: "PersonagemNavesEstelares");

            migrationBuilder.DropTable(
                name: "PlanetaFilme");

            migrationBuilder.DropTable(
                name: "VeiculoFilme");

            migrationBuilder.DropIndex(
                name: "IX_FilmePlaneta_VeiculoId",
                table: "FilmePlaneta");

            migrationBuilder.DropColumn(
                name: "VeiculoId",
                table: "FilmePlaneta");

            migrationBuilder.RenameColumn(
                name: "PlanetaId",
                table: "FilmePlaneta",
                newName: "PlanetasId");

            migrationBuilder.RenameColumn(
                name: "FilmeId",
                table: "FilmePlaneta",
                newName: "FilmesId");

            migrationBuilder.RenameIndex(
                name: "IX_FilmePlaneta_PlanetaId",
                table: "FilmePlaneta",
                newName: "IX_FilmePlaneta_PlanetasId");

            migrationBuilder.AlterColumn<int>(
                name: "PlanetaId",
                table: "Personagem",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddColumn<int>(
                name: "FilmeId",
                table: "Personagem",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "FilmeNavesEstelares",
                columns: table => new
                {
                    FilmesId = table.Column<int>(type: "INTEGER", nullable: false),
                    NavesId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FilmeNavesEstelares", x => new { x.FilmesId, x.NavesId });
                    table.ForeignKey(
                        name: "FK_FilmeNavesEstelares_Filme_FilmesId",
                        column: x => x.FilmesId,
                        principalTable: "Filme",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FilmeNavesEstelares_NavesEstelares_NavesId",
                        column: x => x.NavesId,
                        principalTable: "NavesEstelares",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FilmeVeiculo",
                columns: table => new
                {
                    FilmesId = table.Column<int>(type: "INTEGER", nullable: false),
                    VeiculosId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FilmeVeiculo", x => new { x.FilmesId, x.VeiculosId });
                    table.ForeignKey(
                        name: "FK_FilmeVeiculo_Filme_FilmesId",
                        column: x => x.FilmesId,
                        principalTable: "Filme",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FilmeVeiculo_Veiculo_VeiculosId",
                        column: x => x.VeiculosId,
                        principalTable: "Veiculo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Personagem_FilmeId",
                table: "Personagem",
                column: "FilmeId");

            migrationBuilder.CreateIndex(
                name: "IX_FilmeNavesEstelares_NavesId",
                table: "FilmeNavesEstelares",
                column: "NavesId");

            migrationBuilder.CreateIndex(
                name: "IX_FilmeVeiculo_VeiculosId",
                table: "FilmeVeiculo",
                column: "VeiculosId");

            migrationBuilder.AddForeignKey(
                name: "FK_FilmePlaneta_Filme_FilmesId",
                table: "FilmePlaneta",
                column: "FilmesId",
                principalTable: "Filme",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FilmePlaneta_Planeta_PlanetasId",
                table: "FilmePlaneta",
                column: "PlanetasId",
                principalTable: "Planeta",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Personagem_Filme_FilmeId",
                table: "Personagem",
                column: "FilmeId",
                principalTable: "Filme",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Personagem_Planeta_PlanetaId",
                table: "Personagem",
                column: "PlanetaId",
                principalTable: "Planeta",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FilmePlaneta_Filme_FilmesId",
                table: "FilmePlaneta");

            migrationBuilder.DropForeignKey(
                name: "FK_FilmePlaneta_Planeta_PlanetasId",
                table: "FilmePlaneta");

            migrationBuilder.DropForeignKey(
                name: "FK_Personagem_Filme_FilmeId",
                table: "Personagem");

            migrationBuilder.DropForeignKey(
                name: "FK_Personagem_Planeta_PlanetaId",
                table: "Personagem");

            migrationBuilder.DropTable(
                name: "FilmeNavesEstelares");

            migrationBuilder.DropTable(
                name: "FilmeVeiculo");

            migrationBuilder.DropIndex(
                name: "IX_Personagem_FilmeId",
                table: "Personagem");

            migrationBuilder.DropColumn(
                name: "FilmeId",
                table: "Personagem");

            migrationBuilder.RenameColumn(
                name: "PlanetasId",
                table: "FilmePlaneta",
                newName: "PlanetaId");

            migrationBuilder.RenameColumn(
                name: "FilmesId",
                table: "FilmePlaneta",
                newName: "FilmeId");

            migrationBuilder.RenameIndex(
                name: "IX_FilmePlaneta_PlanetasId",
                table: "FilmePlaneta",
                newName: "IX_FilmePlaneta_PlanetaId");

            migrationBuilder.AlterColumn<int>(
                name: "PlanetaId",
                table: "Personagem",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "VeiculoId",
                table: "FilmePlaneta",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "FilmePersonagem",
                columns: table => new
                {
                    FilmeId = table.Column<int>(type: "INTEGER", nullable: false),
                    PersonagemId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FilmePersonagem", x => new { x.FilmeId, x.PersonagemId });
                    table.ForeignKey(
                        name: "FK_Filme_FilmeId",
                        column: x => x.FilmeId,
                        principalTable: "Filme",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PersonagemFilme_PersonagemId",
                        column: x => x.PersonagemId,
                        principalTable: "Personagem",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NavesEstelaresFilme",
                columns: table => new
                {
                    FilmeId = table.Column<int>(type: "INTEGER", nullable: false),
                    NavesEstelaresId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NavesEstelaresFilme", x => new { x.FilmeId, x.NavesEstelaresId });
                    table.ForeignKey(
                        name: "FK_FilmeNavesEstelaresId_FilmeId",
                        column: x => x.FilmeId,
                        principalTable: "Filme",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NavesEstelares_NavesEstelaresId",
                        column: x => x.NavesEstelaresId,
                        principalTable: "NavesEstelares",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PersonagemFilme",
                columns: table => new
                {
                    FilmeId = table.Column<int>(type: "INTEGER", nullable: false),
                    PersonagemId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonagemFilme", x => new { x.FilmeId, x.PersonagemId });
                    table.ForeignKey(
                        name: "FK_FilmePersonagem_FilmeId",
                        column: x => x.FilmeId,
                        principalTable: "Filme",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Personagem_PersonagemId",
                        column: x => x.PersonagemId,
                        principalTable: "Personagem",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PersonagemNavesEstelares",
                columns: table => new
                {
                    FilmeId = table.Column<int>(type: "INTEGER", nullable: false),
                    NavesEstelaresId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonagemNavesEstelares", x => new { x.FilmeId, x.NavesEstelaresId });
                    table.ForeignKey(
                        name: "FK_Filme_FilmeId",
                        column: x => x.FilmeId,
                        principalTable: "Filme",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NavesEstelaresFilme_NavesEstelaresId",
                        column: x => x.NavesEstelaresId,
                        principalTable: "NavesEstelares",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PlanetaFilme",
                columns: table => new
                {
                    FilmeId = table.Column<int>(type: "INTEGER", nullable: false),
                    PlanetaId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlanetaFilme", x => new { x.FilmeId, x.PlanetaId });
                    table.ForeignKey(
                        name: "FK_FilmePlaneta_FilmeId",
                        column: x => x.FilmeId,
                        principalTable: "Filme",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Planeta_PlanetaId",
                        column: x => x.PlanetaId,
                        principalTable: "Planeta",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VeiculoFilme",
                columns: table => new
                {
                    FilmeId = table.Column<int>(type: "INTEGER", nullable: false),
                    VeiculoId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VeiculoFilme", x => new { x.FilmeId, x.VeiculoId });
                    table.ForeignKey(
                        name: "FK_FilmeVeiculo_FilmeId",
                        column: x => x.FilmeId,
                        principalTable: "Filme",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Veiculo_VeiculoId",
                        column: x => x.VeiculoId,
                        principalTable: "Veiculo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FilmePlaneta_VeiculoId",
                table: "FilmePlaneta",
                column: "VeiculoId");

            migrationBuilder.CreateIndex(
                name: "IX_FilmePersonagem_PersonagemId",
                table: "FilmePersonagem",
                column: "PersonagemId");

            migrationBuilder.CreateIndex(
                name: "IX_NavesEstelaresFilme_NavesEstelaresId",
                table: "NavesEstelaresFilme",
                column: "NavesEstelaresId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonagemFilme_PersonagemId",
                table: "PersonagemFilme",
                column: "PersonagemId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonagemNavesEstelares_NavesEstelaresId",
                table: "PersonagemNavesEstelares",
                column: "NavesEstelaresId");

            migrationBuilder.CreateIndex(
                name: "IX_PlanetaFilme_PlanetaId",
                table: "PlanetaFilme",
                column: "PlanetaId");

            migrationBuilder.CreateIndex(
                name: "IX_VeiculoFilme_VeiculoId",
                table: "VeiculoFilme",
                column: "VeiculoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Filme_FilmeId",
                table: "FilmePlaneta",
                column: "FilmeId",
                principalTable: "Filme",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PlanetaFilme_PlanetaId",
                table: "FilmePlaneta",
                column: "PlanetaId",
                principalTable: "Planeta",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VeiculoFilme_VeiculoId",
                table: "FilmePlaneta",
                column: "VeiculoId",
                principalTable: "Veiculo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Planeta_Personagem",
                table: "Personagem",
                column: "PlanetaId",
                principalTable: "Planeta",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
