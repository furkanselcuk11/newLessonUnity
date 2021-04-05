using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    CharacterController controller;

    AudioSource source; // Ses kaynağı

    Vector3 velocity;
    bool isGrounded;
    bool isMoving;

    public Transform ground;
    public float distance = 0.3f;

    public float speed;
    public float JumpHeight;
    public float gravity;

    public float originalHeight;
    public float crouchHeight;

    public float timeBetweenSteps;  // Adımlar arası kaç sn olacağı
    float timer;    // Ayak seslerimin aralığı
    public AudioClip[] stepSounds;
    
    public LayerMask mask;  // Seçtiğimiz zeminlerde zıplamsını sağlar

    private void Start()
    {
        controller = GetComponent<CharacterController>();
        source = GetComponent<AudioSource>();
    }
    private void Update()
    {
        #region Movement
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 move = transform.right * horizontal + transform.forward * vertical;
        controller.Move(move * speed * Time.deltaTime); //  Karakter hıza göre hareket etmesini sağlar       

        #endregion

        #region Basic Footsteps
        if(horizontal !=0 || vertical != 0)
        {
            isMoving = true;
        }
        else
        {
            isMoving = false;
        }

        if (isMoving)
        {
            timer -= Time.deltaTime;

            if (timer <= 0)
            {
                timer = timeBetweenSteps;   // Belirlenen süre içine ses çalsın
                source.clip = stepSounds[Random.Range(0, stepSounds.Length)];
                source.pitch = Random.Range(0.85f, 1.15f);  // Ses incelik ve kalınlık aralğı
                source.Play();
            }            
        }
        else
        {
            timer = timeBetweenSteps;
        }
        #endregion

        #region Jump
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            velocity.y += Mathf.Sqrt(JumpHeight * -3.0f * gravity);
        }
        #endregion

        #region Gravity
        isGrounded = Physics.CheckSphere(ground.position, distance, mask);
        if (isGrounded && velocity.y < 0)
        {
            velocity.y = 0f;
        }
        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
        #endregion

        #region Basic Cruch
        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            controller.height = crouchHeight;
            speed = 2.0f;
            JumpHeight = 0f;
            timeBetweenSteps = 1.0f;
        }
        if (Input.GetKeyUp(KeyCode.LeftControl))
        {
            controller.height = originalHeight;
            speed = 5.0f;
            JumpHeight = 2.0f;
            timeBetweenSteps = 0.4f;
        }
        #endregion

        #region Basic Runnig
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            speed = 10.0f;
            timeBetweenSteps=0.2f;
        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            speed = 5.0f;
            timeBetweenSteps = 0.4f;
        }
        #endregion


    }
}
