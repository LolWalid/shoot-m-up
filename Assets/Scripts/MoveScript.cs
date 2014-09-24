using UnityEngine;
using System.Collections;


public class MoveScript : MonoBehaviour {

	public Vector2 speed;
	public Vector2 direction;
	public bool isEnemy;
	// Use this for initialization
	void Start () {
		if (isEnemy) {
			float rd = Random.Range(-12f,6f);
			transform.position = new Vector2(transform.position.x, rd);
			//transform.position.Set(transform.position.x, rd, 0);
		}
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 temp = new Vector3();
		temp.x = direction.x * speed.x * Time.deltaTime;
		temp.y = direction.y * speed.y * Time.deltaTime;
		temp.z = 0;
		transform.Translate(temp);
		//Debug.Log(Time.frameCount);
	}
}
