using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    public Animator anim;

    public GameObject vfx;

    private BoxCollider2D boxCollider2D;
    private void Awake()
    {
        anim = GetComponent<Animator>();
        boxCollider2D = GetComponent<BoxCollider2D>();
    }

    private void Start()
    {
        anim.SetTrigger("Intro");
       
    }

    private void OnMouseDown()
    {
        anim.SetTrigger("Rotate");
        boxCollider2D.enabled = false;
    }

    public void PlayVfx()
    {
        GameObject vfxExplosion = Instantiate(vfx, transform.position, Quaternion.identity);
        Destroy(vfxExplosion, 1f);
        GameManager.Instance.CheckLevelUp();
    }
}
