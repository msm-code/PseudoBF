﻿using PseudoBF.CodeDom;
using System.Collections.Generic;
using System;
using System.Linq;

namespace PseudoBF.CodeInfrastructure
{
    public class StackContext
    {
        private Stack<StackFrame> callStack;

        public StackContext()
        {
            callStack = new Stack<StackFrame>();
        }

        public void Enter(Subroutine subroutine)
        {
            StackFrame frame = new StackFrame(this, subroutine);
            callStack.Push(frame);
        }

        public void Exit(Subroutine subroutine)
        {
            if (CurrentFrame.Subroutine != subroutine)
            { throw new InvalidOperationException("Trying to exit method other than current"); }
            callStack.Pop();
        }

        public bool InContext(Subroutine subroutine)
        {
            return callStack.Any((frame) => frame.Subroutine == subroutine);
        }

        public StackFrame CurrentFrame
        {
            get { return callStack.Peek(); }
        }
    }
}
