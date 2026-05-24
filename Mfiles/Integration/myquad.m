function y = myquad(strfunc, a, b)

F = inline(strfunc) ;
y = quad(F, a, b) ;