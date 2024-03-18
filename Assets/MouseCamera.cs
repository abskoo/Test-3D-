using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseCamera : MonoBehaviour
{
    float mousX;
    float mousY;

    public float Sensevity = 1000f;
    public Transform player;

    float rotation = 0f;

    public float MineAngle = -90f;
    public float MaxAngle = 90f;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        mousX = Input.GetAxis("Mouse X") * Sensevity * Time.deltaTime;
        mousY = Input.GetAxis("Mouse Y") * Sensevity * Time.deltaTime;

        rotation -= mousY;
        rotation = Mathf.Clamp(rotation, MineAngle, MaxAngle);
        transform.localRotation = Quaternion.Euler(rotation, 0, 0);

        player.Rotate(Vector3.up * mousX);
    }
}
