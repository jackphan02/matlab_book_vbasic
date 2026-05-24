#include "COMLinear_com.hpp"


CCOMLinear::CCOMLinear()
{
  g_pModule->InitializeComponentInstanceEx(&m_hinst);
}
CCOMLinear::~CCOMLinear()
{
  if (m_hinst)
    g_pModule->TerminateInstance(&m_hinst);
}

HRESULT __stdcall CCOMLinear::mylu(/*[in]*/long nargout, /*[in,out]*/VARIANT* L, 
                                   /*[in,out]*/VARIANT* U, /*[in,out]*/VARIANT* P, 
                                   /*[in]*/VARIANT A) {
  return( CallComFcn( "mylu", (int) nargout, 3, 1, L, U, P, &A ) );
}


HRESULT __stdcall CCOMLinear::mymldivide(/*[in]*/long nargout, /*[in,out]*/VARIANT* x, 
                                         /*[in]*/VARIANT A, /*[in]*/VARIANT b) {
  return( CallComFcn( "mymldivide", (int) nargout, 1, 2, x, &A, &b ) );
}


HRESULT __stdcall CCOMLinear::mymtimes(/*[in]*/long nargout, /*[in,out]*/VARIANT* y, 
                                       /*[in]*/VARIANT a, /*[in]*/VARIANT b) {
  return( CallComFcn( "mymtimes", (int) nargout, 1, 2, y, &a, &b ) );
}


HRESULT __stdcall CCOMLinear::mytranspose(/*[in]*/long nargout, /*[in,out]*/VARIANT* y, 
                                          /*[in]*/VARIANT x) {
  return( CallComFcn( "mytranspose", (int) nargout, 1, 1, y, &x ) );
}

HRESULT __stdcall CCOMLinear::MCRWaitForFigures()
{
  mclWaitForFiguresToDie(m_hinst);
  return(S_OK);
}
