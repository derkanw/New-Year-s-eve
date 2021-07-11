using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SantaParams : MonoBehaviour
{
    public GameObject prefab;
    public float fireSpeed;
    public int hp;
    private bool flag = false;

    void Start()
    {
    }

    void Update()
    {
        
        if (!flag && Physics.Raycast(transform.position, new Vector3(1, 0, 0), 10f))
        {
            flag = true;
            StartCoroutine(InitGift());
        }
        if (hp == 0)
            Destroy(gameObject);
    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.name == "MaleFree1(Clone)")
        {
            ChildParams child = collider.gameObject.GetComponent<ChildParams>();
            hp -= child.power;
            child.dissatisfaction = 0;
        }
    }

    IEnumerator InitGift()
    {
        float speed = 5f, distance = 10f;
        while (Physics.Raycast(transform.position, new Vector3(1, 0, 0), distance))
        {
            GameObject gift = Instantiate(prefab, new Vector3(transform.position.x , transform.position.y + 1, transform.position.z), Quaternion.identity);
            gift.GetComponent<Rigidbody>().velocity = new Vector3(1, 0, 0) * speed;
            yield return new WaitForSeconds(fireSpeed);

        }
        flag = false;
    }
}
