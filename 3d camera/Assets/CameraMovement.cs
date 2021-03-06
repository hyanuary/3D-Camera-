﻿using UnityEngine;
using System.Collections;

public class CameraMovement : MonoBehaviour {

	public GameObject player;
	public float damping = 1;
	Vector3 offset;

	void Start() {
		offset = transform.position - player.transform.position;
	}

	void LateUpdate() {
		Vector3 desiredPosition = player.transform.position + offset;
		Vector3 position = Vector3.Lerp(transform.position, desiredPosition, Time.deltaTime * damping);
		transform.position = position;

		transform.LookAt(player.transform.position);
	}

}
