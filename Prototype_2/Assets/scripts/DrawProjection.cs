using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawProjection : MonoBehaviour
{
    CanonController canonController;
    LineRenderer lineRenderer;

    //num of points on the line
    public int numPoints = 50;

    // distance between those points
    public float timeBetweenPoints = 0.1f;

    // The physics layers that will cause the line to stop being drawn
    public LayerMask CollidableLayers;

    // Start is called before the first frame update
    void Start()
    {
        canonController = GetComponent<CanonController>();
        lineRenderer = GetComponent<LineRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        lineRenderer.positionCount = (int)numPoints;
        List<Vector3> points = new List<Vector3>();
        Vector3 startPosition = canonController.ShotPoint.position;
        Vector3 startVelocity = canonController.ShotPoint.up * canonController.blastPower;
        for (float t = 0; t < numPoints; t += timeBetweenPoints)
        {
            Vector3 newPoint = startPosition + t * startVelocity;
            newPoint.y = startPosition.y + startVelocity.y * t + Physics.gravity.y / 2f * t * t;
            points.Add(newPoint);

            if (Physics.OverlapSphere(newPoint, 2, CollidableLayers).Length > 0)
            {
                lineRenderer.positionCount = points.Count;
                break;
            }
        }
        lineRenderer.SetPositions(points.ToArray());
    }
}
