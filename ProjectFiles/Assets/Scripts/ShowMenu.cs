using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;

public class ShowMenu : MonoBehaviour
{
    public List<AllMenu> menuItem;
    public FoodID[] menuFields;
    public TextMeshProUGUI Type;
    public int pageCounter;
    public UIHandler UI;

    public void MenuType(int page)
    {
        UI.EnableMenu();
        pageCounter = page;
        ShowItems();
    }

    public void ShowItems()
    {
        Type.text = menuItem[pageCounter].Type;
        for (int i = 0; i < menuFields.Length; i++)
        {
            menuFields[i].itemID = i;
            menuFields[i].pageID = pageCounter;
            menuFields[i].transform.GetChild(0).GetComponent<TMPro.TextMeshProUGUI>().text = menuItem[pageCounter].Item[i];
            menuFields[i].textChanged();
        }
    }

    public void NextPage()
    {
        pageCounter++;
        ShowItems();
    }

    public void PreviousPage()
    {
        if (pageCounter != 0)
        {
            pageCounter--;
            ShowItems();
        }
    }
}
