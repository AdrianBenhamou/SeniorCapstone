﻿using System;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

/// <summary>
/// Data container for a recipe
/// </summary>
[Serializable]
public class Recipe 
{
    
    public string Name;
    public int Calories;
    public int PrepTimeMinutes;
    public Ingredient[] Ingredients;
    public string[] Steps;
    public int StarRating;
    public string[] Reviews;
    public string[] Tags;
    public string ImageReferencePath;
    public Sprite ImageSprite;
    public string Key;

    /// <summary>
    /// Creates a new instance of Recipe
    /// </summary>
    /// <param name="name">The name of the recipe</param>
    /// <param name="imagePath">Image itemPath url for the database</param>
    /// <param name="calories">The amount of calories</param>
    /// <param name="prepTimeMinutes">The prep time in minutes</param>
    /// <param name="tags">The tags for this recipe</param>
    /// <param name="ingredients">The ingredients for this recipe</param>
    /// <param name="steps">The steps for this recipe</param>
    /// <param name="reviews">The reviews for this recipe</param>
    /// <param name="starRating">The rating for this recipe</param>
    public Recipe(string name, string imagePath, int calories, int prepTimeMinutes, List<string> tags, List<Ingredient> ingredients, List<string> steps, List<string> reviews = null, int starRating = 5, string key = "")
    {
        
        Name = name;
        ImageReferencePath = imagePath;
        Calories = calories;
        PrepTimeMinutes = prepTimeMinutes;
        Tags = tags.ToArray();
        Ingredients = ingredients.ToArray();
        Steps = steps.ToArray();
        StarRating = starRating;

        if(reviews != null)
            Reviews = reviews.ToArray();

        Key = key;
    }
}
