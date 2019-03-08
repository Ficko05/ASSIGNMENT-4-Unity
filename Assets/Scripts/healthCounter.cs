using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class healthCounter : MonoBehaviour
{
    public int count;
    public Text countText;

    public static healthCounter instance;

    void Awake()
    {
        instance = this;
        count = 20;
        setCountText();
        if(count == 0)
        {

        }
    }
    public void setCount()
    {
        count = count - 1;
        countText.text = "Life: " + count.ToString();
    }

    public void setCountText()
    {
        countText.text = "Life: " + count.ToString();
    }
}
