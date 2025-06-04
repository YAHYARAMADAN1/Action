using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerToEnd : MonoBehaviour
{
    
    public GameObject CanvasEnd;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            CanvasEnd.SetActive(true);
            //Time.timeScale = 0f; // if you want to Pause the game
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
