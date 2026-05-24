function dy = yoursecondfunc(t, y, strfunc)

% example:
% y'' - 2y' -6y = cos(3t)
% y'' = cos(3t) + 2y' + 6y 
% write an expression string with replace y' by yprime:
%      cos(3*t) + 2*yprime + 6*y


f0 = inline('yy') ;
dy(1,:) = feval( f0, y(2) ) ;

%trick for a function with/without t, yprime, y
strfunction = strcat(strfunc, '+ 0*t + 0*yprime + 0*y') ;

f1 = inline(strfunction) ;
dy(2,:) = feval(  f1, t , y(1), y(2) ) ;








