using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class floorManger : MonoBehaviour
{
    [SerializeField] GameObject[] floorprefabs;
    public void SpawnFloor()
    {
       int r = Random.Range(0,floorprefabs.Length);
       GameObject floor = Instantiate( floorprefabs[r], transform);
       floor.transform.position = new Vector3(Random.Range(-3.65f, 3.65f), -5.1f, 0f);
    }
}
