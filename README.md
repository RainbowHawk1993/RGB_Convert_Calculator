This is an algorithm created to find the least amount of steps possible to convert a three number array into an array with two zeroes.

The rules of numbers converting are the following:

Numbers with index 0 and 1 can decrement by one, then number with index 2 will increment by 2. Same is true for all other possible decrements/increments.
Numbers can't go below 0.

My solution for this algorithm is the following:
1. Check if non-target colors can be equalized and if the target color can supply enough digits for the equalization
2. Make non-target colors equal
3. Decrement non-colors numbers until they are both 0.

In this code example I don't use loops or decrement/increment everything because I care only for finding required amount of steps.

Also I am pretty sure that the answer is always gonna be equal to the larger of the non-target colors.
