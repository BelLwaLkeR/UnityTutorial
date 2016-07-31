using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {
    public string targetTag;
    public float speed = 10.0f;

	// Use this for initialization
	void Start () {
        GetComponent<Rigidbody2D>().velocity = transform.up.normalized * speed;
	}

	public void OnCollisionEnter(Collider other) {
		if (other.tag != targetTag) { return; }
		Destroy(gameObject);
	}
}
