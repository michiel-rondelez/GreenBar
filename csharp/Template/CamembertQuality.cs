using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.Template
{
    public class CamembertQuality : QualityTemplate
    {

        public CamembertQuality(Item item) : base(item)
        {
        }

        protected override bool HasSellDateDegradation()
        {
            return false;
        }

        protected override bool IsLegendaryItem()
        {
            return base.IsLegendaryItem();
        }

        protected override void QualityUpdate()
        {
            if (base.Item.Quality < 50)
            {
                base.Item.Quality++;
            }
        }
    }
}
