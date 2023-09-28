using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float queueTime = 1.5f;
    public float time = 0;
    // Game Object specified in unity
    public GameObject obstacle;
    public float height;

    // Start is called before the first frame update
    void Start()
    {
        if(time > queueTime) {
            GameObject go = Instantiate(obstacle);
            go.transform.position = transform.position+
            new Vector3(0, Random.Range(-height, height), 0);
            time = 0;
            // Removes the object after 10 seconds
            Destroy(go, 10);
        }

        time += Time.deltaTime;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
