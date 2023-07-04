using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ZombiHareket : MonoBehaviour
{
    public GameObject kalp;
    private GameObject Oyuncu;
    private int zombidenGelenPuan=10;
    private int zombiCan = 3;
    private float mesafe;
    private OyunKontrol oKontrol;
    private AudioSource aSource;
    
    
    // Start is called before the first frame update
    void Start()
    {
        aSource= GetComponent<AudioSource>();
        Oyuncu = GameObject.Find("FPSController");
        oKontrol=GameObject.Find("_Scripts").GetComponent<OyunKontrol>();
    }

    // Update is called once per frame
    void Update()
    {

        GetComponent<NavMeshAgent>().destination = Oyuncu.transform.position;
        mesafe = Vector3.Distance(transform.position, Oyuncu.transform.position);

        if (mesafe < 10f && zombiCan!=0)
        {
            if(!aSource.isPlaying)
            aSource.Play();
            GetComponentInChildren<Animation>().Play("Zombie_Attack_01");
        }
        else
        {
            if (aSource.isPlaying)
                aSource.Stop();
        }
    }
    private void OnCollisionEnter(Collision c)
    {
        if (c.collider.gameObject.tag.Equals("mermi"))
        {
            
            zombiCan--;
            if (zombiCan == 0)
            {
                oKontrol.PuanArttir(zombidenGelenPuan);
                Instantiate(kalp,transform.position,Quaternion.identity);
                GetComponentInChildren<Animation>().Play("Zombie_Death_01");
                Destroy(this.gameObject,1.667f);
            }
        }
    }
}
