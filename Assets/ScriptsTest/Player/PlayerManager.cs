
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI; 

public class PlayerManager : MonoBehaviour
{
    [SerializeField] public static int numberOfCoins;
    public Text  PoinText;
   
    void Start()
    {
        numberOfCoins = 0;
    }

    
    void Update()
    {   
       
        this.PoinText.text = "Point: " + numberOfCoins;
        
    }
}
