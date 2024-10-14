using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CrudOperation.Migrations
{
    /// <inheritdoc />
    public partial class PeoplesAndSubject : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "subject_name",
                table: "subject",
                type: "text",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.CreateIndex(
                name: "IX_person_subject_id",
                table: "person",
                column: "subject_id");

            migrationBuilder.AddForeignKey(
                name: "FK_person_subject_subject_id",
                table: "person",
                column: "subject_id",
                principalTable: "subject",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_person_subject_subject_id",
                table: "person");

            migrationBuilder.DropIndex(
                name: "IX_person_subject_id",
                table: "person");

            migrationBuilder.AlterColumn<int>(
                name: "subject_name",
                table: "subject",
                type: "integer",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");
        }
    }
}
