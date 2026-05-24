#ifndef _MATLABCOMLinear_COMLinear_com_HPP
#define _MATLABCOMLinear_COMLinear_com_HPP 1

#include <windows.h>
#include "MATLABCOMLinear_idl.h"
#include "mclmcrrt.h"
#include "mclcom.h"
#include "mclcommain.h"
#include "mclcomclass.h"

class CCOMLinear : public CMCLClassImpl<ICOMLinear, &IID_ICOMLinear, CCOMLinear, 
                                        &CLSID_COMLinear>
{
public:
  CCOMLinear();
  ~CCOMLinear();

  HRESULT __stdcall mylu(/*[in]*/long nargout, /*[in,out]*/VARIANT* L, 
                         /*[in,out]*/VARIANT* U, /*[in,out]*/VARIANT* P, /*[in]*/VARIANT 
                         A); 

  HRESULT __stdcall mymldivide(/*[in]*/long nargout, /*[in,out]*/VARIANT* x, 
                               /*[in]*/VARIANT A, /*[in]*/VARIANT b); 

  HRESULT __stdcall mymtimes(/*[in]*/long nargout, /*[in,out]*/VARIANT* y, 
                             /*[in]*/VARIANT a, /*[in]*/VARIANT b); 

  HRESULT __stdcall mytranspose(/*[in]*/long nargout, /*[in,out]*/VARIANT* y, 
                                /*[in]*/VARIANT x); 

  HRESULT __stdcall MCRWaitForFigures();
};
#endif
