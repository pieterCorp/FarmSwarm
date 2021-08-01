using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FarmSwarm.data.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Decks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Decks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SensorData",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Temperature = table.Column<float>(type: "real", nullable: false),
                    Humidity = table.Column<float>(type: "real", nullable: false),
                    LightIntensity = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SensorData", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GreenHouses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DeckId = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GreenHouses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GreenHouses_Decks_DeckId",
                        column: x => x.DeckId,
                        principalTable: "Decks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DeckId = table.Column<int>(type: "int", nullable: false),
                    DeckPosition = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Locations_Decks_DeckId",
                        column: x => x.DeckId,
                        principalTable: "Decks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Plants",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GreenHouseId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Plants", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Plants_GreenHouses_GreenHouseId",
                        column: x => x.GreenHouseId,
                        principalTable: "GreenHouses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "States",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SensorDataId = table.Column<int>(type: "int", nullable: false),
                    LocationId = table.Column<int>(type: "int", nullable: false),
                    GreenHouseId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_States", x => x.Id);
                    table.ForeignKey(
                        name: "FK_States_GreenHouses_GreenHouseId",
                        column: x => x.GreenHouseId,
                        principalTable: "GreenHouses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_States_Locations_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Locations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_States_SensorData_SensorDataId",
                        column: x => x.SensorDataId,
                        principalTable: "SensorData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Decks",
                columns: new[] { "Id", "CreatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 8, 1, 1, 44, 49, 289, DateTimeKind.Local).AddTicks(6357) },
                    { 2, new DateTime(2021, 8, 1, 1, 44, 49, 289, DateTimeKind.Local).AddTicks(6364) }
                });

            migrationBuilder.InsertData(
                table: "GreenHouses",
                columns: new[] { "Id", "CreatedAt", "DeckId" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 8, 1, 1, 44, 49, 287, DateTimeKind.Local).AddTicks(5114), null },
                    { 2, new DateTime(2021, 8, 1, 1, 44, 49, 287, DateTimeKind.Local).AddTicks(5784), null }
                });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "CreatedAt", "DeckId", "DeckPosition" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 8, 1, 1, 44, 49, 290, DateTimeKind.Local).AddTicks(788), 1, 1 },
                    { 2, new DateTime(2021, 8, 1, 1, 44, 49, 290, DateTimeKind.Local).AddTicks(1784), 1, 2 },
                    { 3, new DateTime(2021, 8, 1, 1, 44, 49, 290, DateTimeKind.Local).AddTicks(1791), 1, 3 },
                    { 4, new DateTime(2021, 8, 1, 1, 44, 49, 290, DateTimeKind.Local).AddTicks(1796), 1, 4 },
                    { 5, new DateTime(2021, 8, 1, 1, 44, 49, 290, DateTimeKind.Local).AddTicks(1801), 1, 5 },
                    { 6, new DateTime(2021, 8, 1, 1, 44, 49, 290, DateTimeKind.Local).AddTicks(1806), 1, 6 }
                });

            migrationBuilder.InsertData(
                table: "Plants",
                columns: new[] { "Id", "CreatedAt", "GreenHouseId", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 8, 1, 1, 44, 49, 289, DateTimeKind.Local).AddTicks(1742), 1, "basil" },
                    { 2, new DateTime(2021, 8, 1, 1, 44, 49, 289, DateTimeKind.Local).AddTicks(2787), 1, "tomato" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_GreenHouses_DeckId",
                table: "GreenHouses",
                column: "DeckId");

            migrationBuilder.CreateIndex(
                name: "IX_Locations_DeckId",
                table: "Locations",
                column: "DeckId");

            migrationBuilder.CreateIndex(
                name: "IX_Plants_GreenHouseId",
                table: "Plants",
                column: "GreenHouseId");

            migrationBuilder.CreateIndex(
                name: "IX_States_GreenHouseId",
                table: "States",
                column: "GreenHouseId");

            migrationBuilder.CreateIndex(
                name: "IX_States_LocationId",
                table: "States",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_States_SensorDataId",
                table: "States",
                column: "SensorDataId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Plants");

            migrationBuilder.DropTable(
                name: "States");

            migrationBuilder.DropTable(
                name: "GreenHouses");

            migrationBuilder.DropTable(
                name: "Locations");

            migrationBuilder.DropTable(
                name: "SensorData");

            migrationBuilder.DropTable(
                name: "Decks");
        }
    }
}
