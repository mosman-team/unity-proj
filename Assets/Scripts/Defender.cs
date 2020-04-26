using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Defender : MonoBehaviour
{
    [SerializeField] int cost;
    StarDisplay starDisplay;
    void Start()
    {
        starDisplay = FindObjectOfType<StarDisplay>();    
    }

    public int GetCost()
    {
        return cost;
    }

    public void CallAddToStars(int amount)
    {
        starDisplay.AddToStars(amount);
    }
}





















