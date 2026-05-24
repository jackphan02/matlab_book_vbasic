/*
* MATLAB Compiler: 4.11 (R2009b)
* Date: Tue Dec 01 23:23:59 2009
* Arguments: "-B" "macro_default" "-C" "-W"
* "dotnet:MatrixMultiplicationNameSpace,MatrixMultiplication,2.0,encryption_keyfile_path,l
* ocal" "mymtimes.m" 
*/
using System;
using System.Reflection;
using MathWorks.MATLAB.NET.Arrays;
using MathWorks.MATLAB.NET.Utility;
using MathWorks.MATLAB.NET.ComponentData;

#if SHARED
[assembly: System.Reflection.AssemblyKeyFile(@"encryption_keyfile_path")]
#endif

namespace MatrixMultiplicationNameSpace
{
  /// <summary>
  /// The MatrixMultiplication class provides a CLS compliant, MWArray interface to the
  /// M-functions contained in the files:
  /// <newpara></newpara>
  /// mymtimes.m
  /// <newpara></newpara>
  /// deployprint.m
  /// <newpara></newpara>
  /// printdlg.m
  /// </summary>
  /// <remarks>
  /// @Version 2.0
  /// </remarks>
  public class MatrixMultiplication : IDisposable
  {
    #region Constructors

    /// <summary internal= "true">
    /// The static constructor instantiates and initializes the MATLAB Component Runtime
    /// instance.
    /// </summary>
    static MatrixMultiplication()
    {
      if (MWMCR.MCRAppInitialized)
      {
        Assembly assembly= Assembly.GetExecutingAssembly();

        string ctfFilePath= assembly.Location;

        int lastDelimiter= ctfFilePath.LastIndexOf(@"\");

        ctfFilePath= ctfFilePath.Remove(lastDelimiter, (ctfFilePath.Length - lastDelimiter));

        mcr= new MWMCR(MCRComponentState.MCC_MatrixMultiplicationNameSpace_name_data,
                       MCRComponentState.MCC_MatrixMultiplicationNameSpace_root_data,
                       MCRComponentState.MCC_MatrixMultiplicationNameSpace_public_data,
                       MCRComponentState.MCC_MatrixMultiplicationNameSpace_session_data,
                       MCRComponentState.MCC_MatrixMultiplicationNameSpace_matlabpath_data,
                       MCRComponentState.MCC_MatrixMultiplicationNameSpace_classpath_data,
                       MCRComponentState.MCC_MatrixMultiplicationNameSpace_libpath_data,
                       MCRComponentState.MCC_MatrixMultiplicationNameSpace_mcr_application_options,
                       MCRComponentState.MCC_MatrixMultiplicationNameSpace_mcr_runtime_options,
                       MCRComponentState.MCC_MatrixMultiplicationNameSpace_mcr_pref_dir,
                       MCRComponentState.MCC_MatrixMultiplicationNameSpace_set_warning_state,
                       ctfFilePath, true);
      }
      else
      {
        throw new ApplicationException("MWArray assembly could not be initialized");
      }
    }


    /// <summary>
    /// Constructs a new instance of the MatrixMultiplication class.
    /// </summary>
    public MatrixMultiplication()
    {
    }


    #endregion Constructors

    #region Finalize

    /// <summary internal= "true">
    /// Class destructor called by the CLR garbage collector.
    /// </summary>
    ~MatrixMultiplication()
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
    /// Provides a single output, 0-input MWArrayinterface to the mymtimes M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray mymtimes()
    {
      return mcr.EvaluateFunction("mymtimes", new MWArray[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input MWArrayinterface to the mymtimes M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="a">Input argument #1</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray mymtimes(MWArray a)
    {
      return mcr.EvaluateFunction("mymtimes", a);
    }


    /// <summary>
    /// Provides a single output, 2-input MWArrayinterface to the mymtimes M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="a">Input argument #1</param>
    /// <param name="b">Input argument #2</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray mymtimes(MWArray a, MWArray b)
    {
      return mcr.EvaluateFunction("mymtimes", a, b);
    }


    /// <summary>
    /// Provides the standard 0-input MWArray interface to the mymtimes M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] mymtimes(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "mymtimes", new MWArray[]{});
    }


    /// <summary>
    /// Provides the standard 1-input MWArray interface to the mymtimes M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="a">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] mymtimes(int numArgsOut, MWArray a)
    {
      return mcr.EvaluateFunction(numArgsOut, "mymtimes", a);
    }


    /// <summary>
    /// Provides the standard 2-input MWArray interface to the mymtimes M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="a">Input argument #1</param>
    /// <param name="b">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] mymtimes(int numArgsOut, MWArray a, MWArray b)
    {
      return mcr.EvaluateFunction(numArgsOut, "mymtimes", a, b);
    }


    /// <summary>
    /// Provides an interface for the mymtimes function in which the input and output
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
    public void mymtimes(int numArgsOut, ref MWArray[] argsOut, MWArray[] argsIn)
    {
      mcr.EvaluateFunction("mymtimes", numArgsOut, ref argsOut, argsIn);
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
