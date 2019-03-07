using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class healthCounter : MonoBehaviour
{
    public int count;
    public Text countText;

    void Start()
    {
        count = 20;
        setCountText();
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
