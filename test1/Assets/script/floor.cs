using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class floor : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] float moveSpeed = 3f;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, moveSpeed * Time.deltaTime, 0);
        if (transform.position.y > 6f)
        {
            Destroy(gameObject);
            transform.parent.GetComponent<floorManger>().SpawnFloor();
        }
    }
}
