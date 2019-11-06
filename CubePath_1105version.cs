using UnityEngine;

public class CubePath : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*       if (Input.GetKey(KeyCode.W))
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
       */
        transform.position += transform.forward * 5 * Time.deltaTime;
        transform.Rotate(new Vector3(0f, -100f, 0f) * Time.deltaTime);
    }
    
    void OnCollisionEnter(Collision otherObj)
    {

    }
}
//To Do List.
//Adding script to Solar Panels (Nick)
//Adding script to Robot and storage area (Lin)
//Making the robot move automatically.  Programming a path. (All)
//Adding Tools and toolbox models (Nick)
//Make robot move around crater (Andrew)
//Storage area domed (Lin)
// Find coordinates of objects.
// Due by Nov 13.
//Crater: (0, -50, 0) Radius of 26.25
//Storage: (50, 7.822609, -50)
// Cube (0, 1, -35)
//Get or make models for crates.
//Get or make models of something with wheels.