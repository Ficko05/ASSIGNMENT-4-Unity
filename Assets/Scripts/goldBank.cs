using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class goldBank : MonoBehaviour
{
    public int gold;
    public Text goldText;

    
    void Start()
    {
        setGoldText();
    }

    public void setGoldText()
    {
        goldText.text = "Gold: " + gold.ToString();
    }
}
