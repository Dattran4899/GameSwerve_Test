using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayController : MonoBehaviour
{

    [SerializeField] private float SpeedMoveForwad;
    private bool  isGameStated; 
    void Start()
    {
        this.isGameStated = false;
    }

    void Update()
    {
        if (this.isGameStated)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + this.SpeedMoveForwad * Time.deltaTime);
        }
        else
        {
            return;
        }
    }
    
}
