/*
* MATLAB Compiler: 4.11 (R2009b)
* Date: Sat Aug 07 10:01:24 2010
* Arguments: "-B" "macro_default" "-W" "dotnet:ODENameSpace,ODE,0.0,private" "-d"
* "C:\MatlabVB\Mfiles\ODE\ODENameSpace\src" "-T" "link:lib" "-v"
* "class{ODE:C:\MatlabVB\Mfiles\ODE\myode45firstorder.m,C:\MatlabVB\Mfiles\ODE\myode45seco
* ndorder.m,C:\MatlabVB\Mfiles\ODE\myotherode.m,C:\MatlabVB\Mfiles\ODE\mysecondfunc.m,C:\M
* atlabVB\Mfiles\ODE\yourfunc.m,C:\MatlabVB\Mfiles\ODE\yoursecondfunc.m}"
* "class{Class1:}" 
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

namespace ODENameSpaceNative
{
  /// <summary>
  /// The ODE class provides a CLS compliant, Object (native) interface to the
  /// M-functions contained in the files:
  /// <newpara></newpara>
  /// C:\MatlabVB\Mfiles\ODE\myode45firstorder.m
  /// <newpara></newpara>
  /// C:\MatlabVB\Mfiles\ODE\myode45secondorder.m
  /// <newpara></newpara>
  /// C:\MatlabVB\Mfiles\ODE\myotherode.m
  /// <newpara></newpara>
  /// C:\MatlabVB\Mfiles\ODE\mysecondfunc.m
  /// <newpara></newpara>
  /// C:\MatlabVB\Mfiles\ODE\yourfunc.m
  /// <newpara></newpara>
  /// C:\MatlabVB\Mfiles\ODE\yoursecondfunc.m
  /// <newpara></newpara>
  /// deployprint.m
  /// <newpara></newpara>
  /// printdlg.m
  /// </summary>
  /// <remarks>
  /// @Version 0.0
  /// </remarks>
  public class ODE : IDisposable
  {
    #region Constructors

    /// <summary internal= "true">
    /// The static constructor instantiates and initializes the MATLAB Component Runtime
    /// instance.
    /// </summary>
    static ODE()
    {
      if (MWMCR.MCRAppInitialized)
      {
        Assembly assembly= Assembly.GetExecutingAssembly();

        string ctfFilePath= assembly.Location;

        int lastDelimiter= ctfFilePath.LastIndexOf(@"\");

        ctfFilePath= ctfFilePath.Remove(lastDelimiter, (ctfFilePath.Length - lastDelimiter));

        string ctfFileName = MCRComponentState.MCC_ODENameSpace_name_data + ".ctf";

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
        mcr= new MWMCR(MCRComponentState.MCC_ODENameSpace_name_data,
                       MCRComponentState.MCC_ODENameSpace_root_data,
                       MCRComponentState.MCC_ODENameSpace_public_data,
                       MCRComponentState.MCC_ODENameSpace_session_data,
                       MCRComponentState.MCC_ODENameSpace_matlabpath_data,
                       MCRComponentState.MCC_ODENameSpace_classpath_data,
                       MCRComponentState.MCC_ODENameSpace_libpath_data,
                       MCRComponentState.MCC_ODENameSpace_mcr_application_options,
                       MCRComponentState.MCC_ODENameSpace_mcr_runtime_options,
                       MCRComponentState.MCC_ODENameSpace_mcr_pref_dir,
                       MCRComponentState.MCC_ODENameSpace_set_warning_state,
                       ctfFilePath, embeddedCtfStream, true);
      }
      else
      {
        throw new ApplicationException("MWArray assembly could not be initialized");
      }
    }


    /// <summary>
    /// Constructs a new instance of the ODE class.
    /// </summary>
    public ODE()
    {
    }


    #endregion Constructors

    #region Finalize

    /// <summary internal= "true">
    /// Class destructor called by the CLR garbage collector.
    /// </summary>
    ~ODE()
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
    /// Provides a single output, 0-input Objectinterface to the myode45firstorder
    /// M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object myode45firstorder()
    {
      return mcr.EvaluateFunction("myode45firstorder", new Object[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input Objectinterface to the myode45firstorder
    /// M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="strfunc">Input argument #1</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object myode45firstorder(Object strfunc)
    {
      return mcr.EvaluateFunction("myode45firstorder", strfunc);
    }


    /// <summary>
    /// Provides a single output, 2-input Objectinterface to the myode45firstorder
    /// M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="strfunc">Input argument #1</param>
    /// <param name="tspan">Input argument #2</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object myode45firstorder(Object strfunc, Object tspan)
    {
      return mcr.EvaluateFunction("myode45firstorder", strfunc, tspan);
    }


    /// <summary>
    /// Provides a single output, 3-input Objectinterface to the myode45firstorder
    /// M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="strfunc">Input argument #1</param>
    /// <param name="tspan">Input argument #2</param>
    /// <param name="y0">Input argument #3</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object myode45firstorder(Object strfunc, Object tspan, Object y0)
    {
      return mcr.EvaluateFunction("myode45firstorder", strfunc, tspan, y0);
    }


    /// <summary>
    /// Provides the standard 0-input Object interface to the myode45firstorder
    /// M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] myode45firstorder(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "myode45firstorder", new Object[]{});
    }


    /// <summary>
    /// Provides the standard 1-input Object interface to the myode45firstorder
    /// M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="strfunc">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] myode45firstorder(int numArgsOut, Object strfunc)
    {
      return mcr.EvaluateFunction(numArgsOut, "myode45firstorder", strfunc);
    }


    /// <summary>
    /// Provides the standard 2-input Object interface to the myode45firstorder
    /// M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="strfunc">Input argument #1</param>
    /// <param name="tspan">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] myode45firstorder(int numArgsOut, Object strfunc, Object tspan)
    {
      return mcr.EvaluateFunction(numArgsOut, "myode45firstorder", strfunc, tspan);
    }


    /// <summary>
    /// Provides the standard 3-input Object interface to the myode45firstorder
    /// M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="strfunc">Input argument #1</param>
    /// <param name="tspan">Input argument #2</param>
    /// <param name="y0">Input argument #3</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] myode45firstorder(int numArgsOut, Object strfunc, Object tspan, 
                                Object y0)
    {
      return mcr.EvaluateFunction(numArgsOut, "myode45firstorder", strfunc, tspan, y0);
    }


    /// <summary>
    /// Provides a single output, 0-input Objectinterface to the myode45secondorder
    /// M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object myode45secondorder()
    {
      return mcr.EvaluateFunction("myode45secondorder", new Object[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input Objectinterface to the myode45secondorder
    /// M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="strfunc">Input argument #1</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object myode45secondorder(Object strfunc)
    {
      return mcr.EvaluateFunction("myode45secondorder", strfunc);
    }


    /// <summary>
    /// Provides a single output, 2-input Objectinterface to the myode45secondorder
    /// M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="strfunc">Input argument #1</param>
    /// <param name="tspan">Input argument #2</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object myode45secondorder(Object strfunc, Object tspan)
    {
      return mcr.EvaluateFunction("myode45secondorder", strfunc, tspan);
    }


    /// <summary>
    /// Provides a single output, 3-input Objectinterface to the myode45secondorder
    /// M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="strfunc">Input argument #1</param>
    /// <param name="tspan">Input argument #2</param>
    /// <param name="y0">Input argument #3</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object myode45secondorder(Object strfunc, Object tspan, Object y0)
    {
      return mcr.EvaluateFunction("myode45secondorder", strfunc, tspan, y0);
    }


    /// <summary>
    /// Provides the standard 0-input Object interface to the myode45secondorder
    /// M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] myode45secondorder(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "myode45secondorder", new Object[]{});
    }


    /// <summary>
    /// Provides the standard 1-input Object interface to the myode45secondorder
    /// M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="strfunc">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] myode45secondorder(int numArgsOut, Object strfunc)
    {
      return mcr.EvaluateFunction(numArgsOut, "myode45secondorder", strfunc);
    }


    /// <summary>
    /// Provides the standard 2-input Object interface to the myode45secondorder
    /// M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="strfunc">Input argument #1</param>
    /// <param name="tspan">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] myode45secondorder(int numArgsOut, Object strfunc, Object tspan)
    {
      return mcr.EvaluateFunction(numArgsOut, "myode45secondorder", strfunc, tspan);
    }


    /// <summary>
    /// Provides the standard 3-input Object interface to the myode45secondorder
    /// M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="strfunc">Input argument #1</param>
    /// <param name="tspan">Input argument #2</param>
    /// <param name="y0">Input argument #3</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] myode45secondorder(int numArgsOut, Object strfunc, Object tspan, 
                                 Object y0)
    {
      return mcr.EvaluateFunction(numArgsOut, "myode45secondorder", strfunc, tspan, y0);
    }


    /// <summary>
    /// Provides a single output, 0-input Objectinterface to the myotherode M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object myotherode()
    {
      return mcr.EvaluateFunction("myotherode", new Object[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input Objectinterface to the myotherode M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="tspan">Input argument #1</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object myotherode(Object tspan)
    {
      return mcr.EvaluateFunction("myotherode", tspan);
    }


    /// <summary>
    /// Provides a single output, 2-input Objectinterface to the myotherode M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="tspan">Input argument #1</param>
    /// <param name="y0">Input argument #2</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object myotherode(Object tspan, Object y0)
    {
      return mcr.EvaluateFunction("myotherode", tspan, y0);
    }


    /// <summary>
    /// Provides the standard 0-input Object interface to the myotherode M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] myotherode(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "myotherode", new Object[]{});
    }


    /// <summary>
    /// Provides the standard 1-input Object interface to the myotherode M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="tspan">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] myotherode(int numArgsOut, Object tspan)
    {
      return mcr.EvaluateFunction(numArgsOut, "myotherode", tspan);
    }


    /// <summary>
    /// Provides the standard 2-input Object interface to the myotherode M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="tspan">Input argument #1</param>
    /// <param name="y0">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] myotherode(int numArgsOut, Object tspan, Object y0)
    {
      return mcr.EvaluateFunction(numArgsOut, "myotherode", tspan, y0);
    }


    /// <summary>
    /// Provides a single output, 0-input Objectinterface to the mysecondfunc M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object mysecondfunc()
    {
      return mcr.EvaluateFunction("mysecondfunc", new Object[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input Objectinterface to the mysecondfunc M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="t">Input argument #1</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object mysecondfunc(Object t)
    {
      return mcr.EvaluateFunction("mysecondfunc", t);
    }


    /// <summary>
    /// Provides a single output, 2-input Objectinterface to the mysecondfunc M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="t">Input argument #1</param>
    /// <param name="y">Input argument #2</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object mysecondfunc(Object t, Object y)
    {
      return mcr.EvaluateFunction("mysecondfunc", t, y);
    }


    /// <summary>
    /// Provides the standard 0-input Object interface to the mysecondfunc M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] mysecondfunc(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "mysecondfunc", new Object[]{});
    }


    /// <summary>
    /// Provides the standard 1-input Object interface to the mysecondfunc M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="t">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] mysecondfunc(int numArgsOut, Object t)
    {
      return mcr.EvaluateFunction(numArgsOut, "mysecondfunc", t);
    }


    /// <summary>
    /// Provides the standard 2-input Object interface to the mysecondfunc M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="t">Input argument #1</param>
    /// <param name="y">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] mysecondfunc(int numArgsOut, Object t, Object y)
    {
      return mcr.EvaluateFunction(numArgsOut, "mysecondfunc", t, y);
    }


    /// <summary>
    /// Provides a single output, 0-input Objectinterface to the yourfunc M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// trick for a function with/without t, y
    /// </remarks>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object yourfunc()
    {
      return mcr.EvaluateFunction("yourfunc", new Object[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input Objectinterface to the yourfunc M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// trick for a function with/without t, y
    /// </remarks>
    /// <param name="t">Input argument #1</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object yourfunc(Object t)
    {
      return mcr.EvaluateFunction("yourfunc", t);
    }


    /// <summary>
    /// Provides a single output, 2-input Objectinterface to the yourfunc M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// trick for a function with/without t, y
    /// </remarks>
    /// <param name="t">Input argument #1</param>
    /// <param name="y">Input argument #2</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object yourfunc(Object t, Object y)
    {
      return mcr.EvaluateFunction("yourfunc", t, y);
    }


    /// <summary>
    /// Provides a single output, 3-input Objectinterface to the yourfunc M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// trick for a function with/without t, y
    /// </remarks>
    /// <param name="t">Input argument #1</param>
    /// <param name="y">Input argument #2</param>
    /// <param name="strfunc">Input argument #3</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object yourfunc(Object t, Object y, Object strfunc)
    {
      return mcr.EvaluateFunction("yourfunc", t, y, strfunc);
    }


    /// <summary>
    /// Provides the standard 0-input Object interface to the yourfunc M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// trick for a function with/without t, y
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] yourfunc(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "yourfunc", new Object[]{});
    }


    /// <summary>
    /// Provides the standard 1-input Object interface to the yourfunc M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// trick for a function with/without t, y
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="t">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] yourfunc(int numArgsOut, Object t)
    {
      return mcr.EvaluateFunction(numArgsOut, "yourfunc", t);
    }


    /// <summary>
    /// Provides the standard 2-input Object interface to the yourfunc M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// trick for a function with/without t, y
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="t">Input argument #1</param>
    /// <param name="y">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] yourfunc(int numArgsOut, Object t, Object y)
    {
      return mcr.EvaluateFunction(numArgsOut, "yourfunc", t, y);
    }


    /// <summary>
    /// Provides the standard 3-input Object interface to the yourfunc M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// trick for a function with/without t, y
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="t">Input argument #1</param>
    /// <param name="y">Input argument #2</param>
    /// <param name="strfunc">Input argument #3</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] yourfunc(int numArgsOut, Object t, Object y, Object strfunc)
    {
      return mcr.EvaluateFunction(numArgsOut, "yourfunc", t, y, strfunc);
    }


    /// <summary>
    /// Provides a single output, 0-input Objectinterface to the yoursecondfunc
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// example:
    /// y'' - 2y' -6y = cos(3t)
    /// y'' = cos(3t) + 2y' + 6y 
    /// write an expression string with replace y' by yprime:
    /// cos(3*t) + 2*yprime + 6*y
    /// </remarks>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object yoursecondfunc()
    {
      return mcr.EvaluateFunction("yoursecondfunc", new Object[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input Objectinterface to the yoursecondfunc
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// example:
    /// y'' - 2y' -6y = cos(3t)
    /// y'' = cos(3t) + 2y' + 6y 
    /// write an expression string with replace y' by yprime:
    /// cos(3*t) + 2*yprime + 6*y
    /// </remarks>
    /// <param name="t">Input argument #1</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object yoursecondfunc(Object t)
    {
      return mcr.EvaluateFunction("yoursecondfunc", t);
    }


    /// <summary>
    /// Provides a single output, 2-input Objectinterface to the yoursecondfunc
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// example:
    /// y'' - 2y' -6y = cos(3t)
    /// y'' = cos(3t) + 2y' + 6y 
    /// write an expression string with replace y' by yprime:
    /// cos(3*t) + 2*yprime + 6*y
    /// </remarks>
    /// <param name="t">Input argument #1</param>
    /// <param name="y">Input argument #2</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object yoursecondfunc(Object t, Object y)
    {
      return mcr.EvaluateFunction("yoursecondfunc", t, y);
    }


    /// <summary>
    /// Provides a single output, 3-input Objectinterface to the yoursecondfunc
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// example:
    /// y'' - 2y' -6y = cos(3t)
    /// y'' = cos(3t) + 2y' + 6y 
    /// write an expression string with replace y' by yprime:
    /// cos(3*t) + 2*yprime + 6*y
    /// </remarks>
    /// <param name="t">Input argument #1</param>
    /// <param name="y">Input argument #2</param>
    /// <param name="strfunc">Input argument #3</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object yoursecondfunc(Object t, Object y, Object strfunc)
    {
      return mcr.EvaluateFunction("yoursecondfunc", t, y, strfunc);
    }


    /// <summary>
    /// Provides the standard 0-input Object interface to the yoursecondfunc M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// example:
    /// y'' - 2y' -6y = cos(3t)
    /// y'' = cos(3t) + 2y' + 6y 
    /// write an expression string with replace y' by yprime:
    /// cos(3*t) + 2*yprime + 6*y
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] yoursecondfunc(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "yoursecondfunc", new Object[]{});
    }


    /// <summary>
    /// Provides the standard 1-input Object interface to the yoursecondfunc M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// example:
    /// y'' - 2y' -6y = cos(3t)
    /// y'' = cos(3t) + 2y' + 6y 
    /// write an expression string with replace y' by yprime:
    /// cos(3*t) + 2*yprime + 6*y
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="t">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] yoursecondfunc(int numArgsOut, Object t)
    {
      return mcr.EvaluateFunction(numArgsOut, "yoursecondfunc", t);
    }


    /// <summary>
    /// Provides the standard 2-input Object interface to the yoursecondfunc M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// example:
    /// y'' - 2y' -6y = cos(3t)
    /// y'' = cos(3t) + 2y' + 6y 
    /// write an expression string with replace y' by yprime:
    /// cos(3*t) + 2*yprime + 6*y
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="t">Input argument #1</param>
    /// <param name="y">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] yoursecondfunc(int numArgsOut, Object t, Object y)
    {
      return mcr.EvaluateFunction(numArgsOut, "yoursecondfunc", t, y);
    }


    /// <summary>
    /// Provides the standard 3-input Object interface to the yoursecondfunc M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// example:
    /// y'' - 2y' -6y = cos(3t)
    /// y'' = cos(3t) + 2y' + 6y 
    /// write an expression string with replace y' by yprime:
    /// cos(3*t) + 2*yprime + 6*y
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="t">Input argument #1</param>
    /// <param name="y">Input argument #2</param>
    /// <param name="strfunc">Input argument #3</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] yoursecondfunc(int numArgsOut, Object t, Object y, Object strfunc)
    {
      return mcr.EvaluateFunction(numArgsOut, "yoursecondfunc", t, y, strfunc);
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
