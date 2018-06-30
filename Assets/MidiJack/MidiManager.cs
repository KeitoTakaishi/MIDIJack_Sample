using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MidiJack
{
    public class MidiManager : MonoBehaviour
    {
        private int _KnobNum = 8;
        public GameObject[] meter;
        private Vector3[] _pos;
        void Start()
        {
            _pos = new Vector3[_KnobNum];
            for (int i = 0; i < _KnobNum; i++){
                _pos[i] = meter[i].transform.position;
            }
           
        }

        void Update()
        {
            for (int i = 0; i < _KnobNum; i++)
            {

                meter[i].transform.position =
                            new Vector3(_pos[i].x, MidiMaster.GetKnob(MidiChannel.Ch1, i)*5.0f, _pos[i].z);
            }
        }
    }
}
