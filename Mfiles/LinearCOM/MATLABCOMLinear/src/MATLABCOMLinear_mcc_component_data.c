//
// MATLAB Compiler: 4.11 (R2009b)
// Date: Sun Aug 22 21:42:09 2010
// Arguments: "-B" "macro_default" "-W" "com:MATLABCOMLinear,COMLinear,1.0"
// "-d" "C:\MatlabVB\Mfiles\LinearCOM\MATLABCOMLinear\src" "-T" "link:lib" "-v"
// "class{COMLinear:C:\MatlabVB\Mfiles\LinearCOM\mylu.m,C:\MatlabVB\Mfiles\Linea
// rCOM\mymldivide.m,C:\MatlabVB\Mfiles\LinearCOM\mymtimes.m,C:\MatlabVB\Mfiles\
// LinearCOM\mytranspose.m}" 
//

#include "mclmcrrt.h"

#ifdef __cplusplus
extern "C" {
#endif
extern const unsigned char __MCC_MATLABCOMLinear_session_key[] = {
    '2', '0', '0', '9', '1', '2', '3', '0', '8', '0', '4', '5', 'B', '9', 'F',
    '4', '5', '8', '3', '2', 'F', '4', 'D', '5', '6', 'B', '9', '9', 'D', '0',
    '2', '2', 'A', 'C', 'C', '3', 'F', '6', '9', '8', 'A', '2', '0', 'B', '3',
    '4', '3', '7', '5', 'B', '7', 'B', '0', '5', '8', '0', '9', '5', 'A', '6',
    'A', 'D', '5', '2', 'E', 'B', '3', '4', '0', '9', '8', 'F', 'B', 'A', 'B',
    '4', 'F', '4', '6', '1', '6', '3', '0', 'E', 'F', '4', 'E', '7', 'C', 'F',
    'A', '3', '2', '4', '0', '9', 'A', '0', '1', 'F', 'F', 'F', 'C', 'D', '6',
    '9', '6', 'F', 'E', '0', '6', 'D', 'F', 'E', '2', '4', '8', 'A', '8', '3',
    'E', '4', '7', '3', 'C', 'A', '1', '6', '4', '2', '2', '1', 'E', 'B', 'D',
    '3', 'C', '4', '7', '4', 'F', '4', 'F', 'C', '2', '1', 'D', '3', 'E', '0',
    'B', '5', 'D', 'E', '4', 'D', '2', '3', 'F', '0', '9', '1', 'C', 'D', '1',
    '6', '4', '5', '9', 'C', 'A', 'E', '5', 'A', 'C', '1', '3', 'A', '2', 'D',
    '0', '9', '9', 'C', '6', '5', 'A', '0', '7', 'C', 'F', '3', 'B', 'B', 'E',
    '1', 'D', '3', '3', '9', 'A', 'C', 'B', '0', '4', 'E', '6', '0', '8', 'A',
    'D', '3', '8', 'F', '4', 'A', '3', '8', '5', '5', 'D', 'C', '1', '8', '0',
    'F', '7', '7', 'E', 'B', '5', '7', '2', '1', '9', '3', '1', '7', 'D', '6',
    '3', 'A', '9', 'A', '4', '1', 'C', 'B', 'F', 'A', '6', '2', 'E', '2', '1',
    '5', '\0'};

extern const unsigned char __MCC_MATLABCOMLinear_public_key[] = {
    '3', '0', '8', '1', '9', 'D', '3', '0', '0', 'D', '0', '6', '0', '9', '2',
    'A', '8', '6', '4', '8', '8', '6', 'F', '7', '0', 'D', '0', '1', '0', '1',
    '0', '1', '0', '5', '0', '0', '0', '3', '8', '1', '8', 'B', '0', '0', '3',
    '0', '8', '1', '8', '7', '0', '2', '8', '1', '8', '1', '0', '0', 'C', '4',
    '9', 'C', 'A', 'C', '3', '4', 'E', 'D', '1', '3', 'A', '5', '2', '0', '6',
    '5', '8', 'F', '6', 'F', '8', 'E', '0', '1', '3', '8', 'C', '4', '3', '1',
    '5', 'B', '4', '3', '1', '5', '2', '7', '7', 'E', 'D', '3', 'F', '7', 'D',
    'A', 'E', '5', '3', '0', '9', '9', 'D', 'B', '0', '8', 'E', 'E', '5', '8',
    '9', 'F', '8', '0', '4', 'D', '4', 'B', '9', '8', '1', '3', '2', '6', 'A',
    '5', '2', 'C', 'C', 'E', '4', '3', '8', '2', 'E', '9', 'F', '2', 'B', '4',
    'D', '0', '8', '5', 'E', 'B', '9', '5', '0', 'C', '7', 'A', 'B', '1', '2',
    'E', 'D', 'E', '2', 'D', '4', '1', '2', '9', '7', '8', '2', '0', 'E', '6',
    '3', '7', '7', 'A', '5', 'F', 'E', 'B', '5', '6', '8', '9', 'D', '4', 'E',
    '6', '0', '3', '2', 'F', '6', '0', 'C', '4', '3', '0', '7', '4', 'A', '0',
    '4', 'C', '2', '6', 'A', 'B', '7', '2', 'F', '5', '4', 'B', '5', '1', 'B',
    'B', '4', '6', '0', '5', '7', '8', '7', '8', '5', 'B', '1', '9', '9', '0',
    '1', '4', '3', '1', '4', 'A', '6', '5', 'F', '0', '9', '0', 'B', '6', '1',
    'F', 'C', '2', '0', '1', '6', '9', '4', '5', '3', 'B', '5', '8', 'F', 'C',
    '8', 'B', 'A', '4', '3', 'E', '6', '7', '7', '6', 'E', 'B', '7', 'E', 'C',
    'D', '3', '1', '7', '8', 'B', '5', '6', 'A', 'B', '0', 'F', 'A', '0', '6',
    'D', 'D', '6', '4', '9', '6', '7', 'C', 'B', '1', '4', '9', 'E', '5', '0',
    '2', '0', '1', '1', '1', '\0'};

static const char * MCC_MATLABCOMLinear_matlabpath_data[] = 
  { "MATLABCOMLin/", "$TOOLBOXDEPLOYDIR/", "MatlabVB/Mfiles/LinearCOM/",
    "$TOOLBOXMATLABDIR/general/", "$TOOLBOXMATLABDIR/ops/",
    "$TOOLBOXMATLABDIR/lang/", "$TOOLBOXMATLABDIR/elmat/",
    "$TOOLBOXMATLABDIR/randfun/", "$TOOLBOXMATLABDIR/elfun/",
    "$TOOLBOXMATLABDIR/specfun/", "$TOOLBOXMATLABDIR/matfun/",
    "$TOOLBOXMATLABDIR/datafun/", "$TOOLBOXMATLABDIR/polyfun/",
    "$TOOLBOXMATLABDIR/funfun/", "$TOOLBOXMATLABDIR/sparfun/",
    "$TOOLBOXMATLABDIR/scribe/", "$TOOLBOXMATLABDIR/graph2d/",
    "$TOOLBOXMATLABDIR/graph3d/", "$TOOLBOXMATLABDIR/specgraph/",
    "$TOOLBOXMATLABDIR/graphics/", "$TOOLBOXMATLABDIR/uitools/",
    "$TOOLBOXMATLABDIR/strfun/", "$TOOLBOXMATLABDIR/imagesci/",
    "$TOOLBOXMATLABDIR/iofun/", "$TOOLBOXMATLABDIR/audiovideo/",
    "$TOOLBOXMATLABDIR/timefun/", "$TOOLBOXMATLABDIR/datatypes/",
    "$TOOLBOXMATLABDIR/verctrl/", "$TOOLBOXMATLABDIR/codetools/",
    "$TOOLBOXMATLABDIR/helptools/", "$TOOLBOXMATLABDIR/winfun/",
    "$TOOLBOXMATLABDIR/winfun/NET/", "$TOOLBOXMATLABDIR/demos/",
    "$TOOLBOXMATLABDIR/timeseries/", "$TOOLBOXMATLABDIR/hds/",
    "$TOOLBOXMATLABDIR/guide/", "$TOOLBOXMATLABDIR/plottools/",
    "toolbox/local/", "toolbox/shared/dastudio/",
    "$TOOLBOXMATLABDIR/datamanager/", "toolbox/compiler/" };

static const char * MCC_MATLABCOMLinear_classpath_data[] = 
  { "" };

static const char * MCC_MATLABCOMLinear_libpath_data[] = 
  { "" };

static const char * MCC_MATLABCOMLinear_app_opts_data[] = 
  { "" };

static const char * MCC_MATLABCOMLinear_run_opts_data[] = 
  { "" };

static const char * MCC_MATLABCOMLinear_warning_state_data[] = 
  { "off:MATLAB:dispatcher:nameConflict" };


mclComponentData __MCC_MATLABCOMLinear_component_data = { 

  /* Public key data */
  __MCC_MATLABCOMLinear_public_key,

  /* Component name */
  "MATLABCOMLinear",

  /* Component Root */
  "",

  /* Application key data */
  __MCC_MATLABCOMLinear_session_key,

  /* Component's MATLAB Path */
  MCC_MATLABCOMLinear_matlabpath_data,

  /* Number of directories in the MATLAB Path */
  41,

  /* Component's Java class path */
  MCC_MATLABCOMLinear_classpath_data,
  /* Number of directories in the Java class path */
  0,

  /* Component's load library path (for extra shared libraries) */
  MCC_MATLABCOMLinear_libpath_data,
  /* Number of directories in the load library path */
  0,

  /* MCR instance-specific runtime options */
  MCC_MATLABCOMLinear_app_opts_data,
  /* Number of MCR instance-specific runtime options */
  0,

  /* MCR global runtime options */
  MCC_MATLABCOMLinear_run_opts_data,
  /* Number of MCR global runtime options */
  0,
  
  /* Component preferences directory */
  "MATLABCOMLin_F817775B0030FF2AE5C54339A5739CB1",

  /* MCR warning status data */
  MCC_MATLABCOMLinear_warning_state_data,
  /* Number of MCR warning status modifiers */
  1,

  /* Path to component - evaluated at runtime */
  NULL

};

#ifdef __cplusplus
}
#endif


