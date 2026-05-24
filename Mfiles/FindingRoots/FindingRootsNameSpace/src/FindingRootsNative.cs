/*
* MATLAB Compiler: 4.11 (R2009b)
* Date: Tue Aug 17 22:14:13 2010
* Arguments: "-B" "macro_default" "-W"
* "dotnet:FindingRootsNameSpace,FindingRoots,0.0,private" "-d"
* "C:\MatlabVB\Mfiles\FindingRoots\FindingRootsNameSpace\src" "-T" "link:lib" "-v"
* "class{FindingRoots:C:\MatlabVB\Mfiles\FindingRoots\myfzero.m,C:\MatlabVB\Mfiles\Finding
* Roots\myroots.m}" 
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

namespace FindingRootsNameSpaceNative
{
  /// <summary>
  /// The FindingRoots class provides a CLS compliant, Object (native) interface to the
  /// M-functions contained in the files:
  /// <newpara></newpara>
  /// C:\MatlabVB\Mfiles\FindingRoots\myfzero.m
  /// <newpara></newpara>
  /// C:\MatlabVB\Mfiles\FindingRoots\myroots.m
  /// <newpara></newpara>
  /// deployprint.m
  /// <newpara></newpara>
  /// printdlg.m
  /// </summary>
  /// <remarks>
  /// @Version 0.0
  /// </remarks>
  public class FindingRoots : IDisposable
  {
    #region Constructors

    /// <summary internal= "true">
    /// The static constructor instantiates and initializes the MATLAB Component Runtime
    /// instance.
    /// </summary>
    static FindingRoots()
    {
      if (MWMCR.MCRAppInitialized)
      {
        Assembly assembly= Assembly.GetExecutingAssembly();

        string ctfFilePath= assembly.Location;

        int lastDelimiter= ctfFilePath.LastIndexOf(@"\");

        ctfFilePath= ctfFilePath.Remove(lastDelimiter, (ctfFilePath.Length - lastDelimiter));

        string ctfFileName = MCRComponentState.MCC_FindingRootsNameSpace_name_data + ".ctf";

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
        mcr= new MWMCR(MCRComponentState.MCC_FindingRootsNameSpace_name_data,
                       MCRComponentState.MCC_FindingRootsNameSpace_root_data,
                       MCRComponentState.MCC_FindingRootsNameSpace_public_data,
                       MCRComponentState.MCC_FindingRootsNameSpace_session_data,
                       MCRComponentState.MCC_FindingRootsNameSpace_matlabpath_data,
                       MCRComponentState.MCC_FindingRootsNameSpace_classpath_data,
                       MCRComponentState.MCC_FindingRootsNameSpace_libpath_data,
                       MCRComponentState.MCC_FindingRootsNameSpace_mcr_application_options,
                       MCRComponentState.MCC_FindingRootsNameSpace_mcr_runtime_options,
                       MCRComponentState.MCC_FindingRootsNameSpace_mcr_pref_dir,
                       MCRComponentState.MCC_FindingRootsNameSpace_set_warning_state,
                       ctfFilePath, embeddedCtfStream, true);
      }
      else
      {
        throw new ApplicationException("MWArray assembly could not be initialized");
      }
    }


    /// <summary>
    /// Constructs a new instance of the FindingRoots class.
    /// </summary>
    public FindingRoots()
    {
    }


    #endregion Constructors

    #region Finalize

    /// <summary internal= "true">
    /// Class destructor called by the CLR garbage collector.
    /// </summary>
    ~FindingRoots()
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
    /// Provides a single output, 0-input Objectinterface to the myfzero M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object myfzero()
    {
      return mcr.EvaluateFunction("myfzero", new Object[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input Objectinterface to the myfzero M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="strfunc">Input argument #1</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object myfzero(Object strfunc)
    {
      return mcr.EvaluateFunction("myfzero", strfunc);
    }


    /// <summary>
    /// Provides a single output, 2-input Objectinterface to the myfzero M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="strfunc">Input argument #1</param>
    /// <param name="x0">Input argument #2</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object myfzero(Object strfunc, Object x0)
    {
      return mcr.EvaluateFunction("myfzero", strfunc, x0);
    }


    /// <summary>
    /// Provides the standard 0-input Object interface to the myfzero M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] myfzero(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "myfzero", new Object[]{});
    }


    /// <summary>
    /// Provides the standard 1-input Object interface to the myfzero M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="strfunc">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] myfzero(int numArgsOut, Object strfunc)
    {
      return mcr.EvaluateFunction(numArgsOut, "myfzero", strfunc);
    }


    /// <summary>
    /// Provides the standard 2-input Object interface to the myfzero M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="strfunc">Input argument #1</param>
    /// <param name="x0">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] myfzero(int numArgsOut, Object strfunc, Object x0)
    {
      return mcr.EvaluateFunction(numArgsOut, "myfzero", strfunc, x0);
    }


    /// <summary>
    /// Provides a single output, 0-input Objectinterface to the myroots M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object myroots()
    {
      return mcr.EvaluateFunction("myroots", new Object[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input Objectinterface to the myroots M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="c">Input argument #1</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object myroots(Object c)
    {
      return mcr.EvaluateFunction("myroots", c);
    }


    /// <summary>
    /// Provides the standard 0-input Object interface to the myroots M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] myroots(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "myroots", new Object[]{});
    }


    /// <summary>
    /// Provides the standard 1-input Object interface to the myroots M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="c">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] myroots(int numArgsOut, Object c)
    {
      return mcr.EvaluateFunction(numArgsOut, "myroots", c);
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
