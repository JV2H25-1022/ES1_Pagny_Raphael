using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class demarrer : MonoBehaviour
{
    [SerializeReference] private GameObject PlateformeInitiale;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Demarrer()
    {
        PlateformeInitiale.SetActive(false);
    }
}
