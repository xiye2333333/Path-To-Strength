using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehavior : MonoBehaviour
{
    public GameObject Hero;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 heroPosition = Hero.transform.position;
        heroPosition.z = -10;
        GetComponent<Transform>().position = heroPosition;
    }
}
