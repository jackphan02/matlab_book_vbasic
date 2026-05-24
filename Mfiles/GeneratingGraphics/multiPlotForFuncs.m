function multiPlotForFuncs(strPlot1, colorPlot1, markerPlot1, ... 
                          strPlot2, colorPlot2, markerPlot2, ... 
                          strPlot3, colorPlot3, markerPlot3, ...
                          strTitle, strxlabel , strylabel )

t = linspace(0, 2*pi, 20) ;

% y1 = cos(t)           ;
% y2 = cos(t + pi/3)    ;
% y3 = cos(t + 2*pi/3)  ;

f1 = inline(strPlot1)   ;
y1 = feval( f1, t )     ;

f2 = inline(strPlot2)   ;
y2 = feval( f2, t )     ;

f3 = inline(strPlot3)   ;
y3 =  feval( f3, t )    ;

hold on ;

Hplot1 =  plot (t, y1) ; 
Hplot2 =  plot (t, y2) ; 
Hplot3 =  plot (t, y3) ; 

% set(Hplot1, 'Color', 'r', 'Marker', '*', 'LineStyle', '-')    ;
% set(Hplot2, 'Color', 'b', 'Marker', '^', 'LineStyle', 'none') ;
% set(Hplot3, 'Color', 'k', 'Marker', 'o', 'LineStyle', '--')   ;
% 
 set(Hplot1, 'Color', colorPlot1, 'Marker', markerPlot1, 'LineStyle', '-')      ;
 set(Hplot2, 'Color', colorPlot2, 'Marker', markerPlot2, 'LineStyle', 'none')   ;
 set(Hplot3, 'Color', colorPlot3, 'Marker', markerPlot3, 'LineStyle', '--')     ;

string1 = 'plot 1' ;
string2 = 'plot 2' ;
string3 = 'plot 3' ;

pos = 'SouthEast' ;

Hlegend = legend(string1, string2, string3, 'Location', pos) ;
set(Hlegend, 'FontWeight', 'bold') ;
legend('boxon') ;

hold off ;

%title('Figure Legends') ;
 title(strTitle) ;

%xlabel('x') ;
 xlabel(strxlabel) ;

%ylabel('y') ;
 ylabel(strylabel) ;
 
grid on ;
