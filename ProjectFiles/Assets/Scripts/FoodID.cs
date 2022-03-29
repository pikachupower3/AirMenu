using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodID : MonoBehaviour
{
    public int itemID;
    public int pageID;
    public ShowFood handler;
    public UIHandler UI;
    public OrderButton Order;
    public bool isEnabled = true;

    public void textChanged()
    {
        if(gameObject.transform.GetChild(0).GetComponent<TMPro.TextMeshProUGUI>().text == "")
        {
            isEnabled = false;
        }
        else
        {
            isEnabled = true;
        }
    }

    public void ShowFood()
    {
        if (isEnabled)
        {
            Order.itemID = itemID;
            Order.pageID = pageID;
            handler.showDetails(itemID, pageID);
            UI.EnableOrder();
        }
    }
}
