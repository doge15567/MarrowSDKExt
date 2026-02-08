using SLZ.Marrow;
using SLZ.Marrow.Circuits;
using UnityEngine;
using UnityEngine.UIElements;

namespace SLZ.Marrow.Circuits
{
	public class ActuatorSocket : Actuator
	{
        [SerializeField]
        private Circuit _input;
        [SerializeField]
        protected Servo _servo;
        [SerializeField]
        protected Rigidbody _rb;
        public Circuit input
        {
            get
            {
                return _input;
            }
            set
            {
                _input = value;
            }
        }
        public override void SetupInputs()
        {
        }
        protected virtual void Reset()
        {
        }
        public ActuatorSocket()
        {
            base._updateFixedTime = -1f;
            int num = 0;
            base._updateSeed = -1f;
            base._inputs = new Circuit[num];
        }
    }
}
