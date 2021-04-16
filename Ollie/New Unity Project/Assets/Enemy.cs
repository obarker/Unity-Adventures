using UnityEngine;

public class Enemy : MonoBehaviour {

    public float speed = 300f;

    private Transform target;
    private int wavepointIndex = 0;

    void Start()
    {
        target = WP.points[0];
    }

    void Update()
    {
        Vector3 dir = target.position - transform.position;
        transform.Translate(dir.normalized * speed * Time.deltaTime, Space.World);

        if (Vector3.Distance(transform.position, target.position) <= 0.2f)
        {
            GetNextWaypoint();

        }    

    }

    void GetNextWaypoint()
    {
        if (wavepointIndex >= WP.points.Length - 1)
        {
            Destroy(gameObject);
        }    

        wavepointIndex++;
        target = WP.points[wavepointIndex];
    }
}

