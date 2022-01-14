using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    //public float moveSpeed = 5f;
    [SerializeField] float moveSpeed = 3f;
    // Start is called before the first frame update
    GameObject currentFloor;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(moveSpeed * Time.deltaTime, 0, 0);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-moveSpeed * Time.deltaTime, 0, 0);
        }

    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "normal")
        {
            if (other.contacts[0].normal == new Vector2(0f, 1f))
            {
                Debug.Log("撞到第一種階梯");
                currentFloor = other.gameObject;
            }
            //Debug.Log(other.contacts[0].normal);
            //Debug.Log(other.contacts[1].normal);

        }

        else if (other.gameObject.tag == "nails")
        {
            if (other.contacts[0].normal == new Vector2(0f, 1f))
            {
                Debug.Log("撞到第二種階梯");
                currentFloor = other.gameObject;
            }
        }

        else if (other.gameObject.tag == "ceiling")
        {
            Debug.Log("撞到天花板啦");
            currentFloor.GetComponent<BoxCollider2D>().enabled = false;
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Deadline")
        {
            Debug.Log("你死啦");
        }

    }
}
