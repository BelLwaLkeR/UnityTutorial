using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
    public float speed = 5;

	// Update is called once per frame
	void Update () {
        Vector2 input = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        Vector2 direction = input.normalized;

        GetComponent<Rigidbody2D>().velocity = direction * speed;

	}
}
