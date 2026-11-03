using UnityEngine;
using UnityEngine.AI;

public class DeerW5 : MonoBehaviour
{
    [SerializeField] private Animator _animator;
    [SerializeField] private NavMeshAgent _NavMeshAgent;
    [SerializeField] private Transform _Target;
    

    //private string _isWalkingName = "IsWalking";

    private void Start()
    {
        Vector3 destination = _Target.position;
        _NavMeshAgent.SetDestination(destination);


    }

}


// Write your DeerW5 class in here :)
// Hint: if you don't remember what a class is supposed to look like,
//      maybe check out CatW5...
// If you copied the class declaration from CatW5, you'd only need to change one thing...