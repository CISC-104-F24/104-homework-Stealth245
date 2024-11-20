using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Collision : MonoBehaviour
{
    private float speed = 4.0f;


    //change object//
    public Transform BookshelfBackingPrefab;

    void OnCollisionEnter(Collision collision)
    {
        ContactPoint contact = collision;
        Quaternion rotation = Quaternion.FromToRotation(Vector3.up, contact.normal);
        Vector3 position = contact.point;
        Instantiate(BookshelfBackingPrefab, position, rotation);
        Destroy(gameObject);
    }
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("LoadScene");
        //load scene//
        SceneManager.LoadScene("HW3", LoadSceneMode.Additive);
        //change color//
        GetComponent<MeshRenderer>().material.color = new Color(0.2f, 1f, 0.33f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
    private void OnTriggerEnter(Collider other)
    {
    speed = speed * -1;
    }
    
}