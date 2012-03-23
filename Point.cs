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

namespace Libraries.Imaging
{
	//we need to shift elements around by finding a factor for
	//scanning...

	// a d g    d g j
	// b e h => e h k
	// c f i    f i l

	//The image above shows a 3x3 mask
	//the interesting part about this is that when we move over
	//We are shifting elements in the mask to the left by one
	//for each line. "You're a wish master"

	//this means that we shift elements to the left by one and 
	//only scan for j,k,l
	//or in code for the right operation

	//T[] dat = new T[9];
	//dat[0] = a; dat[1] = d; dat[2] = g;
	//dat[3] = b; dat[4] = e; dat[5] = h;
	//dat[6] = c; dat[7] = f; dat[8] = i;

	//performing the shift right operation yields this
	//dat[0] = dat[1]; dat[1] = dat[2]; dat[2] = j;
	//dat[3] = dat[4]; dat[4] = dat[5]; dat[5] = k;
	//dat[6] = dat[7]; dat[7] = dat[8]; dat[8] = l;

	//performing the down operation consists of this
	// a d g    b e h
	// b e h => c f i
	// c f i    j k l

	//this yields
	//dat[0] = dat[3]; dat[1] = dat[4]; dat[2] = dat[5];
	//dat[3] = dat[6]; dat[4] = dat[7]; dat[5] = dat[8];
	//dat[6] = j;      dat[7] = k;      dat[8] = l;


	//performing a left operation consists of 
	// a d g    j a d
	// b e h => k b e
	// c f i    l c f

	//ordering is important here
	//dat[2] = dat[1]; dat[1] = dat[0]; dat[0] = j;
	//dat[5] = dat[4]; dat[4] = dat[3]; dat[3] = k;
	//dat[8] = dat[7]; dat[7] = dat[6]; dat[6] = l;

	//we want to do this right down left down right repeat until finished
	
}
