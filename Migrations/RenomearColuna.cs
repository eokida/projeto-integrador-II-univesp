using System;
using Microsoft.EntityFrameworkCore.Migrations;

public partial class RenomearColuna : Migration
{
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.RenameColumn(
            name: "Quantidade em estoque",
            table: "Produtos",
            newName: "QuantidadeEmEstoque");
    }

    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.RenameColumn(
            name: "QuantidadeEmEstoque",
            table: "Produtos",
            newName: "Quantidade em estoque");
    }
}
