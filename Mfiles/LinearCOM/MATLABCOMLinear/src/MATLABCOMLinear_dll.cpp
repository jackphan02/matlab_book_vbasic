#include "mwcomtypes.h"
#include "mclmcrrt.h"
#include "mclcom.h"
#include "mclcommain.h"
#include "COMLinear_com.hpp"
#include "MATLABCOMLinear_idl_i.c"
#include "mwcomutil_i.c"
#include "mwcomtypes_i.c"



#ifdef __cplusplus
extern "C" {
#endif

extern mclComponentData __MCC_MATLABCOMLinear_component_data;

#ifdef __cplusplus
}
#endif


static bool _mcr_initialize_fcn(HMCRINSTANCE* inst,
                                const char* path_to_component,
                                std::istream* ctfStream, int ctfStreamSize)
{
  __MCC_MATLABCOMLinear_component_data.path_to_component = path_to_component;
  mclComponentOptions* componentOptions = mclCreateComponentOptions(true, false, "", 
                                                                    ctfStream, 
                                                                    ctfStreamSize);
  bool bResult = mclInitializeComponentInstanceEx(inst, 
                                                  &__MCC_MATLABCOMLinear_component_data, 
                                                  componentOptions, true, COMObject, 
                                                  LibTarget, NULL, NULL);
  mclDestroyComponentOptions(componentOptions);
  return bResult;
}
static bool _mcr_terminate_fcn(HMCRINSTANCE* inst)
{
  return mclTerminateInstance(inst);
}
static CMCLModule g_Module(_mcr_initialize_fcn, _mcr_terminate_fcn, true);
CMCLModule* g_pModule = &g_Module;

static _MCLOBJECT_MAP_ENTRY objectmap[] = 
{
  {
      &CLSID_COMLinear, CCOMLinear::RegisterClass, CCOMLinear::UnregisterClass, 
    CCOMLinear::GetClassObject, "COMLinear", "MATLABCOMLinear.COMLinear", 
    "MATLABCOMLinear.COMLinear.1_0"
  },
  {
    NULL, NULL, NULL, NULL, "", "", ""
  }
};

extern "C" { 

BOOL WINAPI DllMain( HINSTANCE hInstance, DWORD dwReason, void *pv )
{
  return g_pModule->InitMain(objectmap, &LIBID_MATLABCOMLinear, 1, 0, hInstance, 
                             dwReason, pv);
}

HRESULT __stdcall DllCanUnloadNow()
{
  return (g_pModule->GetLockCount()==0) ? S_OK : S_FALSE;
}

HRESULT __stdcall DllGetClassObject(REFCLSID clsid, REFIID iid, void **ppv )
{
  return g_pModule->GetClassObject( clsid, iid, ppv );
}

HRESULT __stdcall DllRegisterServer()
{
  return g_pModule->UpdateRegistry( TRUE );
}

HRESULT __stdcall DllUnregisterServer()
{
  return g_pModule->UpdateRegistry( FALSE );
}

}
