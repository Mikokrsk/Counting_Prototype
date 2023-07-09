using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] GameObject ball;
    [SerializeField] float maxPosX;
    [SerializeField] float minPosY;
    [SerializeField] float maxPosY;
    [SerializeField] float maxPosZ;
    [SerializeField] int countBalls;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void SpawnBall()
    {
        Vector3 position = new Vector3(GeneratePosition(-maxPosX, maxPosX), GeneratePosition(minPosY, maxPosY)
                    , GeneratePosition(-maxPosZ, maxPosZ));
        Instantiate(ball, position, ball.transform.rotation);
    }

    private float GeneratePosition(float _minPos , float _maxPos)
    {
        return Random.Range(_minPos,_maxPos);
    }
}
