namespace Clarfications
{
    public class MenuItem
    {
        //Properties or attributes. Sometimes they are called fields or field variables. This can lead to confusion for begginers
        public string FoodTitle { get; set; }
        public string Description { get; set; }
        public List<string> Ingredients { get; set; }
        private decimal Price { get;  public set; }

        //Constructor
        public MenuItem(string foodTitle, string description, List<string> ingredients, decimal price)
        {
            FoodTitle = foodTitle;
            Description = description;
            Ingredients = ingredients;
            Price = price;
        }

        public void RemoveIngredient(string ingredient)
        {
            //this is a variable
            var message = "Ingredient " + ingredient + " was removed.";
            //this is a property of the class 
            Ingredients.Remove(ingredient);
            Console.WriteLine(message);
        }

        public void AddIngredient(string ingredient)
        {
            Ingredients.Add(ingredient);
            Price = Price + 5;
        }
    }
}
