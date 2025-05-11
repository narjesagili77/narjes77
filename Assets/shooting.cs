

using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
public class shooting : MonoBehaviour
{
    public GameObject gm;
    public GameObject pos;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.J))
        {
            shoot();
        }
    }
    void shoot()
    {
        GameObject bullet = Instantiate(gm, pos.transform.position, Quaternion.identity);
        bullet.GetComponent<Rigidbody>().AddForce(Vector3.right * 250);
        Destroy(bullet, 5f);

    }
}