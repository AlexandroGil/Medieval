using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour
{
    private Animator _animator;
    private bool mIsLoaded = false;
    public Transform CannonBall_Spawn =  null;
    public GameObject Cannonball =  null;
    private GameObject cannonmain;
    public ParticleSystem PS_Smoke;
    public AudioSource audioData;
    public Vector2 rightStick;
    public bool shoot;
    public float Power = 12.0f;
    // Start is called before the first frame update
    void Start()
    {
        _animator = GetComponent<Animator>();
        audioData = GetComponent<AudioSource>();
        //CannonBall_Spawn = transform.Find("CannonBall_Spawn");
        cannonmain = GameObject.Find("CannonMain");
        //PS_Smoke = transform.Find("Smoke").GetComponent<ParticleSystem>();
        PS_Smoke.Stop();
    }

    // Update is called once per frame
    void Update()
    {
      if(Input.GetKeyDown(KeyCode.Space)) {
          ShootCannonBall();
      }  
      if(Input.GetKeyDown(KeyCode.D)) {
          transform.Rotate(0.0f, 1.0f, 0.0f);
      }
      if(Input.GetKeyDown(KeyCode.A)) {
          transform.Rotate(0.0f, -1.0f, 0.0f);
      }
      if(Input.GetKeyDown(KeyCode.W)) {
          cannonmain.transform.Rotate(0.0f, 0.0f, 1.0f);
        }
        if(Input.GetKeyDown(KeyCode.S)) {
          cannonmain.transform.Rotate(0.0f, 0.0f, -1.0f);
        }
        if(OVRInput.GetDown(OVRInput.RawButton.A)) {
            ShootCannonBall();
        }
        if(OVRInput.Get(OVRInput.RawAxis1D.RIndexTrigger) > 0) {
            shoot = true;
        }
        if(shoot == true) {
            ShootBoolCannon();
        }
        rightStick = OVRInput.Get(OVRInput.RawAxis2D.RThumbstick);

        if(rightStick.x >= 0.5f) {
            transform.Rotate(0.0f, 1.0f, 0.0f);
        }
        if(rightStick.x <= -0.5f) {
            transform.Rotate(0.0f, -1.0f, 0.0f);
        }
        if(rightStick.y >= 0.5f) {
            cannonmain.transform.Rotate(0.0f, 0.0f, 1.0f);
        }
        if(rightStick.y <= -0.5f) {
            cannonmain.transform.Rotate(0.0f, 0.0f, -1.0f);
        }
    }

    public void ShootBoolCannon() {
        ShootCannonBall();
        shoot = false;
    }
    private void ShootCannonBall() {
        audioData.Play(0);
        GameObject cannonball = Instantiate(Cannonball, CannonBall_Spawn.position, Quaternion.identity);
        Rigidbody rb = cannonball.AddComponent<Rigidbody>();
        rb.velocity = Power * CannonBall_Spawn.forward;
        //StartCoroutine(RemoveCannonBall_Rigidbody(rb, 2.0f));
        //_animator.Play("cannonshot");
        PS_Smoke.Play();
    }

    IEnumerator RemoveCannonBall_Rigidbody(Rigidbody rb, float delay) {
        yield return new WaitForSeconds(delay);
        Destroy(rb);
    }

    public void SetTheta(float value)
    {
        transform.rotation = Quaternion.Euler(0.0f, value, 0.0f);
    }

    public void SetPhi(float value)
    {
        cannonmain.transform.rotation = Quaternion.Euler(0.0f, 0.0f, value);
    }
}
