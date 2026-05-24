function [t, y] = myode45firstorder(strfunc, tspan, y0)

[t, y] = ode45(@yourfunc, tspan, y0, [], strfunc) ;

