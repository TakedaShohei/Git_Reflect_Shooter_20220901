using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Resources.Scripts { 
public class CharcterController : MonoBehaviour
{
    // Start is called before the first frame update


    //parameter
    int hp_;
    int max_hp_;
    float max_speed_;
    private float speed_;

    //set bounce
    GameObject character_;
    Rigidbody2D rigdbody_;
    Vector2 start_pos_;

    //CharacterData
    [SerializeField]
    CharacterData data_ = null;

    [SerializeField]
    Vector2 launch_direction = new Vector2();

    [SerializeField]
    SpriteRenderer render_ = null;

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

    private void FixedUpdate()
    {
        this.rigdbody_.velocity *= 0.995f; 
    }

    void Setup()
    {
        //setup character data
        CharacterSetup(data_);



        character_ = this.gameObject;
        this.rigdbody_ = GetComponent<Rigidbody2D>();
        speed_ = 0;
    }

    void Launch()
    {
        rigdbody_.velocity = launch_direction;
    }

    public void CharacterSetup(CharacterData in_data)
    {

        hp_ = in_data.Hp;
        max_hp_ = in_data.Hp;
        max_speed_ = in_data.Speed;
        speed_ = max_speed_;
        render_.sprite = in_data.Image;
    }
}
}
