//
// MATLAB Compiler: 4.11 (R2009b)
// Date: Sun Jul 25 18:28:27 2010
// Arguments: "-B" "macro_default" "-W" "com:CreateCOM,MyCOM,1.0" "-d"
// "C:\MyDocuments\Matlab\MFiles\CreateCOM\CreateCOM\src" "-T" "link:lib" "-v"
// "class{MyCOM:C:\MyDocuments\Matlab\MFiles\CreateCOM\myplus.m}" 
//

#include "mclmcrrt.h"

#ifdef __cplusplus
extern "C" {
#endif
extern const unsigned char __MCC_CreateCOM_session_key[] = {
    '1', 'D', '4', '6', 'E', 'E', '0', 'B', 'B', 'D', '1', '2', 'D', 'E', 'E',
    'D', 'A', 'C', 'C', 'F', '2', 'C', 'C', '7', '9', '3', '7', '0', '5', '3',
    'F', '2', '7', '8', '6', '6', 'D', '8', '8', '6', '2', '9', '6', '4', '5',
    '8', '8', 'B', '0', 'B', 'E', '5', 'B', '1', 'D', '7', '6', 'B', 'B', '4',
    'F', '1', '6', '5', '3', 'E', '2', 'C', 'A', 'E', '6', 'B', 'C', 'A', 'D',
    '0', 'D', 'A', 'F', 'A', '5', '0', '5', '0', 'B', 'E', '4', '2', '5', '8',
    'C', 'A', '5', '5', '1', '7', '7', 'A', 'A', '4', '6', '2', '5', '1', '4',
    '5', '0', 'B', '3', 'E', '5', 'D', '5', 'B', '6', '0', '2', 'F', '9', '8',
    'E', '3', '6', '4', '4', '3', 'A', 'F', '8', 'E', '9', '4', '1', '4', '8',
    'C', '7', '3', 'E', 'E', '0', '7', 'E', '7', 'C', 'A', 'E', '6', '0', 'C',
    '2', '8', '1', '3', '7', '1', 'F', '2', '9', 'F', '7', '9', '8', '5', '8',
    '1', '0', '6', '5', '7', '4', '8', '3', '8', 'D', '3', '6', 'C', '5', '0',
    'C', '7', '0', '0', '2', '6', 'E', '3', 'A', '1', '7', 'F', 'C', 'B', '2',
    'D', '1', 'C', '2', 'F', 'D', 'D', '2', '8', 'A', '1', 'D', '7', '5', '6',
    'C', '0', '5', '4', '8', '0', '7', 'F', 'E', 'B', 'C', '0', '5', 'C', '4',
    '1', 'D', 'E', '8', '5', 'C', '7', '7', '3', '1', 'B', 'D', '2', '5', '0',
    'A', 'F', '0', '6', '0', 'F', '5', 'D', '4', '2', 'F', '5', 'A', 'C', 'F',
    '2', '\0'};

extern const unsigned char __MCC_CreateCOM_public_key[] = {
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

static const char * MCC_CreateCOM_matlabpath_data[] = 
  { "CreateCOM/", "$TOOLBOXDEPLOYDIR/",
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

static const char * MCC_CreateCOM_classpath_data[] = 
  { "" };

static const char * MCC_CreateCOM_libpath_data[] = 
  { "" };

static const char * MCC_CreateCOM_app_opts_data[] = 
  { "" };

static const char * MCC_CreateCOM_run_opts_data[] = 
  { "" };

static const char * MCC_CreateCOM_warning_state_data[] = 
  { "off:MATLAB:dispatcher:nameConflict" };


mclComponentData __MCC_CreateCOM_component_data = { 

  /* Public key data */
  __MCC_CreateCOM_public_key,

  /* Component name */
  "CreateCOM",

  /* Component Root */
  "",

  /* Application key data */
  __MCC_CreateCOM_session_key,

  /* Component's MATLAB Path */
  MCC_CreateCOM_matlabpath_data,

  /* Number of directories in the MATLAB Path */
  40,

  /* Component's Java class path */
  MCC_CreateCOM_classpath_data,
  /* Number of directories in the Java class path */
  0,

  /* Component's load library path (for extra shared libraries) */
  MCC_CreateCOM_libpath_data,
  /* Number of directories in the load library path */
  0,

  /* MCR instance-specific runtime options */
  MCC_CreateCOM_app_opts_data,
  /* Number of MCR instance-specific runtime options */
  0,

  /* MCR global runtime options */
  MCC_CreateCOM_run_opts_data,
  /* Number of MCR global runtime options */
  0,
  
  /* Component preferences directory */
  "CreateCOM_C363F6013940503EC138F656BBDD0D11",

  /* MCR warning status data */
  MCC_CreateCOM_warning_state_data,
  /* Number of MCR warning status modifiers */
  1,

  /* Path to component - evaluated at runtime */
  NULL

};

#ifdef __cplusplus
}
#endif


