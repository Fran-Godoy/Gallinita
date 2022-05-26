using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehve : MonoBehaviour
{
    public GameObject prefab;
    public GameObject spawnPoint;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject Clon;
            Clon = Instantiate(prefab);
            Clon.transform.position = spawnPoint.transform.position -Vector3.forward;
        }   
    }
}
