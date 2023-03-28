using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clarfications
{
    public class MenuItem2
    {
        /*
        //Very old method
        private string foodTitle; //this is called a field

        public string GetFoodTitle()
        {
            return foodTitle;
        }

        public void SetFoodTitle(string value)
        {
            this.foodTitle= value;
        }

        */
        //New method
        private string foodTitle; //this is called a field
        public string FoodTitle // property
        {
            get { return foodTitle; }   // get method
            set { foodTitle = value +"MyValue"; }  // set method
        }
        

        //This new method is equivalent to
        public string FoodTitle {get; set;}

        public override string ToString()
        {
            return FoodTitle +"My String method"
        }
    }
}
