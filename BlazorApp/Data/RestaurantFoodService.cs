namespace BlazorApp.Data
{
    public class RestaurantFoodService
    {
        private static readonly string[] Restaurants = new[]
        {
            "Pork Rinds", "Somtam JoeJoe", "Heaven Chicken", "Pad thai", "Minced pork Mama"
        };

        public Task<RestaurantFood[]> GetRestaurants(string foodName)
        {
            return Task.FromResult(Restaurants.Select((restaurant, index) => new RestaurantFood
            {
                Name = restaurant,
                Description = "Test",
                Price = 1,
                Score = 10,
            }).ToArray());
        }
    }
}