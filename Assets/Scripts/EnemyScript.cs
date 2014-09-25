using UnityEngine;
using System.Collections;

public class EnemyScript : MonoBehaviour {
	public float shootingRate;

	public GameObject enemyShot;

	bool canAttack;
	float timeSinceLastShot;

	// Use this for initialization
	void Start () {
		canAttack = true;
		timeSinceLastShot=0f;
	}
	
	// Update is called once per frame
	void Update () {
		if (canAttack) {
			Attack (true);
			canAttack=false;
			timeSinceLastShot=0;
		}
		else {
			timeSinceLastShot += Time.deltaTime;
			if (timeSinceLastShot >= shootingRate)
				canAttack=true;
		}
	}

	public void Attack(bool isEnemy) {
		GameObject fire = (GameObject) GameObject.Instantiate(enemyShot,transform.position,transform.rotation);
		ShotScript shotScript = (ShotScript) fire.GetComponent("ShotScript");
		
		shotScript.fromEnemy = isEnemy;
		MoveScript moveScript = (MoveScript) fire.GetComponent("MoveScript");
		moveScript.speed = new Vector2(1,1);
		moveScript.direction = new Vector2(Random.Range(-10.0F, 10.0F), Random.Range(-10.0F, 10.0F));
	}
}
