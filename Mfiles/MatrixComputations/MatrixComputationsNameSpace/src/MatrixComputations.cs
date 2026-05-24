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

namespace MatrixComputationsNameSpace
{
  /// <summary>
  /// The MatrixComputations class provides a CLS compliant, MWArray interface to the
  /// M-functions contained in the files:
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
    /// Provides a single output, 0-input MWArrayinterface to the mydet M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray mydet()
    {
      return mcr.EvaluateFunction("mydet", new MWArray[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input MWArrayinterface to the mydet M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="a">Input argument #1</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray mydet(MWArray a)
    {
      return mcr.EvaluateFunction("mydet", a);
    }


    /// <summary>
    /// Provides the standard 0-input MWArray interface to the mydet M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] mydet(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "mydet", new MWArray[]{});
    }


    /// <summary>
    /// Provides the standard 1-input MWArray interface to the mydet M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="a">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] mydet(int numArgsOut, MWArray a)
    {
      return mcr.EvaluateFunction(numArgsOut, "mydet", a);
    }


    /// <summary>
    /// Provides an interface for the mydet function in which the input and output
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
    public void mydet(int numArgsOut, ref MWArray[] argsOut, MWArray[] argsIn)
    {
      mcr.EvaluateFunction("mydet", numArgsOut, ref argsOut, argsIn);
    }


    /// <summary>
    /// Provides a single output, 0-input MWArrayinterface to the myinv M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray myinv()
    {
      return mcr.EvaluateFunction("myinv", new MWArray[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input MWArrayinterface to the myinv M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="a">Input argument #1</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray myinv(MWArray a)
    {
      return mcr.EvaluateFunction("myinv", a);
    }


    /// <summary>
    /// Provides the standard 0-input MWArray interface to the myinv M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] myinv(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "myinv", new MWArray[]{});
    }


    /// <summary>
    /// Provides the standard 1-input MWArray interface to the myinv M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="a">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] myinv(int numArgsOut, MWArray a)
    {
      return mcr.EvaluateFunction(numArgsOut, "myinv", a);
    }


    /// <summary>
    /// Provides an interface for the myinv function in which the input and output
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
    public void myinv(int numArgsOut, ref MWArray[] argsOut, MWArray[] argsIn)
    {
      mcr.EvaluateFunction("myinv", numArgsOut, ref argsOut, argsIn);
    }


    /// <summary>
    /// Provides a single output, 0-input MWArrayinterface to the myminus M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray myminus()
    {
      return mcr.EvaluateFunction("myminus", new MWArray[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input MWArrayinterface to the myminus M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="a">Input argument #1</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray myminus(MWArray a)
    {
      return mcr.EvaluateFunction("myminus", a);
    }


    /// <summary>
    /// Provides a single output, 2-input MWArrayinterface to the myminus M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="a">Input argument #1</param>
    /// <param name="b">Input argument #2</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray myminus(MWArray a, MWArray b)
    {
      return mcr.EvaluateFunction("myminus", a, b);
    }


    /// <summary>
    /// Provides the standard 0-input MWArray interface to the myminus M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] myminus(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "myminus", new MWArray[]{});
    }


    /// <summary>
    /// Provides the standard 1-input MWArray interface to the myminus M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="a">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] myminus(int numArgsOut, MWArray a)
    {
      return mcr.EvaluateFunction(numArgsOut, "myminus", a);
    }


    /// <summary>
    /// Provides the standard 2-input MWArray interface to the myminus M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="a">Input argument #1</param>
    /// <param name="b">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] myminus(int numArgsOut, MWArray a, MWArray b)
    {
      return mcr.EvaluateFunction(numArgsOut, "myminus", a, b);
    }


    /// <summary>
    /// Provides an interface for the myminus function in which the input and output
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
    public void myminus(int numArgsOut, ref MWArray[] argsOut, MWArray[] argsIn)
    {
      mcr.EvaluateFunction("myminus", numArgsOut, ref argsOut, argsIn);
    }


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
    /// Provides a single output, 0-input MWArrayinterface to the myplus M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray myplus()
    {
      return mcr.EvaluateFunction("myplus", new MWArray[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input MWArrayinterface to the myplus M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="a">Input argument #1</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray myplus(MWArray a)
    {
      return mcr.EvaluateFunction("myplus", a);
    }


    /// <summary>
    /// Provides a single output, 2-input MWArrayinterface to the myplus M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="a">Input argument #1</param>
    /// <param name="b">Input argument #2</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray myplus(MWArray a, MWArray b)
    {
      return mcr.EvaluateFunction("myplus", a, b);
    }


    /// <summary>
    /// Provides the standard 0-input MWArray interface to the myplus M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] myplus(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "myplus", new MWArray[]{});
    }


    /// <summary>
    /// Provides the standard 1-input MWArray interface to the myplus M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="a">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] myplus(int numArgsOut, MWArray a)
    {
      return mcr.EvaluateFunction(numArgsOut, "myplus", a);
    }


    /// <summary>
    /// Provides the standard 2-input MWArray interface to the myplus M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="a">Input argument #1</param>
    /// <param name="b">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] myplus(int numArgsOut, MWArray a, MWArray b)
    {
      return mcr.EvaluateFunction(numArgsOut, "myplus", a, b);
    }


    /// <summary>
    /// Provides an interface for the myplus function in which the input and output
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
    public void myplus(int numArgsOut, ref MWArray[] argsOut, MWArray[] argsIn)
    {
      mcr.EvaluateFunction("myplus", numArgsOut, ref argsOut, argsIn);
    }


    /// <summary>
    /// Provides a single output, 0-input MWArrayinterface to the mytranspose M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray mytranspose()
    {
      return mcr.EvaluateFunction("mytranspose", new MWArray[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input MWArrayinterface to the mytranspose M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="x">Input argument #1</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray mytranspose(MWArray x)
    {
      return mcr.EvaluateFunction("mytranspose", x);
    }


    /// <summary>
    /// Provides the standard 0-input MWArray interface to the mytranspose M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] mytranspose(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "mytranspose", new MWArray[]{});
    }


    /// <summary>
    /// Provides the standard 1-input MWArray interface to the mytranspose M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="x">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] mytranspose(int numArgsOut, MWArray x)
    {
      return mcr.EvaluateFunction(numArgsOut, "mytranspose", x);
    }


    /// <summary>
    /// Provides an interface for the mytranspose function in which the input and output
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
    public void mytranspose(int numArgsOut, ref MWArray[] argsOut, MWArray[] argsIn)
    {
      mcr.EvaluateFunction("mytranspose", numArgsOut, ref argsOut, argsIn);
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
