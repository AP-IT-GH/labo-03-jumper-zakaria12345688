using UnityEngine;
using Unity.MLAgents;
using Unity.MLAgents.Sensors;
using Unity.MLAgents.Actuators;

public class CubeAgent : Agent
{
    public Transform target, greenZone;
    public float moveSpeed = 5f;
    private bool hasTarget = false;

    public override void OnEpisodeBegin()
    {
        transform.localPosition = Vector3.up;
        target.localPosition = new Vector3(Random.Range(-5f, 5f), 0.5f, Random.Range(-5f, 5f));
        hasTarget = false;
        target.gameObject.SetActive(true);
    }

    public override void CollectObservations(VectorSensor sensor)
    {
        sensor.AddObservation(hasTarget ? greenZone.localPosition : target.localPosition);
        sensor.AddObservation(transform.localPosition);
        sensor.AddObservation(hasTarget ? 1f : 0f);
    }

    public override void OnActionReceived(ActionBuffers actions)
    {
        // Bepaal doelpositie
        Vector3 targetPos = hasTarget ? greenZone.position : target.position;
        
        // Beweging
        Vector3 move = (targetPos - transform.position).normalized * moveSpeed * Time.deltaTime;
        transform.localPosition += new Vector3(move.x, 0, move.z);

        // Target oppakken
        if (!hasTarget && Vector3.Distance(transform.position, target.position) < 1.5f)
        {
            hasTarget = true;
            target.gameObject.SetActive(false);
            SetReward(1f);
        }

        // Afleveren
        if (hasTarget && Vector3.Distance(transform.position, greenZone.position) < 2f)
        {
            SetReward(1f);
            EndEpisode();
        }

        AddReward(-0.001f);
    }
}