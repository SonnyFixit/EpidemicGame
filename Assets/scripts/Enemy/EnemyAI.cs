using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

[RequireComponent (typeof (Rigidbody2D))]
[RequireComponent (typeof (Seeker))]
public class EnemyAI : MonoBehaviour
{

    public Transform target;
    public float updateRate = 2f;
    private Seeker seeker;
    private Rigidbody2D rb;
    public Path path;
    public float speed = 300f;
    public ForceMode2D fMode;

    [HideInInspector]
    public bool pathisEnding = false;
    public float nextWaypointDistance = 3;
    private int currentWaypoint = 0;


    private void Start()
    {
        seeker = GetComponent<Seeker>();
        rb = GetComponent<Rigidbody2D>();

        if(target == null)
        {
            Debug.LogError("No player found");
            return;
        }

        seeker.StartPath(transform.position, target.position, OnPathComplete);


        StartCoroutine(UpdatePath());
    }

    IEnumerator UpdatePath()
    {
        if (target == null)
        {
            yield break;
        }

        seeker.StartPath(transform.position, target.position, OnPathComplete);
        yield return new WaitForSeconds(1 / updateRate);
        StartCoroutine(UpdatePath());
    }

    public void OnPathComplete(Path p)
    {
        Debug.Log(p.error);
        if(!p.error)
        {
            path = p;
            currentWaypoint = 0;
        }
    }

    private void FixedUpdate()
    {
        if(path == null)
        {
            return;
        }

        if(target == null)
        {
            return;
        }

        if(currentWaypoint >= path.vectorPath.Count)
        {
            if(pathisEnding)
            {
                return;
            }

            Debug.Log("end of path reached");
            pathisEnding = true;
            return;
        }

        pathisEnding = false;

        Vector3 dir = (path.vectorPath[currentWaypoint] - transform.position).normalized;
        dir *= speed * Time.fixedDeltaTime;

        rb.AddForce(dir, fMode);

        float dist = Vector3.Distance(transform.position, path.vectorPath[currentWaypoint]);

        if (dist < nextWaypointDistance)
        {
            currentWaypoint++;
            return;
        }
    }
}
