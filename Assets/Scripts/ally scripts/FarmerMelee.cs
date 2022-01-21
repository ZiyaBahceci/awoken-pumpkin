using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FarmerMelee : MonoBehaviour
{
    GameObject target = null;
    [SerializeField]float farmermeleePower = 20f;
    private void OnTriggerEnter2D(Collider2D other) {

        if(other.GetComponent<Attacker>()){
        GetComponent<Animator>().SetBool("isAttacking",true);

        target = other.gameObject;
        }
        

    }
       public void Attack(){
        if(target !=null){
        target.GetComponent<Health>().DealDamage(farmermeleePower);

        }else{
                   GetComponent<Animator>().SetBool("isAttacking",false);
                   return;

        }
    
    }
           

}
