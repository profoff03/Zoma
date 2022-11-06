using System;
using UnityEngine;
using UnityEngine.UIElements;

public class Gun : MonoBehaviour
{
    public  Image aim;
    public float damage = 10f;
    public float range = 100f;
    public float fireRate = 15f;
    public Camera fpsCam;

    public ParticleSystem effect;
    public float nextTimeToFire = 0f;
    
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire1") && Time.time > nextTimeToFire)
        {
            nextTimeToFire = Time.time + 1f/fireRate;
            Shoot();
        }
    }
    
    private void Shoot()
    {
        effect.Play();
        RaycastHit hit;
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
            Target target = hit.transform.GetComponent<Target>();
            if (target != null)
            {
                target.TakeDamage(damage);
            }

            if (hit.transform.tag.Equals("Finish"))
            {
                aim.tintColor = Color.red;
            }
            else
            {
                aim.tintColor = Color.black;
            }
        }

    }
}
