using UnityEngine;

public class PlayerController : MonoBehaviour {

    public GameManager gameManager;

    public Transform rb;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Transform>();
    }
	
	// Update is called once per frame
	void Update () {
        if (rb.position.y < -3)
        {
            Debug.Log("Game Over");
            gameManager.EndGame();
        }
	}
}
