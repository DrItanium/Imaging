//Copyright 2012 Joshua Scoggins. All rights reserved.
//
//Redistribution and use in source and binary forms, with or without modification, are
//permitted provided that the following conditions are met:
//
//   1. Redistributions of source code must retain the above copyright notice, this list of
//      conditions and the following disclaimer.
//
//   2. Redistributions in binary form must reproduce the above copyright notice, this list
//      of conditions and the following disclaimer in the documentation and/or other materials
//      provided with the distribution.
//
//THIS SOFTWARE IS PROVIDED BY Joshua Scoggins ``AS IS'' AND ANY EXPRESS OR IMPLIED
//WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND
//FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL Joshua Scoggins OR
//CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR
//CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR
//SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON
//ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING
//NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF
//ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
//
//The views and conclusions contained in the software and documentation are those of the
//authors and should not be interpreted as representing official policies, either expressed
//or implied, of Joshua Scoggins. 
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Drawing;
using System.Drawing.Imaging;


namespace TheoreticalIndustries.Libraries.Imaging
{
	public unsafe struct Pixel3
	{
		public byte Red { get; set; }
		public byte Green { get; set; }
		public byte Blue { get; set; }
		public Pixel3(byte* input)
			: this(input[0], input[1], input[2])
		{
		}
		public Pixel3(byte red, byte green, byte blue)
			: this()
		{
			Red = red;
			Green = green;
			Blue = blue;
		}
		public static explicit operator Pixel1(Pixel3 pix)
		{
			float f0 = 0.3f * (float)pix.Red;
			float f1 = 0.59f * (float)pix.Green;
			float f2 = 0.11f * (float)pix.Blue;
			return new Pixel1((byte)(f0 + f1 + f2));
			//how do I select the b
		}
		public static explicit operator Pixel4(Pixel3 pix)
		{
			return new Pixel4(pix.Red, pix.Green, pix.Blue, (byte)255);
		}
	}
}
