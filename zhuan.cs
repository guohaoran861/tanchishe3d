using UnityEngine;
using System.Collections;

public class zhuan : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
    public Transform tt;
    public float zhuansu = 1f;
	// Update is called once per frame
	void Update () {
        this.transform.RotateAround(tt.position, Vector3.up, zhuansu);
	}
}
