using UnityEngine;

public class CameraControl : MonoBehaviour
{
    private Transform player;
    private Vector3 dir;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player = GameObject.FindWithTag("Player").transform;
        dir = player.transform.position - transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position - dir;

        float mouseX = Input.GetAxis("Mouse X");

        transform.Rotate(Vector3.up, mouseX * 90 * Time.deltaTime);
    }
}
