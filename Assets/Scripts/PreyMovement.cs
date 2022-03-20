using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PreyMovement : MonoBehaviour
{

    private readonly float _moveInterval = 10.0f;
    private float _time;
    private Vector3 target;
    private float yvalue, xvalue;
    public float speed = 1.0f;
    private Vector3 position;
    private bool moving = false;
    // Start is called before the first frame update
    void Start()
    {
        _time = 0f;
        position = gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        _time += Time.deltaTime;

        while (_time >= _moveInterval)
        {
            GetNewCoords();
            _time -= _moveInterval;
        }

        if (moving == true)
        {
            float step = speed * Time.deltaTime; // calculate distance to move
            transform.position = Vector3.MoveTowards(transform.position, target, step);
            if(transform.position == target)
            {
                moving = false;
            }
        }
      

    }


    void GetNewCoords()
    {
        yvalue = Random.Range(4.1f, -4.5f);
        xvalue = Random.Range(7.0f, -8.0f);

        target = new Vector3(xvalue, yvalue,0);

        moving = true;
     
    }


}
