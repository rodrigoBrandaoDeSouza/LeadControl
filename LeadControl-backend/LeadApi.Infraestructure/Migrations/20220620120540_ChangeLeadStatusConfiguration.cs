using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeadApi.Infraestructure.Migrations
{
    public partial class ChangeLeadStatusConfiguration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_LeadStatus_StatusId",
                table: "LeadStatus");

            migrationBuilder.CreateIndex(
                name: "IX_LeadStatus_StatusId",
                table: "LeadStatus",
                column: "StatusId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_LeadStatus_StatusId",
                table: "LeadStatus");

            migrationBuilder.CreateIndex(
                name: "IX_LeadStatus_StatusId",
                table: "LeadStatus",
                column: "StatusId",
                unique: true);
        }
    }
}
