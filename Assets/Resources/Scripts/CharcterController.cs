using UnityEngine;

namespace Assets.Resources.Scripts
{
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

        [SerializeField]
        Transform root_ = null;

        [SerializeField]
        Vector2 current_direction = new Vector2();

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

            
            current_direction = this.rigdbody_.velocity;
        }

        private void FixedUpdate()
        {
            this.rigdbody_.velocity *= 0.995f;
        }

        void Setup()
        {
            character_ = this.gameObject;
            this.rigdbody_ = GetComponent<Rigidbody2D>();
            speed_ = 0;
            //setup character data
            CharacterSetup(data_);

        }



        void test()
        {
            Launch();
        }
        void Launch()
        {
            rigdbody_.velocity = launch_direction;
        }

        void BounceUpdate()
        {

        }

        private void OnCollisionEnter2D(Collision2D collision)
        {
            var disired_direction = Vector2.Reflect(current_direction,collision.contacts[0].normal);
        }

        public void CharacterSetup(CharacterData in_data)
        {

            hp_ = in_data.Hp;
            max_hp_ = in_data.Hp;
            max_speed_ = in_data.Speed;
            speed_ = max_speed_;
            render_.sprite = in_data.Image;

            //just test
            test();
        }
    }
}
