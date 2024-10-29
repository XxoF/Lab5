using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;
    [SerializeField] private Vector3 offset;

    [Range(0f, 1f)]
    [SerializeField] private float sensitivity = 1f;

    void Start()
    {
        offset = transform.position - player.transform.position;
    }

    private void FixedUpdate()
    {
        float mouse = Input.GetAxis("Mouse Y");
        transform.Rotate(new Vector3(-mouse * sensitivity, 0, 0));
    }

    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}
