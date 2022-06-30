
using Unity.VisualScripting;
using UnityEngine;

public class ObstacleController : MonoBehaviour
{
    public ParticleSystem BallTrail; 
    private void OnTriggerEnter(Collider other)
    {
        
        /*Debug.Log("Coins: " + PlayerManager.numberOfCoins);*/
        Destroy(this.gameObject);
        this.ObsColor(other);
        
    }
    private void ObsColor(Collider other)
    {
        if (this.gameObject.GetComponent<Renderer>().material.name == "yellow (Instance)")
        {
            other.gameObject.GetComponent<Renderer>().material.color =  this.gameObject.GetComponent<Renderer>().material.color;
            PlayerManager.numberOfCoins                              += 1;
            /*this.BallTrail.GetComponent<Renderer>().material         =  this.gameObject.GetComponent<Renderer>().material;*/
        }

        if (this.gameObject.GetComponent<Renderer>().material.name == "red (Instance)")
        {
            other.gameObject.GetComponent<Renderer>().material.color = Color.red;
            PlayerManager.numberOfCoins += 1; 
            
        }

        if (this.gameObject.GetComponent<Renderer>().material.name == "blue (Instance)")
        {
            other.gameObject.GetComponent<Renderer>().material.color = Color.blue;
            PlayerManager.numberOfCoins += 1; 
        }
        
    }
    
}

