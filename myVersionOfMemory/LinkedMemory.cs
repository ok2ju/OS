using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Memory
{
    public class LinkedMemory
    {
        private int size;
        private List<Segment> listOfSegments;
        private int sizeOfSegment;
        IDictionary<Int32, Segment> dictionary = new SortedDictionary<Int32, Segment>();


        public LinkedMemory(int size, int sizeOfSegment)
        {
            this.size = size;
            this.sizeOfSegment = sizeOfSegment;

            init();
        }

        private void init()
        {
            int numberOfSegment = size / sizeOfSegment;

            for (int i = 0; i < numberOfSegment; i++)
            {
                Segment currentSegment = new Segment(i);
                currentSegment.setNext(i + 1);
                currentSegment.setPreview(i - 1);
                currentSegment.setSizeOfSegment(sizeOfSegment);
                currentSegment.setCurrentAdress(i);
                currentSegment.setIsFull(false);
                dictionary.Add(i, currentSegment);
            }
        }

        public void setSize(int size)
        {
            this.size = size;
        }

        public int getSize()
        {
            return size;
        }
    }
}
