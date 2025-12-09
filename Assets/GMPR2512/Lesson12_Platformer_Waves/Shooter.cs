using UnityEngine;

namespace GMPR2512.Lesson12_Platformer_Waves
{
    public class Shooter : MonoBehaviour
    {
        private GameObject lastObjectHit;
        private LineRenderer _laserLine;
        [SerializeField] private float _laserLength = 8f;
        
        void Awake()
        {
            if(_laserLine == null)
            {
                _laserLine = GetComponent<LineRenderer>();
            }
            if(_laserLine != null)
            {
                _laserLine.positionCount = 2;
                _laserLine.useWorldSpace = true;
                _laserLine.startWidth = 0.05f;
                _laserLine.endWidth = 0.05f;
            }
        }
        void Update()
        {
            float rotationInput = 0;
            if(Input.GetKey(KeyCode.Comma))
            {
                rotationInput = 1;
            }
            else if(Input.GetKey(KeyCode.Period))
            {
                rotationInput = -1;
            }
            transform.parent.transform.Rotate(new Vector3(0, 0, rotationInput * 0.1f));


            int layerMask = LayerMask.GetMask("Ground", "Enemy");
            RaycastHit2D rh2d = Physics2D.Raycast(transform.position, transform.right, _laserLength, layerMask);

            //the raycast is hitting something in the layer that it's looking for
            if(rh2d.transform != null)
            {
                //****** have we hit the player? destroy! *****
                Destroy(rh2d.transform.gameObject);
                // rh2d.transform.gameObject.GetComponent<Renderer>().material.color = Color.blue;
                // lastObjectHit = rh2d.transform.gameObject;;
            }
            // else if(lastObjectHit != null)//we were pointing at something, but not anymore
            // {
            //     // lastObjectHit.gameObject.GetComponent<Renderer>().material.color = Color.white;
            // }
            Vector3 endPoint = transform.position + transform.right * _laserLength;
            if(rh2d.collider != null) //if our laser has hit something, don't draw it through the thing we hit
            {
                endPoint = rh2d.point;
            }

            _laserLine.SetPosition(0, transform.position);
            _laserLine.SetPosition(1, endPoint);

        }

        void OnDrawGizmos()
        {
           Gizmos.color = Color.red;
           Gizmos.DrawSphere(transform.position, .04f);
           Gizmos.DrawRay(transform.position, transform.right * 1000); 
        }
    }
}
