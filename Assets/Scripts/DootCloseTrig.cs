using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DootCloseTrig : MonoBehaviour
{
    [SerializeField] private Transform cameraMain;
    [SerializeField] private Animator door;
    [SerializeField] private Transform point;

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
        if(other.gameObject.tag == "Player")
        {
            door.SetBool("Open", false);

            cameraMain.position = point.position;
            cameraMain.rotation = Quaternion.Euler(17.034f, -163.2f, 0f);
        }
    }
}
