using UnityEngine;
using System.Collections;

public class CameraThird : MonoBehaviour {

	public GameObject player;
	public float rotateSpeed = 5;
	Vector3 offset;

	void Start() {
		offset = player.transform.position - transform.position;
	}

	void LateUpdate() {
		float horizontal = Input.GetAxis("Mouse X") * rotateSpeed;
		player.transform.Rotate(0, horizontal, 0);

		float desiredAngle = player.transform.eulerAngles.y;
		Quaternion rotation = Quaternion.Euler(0, desiredAngle, 0);
		transform.position = player.transform.position - (rotation * offset);

		transform.LookAt(player.transform);
	}
}
