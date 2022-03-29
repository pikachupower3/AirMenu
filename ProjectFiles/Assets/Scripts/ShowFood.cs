using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ShowFood : MonoBehaviour
{
    public List<FoodDetails> FoodInfo;
    public TextMeshProUGUI Food;
    public TextMeshProUGUI Details;

    public void showDetails(int foodID, int pageID)
    {
        Food.text = FoodInfo[pageID].Food[foodID];
        Details.text = FoodInfo[pageID].Details[foodID];
    }
}
