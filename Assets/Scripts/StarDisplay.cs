using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class StarDisplay : MonoBehaviour
{
    [SerializeField] int numberOfStars;
    [SerializeField] Text starsText;

    private void Start()
    {
        UpdateStarsText();
    }

    public int GetNumberOfStars()
    {
        return numberOfStars;
    }

    public bool isEnough(int needAmount)
    {
        if (numberOfStars >= needAmount) return true;
        else return false;
    }
    public void SpendStars(int needAmount)
    {
        numberOfStars -= needAmount;
        UpdateStarsText();
    }
    public void AddToStars(int amount)
    {
        numberOfStars += amount;
        UpdateStarsText();
    }

    
    private void UpdateStarsText()
    {
        starsText.text = numberOfStars.ToString();
    }
}



















