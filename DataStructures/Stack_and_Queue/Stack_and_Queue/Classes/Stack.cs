﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Stack_and_Queue.Classes
{
    public class Stack
    {
        // Declares a field for the "Top" (Last-in, First-out) Node in the Stack
        public Node Top { get; set; }

        /// <summary>
        /// Constructor method for creating the Stack
        /// </summary>
        /// <param name="node">Node to add to Stack</param>
        public Stack(Node node)
        {
            Top = node;
        }

        /// <summary>
        /// Method which adds a Node to the Top of the Stack
        /// </summary>
        /// <param name="node">Node to add to Stack</param>
        public void Push(Node node)
        {
            node.Next = Top;
            Top = node;
        }

        /// <summary>
        /// Method which removes the Top Node from the Stack
        /// </summary>
        /// <returns>Node</returns>
        public Node Pop()
        {
            if (Top != null)
            {
                Node Temp = Top;
                Top = Top.Next;

                Temp.Next = null;
                return Temp;
            }

            return null;
        }

        /// <summary>
        /// Method to grab the Top node in the Stack without removing the Node
        /// </summary>
        /// <returns>Node</returns>
        public Node Peek()
        {
            return Top;
        }
    }
}
