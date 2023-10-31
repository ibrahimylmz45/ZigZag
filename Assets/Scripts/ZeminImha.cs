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
            //Eðer çok kenardan gidilirse zeminle temas kesilebiliyor. Böyle olunca geçerli zemin geçilmeden düþüþ baþlýyor.
            // Delay tarzý bir method bulabilirsen olayý çözersin.
            timeWaitControl = Time.time + waitTime;
            
        }
    }
}
