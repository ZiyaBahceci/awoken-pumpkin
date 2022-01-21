using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DefenderButton : MonoBehaviour
{
    
    [SerializeField] Defender defenderPrefab;
    private void Start() {
       
    }
    private void Update() {
        
    }
     private void OnMouseDown()
    {
        var Buttons = FindObjectsOfType<DefenderButton>();
        
        foreach (DefenderButton button in Buttons)
        {
            button.GetComponent<SpriteRenderer>().color = new Color32(87, 87, 87, 255);
            button.transform.GetChild(0).gameObject.SetActive(false);
            }
        transform.GetChild(0).gameObject.SetActive(true);
      GetComponent<SpriteRenderer>().color = Color.white;
     
        FindObjectOfType<DefenderSpawner>().SetSelectedDefender(defenderPrefab);
        
    }
    
}
