using UnityEngine;

public class CoinScript : MonoBehaviour
{
    public GameObject counterObject;
    private CoinCounter coinCounter;

    private void Start() {
        counterObject = GameObject.Find("CoinText");
        coinCounter = counterObject.GetComponent<CoinCounter>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        coinCounter.counter += 1;
        Destroy(gameObject);
    }
}
