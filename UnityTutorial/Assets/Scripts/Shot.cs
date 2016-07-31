using UnityEngine;
using System.Collections;

public class Shot : MonoBehaviour {
    public Bullet bullet;
    public float interval;
	// Use this for initialization
	IEnumerator Start () {
		while (true) {
			Instantiate(bullet, transform.position, transform.rotation);
			yield return new WaitForSeconds(interval);
		}
	}
}
