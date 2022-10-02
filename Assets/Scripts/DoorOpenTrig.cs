using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpenTrig : MonoBehaviour
{
    [SerializeField] private Animator door;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            door.SetBool("Open", true);
            
            //cameraMain.position = new Vector3(-13.71f, 8.27f, 5.71f);
            //cameraMain.rotation = Quaternion.Euler(17.034f, -163.2f, 0f);
        }
    }
}
