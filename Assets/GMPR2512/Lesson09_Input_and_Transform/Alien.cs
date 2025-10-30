using UnityEngine;

namespace Lesson09_Input_and_Transform
{
    public class Alien : MonoBehaviour
    {
        [SerializeField] private int _upperRandomFiringRange;
        [SerializeField] private GameObject _projectilePrefab;
        [SerializeField] private float _projectileSpeed = 10, _projectileSpinVelocity = 0;
        [SerializeField] private Transform _firingPositionTransform;

        
        void Update()
        {
            

            int rando = Random.Range(1, _upperRandomFiringRange);
            if (rando == 1)
            {
                GameObject thePrefab =
                    Instantiate(_projectilePrefab, _firingPositionTransform.position, transform.rotation);

                Projectile projectileScript
                    = thePrefab.GetComponent<Projectile>();

                //"transform.up" means "up according to the gameobject to which this script is attached"
                //in other words, it means "up according to the ship"
                projectileScript.Initialize(transform.up, _projectileSpeed, _projectileSpinVelocity);
            }
        }
        void OnTriggerEnter2D(Collider2D theCollider)
        {
            if (theCollider.tag.Equals("Wall"))
            {
                AlienLeader leaderScript = transform.parent.GetComponent<AlienLeader>();
                leaderScript.ChangeHorizontalDirection();
                //The StepDown method would tell the leader to move down 
                //by one Alien's height
                //leaderScript.StepDown(transform.localScale.y);

                //transform.parent.parent.parent.GetChild(0).GetChild(0).GetChild(0)
            }
        }
    }
}
