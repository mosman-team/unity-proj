using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderSpawner : MonoBehaviour
{
    Defender defenderPrefab;
    Camera cam;

    [SerializeField] StarDisplay starDisplay;

    void Start()
    {
        if(cam == null) { cam = Camera.main; }
        starDisplay = FindObjectOfType<StarDisplay>();
    }

    private void OnMouseDown()
    {
        if (!defenderPrefab) { return; }


        
        if (starDisplay.isEnough(defenderPrefab.GetCost()))
        {
            starDisplay.SpendStars(defenderPrefab.GetCost());

            InstantiateDefender(getPositionForDefender());
        }

    }
    public void setDefenderPrefab(Defender newDefenderPrefab)
    {
        defenderPrefab = newDefenderPrefab;
    }
    
    public Vector2 getPositionForDefender()
    {
        Vector2 worldPos = cam.ScreenToWorldPoint(new Vector2(Input.mousePosition.x, 
            Input.mousePosition.y));

        Vector2 defenderPosition = SnapToGrid(worldPos);
        
        return defenderPosition;
    }
    Vector2 SnapToGrid(Vector2 rawWorldPos) {
        float newX = Mathf.RoundToInt(rawWorldPos.x);
        float newY = Mathf.RoundToInt(rawWorldPos.y);
        return new Vector2(newX, newY);
    }

    void InstantiateDefender(Vector2 position)
    {
        Instantiate(defenderPrefab, position, Quaternion.identity);
    }
}



















