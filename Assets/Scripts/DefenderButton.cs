using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderButton : MonoBehaviour
{
    SpriteRenderer renderer;
    DefenderSpawner defenderSpawner;
    [SerializeField] Defender defender;

    private void Start()
    {
        renderer = GetComponent<SpriteRenderer>();
        defenderSpawner = FindObjectOfType<DefenderSpawner>();
    }

    private void OnMouseDown()
    {

        var buttons = FindObjectsOfType<DefenderButton>();
        foreach (DefenderButton button in buttons)
        {
            button.GetComponent<SpriteRenderer>().color = new Color32(60,60,60,255);
        }

        renderer.color = Color.white;
        defenderSpawner.setDefenderPrefab(defender);

    }


}
