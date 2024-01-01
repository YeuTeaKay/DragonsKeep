
using Mirror;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class PlayerController : NetworkBehaviour
{
    public CharacterController controller;
    public Transform gunModel;
    public GameObject bulletPrefab;
    public float bulletSpeed = 10f;
    public float speed = 6f;

    public float turnSmoothTime = 0.1f;
    float smoothVelocity;

    void FixedUpdate() 
    {

        Application.targetFrameRate = 60;
        if(!isLocalPlayer)
        {
            return;
        }

            float horizontal = Input.GetAxisRaw("Horizontal");
            float vertical = Input.GetAxisRaw("Vertical");
            Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized;

            if(direction.magnitude >= 0.1f)
            {
                float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg;
                float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref smoothVelocity, turnSmoothTime);
                transform.rotation = Quaternion.Euler(0f, angle, 0f);

                Vector3 moveDir = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward;
                controller.Move(moveDir.normalized * speed * Time.deltaTime);
            }
            
            
        if(Input.GetKeyDown(KeyCode.Space))
        {
            CmdFire();
        }
    }

    [Command]
    private void CmdFire()
    {
        GameObject bullet = Instantiate(bulletPrefab, gunModel.position, gunModel.rotation);

        bullet.SetActive(true);

        Rigidbody bulletRigidBody = bullet.GetComponent<Rigidbody>();
        bulletRigidBody.velocity = bullet.transform.forward * bulletSpeed;

        NetworkServer.Spawn(bullet);
        
        Destroy(bullet, 3f);
    }

    

    public override void OnStartLocalPlayer()
    {
        GetComponentInChildren<SkinnedMeshRenderer>().material.color = Color.red;
    }

}
