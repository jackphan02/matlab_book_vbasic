function dydt = yourfunc(t, y, strfunc)

%trick for a function with/without t, y
strfunction = strcat(strfunc, '+ 0*t + 0*y') ;

F = inline(strfunction) ;
dydt = feval(F, t, y) ;
