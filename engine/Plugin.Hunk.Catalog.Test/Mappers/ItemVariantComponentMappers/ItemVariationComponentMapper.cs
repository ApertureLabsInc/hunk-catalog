﻿using Plugin.Hunk.Catalog.Mappers;
using Plugin.Hunk.Catalog.Test.Entity;
using Sitecore.Commerce.Core;
using Sitecore.Commerce.Plugin.Catalog;

namespace Plugin.Hunk.Catalog.Test.Mappers.ItemVariantComponentMappers
{
    public class ItemVariationComponentMapper : BaseItemVariationComponentMapper<SourceProduct, SourceProductVariant, CommerceEntity>
    {
        public ItemVariationComponentMapper(SourceProduct product, SourceProductVariant productVariant, CommerceEntity commerceEntity, Component parentComponent, CommerceCommander commerceCommander, CommercePipelineExecutionContext context)
            :base(product, productVariant, commerceEntity, parentComponent, commerceCommander, context)
        { }

        protected override string ComponentId => SourceVariant.Id;

        protected override void Map(ItemVariationComponent component)
        {
            component.Id = SourceVariant.Id;
            component.DisplayName = SourceVariant.DisplayName;
            component.Description = SourceVariant.Description;
        }

        protected override void MapLocalizeValues(ItemVariationComponent component)
        {
            component.DisplayName = SourceVariant.DisplayName;
            component.Description = SourceVariant.Description;
        }
    }
}