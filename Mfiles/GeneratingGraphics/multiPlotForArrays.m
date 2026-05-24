function multiPlotForArrays(t, y1, y2, y3, y4, ...
                                  strTitle, strxlabel, strylabel )

hold on ;

Hplot1 =  plot (t, y1) ; 
Hplot2 =  plot (t, y2) ; 
Hplot3 =  plot (t, y3) ; 
Hplot4 =  plot (t, y4) ; 

set(Hplot1, 'Color', 'r', 'Marker', '*', 'LineStyle', '-' )  ;
set(Hplot2, 'Color', 'b', 'Marker', '^', 'LineStyle', ':' )  ;
set(Hplot3, 'Color', 'k', 'Marker', 'o', 'LineStyle', '--')  ;
set(Hplot4, 'Color', 'g', 'Marker', 'o', 'LineStyle', '--')  ;

string1 = 'plot 1' ;
string2 = 'plot 2' ;
string3 = 'plot 3' ;
string4 = 'plot 4' ;

pos = 'SouthEast' ;

Hlegend = legend(string1, string2, string3, string4, 'Location', pos) ;
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