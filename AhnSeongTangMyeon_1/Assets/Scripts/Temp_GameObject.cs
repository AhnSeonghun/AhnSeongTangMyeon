using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Temp_GameObject : MonoBehaviour
{
    public int hp;
    public float moveSpeed = 1.0f;
    public Vector3 pos = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
        hp = 50;

        pos = new Vector3(20, 20, 20);
        transform.position = pos;
    }

    // Update is called once per frame
    void Update()
    {
        MoveCube();

        if(Input.GetKeyDown(KeyCode.Space)) // 키가 내려갔을 때
        {
            moveSpeed++;
        }
    }

    void MoveCube()
    {
        if(Input.GetKey(KeyCode.UpArrow)) // 키가 눌러져 있을 때
        {
            transform.position += new Vector3(0.0f, moveSpeed * Time.deltaTime, 0.0f);
        }
        if(Input.GetKey(KeyCode.DownArrow)) // 키가 눌러져 있을 때
        {
            transform.position += new Vector3(0.0f, -moveSpeed * Time.deltaTime, 0.0f);
        }
        if(Input.GetKey(KeyCode.LeftArrow)) // 키가 눌러져 있을 때
        {
            transform.position += new Vector3(-moveSpeed * Time.deltaTime, 0.0f, 0.0f);
        }
        if(Input.GetKey(KeyCode.RightArrow)) // 키가 눌러져 있을 때
        {
            transform.position += new Vector3(moveSpeed * Time.deltaTime, 0.0f, 0.0f);
        }
    }
}
