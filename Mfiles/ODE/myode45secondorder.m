function [t, y] = myode45secondorder(strfunc, tspan, y0)

[t,y] = ode45(@yoursecondfunc, tspan, y0, [], strfunc) ;
