using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;
	
	public AudioSource walkingSound;

	private float lastPosition;
	
	public bool isWalking = false;
	public Animator anim;
	
    public float speed = 4f;
    public float gravity = -9.81f;
    public float jumpHeight = 3f;
    public float run = 12f;

    private Vector3 velocity;

    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;
	

    bool isGrounded = true;
	
	void Start(){
		controller = GetComponent<CharacterController>();
		lastPosition = transform.position.x;
	}

    void Update()
    {	
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if (isGrounded && velocity.y < 0)
            velocity.y = -2f;

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * speed * Time.deltaTime);

        if (Input.GetButtonDown("Jump") && isGrounded)
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);

        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);
		
		
		if(lastPosition < transform.position.x || lastPosition > transform.position.x)
		{
			
			isWalking = true;
			anim.SetBool("isWalking", true);
		} else {
			isWalking = false;
			anim.SetBool("isWalking", false);
			
		}
		
		lastPosition = transform.position.x;
	
		
		
		
		
		//Debug.Log(controller.velocity.magnitude);
		
    }
}
