
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public  Transform target;
    private Vector3   offfet;
    private void Start()
    {
        this.offfet = this.transform.position - this.target.position; 
    }

    // Update is called once per frame
    private void Update()
    {
        var transform1  = this.transform;
        var position    = transform1.position;
        var newPosition = new Vector3(position.x, position.y, this.offfet.z + this.target.position.z);
        this.transform.position = Vector3.Lerp(position, newPosition, 10 * Time.deltaTime);
    }
}
