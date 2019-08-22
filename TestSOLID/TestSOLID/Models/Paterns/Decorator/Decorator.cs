using System;
using System.Collections.Generic;
using System.Text;

namespace TestSOLID.Models.Paterns.Decorator
{
    abstract class Decorator : Component
    {
        protected Component component;

        protected Decorator()
        {
        }

        public void SetComponent(Component component) {
            this.component = component;
        }

        public override void Operation()
        {
            if (component != null) {
                component.Operation();
            }
        }
    }
}
