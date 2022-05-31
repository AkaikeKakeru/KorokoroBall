using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{

    public GameObject clearText;
    public GameObject nextButton;
    public GameObject giveUpButton;
    public GameObject resetButton;
    public AudioSource audioSource;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("GOAL!");

        clearText.SetActive(true);
        nextButton.SetActive(true);
        giveUpButton.SetActive(false);
        resetButton.SetActive(false);
        audioSource.Play();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
