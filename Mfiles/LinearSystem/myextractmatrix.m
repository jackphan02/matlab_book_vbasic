function B = myextractmatrix(A, rowa, rowb, cola, colb)

B = A(rowa:rowb, cola:colb) ;
% extract from row a to row b, and from col a to col b