using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPS : MonoBehaviour
{//Здоровье
    public int health=3;
        //Уровень 
        public int level=1;
        //Скорость 
        public float speed=1.3f;
    // Start is called before the first frame update
    void Start()
    {
        health += level;
        print("Жизней:" + health);
    }
   

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = transform.position;
        newPosition.z += speed * Time.deltaTime;
        transform.position = newPosition;
    }
}
