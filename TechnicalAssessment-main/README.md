# TechnicalAssessment
The technical assessment seed project

## My notes for DeepestPit
### Extracted to clean the code.

/* Breakdown - (Writing out my thoughts)
    * A pit requires 3 provided points.
    *  - The first point P must be greater or equals to 0
    *  - The second point Q must be less than the first point P and the third point R
    *  - The third point R must be greater than the second point Q
    *  
    * Point from P continuously decrease until point Q is found in the sequence
    * Likewise the sequence from Q continuously increases until point R is found.
    * Depth is the smaller of the two differences between the points. [*]
    * 
    * Use change in direction to determine a pit?
    * Try get relevent points below 0 that actually matter in defining a pit. (This is not true)
    * An actual Pit bottom goes an indefinite amount left till a peak is found, same for the right?
    * 
    * Use all peaks and valleys to determine the depth of the pit. [Try]
    * What if index 0 and ^1 are peaks? [*]
    * I need to think about the fact that P >= 0.
*/