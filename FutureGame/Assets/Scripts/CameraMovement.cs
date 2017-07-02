using UnityEngine;

public class CameraMovement : MonoBehaviour {

    public Transform cam;
    public Transform player;
    public float vertSpeed = 20f;
    public float horiSpeed = 20f;
    public float yaw = 0f;
    public float pitch = 0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        cam.LookAt(player);
        Vector3 toMove = new Vector3(Input.GetAxis("Mouse X") * 0.5f, Input.GetAxis("Mouse Y") * 0.5f, 0);
        cam.Translate(toMove);
	}
}
