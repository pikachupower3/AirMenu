using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class AllMenu
{
    public string Type;
    public string[] Item;
}

[System.Serializable]
public class FoodDetails
{
    public string Type;
    public string[] Food;
    public string[] Details;
}

[System.Serializable]
public class FoodImage
{
    public string Type;
    public Sprite[] itemSprite;
}