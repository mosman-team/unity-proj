using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CastleComponent : MonoBehaviour
{
    [SerializeField] Sprite[] DestroyedSprites;
    SpriteRenderer sr;
    int count;

    // Start is called before the first frame update
    void Start()
    {
        sr = gameObject.GetComponent<SpriteRenderer>();
        count = 0;
        sr.sprite = DestroyedSprites[count];

    }

    public void swapImage()
    {
        this.count++;
        if (this.count < 3)
        {
            sr.sprite = DestroyedSprites[this.count];
        }

    }
    public int getCount()
    {
        return this.count;
    }
}
