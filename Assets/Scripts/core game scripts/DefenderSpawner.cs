using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderSpawner : MonoBehaviour
{
     Defender defender;
     float paddingx = 0.5f;
     float paddingy = 0.5f;
    GameObject DefenderParent;
    const string DEFENDER_PARENT_NAME = "Defenders";

    private void Start()
    {
        CreateDefenderParent();
    }

    private void CreateDefenderParent()
    {
        DefenderParent = GameObject.Find(DEFENDER_PARENT_NAME);
        if (!DefenderParent)
        {
            DefenderParent = new GameObject(DEFENDER_PARENT_NAME);
        }
    }

    private void OnMouseDown()
    {
         bool flag =FindObjectOfType<gameOptions>().flag;

        if(defender == null&& flag == true){
            return;
        }else if(flag == false){
        AttemptToPlaceDefenderAt(GetSquareClicked());

        }

    }
    public void SetSelectedDefender(Defender defenderToSelect)
    {
        defender = defenderToSelect;
    }



    private void AttemptToPlaceDefenderAt(Vector2 gridPos)
    {
        var WheatDisplay = FindObjectOfType<wheatDisplay>();
        int defenderCost = defender.GetwheatCost();
        if (WheatDisplay.HaveEnoughWheats(defenderCost))
        {
            SpawnDefender(gridPos);
            WheatDisplay.RemoveWheat(defenderCost);
        }
        //if we have Enough stars
        // spend the wheat
    }



        private Vector2 GetSquareClicked()
    {
        Vector2 clickPos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        Vector2 worldPosition = Camera.main.ScreenToWorldPoint(clickPos);
        Vector2 gridPos = SnapToGrid(worldPosition);
        return gridPos;
    }
    private Vector2 SnapToGrid(Vector2 rawWorldPos)
    {
        float newX = Mathf.RoundToInt(rawWorldPos.x);
        float newY = Mathf.RoundToInt(rawWorldPos.y);
        
        return new Vector2(newX+0.15f, newY-0.5f);
    }



    private void SpawnDefender(Vector2 coordinates)
    { 
   

        
        Defender newDefender = Instantiate(defender, 
        coordinates, Quaternion.identity) as Defender;
        newDefender.transform.parent = DefenderParent.transform;
        
        
    }
}
   
