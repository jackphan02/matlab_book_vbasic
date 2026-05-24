/*
* MATLAB Compiler: 4.11 (R2009b)
* Date: Sat Jun 19 16:01:16 2010
* Arguments: "-B" "macro_default" "-W" "dotnet:PlusNameSpace,PlusClass,0.0,private" "-d"
* "C:\MatlabVB\Mfiles\CreatingLibrary\PlusNameSpace\src" "-T" "link:lib" "-v"
* "class{PlusClass:C:\MatlabVB\Mfiles\CreatingLibrary\myplus.m}" 
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

namespace PlusNameSpaceNative
{
  /// <summary>
  /// The PlusClass class provides a CLS compliant, Object (native) interface to the
  /// M-functions contained in the files:
  /// <newpara></newpara>
  /// C:\MatlabVB\Mfiles\CreatingLibrary\myplus.m
  /// <newpara></newpara>
  /// deployprint.m
  /// <newpara></newpara>
  /// printdlg.m
  /// </summary>
  /// <remarks>
  /// @Version 0.0
  /// </remarks>
  public class PlusClass : IDisposable
  {
    #region Constructors

    /// <summary internal= "true">
    /// The static constructor instantiates and initializes the MATLAB Component Runtime
    /// instance.
    /// </summary>
    static PlusClass()
    {
      if (MWMCR.MCRAppInitialized)
      {
        Assembly assembly= Assembly.GetExecutingAssembly();

        string ctfFilePath= assembly.Location;

        int lastDelimiter= ctfFilePath.LastIndexOf(@"\");

        ctfFilePath= ctfFilePath.Remove(lastDelimiter, (ctfFilePath.Length - lastDelimiter));

        string ctfFileName = MCRComponentState.MCC_PlusNameSpace_name_data + ".ctf";

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
        mcr= new MWMCR(MCRComponentState.MCC_PlusNameSpace_name_data,
                       MCRComponentState.MCC_PlusNameSpace_root_data,
                       MCRComponentState.MCC_PlusNameSpace_public_data,
                       MCRComponentState.MCC_PlusNameSpace_session_data,
                       MCRComponentState.MCC_PlusNameSpace_matlabpath_data,
                       MCRComponentState.MCC_PlusNameSpace_classpath_data,
                       MCRComponentState.MCC_PlusNameSpace_libpath_data,
                       MCRComponentState.MCC_PlusNameSpace_mcr_application_options,
                       MCRComponentState.MCC_PlusNameSpace_mcr_runtime_options,
                       MCRComponentState.MCC_PlusNameSpace_mcr_pref_dir,
                       MCRComponentState.MCC_PlusNameSpace_set_warning_state,
                       ctfFilePath, embeddedCtfStream, true);
      }
      else
      {
        throw new ApplicationException("MWArray assembly could not be initialized");
      }
    }


    /// <summary>
    /// Constructs a new instance of the PlusClass class.
    /// </summary>
    public PlusClass()
    {
    }


    #endregion Constructors

    #region Finalize

    /// <summary internal= "true">
    /// Class destructor called by the CLR garbage collector.
    /// </summary>
    ~PlusClass()
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
    /// Provides a single output, 0-input Objectinterface to the myplus M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object myplus()
    {
      return mcr.EvaluateFunction("myplus", new Object[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input Objectinterface to the myplus M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="a">Input argument #1</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object myplus(Object a)
    {
      return mcr.EvaluateFunction("myplus", a);
    }


    /// <summary>
    /// Provides a single output, 2-input Objectinterface to the myplus M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="a">Input argument #1</param>
    /// <param name="b">Input argument #2</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object myplus(Object a, Object b)
    {
      return mcr.EvaluateFunction("myplus", a, b);
    }


    /// <summary>
    /// Provides the standard 0-input Object interface to the myplus M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] myplus(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "myplus", new Object[]{});
    }


    /// <summary>
    /// Provides the standard 1-input Object interface to the myplus M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="a">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] myplus(int numArgsOut, Object a)
    {
      return mcr.EvaluateFunction(numArgsOut, "myplus", a);
    }


    /// <summary>
    /// Provides the standard 2-input Object interface to the myplus M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="a">Input argument #1</param>
    /// <param name="b">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] myplus(int numArgsOut, Object a, Object b)
    {
      return mcr.EvaluateFunction(numArgsOut, "myplus", a, b);
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
