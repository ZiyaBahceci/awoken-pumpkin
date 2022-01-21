using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigWheat : MonoBehaviour
{
    [SerializeField] GameObject smallWheat;
    [SerializeField] GameObject wheatParent;
    
   
     private void OnMouseOver() {
         if(Input.GetMouseButtonDown(0)){
         Instantiate(smallWheat,transform.position,
         Quaternion.identity);
         
         //newSmallWheat.transform.parent = wheatParent.transform;
         FindObjectOfType<wheatDisplay>().AddWheats(50);
         Destroy(this.gameObject); 
         }
       
     }
}
