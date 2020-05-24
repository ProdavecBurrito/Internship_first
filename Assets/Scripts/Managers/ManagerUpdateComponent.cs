using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerUpdateComponent : MonoBehaviour
{
    ManagerUpdate manager;

    public void Setup(ManagerUpdate mng)
    {
        manager = mng;
    }

    private void Update()
    {
        manager.Tick();
    }

    private void FixedUpdate()
    {
        manager.TickFixed();
    }

    private void LateUpdate()
    {
        manager.TickLate();
    }
}
