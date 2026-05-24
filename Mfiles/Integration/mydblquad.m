function dbint = mydblquad(strfunc, x1, x2, y1, y2)

F = inline(strfunc)  ;
dbint = dblquad(F, x1, x2, y1, y2) ;
