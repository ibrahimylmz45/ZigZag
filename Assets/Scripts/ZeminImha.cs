using UnityEngine;

public class ZeminImha : MonoBehaviour
{
    public float waitTime;
    float timeWaitControl = 0;
    private void Update()
    {
        if (timeWaitControl <= Time.time && timeWaitControl != 0)
        {
            Rigidbody freezeRigidbody = GetComponent<Rigidbody>();
            freezeRigidbody.constraints = RigidbodyConstraints.None;
        }

        if (transform.position.y <= -8)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if(collision.gameObject.tag == "top")
        {
            //E�er �ok kenardan gidilirse zeminle temas kesilebiliyor. B�yle olunca ge�erli zemin ge�ilmeden d���� ba�l�yor.
            // Delay tarz� bir method bulabilirsen olay� ��zersin.
            timeWaitControl = Time.time + waitTime;
            
        }
    }
}
