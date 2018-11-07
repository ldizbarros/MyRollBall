using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * Con este script hacemos que la camara siga la bola cada vez que se mueva.
 **/

public class CameraControler : MonoBehaviour {

    public GameObject player;
    private Vector3 offset;

    void Start() {
        offset = transform.position - player.transform.position;
    }

    void LateUpdate() {
        transform.position = player.transform.position + offset;
    }
}
