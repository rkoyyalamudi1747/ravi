﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1st_assignment
{
    public class Rectangle
  
        {
            private int length;
            private int width;
            
            public Rectangle()
            {
                length = 1;
                width = 1;
            }
            public Rectangle(int length, int width)
            {
                this.length = length;
                this.width = width;
            }
            public int GetLength()
            {
                return length;
            }
            public int SetLength(int length)
            {
                this.length = length;
                return this.length;
            }
            public int GetWidth()
            {
                return width;
            }
            public int SetWidth(int Width)
            {
                this.width = Width;
                return this.width;
            }
            public int GetPerimeter()
            {

                return (width * 2) + (length * 2);
            }
            public int GetArea()
            {

                return width * length;
            }


        }

    }
