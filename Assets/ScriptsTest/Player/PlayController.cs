
using UnityEngine;

public class PlayController : MonoBehaviour
{

  [Header("Reference")]
    public Camera mainCam;

    [Header("Settings")]
    [SerializeField] private float speedMoveForward;
    [SerializeField] private float speedMoveLeftRight;
     
    /*[HideInInspector]*/

    private float   lastPosX;
    private Vector3 currMousePos; 
    private Vector3 newPosForTrans;
   

    private bool isGameStarted;

    private void Start()
    {
        this.isGameStarted = false;
    }
    private void Update()
    {

        PlayerMoving();

        if (this.isGameStarted)
        {
            var transform1 = this.transform;
            var position   = transform1.position;
            position            = new Vector3(position.x, position.y, position.z + this.speedMoveForward * Time.deltaTime);
            transform1.position = position;
        }
    }

    private void PlayerMoving()
    {
        if (Input.GetMouseButton(0))
        {
            this.currMousePos = Input.mousePosition;

            this.Move();
            this.lastPosX = this.currMousePos.x;

        }
        if (Input.GetMouseButtonDown(0))
        {
            this.lastPosX      = this.currMousePos.x;
            this.isGameStarted = true;
            this.currMousePos  = Input.mousePosition;
        }

       
    }


    private void Move()
    {

        if (this.currMousePos.x < this.lastPosX)
        {
            if (this.transform.position.x > -4f)
            {
                this.newPosForTrans.x = -4;
            }
    
            
            var position = transform.position;
            this.newPosForTrans = new Vector3(position.x - this.speedMoveLeftRight * Time.deltaTime,
                position.y,
                position.z);

        }
        if (currMousePos.x == lastPosX)
        {
            newPosForTrans = this.transform.position;
        }
        if (this.currMousePos.x > this.lastPosX)
        {
            if (this.transform.position.x < 4f)
            {
                this.newPosForTrans.x = 4;
            }

            var transform1 = this.transform;
            var position   = transform1.position;
            this.newPosForTrans = new Vector3(position.x + this.speedMoveLeftRight * Time.deltaTime,
                position.y,
                position.z);
            
        }
        this.transform.position = this.newPosForTrans;
    }
    
}
