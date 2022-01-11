using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class floorManger : MonoBehaviour
{
    [SerializeField] GameObject[] floorprefabs;
    public void SpawnFloor()
    {
       int r = Random.Range(0,floorprefabs.Length);
       Instantiate( floorprefabs[r], transform);
    }
}
