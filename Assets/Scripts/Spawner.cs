using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {
	public GameObject prefab;
	public int count;

	protected GameObject parent;
	protected string tag;

	protected virtual void SpawnObject(Vector3 startPos, Vector3 direction, int n);

	protected void BuildObjects() {
		Vector3 startPos = transform.position;
		Vector3 direction = Vector3.forward;

		for (int i = 0; i < count; i++) {
			SpawnObject(startPos, direction, i);
		}
	}

	protected void Spawn() {
		parent = GameObject.FindWithTag(tag);
		BuildObjects();
		Destroy(gameObject);
	}

	// Use this for initialization
	void Start () {
		Spawn();
	}

	// Update is called once per frame
	void Update () {

	}

	void Awake() {
	}
}
