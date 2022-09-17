using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball_Move : MonoBehaviour
{
    public Rigidbody rb;
    private float jumpforce;
    public GameObject splashPrefab;
    private GameManager game_Manager;

    void Start()
    {
        game_Manager = GameObject.FindObjectOfType<GameManager>();
        jumpforce = 5f;
    }

    

    private void OnCollisionEnter(Collision other)
    {
        rb.velocity = Vector3.up * jumpforce;




        GameObject splash = Instantiate(splashPrefab, transform.position+new Vector3(0,-0.2f,0), transform.rotation);
        splash.transform.SetParent(other.gameObject.transform);

        string materialName = other.gameObject.GetComponent<MeshRenderer>().material.name;


        Debug.Log("" + materialName);

        if (materialName=="BlockColor (Instance)")
        {

        }
        else if(materialName== "KillColor (Instance)")
        {
            game_Manager.Restart_Game();
        }
        else if (materialName== "LastRing (Instance)")
        {

        }
    }

}
