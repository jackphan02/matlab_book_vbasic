

/* this ALWAYS GENERATED file contains the definitions for the interfaces */


 /* File created by MIDL compiler version 7.00.0500 */
/* at Sun Aug 22 21:42:22 2010
 */
/* Compiler settings for C:\MatlabVB\Mfiles\LinearCOM\MATLABCOMLinear\src\MATLABCOMLinear_idl.idl:
    Oicf, W1, Zp8, env=Win32 (32b run)
    protocol : dce , ms_ext, c_ext, robust
    error checks: allocation ref bounds_check enum stub_data 
    VC __declspec() decoration level: 
         __declspec(uuid()), __declspec(selectany), __declspec(novtable)
         DECLSPEC_UUID(), MIDL_INTERFACE()
*/
//@@MIDL_FILE_HEADING(  )

#pragma warning( disable: 4049 )  /* more than 64k source lines */


/* verify that the <rpcndr.h> version is high enough to compile this file*/
#ifndef __REQUIRED_RPCNDR_H_VERSION__
#define __REQUIRED_RPCNDR_H_VERSION__ 475
#endif

#include "rpc.h"
#include "rpcndr.h"

#ifndef __RPCNDR_H_VERSION__
#error this stub requires an updated version of <rpcndr.h>
#endif // __RPCNDR_H_VERSION__

#ifndef COM_NO_WINDOWS_H
#include "windows.h"
#include "ole2.h"
#endif /*COM_NO_WINDOWS_H*/

#ifndef __MATLABCOMLinear_idl_h__
#define __MATLABCOMLinear_idl_h__

#if defined(_MSC_VER) && (_MSC_VER >= 1020)
#pragma once
#endif

/* Forward Declarations */ 

#ifndef __ICOMLinear_FWD_DEFINED__
#define __ICOMLinear_FWD_DEFINED__
typedef interface ICOMLinear ICOMLinear;
#endif 	/* __ICOMLinear_FWD_DEFINED__ */


#ifndef __COMLinear_FWD_DEFINED__
#define __COMLinear_FWD_DEFINED__

#ifdef __cplusplus
typedef class COMLinear COMLinear;
#else
typedef struct COMLinear COMLinear;
#endif /* __cplusplus */

#endif 	/* __COMLinear_FWD_DEFINED__ */


/* header files for imported files */
#include "oaidl.h"
#include "ocidl.h"
#include "mwcomtypes.h"

#ifdef __cplusplus
extern "C"{
#endif 


#ifndef __ICOMLinear_INTERFACE_DEFINED__
#define __ICOMLinear_INTERFACE_DEFINED__

/* interface ICOMLinear */
/* [unique][helpstring][dual][uuid][object] */ 


EXTERN_C const IID IID_ICOMLinear;

#if defined(__cplusplus) && !defined(CINTERFACE)
    
    MIDL_INTERFACE("C0BB0E78-926D-4BFC-8FD9-00E1FA8E8787")
    ICOMLinear : public IDispatch
    {
    public:
        virtual /* [helpstring][id][propget] */ HRESULT STDMETHODCALLTYPE get_MWFlags( 
            /* [retval][out] */ IMWFlags **ppvFlags) = 0;
        
        virtual /* [helpstring][id][propput] */ HRESULT STDMETHODCALLTYPE put_MWFlags( 
            /* [in] */ IMWFlags *pvFlags) = 0;
        
        virtual /* [helpstring][id] */ HRESULT STDMETHODCALLTYPE mylu( 
            /* [in] */ long nargout,
            /* [out][in] */ VARIANT *L,
            /* [out][in] */ VARIANT *U,
            /* [out][in] */ VARIANT *P,
            /* [in] */ VARIANT A) = 0;
        
        virtual /* [helpstring][id] */ HRESULT STDMETHODCALLTYPE mymldivide( 
            /* [in] */ long nargout,
            /* [out][in] */ VARIANT *x,
            /* [in] */ VARIANT A,
            /* [in] */ VARIANT b) = 0;
        
        virtual /* [helpstring][id] */ HRESULT STDMETHODCALLTYPE mymtimes( 
            /* [in] */ long nargout,
            /* [out][in] */ VARIANT *y,
            /* [in] */ VARIANT a,
            /* [in] */ VARIANT b) = 0;
        
        virtual /* [helpstring][id] */ HRESULT STDMETHODCALLTYPE mytranspose( 
            /* [in] */ long nargout,
            /* [out][in] */ VARIANT *y,
            /* [in] */ VARIANT x) = 0;
        
        virtual /* [helpstring][id] */ HRESULT STDMETHODCALLTYPE MCRWaitForFigures( void) = 0;
        
    };
    
#else 	/* C style interface */

    typedef struct ICOMLinearVtbl
    {
        BEGIN_INTERFACE
        
        HRESULT ( STDMETHODCALLTYPE *QueryInterface )( 
            ICOMLinear * This,
            /* [in] */ REFIID riid,
            /* [iid_is][out] */ 
            __RPC__deref_out  void **ppvObject);
        
        ULONG ( STDMETHODCALLTYPE *AddRef )( 
            ICOMLinear * This);
        
        ULONG ( STDMETHODCALLTYPE *Release )( 
            ICOMLinear * This);
        
        HRESULT ( STDMETHODCALLTYPE *GetTypeInfoCount )( 
            ICOMLinear * This,
            /* [out] */ UINT *pctinfo);
        
        HRESULT ( STDMETHODCALLTYPE *GetTypeInfo )( 
            ICOMLinear * This,
            /* [in] */ UINT iTInfo,
            /* [in] */ LCID lcid,
            /* [out] */ ITypeInfo **ppTInfo);
        
        HRESULT ( STDMETHODCALLTYPE *GetIDsOfNames )( 
            ICOMLinear * This,
            /* [in] */ REFIID riid,
            /* [size_is][in] */ LPOLESTR *rgszNames,
            /* [range][in] */ UINT cNames,
            /* [in] */ LCID lcid,
            /* [size_is][out] */ DISPID *rgDispId);
        
        /* [local] */ HRESULT ( STDMETHODCALLTYPE *Invoke )( 
            ICOMLinear * This,
            /* [in] */ DISPID dispIdMember,
            /* [in] */ REFIID riid,
            /* [in] */ LCID lcid,
            /* [in] */ WORD wFlags,
            /* [out][in] */ DISPPARAMS *pDispParams,
            /* [out] */ VARIANT *pVarResult,
            /* [out] */ EXCEPINFO *pExcepInfo,
            /* [out] */ UINT *puArgErr);
        
        /* [helpstring][id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_MWFlags )( 
            ICOMLinear * This,
            /* [retval][out] */ IMWFlags **ppvFlags);
        
        /* [helpstring][id][propput] */ HRESULT ( STDMETHODCALLTYPE *put_MWFlags )( 
            ICOMLinear * This,
            /* [in] */ IMWFlags *pvFlags);
        
        /* [helpstring][id] */ HRESULT ( STDMETHODCALLTYPE *mylu )( 
            ICOMLinear * This,
            /* [in] */ long nargout,
            /* [out][in] */ VARIANT *L,
            /* [out][in] */ VARIANT *U,
            /* [out][in] */ VARIANT *P,
            /* [in] */ VARIANT A);
        
        /* [helpstring][id] */ HRESULT ( STDMETHODCALLTYPE *mymldivide )( 
            ICOMLinear * This,
            /* [in] */ long nargout,
            /* [out][in] */ VARIANT *x,
            /* [in] */ VARIANT A,
            /* [in] */ VARIANT b);
        
        /* [helpstring][id] */ HRESULT ( STDMETHODCALLTYPE *mymtimes )( 
            ICOMLinear * This,
            /* [in] */ long nargout,
            /* [out][in] */ VARIANT *y,
            /* [in] */ VARIANT a,
            /* [in] */ VARIANT b);
        
        /* [helpstring][id] */ HRESULT ( STDMETHODCALLTYPE *mytranspose )( 
            ICOMLinear * This,
            /* [in] */ long nargout,
            /* [out][in] */ VARIANT *y,
            /* [in] */ VARIANT x);
        
        /* [helpstring][id] */ HRESULT ( STDMETHODCALLTYPE *MCRWaitForFigures )( 
            ICOMLinear * This);
        
        END_INTERFACE
    } ICOMLinearVtbl;

    interface ICOMLinear
    {
        CONST_VTBL struct ICOMLinearVtbl *lpVtbl;
    };

    

#ifdef COBJMACROS


#define ICOMLinear_QueryInterface(This,riid,ppvObject)	\
    ( (This)->lpVtbl -> QueryInterface(This,riid,ppvObject) ) 

#define ICOMLinear_AddRef(This)	\
    ( (This)->lpVtbl -> AddRef(This) ) 

#define ICOMLinear_Release(This)	\
    ( (This)->lpVtbl -> Release(This) ) 


#define ICOMLinear_GetTypeInfoCount(This,pctinfo)	\
    ( (This)->lpVtbl -> GetTypeInfoCount(This,pctinfo) ) 

#define ICOMLinear_GetTypeInfo(This,iTInfo,lcid,ppTInfo)	\
    ( (This)->lpVtbl -> GetTypeInfo(This,iTInfo,lcid,ppTInfo) ) 

#define ICOMLinear_GetIDsOfNames(This,riid,rgszNames,cNames,lcid,rgDispId)	\
    ( (This)->lpVtbl -> GetIDsOfNames(This,riid,rgszNames,cNames,lcid,rgDispId) ) 

#define ICOMLinear_Invoke(This,dispIdMember,riid,lcid,wFlags,pDispParams,pVarResult,pExcepInfo,puArgErr)	\
    ( (This)->lpVtbl -> Invoke(This,dispIdMember,riid,lcid,wFlags,pDispParams,pVarResult,pExcepInfo,puArgErr) ) 


#define ICOMLinear_get_MWFlags(This,ppvFlags)	\
    ( (This)->lpVtbl -> get_MWFlags(This,ppvFlags) ) 

#define ICOMLinear_put_MWFlags(This,pvFlags)	\
    ( (This)->lpVtbl -> put_MWFlags(This,pvFlags) ) 

#define ICOMLinear_mylu(This,nargout,L,U,P,A)	\
    ( (This)->lpVtbl -> mylu(This,nargout,L,U,P,A) ) 

#define ICOMLinear_mymldivide(This,nargout,x,A,b)	\
    ( (This)->lpVtbl -> mymldivide(This,nargout,x,A,b) ) 

#define ICOMLinear_mymtimes(This,nargout,y,a,b)	\
    ( (This)->lpVtbl -> mymtimes(This,nargout,y,a,b) ) 

#define ICOMLinear_mytranspose(This,nargout,y,x)	\
    ( (This)->lpVtbl -> mytranspose(This,nargout,y,x) ) 

#define ICOMLinear_MCRWaitForFigures(This)	\
    ( (This)->lpVtbl -> MCRWaitForFigures(This) ) 

#endif /* COBJMACROS */


#endif 	/* C style interface */




#endif 	/* __ICOMLinear_INTERFACE_DEFINED__ */



#ifndef __MATLABCOMLinear_LIBRARY_DEFINED__
#define __MATLABCOMLinear_LIBRARY_DEFINED__

/* library MATLABCOMLinear */
/* [helpstring][version][uuid] */ 


EXTERN_C const IID LIBID_MATLABCOMLinear;

EXTERN_C const CLSID CLSID_COMLinear;

#ifdef __cplusplus

class DECLSPEC_UUID("7F580A67-2E3F-471A-99B5-05BE15181305")
COMLinear;
#endif
#endif /* __MATLABCOMLinear_LIBRARY_DEFINED__ */

/* Additional Prototypes for ALL interfaces */

unsigned long             __RPC_USER  VARIANT_UserSize(     unsigned long *, unsigned long            , VARIANT * ); 
unsigned char * __RPC_USER  VARIANT_UserMarshal(  unsigned long *, unsigned char *, VARIANT * ); 
unsigned char * __RPC_USER  VARIANT_UserUnmarshal(unsigned long *, unsigned char *, VARIANT * ); 
void                      __RPC_USER  VARIANT_UserFree(     unsigned long *, VARIANT * ); 

/* end of Additional Prototypes */

#ifdef __cplusplus
}
#endif

#endif


