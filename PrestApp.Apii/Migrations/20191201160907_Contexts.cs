using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PrestApp.Api.Migrations
{
    public partial class Contexts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    Cli_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TitAcdm_ID = table.Column<int>(nullable: false),
                    Ocu_ID = table.Column<int>(nullable: false),
                    Cli_Nombres = table.Column<string>(nullable: true),
                    Cli_Apellidos = table.Column<string>(nullable: true),
                    Cli_Genero = table.Column<string>(nullable: false),
                    Cli_Cédula = table.Column<string>(nullable: true),
                    Cli_FechaNacimiento = table.Column<string>(nullable: true),
                    Cli_TelCasa = table.Column<string>(nullable: true),
                    Cli_TelCelular = table.Column<string>(nullable: true),
                    Cli_EstadoCivil = table.Column<string>(nullable: true),
                    Cli_Dependientes = table.Column<int>(nullable: false),
                    Cli_Ingresos = table.Column<decimal>(nullable: false),
                    Cli_Dirección = table.Column<string>(nullable: true),
                    Cli_Correo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.Cli_ID);
                });

            migrationBuilder.CreateTable(
                name: "ModalidadesDePago",
                columns: table => new
                {
                    ModPag_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ModPag_Nombre = table.Column<string>(maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModalidadesDePago", x => x.ModPag_ID);
                });

            migrationBuilder.CreateTable(
                name: "Ocupaciones",
                columns: table => new
                {
                    Ocu_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Ocu_Nombre = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ocupaciones", x => x.Ocu_ID);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Rol_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Rol_Nombre = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Rol_ID);
                });

            migrationBuilder.CreateTable(
                name: "TitulosAcademicos",
                columns: table => new
                {
                    TitAcdm_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TitAcdm_Nombre = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TitulosAcademicos", x => x.TitAcdm_ID);
                });

            migrationBuilder.CreateTable(
                name: "Pagos",
                columns: table => new
                {
                    Pag_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Cli_ID = table.Column<int>(nullable: false),
                    Pag_Fecha = table.Column<DateTime>(nullable: false),
                    Pag_BalanceInicial = table.Column<double>(nullable: false),
                    Pag_CuotaPrestamo = table.Column<double>(nullable: false),
                    Pag_Interes = table.Column<double>(nullable: false),
                    Pag_CapitalPendiente = table.Column<double>(nullable: false),
                    Pag_Mora = table.Column<int>(nullable: false),
                    Pag_FormaPago = table.Column<string>(nullable: true),
                    Pag_MontoFinal = table.Column<double>(nullable: false),
                    Pag_InteresAcumulado = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pagos", x => x.Pag_ID);
                    table.ForeignKey(
                        name: "FK_Pagos_Clientes_Cli_ID",
                        column: x => x.Cli_ID,
                        principalTable: "Clientes",
                        principalColumn: "Cli_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Prestamos",
                columns: table => new
                {
                    Prest_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Cli_ID = table.Column<int>(nullable: false),
                    Prest_Monto = table.Column<double>(nullable: false),
                    Prest_Interes = table.Column<double>(nullable: false),
                    Prest_Cuotas = table.Column<int>(nullable: false),
                    Prest_FechaCreacion = table.Column<DateTime>(nullable: false),
                    Prest_FechaPrimerPago = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prestamos", x => x.Prest_ID);
                    table.ForeignKey(
                        name: "FK_Prestamos_Clientes_Cli_ID",
                        column: x => x.Cli_ID,
                        principalTable: "Clientes",
                        principalColumn: "Cli_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Amortizaciones",
                columns: table => new
                {
                    Amort_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Prest_ID = table.Column<int>(nullable: false),
                    Cli_ID = table.Column<int>(nullable: false),
                    ModPag_ID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Amortizaciones", x => x.Amort_ID);
                    table.ForeignKey(
                        name: "FK_Amortizaciones_Clientes_Cli_ID",
                        column: x => x.Cli_ID,
                        principalTable: "Clientes",
                        principalColumn: "Cli_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Amortizaciones_ModalidadesDePago_ModPag_ID",
                        column: x => x.ModPag_ID,
                        principalTable: "ModalidadesDePago",
                        principalColumn: "ModPag_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Usu_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Rol_ID = table.Column<int>(nullable: false),
                    Usu_NombreReal = table.Column<string>(maxLength: 80, nullable: false),
                    Usu_Nombre = table.Column<string>(maxLength: 30, nullable: false),
                    Usu_Clave = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Usu_ID);
                    table.ForeignKey(
                        name: "FK_Usuarios_Roles_Rol_ID",
                        column: x => x.Rol_ID,
                        principalTable: "Roles",
                        principalColumn: "Rol_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Amortizaciones_Cli_ID",
                table: "Amortizaciones",
                column: "Cli_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Amortizaciones_ModPag_ID",
                table: "Amortizaciones",
                column: "ModPag_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Pagos_Cli_ID",
                table: "Pagos",
                column: "Cli_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Prestamos_Cli_ID",
                table: "Prestamos",
                column: "Cli_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_Rol_ID",
                table: "Usuarios",
                column: "Rol_ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Amortizaciones");

            migrationBuilder.DropTable(
                name: "Ocupaciones");

            migrationBuilder.DropTable(
                name: "Pagos");

            migrationBuilder.DropTable(
                name: "Prestamos");

            migrationBuilder.DropTable(
                name: "TitulosAcademicos");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "ModalidadesDePago");

            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "Roles");
        }
    }
}
