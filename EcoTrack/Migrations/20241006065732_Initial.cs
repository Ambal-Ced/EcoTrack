using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EcoTrack.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "electrates",
                columns: table => new
                {
                    sepa = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ids = table.Column<int>(type: "int", nullable: false),
                    kwrate = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    totbillelec = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    dates1 = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_electrates", x => x.sepa);
                });

            migrationBuilder.CreateTable(
                name: "info",
                columns: table => new
                {
                    ids = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    lname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    fname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    mname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    type_ = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    conto = table.Column<int>(type: "int", nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_info", x => x.ids);
                });

            migrationBuilder.CreateTable(
                name: "insights",
                columns: table => new
                {
                    iid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    insight = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ids = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_insights", x => x.iid);
                });

            migrationBuilder.CreateTable(
                name: "pfeed",
                columns: table => new
                {
                    fid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ids = table.Column<int>(type: "int", nullable: false),
                    feedbacks = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pfeed", x => x.fid);
                });

            migrationBuilder.CreateTable(
                name: "ppost",
                columns: table => new
                {
                    pid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ids = table.Column<int>(type: "int", nullable: false),
                    feedbacks = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ppost", x => x.pid);
                });

            migrationBuilder.CreateTable(
                name: "waterrates",
                columns: table => new
                {
                    sepb = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ids = table.Column<int>(type: "int", nullable: false),
                    cbrate = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    totbillwater = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    dates2 = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_waterrates", x => x.sepb);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "electrates");

            migrationBuilder.DropTable(
                name: "info");

            migrationBuilder.DropTable(
                name: "insights");

            migrationBuilder.DropTable(
                name: "pfeed");

            migrationBuilder.DropTable(
                name: "ppost");

            migrationBuilder.DropTable(
                name: "waterrates");
        }
    }
}
