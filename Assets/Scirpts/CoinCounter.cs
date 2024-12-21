using UnityEngine;
using UnityEngine.UI;

public class CoinCounter : MonoBehaviour
{
    
    public Text text;
    public int counter = 0;

    void Update()
    {
        text.text = "Coins collected: " + counter.ToString();
    }
}
