using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSwitching : MonoBehaviour
{
    public Animator anim;

    public GameObject shield;
    public GameObject sword;

    public GameObject greatSword;

    public bool isGreatSword = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isGreatSword)
        {
            shield.SetActive(false);
            sword.SetActive(false);

            greatSword.SetActive(true);

            anim.SetBool("IsGreatSword", isGreatSword);
        }
        else
        {
            shield.SetActive(true);
            sword.SetActive(true);

            greatSword.SetActive(false);

            anim.SetBool("IsGreatSword", isGreatSword);
        }
    }
}
