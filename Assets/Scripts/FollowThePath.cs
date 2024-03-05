using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowThePath : MonoBehaviour
{
    public Transform[] waypoints;

    [SerializeField]
    private float moveSpeed = 1f;

    [HideInInspector]
    public int waypointIndex;

    public bool moveAllowed = false;
    
    // Start is called before the first frame update
    void Start()
    {
        waypointIndex = Tabuleiro.CasaAtual;
        transform.position = waypoints[waypointIndex].transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (moveAllowed)
        {
            Move();
        }
    }

    private void Move()
    {
        if ((Tabuleiro.Pontuacao > 0) && (waypointIndex <= waypoints.Length - 1))
        {
            transform.position = Vector2.MoveTowards(transform.position, waypoints[waypointIndex].transform.position, moveSpeed * Time.deltaTime);
            
            if (transform.position == waypoints[waypointIndex].transform.position)
            {
                waypointIndex++;
            }
        }
        else if ((Tabuleiro.Pontuacao < 0) && (waypointIndex >= 0))
        {
            transform.position = Vector2.MoveTowards(transform.position, waypoints[waypointIndex].transform.position, moveSpeed * Time.deltaTime);

            if (transform.position == waypoints[waypointIndex].transform.position)
            {
                waypointIndex--;
            }
        }
    }
}
