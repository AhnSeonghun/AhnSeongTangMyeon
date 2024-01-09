using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereCollision : MonoBehaviour
{
    public int Hp = 100;
    public float checkTime = 0.0f;

    private void OnCollisionEnter(Collision collision)
    {
        // if(collision.gameObject.tag == "Player") {
        //     int cHP = collision.gameObject.GetComponent<PlayerCollision>().Hp;
        //     Debug.Log("Collision Hp : " + cHP);
        // }

        // Debug.Log("NAME ENTER : " + collision.gameObject.name); // 충돌체의 오브젝트 이름을 가져온다.   

        // Debug.Log("TAG : " + collision.gameObject.tag); // 충돌체의 오브젝트 태그를 가져온다.    
    }

    private void OnCollisionStay(Collision collision) {
        // Debug.Log("NAME STAY : " + collision.gameObject.name);
    }

    private void OnCollisionExit(Collision collision) {
        // Debug.Log("NAME EXIT : " + collision.gameObject.name);
    }

    private void OnTriggerEnter(Collider other) {
        Debug.Log("TRIGGER ENTER : " + other.gameObject.name);

        if(other.gameObject.tag == "ITEM")
        {
            int cHP = other.gameObject.GetComponent<PlayerCollision>().Hp;
            Debug.Log("HP UP : " + cHP);
            Hp += cHP;
            Destroy(other.gameObject);
        }
    }

    private void OnTriggerStay(Collider other) {
        Debug.Log("TRIGGER STAY : " + other.gameObject.name);

        if(other.gameObject.tag == "Field")
        {
            checkTime += Time.deltaTime;
            if(checkTime >= 1.0f)
            {
                Debug.Log("HP DOWN");
                Hp -= 1;
                checkTime = 0.0f;
            }
        }
    }

    private void OnTriggerExit(Collider other) {
        // Debug.Log("TRIGGER EXIT : " + other.gameObject.name);
    }
}