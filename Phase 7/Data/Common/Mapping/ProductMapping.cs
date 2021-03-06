﻿namespace Pezza.Common.Mapping
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Pezza.Common.DTO;
    using Pezza.Common.Entities;

    public static class ProductMapping
    {
        public static ProductDTO Map(this Product entity) =>
           (entity != null) ? new ProductDTO
           {
               Id = entity.Id,
               DateCreated = entity.DateCreated,
               Description = entity.Description,
               IsActive = entity.IsActive,
               Name = entity.Name,
               OfferEndDate = entity.OfferEndDate,
               OfferPrice = entity.OfferPrice,
               PictureUrl = entity.PictureUrl,
               Price = entity.Price,
               Special = entity.Special

           } : null;

        public static IEnumerable<ProductDTO> Map(this IEnumerable<Product> entity) =>
           entity.Select(x => x.Map());

        public static Product Map(this ProductDTO dto) =>
           (dto != null) ? new Product
           {
               Id = dto.Id,
               DateCreated = dto.DateCreated,
               Description = dto.Description,
               IsActive = dto.IsActive ?? true,
               Name = dto.Name,
               OfferEndDate = dto.OfferEndDate,
               OfferPrice = dto.OfferPrice,
               PictureUrl = dto.PictureUrl,
               Price = dto.Price ?? 0,
               Special = dto.Special ?? false
           } : null;

        public static IEnumerable<Product> Map(this IEnumerable<ProductDTO> dto) =>
           dto.Select(x => x.Map());

        public static Product Map(this ProductDataDTO dto) =>
           (dto != null) ? new Product
           {
               Name = dto.Name,
               Description = dto.Description,
               IsActive = dto.IsActive ?? true,
               OfferEndDate = dto.OfferEndDate,
               OfferPrice = dto.OfferPrice,
               PictureUrl = dto.PictureUrl,
               Price = dto.Price ?? dto.Price.Value,
               Special = dto.Special ?? false,
               DateCreated = DateTime.Now
           } : null;

        public static IEnumerable<Product> Map(this IEnumerable<ProductDataDTO> dto) =>
           dto.Select(x => x.Map());
    }
}
