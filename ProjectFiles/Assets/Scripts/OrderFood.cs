using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class OrderFood : MonoBehaviour
{
    public List<FoodImage> itemImage;
    public Image food;
    public Image drinks;
    public Image sides;
    public Image snacks;
    public Sprite blank;
    public bool isDessert = false;

    public void ChangeFood(int foodID, int pageID)
    {
        if (isDessert)
        {
            if (itemImage[pageID].Type == "Sides")
            {
                sides.sprite = itemImage[pageID].itemSprite[foodID];
                food.sprite = blank;
                isDessert = false;
            }
            if (itemImage[pageID].Type == "Snacks")
            {
                snacks.sprite = itemImage[pageID].itemSprite[foodID];
                food.sprite = blank;
                isDessert = false;
            }
        }
        else
        {
            if (itemImage[pageID].Type == "Sides")
            {
                sides.sprite = itemImage[pageID].itemSprite[foodID];
            }
            if (itemImage[pageID].Type == "Snacks")
            {
                snacks.sprite = itemImage[pageID].itemSprite[foodID];
            }
        }

        if (itemImage[pageID].Type == "Main")
        {
            food.sprite = itemImage[pageID].itemSprite[foodID];
            isDessert = false;
        }
        if (itemImage[pageID].Type == "Desserts")
        {
            food.sprite = itemImage[pageID].itemSprite[foodID];
            sides.sprite = blank;
            snacks.sprite = blank;
            isDessert = true;
        }
        if (itemImage[pageID].Type == "Drinks")
        {
            drinks.sprite = itemImage[pageID].itemSprite[foodID];
        }
    }
}
