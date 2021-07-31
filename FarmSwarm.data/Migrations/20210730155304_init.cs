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
                name: "GreenHouses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GreenHouses", x => x.Id);
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
                name: "Locations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CurrentConditionId = table.Column<int>(type: "int", nullable: true),
                    CurrentGreenHouseId = table.Column<int>(type: "int", nullable: true),
                    DeckId = table.Column<int>(type: "int", nullable: true),
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
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Locations_GreenHouses_CurrentGreenHouseId",
                        column: x => x.CurrentGreenHouseId,
                        principalTable: "GreenHouses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Conditions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Temperature = table.Column<float>(type: "real", nullable: false),
                    Humidity = table.Column<float>(type: "real", nullable: false),
                    LightIntensity = table.Column<int>(type: "int", nullable: false),
                    LocationId = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Conditions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Conditions_Locations_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Locations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "GreenHouses",
                columns: new[] { "Id", "CreatedAt" },
                values: new object[] { 1, new DateTime(2021, 7, 30, 17, 53, 4, 213, DateTimeKind.Local).AddTicks(510) });

            migrationBuilder.InsertData(
                table: "GreenHouses",
                columns: new[] { "Id", "CreatedAt" },
                values: new object[] { 2, new DateTime(2021, 7, 30, 17, 53, 4, 213, DateTimeKind.Local).AddTicks(1200) });

            migrationBuilder.InsertData(
                table: "Plants",
                columns: new[] { "Id", "CreatedAt", "GreenHouseId", "Name" },
                values: new object[] { 1, new DateTime(2021, 7, 30, 17, 53, 4, 214, DateTimeKind.Local).AddTicks(7041), 1, "basil" });

            migrationBuilder.InsertData(
                table: "Plants",
                columns: new[] { "Id", "CreatedAt", "GreenHouseId", "Name" },
                values: new object[] { 2, new DateTime(2021, 7, 30, 17, 53, 4, 214, DateTimeKind.Local).AddTicks(8086), 1, "tomato" });

            migrationBuilder.CreateIndex(
                name: "IX_Conditions_LocationId",
                table: "Conditions",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_Locations_CurrentConditionId",
                table: "Locations",
                column: "CurrentConditionId");

            migrationBuilder.CreateIndex(
                name: "IX_Locations_CurrentGreenHouseId",
                table: "Locations",
                column: "CurrentGreenHouseId");

            migrationBuilder.CreateIndex(
                name: "IX_Locations_DeckId",
                table: "Locations",
                column: "DeckId");

            migrationBuilder.CreateIndex(
                name: "IX_Plants_GreenHouseId",
                table: "Plants",
                column: "GreenHouseId");

            migrationBuilder.AddForeignKey(
                name: "FK_Locations_Conditions_CurrentConditionId",
                table: "Locations",
                column: "CurrentConditionId",
                principalTable: "Conditions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Conditions_Locations_LocationId",
                table: "Conditions");

            migrationBuilder.DropTable(
                name: "Plants");

            migrationBuilder.DropTable(
                name: "Locations");

            migrationBuilder.DropTable(
                name: "Conditions");

            migrationBuilder.DropTable(
                name: "Decks");

            migrationBuilder.DropTable(
                name: "GreenHouses");
        }
    }
}
