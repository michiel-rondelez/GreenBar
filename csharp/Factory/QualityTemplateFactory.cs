using csharp.Template;
using System;

namespace csharp.Factory
{
    public class QualityTemplateFactory
    {
        private readonly Item _item;

        public QualityTemplateFactory(Item item)
        {
            _item = item;
        }
        public QualityTemplate CreateQualityTemplate(ItemType itemType)
        {
            switch (itemType)
            {
                case ItemType.Default: return new DefaultQuality(_item);
                case ItemType.Camembert: return new CamembertQuality(_item);
                case ItemType.Conjured: return new ConjuredQuality(_item);
                case ItemType.Legendary: return new LegendaryQuality(_item);
                case ItemType.VIPPasses: return new VIPPassesQuality(_item);
                default: throw new NotImplementedException();
            }
        }
    }
}
