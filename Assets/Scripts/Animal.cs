using OpenCover.Framework.Model;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour
{

    private float _movementSpeed = 1;
    protected float movementSpeed // ENCAPSULATION
    {
        get { return _movementSpeed; }
        set
        {
            if (value < 0.0f)
                Debug.LogError("Movement speed cannot be negative");
            else
                _movementSpeed = value;
        }
    }
    protected int movementZone { get; } = 20; // ENCAPSULATION
    protected Vector3 targetPosition;

    [SerializeField] List<AudioClip> AnimalSound;
    private float timeTillNextSound=0;
    private float timeBetweenSounds;

    private string _producedItem="none";
    public string producedItem // ENCAPSULATION
    {
        get { return _producedItem; }
        set
        {
            if (value != "Egg" && value != "Milk" && value != "Wool")
                _producedItem = "none";
            else
                _producedItem = value;
        }
    }

    protected virtual void Start() // POLYMORPHISM
    {
        targetPosition = transform.position;
    }

    private void Update()
    {
        Move();// ABSTRACTION
        Talk();// ABSTRACTION
    }

    private void Move()
    {
        if (DestinationReached())// ABSTRACTION
        {
            SetDestination();// ABSTRACTION
        }
        transform.LookAt(targetPosition);
        transform.Translate (Vector3.forward * _movementSpeed * Time.deltaTime);
    }

    private bool DestinationReached()
    {
        if(transform.position.x - targetPosition.x < 1 && transform.position.y - targetPosition.y < 1 && transform.position.z - targetPosition.z < 1 )
            return true;
        else
            return false;
    }

    private void Talk()
    {
        if (timeTillNextSound <= 0)
        {
            timeBetweenSounds = Random.Range(2f, 7f);
            timeTillNextSound = timeBetweenSounds;
            gameObject.GetComponent<AudioSource>().PlayOneShot(AnimalSound[Random.Range(0,AnimalSound.Count)]);
        }
        timeTillNextSound -= Time.deltaTime;
    }

    protected virtual void SetDestination() // POLYMORPHISM
    {
        targetPosition = new Vector3(Random.Range(-movementZone, movementZone), 0, Random.Range(-movementZone, movementZone));
    }
}
