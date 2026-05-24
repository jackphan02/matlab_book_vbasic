function varargout = CurveFittings(x,y,cftLib)

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