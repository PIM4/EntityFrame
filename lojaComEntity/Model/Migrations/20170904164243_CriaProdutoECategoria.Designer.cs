using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations;
using lojaComEntity;

namespace lojaComEntity.Migrations
{
    [DbContext(typeof(EntidadesContext))]
    [Migration("20170904164243_CriaProdutoECategoria")]
    partial class CriaProdutoECategoria
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-rc1-16348")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("lojaComEntity.Entity.Usuario", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nome");

                    b.Property<string>("Senha");

                    b.HasKey("ID");
                });

            modelBuilder.Entity("lojaComEntity.Model.Entity.Categoria", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("nome");

                    b.HasKey("ID");
                });

            modelBuilder.Entity("lojaComEntity.Model.Entity.Produto", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CategoriaID");

                    b.Property<string>("nome");

                    b.Property<float>("preco");

                    b.HasKey("ID");
                });

            modelBuilder.Entity("lojaComEntity.Model.Entity.Produto", b =>
                {
                    b.HasOne("lojaComEntity.Model.Entity.Categoria")
                        .WithMany()
                        .HasForeignKey("CategoriaID");
                });
        }
    }
}
