/*
* MATLAB Compiler: 4.11 (R2009b)
* Date: Sat Aug 14 22:00:13 2010
* Arguments: "-B" "macro_default" "-W"
* "dotnet:PolyInterpolationNameSpace,PolyInterpolation,0.0,private" "-d"
* "C:\MatlabVB\Mfiles\PolyInterpolation\PolyInterpolationNameSpace\src" "-T" "link:lib"
* "-v"
* "class{PolyInterpolation:C:\MatlabVB\Mfiles\PolyInterpolation\Interp2InNonGrid.m,C:\Matl
* abVB\Mfiles\PolyInterpolation\myfinemeshgrid.m,C:\MatlabVB\Mfiles\PolyInterpolation\mygr
* iddata.m,C:\MatlabVB\Mfiles\PolyInterpolation\myinterp1.m,C:\MatlabVB\Mfiles\PolyInterpo
* lation\myinterp2.m,C:\MatlabVB\Mfiles\PolyInterpolation\mymeshgrid.m,C:\MatlabVB\Mfiles\
* PolyInterpolation\mypolyfit.m,C:\MatlabVB\Mfiles\PolyInterpolation\mypolyval.m}" 
*/
using System;
using System.Reflection;
using System.IO;
using MathWorks.MATLAB.NET.Arrays;
using MathWorks.MATLAB.NET.Utility;
using MathWorks.MATLAB.NET.ComponentData;

#if SHARED
[assembly: System.Reflection.AssemblyKeyFile(@"")]
#endif

namespace PolyInterpolationNameSpaceNative
{
  /// <summary>
  /// The PolyInterpolation class provides a CLS compliant, Object (native) interface to
  /// the M-functions contained in the files:
  /// <newpara></newpara>
  /// C:\MatlabVB\Mfiles\PolyInterpolation\Interp2InNonGrid.m
  /// <newpara></newpara>
  /// C:\MatlabVB\Mfiles\PolyInterpolation\myfinemeshgrid.m
  /// <newpara></newpara>
  /// C:\MatlabVB\Mfiles\PolyInterpolation\mygriddata.m
  /// <newpara></newpara>
  /// C:\MatlabVB\Mfiles\PolyInterpolation\myinterp1.m
  /// <newpara></newpara>
  /// C:\MatlabVB\Mfiles\PolyInterpolation\myinterp2.m
  /// <newpara></newpara>
  /// C:\MatlabVB\Mfiles\PolyInterpolation\mymeshgrid.m
  /// <newpara></newpara>
  /// C:\MatlabVB\Mfiles\PolyInterpolation\mypolyfit.m
  /// <newpara></newpara>
  /// C:\MatlabVB\Mfiles\PolyInterpolation\mypolyval.m
  /// <newpara></newpara>
  /// deployprint.m
  /// <newpara></newpara>
  /// printdlg.m
  /// </summary>
  /// <remarks>
  /// @Version 0.0
  /// </remarks>
  public class PolyInterpolation : IDisposable
  {
    #region Constructors

    /// <summary internal= "true">
    /// The static constructor instantiates and initializes the MATLAB Component Runtime
    /// instance.
    /// </summary>
    static PolyInterpolation()
    {
      if (MWMCR.MCRAppInitialized)
      {
        Assembly assembly= Assembly.GetExecutingAssembly();

        string ctfFilePath= assembly.Location;

        int lastDelimiter= ctfFilePath.LastIndexOf(@"\");

        ctfFilePath= ctfFilePath.Remove(lastDelimiter, (ctfFilePath.Length - lastDelimiter));

        string ctfFileName = MCRComponentState.MCC_PolyInterpolationNameSpace_name_data + ".ctf";

        Stream embeddedCtfStream = null;

        String[] resourceStrings = assembly.GetManifestResourceNames();

        foreach (String name in resourceStrings)
        {
          if (name.Contains(ctfFileName))
          {
            embeddedCtfStream = assembly.GetManifestResourceStream(name);
            break;
          }
        }
        mcr= new MWMCR(MCRComponentState.MCC_PolyInterpolationNameSpace_name_data,
                       MCRComponentState.MCC_PolyInterpolationNameSpace_root_data,
                       MCRComponentState.MCC_PolyInterpolationNameSpace_public_data,
                       MCRComponentState.MCC_PolyInterpolationNameSpace_session_data,
                       MCRComponentState.MCC_PolyInterpolationNameSpace_matlabpath_data,
                       MCRComponentState.MCC_PolyInterpolationNameSpace_classpath_data,
                       MCRComponentState.MCC_PolyInterpolationNameSpace_libpath_data,
                       MCRComponentState.MCC_PolyInterpolationNameSpace_mcr_application_options,
                       MCRComponentState.MCC_PolyInterpolationNameSpace_mcr_runtime_options,
                       MCRComponentState.MCC_PolyInterpolationNameSpace_mcr_pref_dir,
                       MCRComponentState.MCC_PolyInterpolationNameSpace_set_warning_state,
                       ctfFilePath, embeddedCtfStream, true);
      }
      else
      {
        throw new ApplicationException("MWArray assembly could not be initialized");
      }
    }


    /// <summary>
    /// Constructs a new instance of the PolyInterpolation class.
    /// </summary>
    public PolyInterpolation()
    {
    }


    #endregion Constructors

    #region Finalize

    /// <summary internal= "true">
    /// Class destructor called by the CLR garbage collector.
    /// </summary>
    ~PolyInterpolation()
    {
      Dispose(false);
    }


    /// <summary>
    /// Frees the native resources associated with this object
    /// </summary>
    public void Dispose()
    {
      Dispose(true);

      GC.SuppressFinalize(this);
    }


    /// <summary internal= "true">
    /// Internal dispose function
    /// </summary>
    protected virtual void Dispose(bool disposing)
    {
      if (!disposed)
      {
        disposed= true;

        if (disposing)
        {
          // Free managed resources;
        }

        // Free native resources
      }
    }


    #endregion Finalize

    #region Methods

    /// <summary>
    /// Provides a single output, 0-input Objectinterface to the Interp2InNonGrid
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// step 1
    /// </remarks>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object Interp2InNonGrid()
    {
      return mcr.EvaluateFunction("Interp2InNonGrid", new Object[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input Objectinterface to the Interp2InNonGrid
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// step 1
    /// </remarks>
    /// <param name="a">Input argument #1</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object Interp2InNonGrid(Object a)
    {
      return mcr.EvaluateFunction("Interp2InNonGrid", a);
    }


    /// <summary>
    /// Provides a single output, 2-input Objectinterface to the Interp2InNonGrid
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// step 1
    /// </remarks>
    /// <param name="a">Input argument #1</param>
    /// <param name="b">Input argument #2</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object Interp2InNonGrid(Object a, Object b)
    {
      return mcr.EvaluateFunction("Interp2InNonGrid", a, b);
    }


    /// <summary>
    /// Provides the standard 0-input Object interface to the Interp2InNonGrid
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// step 1
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] Interp2InNonGrid(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "Interp2InNonGrid", new Object[]{});
    }


    /// <summary>
    /// Provides the standard 1-input Object interface to the Interp2InNonGrid
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// step 1
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="a">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] Interp2InNonGrid(int numArgsOut, Object a)
    {
      return mcr.EvaluateFunction(numArgsOut, "Interp2InNonGrid", a);
    }


    /// <summary>
    /// Provides the standard 2-input Object interface to the Interp2InNonGrid
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// step 1
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="a">Input argument #1</param>
    /// <param name="b">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] Interp2InNonGrid(int numArgsOut, Object a, Object b)
    {
      return mcr.EvaluateFunction(numArgsOut, "Interp2InNonGrid", a, b);
    }


    /// <summary>
    /// Provides a single output, 0-input Objectinterface to the myfinemeshgrid
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Using two colons to create a vector with increments between
    /// first and end elements.
    /// </remarks>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object myfinemeshgrid()
    {
      return mcr.EvaluateFunction("myfinemeshgrid", new Object[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input Objectinterface to the myfinemeshgrid
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Using two colons to create a vector with increments between
    /// first and end elements.
    /// </remarks>
    /// <param name="vectorstepx">Input argument #1</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object myfinemeshgrid(Object vectorstepx)
    {
      return mcr.EvaluateFunction("myfinemeshgrid", vectorstepx);
    }


    /// <summary>
    /// Provides a single output, 2-input Objectinterface to the myfinemeshgrid
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Using two colons to create a vector with increments between
    /// first and end elements.
    /// </remarks>
    /// <param name="vectorstepx">Input argument #1</param>
    /// <param name="vectorstepy">Input argument #2</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object myfinemeshgrid(Object vectorstepx, Object vectorstepy)
    {
      return mcr.EvaluateFunction("myfinemeshgrid", vectorstepx, vectorstepy);
    }


    /// <summary>
    /// Provides the standard 0-input Object interface to the myfinemeshgrid M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Using two colons to create a vector with increments between
    /// first and end elements.
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] myfinemeshgrid(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "myfinemeshgrid", new Object[]{});
    }


    /// <summary>
    /// Provides the standard 1-input Object interface to the myfinemeshgrid M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Using two colons to create a vector with increments between
    /// first and end elements.
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="vectorstepx">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] myfinemeshgrid(int numArgsOut, Object vectorstepx)
    {
      return mcr.EvaluateFunction(numArgsOut, "myfinemeshgrid", vectorstepx);
    }


    /// <summary>
    /// Provides the standard 2-input Object interface to the myfinemeshgrid M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Using two colons to create a vector with increments between
    /// first and end elements.
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="vectorstepx">Input argument #1</param>
    /// <param name="vectorstepy">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] myfinemeshgrid(int numArgsOut, Object vectorstepx, Object vectorstepy)
    {
      return mcr.EvaluateFunction(numArgsOut, "myfinemeshgrid", vectorstepx, vectorstepy);
    }


    /// <summary>
    /// Provides a single output, 0-input Objectinterface to the mygriddata M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object mygriddata()
    {
      return mcr.EvaluateFunction("mygriddata", new Object[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input Objectinterface to the mygriddata M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="x">Input argument #1</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object mygriddata(Object x)
    {
      return mcr.EvaluateFunction("mygriddata", x);
    }


    /// <summary>
    /// Provides a single output, 2-input Objectinterface to the mygriddata M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="x">Input argument #1</param>
    /// <param name="y">Input argument #2</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object mygriddata(Object x, Object y)
    {
      return mcr.EvaluateFunction("mygriddata", x, y);
    }


    /// <summary>
    /// Provides a single output, 3-input Objectinterface to the mygriddata M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="x">Input argument #1</param>
    /// <param name="y">Input argument #2</param>
    /// <param name="z">Input argument #3</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object mygriddata(Object x, Object y, Object z)
    {
      return mcr.EvaluateFunction("mygriddata", x, y, z);
    }


    /// <summary>
    /// Provides a single output, 4-input Objectinterface to the mygriddata M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="x">Input argument #1</param>
    /// <param name="y">Input argument #2</param>
    /// <param name="z">Input argument #3</param>
    /// <param name="XI">Input argument #4</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object mygriddata(Object x, Object y, Object z, Object XI)
    {
      return mcr.EvaluateFunction("mygriddata", x, y, z, XI);
    }


    /// <summary>
    /// Provides a single output, 5-input Objectinterface to the mygriddata M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="x">Input argument #1</param>
    /// <param name="y">Input argument #2</param>
    /// <param name="z">Input argument #3</param>
    /// <param name="XI">Input argument #4</param>
    /// <param name="YI">Input argument #5</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object mygriddata(Object x, Object y, Object z, Object XI, Object YI)
    {
      return mcr.EvaluateFunction("mygriddata", x, y, z, XI, YI);
    }


    /// <summary>
    /// Provides the standard 0-input Object interface to the mygriddata M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] mygriddata(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "mygriddata", new Object[]{});
    }


    /// <summary>
    /// Provides the standard 1-input Object interface to the mygriddata M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="x">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] mygriddata(int numArgsOut, Object x)
    {
      return mcr.EvaluateFunction(numArgsOut, "mygriddata", x);
    }


    /// <summary>
    /// Provides the standard 2-input Object interface to the mygriddata M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="x">Input argument #1</param>
    /// <param name="y">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] mygriddata(int numArgsOut, Object x, Object y)
    {
      return mcr.EvaluateFunction(numArgsOut, "mygriddata", x, y);
    }


    /// <summary>
    /// Provides the standard 3-input Object interface to the mygriddata M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="x">Input argument #1</param>
    /// <param name="y">Input argument #2</param>
    /// <param name="z">Input argument #3</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] mygriddata(int numArgsOut, Object x, Object y, Object z)
    {
      return mcr.EvaluateFunction(numArgsOut, "mygriddata", x, y, z);
    }


    /// <summary>
    /// Provides the standard 4-input Object interface to the mygriddata M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="x">Input argument #1</param>
    /// <param name="y">Input argument #2</param>
    /// <param name="z">Input argument #3</param>
    /// <param name="XI">Input argument #4</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] mygriddata(int numArgsOut, Object x, Object y, Object z, Object XI)
    {
      return mcr.EvaluateFunction(numArgsOut, "mygriddata", x, y, z, XI);
    }


    /// <summary>
    /// Provides the standard 5-input Object interface to the mygriddata M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="x">Input argument #1</param>
    /// <param name="y">Input argument #2</param>
    /// <param name="z">Input argument #3</param>
    /// <param name="XI">Input argument #4</param>
    /// <param name="YI">Input argument #5</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] mygriddata(int numArgsOut, Object x, Object y, Object z, Object XI, 
                         Object YI)
    {
      return mcr.EvaluateFunction(numArgsOut, "mygriddata", x, y, z, XI, YI);
    }


    /// <summary>
    /// Provides a single output, 0-input Objectinterface to the myinterp1 M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object myinterp1()
    {
      return mcr.EvaluateFunction("myinterp1", new Object[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input Objectinterface to the myinterp1 M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="x">Input argument #1</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object myinterp1(Object x)
    {
      return mcr.EvaluateFunction("myinterp1", x);
    }


    /// <summary>
    /// Provides a single output, 2-input Objectinterface to the myinterp1 M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="x">Input argument #1</param>
    /// <param name="y">Input argument #2</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object myinterp1(Object x, Object y)
    {
      return mcr.EvaluateFunction("myinterp1", x, y);
    }


    /// <summary>
    /// Provides a single output, 3-input Objectinterface to the myinterp1 M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="x">Input argument #1</param>
    /// <param name="y">Input argument #2</param>
    /// <param name="xi">Input argument #3</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object myinterp1(Object x, Object y, Object xi)
    {
      return mcr.EvaluateFunction("myinterp1", x, y, xi);
    }


    /// <summary>
    /// Provides the standard 0-input Object interface to the myinterp1 M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] myinterp1(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "myinterp1", new Object[]{});
    }


    /// <summary>
    /// Provides the standard 1-input Object interface to the myinterp1 M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="x">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] myinterp1(int numArgsOut, Object x)
    {
      return mcr.EvaluateFunction(numArgsOut, "myinterp1", x);
    }


    /// <summary>
    /// Provides the standard 2-input Object interface to the myinterp1 M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="x">Input argument #1</param>
    /// <param name="y">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] myinterp1(int numArgsOut, Object x, Object y)
    {
      return mcr.EvaluateFunction(numArgsOut, "myinterp1", x, y);
    }


    /// <summary>
    /// Provides the standard 3-input Object interface to the myinterp1 M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="x">Input argument #1</param>
    /// <param name="y">Input argument #2</param>
    /// <param name="xi">Input argument #3</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] myinterp1(int numArgsOut, Object x, Object y, Object xi)
    {
      return mcr.EvaluateFunction(numArgsOut, "myinterp1", x, y, xi);
    }


    /// <summary>
    /// Provides a single output, 0-input Objectinterface to the myinterp2 M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object myinterp2()
    {
      return mcr.EvaluateFunction("myinterp2", new Object[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input Objectinterface to the myinterp2 M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="X">Input argument #1</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object myinterp2(Object X)
    {
      return mcr.EvaluateFunction("myinterp2", X);
    }


    /// <summary>
    /// Provides a single output, 2-input Objectinterface to the myinterp2 M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="X">Input argument #1</param>
    /// <param name="Y">Input argument #2</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object myinterp2(Object X, Object Y)
    {
      return mcr.EvaluateFunction("myinterp2", X, Y);
    }


    /// <summary>
    /// Provides a single output, 3-input Objectinterface to the myinterp2 M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="X">Input argument #1</param>
    /// <param name="Y">Input argument #2</param>
    /// <param name="Z">Input argument #3</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object myinterp2(Object X, Object Y, Object Z)
    {
      return mcr.EvaluateFunction("myinterp2", X, Y, Z);
    }


    /// <summary>
    /// Provides a single output, 4-input Objectinterface to the myinterp2 M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="X">Input argument #1</param>
    /// <param name="Y">Input argument #2</param>
    /// <param name="Z">Input argument #3</param>
    /// <param name="XI">Input argument #4</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object myinterp2(Object X, Object Y, Object Z, Object XI)
    {
      return mcr.EvaluateFunction("myinterp2", X, Y, Z, XI);
    }


    /// <summary>
    /// Provides a single output, 5-input Objectinterface to the myinterp2 M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="X">Input argument #1</param>
    /// <param name="Y">Input argument #2</param>
    /// <param name="Z">Input argument #3</param>
    /// <param name="XI">Input argument #4</param>
    /// <param name="YI">Input argument #5</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object myinterp2(Object X, Object Y, Object Z, Object XI, Object YI)
    {
      return mcr.EvaluateFunction("myinterp2", X, Y, Z, XI, YI);
    }


    /// <summary>
    /// Provides a single output, 6-input Objectinterface to the myinterp2 M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="X">Input argument #1</param>
    /// <param name="Y">Input argument #2</param>
    /// <param name="Z">Input argument #3</param>
    /// <param name="XI">Input argument #4</param>
    /// <param name="YI">Input argument #5</param>
    /// <param name="method">Input argument #6</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object myinterp2(Object X, Object Y, Object Z, Object XI, Object YI, Object 
                      method)
    {
      return mcr.EvaluateFunction("myinterp2", X, Y, Z, XI, YI, method);
    }


    /// <summary>
    /// Provides the standard 0-input Object interface to the myinterp2 M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] myinterp2(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "myinterp2", new Object[]{});
    }


    /// <summary>
    /// Provides the standard 1-input Object interface to the myinterp2 M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="X">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] myinterp2(int numArgsOut, Object X)
    {
      return mcr.EvaluateFunction(numArgsOut, "myinterp2", X);
    }


    /// <summary>
    /// Provides the standard 2-input Object interface to the myinterp2 M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="X">Input argument #1</param>
    /// <param name="Y">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] myinterp2(int numArgsOut, Object X, Object Y)
    {
      return mcr.EvaluateFunction(numArgsOut, "myinterp2", X, Y);
    }


    /// <summary>
    /// Provides the standard 3-input Object interface to the myinterp2 M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="X">Input argument #1</param>
    /// <param name="Y">Input argument #2</param>
    /// <param name="Z">Input argument #3</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] myinterp2(int numArgsOut, Object X, Object Y, Object Z)
    {
      return mcr.EvaluateFunction(numArgsOut, "myinterp2", X, Y, Z);
    }


    /// <summary>
    /// Provides the standard 4-input Object interface to the myinterp2 M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="X">Input argument #1</param>
    /// <param name="Y">Input argument #2</param>
    /// <param name="Z">Input argument #3</param>
    /// <param name="XI">Input argument #4</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] myinterp2(int numArgsOut, Object X, Object Y, Object Z, Object XI)
    {
      return mcr.EvaluateFunction(numArgsOut, "myinterp2", X, Y, Z, XI);
    }


    /// <summary>
    /// Provides the standard 5-input Object interface to the myinterp2 M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="X">Input argument #1</param>
    /// <param name="Y">Input argument #2</param>
    /// <param name="Z">Input argument #3</param>
    /// <param name="XI">Input argument #4</param>
    /// <param name="YI">Input argument #5</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] myinterp2(int numArgsOut, Object X, Object Y, Object Z, Object XI, 
                        Object YI)
    {
      return mcr.EvaluateFunction(numArgsOut, "myinterp2", X, Y, Z, XI, YI);
    }


    /// <summary>
    /// Provides the standard 6-input Object interface to the myinterp2 M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="X">Input argument #1</param>
    /// <param name="Y">Input argument #2</param>
    /// <param name="Z">Input argument #3</param>
    /// <param name="XI">Input argument #4</param>
    /// <param name="YI">Input argument #5</param>
    /// <param name="method">Input argument #6</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] myinterp2(int numArgsOut, Object X, Object Y, Object Z, Object XI, 
                        Object YI, Object method)
    {
      return mcr.EvaluateFunction(numArgsOut, "myinterp2", X, Y, Z, XI, YI, method);
    }


    /// <summary>
    /// Provides a single output, 0-input Objectinterface to the mymeshgrid M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Using two colons to create a vector with increments between
    /// first and end elements.
    /// </remarks>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object mymeshgrid()
    {
      return mcr.EvaluateFunction("mymeshgrid", new Object[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input Objectinterface to the mymeshgrid M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Using two colons to create a vector with increments between
    /// first and end elements.
    /// </remarks>
    /// <param name="vectorstepx">Input argument #1</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object mymeshgrid(Object vectorstepx)
    {
      return mcr.EvaluateFunction("mymeshgrid", vectorstepx);
    }


    /// <summary>
    /// Provides a single output, 2-input Objectinterface to the mymeshgrid M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Using two colons to create a vector with increments between
    /// first and end elements.
    /// </remarks>
    /// <param name="vectorstepx">Input argument #1</param>
    /// <param name="vectorstepy">Input argument #2</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object mymeshgrid(Object vectorstepx, Object vectorstepy)
    {
      return mcr.EvaluateFunction("mymeshgrid", vectorstepx, vectorstepy);
    }


    /// <summary>
    /// Provides the standard 0-input Object interface to the mymeshgrid M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Using two colons to create a vector with increments between
    /// first and end elements.
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] mymeshgrid(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "mymeshgrid", new Object[]{});
    }


    /// <summary>
    /// Provides the standard 1-input Object interface to the mymeshgrid M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Using two colons to create a vector with increments between
    /// first and end elements.
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="vectorstepx">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] mymeshgrid(int numArgsOut, Object vectorstepx)
    {
      return mcr.EvaluateFunction(numArgsOut, "mymeshgrid", vectorstepx);
    }


    /// <summary>
    /// Provides the standard 2-input Object interface to the mymeshgrid M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Using two colons to create a vector with increments between
    /// first and end elements.
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="vectorstepx">Input argument #1</param>
    /// <param name="vectorstepy">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] mymeshgrid(int numArgsOut, Object vectorstepx, Object vectorstepy)
    {
      return mcr.EvaluateFunction(numArgsOut, "mymeshgrid", vectorstepx, vectorstepy);
    }


    /// <summary>
    /// Provides a single output, 0-input Objectinterface to the mypolyfit M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object mypolyfit()
    {
      return mcr.EvaluateFunction("mypolyfit", new Object[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input Objectinterface to the mypolyfit M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="x">Input argument #1</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object mypolyfit(Object x)
    {
      return mcr.EvaluateFunction("mypolyfit", x);
    }


    /// <summary>
    /// Provides a single output, 2-input Objectinterface to the mypolyfit M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="x">Input argument #1</param>
    /// <param name="y">Input argument #2</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object mypolyfit(Object x, Object y)
    {
      return mcr.EvaluateFunction("mypolyfit", x, y);
    }


    /// <summary>
    /// Provides a single output, 3-input Objectinterface to the mypolyfit M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="x">Input argument #1</param>
    /// <param name="y">Input argument #2</param>
    /// <param name="n">Input argument #3</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object mypolyfit(Object x, Object y, Object n)
    {
      return mcr.EvaluateFunction("mypolyfit", x, y, n);
    }


    /// <summary>
    /// Provides the standard 0-input Object interface to the mypolyfit M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] mypolyfit(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "mypolyfit", new Object[]{});
    }


    /// <summary>
    /// Provides the standard 1-input Object interface to the mypolyfit M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="x">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] mypolyfit(int numArgsOut, Object x)
    {
      return mcr.EvaluateFunction(numArgsOut, "mypolyfit", x);
    }


    /// <summary>
    /// Provides the standard 2-input Object interface to the mypolyfit M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="x">Input argument #1</param>
    /// <param name="y">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] mypolyfit(int numArgsOut, Object x, Object y)
    {
      return mcr.EvaluateFunction(numArgsOut, "mypolyfit", x, y);
    }


    /// <summary>
    /// Provides the standard 3-input Object interface to the mypolyfit M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="x">Input argument #1</param>
    /// <param name="y">Input argument #2</param>
    /// <param name="n">Input argument #3</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] mypolyfit(int numArgsOut, Object x, Object y, Object n)
    {
      return mcr.EvaluateFunction(numArgsOut, "mypolyfit", x, y, n);
    }


    /// <summary>
    /// Provides a single output, 0-input Objectinterface to the mypolyval M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object mypolyval()
    {
      return mcr.EvaluateFunction("mypolyval", new Object[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input Objectinterface to the mypolyval M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="p">Input argument #1</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object mypolyval(Object p)
    {
      return mcr.EvaluateFunction("mypolyval", p);
    }


    /// <summary>
    /// Provides a single output, 2-input Objectinterface to the mypolyval M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="p">Input argument #1</param>
    /// <param name="x">Input argument #2</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object mypolyval(Object p, Object x)
    {
      return mcr.EvaluateFunction("mypolyval", p, x);
    }


    /// <summary>
    /// Provides the standard 0-input Object interface to the mypolyval M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] mypolyval(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "mypolyval", new Object[]{});
    }


    /// <summary>
    /// Provides the standard 1-input Object interface to the mypolyval M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="p">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] mypolyval(int numArgsOut, Object p)
    {
      return mcr.EvaluateFunction(numArgsOut, "mypolyval", p);
    }


    /// <summary>
    /// Provides the standard 2-input Object interface to the mypolyval M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="p">Input argument #1</param>
    /// <param name="x">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] mypolyval(int numArgsOut, Object p, Object x)
    {
      return mcr.EvaluateFunction(numArgsOut, "mypolyval", p, x);
    }


    /// <summary>
    /// This method will cause a MATLAB figure window to behave as a modal dialog box.
    /// The method will not return until all the figure windows associated with this
    /// component have been closed.
    /// </summary>
    /// <remarks>
    /// An application should only call this method when required to keep the
    /// MATLAB figure window from disappearing.  Other techniques, such as calling
    /// Console.ReadLine() from the application should be considered where
    /// possible.</remarks>
    ///
    public void WaitForFiguresToDie()
    {
      mcr.WaitForFiguresToDie();
    }



    #endregion Methods

    #region Class Members

    private static MWMCR mcr= null;

    private bool disposed= false;

    #endregion Class Members
  }
}
