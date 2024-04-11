using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CircleCollider2D))]
[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMov : MonoBehaviour
{
    [SerializeField] FixedJoystick joystick;
    [SerializeField] KeyCode modeChangeKey;
    [SerializeField] GameObject modeBtnYellow;
    [SerializeField] GameObject modeBtnGreen;

    float inputX, inputY, currentDeg;
    [SerializeField] List<GameObject> weapons = new List<GameObject> { };

    void Update()
    {
        inputX = joystick.Horizontal;
        inputY = joystick.Vertical;
        currentDeg = Mathf.Atan2(inputY, inputX) * Mathf.Rad2Deg;//ジョイスティックの角度を確保

        // モード切り替え
        if (Input.GetKeyDown(modeChangeKey)) 
        {
            if (weapons[0].tag == "WeaponGreen")
            {
                WeaponMode_Yellow();
            }
            else
            {
                WeaponMode_Green();
            }   
        }

        WeaponActivation();       
    }

    public void WeaponMode_Green()
    {
        for(int w = 0; w < weapons.Count; w++) 
        {
            weapons[w].tag = "WeaponGreen";
            weapons[w].GetComponent<SpriteRenderer>().color = Color.green;
        }

        modeBtnGreen.SetActive(true);
        modeBtnYellow.SetActive(false);
    }

    public void WeaponMode_Yellow()
    {
        for (int w = 0; w < weapons.Count; w++) 
        { 
            weapons[w].tag = "WeaponYellow";
            weapons[w].GetComponent<SpriteRenderer>().color = Color.yellow;
        }

        modeBtnGreen.SetActive(false);
        modeBtnYellow.SetActive(true);
    }

    void AlphaChanger(GameObject g ,float nextalpha)
    {
        Color beforecolor = g.GetComponent<SpriteRenderer>().color;
        Color afterColor;
        afterColor.r = beforecolor.r;
        afterColor.g = beforecolor.g;
        afterColor.b = beforecolor.b;
        afterColor.a = nextalpha;
        g.GetComponent<SpriteRenderer>().color = afterColor;
    }
    void WeaponActivation()
    {
        if (currentDeg >= 0 && currentDeg <= 60f)
        {
            AlphaChanger(weapons[0], 1);
            weapons[0].GetComponent<CircleCollider2D>().enabled = true;

            AlphaChanger(weapons[1], 0);
            weapons[1].GetComponent<CircleCollider2D>().enabled = false;

            AlphaChanger(weapons[2], 0);
            weapons[2].GetComponent<CircleCollider2D>().enabled = false;

            AlphaChanger(weapons[3], 0);
            weapons[3].GetComponent<CircleCollider2D>().enabled = false;

            AlphaChanger(weapons[4], 0);
            weapons[4].GetComponent<CircleCollider2D>().enabled = false;

            AlphaChanger(weapons[5], 0);
            weapons[5].GetComponent<CircleCollider2D>().enabled = false;
        }
        else if (currentDeg >= 0 && currentDeg <= 120f)
        {
            AlphaChanger(weapons[0], 0);
            weapons[0].GetComponent<CircleCollider2D>().enabled = false;

            AlphaChanger(weapons[1], 1);
            weapons[1].GetComponent<CircleCollider2D>().enabled = true;

            AlphaChanger(weapons[2], 0);
            weapons[2].GetComponent<CircleCollider2D>().enabled = false;

            AlphaChanger(weapons[3], 0);
            weapons[3].GetComponent<CircleCollider2D>().enabled = false;

            AlphaChanger(weapons[4], 0);
            weapons[4].GetComponent<CircleCollider2D>().enabled = false;

            AlphaChanger(weapons[5], 0);
            weapons[5].GetComponent<CircleCollider2D>().enabled = false;
        }
        else if (currentDeg >= 0 && currentDeg <= 180f)
        {
            AlphaChanger(weapons[0], 0);
            weapons[0].GetComponent<CircleCollider2D>().enabled = false;

            AlphaChanger(weapons[1], 0);
            weapons[1].GetComponent<CircleCollider2D>().enabled = false;

            AlphaChanger(weapons[2], 1);
            weapons[2].GetComponent<CircleCollider2D>().enabled = true;

            AlphaChanger(weapons[3], 0);
            weapons[3].GetComponent<CircleCollider2D>().enabled = false;

            AlphaChanger(weapons[4], 0);
            weapons[4].GetComponent<CircleCollider2D>().enabled = false;

            AlphaChanger(weapons[5], 0);
            weapons[5].GetComponent<CircleCollider2D>().enabled = false;
        }
        else if (currentDeg >= -60f)
        {
            AlphaChanger(weapons[0], 0);
            weapons[0].GetComponent<CircleCollider2D>().enabled = false;

            AlphaChanger(weapons[1], 0);
            weapons[1].GetComponent<CircleCollider2D>().enabled = false;

            AlphaChanger(weapons[2], 0);
            weapons[2].GetComponent<CircleCollider2D>().enabled = false;

            AlphaChanger(weapons[3], 0);
            weapons[3].GetComponent<CircleCollider2D>().enabled = false;

            AlphaChanger(weapons[4], 0);
            weapons[4].GetComponent<CircleCollider2D>().enabled = false;

            AlphaChanger(weapons[5], 1);
            weapons[5].GetComponent<CircleCollider2D>().enabled = true;
        }
        else if (currentDeg >= -120f)
        {
            AlphaChanger(weapons[0], 0);
            weapons[0].GetComponent<CircleCollider2D>().enabled = false;

            AlphaChanger(weapons[1], 0);
            weapons[1].GetComponent<CircleCollider2D>().enabled = false;

            AlphaChanger(weapons[2], 0);
            weapons[2].GetComponent<CircleCollider2D>().enabled = false;

            AlphaChanger(weapons[3], 0);
            weapons[3].GetComponent<CircleCollider2D>().enabled = false;

            AlphaChanger(weapons[4], 1);
            weapons[4].GetComponent<CircleCollider2D>().enabled = true;

            AlphaChanger(weapons[5], 0);
            weapons[5].GetComponent<CircleCollider2D>().enabled = false;
        }
        else if (currentDeg >= -180f)
        {
            AlphaChanger(weapons[0], 0);
            weapons[0].GetComponent<CircleCollider2D>().enabled = false;

            AlphaChanger(weapons[1], 0);
            weapons[1].GetComponent<CircleCollider2D>().enabled = false;

            AlphaChanger(weapons[2], 0);
            weapons[2].GetComponent<CircleCollider2D>().enabled = false;

            AlphaChanger(weapons[3], 1);
            weapons[3].GetComponent<CircleCollider2D>().enabled = true;

            AlphaChanger(weapons[4], 0);
            weapons[4].GetComponent<CircleCollider2D>().enabled = false;

            AlphaChanger(weapons[5], 0);
            weapons[5].GetComponent<CircleCollider2D>().enabled = false;
        }
    }
}
