﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotator : MonoBehaviour {

	// Update is called once per frame
	void Update () {
        transform.Rotate(new Vector3(3, 4, 5));
	}
}