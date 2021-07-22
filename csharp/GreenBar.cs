using csharp.Factory;
using System.Collections.Generic;

namespace csharp
{
    public class GreenBar
    {
        IList<Item> Items;
        public GreenBar(IList<Item> Items)
        {
            this.Items = Items;
        }

        public void UpdateQuality()
        {
            for (var i = 0; i < Items.Count; i++)
            {
                var qualityTemplate = new ConcreteQualityTemplateFactory(Items[i]).CreateQualityTemplate(Items[i].ItemType);
                Items[i] = qualityTemplate.GetUpdatedItem();
            }
        }
    }
}
