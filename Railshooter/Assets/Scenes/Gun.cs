
using UnityEngine;

public class Gun : MonoBehaviour
{
    public float damage = 10f;
    public float range = 100f;
    public Texture2D curseur;

    public Camera fpscam;
    public ParticleSystem Flash;
    public GameObject impactEffect;

    public GameObject gun;
    public float throwForce = 4f;
    public float plasmabullet = 4f;
    public GameObject grenadePrefab;
    public GameObject PlasmaBall;
    public GameObject cible;


    private void Start()
    {
        Cursor.SetCursor(curseur, Vector2.zero, CursorMode.Auto);
    }
    void Update()
    {
        ///Ray ray = fpscam.ScreenPointToRay(Input.mousePosition);
        ///if (Physics.Raycast(ray, out RaycastHit raycastHit))
        ///{
        ///    transform.position = raycastHit.point;
        ///}
        Vector3 mousePos = Input.mousePosition;
        mousePos.z = 100f;
        mousePos = fpscam.ScreenToWorldPoint(mousePos);
        Debug.DrawRay(transform.position, mousePos - transform.position,
        Color.blue);

        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }

        if (Input.GetKeyDown("g"))
        {
            ThrowGrenade();
        }

        if (Input.GetKeyDown("c"))
        {
            Plasma();
        }
    }

    void Shoot()
    {
        Flash.Play();
        RaycastHit hit;
        Ray ray = fpscam.ScreenPointToRay(Input.mousePosition);

        ///Debug.DrawRay(transform.position, transform.forward * 100, Color.red);
        if (Physics.Raycast(ray, out hit, 100))
        {
            Debug.Log("PLS JE VEUX QUE CA MARCHE !!");
            Instantiate(impactEffect, hit.point, Quaternion.LookRotation(hit.normal));
        }
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
        rb.AddForce(mousePos / 6, ForceMode.VelocityChange);

    }

    void Plasma()
    {
        Vector3 mousePos = Input.mousePosition;
        mousePos.z = 100f;
        mousePos = fpscam.ScreenToWorldPoint(mousePos);
        GameObject PlasmaBal = Instantiate(PlasmaBall, transform.position, transform.rotation);
        Rigidbody rb = PlasmaBal.GetComponent<Rigidbody>();
        rb.AddForce(mousePos / plasmabullet, ForceMode.VelocityChange);
    }
}
