using System;
using System.Collections.Generic;
using System.Text;

namespace RPPOON_LV5
{
    class ShippingService
    {
        private double pricePerKg;

        public ShippingService(double pricePerKg)
        {
            this.pricePerKg = pricePerKg;
        }

        public double GetDeliveryPrice(IShipable item)
        {
            return item.Weight * pricePerKg;
        }
    }
}
