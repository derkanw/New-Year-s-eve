using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class santa : MonoBehaviour
{
    public List<GameObject> children;
    private List<childParams> childrenParams = new List<childParams>();
    public GameObject target = null;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < children.Count; ++i)
            childrenParams.Add(children[i].GetComponent<childParams>());
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        DeleteChildren();
        if (children.Count != 0)
            FindTarget();
    }

    private void DeleteChildren()
    {
        List<int> indexes = new List<int>();
        for (int i = 0; i < childrenParams.Count; ++i)
            if (childrenParams[i].hp <= 0)
                indexes.Add(i);

        while (indexes.Count != 0)
        {
            Destroy(children[indexes[0]]);
            childrenParams.Remove(childrenParams[indexes[0]]);
            children.Remove(children[indexes[0]]);
            indexes.Remove(indexes[0]);
        }
    }

    private void FindTarget()
    {
        float distance = 0, temp;

        for (int i = 0; i < children.Count; ++i)
        {
            temp = Vector3.Distance(this.transform.position, children[i].transform.position);
            if (distance == 0 || temp < distance)
            {
                distance = temp;
                target = children[i];
            }
        }
    }
}
