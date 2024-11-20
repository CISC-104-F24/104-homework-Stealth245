using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Card : MonoBehaviour
{
    public int rank;
    public Color color1;
    public TextMeshProUGUI NumberTop;
    public TextMeshProUGUI NumberBot;
    public Image Background;
    
    public void cardNumbers()
    {
        cardNumbers = NumberBot;
        cardNumbers = NumberTop;

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
