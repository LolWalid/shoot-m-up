using UnityEngine;
using System.Collections;

public class ShotScript : MonoBehaviour {
	public int damage;
	public bool fromEnemy;

	// Use this for initialization
	void Start () {
		Destroy(gameObject,10f);

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
