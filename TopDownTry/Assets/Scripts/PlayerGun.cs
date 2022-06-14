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
        if (lastTimeShot + firingSpeed < Time.time && PlayerPrefs.GetInt("pause") == 0)
        {
            lastTimeShot = Time.time;
            Instantiate(projectile, firingPoint.position, firingPoint.rotation);
            MuzzleFlash.SetActive(true);
            if(PlayerPrefs.GetInt("sfxStats") == 1)
                mAudioSrc.Play();
            StartCoroutine(wait());
        }
    }
    IEnumerator wait()
    {
        yield return new WaitForSeconds(0.04f);
        MuzzleFlash.SetActive(false);
    }
}
