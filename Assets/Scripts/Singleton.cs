using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// Синглтон
/// </summary>
namespace InstrumentsForUnity
{
    public class Singleton<T> : MonoBehaviour where T : MonoBehaviour
    {
        static T instance; 

        public static T Instance
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
