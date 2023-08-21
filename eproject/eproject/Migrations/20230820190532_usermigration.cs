using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eproject.Migrations
{
    public partial class usermigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tbl_user",
                columns: table => new
                {
                    user_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    user_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    user_username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    user_email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    user_password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    user_phone = table.Column<int>(type: "int", nullable: false),
                    user_gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    user_dob = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    user_image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    user_country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    user_city = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    user_address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    user_marital_status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    user_qualification = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    user_school = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    user_college = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    user_work_status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    user_organization = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    user_designation = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_user", x => x.user_id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbl_user");
        }
    }
}
