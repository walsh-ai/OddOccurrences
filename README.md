Find the 'odd occurrence' in an array with an odd number of elements (integers).
Each element can be paired with a duplicate, except for one which is left unpaired and has only one instance in the
array. 
Write a method to return the unpaired 'odd' element. 

Two methods are proposed, one being more efficient than the other. The first method is to use a Hash Set into which each unseen element is inserted while iterating the array, and from which each seen element existing in the Hash Set is removed when it is seen again. Finally, only the unpaired element remains in the Hash Set and can be returned. 

The second 'fast' method does not require a Hash Set, although it also runs in O(n) with the size of the array. Starting at 0, a running value A is updated while iterating the array as A = (A XOR B) for each array element B. Through repeated XOR, paired elements will cancel themselves out. Finally, A will hold the value of the unpaired element. This can be a bit awkward to imagine and it is just as well to test the idea by hand. 
