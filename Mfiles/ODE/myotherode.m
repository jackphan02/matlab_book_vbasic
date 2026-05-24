function [t, y] = myotherode(tspan, y0)

[t,y] = ode45(@mysecondfunc, tspan, y0) ;
