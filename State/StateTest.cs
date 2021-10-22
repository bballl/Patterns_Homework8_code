using UnityEngine;

namespace BehavioralPatterns.State.ExampleFirst
{
    public sealed class StateTest : MonoBehaviour
    {
        private void Start()
        {
            //Player c = new Player(new ConcreteStateA());

            
            
        }

        private void Update()
        {
            ChangeState();
        }

        public void ChangeState()
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                StateRotation();
            }

            if (Input.GetKeyDown(KeyCode.Q))
            {
                StateRise();
            }
        }

        public void StateRise()
        {
            Debug.Log("Выполняю взлет");
        }

        public void StateRotation()
        {
            Debug.Log("Выполняю вращение");
        }

        public void StateNeutral()
        {
            Debug.Log("Нейтральное состояние");
        }
    }
}
