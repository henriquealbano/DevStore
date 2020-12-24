﻿using DevStore.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Text;

namespace DevStore.Infra.Mapping
{
    public class ProductMap : EntityTypeConfiguration<Product>
    {
        public ProductMap()
        {
            ToTable("Product");

            HasKey(x => x.Id);
            
            Property(x => x.Title).HasMaxLength(160).IsRequired();
            Property(x => x.Price).IsRequired();
            Property(x => x.AcquireDate).IsRequired();

            HasRequired(x => x.Category);
        }
    }
}

