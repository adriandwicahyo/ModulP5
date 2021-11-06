using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animasi : MonoBehaviour
{
    //Variable
    private float nilai_x;
    private float nilai_z;
    private bool status_ground;

    //Referensi
    private Animator anim;
    private GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponentInChildren<Animator>();
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        nilai_x = player.GetComponent<gerak_Player>().x;
        nilai_z = player.GetComponent<gerak_Player>().z;
        status_ground = player.GetComponent<gerak_Player>().isGrounded;
        anim.SetFloat("x", nilai_x);
        anim.SetFloat("z", nilai_z);
        anim.SetBool("isGrounded", status_ground);
    }
}
