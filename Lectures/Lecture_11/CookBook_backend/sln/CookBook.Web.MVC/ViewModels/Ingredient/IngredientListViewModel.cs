﻿using CookBook.BL.Web.MVC.Api;
using System.Collections.Generic;

namespace CookBook.Web.MVC.ViewModels.Ingredient
{
    public class IngredientListViewModel
    {
        public IList<IngredientListModel> Ingredients { get; set; }
    }
}
