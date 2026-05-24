#include "MyCOM_com.hpp"


CMyCOM::CMyCOM()
{
  g_pModule->InitializeComponentInstanceEx(&m_hinst);
}
CMyCOM::~CMyCOM()
{
  if (m_hinst)
    g_pModule->TerminateInstance(&m_hinst);
}

HRESULT __stdcall CMyCOM::myplus(/*[in]*/long nargout, /*[in,out]*/VARIANT* y, 
                                 /*[in]*/VARIANT a, /*[in]*/VARIANT b) {
  return( CallComFcn( "myplus", (int) nargout, 1, 2, y, &a, &b ) );
}

HRESULT __stdcall CMyCOM::MCRWaitForFigures()
{
  mclWaitForFiguresToDie(m_hinst);
  return(S_OK);
}
