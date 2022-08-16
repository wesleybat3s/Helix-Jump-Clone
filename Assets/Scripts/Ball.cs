using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] Rigidbody ball;

    [SerializeField] GameObject splashPrefab;
     
    [SerializeField] float jumpForce;

    private GameManager gm;
    
    void Start()
    {
        gm = GameObject.FindObjectOfType<GameManager>(); 
    }

    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {
        ball.AddForce(Vector3.up * jumpForce);
        GameObject splash = Instantiate(splashPrefab, transform.position +new Vector3(0,-0.2f,0), transform.rotation);
        splash.transform.SetParent(other.gameObject.transform);


        string materialName = other.gameObject.GetComponent<MeshRenderer>().material.name;

       

        if (materialName == "Yellow (Instance)")
        {
            gm.RestartGame();
            
        }

        else if (true)
        {

        }

    }
}
