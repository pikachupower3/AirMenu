using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

public class OrderButton : MonoBehaviour
{
    public int itemID;
    public int pageID;
    public UIHandler UI;
    public OrderFood OrderStuff;

    public void PassOrder()
    {
        OrderStuff.ChangeFood(itemID, pageID);
        UI.EnableFood();
    }
}
