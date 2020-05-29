using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackHandler : MonoBehaviour
{
    [SerializeField] float moveSpeed = 0f;
    public GameObject Track;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private float i = 0;
    private float lifeTime = -100;
    // Update is called once per frame
    void Update()
    {
        

        transform.Translate(Vector3.left * Time.deltaTime * moveSpeed);
        i = transform.position.x;
        if(i < lifeTime)
        {
            Destruction();
            GameObject temp = Instantiate(gameObject.transform.GetChild(0).gameObject, Vector3.zero, Quaternion.identity);
            temp.transform.position = new Vector3(gameObject.transform.GetChild(gameObject.transform.childCount - 1).position.x + 100f, 0, 0);
            temp.transform.parent = gameObject.transform;
            lifeTime = lifeTime - 100;
        }        
    }
    void Destruction()
    {
        Destroy(transform.GetChild(0).gameObject);
    }
}

