using UnityEngine;

namespace GMPR2512.Lesson05_Final_Deathzone
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
            Gizmos.DrawSphere(transform.position, _radius);
        }
    }
}
