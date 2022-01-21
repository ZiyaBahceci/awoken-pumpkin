using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackerSpawner : MonoBehaviour
{
   
    [SerializeField] float minSpawnDelay = 5f;
    [SerializeField] float maxSpawnDelay = 15f;
    [SerializeField] Attacker[] attackersPrefab;
    bool spawn = true;
    int random;
    
  
 
     public void StopSpawning()
    {
        spawn = false;
    }
    
    IEnumerator Start()
    {
        
         while (spawn)
         {
             
            
            yield return new WaitForSeconds(Random.Range(minSpawnDelay, maxSpawnDelay));
            SpawnAttacker();
            
        }
    }

   
    private void SpawnAttacker()
    {
        random = Random.Range(0, attackersPrefab.Length);
        Spawn(attackersPrefab[random]);
    }

    private void Spawn(Attacker myAttacker)
    {
        if(spawn){
         Attacker newAttacker = Instantiate(myAttacker, transform.position, Quaternion.identity) as Attacker;
        newAttacker.transform.parent = transform;
        }else{
            return;
        }
        
    }
}
