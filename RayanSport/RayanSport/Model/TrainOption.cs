﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayanSport
{
    class TrainOption
    {
       

        public String trainOption_name { get; set; }
        public long trainOption_price { get; set; }
        public long trainOption_Id { get; set; }
        public TrainOption(string trainOption_name, long trainOption_price, long trainOption_Id)
        {
            this.trainOption_name = trainOption_name;
            this.trainOption_price = trainOption_price;
            this.trainOption_Id = trainOption_Id;
        }
    }
}
