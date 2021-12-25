using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdJump : MonoBehaviour //MonoBehaviour의 상속을 받음
{
    Rigidbody2D rb;
    public float jumpPower;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
         if (Input.GetMouseButtonDown(0)) //Input.GetMouseButtonDown(0)마우스클릭 왼쪽
         {
             rb.velocity = Vector2.up * jumpPower; // (0,3)
         }
    }
}
