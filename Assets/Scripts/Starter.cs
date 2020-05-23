using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Класс для хранения менеджеров
/// </summary>
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
