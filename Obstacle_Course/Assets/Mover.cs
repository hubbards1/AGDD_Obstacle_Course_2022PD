using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float moveSpeed = 1f;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Welcome to my game!");
        Debug.Log("Move with WASD and dodge stuff.");
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

     void MovePlayer()
    {
        float xTranslate = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float zTranslate = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        this.transform.Translate(xTranslate, 0, zTranslate);
    }
}
