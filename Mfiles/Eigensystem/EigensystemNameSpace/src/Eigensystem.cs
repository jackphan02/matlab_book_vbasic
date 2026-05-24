/*
* MATLAB Compiler: 4.11 (R2009b)
* Date: Wed Aug 18 22:38:36 2010
* Arguments: "-B" "macro_default" "-W"
* "dotnet:EigensystemNameSpace,Eigensystem,0.0,private" "-d"
* "C:\MatlabVB\Mfiles\Eigensystem\EigensystemNameSpace\src" "-T" "link:lib" "-v"
* "class{Eigensystem:C:\MatlabVB\Mfiles\Eigensystem\myeig.m}" 
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

namespace EigensystemNameSpace
{
  /// <summary>
  /// The Eigensystem class provides a CLS compliant, MWArray interface to the
  /// M-functions contained in the files:
  /// <newpara></newpara>
  /// C:\MatlabVB\Mfiles\Eigensystem\myeig.m
  /// <newpara></newpara>
  /// deployprint.m
  /// <newpara></newpara>
  /// printdlg.m
  /// </summary>
  /// <remarks>
  /// @Version 0.0
  /// </remarks>
  public class Eigensystem : IDisposable
  {
    #region Constructors

    /// <summary internal= "true">
    /// The static constructor instantiates and initializes the MATLAB Component Runtime
    /// instance.
    /// </summary>
    static Eigensystem()
    {
      if (MWMCR.MCRAppInitialized)
      {
        Assembly assembly= Assembly.GetExecutingAssembly();

        string ctfFilePath= assembly.Location;

        int lastDelimiter= ctfFilePath.LastIndexOf(@"\");

        ctfFilePath= ctfFilePath.Remove(lastDelimiter, (ctfFilePath.Length - lastDelimiter));

        string ctfFileName = MCRComponentState.MCC_EigensystemNameSpace_name_data + ".ctf";

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
        mcr= new MWMCR(MCRComponentState.MCC_EigensystemNameSpace_name_data,
                       MCRComponentState.MCC_EigensystemNameSpace_root_data,
                       MCRComponentState.MCC_EigensystemNameSpace_public_data,
                       MCRComponentState.MCC_EigensystemNameSpace_session_data,
                       MCRComponentState.MCC_EigensystemNameSpace_matlabpath_data,
                       MCRComponentState.MCC_EigensystemNameSpace_classpath_data,
                       MCRComponentState.MCC_EigensystemNameSpace_libpath_data,
                       MCRComponentState.MCC_EigensystemNameSpace_mcr_application_options,
                       MCRComponentState.MCC_EigensystemNameSpace_mcr_runtime_options,
                       MCRComponentState.MCC_EigensystemNameSpace_mcr_pref_dir,
                       MCRComponentState.MCC_EigensystemNameSpace_set_warning_state,
                       ctfFilePath, embeddedCtfStream, true);
      }
      else
      {
        throw new ApplicationException("MWArray assembly could not be initialized");
      }
    }


    /// <summary>
    /// Constructs a new instance of the Eigensystem class.
    /// </summary>
    public Eigensystem()
    {
    }


    #endregion Constructors

    #region Finalize

    /// <summary internal= "true">
    /// Class destructor called by the CLR garbage collector.
    /// </summary>
    ~Eigensystem()
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
    /// Provides a single output, 0-input MWArrayinterface to the myeig M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray myeig()
    {
      return mcr.EvaluateFunction("myeig", new MWArray[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input MWArrayinterface to the myeig M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="A">Input argument #1</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray myeig(MWArray A)
    {
      return mcr.EvaluateFunction("myeig", A);
    }


    /// <summary>
    /// Provides the standard 0-input MWArray interface to the myeig M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] myeig(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "myeig", new MWArray[]{});
    }


    /// <summary>
    /// Provides the standard 1-input MWArray interface to the myeig M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="A">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] myeig(int numArgsOut, MWArray A)
    {
      return mcr.EvaluateFunction(numArgsOut, "myeig", A);
    }


    /// <summary>
    /// Provides an interface for the myeig function in which the input and output
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
    public void myeig(int numArgsOut, ref MWArray[] argsOut, MWArray[] argsIn)
    {
      mcr.EvaluateFunction("myeig", numArgsOut, ref argsOut, argsIn);
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
