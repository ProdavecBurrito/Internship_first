using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ManagerEvenst", menuName = "Managers/ManagerEvenst")]
public class ManagerEvents : MonoBehaviour
{
    public GameObject prefab;

    public void CreatePrefab(Vector3 pos)
    {
        Instantiate(prefab, pos, Quaternion.identity);
    }
}
