using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.Template
{
    public class DefaultQuality : QualityTemplate
    {
        public DefaultQuality(Item item) : base(item)
        {

        }
        protected override void QualityUpdate()
        {
            base.Item.Quality--;
        }
    }
}
