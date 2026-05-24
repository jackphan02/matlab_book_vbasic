function varargout = mytextread(fileName, colNum, mydelimiter)

  switch colNum
    
    case 2   
    [A1, A2] = textread(fileName, '%f%f','delimiter', mydelimiter) ;
    varargout{1} = A1 ; varargout{2} = A2 ;
      
    case 3    
    [A1, A2, A3] = textread(fileName, '%f%f%f', 'delimiter', mydelimiter) ;
    varargout{1} = A1 ; varargout{2} = A2 ; varargout{3} = A3 ;
    
    case 4   
    [A1, A2, A3, A4] = textread(fileName, '%f%f%f%f', 'delimiter', mydelimiter) ;
    varargout{1} = A1 ; varargout{2} = A2 ; varargout{3} = A3 ;
    varargout{4} = A4 ;
    
    case 5   
    [A1, A2, A3, A4, A5] = textread(fileName, '%f%f%f%f%f', 'delimiter', mydelimiter) ;
    varargout{1} = A1 ; varargout{2} = A2 ; varargout{3} = A3 ;
    varargout{4} = A4 ; varargout{5} = A5 ;
        
    otherwise
        disp('This function reads files with max colums = 5.');

  end

