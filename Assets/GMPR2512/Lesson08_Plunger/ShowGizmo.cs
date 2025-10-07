using UnityEngine;

namespace GMPR2512.Lesson08_Plunger
{
    public class ShowGizmo : MonoBehaviour
    {
        //SerializeField exposes the private data member in the Unity editor, 
        //while also allowing it to be private, and uneditable via code
        [SerializeField] private Color _gizmoColour = Color.red;
        [SerializeField] private float _radius = 0.5f;
        void OnDrawGizmos()
        {
            
            Gizmos.color = _gizmoColour;

            //"transform" represents the transform of the game object to which this script
            //is attached
            //alternatively, we could GetComponent<Transform>().position
            Gizmos.DrawSphere(transform.position, _radius);
        }
    }
}
