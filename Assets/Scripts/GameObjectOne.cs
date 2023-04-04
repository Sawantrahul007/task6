using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameObjectOne : MonoBehaviour
{
    private void Awake()
    {
        Debug.Log("Awake function Call");
    }
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start Function call");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Update Function call");
    }
    private void OnEnable()
    {
        Debug.Log("OnEnable Function call");

    }
    private void Reset()
    {
        Debug.Log("Reset Function call");
    }
    private void FixedUpdate()
    {
        Debug.Log("Fixed Update Function Call");
    }
    private void OnDisable()
    {
        Debug.Log("Disable Function Call");
    }
}
