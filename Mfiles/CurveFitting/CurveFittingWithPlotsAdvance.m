function  varargout = CurveFittingWithPlotsAdvance(x,y,cftLib, ...
                                         graTitle, xlab, ylab, ...
                       cftColor, dataColor, cftLegend, dataLengend)

%%%%%%% Curve fit data %%%%%%%%%%
[cft_data,cft_info] = fit(x,y,cftLib);
formula_a    = formula(cft_data)     ;
varargout{1} = formula_a ;

coeff_names  = coeffnames(cft_data)  ;
varargout{2} = coeff_names ;

coeff_values = coeffvalues(cft_data) ;
varargout{3} = coeff_values ;

conf_int     = confint(cft_data)     ;
varargout{4} = conf_int ;

varargout{5} = cft_info ; 
%%%%%%%%%%%%%%%%%

close all ;
cftResult = fit(x,y, cftLib);

Hcfit = plot(cftResult) ;
hold on ; % require here: after plot result

set(Hcfit,'Color',cftColor,'Marker','.','LineStyle','-') ;

Hcfit_legend = cftLegend ;

Hdata = plot(x,y) ;
set(Hdata,'Color',dataColor,'Marker','*','LineStyle','none') ;
Hdata_legend = dataLengend ;

Hlegend = legend(Hcfit_legend, Hdata_legend) ;
set(Hlegend, 'FontWeight', 'bold') ;

title(graTitle) ;
xlabel(xlab) ;
ylabel(ylab) ;


hold off ;

grid on ;