using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    [SerializeField] Transform target;
    [SerializeField] float speed;

    private float _distance;
   

    private void Start()
    {
        StartCoroutine(RotateAround());
    }

  IEnumerator RotateAround()
    {
        //Gezegenlerin donuslerini yapmalari ve aralarindaki hiza gore mesafeyi hesaplama
        transform.RotateAround(target.transform.position, target.transform.up, speed * Time.deltaTime);
        _distance += speed * Time.deltaTime;
        

        if (_distance>=360)
        {
            
            _distance = 0;
            print(gameObject.name + "Bir tam turunu tamamladi");  //Bir tam turunu tamamladiginda ekranda bir mesaj gostermek icin

        }
        yield return new WaitForEndOfFrame();  
        StartCoroutine(RotateAround());
    }
    
       
    
}
