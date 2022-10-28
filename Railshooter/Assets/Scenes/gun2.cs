using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gun2 : MonoBehaviour
{
    public Texture2D curseur;
    public Camera fpscam;
    public GameObject PlasmaBall;
    public GameObject grenadePrefab;
    public Animator mAnimator;
    public GameObject gun;

    // Start is called before the first frame update
    private void Start()
    {
        Cursor.SetCursor(curseur, Vector2.zero, CursorMode.Auto);
    }

    // Update is called once per frame
    void Update()
    {
        mAnimator = gun.GetComponent<Animator>();
        mAnimator.SetBool("tirr", false);
        if (Input.GetKeyDown("c"))
        {
            Plasma();
        }

        if (Input.GetKeyDown("g"))
        {
            ThrowGrenade();
        }
    }

    void Plasma()
    {
        mAnimator = gun.GetComponent<Animator>();
        mAnimator.SetBool("tirr", true);
        Vector3 mousePos = Input.mousePosition;
        mousePos.z = 100f;
        mousePos = fpscam.ScreenToWorldPoint(mousePos);
        GameObject PlasmaBal = Instantiate(PlasmaBall, transform.position, transform.rotation);
        Rigidbody rb = PlasmaBal.GetComponent<Rigidbody>();
        rb.AddForce((mousePos - transform.position) / 5, ForceMode.VelocityChange);
    }

    void ThrowGrenade()
    {
        ///RaycastHit hit;
        ///Ray ray = fpscam.ScreenPointToRay(Input.mousePosition);
        Vector3 mousePos = Input.mousePosition;
        mousePos.z = 100f;
        mousePos = fpscam.ScreenToWorldPoint(mousePos);
        GameObject grenade = Instantiate(grenadePrefab, transform.position, transform.rotation);
        Rigidbody rb = grenade.GetComponent<Rigidbody>();
        rb.AddForce((mousePos - transform.position) / 3, ForceMode.VelocityChange);

    }
}
