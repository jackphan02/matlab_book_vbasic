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

namespace ODENameSpaceNative
{
  /// <summary>
  /// The Class1 class provides a CLS compliant, Object (native) interface to the
  /// M-functions contained in the files:
  /// </summary>
  /// <remarks>
  /// @Version 0.0
  /// </remarks>
  public class Class1 : IDisposable
  {
    #region Constructors

    /// <summary internal= "true">
    /// The static constructor instantiates and initializes the MATLAB Component Runtime
    /// instance.
    /// </summary>
    static Class1()
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
    /// Constructs a new instance of the Class1 class.
    /// </summary>
    public Class1()
    {
    }


    #endregion Constructors

    #region Finalize

    /// <summary internal= "true">
    /// Class destructor called by the CLR garbage collector.
    /// </summary>
    ~Class1()
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
