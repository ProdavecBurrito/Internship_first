using UnityEngine;

public class ActorZombie : MonoBehaviour, ITick
{
    private void Awake()
    {
        ManagerUpdate.AddTo(this);
    }

    public void Tick()
    {
        Debug.Log("Brains");

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Toolbox.Get<ManagerEvents>().CreatePrefab(Random.insideUnitSphere * Random.Range(-15, 15));
        }
    }
}
