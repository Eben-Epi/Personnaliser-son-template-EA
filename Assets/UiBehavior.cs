using System.Runtime.InteropServices;
using UnityEngine;

namespace DefaultNamespace
{
    public class UiBehavior : MonoBehaviour
    {
        [DllImport("__Internal")]
        private static extern void popUp();

        public void triggerPopUp()
        {
            popUp();
        }
    }
}