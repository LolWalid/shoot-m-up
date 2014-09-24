using UnityEngine;
using System.Collections;

public class HealthScript : MonoBehaviour {
	public int hp;
	public bool isEnemy;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D (Collider2D shot) {
		ShotScript shotScript = (ShotScript) shot.gameObject.GetComponent("ShotScript");
		if ((shotScript.fromEnemy && !isEnemy) || !shotScript.fromEnemy && isEnemy)
		{
			hp-=10;
			Destroy(shot.gameObject);
			if (hp < 1)
				Destroy (this.gameObject);
		}
	}
}
