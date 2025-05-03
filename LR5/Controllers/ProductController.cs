using LR5.Models;
using Microsoft.AspNetCore.Mvc;

public class ProductController : Controller
{
    private readonly List<Dish> _dishes;
    private readonly List<DishGroup> _dishGroups;

    public ProductController()
    {
        _dishGroups = new List<DishGroup>
        {
            new DishGroup { DishGroupId = 1, GroupName = "Стартеры" },
            new DishGroup { DishGroupId = 2, GroupName = "Основные блюда" }
        };

        _dishes = new List<Dish>
        {
            new Dish { DishId = 1, DishName = "Ленинградский", Calories = 200, DishGroupId = 1, Image = "soup.png" },
            new Dish { DishId = 2, DishName = "Блины", Calories = 300, DishGroupId = 1, Image = "blins.png" }
        };
    }

    public IActionResult Index()
    {
        return View(_dishes);
    }
}