using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] GameObject ball;
    [SerializeField] float minPosX;
    [SerializeField] float maxPosX;
    [SerializeField] float minPosY;
    [SerializeField] float maxPosY;
    [SerializeField] float minPosZ;
    [SerializeField] float maxPosZ;
    [SerializeField] int countBalls;
    private int actualCountBalls;
    // Start is called before the first frame update
    void Start()
    {
        actualCountBalls = 0;
        StartCoroutine(SpawnBalls());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator SpawnBalls()
    {
        yield return new WaitForSeconds(3f);
        Vector3 position = new Vector3(GeneratePosition(minPosX,maxPosX),GeneratePosition(minPosY,maxPosY)
            ,GeneratePosition(minPosZ,maxPosZ));
        Instantiate(ball,position,ball.transform.rotation);
        actualCountBalls++;
        if (actualCountBalls<countBalls)
        {
            StartCoroutine(SpawnBalls());
        }
        else
        {
            StopCoroutine(SpawnBalls());
        }

    }

    private float GeneratePosition(float _minPos , float _maxPos)
    {
        return Random.Range(_minPos,_maxPos);
    }
}
