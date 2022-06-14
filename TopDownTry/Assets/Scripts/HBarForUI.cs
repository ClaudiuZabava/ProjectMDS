using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HBarForUI : MonoBehaviour
{
    [SerializeField]
    private GameObject player;

    [SerializeField]
    private Slider slider;

    // Update is called once per frame
    void Update()
    {
        float hValue1 = player.GetComponent<PlayerController>().OldPhealth;
        float hValue2 = player.GetComponent<PlayerController>().phealth;
        slider.value = hValue2 / hValue1;
    }
}
