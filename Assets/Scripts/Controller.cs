using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace InstrumentsForUnity
{
    public class Singleton<T> : MonoBehaviour where T : MonoBehaviour
    {
        T instance; 

        T _instance
        {
            get
            {
                if (instance == null)
                {
                    instance = FindObjectOfType<T>();
                    if (instance == null)
                    {
                        var singleton = new GameObject("SINGLETON" + typeof(T));
                        instance = singleton.AddComponent<T>();
                        DontDestroyOnLoad(singleton);
                    }
                }
                return instance;
            }
        }
    }
}
