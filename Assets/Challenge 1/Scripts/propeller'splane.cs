using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    private float rotationSpeed=677.0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      transform.Rotate(0,0,rotationSpeed * Time.deltaTime);
    }
}
