using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.Template
{
    public abstract class QualityTemplate
    {
        public QualityTemplate(Item item)
        {
            Item = item;
        }
        protected Item Item { get; set; }
        public Item GetUpdatedItem()
        {
            if (IsLegendaryItem())
            {
                Item.Quality = 80;
                return Item;
            }
            SellDateCountdown();
            if (HasSellDateDegradation())
            {
                SellDateDegradation();
            }
            
            QualityUpdate();
            Validation();
            return Item;
        }
        protected virtual Boolean IsLegendaryItem()
        {
            return false;
        }
        protected virtual Boolean HasSellDateDegradation()
        {
            return true;
        }
        protected abstract void QualityUpdate();
        protected void SellDateCountdown()
        {
            Item.SellIn--;
        }

        protected void SellDateDegradation()
        {
            if (Item.SellIn < 0)
            {
                Item.Quality -= 2;
            }
        }
        protected void Validation()
        {
            if (Item.Quality <= 0)
            {
                Item.Quality = 0;
            }

            if (Item.Quality >= 50)
            {
                Item.Quality = 50;
            }
        }      
    }
}
