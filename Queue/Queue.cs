﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    public class Queue
    {
        private int maxSize;
        private long[] myQueue;
        private int front;
        private int rear;
        private int items;

        public Queue(int size)
        {
            maxSize = size;
            myQueue = new long[size];
            front = 0;
            rear = -1;
            items = 0;
        }

        public void insert(long j)
        {

            if (isFull())
            {
                Console.WriteLine("Queue is Full");

            }
            else
            {
                if (rear==maxSize - 1)
                {
                    rear = -1;
                }
                rear++;
                myQueue[rear] = j;
                items++;

            }
        }

        public long remove()
        {
            long temp = myQueue[front];
            front++;
            if (front ==maxSize)
            {
                front = 0;
            }
            return temp;

        }

        public long  peekFront()
        {
            return myQueue[front];
        }
        public bool isEmpty()
        {
            return (items == 0);
        }
        public bool isFull()
        {

            return (items == maxSize);
        }

    }
}
