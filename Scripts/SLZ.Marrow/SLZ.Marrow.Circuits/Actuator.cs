using System;
using System.Collections.Generic;
using System.Linq;
using SLZ.Marrow.Circuits;
using UnityEngine;
using UnityEngine.UIElements;

namespace SLZ.Marrow.Circuits
{
    public class Actuator : MonoBehaviour
    {
        private float _updateFixedTime = -1f;
        private float _updateSeed;
        private Circuit[] _inputs;
        protected ExternalActuator _externalActuator;
        public double updateFixedTime
        {
            get
            {
                float num = _updateFixedTime;
            }
        }
        public float updateSeed
        {
            get
            {
                return _updateSeed;
            }
        }
        public ExternalActuator externalActuator
        {
            get
            {
                return _externalActuator;
            }
            set
            {
                _externalActuator = value;
            }
        }
        protected virtual void Awake()
        {
        }
        protected virtual void Start()
        {
        }
        protected virtual void OnDestroy()
        {
        }
        protected virtual void Initialize()
        {
        }
        public void RecursiveUpdate(float fixedTime)
        {
        }
        public void InitializingUpdate(float seed)
        {
        }
        protected virtual void Actuate(double fixedTime, bool isInitializing = false)
        {
        }
        public virtual void SetupInputs()
        {
        }
        protected void SetInputs()
        {
        }
        protected void SetInputs(Circuit circuitA)
        {
        }
        protected void SetInputs(Circuit circuitA, Circuit circuitB)
        {
        }
        protected void SetInputs(Circuit circuitA, Circuit circuitB, Circuit circuitC)
        {
            
        }
        protected void SetInputs(Circuit[] circuits)
        {
        }
        private void LinkInputs()
        {
        }
        private void UnlinkInputs()
        {
        }
        public Actuator()
        {
            int num = 0;
            _updateSeed = -1f;
            _inputs = new Circuit[num];
        }
    }
}