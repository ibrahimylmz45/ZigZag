using UnityEngine;

public class ZeminDusmeKontrol : MonoBehaviour
{
    int a = 0;
    void Update()
    {
        if (a == 0)
        {
            if (transform.position.y <= 0)
            {
                Rigidbody zeminRigi = gameObject.GetComponent<Rigidbody>();
                zeminRigi.constraints = RigidbodyConstraints.FreezeAll;
                transform.position = new Vector3(transform.position.x, 0, transform.position.z);
                a = 1;
            }
        }
    }
}
