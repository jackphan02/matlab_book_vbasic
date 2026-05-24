/*
* MATLAB Compiler: 4.11 (R2009b)
* Date: Thu Aug 05 06:54:58 2010
* Arguments: "-B" "macro_default" "-W"
* "dotnet:LinearSystemNameSpace,LinearSystem,0.0,private" "-d"
* "C:\MatlabVB\Mfiles\LinearSystem\LinearSystemNameSpace\src" "-T" "link:lib" "-v"
* "class{LinearSystem:C:\MatlabVB\Mfiles\LinearSystem\mydiag.m,C:\MatlabVB\Mfiles\LinearSy
* stem\myextractmatrix.m,C:\MatlabVB\Mfiles\LinearSystem\myfull.m,C:\MatlabVB\Mfiles\Linea
* rSystem\mylu.m,C:\MatlabVB\Mfiles\LinearSystem\mymldivide.m,C:\MatlabVB\Mfiles\LinearSys
* tem\mymrdivide.m,C:\MatlabVB\Mfiles\LinearSystem\mysparse.m,C:\MatlabVB\Mfiles\LinearSys
* tem\myspdiags.m,C:\MatlabVB\Mfiles\LinearSystem\mytranspose.m}" 
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

namespace LinearSystemNameSpaceNative
{
  /// <summary>
  /// The LinearSystem class provides a CLS compliant, Object (native) interface to the
  /// M-functions contained in the files:
  /// <newpara></newpara>
  /// C:\MatlabVB\Mfiles\LinearSystem\mydiag.m
  /// <newpara></newpara>
  /// C:\MatlabVB\Mfiles\LinearSystem\myextractmatrix.m
  /// <newpara></newpara>
  /// C:\MatlabVB\Mfiles\LinearSystem\myfull.m
  /// <newpara></newpara>
  /// C:\MatlabVB\Mfiles\LinearSystem\mylu.m
  /// <newpara></newpara>
  /// C:\MatlabVB\Mfiles\LinearSystem\mymldivide.m
  /// <newpara></newpara>
  /// C:\MatlabVB\Mfiles\LinearSystem\mymrdivide.m
  /// <newpara></newpara>
  /// C:\MatlabVB\Mfiles\LinearSystem\mysparse.m
  /// <newpara></newpara>
  /// C:\MatlabVB\Mfiles\LinearSystem\myspdiags.m
  /// <newpara></newpara>
  /// C:\MatlabVB\Mfiles\LinearSystem\mytranspose.m
  /// <newpara></newpara>
  /// deployprint.m
  /// <newpara></newpara>
  /// printdlg.m
  /// </summary>
  /// <remarks>
  /// @Version 0.0
  /// </remarks>
  public class LinearSystem : IDisposable
  {
    #region Constructors

    /// <summary internal= "true">
    /// The static constructor instantiates and initializes the MATLAB Component Runtime
    /// instance.
    /// </summary>
    static LinearSystem()
    {
      if (MWMCR.MCRAppInitialized)
      {
        Assembly assembly= Assembly.GetExecutingAssembly();

        string ctfFilePath= assembly.Location;

        int lastDelimiter= ctfFilePath.LastIndexOf(@"\");

        ctfFilePath= ctfFilePath.Remove(lastDelimiter, (ctfFilePath.Length - lastDelimiter));

        string ctfFileName = MCRComponentState.MCC_LinearSystemNameSpace_name_data + ".ctf";

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
        mcr= new MWMCR(MCRComponentState.MCC_LinearSystemNameSpace_name_data,
                       MCRComponentState.MCC_LinearSystemNameSpace_root_data,
                       MCRComponentState.MCC_LinearSystemNameSpace_public_data,
                       MCRComponentState.MCC_LinearSystemNameSpace_session_data,
                       MCRComponentState.MCC_LinearSystemNameSpace_matlabpath_data,
                       MCRComponentState.MCC_LinearSystemNameSpace_classpath_data,
                       MCRComponentState.MCC_LinearSystemNameSpace_libpath_data,
                       MCRComponentState.MCC_LinearSystemNameSpace_mcr_application_options,
                       MCRComponentState.MCC_LinearSystemNameSpace_mcr_runtime_options,
                       MCRComponentState.MCC_LinearSystemNameSpace_mcr_pref_dir,
                       MCRComponentState.MCC_LinearSystemNameSpace_set_warning_state,
                       ctfFilePath, embeddedCtfStream, true);
      }
      else
      {
        throw new ApplicationException("MWArray assembly could not be initialized");
      }
    }


    /// <summary>
    /// Constructs a new instance of the LinearSystem class.
    /// </summary>
    public LinearSystem()
    {
    }


    #endregion Constructors

    #region Finalize

    /// <summary internal= "true">
    /// Class destructor called by the CLR garbage collector.
    /// </summary>
    ~LinearSystem()
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
    /// Provides a single output, 0-input Objectinterface to the mydiag M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object mydiag()
    {
      return mcr.EvaluateFunction("mydiag", new Object[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input Objectinterface to the mydiag M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="v">Input argument #1</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object mydiag(Object v)
    {
      return mcr.EvaluateFunction("mydiag", v);
    }


    /// <summary>
    /// Provides a single output, 2-input Objectinterface to the mydiag M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="v">Input argument #1</param>
    /// <param name="k">Input argument #2</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object mydiag(Object v, Object k)
    {
      return mcr.EvaluateFunction("mydiag", v, k);
    }


    /// <summary>
    /// Provides the standard 0-input Object interface to the mydiag M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] mydiag(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "mydiag", new Object[]{});
    }


    /// <summary>
    /// Provides the standard 1-input Object interface to the mydiag M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="v">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] mydiag(int numArgsOut, Object v)
    {
      return mcr.EvaluateFunction(numArgsOut, "mydiag", v);
    }


    /// <summary>
    /// Provides the standard 2-input Object interface to the mydiag M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="v">Input argument #1</param>
    /// <param name="k">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] mydiag(int numArgsOut, Object v, Object k)
    {
      return mcr.EvaluateFunction(numArgsOut, "mydiag", v, k);
    }


    /// <summary>
    /// Provides a single output, 0-input Objectinterface to the myextractmatrix
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// extract from row a to row b, and from col a to col b</remarks>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object myextractmatrix()
    {
      return mcr.EvaluateFunction("myextractmatrix", new Object[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input Objectinterface to the myextractmatrix
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// extract from row a to row b, and from col a to col b</remarks>
    /// <param name="A">Input argument #1</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object myextractmatrix(Object A)
    {
      return mcr.EvaluateFunction("myextractmatrix", A);
    }


    /// <summary>
    /// Provides a single output, 2-input Objectinterface to the myextractmatrix
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// extract from row a to row b, and from col a to col b</remarks>
    /// <param name="A">Input argument #1</param>
    /// <param name="rowa">Input argument #2</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object myextractmatrix(Object A, Object rowa)
    {
      return mcr.EvaluateFunction("myextractmatrix", A, rowa);
    }


    /// <summary>
    /// Provides a single output, 3-input Objectinterface to the myextractmatrix
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// extract from row a to row b, and from col a to col b</remarks>
    /// <param name="A">Input argument #1</param>
    /// <param name="rowa">Input argument #2</param>
    /// <param name="rowb">Input argument #3</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object myextractmatrix(Object A, Object rowa, Object rowb)
    {
      return mcr.EvaluateFunction("myextractmatrix", A, rowa, rowb);
    }


    /// <summary>
    /// Provides a single output, 4-input Objectinterface to the myextractmatrix
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// extract from row a to row b, and from col a to col b</remarks>
    /// <param name="A">Input argument #1</param>
    /// <param name="rowa">Input argument #2</param>
    /// <param name="rowb">Input argument #3</param>
    /// <param name="cola">Input argument #4</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object myextractmatrix(Object A, Object rowa, Object rowb, Object cola)
    {
      return mcr.EvaluateFunction("myextractmatrix", A, rowa, rowb, cola);
    }


    /// <summary>
    /// Provides a single output, 5-input Objectinterface to the myextractmatrix
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// extract from row a to row b, and from col a to col b</remarks>
    /// <param name="A">Input argument #1</param>
    /// <param name="rowa">Input argument #2</param>
    /// <param name="rowb">Input argument #3</param>
    /// <param name="cola">Input argument #4</param>
    /// <param name="colb">Input argument #5</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object myextractmatrix(Object A, Object rowa, Object rowb, Object cola, Object 
                            colb)
    {
      return mcr.EvaluateFunction("myextractmatrix", A, rowa, rowb, cola, colb);
    }


    /// <summary>
    /// Provides the standard 0-input Object interface to the myextractmatrix M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// extract from row a to row b, and from col a to col b</remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] myextractmatrix(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "myextractmatrix", new Object[]{});
    }


    /// <summary>
    /// Provides the standard 1-input Object interface to the myextractmatrix M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// extract from row a to row b, and from col a to col b</remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="A">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] myextractmatrix(int numArgsOut, Object A)
    {
      return mcr.EvaluateFunction(numArgsOut, "myextractmatrix", A);
    }


    /// <summary>
    /// Provides the standard 2-input Object interface to the myextractmatrix M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// extract from row a to row b, and from col a to col b</remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="A">Input argument #1</param>
    /// <param name="rowa">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] myextractmatrix(int numArgsOut, Object A, Object rowa)
    {
      return mcr.EvaluateFunction(numArgsOut, "myextractmatrix", A, rowa);
    }


    /// <summary>
    /// Provides the standard 3-input Object interface to the myextractmatrix M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// extract from row a to row b, and from col a to col b</remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="A">Input argument #1</param>
    /// <param name="rowa">Input argument #2</param>
    /// <param name="rowb">Input argument #3</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] myextractmatrix(int numArgsOut, Object A, Object rowa, Object rowb)
    {
      return mcr.EvaluateFunction(numArgsOut, "myextractmatrix", A, rowa, rowb);
    }


    /// <summary>
    /// Provides the standard 4-input Object interface to the myextractmatrix M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// extract from row a to row b, and from col a to col b</remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="A">Input argument #1</param>
    /// <param name="rowa">Input argument #2</param>
    /// <param name="rowb">Input argument #3</param>
    /// <param name="cola">Input argument #4</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] myextractmatrix(int numArgsOut, Object A, Object rowa, Object rowb, 
                              Object cola)
    {
      return mcr.EvaluateFunction(numArgsOut, "myextractmatrix", A, rowa, rowb, cola);
    }


    /// <summary>
    /// Provides the standard 5-input Object interface to the myextractmatrix M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// extract from row a to row b, and from col a to col b</remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="A">Input argument #1</param>
    /// <param name="rowa">Input argument #2</param>
    /// <param name="rowb">Input argument #3</param>
    /// <param name="cola">Input argument #4</param>
    /// <param name="colb">Input argument #5</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] myextractmatrix(int numArgsOut, Object A, Object rowa, Object rowb, 
                              Object cola, Object colb)
    {
      return mcr.EvaluateFunction(numArgsOut, "myextractmatrix", A, rowa, rowb, cola, colb);
    }


    /// <summary>
    /// Provides a single output, 0-input Objectinterface to the myfull M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object myfull()
    {
      return mcr.EvaluateFunction("myfull", new Object[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input Objectinterface to the myfull M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="S">Input argument #1</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object myfull(Object S)
    {
      return mcr.EvaluateFunction("myfull", S);
    }


    /// <summary>
    /// Provides the standard 0-input Object interface to the myfull M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] myfull(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "myfull", new Object[]{});
    }


    /// <summary>
    /// Provides the standard 1-input Object interface to the myfull M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="S">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] myfull(int numArgsOut, Object S)
    {
      return mcr.EvaluateFunction(numArgsOut, "myfull", S);
    }


    /// <summary>
    /// Provides a single output, 0-input Objectinterface to the mylu M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object mylu()
    {
      return mcr.EvaluateFunction("mylu", new Object[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input Objectinterface to the mylu M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="A">Input argument #1</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object mylu(Object A)
    {
      return mcr.EvaluateFunction("mylu", A);
    }


    /// <summary>
    /// Provides the standard 0-input Object interface to the mylu M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] mylu(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "mylu", new Object[]{});
    }


    /// <summary>
    /// Provides the standard 1-input Object interface to the mylu M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="A">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] mylu(int numArgsOut, Object A)
    {
      return mcr.EvaluateFunction(numArgsOut, "mylu", A);
    }


    /// <summary>
    /// Provides a single output, 0-input Objectinterface to the mymldivide M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// solve equation Ax = b 
    /// </remarks>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object mymldivide()
    {
      return mcr.EvaluateFunction("mymldivide", new Object[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input Objectinterface to the mymldivide M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// solve equation Ax = b 
    /// </remarks>
    /// <param name="A">Input argument #1</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object mymldivide(Object A)
    {
      return mcr.EvaluateFunction("mymldivide", A);
    }


    /// <summary>
    /// Provides a single output, 2-input Objectinterface to the mymldivide M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// solve equation Ax = b 
    /// </remarks>
    /// <param name="A">Input argument #1</param>
    /// <param name="b">Input argument #2</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object mymldivide(Object A, Object b)
    {
      return mcr.EvaluateFunction("mymldivide", A, b);
    }


    /// <summary>
    /// Provides the standard 0-input Object interface to the mymldivide M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// solve equation Ax = b 
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] mymldivide(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "mymldivide", new Object[]{});
    }


    /// <summary>
    /// Provides the standard 1-input Object interface to the mymldivide M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// solve equation Ax = b 
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="A">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] mymldivide(int numArgsOut, Object A)
    {
      return mcr.EvaluateFunction(numArgsOut, "mymldivide", A);
    }


    /// <summary>
    /// Provides the standard 2-input Object interface to the mymldivide M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// solve equation Ax = b 
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="A">Input argument #1</param>
    /// <param name="b">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] mymldivide(int numArgsOut, Object A, Object b)
    {
      return mcr.EvaluateFunction(numArgsOut, "mymldivide", A, b);
    }


    /// <summary>
    /// Provides a single output, 0-input Objectinterface to the mymrdivide M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// solve equation xA = b ==> 
    /// </remarks>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object mymrdivide()
    {
      return mcr.EvaluateFunction("mymrdivide", new Object[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input Objectinterface to the mymrdivide M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// solve equation xA = b ==> 
    /// </remarks>
    /// <param name="A">Input argument #1</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object mymrdivide(Object A)
    {
      return mcr.EvaluateFunction("mymrdivide", A);
    }


    /// <summary>
    /// Provides a single output, 2-input Objectinterface to the mymrdivide M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// solve equation xA = b ==> 
    /// </remarks>
    /// <param name="A">Input argument #1</param>
    /// <param name="b">Input argument #2</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object mymrdivide(Object A, Object b)
    {
      return mcr.EvaluateFunction("mymrdivide", A, b);
    }


    /// <summary>
    /// Provides the standard 0-input Object interface to the mymrdivide M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// solve equation xA = b ==> 
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] mymrdivide(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "mymrdivide", new Object[]{});
    }


    /// <summary>
    /// Provides the standard 1-input Object interface to the mymrdivide M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// solve equation xA = b ==> 
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="A">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] mymrdivide(int numArgsOut, Object A)
    {
      return mcr.EvaluateFunction(numArgsOut, "mymrdivide", A);
    }


    /// <summary>
    /// Provides the standard 2-input Object interface to the mymrdivide M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// solve equation xA = b ==> 
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="A">Input argument #1</param>
    /// <param name="b">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] mymrdivide(int numArgsOut, Object A, Object b)
    {
      return mcr.EvaluateFunction(numArgsOut, "mymrdivide", A, b);
    }


    /// <summary>
    /// Provides a single output, 0-input Objectinterface to the mysparse M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object mysparse()
    {
      return mcr.EvaluateFunction("mysparse", new Object[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input Objectinterface to the mysparse M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="A">Input argument #1</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object mysparse(Object A)
    {
      return mcr.EvaluateFunction("mysparse", A);
    }


    /// <summary>
    /// Provides the standard 0-input Object interface to the mysparse M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] mysparse(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "mysparse", new Object[]{});
    }


    /// <summary>
    /// Provides the standard 1-input Object interface to the mysparse M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="A">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] mysparse(int numArgsOut, Object A)
    {
      return mcr.EvaluateFunction(numArgsOut, "mysparse", A);
    }


    /// <summary>
    /// Provides a single output, 0-input Objectinterface to the myspdiags M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object myspdiags()
    {
      return mcr.EvaluateFunction("myspdiags", new Object[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input Objectinterface to the myspdiags M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="B">Input argument #1</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object myspdiags(Object B)
    {
      return mcr.EvaluateFunction("myspdiags", B);
    }


    /// <summary>
    /// Provides a single output, 2-input Objectinterface to the myspdiags M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="B">Input argument #1</param>
    /// <param name="d">Input argument #2</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object myspdiags(Object B, Object d)
    {
      return mcr.EvaluateFunction("myspdiags", B, d);
    }


    /// <summary>
    /// Provides a single output, 3-input Objectinterface to the myspdiags M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="B">Input argument #1</param>
    /// <param name="d">Input argument #2</param>
    /// <param name="m">Input argument #3</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object myspdiags(Object B, Object d, Object m)
    {
      return mcr.EvaluateFunction("myspdiags", B, d, m);
    }


    /// <summary>
    /// Provides a single output, 4-input Objectinterface to the myspdiags M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="B">Input argument #1</param>
    /// <param name="d">Input argument #2</param>
    /// <param name="m">Input argument #3</param>
    /// <param name="n">Input argument #4</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object myspdiags(Object B, Object d, Object m, Object n)
    {
      return mcr.EvaluateFunction("myspdiags", B, d, m, n);
    }


    /// <summary>
    /// Provides the standard 0-input Object interface to the myspdiags M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] myspdiags(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "myspdiags", new Object[]{});
    }


    /// <summary>
    /// Provides the standard 1-input Object interface to the myspdiags M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="B">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] myspdiags(int numArgsOut, Object B)
    {
      return mcr.EvaluateFunction(numArgsOut, "myspdiags", B);
    }


    /// <summary>
    /// Provides the standard 2-input Object interface to the myspdiags M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="B">Input argument #1</param>
    /// <param name="d">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] myspdiags(int numArgsOut, Object B, Object d)
    {
      return mcr.EvaluateFunction(numArgsOut, "myspdiags", B, d);
    }


    /// <summary>
    /// Provides the standard 3-input Object interface to the myspdiags M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="B">Input argument #1</param>
    /// <param name="d">Input argument #2</param>
    /// <param name="m">Input argument #3</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] myspdiags(int numArgsOut, Object B, Object d, Object m)
    {
      return mcr.EvaluateFunction(numArgsOut, "myspdiags", B, d, m);
    }


    /// <summary>
    /// Provides the standard 4-input Object interface to the myspdiags M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="B">Input argument #1</param>
    /// <param name="d">Input argument #2</param>
    /// <param name="m">Input argument #3</param>
    /// <param name="n">Input argument #4</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] myspdiags(int numArgsOut, Object B, Object d, Object m, Object n)
    {
      return mcr.EvaluateFunction(numArgsOut, "myspdiags", B, d, m, n);
    }


    /// <summary>
    /// Provides a single output, 0-input Objectinterface to the mytranspose M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object mytranspose()
    {
      return mcr.EvaluateFunction("mytranspose", new Object[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input Objectinterface to the mytranspose M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="x">Input argument #1</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object mytranspose(Object x)
    {
      return mcr.EvaluateFunction("mytranspose", x);
    }


    /// <summary>
    /// Provides the standard 0-input Object interface to the mytranspose M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] mytranspose(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "mytranspose", new Object[]{});
    }


    /// <summary>
    /// Provides the standard 1-input Object interface to the mytranspose M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="x">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] mytranspose(int numArgsOut, Object x)
    {
      return mcr.EvaluateFunction(numArgsOut, "mytranspose", x);
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
