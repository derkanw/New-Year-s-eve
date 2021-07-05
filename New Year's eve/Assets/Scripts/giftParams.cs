using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class giftParams : MonoBehaviour
{
    public GameObject target;
    public int power;
    private Vector3 startPos;
    private float progress, step = 0.1f;

    void OnCollisionEnter(Collision collision)
    {
        /*Vector3 point = collision.contacts[0].point;
        if (Vector3.Distance(point, target.transform.position) < 1 || target != null)
        {
            childParams param = target.GetComponent<childParams>();
            param.hp -= power;
        }*/
        Destroy(this);
    }

    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(startPos,
            new Vector3(target.transform.position.x, target.transform.position.y + 1, target.transform.position.z), progress);
        progress += step;
    }
}
