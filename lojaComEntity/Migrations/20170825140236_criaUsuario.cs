using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;
using Microsoft.Data.Entity.Metadata;

namespace lojaComEntity.Migrations
{
    public partial class criaUsuario : Migration
    {   
        // Metodos criados no migration, que é a classe que ela herda, 
        // Metodo Up cria a tabela, baseado na entidade Usuario
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: true),
                    Senha = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.ID);
                });
        }
        // Metodo Down apaga a tabela
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable("Usuario");
        }
    }
}
