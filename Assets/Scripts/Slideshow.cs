using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slideshow : MonoBehaviour
{
    public GameObject nextBtn;
    public GameObject prevBtn;
    public Sprite[] mImg;
    private int counter = 0;

    public void Next()
    {
        counter++;
        checkBtns();
        gameObject.GetComponent<SpriteRenderer>().sprite = mImg[counter];
    }

    public void Previous()
    {
        counter--;
        checkBtns();
        gameObject.GetComponent<SpriteRenderer>().sprite = mImg[counter];
    }

    private void checkBtns()
    {
        if (counter < 1)
        {
            prevBtn.SetActive(false);
        }
        else
        {
            prevBtn.SetActive(true);
        }

        if (counter > mImg.Length - 2)
        {
            nextBtn.SetActive(false);
        }
        else
        {
            nextBtn.SetActive(true);
        }
    }
}
