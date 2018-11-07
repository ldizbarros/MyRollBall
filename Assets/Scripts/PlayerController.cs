using System.Collections;
using UnityEngine;
using UnityEngine.UI;

/**
 * Con este script le damos movimiento a la bola
 **/

public class PlayerController : MonoBehaviour {

    public float speed;
    public Text countText;
    public Text winText;
    public Text loseText;

    private Rigidbody rb;
    private int count;

    void Start () {

        rb = GetComponent<Rigidbody>();
	count = 0;
        SetCountText ();
        winText.text = "";
	loseText.text = "";
    }

    void FixedUpdate (){

        float moveH = Input.GetAxis("Horizontal");
        float moveV = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveH, 0.0f, moveV);

        rb.AddForce(movement*speed);
    }

    void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag ("Pick Up")){
            other.gameObject.SetActive (false);
	    count = count + 1;
            SetCountText ();
        }
	if (other.gameObject.CompareTag ("Vacio")){
	    this.gameObject.SetActive (false);
            loseText.text = "GAME OVER!!!!!";
	}
    }

    void SetCountText () {
        countText.text = "Count: " + count.ToString ();
        if (count >= 10) {
            winText.text = "You Win!";
        }
    }
}
