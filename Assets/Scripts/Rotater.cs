using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * Este script es para hacer rotar el cubo que recoge la bola 
 **/

public class Rotater : MonoBehaviour {
    
	void Update () {
        transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);
    }
}
