using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonControl : MonoBehaviour
{
    [SerializeField] private Animator animator;
    [SerializeField] private Animator door;

    Transform curentdoorPosition;
    Transform startDoorPosition;


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
        if (other.gameObject)
        {
            animator.SetBool("Pressed", true);
            door.SetBool("Open", true);

        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject)
        {
            animator.SetBool("Pressed", false);
            door.SetBool("Open", false);

        }


    }

    //private IEnumerator DoorOpen()
    //{
    //    while(door.position.y != 6f)
    //    {
    //        door.transform.position += new Vector3(0f, 1f, 0f) * Time.deltaTime;
    //        yield return null;
    //    }

    //    Debug.Log(door.position.y);
    //}

    //private IEnumerator DoorClose()
    //{
    //    while (door.position.y != 0f)
    //    {
    //        door.transform.position -= new Vector3(0f, 1f, 0f) * Time.deltaTime;
    //        yield return null;
    //    }
    //}
}
