/*
* MATLAB Compiler: 4.11 (R2009b)
* Date: Wed Aug 18 23:08:37 2010
* Arguments: "-B" "macro_default" "-W"
* "dotnet:RandomNumberNameSpace,RandomNumber,0.0,private" "-d"
* "C:\MatlabVB\Mfiles\RandomNumber\RandomNumberNameSpace\src" "-T" "link:lib" "-v"
* "class{RandomNumber:C:\MatlabVB\Mfiles\RandomNumber\myrand.m,C:\MatlabVB\Mfiles\RandomNu
* mber\myrandn.m}" 
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

namespace RandomNumberNameSpaceNative
{
  /// <summary>
  /// The RandomNumber class provides a CLS compliant, Object (native) interface to the
  /// M-functions contained in the files:
  /// <newpara></newpara>
  /// C:\MatlabVB\Mfiles\RandomNumber\myrand.m
  /// <newpara></newpara>
  /// C:\MatlabVB\Mfiles\RandomNumber\myrandn.m
  /// <newpara></newpara>
  /// deployprint.m
  /// <newpara></newpara>
  /// printdlg.m
  /// </summary>
  /// <remarks>
  /// @Version 0.0
  /// </remarks>
  public class RandomNumber : IDisposable
  {
    #region Constructors

    /// <summary internal= "true">
    /// The static constructor instantiates and initializes the MATLAB Component Runtime
    /// instance.
    /// </summary>
    static RandomNumber()
    {
      if (MWMCR.MCRAppInitialized)
      {
        Assembly assembly= Assembly.GetExecutingAssembly();

        string ctfFilePath= assembly.Location;

        int lastDelimiter= ctfFilePath.LastIndexOf(@"\");

        ctfFilePath= ctfFilePath.Remove(lastDelimiter, (ctfFilePath.Length - lastDelimiter));

        string ctfFileName = MCRComponentState.MCC_RandomNumberNameSpace_name_data + ".ctf";

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
        mcr= new MWMCR(MCRComponentState.MCC_RandomNumberNameSpace_name_data,
                       MCRComponentState.MCC_RandomNumberNameSpace_root_data,
                       MCRComponentState.MCC_RandomNumberNameSpace_public_data,
                       MCRComponentState.MCC_RandomNumberNameSpace_session_data,
                       MCRComponentState.MCC_RandomNumberNameSpace_matlabpath_data,
                       MCRComponentState.MCC_RandomNumberNameSpace_classpath_data,
                       MCRComponentState.MCC_RandomNumberNameSpace_libpath_data,
                       MCRComponentState.MCC_RandomNumberNameSpace_mcr_application_options,
                       MCRComponentState.MCC_RandomNumberNameSpace_mcr_runtime_options,
                       MCRComponentState.MCC_RandomNumberNameSpace_mcr_pref_dir,
                       MCRComponentState.MCC_RandomNumberNameSpace_set_warning_state,
                       ctfFilePath, embeddedCtfStream, true);
      }
      else
      {
        throw new ApplicationException("MWArray assembly could not be initialized");
      }
    }


    /// <summary>
    /// Constructs a new instance of the RandomNumber class.
    /// </summary>
    public RandomNumber()
    {
    }


    #endregion Constructors

    #region Finalize

    /// <summary internal= "true">
    /// Class destructor called by the CLR garbage collector.
    /// </summary>
    ~RandomNumber()
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
    /// Provides a single output, 0-input Objectinterface to the myrand M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object myrand()
    {
      return mcr.EvaluateFunction("myrand", new Object[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input Objectinterface to the myrand M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="m">Input argument #1</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object myrand(Object m)
    {
      return mcr.EvaluateFunction("myrand", m);
    }


    /// <summary>
    /// Provides a single output, 2-input Objectinterface to the myrand M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="m">Input argument #1</param>
    /// <param name="n">Input argument #2</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object myrand(Object m, Object n)
    {
      return mcr.EvaluateFunction("myrand", m, n);
    }


    /// <summary>
    /// Provides the standard 0-input Object interface to the myrand M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] myrand(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "myrand", new Object[]{});
    }


    /// <summary>
    /// Provides the standard 1-input Object interface to the myrand M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="m">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] myrand(int numArgsOut, Object m)
    {
      return mcr.EvaluateFunction(numArgsOut, "myrand", m);
    }


    /// <summary>
    /// Provides the standard 2-input Object interface to the myrand M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="m">Input argument #1</param>
    /// <param name="n">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] myrand(int numArgsOut, Object m, Object n)
    {
      return mcr.EvaluateFunction(numArgsOut, "myrand", m, n);
    }


    /// <summary>
    /// Provides a single output, 0-input Objectinterface to the myrandn M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object myrandn()
    {
      return mcr.EvaluateFunction("myrandn", new Object[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input Objectinterface to the myrandn M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="m">Input argument #1</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object myrandn(Object m)
    {
      return mcr.EvaluateFunction("myrandn", m);
    }


    /// <summary>
    /// Provides a single output, 2-input Objectinterface to the myrandn M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="m">Input argument #1</param>
    /// <param name="n">Input argument #2</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object myrandn(Object m, Object n)
    {
      return mcr.EvaluateFunction("myrandn", m, n);
    }


    /// <summary>
    /// Provides the standard 0-input Object interface to the myrandn M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] myrandn(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "myrandn", new Object[]{});
    }


    /// <summary>
    /// Provides the standard 1-input Object interface to the myrandn M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="m">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] myrandn(int numArgsOut, Object m)
    {
      return mcr.EvaluateFunction(numArgsOut, "myrandn", m);
    }


    /// <summary>
    /// Provides the standard 2-input Object interface to the myrandn M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="m">Input argument #1</param>
    /// <param name="n">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] myrandn(int numArgsOut, Object m, Object n)
    {
      return mcr.EvaluateFunction(numArgsOut, "myrandn", m, n);
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
