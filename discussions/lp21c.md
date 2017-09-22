--Lesson Plan 21

--C#

--Name: Xavier Kleiber

1. Give five examples (using valid C# code) of the five bitwise operators listed in the text.
- int x = ~10;
- int x = 10 <<4;
- int x = 10 | 4;
- int x = 10 & 4;
- int x = 10 ^ 4;

2.Does C# implement the right-shift (>>) operator? If so, give an example of its operation using valid C# code.
- The right shift operator is two consecutive greater than operators (>>) 
that takes an integer argument and shits the bits that many places to the right. 
The rightmost bits are discarded and zeros are added to the left: int x = 150 >> 3; 
declares an integer type variable x and assigns it the value 18.

3. Explain in detail this code: bits & (1 << index);.
- (1 << index) will return a value binary equivalent of 1. 
& is comparing the binary value of the variable bits to the binary value of (1 << index).

4. Explain in detail this code: bits |= (1 << index);.
- The code in parenthesis works exactly as explained above. 
The compound assignment operator with the bitwise or compares the 
value in the binary value of the variable bits to the binary value 
of (1 << index) and returns a value that has 1s in all the binary positions in either number. 
So if bits contained the value 8 (00001000) and index contained the value of 5, 
then 00001000 or 00100000 has 1s in the 4th and 6th positions and is 00101000 which is decimal 40. 
The because it's a compound assignment operator, bits is assigned the value 40.

5. Explain in detail this code: bits &= (1 << index);.
- Same code as before with the exception of the compound assignment operator.

6. How does C# interpret this: bool peek = bits[n];?
- This statement is converted to a call to the get accessor for bits, 
and the index argument is set to the value of n. In essence, you are 
declaring a bool type variable peek and assigning it the value returned 
from the get accessor based on the value of n; so if n was 3, it would pass 3 to the get accessor.

7. How does C# interpret this: bits[n] = true;?
- Calls to the set accessor for bits where the index is the value of n and sets the value to true (1).

8. How does C# interpret this: bits[n] ^= true;?
- This statement is converted to a call to both the get and set accessor for bits where the index is the value of n. 
It basically inverts the bit value at the nth position in bits.