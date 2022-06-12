using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGun : MonoBehaviour
{
    [SerializeField]
    Transform firingPoint;

    [SerializeField]
    GameObject projectile;

    [SerializeField]
    float firingSpeed;

    [SerializeField]
    private GameObject MuzzleFlash;

    [SerializeField]
    private AudioSource mAudioSrc;

    public static PlayerGun Instance;

    private float lastTimeShot = 0;

    void Start()
    {
        Instance = GetComponent<PlayerGun>();
        mAudioSrc=GetComponent<AudioSource>();
    }

    public void Shoot()
    {
        if (lastTimeShot + firingSpeed < Time.time)
        {
            lastTimeShot = Time.time;
            mAudioSrc.Play();
            Instantiate(projectile, firingPoint.position, firingPoint.rotation);
            MuzzleFlash.SetActive(true);
            StartCoroutine(wait());
        }
    }
    IEnumerator wait()
    {
        yield return new WaitForSeconds(0.04f);
        MuzzleFlash.SetActive(false);
    }
}
