using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wheat : MonoBehaviour
{
    [SerializeField] GameObject bigWheat;
    [SerializeField] GameObject WheatParent;
  
   
    private void Awake() {
        StartCoroutine(wheatCounter());
    }

    IEnumerator wheatCounter(){
         yield return new WaitForSeconds(8);
  Instantiate(bigWheat,transform.position,
        Quaternion.identity);
        //BigWheat.transform.parent = WheatParent.transform;
        Destroy(this.gameObject);
    }
   
   
}
