using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour
{
    

    void Start()
    {
        UnitSelections.Instance.unitList.Add(this.gameObject);
    }

    

    void OnDestroy()
    {
        UnitSelections.Instance.unitList.Remove(this.gameObject);
    }
}
