using MeuCorre.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuCorre.Infra.Data.Configurations
{
    internal class TagConfiguration : IEntityTypeConfiguration<Tag>
    {
        public void Configure(EntityTypeBuilder<Tag> builder)
        {
            //Define o nome da tabela no banco de dados.
            builder.ToTable("Tags");

            //Define a chave primária.
            builder.HasKey(tag => tag.Id);

            //Define as propriedades da entidade e suas configurações.
            builder.Property(tag => tag.Nome)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(tag => tag.Cor)
                .IsRequired()
                .HasMaxLength(255);


            builder.Property(tag => tag.DataCriacao)
                .IsRequired();

            builder.Property(tag => tag.DataAtualizacao)
                .IsRequired(false);

            //Define que o nome é único.
            builder.HasIndex(tag => tag.Nome)
                .IsUnique();

            //Chaves Estrangeiras FK
            //Define o relacionamento entre Subcategoria e Usuario 
            builder.HasOne(tag => tag.Usuario)
                .WithMany(usuario => usuario.Tag)
                .HasForeignKey(tag => tag.UsuarioId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
