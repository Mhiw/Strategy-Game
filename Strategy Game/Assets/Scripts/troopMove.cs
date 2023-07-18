using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class troopMove : MonoBehaviour
{
    private Vector3 target;
    NavMeshAgent troop;

    public GameObject Target;



    void Awake()
    {
        troop = GetComponent<NavMeshAgent>();
        troop.updateRotation = false;
        troop.updateUpAxis = false;
    }

    
    void Update()
    {
        SetTargetPosition();
        SetTroopPosition();
    }


    void SetTargetPosition()
    {
        if(Input.GetMouseButtonDown(0))
        {
            target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Target.transform.position = new Vector3(target.x, target.y, transform.position.z);
        }
    }

    void SetTroopPosition()
    {
        troop.SetDestination(new Vector3(target.x, target.y, transform.position.z));
    }
}
