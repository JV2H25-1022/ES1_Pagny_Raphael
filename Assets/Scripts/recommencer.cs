using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class recommencer : MonoBehaviour
{



    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other) 
    {
        if(other.gameObject.tag == ("Finish"))
        {
            Invoke("Redemarrer", 5);
        }
    }
    void Redemarrer()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);    
    }

    void OnCollisionEnter(Collision other) {
        if(other.gameObject.tag == ("Cible"))
        {
            Destroy(other.gameObject);
        }
    }

}

