using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public float moveSpeed = 5f;
    //[SerializeField] float moveSpeed = 5f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow) )
        {
            transform.Translate(moveSpeed * Time.deltaTime,0, 0);
        }
        else if(Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-moveSpeed* Time.deltaTime,0,0);
        }
        
    }


    private void OnCollisionEnter2D(Collision2D other) 
    { 
        if(other.gameObject.tag == "Floor1")
        {
            Debug.Log("撞到第一種階梯");
        }

        else if(other.gameObject.tag =="Floor2")
        {
            Debug.Log("撞到第二種階梯");
        }
    }
    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.gameObject.tag =="Deadline")
        {
            Debug.Log("你死啦");
        }
        
    }
}
