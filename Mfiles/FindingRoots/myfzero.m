function x = myfzero(strfunc, x0)

F = inline(strfunc) ;
x = fzero(F, x0) ;