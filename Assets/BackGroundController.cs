using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundController : MonoBehaviour {
	// Start is called before the first frame update
	void Start() {
		DontDestroyOnLoad(gameObject);
	}

	/// <summary>値を 0 ~ 1 の範囲に正規化する</summary>
	/// <param name="value">値</param>
	/// <returns>正規化された値</returns>
	void Update() {
	}

	private void FixedUpdate() {
		transform.Translate(0, -0.03f, 0);
		if (transform.position.y < -4.9f) {
			transform.position = new Vector3(0, 4.9f, 0);
		}
	}
}
