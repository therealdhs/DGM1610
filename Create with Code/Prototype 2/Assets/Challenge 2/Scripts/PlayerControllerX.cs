using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float coolDown = 0.0f;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) & coolDown > 0.8f)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            coolDown = 0.0f;
        }
        coolDown = coolDown + Time.deltaTime;
    }
}
