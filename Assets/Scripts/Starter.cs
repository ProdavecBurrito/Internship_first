using System.Collections.Generic;
using UnityEngine;

public class Starter : MonoBehaviour
{
    [SerializeField]
    List<ManagerBase> managers = new List<ManagerBase>();

    private void Awake()
    {
        foreach(var managerBase in managers)
        {
            Toolbox.Add(managerBase);
        }
    }
}
