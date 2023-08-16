using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistencia.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Genero",
                columns: table => new
                {
                    Genero_PK = table.Column<string>(type: "varchar(25)", maxLength: 25, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genero", x => x.Genero_PK);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Pais",
                columns: table => new
                {
                    Pais_FK = table.Column<string>(type: "varchar(85)", maxLength: 85, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pais", x => x.Pais_FK);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Salon",
                columns: table => new
                {
                    PKSalon = table.Column<string>(type: "varchar(25)", maxLength: 25, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Capacidad = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Salon", x => x.PKSalon);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TipoDeDocumento",
                columns: table => new
                {
                    PKNombreTipo = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoDeDocumento", x => x.PKNombreTipo);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TipoPersona",
                columns: table => new
                {
                    PKTipoPersona = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Descripcion = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoPersona", x => x.PKTipoPersona);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TipoVia",
                columns: table => new
                {
                    PKNombreTipoVia = table.Column<string>(type: "varchar(25)", maxLength: 25, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Abreviatura = table.Column<string>(type: "varchar(5)", maxLength: 5, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoVia", x => x.PKNombreTipoVia);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Departamento",
                columns: table => new
                {
                    Departamento_FK = table.Column<string>(type: "varchar(40)", maxLength: 40, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Pais_FK = table.Column<string>(type: "varchar(85)", maxLength: 85, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departamento", x => x.Departamento_FK);
                    table.ForeignKey(
                        name: "FK_Departamento_Pais_Pais_FK",
                        column: x => x.Pais_FK,
                        principalTable: "Pais",
                        principalColumn: "Pais_FK",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Ciudad",
                columns: table => new
                {
                    PKCiudad = table.Column<string>(type: "varchar(85)", maxLength: 85, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Departamento_FK = table.Column<string>(type: "varchar(40)", maxLength: 40, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ciudad", x => x.PKCiudad);
                    table.ForeignKey(
                        name: "FK_Ciudad_Departamento_Departamento_FK",
                        column: x => x.Departamento_FK,
                        principalTable: "Departamento",
                        principalColumn: "Departamento_FK",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Persona",
                columns: table => new
                {
                    Cedula_PK = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombres = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Apellidos = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TipoDeDocumento_FK = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Genero_FK = table.Column<string>(type: "varchar(25)", maxLength: 25, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Ciudad_FK = table.Column<string>(type: "varchar(85)", maxLength: 85, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TipoPersona_FK = table.Column<string>(type: "varchar(25)", maxLength: 25, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persona", x => x.Cedula_PK);
                    table.ForeignKey(
                        name: "FK_Persona_Ciudad_Ciudad_FK",
                        column: x => x.Ciudad_FK,
                        principalTable: "Ciudad",
                        principalColumn: "PKCiudad",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Persona_Genero_Genero_FK",
                        column: x => x.Genero_FK,
                        principalTable: "Genero",
                        principalColumn: "Genero_PK",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Persona_TipoDeDocumento_TipoDeDocumento_FK",
                        column: x => x.TipoDeDocumento_FK,
                        principalTable: "TipoDeDocumento",
                        principalColumn: "PKNombreTipo",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Persona_TipoPersona_TipoPersona_FK",
                        column: x => x.TipoPersona_FK,
                        principalTable: "TipoPersona",
                        principalColumn: "PKTipoPersona",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Direccion",
                columns: table => new
                {
                    PKDireccion = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TipoVia_FK = table.Column<string>(type: "varchar(25)", maxLength: 25, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NroDireccion = table.Column<int>(type: "int", nullable: false),
                    varchar = table.Column<string>(type: "varchar(5)", maxLength: 5, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SufijoCardinal = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NroViaSecundaria = table.Column<int>(type: "int", nullable: false),
                    LetraViaSecundaria = table.Column<string>(type: "varchar(5)", maxLength: 5, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SufijoCardinalVS = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Persona_FK = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Direccion", x => x.PKDireccion);
                    table.ForeignKey(
                        name: "FK_Direccion_Persona_Persona_FK",
                        column: x => x.Persona_FK,
                        principalTable: "Persona",
                        principalColumn: "Cedula_PK",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Direccion_TipoVia_TipoVia_FK",
                        column: x => x.TipoVia_FK,
                        principalTable: "TipoVia",
                        principalColumn: "PKNombreTipoVia",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Matricula",
                columns: table => new
                {
                    Persona_FK = table.Column<long>(type: "bigint", nullable: false),
                    Salon_FK = table.Column<string>(type: "varchar(25)", maxLength: 25, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Matricula", x => x.Persona_FK);
                    table.ForeignKey(
                        name: "FK_Matricula_Persona_Persona_FK",
                        column: x => x.Persona_FK,
                        principalTable: "Persona",
                        principalColumn: "Cedula_PK",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Matricula_Salon_Salon_FK",
                        column: x => x.Salon_FK,
                        principalTable: "Salon",
                        principalColumn: "PKSalon",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TrainerSalon",
                columns: table => new
                {
                    Persona_FK = table.Column<long>(type: "bigint", nullable: false),
                    Salon_FK = table.Column<string>(type: "varchar(25)", maxLength: 25, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainerSalon", x => x.Persona_FK);
                    table.ForeignKey(
                        name: "FK_TrainerSalon_Persona_Persona_FK",
                        column: x => x.Persona_FK,
                        principalTable: "Persona",
                        principalColumn: "Cedula_PK",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TrainerSalon_Salon_Salon_FK",
                        column: x => x.Salon_FK,
                        principalTable: "Salon",
                        principalColumn: "PKSalon",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Ciudad_Departamento_FK",
                table: "Ciudad",
                column: "Departamento_FK");

            migrationBuilder.CreateIndex(
                name: "IX_Departamento_Pais_FK",
                table: "Departamento",
                column: "Pais_FK");

            migrationBuilder.CreateIndex(
                name: "IX_Direccion_Persona_FK",
                table: "Direccion",
                column: "Persona_FK");

            migrationBuilder.CreateIndex(
                name: "IX_Direccion_TipoVia_FK",
                table: "Direccion",
                column: "TipoVia_FK");

            migrationBuilder.CreateIndex(
                name: "IX_Matricula_Salon_FK",
                table: "Matricula",
                column: "Salon_FK");

            migrationBuilder.CreateIndex(
                name: "IX_Persona_Ciudad_FK",
                table: "Persona",
                column: "Ciudad_FK");

            migrationBuilder.CreateIndex(
                name: "IX_Persona_Genero_FK",
                table: "Persona",
                column: "Genero_FK");

            migrationBuilder.CreateIndex(
                name: "IX_Persona_TipoDeDocumento_FK",
                table: "Persona",
                column: "TipoDeDocumento_FK");

            migrationBuilder.CreateIndex(
                name: "IX_Persona_TipoPersona_FK",
                table: "Persona",
                column: "TipoPersona_FK");

            migrationBuilder.CreateIndex(
                name: "IX_TrainerSalon_Salon_FK",
                table: "TrainerSalon",
                column: "Salon_FK");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Direccion");

            migrationBuilder.DropTable(
                name: "Matricula");

            migrationBuilder.DropTable(
                name: "TrainerSalon");

            migrationBuilder.DropTable(
                name: "TipoVia");

            migrationBuilder.DropTable(
                name: "Persona");

            migrationBuilder.DropTable(
                name: "Salon");

            migrationBuilder.DropTable(
                name: "Ciudad");

            migrationBuilder.DropTable(
                name: "Genero");

            migrationBuilder.DropTable(
                name: "TipoDeDocumento");

            migrationBuilder.DropTable(
                name: "TipoPersona");

            migrationBuilder.DropTable(
                name: "Departamento");

            migrationBuilder.DropTable(
                name: "Pais");
        }
    }
}
