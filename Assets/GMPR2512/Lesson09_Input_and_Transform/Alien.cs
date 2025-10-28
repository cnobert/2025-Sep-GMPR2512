using UnityEngine;

namespace Lesson09_Input_and_Transform
{
    public class Alien : MonoBehaviour
    {
        [SerializeField] private int _upperRandomFiringRange;
        [SerializeField] private GameObject _projectilePrefab;
        [SerializeField] private float _movementSpeed = 5;
        [SerializeField] private float _projectileSpeed = 10, _projectileSpinVelocity = 0;
        [SerializeField] private Transform _firingPositionTransform;
        void Update()
        {
            int rando = Random.Range(1, _upperRandomFiringRange);
            if(rando == 1)
            {
                GameObject thePrefab = Instantiate(_projectilePrefab, transform.position, transform.rotation);

                Projectile projectileScript
                    = thePrefab.GetComponent<Projectile>();

                //"transform.up" means "up according to the gameobject to which this script is attached"
                //in other words, it means "up according to the ship"
                projectileScript.Initialize(transform.up, _projectileSpeed, _projectileSpinVelocity);
            }
        }
    }
}
