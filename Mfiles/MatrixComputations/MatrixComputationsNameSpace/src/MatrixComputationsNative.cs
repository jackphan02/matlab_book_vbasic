/*
* MATLAB Compiler: 4.11 (R2009b)
* Date: Sun Jun 20 16:59:06 2010
* Arguments: "-B" "macro_default" "-W"
* "dotnet:MatrixComputationsNameSpace,MatrixComputations,0.0,private" "-d"
* "C:\MatlabVB\Mfiles\MatrixComputations\MatrixComputationsNameSpace\src" "-T" "link:lib"
* "-v"
* "class{MatrixComputations:C:\MatlabVB\Mfiles\MatrixComputations\mydet.m,C:\MatlabVB\Mfil
* es\MatrixComputations\myinv.m,C:\MatlabVB\Mfiles\MatrixComputations\myminus.m,C:\MatlabV
* B\Mfiles\MatrixComputations\mymtimes.m,C:\MatlabVB\Mfiles\MatrixComputations\myplus.m,C:
* \MatlabVB\Mfiles\MatrixComputations\mytranspose.m}" 
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

namespace MatrixComputationsNameSpaceNative
{
  /// <summary>
  /// The MatrixComputations class provides a CLS compliant, Object (native) interface to
  /// the M-functions contained in the files:
  /// <newpara></newpara>
  /// C:\MatlabVB\Mfiles\MatrixComputations\mydet.m
  /// <newpara></newpara>
  /// C:\MatlabVB\Mfiles\MatrixComputations\myinv.m
  /// <newpara></newpara>
  /// C:\MatlabVB\Mfiles\MatrixComputations\myminus.m
  /// <newpara></newpara>
  /// C:\MatlabVB\Mfiles\MatrixComputations\mymtimes.m
  /// <newpara></newpara>
  /// C:\MatlabVB\Mfiles\MatrixComputations\myplus.m
  /// <newpara></newpara>
  /// C:\MatlabVB\Mfiles\MatrixComputations\mytranspose.m
  /// <newpara></newpara>
  /// deployprint.m
  /// <newpara></newpara>
  /// printdlg.m
  /// </summary>
  /// <remarks>
  /// @Version 0.0
  /// </remarks>
  public class MatrixComputations : IDisposable
  {
    #region Constructors

    /// <summary internal= "true">
    /// The static constructor instantiates and initializes the MATLAB Component Runtime
    /// instance.
    /// </summary>
    static MatrixComputations()
    {
      if (MWMCR.MCRAppInitialized)
      {
        Assembly assembly= Assembly.GetExecutingAssembly();

        string ctfFilePath= assembly.Location;

        int lastDelimiter= ctfFilePath.LastIndexOf(@"\");

        ctfFilePath= ctfFilePath.Remove(lastDelimiter, (ctfFilePath.Length - lastDelimiter));

        string ctfFileName = MCRComponentState.MCC_MatrixComputationsNameSpace_name_data + ".ctf";

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
        mcr= new MWMCR(MCRComponentState.MCC_MatrixComputationsNameSpace_name_data,
                       MCRComponentState.MCC_MatrixComputationsNameSpace_root_data,
                       MCRComponentState.MCC_MatrixComputationsNameSpace_public_data,
                       MCRComponentState.MCC_MatrixComputationsNameSpace_session_data,
                       MCRComponentState.MCC_MatrixComputationsNameSpace_matlabpath_data,
                       MCRComponentState.MCC_MatrixComputationsNameSpace_classpath_data,
                       MCRComponentState.MCC_MatrixComputationsNameSpace_libpath_data,
                       MCRComponentState.MCC_MatrixComputationsNameSpace_mcr_application_options,
                       MCRComponentState.MCC_MatrixComputationsNameSpace_mcr_runtime_options,
                       MCRComponentState.MCC_MatrixComputationsNameSpace_mcr_pref_dir,
                       MCRComponentState.MCC_MatrixComputationsNameSpace_set_warning_state,
                       ctfFilePath, embeddedCtfStream, true);
      }
      else
      {
        throw new ApplicationException("MWArray assembly could not be initialized");
      }
    }


    /// <summary>
    /// Constructs a new instance of the MatrixComputations class.
    /// </summary>
    public MatrixComputations()
    {
    }


    #endregion Constructors

    #region Finalize

    /// <summary internal= "true">
    /// Class destructor called by the CLR garbage collector.
    /// </summary>
    ~MatrixComputations()
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
    /// Provides a single output, 0-input Objectinterface to the mydet M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object mydet()
    {
      return mcr.EvaluateFunction("mydet", new Object[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input Objectinterface to the mydet M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="a">Input argument #1</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object mydet(Object a)
    {
      return mcr.EvaluateFunction("mydet", a);
    }


    /// <summary>
    /// Provides the standard 0-input Object interface to the mydet M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] mydet(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "mydet", new Object[]{});
    }


    /// <summary>
    /// Provides the standard 1-input Object interface to the mydet M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="a">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] mydet(int numArgsOut, Object a)
    {
      return mcr.EvaluateFunction(numArgsOut, "mydet", a);
    }


    /// <summary>
    /// Provides a single output, 0-input Objectinterface to the myinv M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object myinv()
    {
      return mcr.EvaluateFunction("myinv", new Object[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input Objectinterface to the myinv M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="a">Input argument #1</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object myinv(Object a)
    {
      return mcr.EvaluateFunction("myinv", a);
    }


    /// <summary>
    /// Provides the standard 0-input Object interface to the myinv M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] myinv(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "myinv", new Object[]{});
    }


    /// <summary>
    /// Provides the standard 1-input Object interface to the myinv M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="a">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] myinv(int numArgsOut, Object a)
    {
      return mcr.EvaluateFunction(numArgsOut, "myinv", a);
    }


    /// <summary>
    /// Provides a single output, 0-input Objectinterface to the myminus M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object myminus()
    {
      return mcr.EvaluateFunction("myminus", new Object[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input Objectinterface to the myminus M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="a">Input argument #1</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object myminus(Object a)
    {
      return mcr.EvaluateFunction("myminus", a);
    }


    /// <summary>
    /// Provides a single output, 2-input Objectinterface to the myminus M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="a">Input argument #1</param>
    /// <param name="b">Input argument #2</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object myminus(Object a, Object b)
    {
      return mcr.EvaluateFunction("myminus", a, b);
    }


    /// <summary>
    /// Provides the standard 0-input Object interface to the myminus M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] myminus(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "myminus", new Object[]{});
    }


    /// <summary>
    /// Provides the standard 1-input Object interface to the myminus M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="a">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] myminus(int numArgsOut, Object a)
    {
      return mcr.EvaluateFunction(numArgsOut, "myminus", a);
    }


    /// <summary>
    /// Provides the standard 2-input Object interface to the myminus M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="a">Input argument #1</param>
    /// <param name="b">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] myminus(int numArgsOut, Object a, Object b)
    {
      return mcr.EvaluateFunction(numArgsOut, "myminus", a, b);
    }


    /// <summary>
    /// Provides a single output, 0-input Objectinterface to the mymtimes M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object mymtimes()
    {
      return mcr.EvaluateFunction("mymtimes", new Object[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input Objectinterface to the mymtimes M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="a">Input argument #1</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object mymtimes(Object a)
    {
      return mcr.EvaluateFunction("mymtimes", a);
    }


    /// <summary>
    /// Provides a single output, 2-input Objectinterface to the mymtimes M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="a">Input argument #1</param>
    /// <param name="b">Input argument #2</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object mymtimes(Object a, Object b)
    {
      return mcr.EvaluateFunction("mymtimes", a, b);
    }


    /// <summary>
    /// Provides the standard 0-input Object interface to the mymtimes M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] mymtimes(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "mymtimes", new Object[]{});
    }


    /// <summary>
    /// Provides the standard 1-input Object interface to the mymtimes M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="a">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] mymtimes(int numArgsOut, Object a)
    {
      return mcr.EvaluateFunction(numArgsOut, "mymtimes", a);
    }


    /// <summary>
    /// Provides the standard 2-input Object interface to the mymtimes M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="a">Input argument #1</param>
    /// <param name="b">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] mymtimes(int numArgsOut, Object a, Object b)
    {
      return mcr.EvaluateFunction(numArgsOut, "mymtimes", a, b);
    }


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
