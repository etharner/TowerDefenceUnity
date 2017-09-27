using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallBuilder : Spawner {
	override void SpawnObject(Vector3 startPos, Vector3 direction, int n) {
		Debug.Log("SDUHSAD");
		Vector3 pos = count * direction + startPos;
		Quaternion rot = Quaternion.Euler(Random.Range(0f, 360f), Random.Range(0f, 360f), Random.Range(0f, 360f));

		GameObject new_object = Instantiate(prefab, pos, rot, parent.transform);
		new_object.transform.localScale = new Vector3(Random.Range(1f, 3f), Random.Range(1f, 3f), Random.Range(1f, 3f));
	}

	void Start () {
		tag = "walls";
		Spawn();
	}
}
