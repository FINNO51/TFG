using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChiselTouch : MonoBehaviour
{   
    private GameObject sphere;
    // Start is called before the first frame update
    void Start()
    {
        sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        sphere.GetComponent<Renderer>().material.color = Color.red;
        sphere.transform.localScale = new Vector3(0.01f, 0.01f, 0.01f);
        Destroy(sphere.GetComponent<Collider>());
    }

    void OnCollisionEnter(Collision collision)
    {
        ContactPoint contact = collision.contacts[0];
        if(contact.otherCollider.gameObject.tag == "Cincel")
            sphere.transform.position = contact.point;
    }

    void OnCollisionExit(Collision collision)
    {
        //Destroy(sphere);
    }
}
