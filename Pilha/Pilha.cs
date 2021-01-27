using System;

namespace FirstConsoleApplication.StackNamespace
{
    public class Stack
    {
        private Element LastElement;

        // add element to the stack
        public void Push(float value)
        {
            int position;

            try
            {
                position = this.LastElement.GetPosition() + 1;
            }

            catch
            {
                position = 0;
            }

            this.LastElement = new Element(
                value: value,  position: position, previousElement: this.LastElement
            );
        }

        // remove element from the stack
        // (returns the removed element)
        public Element Pop()
        {
            if(this.LastElement.GetPosition() == 0) {
                return null;
            }

            Element removedElement = this.LastElement;

            this.LastElement = this.LastElement.GetPreviousElement();

            return removedElement;
        }

        // access value of the top element of the stack 
        public void GetTopElement()
        {
            Console.WriteLine(this.LastElement.GetValue());
        }

        // list elements from the top to the bottom of the stack
        public void ListElements()
        {
            int position = 1;
            Element currentElement = this.LastElement;

            Console.WriteLine(currentElement.GetValue());

            do
            {
                currentElement = currentElement.GetPreviousElement();
                position = currentElement.GetPosition();

                Console.WriteLine(currentElement.GetValue());
            } while (position > 0);
        }

        public class Element
        {
            private float value;
            private int position;
            private Element previousElement;

            public Element(float value, int position, Element previousElement)
            {
                this.value = value;
                this.position = position;
                this.previousElement = previousElement;
            }

            public float GetValue()
            {
                return this.value;
            }

            public int GetPosition()
            {
                return this.position;
            }

            public Element GetPreviousElement()
            {
                return this.previousElement;
            }
        }
    }
}