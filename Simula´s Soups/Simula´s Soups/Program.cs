
(FoodType type, Ingredient ingredient, Seasoning seasoning) soup = GetSoup();

Console.WriteLine($"You made a {soup.seasoning} { soup.type} with {soup.ingredient}");



(FoodType, Ingredient, Seasoning) GetSoup(){

    FoodType type = GetFoodType();
    Ingredient ingredient = GetIngredient();
    Seasoning seasoning = GetSeasoning();

    return (type, ingredient, seasoning);
}

FoodType GetFoodType()
{
    Console.WriteLine("Enter what type of food you want to make (soup, stew, gumbo)");
    string input = Console.ReadLine();

    return input switch
    {
        "soup" => FoodType.soup,
        "stew" => FoodType.stew,
        "gumbo" => FoodType.gumbo
    };
}

Ingredient GetIngredient()
{
    Console.WriteLine("Enter what ingredient you want to use (mushrooms, chicken, carrots, potatoes)");
    string input = Console.ReadLine();

    return input switch
    {
        "mushrooms" => Ingredient.mushrooms,
        "chicken" => Ingredient.chicken,
        "carrots" => Ingredient.carrots,
        "potatoes" => Ingredient.potatoes
    };
}

Seasoning GetSeasoning()
{
    Console.WriteLine("Enter what seasoning you want to use (spicy, salty, sweet)");
    string input = Console.ReadLine();

    return input switch
    {
        "spicy" => Seasoning.spicy,
        "salty" => Seasoning.salty,
        "sweet" => Seasoning.sweet
    };
}



enum FoodType {soup, stew, gumbo}
enum Ingredient {mushrooms, chicken, carrots, potatoes}

enum Seasoning {spicy, salty, sweet}
