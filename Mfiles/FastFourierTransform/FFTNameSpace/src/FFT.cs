/*
* MATLAB Compiler: 4.11 (R2009b)
* Date: Tue Aug 17 23:34:51 2010
* Arguments: "-B" "macro_default" "-W" "dotnet:FFTNameSpace,FFT,0.0,private" "-d"
* "C:\MatlabVB\Mfiles\FastFourierTransform\FFTNameSpace\src" "-T" "link:lib" "-v"
* "class{FFT:C:\MatlabVB\Mfiles\FastFourierTransform\myfft.m,C:\MatlabVB\Mfiles\FastFourie
* rTransform\myfft2.m,C:\MatlabVB\Mfiles\FastFourierTransform\myifft.m,C:\MatlabVB\Mfiles\
* FastFourierTransform\myifft2.m}" 
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

namespace FFTNameSpace
{
  /// <summary>
  /// The FFT class provides a CLS compliant, MWArray interface to the M-functions
  /// contained in the files:
  /// <newpara></newpara>
  /// C:\MatlabVB\Mfiles\FastFourierTransform\myfft.m
  /// <newpara></newpara>
  /// C:\MatlabVB\Mfiles\FastFourierTransform\myfft2.m
  /// <newpara></newpara>
  /// C:\MatlabVB\Mfiles\FastFourierTransform\myifft.m
  /// <newpara></newpara>
  /// C:\MatlabVB\Mfiles\FastFourierTransform\myifft2.m
  /// <newpara></newpara>
  /// deployprint.m
  /// <newpara></newpara>
  /// printdlg.m
  /// </summary>
  /// <remarks>
  /// @Version 0.0
  /// </remarks>
  public class FFT : IDisposable
  {
    #region Constructors

    /// <summary internal= "true">
    /// The static constructor instantiates and initializes the MATLAB Component Runtime
    /// instance.
    /// </summary>
    static FFT()
    {
      if (MWMCR.MCRAppInitialized)
      {
        Assembly assembly= Assembly.GetExecutingAssembly();

        string ctfFilePath= assembly.Location;

        int lastDelimiter= ctfFilePath.LastIndexOf(@"\");

        ctfFilePath= ctfFilePath.Remove(lastDelimiter, (ctfFilePath.Length - lastDelimiter));

        string ctfFileName = MCRComponentState.MCC_FFTNameSpace_name_data + ".ctf";

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
        mcr= new MWMCR(MCRComponentState.MCC_FFTNameSpace_name_data,
                       MCRComponentState.MCC_FFTNameSpace_root_data,
                       MCRComponentState.MCC_FFTNameSpace_public_data,
                       MCRComponentState.MCC_FFTNameSpace_session_data,
                       MCRComponentState.MCC_FFTNameSpace_matlabpath_data,
                       MCRComponentState.MCC_FFTNameSpace_classpath_data,
                       MCRComponentState.MCC_FFTNameSpace_libpath_data,
                       MCRComponentState.MCC_FFTNameSpace_mcr_application_options,
                       MCRComponentState.MCC_FFTNameSpace_mcr_runtime_options,
                       MCRComponentState.MCC_FFTNameSpace_mcr_pref_dir,
                       MCRComponentState.MCC_FFTNameSpace_set_warning_state,
                       ctfFilePath, embeddedCtfStream, true);
      }
      else
      {
        throw new ApplicationException("MWArray assembly could not be initialized");
      }
    }


    /// <summary>
    /// Constructs a new instance of the FFT class.
    /// </summary>
    public FFT()
    {
    }


    #endregion Constructors

    #region Finalize

    /// <summary internal= "true">
    /// Class destructor called by the CLR garbage collector.
    /// </summary>
    ~FFT()
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
    /// Provides a single output, 0-input MWArrayinterface to the myfft M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray myfft()
    {
      return mcr.EvaluateFunction("myfft", new MWArray[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input MWArrayinterface to the myfft M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="X">Input argument #1</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray myfft(MWArray X)
    {
      return mcr.EvaluateFunction("myfft", X);
    }


    /// <summary>
    /// Provides the standard 0-input MWArray interface to the myfft M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] myfft(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "myfft", new MWArray[]{});
    }


    /// <summary>
    /// Provides the standard 1-input MWArray interface to the myfft M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="X">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] myfft(int numArgsOut, MWArray X)
    {
      return mcr.EvaluateFunction(numArgsOut, "myfft", X);
    }


    /// <summary>
    /// Provides an interface for the myfft function in which the input and output
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
    public void myfft(int numArgsOut, ref MWArray[] argsOut, MWArray[] argsIn)
    {
      mcr.EvaluateFunction("myfft", numArgsOut, ref argsOut, argsIn);
    }


    /// <summary>
    /// Provides a single output, 0-input MWArrayinterface to the myfft2 M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray myfft2()
    {
      return mcr.EvaluateFunction("myfft2", new MWArray[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input MWArrayinterface to the myfft2 M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="X">Input argument #1</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray myfft2(MWArray X)
    {
      return mcr.EvaluateFunction("myfft2", X);
    }


    /// <summary>
    /// Provides the standard 0-input MWArray interface to the myfft2 M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] myfft2(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "myfft2", new MWArray[]{});
    }


    /// <summary>
    /// Provides the standard 1-input MWArray interface to the myfft2 M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="X">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] myfft2(int numArgsOut, MWArray X)
    {
      return mcr.EvaluateFunction(numArgsOut, "myfft2", X);
    }


    /// <summary>
    /// Provides an interface for the myfft2 function in which the input and output
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
    public void myfft2(int numArgsOut, ref MWArray[] argsOut, MWArray[] argsIn)
    {
      mcr.EvaluateFunction("myfft2", numArgsOut, ref argsOut, argsIn);
    }


    /// <summary>
    /// Provides a single output, 0-input MWArrayinterface to the myifft M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray myifft()
    {
      return mcr.EvaluateFunction("myifft", new MWArray[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input MWArrayinterface to the myifft M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="X">Input argument #1</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray myifft(MWArray X)
    {
      return mcr.EvaluateFunction("myifft", X);
    }


    /// <summary>
    /// Provides the standard 0-input MWArray interface to the myifft M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] myifft(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "myifft", new MWArray[]{});
    }


    /// <summary>
    /// Provides the standard 1-input MWArray interface to the myifft M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="X">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] myifft(int numArgsOut, MWArray X)
    {
      return mcr.EvaluateFunction(numArgsOut, "myifft", X);
    }


    /// <summary>
    /// Provides an interface for the myifft function in which the input and output
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
    public void myifft(int numArgsOut, ref MWArray[] argsOut, MWArray[] argsIn)
    {
      mcr.EvaluateFunction("myifft", numArgsOut, ref argsOut, argsIn);
    }


    /// <summary>
    /// Provides a single output, 0-input MWArrayinterface to the myifft2 M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray myifft2()
    {
      return mcr.EvaluateFunction("myifft2", new MWArray[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input MWArrayinterface to the myifft2 M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="X">Input argument #1</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray myifft2(MWArray X)
    {
      return mcr.EvaluateFunction("myifft2", X);
    }


    /// <summary>
    /// Provides the standard 0-input MWArray interface to the myifft2 M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] myifft2(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "myifft2", new MWArray[]{});
    }


    /// <summary>
    /// Provides the standard 1-input MWArray interface to the myifft2 M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="X">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] myifft2(int numArgsOut, MWArray X)
    {
      return mcr.EvaluateFunction(numArgsOut, "myifft2", X);
    }


    /// <summary>
    /// Provides an interface for the myifft2 function in which the input and output
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
    public void myifft2(int numArgsOut, ref MWArray[] argsOut, MWArray[] argsIn)
    {
      mcr.EvaluateFunction("myifft2", numArgsOut, ref argsOut, argsIn);
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
