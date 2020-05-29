using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstackleHandler : MonoBehaviour
{
    public GameObject obstaclePrefab;
    GameObject temp;
    // Start is called before the first frame update
    void Start()
    {
        // You can increase the no. of obstactles by increasin min_Value of 
        //Randmo.Rang(MIN_VALUE, MAX_VALUE in the given for loop

        for(int i = 0; i<Random.Range(2, 8); i++)
        {
            temp = Instantiate(obstaclePrefab,
                new Vector3(Random.Range(transform.position.x - 50, transform.position.x + 50), 5, Random.Range(-15, 15)),
                Quaternion.identity);

            temp.transform.parent = gameObject.transform;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
}
