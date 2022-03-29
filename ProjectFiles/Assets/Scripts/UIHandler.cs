using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIHandler : MonoBehaviour
{
    public GameObject Background;
    public GameObject Type;
    public GameObject Menu;
    public GameObject Order;
    public GameObject button;

    public void Start()
    {
        Background.SetActive(true);
        Type.SetActive(true);
        button.SetActive(false);
        Menu.SetActive(false);
        Order.SetActive(false);
    }

    public void EnableMenu()
    {
        Menu.SetActive(true);
        Order.SetActive(false);
        Type.SetActive(false);
    }

    public void EnableOrder()
    {
        Menu.SetActive(false);
        Order.SetActive(true);
    }

    public void EnableFood()
    {
        button.SetActive(true);
        Background.SetActive(false);
    }

    public void EnableWholeMenu()
    {
        Background.SetActive(true);
        Order.SetActive(false);
        Menu.SetActive(true);
        button.SetActive(false);
    }
}
