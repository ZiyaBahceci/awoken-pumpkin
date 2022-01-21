using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField] GameObject projectileprefab, gun;
    AttackerSpawner myLaneSpawner;
    Animator animator;
    GameObject projectileParent;
    const string PROJECTILE_PARENT_NAME = "Defenders";
    private void Start()
    {
        SetLaneSpawner();
        animator = GetComponent<Animator>();
        CreateProjectileParent();
    }

    private void CreateProjectileParent()
    {
        projectileParent = GameObject.Find(PROJECTILE_PARENT_NAME);
        if (!projectileParent)
        {
            projectileParent = new GameObject(PROJECTILE_PARENT_NAME);
        }
   
}

void Update()
    {
        if (IsAttackerInLane())
        {
           
            animator.SetBool("isAttacking",true);
        }
        else
        {
            
            animator.SetBool("isAttacking",false);

        }
    }

    private void SetLaneSpawner()
    {
        AttackerSpawner[] spawners = FindObjectsOfType<AttackerSpawner>();
        foreach(AttackerSpawner spawner in spawners)
        {
            bool isCloseEnough = Mathf.Abs(spawner.transform.position.y - transform.position.y) <= 0.5;
            if (isCloseEnough)
            {
                myLaneSpawner = spawner;
            }
            
        }
    }
    private bool IsAttackerInLane()
    {
        // if my lane spawnner child count less than or equal to 0
        //return false
        if(myLaneSpawner.transform.childCount <= 0)
        {
            return false;
        }else
        {
            return true;

        }
    }
    
   public void Fire()
    {
       
      GameObject projectile = Instantiate(projectileprefab, gun.transform.position, Quaternion.identity)as GameObject;
        projectile.transform.parent = projectileParent.transform;
       }
}
