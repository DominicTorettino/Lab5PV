using Microsoft.EntityFrameworkCore.Migrations;

namespace ESTeCar.Migrations
{
    public partial class restrictions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NumeroDePassageiros",
                table: "Carro");

            migrationBuilder.AlterColumn<string>(
                name: "Designacao",
                table: "Marca",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Modelo",
                table: "Carro",
                maxLength: 25,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Designacao",
                table: "Marca",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "Modelo",
                table: "Carro",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 25);

            migrationBuilder.AddColumn<int>(
                name: "NumeroDePassageiros",
                table: "Carro",
                nullable: false,
                defaultValue: 0);
        }
    }
}
