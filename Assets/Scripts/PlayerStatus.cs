using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStatus : MonoBehaviour
{
    [SerializeField] Slider hpSlider;
    [SerializeField] Slider hpDiffSlider;
    [SerializeField] float maxHP;
    float hp;
    float timer;

    void Start()
    {
        hp = maxHP;
        hpSlider.value = hp / maxHP;
        hpDiffSlider.value = hpSlider.value;
        timer = 0;
    }

    void Update()
    {
        hpDiffSlider.value = Mathf.Lerp(hpDiffSlider.value, hpSlider.value, timer);
        timer += 0.01f * Time.deltaTime;
    }

    public void Hit(int damage)
    {
        hp -= damage;

        if (hp <= 0)
        {
            hp = 0;
        }

        hpSlider.value = hp / maxHP;
        timer = 0;
    }
}
