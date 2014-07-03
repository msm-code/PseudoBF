namespace Brainfuck
{
    public class BrainfuckMachine
    {
        private byte[] bytes;
        private int headLoc;

        public BrainfuckMachine() : this(128) { }

        public BrainfuckMachine(int cellCount)
        {
            this.bytes = new byte[cellCount];
        }

        public byte[] GetCurrentState() 
        { return bytes; }

        public void Execute(string code)
        {
            for (int i = 0; i < code.Length; i++)
            {
                switch (code[i])
                {
                    case '-': bytes[headLoc] = unchecked((byte)(bytes[headLoc] - 1)); break;
                    case '+': bytes[headLoc] = unchecked((byte)(bytes[headLoc] + 1)); break;
                    case '<': headLoc--; break;
                    case '>': headLoc++; break;
                    case '[': if (bytes[headLoc] == 0) { i = FindLoopEnd(code, i, Direction.Forward); } break;
                    case ']': if (bytes[headLoc] != 0) { i = FindLoopEnd(code, i, Direction.Backward); } break;
                    case ',': IoReadChar(headLoc); break;
                    case '.': IoPutChar(headLoc); break;
                }
            }
        }

        private enum Direction
        { Backward = -1, Forward = 1 }

        private int FindLoopEnd(string code, int loc, Direction dir)
        {
            int nest = (int)dir;

            while (nest != 0)
            {
                loc += (int)dir;
                if (code[loc] == '[') { nest++; }
                if (code[loc] == ']') { nest--; }
            }
            return loc;
        }

        private void IoPutChar(int loc) { }
        private void IoReadChar(int loc) { }

        public int HeadLocation
        {
            get { return headLoc; }
        }

        public byte GetCell(int loc)
        {
            return bytes[loc];
        }

        public void SetCell(int loc, byte value)
        {
            bytes[loc] = value;
        }
    }
}
