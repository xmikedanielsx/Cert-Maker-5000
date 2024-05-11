using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

#nullable disable

namespace MigrationsMySQL.Migrations
{
    public partial class AddMoreBaseFieldsAndAddCertificates : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Address1",
                table: "Participants",
                type: "longtext",
                nullable: false);

            migrationBuilder.AddColumn<string>(
                name: "Address2",
                table: "Participants",
                type: "longtext",
                nullable: false);

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Participants",
                type: "longtext",
                nullable: false);

            migrationBuilder.AddColumn<string>(
                name: "RegisteredEmail",
                table: "Participants",
                type: "longtext",
                nullable: false);

            migrationBuilder.AddColumn<string>(
                name: "State",
                table: "Participants",
                type: "longtext",
                nullable: false);

            migrationBuilder.AddColumn<int>(
                name: "Zip",
                table: "Participants",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Address1",
                table: "Events",
                type: "longtext",
                nullable: false);

            migrationBuilder.AddColumn<string>(
                name: "Address2",
                table: "Events",
                type: "longtext",
                nullable: false);

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Events",
                type: "longtext",
                nullable: false);

            migrationBuilder.AddColumn<string>(
                name: "State",
                table: "Events",
                type: "longtext",
                nullable: false);

            migrationBuilder.AddColumn<string>(
                name: "TemplateFilePath",
                table: "Events",
                type: "longtext",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Zip",
                table: "Events",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Certificates",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    ParticipanstId = table.Column<int>(type: "int", nullable: false),
                    FilePathImage = table.Column<string>(type: "longtext", nullable: true),
                    FilePathPDF = table.Column<string>(type: "longtext", nullable: true),
                    ParticipantId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Certificates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Certificates_Participants_ParticipantId",
                        column: x => x.ParticipantId,
                        principalTable: "Participants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Certificates_ParticipantId",
                table: "Certificates",
                column: "ParticipantId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Certificates");

            migrationBuilder.DropColumn(
                name: "Address1",
                table: "Participants");

            migrationBuilder.DropColumn(
                name: "Address2",
                table: "Participants");

            migrationBuilder.DropColumn(
                name: "City",
                table: "Participants");

            migrationBuilder.DropColumn(
                name: "RegisteredEmail",
                table: "Participants");

            migrationBuilder.DropColumn(
                name: "State",
                table: "Participants");

            migrationBuilder.DropColumn(
                name: "Zip",
                table: "Participants");

            migrationBuilder.DropColumn(
                name: "Address1",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "Address2",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "City",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "State",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "TemplateFilePath",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "Zip",
                table: "Events");
        }
    }
}
