﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement
{
   
        public class InventoryDetails
        {
            public List<TypesOfStock> typesOfStock;
        }
        public class TypesOfStock
        {
            public string name;
            public int NoOfshare;
            public int price;
        }
    }
}


