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

namespace ODENameSpace
{
  /// <summary>
  /// The ODE class provides a CLS compliant, MWArray interface to the M-functions
  /// contained in the files:
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
    /// Provides a single output, 0-input MWArrayinterface to the myode45firstorder
    /// M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray myode45firstorder()
    {
      return mcr.EvaluateFunction("myode45firstorder", new MWArray[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input MWArrayinterface to the myode45firstorder
    /// M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="strfunc">Input argument #1</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray myode45firstorder(MWArray strfunc)
    {
      return mcr.EvaluateFunction("myode45firstorder", strfunc);
    }


    /// <summary>
    /// Provides a single output, 2-input MWArrayinterface to the myode45firstorder
    /// M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="strfunc">Input argument #1</param>
    /// <param name="tspan">Input argument #2</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray myode45firstorder(MWArray strfunc, MWArray tspan)
    {
      return mcr.EvaluateFunction("myode45firstorder", strfunc, tspan);
    }


    /// <summary>
    /// Provides a single output, 3-input MWArrayinterface to the myode45firstorder
    /// M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="strfunc">Input argument #1</param>
    /// <param name="tspan">Input argument #2</param>
    /// <param name="y0">Input argument #3</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray myode45firstorder(MWArray strfunc, MWArray tspan, MWArray y0)
    {
      return mcr.EvaluateFunction("myode45firstorder", strfunc, tspan, y0);
    }


    /// <summary>
    /// Provides the standard 0-input MWArray interface to the myode45firstorder
    /// M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] myode45firstorder(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "myode45firstorder", new MWArray[]{});
    }


    /// <summary>
    /// Provides the standard 1-input MWArray interface to the myode45firstorder
    /// M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="strfunc">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] myode45firstorder(int numArgsOut, MWArray strfunc)
    {
      return mcr.EvaluateFunction(numArgsOut, "myode45firstorder", strfunc);
    }


    /// <summary>
    /// Provides the standard 2-input MWArray interface to the myode45firstorder
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
    public MWArray[] myode45firstorder(int numArgsOut, MWArray strfunc, MWArray tspan)
    {
      return mcr.EvaluateFunction(numArgsOut, "myode45firstorder", strfunc, tspan);
    }


    /// <summary>
    /// Provides the standard 3-input MWArray interface to the myode45firstorder
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
    public MWArray[] myode45firstorder(int numArgsOut, MWArray strfunc, MWArray tspan, 
                                 MWArray y0)
    {
      return mcr.EvaluateFunction(numArgsOut, "myode45firstorder", strfunc, tspan, y0);
    }


    /// <summary>
    /// Provides an interface for the myode45firstorder function in which the input and
    /// output
    /// arguments are specified as an array of MWArrays.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of MWArray output arguments</param>
    /// <param name= "argsIn">Array of MWArray input arguments</param>
    ///
    public void myode45firstorder(int numArgsOut, ref MWArray[] argsOut, MWArray[] argsIn)
    {
      mcr.EvaluateFunction("myode45firstorder", numArgsOut, ref argsOut, argsIn);
    }


    /// <summary>
    /// Provides a single output, 0-input MWArrayinterface to the myode45secondorder
    /// M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray myode45secondorder()
    {
      return mcr.EvaluateFunction("myode45secondorder", new MWArray[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input MWArrayinterface to the myode45secondorder
    /// M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="strfunc">Input argument #1</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray myode45secondorder(MWArray strfunc)
    {
      return mcr.EvaluateFunction("myode45secondorder", strfunc);
    }


    /// <summary>
    /// Provides a single output, 2-input MWArrayinterface to the myode45secondorder
    /// M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="strfunc">Input argument #1</param>
    /// <param name="tspan">Input argument #2</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray myode45secondorder(MWArray strfunc, MWArray tspan)
    {
      return mcr.EvaluateFunction("myode45secondorder", strfunc, tspan);
    }


    /// <summary>
    /// Provides a single output, 3-input MWArrayinterface to the myode45secondorder
    /// M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="strfunc">Input argument #1</param>
    /// <param name="tspan">Input argument #2</param>
    /// <param name="y0">Input argument #3</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray myode45secondorder(MWArray strfunc, MWArray tspan, MWArray y0)
    {
      return mcr.EvaluateFunction("myode45secondorder", strfunc, tspan, y0);
    }


    /// <summary>
    /// Provides the standard 0-input MWArray interface to the myode45secondorder
    /// M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] myode45secondorder(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "myode45secondorder", new MWArray[]{});
    }


    /// <summary>
    /// Provides the standard 1-input MWArray interface to the myode45secondorder
    /// M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="strfunc">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] myode45secondorder(int numArgsOut, MWArray strfunc)
    {
      return mcr.EvaluateFunction(numArgsOut, "myode45secondorder", strfunc);
    }


    /// <summary>
    /// Provides the standard 2-input MWArray interface to the myode45secondorder
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
    public MWArray[] myode45secondorder(int numArgsOut, MWArray strfunc, MWArray tspan)
    {
      return mcr.EvaluateFunction(numArgsOut, "myode45secondorder", strfunc, tspan);
    }


    /// <summary>
    /// Provides the standard 3-input MWArray interface to the myode45secondorder
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
    public MWArray[] myode45secondorder(int numArgsOut, MWArray strfunc, MWArray tspan, 
                                  MWArray y0)
    {
      return mcr.EvaluateFunction(numArgsOut, "myode45secondorder", strfunc, tspan, y0);
    }


    /// <summary>
    /// Provides an interface for the myode45secondorder function in which the input and
    /// output
    /// arguments are specified as an array of MWArrays.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of MWArray output arguments</param>
    /// <param name= "argsIn">Array of MWArray input arguments</param>
    ///
    public void myode45secondorder(int numArgsOut, ref MWArray[] argsOut, MWArray[] 
                         argsIn)
    {
      mcr.EvaluateFunction("myode45secondorder", numArgsOut, ref argsOut, argsIn);
    }


    /// <summary>
    /// Provides a single output, 0-input MWArrayinterface to the myotherode M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray myotherode()
    {
      return mcr.EvaluateFunction("myotherode", new MWArray[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input MWArrayinterface to the myotherode M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="tspan">Input argument #1</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray myotherode(MWArray tspan)
    {
      return mcr.EvaluateFunction("myotherode", tspan);
    }


    /// <summary>
    /// Provides a single output, 2-input MWArrayinterface to the myotherode M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="tspan">Input argument #1</param>
    /// <param name="y0">Input argument #2</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray myotherode(MWArray tspan, MWArray y0)
    {
      return mcr.EvaluateFunction("myotherode", tspan, y0);
    }


    /// <summary>
    /// Provides the standard 0-input MWArray interface to the myotherode M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] myotherode(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "myotherode", new MWArray[]{});
    }


    /// <summary>
    /// Provides the standard 1-input MWArray interface to the myotherode M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="tspan">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] myotherode(int numArgsOut, MWArray tspan)
    {
      return mcr.EvaluateFunction(numArgsOut, "myotherode", tspan);
    }


    /// <summary>
    /// Provides the standard 2-input MWArray interface to the myotherode M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="tspan">Input argument #1</param>
    /// <param name="y0">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] myotherode(int numArgsOut, MWArray tspan, MWArray y0)
    {
      return mcr.EvaluateFunction(numArgsOut, "myotherode", tspan, y0);
    }


    /// <summary>
    /// Provides an interface for the myotherode function in which the input and output
    /// arguments are specified as an array of MWArrays.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of MWArray output arguments</param>
    /// <param name= "argsIn">Array of MWArray input arguments</param>
    ///
    public void myotherode(int numArgsOut, ref MWArray[] argsOut, MWArray[] argsIn)
    {
      mcr.EvaluateFunction("myotherode", numArgsOut, ref argsOut, argsIn);
    }


    /// <summary>
    /// Provides a single output, 0-input MWArrayinterface to the mysecondfunc
    /// M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray mysecondfunc()
    {
      return mcr.EvaluateFunction("mysecondfunc", new MWArray[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input MWArrayinterface to the mysecondfunc
    /// M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="t">Input argument #1</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray mysecondfunc(MWArray t)
    {
      return mcr.EvaluateFunction("mysecondfunc", t);
    }


    /// <summary>
    /// Provides a single output, 2-input MWArrayinterface to the mysecondfunc
    /// M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="t">Input argument #1</param>
    /// <param name="y">Input argument #2</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray mysecondfunc(MWArray t, MWArray y)
    {
      return mcr.EvaluateFunction("mysecondfunc", t, y);
    }


    /// <summary>
    /// Provides the standard 0-input MWArray interface to the mysecondfunc M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] mysecondfunc(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "mysecondfunc", new MWArray[]{});
    }


    /// <summary>
    /// Provides the standard 1-input MWArray interface to the mysecondfunc M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="t">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] mysecondfunc(int numArgsOut, MWArray t)
    {
      return mcr.EvaluateFunction(numArgsOut, "mysecondfunc", t);
    }


    /// <summary>
    /// Provides the standard 2-input MWArray interface to the mysecondfunc M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="t">Input argument #1</param>
    /// <param name="y">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] mysecondfunc(int numArgsOut, MWArray t, MWArray y)
    {
      return mcr.EvaluateFunction(numArgsOut, "mysecondfunc", t, y);
    }


    /// <summary>
    /// Provides an interface for the mysecondfunc function in which the input and output
    /// arguments are specified as an array of MWArrays.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of MWArray output arguments</param>
    /// <param name= "argsIn">Array of MWArray input arguments</param>
    ///
    public void mysecondfunc(int numArgsOut, ref MWArray[] argsOut, MWArray[] argsIn)
    {
      mcr.EvaluateFunction("mysecondfunc", numArgsOut, ref argsOut, argsIn);
    }


    /// <summary>
    /// Provides a single output, 0-input MWArrayinterface to the yourfunc M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// trick for a function with/without t, y
    /// </remarks>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray yourfunc()
    {
      return mcr.EvaluateFunction("yourfunc", new MWArray[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input MWArrayinterface to the yourfunc M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// trick for a function with/without t, y
    /// </remarks>
    /// <param name="t">Input argument #1</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray yourfunc(MWArray t)
    {
      return mcr.EvaluateFunction("yourfunc", t);
    }


    /// <summary>
    /// Provides a single output, 2-input MWArrayinterface to the yourfunc M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// trick for a function with/without t, y
    /// </remarks>
    /// <param name="t">Input argument #1</param>
    /// <param name="y">Input argument #2</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray yourfunc(MWArray t, MWArray y)
    {
      return mcr.EvaluateFunction("yourfunc", t, y);
    }


    /// <summary>
    /// Provides a single output, 3-input MWArrayinterface to the yourfunc M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// trick for a function with/without t, y
    /// </remarks>
    /// <param name="t">Input argument #1</param>
    /// <param name="y">Input argument #2</param>
    /// <param name="strfunc">Input argument #3</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray yourfunc(MWArray t, MWArray y, MWArray strfunc)
    {
      return mcr.EvaluateFunction("yourfunc", t, y, strfunc);
    }


    /// <summary>
    /// Provides the standard 0-input MWArray interface to the yourfunc M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// trick for a function with/without t, y
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] yourfunc(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "yourfunc", new MWArray[]{});
    }


    /// <summary>
    /// Provides the standard 1-input MWArray interface to the yourfunc M-function.
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
    public MWArray[] yourfunc(int numArgsOut, MWArray t)
    {
      return mcr.EvaluateFunction(numArgsOut, "yourfunc", t);
    }


    /// <summary>
    /// Provides the standard 2-input MWArray interface to the yourfunc M-function.
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
    public MWArray[] yourfunc(int numArgsOut, MWArray t, MWArray y)
    {
      return mcr.EvaluateFunction(numArgsOut, "yourfunc", t, y);
    }


    /// <summary>
    /// Provides the standard 3-input MWArray interface to the yourfunc M-function.
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
    public MWArray[] yourfunc(int numArgsOut, MWArray t, MWArray y, MWArray strfunc)
    {
      return mcr.EvaluateFunction(numArgsOut, "yourfunc", t, y, strfunc);
    }


    /// <summary>
    /// Provides an interface for the yourfunc function in which the input and output
    /// arguments are specified as an array of MWArrays.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// M-Documentation:
    /// trick for a function with/without t, y
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of MWArray output arguments</param>
    /// <param name= "argsIn">Array of MWArray input arguments</param>
    ///
    public void yourfunc(int numArgsOut, ref MWArray[] argsOut, MWArray[] argsIn)
    {
      mcr.EvaluateFunction("yourfunc", numArgsOut, ref argsOut, argsIn);
    }


    /// <summary>
    /// Provides a single output, 0-input MWArrayinterface to the yoursecondfunc
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
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray yoursecondfunc()
    {
      return mcr.EvaluateFunction("yoursecondfunc", new MWArray[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input MWArrayinterface to the yoursecondfunc
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
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray yoursecondfunc(MWArray t)
    {
      return mcr.EvaluateFunction("yoursecondfunc", t);
    }


    /// <summary>
    /// Provides a single output, 2-input MWArrayinterface to the yoursecondfunc
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
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray yoursecondfunc(MWArray t, MWArray y)
    {
      return mcr.EvaluateFunction("yoursecondfunc", t, y);
    }


    /// <summary>
    /// Provides a single output, 3-input MWArrayinterface to the yoursecondfunc
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
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray yoursecondfunc(MWArray t, MWArray y, MWArray strfunc)
    {
      return mcr.EvaluateFunction("yoursecondfunc", t, y, strfunc);
    }


    /// <summary>
    /// Provides the standard 0-input MWArray interface to the yoursecondfunc M-function.
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
    public MWArray[] yoursecondfunc(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "yoursecondfunc", new MWArray[]{});
    }


    /// <summary>
    /// Provides the standard 1-input MWArray interface to the yoursecondfunc M-function.
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
    public MWArray[] yoursecondfunc(int numArgsOut, MWArray t)
    {
      return mcr.EvaluateFunction(numArgsOut, "yoursecondfunc", t);
    }


    /// <summary>
    /// Provides the standard 2-input MWArray interface to the yoursecondfunc M-function.
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
    public MWArray[] yoursecondfunc(int numArgsOut, MWArray t, MWArray y)
    {
      return mcr.EvaluateFunction(numArgsOut, "yoursecondfunc", t, y);
    }


    /// <summary>
    /// Provides the standard 3-input MWArray interface to the yoursecondfunc M-function.
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
    public MWArray[] yoursecondfunc(int numArgsOut, MWArray t, MWArray y, MWArray strfunc)
    {
      return mcr.EvaluateFunction(numArgsOut, "yoursecondfunc", t, y, strfunc);
    }


    /// <summary>
    /// Provides an interface for the yoursecondfunc function in which the input and
    /// output
    /// arguments are specified as an array of MWArrays.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// M-Documentation:
    /// example:
    /// y'' - 2y' -6y = cos(3t)
    /// y'' = cos(3t) + 2y' + 6y 
    /// write an expression string with replace y' by yprime:
    /// cos(3*t) + 2*yprime + 6*y
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of MWArray output arguments</param>
    /// <param name= "argsIn">Array of MWArray input arguments</param>
    ///
    public void yoursecondfunc(int numArgsOut, ref MWArray[] argsOut, MWArray[] argsIn)
    {
      mcr.EvaluateFunction("yoursecondfunc", numArgsOut, ref argsOut, argsIn);
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
