using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 10f;
    public GameObject cam;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    // Update is called once per frame
    void Update()
    {
        float zAxis = cam.transform.rotation.z;
        if (Input.GetKey("d"))
        {
            gameObject.transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
        }
        else if (Input.GetKey("a"))
        {
            gameObject.transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Obstacle")
        {
            cam.transform.parent = null;
            cam.transform.position = new Vector3(0, 12, 3.5f);
            gameObject.SetActive(false);
        }
        else if(other.gameObject.tag == "Border")
        {
            cam.transform.position = new Vector3(0, 12, 3.5f);
            cam.transform.parent = null;
            gameObject.SetActive(false);
        }
    }
}
