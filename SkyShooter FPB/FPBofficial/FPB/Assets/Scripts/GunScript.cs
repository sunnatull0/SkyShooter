using UnityEngine;

public class GunScript : MonoBehaviour
{
    public float damage = 1f;
    public float range = 1000f;
    public LayerMask layerMask;

    public Camera fpscam;

    public ParticleSystem muzzleFlash;
    public GameObject impactEffect;
    AudioSource soundd;
    public AudioClip aud;

    void Start()
    {
        soundd = GetComponent<AudioSource>();
    }

    void Update()
    {

        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }

        void Shoot()
        {
            muzzleFlash.Play();
            soundd.PlayOneShot(aud);
            
            RaycastHit hit;
            if(Physics.Raycast(fpscam.transform.position, fpscam.transform.forward, out hit, range,layerMask))
            {
                TakeDamage target = hit.transform.GetComponent<TakeDamage>();
                if(target != null)
                {
                    target.Healthh(damage);
                }

                GameObject impactGO = Instantiate(impactEffect, hit.point, Quaternion.LookRotation(hit.normal));
                Destroy(impactGO, 2f);
            }
        }
        
    }
}
