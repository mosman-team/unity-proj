using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CastleHealth : Health
{
    int factor;
    int counter;

    List<GameObject> castleComponents;
    int index;
    // Start is called before the first frame update
    void Start()
    {
        counter = 0;
        index = 0;


        castleComponents = new List<GameObject>();

        for (int i = 0; i < gameObject.transform.childCount; i++)
        {
            castleComponents.Add(gameObject.transform.GetChild(i).gameObject);
        }
        factor = this.getHealth() / (castleComponents.Count * 2);
                                                       

    }

    
    public override void DealDamage(int damage)
    {

        counter++;
        this.setHealth(this.getHealth() - 1);

        if (counter >= factor)
        {
            counter = 0;
            castleComponents[index].GetComponent<CastleComponent>().swapImage();
            index++;
        }
        if(index >= castleComponents.Count)
        {
            index = 0;
        }
    }
}






