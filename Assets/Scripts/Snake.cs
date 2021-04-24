using System.Collections.Generic;
using System.Linq;
using UnityEngine;

[RequireComponent(typeof(LineRenderer))]
public class Snake : MonoBehaviour
{
    public float pointSpacing = .1f;
    public Transform head;

    List<Vector2> points;

    LineRenderer line;

    // Start is called before the first frame update
    void Start()
    {
        line = GetComponent<LineRenderer>();

        points = new List<Vector2>();

        setPoint();
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(points.Last(), head.position) > pointSpacing)
        {
            setPoint();
        }
    }

    void setPoint()
    {
        points.Add(head.position);

        line.positionCount = points.Count;
        line.SetPosition(points.Count - 1, head.position);
    }
}
