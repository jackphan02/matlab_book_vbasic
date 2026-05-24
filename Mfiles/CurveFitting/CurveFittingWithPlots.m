function  varargout = CurveFittingWithPlots(x,y,cftLib)

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

set(Hcfit,'Color','red','Marker','.','LineStyle','-') ;

Hcfit_legend = 'Fitting curve';

Hdata = plot(x,y) ;
set(Hdata, 'Color', 'blue','Marker','*','LineStyle','none') ;
Hdata_legend = 'data' ;

Hlegend = legend(Hcfit_legend, Hdata_legend) ;
set(Hlegend, 'FontWeight', 'bold') ;

hold off ;

grid on ;