using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameState : MonoBehaviour {
	GameObject rock;

	void BuildWall(Vector3 startPos, Vector3 direction, int count) {
		while (count > 0) {
			Vector3 pos = count * direction + startPos;
			Quaternion rot = Quaternion.Euler(Random.Range(0f, 360f), Random.Range(0f, 360f), Random.Range(0f, 360f));

			Instantiate(rock, pos, rot);
			rock.transform.localScale = new Vector3(Random.Range(0, 10), Random.Range(0, 10), Random.Range(0, 10));

			count--;
		}
	}
	// Use this for initialization
	void Start () {
		BuildWall(new Vector3(-50, 0, 100), Vector3.back, 200);
		BuildWall(new Vector3(50, 0, 100), Vector3.back, 200);
		BuildWall(new Vector3(-50, 0, -100), Vector3.right, 100);
		BuildWall(new Vector3(-50, 0, 100), Vector3.right, 100);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void Awake() {
		rock = Resources.Load("Prefabs/Rock") as GameObject;
	}
}
