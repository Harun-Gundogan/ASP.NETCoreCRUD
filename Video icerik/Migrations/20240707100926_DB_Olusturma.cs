using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Video_icerik.Migrations
{
    /// <inheritdoc />
    public partial class DB_Olusturma : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Icerik",
                columns: table => new
                {
                    IcerikId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    YouTubeVideoId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Baslik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UretimTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EgitmeninNotlari = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KullanilanTeknolojiler = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Kategori = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Icerik", x => x.IcerikId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Icerik");
        }
    }
}
