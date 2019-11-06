using UnityEngine;

public class CubePath : MonoBehaviour
{

    bool toolbox = false;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            this.transform.Translate(Vector3.forward * 0.04f);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.down * Time.deltaTime * 20);
            //this.transform.RotateAround(Vector3.zero, Vector3.up, 20 * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.up * Time.deltaTime * 20);
        }

        if (Input.GetKey(KeyCode.S))
        {
            this.transform.Translate(Vector3.back * 0.04f);
        }


        // fetch toolbox
        speed = 0.001f;
        float step = speed * Time.deltaTime;
        float toolboxX = 1.089638f;
        float toolboxY = -0.38f;
        float toolboxZ = 23.8f;
        Vector3 startPosition = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        Vector3 destPosition = new Vector3(toolboxX,toolboxY,toolboxZ);
        if (Input.GetKey(KeyCode.T))
        {
            toolbox = true;
            if (toolbox)
        {
            transform.position = Vector3.MoveTowards(startPosition, destPosition, step);
        }
        }
        
        
    }
    
    void OnCollisionEnter(Collision otherObj)
    {

    }
    
}
