using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControll : MonoBehaviour
{
    public GameObject player;
    public GameObject deephold;
    public static float speed = 2.5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         // Di chuyển camera theo trục x
        transform.Translate(Vector3.right * Time.deltaTime * speed);
        // Di chuyển nhân vật theo trục x
        player.transform.Translate(Vector3.right * Time.deltaTime * speed);
        deephold.transform.Translate(Vector3.right * Time.deltaTime * speed);

    }
}
