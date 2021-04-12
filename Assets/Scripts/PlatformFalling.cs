using System.Collections;
using UnityEngine;

public class PlatformFalling : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        GetComponent<Renderer>().material.color = Color.green;
        StartCoroutine("WaitThenFall");
    }
    IEnumerator WaitThenFall()
    {
        yield return new WaitForSeconds(2);
        GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
    }
}
