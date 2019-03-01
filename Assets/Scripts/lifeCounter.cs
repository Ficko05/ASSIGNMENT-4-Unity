using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class lifeCounter : MonoBehaviour
{
    private int count;
    public Text countText;

    void Start()
    {
        count = 20;
        setCountText();
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "mob")
        {
            Destroy(collision.gameObject);
            count = count - 1;
            setCountText();
        }
    }
    void setCountText()
    {
        countText.text = "Life: " + count.ToString();
    }
}
