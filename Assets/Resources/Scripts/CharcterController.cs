using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharcterController : MonoBehaviour
{
    // Start is called before the first frame update

    GameObject character_;
    Rigidbody2D rigdbody_;
    private float speed_ = 200;

    void Start()
    {
        Setup();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            speed_ = 100;
            this.rigdbody_.AddForce(transform.up * speed_);
        }

    }

    void Setup()
    {
        character_ = this.gameObject;
        this.rigdbody_ = GetComponent<Rigidbody2D>();
    }
}
