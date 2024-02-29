using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject spawnObjects;

    public void Spawn() {
        Instantiate(spawnObjects, transform.position, Quaternion.identity);
    }
}
