using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.Template
{
    public class VIPPassesQuality : QualityTemplate
    {
        public VIPPassesQuality(Item item) : base(item)
        {

        }

        protected override bool IsLegendaryItem()
        {
            return base.IsLegendaryItem();
        }

        protected override void QualityUpdate()
        {
            base.Item.Quality++;
            if (base.Item.SellIn <= 10)
            {
                base.Item.Quality += 2;
            }
            else if (base.Item.SellIn <= 5)
            {
                base.Item.Quality += 3;
            }
        }
    }
}
