using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DigHole : MonoBehaviour
{
    public Sprite hole2;

    public GameObject preyObject;

    private new SpriteRenderer renderer;

    private readonly float _digInterval = 5.0f;
   // private readonly float _spawnPrey = 12.0f;
    private readonly float _spawnFoodInterval = 15.0f;
    private float _time;
    private bool madehole=false;
    // Start is called before the first frame update
    void Start()
    {
        _time = 0f;
        renderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        _time += Time.deltaTime;
        if (_time >= _digInterval&&madehole==false)
        {
            madehole = true;
            DigMore();
            MakePrey();
        }

       
        while (_time >= _spawnFoodInterval)
        {
            RemoveHole();
            _time -= _spawnFoodInterval;
        }


    }
    //Second level of hole
    void DigMore()
    {
        renderer.sprite = hole2;
    }
   
    void RemoveHole()
    {
       
        //Destroy hole
        Destroy(this.gameObject);
    }

    void MakePrey()
    {
        //Call new interactable object
        Instantiate(preyObject, new Vector3(this.gameObject.transform.localPosition.x+0.05f, this.gameObject.transform.localPosition.y+0.15f, 0), Quaternion.identity);

    }
}
