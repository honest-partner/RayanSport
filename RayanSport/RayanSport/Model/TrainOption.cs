using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayanSport
{
    public class TrainOption
    {
       

        public String trainOption_name { get; set; }
        public long trainOption_price { get; set; }
        public long trainOption_Id { get; set; }
        public TrainOption() { }
        public TrainOption(string trainOption_name, long trainOption_price, long trainOption_Id)
        {
            this.trainOption_name = trainOption_name;
            this.trainOption_price = trainOption_price;
            this.trainOption_Id = trainOption_Id;
        }
        public String toString() {
            return String.Format("trainOption_name:{0},trainOption_price:{1},trainOption_Id:{2}", trainOption_name, trainOption_price, trainOption_Id);
        }
    }
}
