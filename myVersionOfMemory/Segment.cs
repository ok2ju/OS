using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Memory
{
    public class Segment
    {
        private bool isFull;
        private int currentAdress;
        private int size;
        private int preview;
        private int next;

        public Segment(int currentAdress)
        {
            this.currentAdress = currentAdress;
        }

        public void setIsFull(bool isFull)
        {
            this.isFull = isFull;
        }

        public bool getIsFull()
        {
            return isFull;
        }

        public void setCurrentAdress(int currentAdress)
        {
            this.currentAdress = currentAdress;
        }

        public int getCurrentAdress()
        {
            return currentAdress;
        }

        public void setSizeOfSegment(int sizeOfSegment)
        {
            this.size = sizeOfSegment;
        }

        public int getSizeOfSegment()
        {
            return size;
        }

        public void setPreview(int preview)
        {
            this.preview = preview;
        }

        public int getPreview(int preview)
        {
            return preview;
        }

        public void setNext(int next)
        {
            this.next = next;
        }

        public int getPreview()
        {
            return preview;
        }
    }
}
