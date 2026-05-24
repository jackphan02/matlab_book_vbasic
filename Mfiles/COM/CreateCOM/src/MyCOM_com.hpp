#ifndef _CreateCOM_MyCOM_com_HPP
#define _CreateCOM_MyCOM_com_HPP 1

#include <windows.h>
#include "CreateCOM_idl.h"
#include "mclmcrrt.h"
#include "mclcom.h"
#include "mclcommain.h"
#include "mclcomclass.h"

class CMyCOM : public CMCLClassImpl<IMyCOM, &IID_IMyCOM, CMyCOM, &CLSID_MyCOM>
{
public:
  CMyCOM();
  ~CMyCOM();

  HRESULT __stdcall myplus(/*[in]*/long nargout, /*[in,out]*/VARIANT* y, /*[in]*/VARIANT 
                           a, /*[in]*/VARIANT b); 

  HRESULT __stdcall MCRWaitForFigures();
};
#endif
