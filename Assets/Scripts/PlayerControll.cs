using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControll : MonoBehaviour
{
    [SerializeField] private float _speed;
    Rigidbody player;

    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = new Vector3(-1 * Input.GetAxis("Vertical"), 0f, Input.GetAxis("Horizontal"));

        if(direction != Vector3.zero)
        {
            player.MovePosition(transform.position + direction * _speed);
        }

        Vector3 floorNormal = new Vector3(0f, 1f, 0f);
        RaycastHit hit;
        Ray vectDown = new Ray(transform.position, Vector3.down);
        if (Physics.Raycast(vectDown, out hit))
        {
            floorNormal = hit.normal;
        }

        transform.rotation = Quaternion.LookRotation(direction, floorNormal);
    }
}
