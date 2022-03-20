using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnHoles : MonoBehaviour
{

    public GameObject holeMound;
    private float yvalue, xvalue;

    private readonly float _interval = 6.0f;
    private float _time;

    // Start is called before the first frame update
    void Start()
    {
        _time = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        _time += Time.deltaTime;
        while (_time >= _interval)
        {
            SpawnInGameObject();
            _time -= _interval;
        }
    }


    void SpawnInGameObject()
    {
        //Pick coordinates
        yvalue = Random.Range(4.1f, -4.5f);
        xvalue = Random.Range(7.0f, -8.0f);

        Instantiate(holeMound, new Vector3(xvalue, yvalue, 0), Quaternion.identity) ;


    }


}
