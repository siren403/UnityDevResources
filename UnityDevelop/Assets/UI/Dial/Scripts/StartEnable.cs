using UnityEngine;
using UnityEngine.UI;


namespace UI.Dial
{
    public class StartEnable : MonoBehaviour
    {
        public Behaviour Target = null;

        void Start()
        {
            if(Target != null)
            {
                Target.enabled = true;
            }
        }

    }
}
