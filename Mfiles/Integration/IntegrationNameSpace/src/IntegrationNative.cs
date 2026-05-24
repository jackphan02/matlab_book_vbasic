/*
* MATLAB Compiler: 4.11 (R2009b)
* Date: Sat Aug 07 11:27:25 2010
* Arguments: "-B" "macro_default" "-W"
* "dotnet:IntegrationNameSpace,Integration,0.0,private" "-d"
* "C:\MatlabVB\Mfiles\Integration\IntegrationNameSpace\src" "-T" "link:lib" "-v"
* "class{Integration:C:\MatlabVB\Mfiles\Integration\mydblquad.m,C:\MatlabVB\Mfiles\Integra
* tion\myquad.m}" 
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

namespace IntegrationNameSpaceNative
{
  /// <summary>
  /// The Integration class provides a CLS compliant, Object (native) interface to the
  /// M-functions contained in the files:
  /// <newpara></newpara>
  /// C:\MatlabVB\Mfiles\Integration\mydblquad.m
  /// <newpara></newpara>
  /// C:\MatlabVB\Mfiles\Integration\myquad.m
  /// <newpara></newpara>
  /// deployprint.m
  /// <newpara></newpara>
  /// printdlg.m
  /// </summary>
  /// <remarks>
  /// @Version 0.0
  /// </remarks>
  public class Integration : IDisposable
  {
    #region Constructors

    /// <summary internal= "true">
    /// The static constructor instantiates and initializes the MATLAB Component Runtime
    /// instance.
    /// </summary>
    static Integration()
    {
      if (MWMCR.MCRAppInitialized)
      {
        Assembly assembly= Assembly.GetExecutingAssembly();

        string ctfFilePath= assembly.Location;

        int lastDelimiter= ctfFilePath.LastIndexOf(@"\");

        ctfFilePath= ctfFilePath.Remove(lastDelimiter, (ctfFilePath.Length - lastDelimiter));

        string ctfFileName = MCRComponentState.MCC_IntegrationNameSpace_name_data + ".ctf";

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
        mcr= new MWMCR(MCRComponentState.MCC_IntegrationNameSpace_name_data,
                       MCRComponentState.MCC_IntegrationNameSpace_root_data,
                       MCRComponentState.MCC_IntegrationNameSpace_public_data,
                       MCRComponentState.MCC_IntegrationNameSpace_session_data,
                       MCRComponentState.MCC_IntegrationNameSpace_matlabpath_data,
                       MCRComponentState.MCC_IntegrationNameSpace_classpath_data,
                       MCRComponentState.MCC_IntegrationNameSpace_libpath_data,
                       MCRComponentState.MCC_IntegrationNameSpace_mcr_application_options,
                       MCRComponentState.MCC_IntegrationNameSpace_mcr_runtime_options,
                       MCRComponentState.MCC_IntegrationNameSpace_mcr_pref_dir,
                       MCRComponentState.MCC_IntegrationNameSpace_set_warning_state,
                       ctfFilePath, embeddedCtfStream, true);
      }
      else
      {
        throw new ApplicationException("MWArray assembly could not be initialized");
      }
    }


    /// <summary>
    /// Constructs a new instance of the Integration class.
    /// </summary>
    public Integration()
    {
    }


    #endregion Constructors

    #region Finalize

    /// <summary internal= "true">
    /// Class destructor called by the CLR garbage collector.
    /// </summary>
    ~Integration()
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
    /// Provides a single output, 0-input Objectinterface to the mydblquad M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object mydblquad()
    {
      return mcr.EvaluateFunction("mydblquad", new Object[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input Objectinterface to the mydblquad M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="strfunc">Input argument #1</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object mydblquad(Object strfunc)
    {
      return mcr.EvaluateFunction("mydblquad", strfunc);
    }


    /// <summary>
    /// Provides a single output, 2-input Objectinterface to the mydblquad M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="strfunc">Input argument #1</param>
    /// <param name="x1">Input argument #2</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object mydblquad(Object strfunc, Object x1)
    {
      return mcr.EvaluateFunction("mydblquad", strfunc, x1);
    }


    /// <summary>
    /// Provides a single output, 3-input Objectinterface to the mydblquad M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="strfunc">Input argument #1</param>
    /// <param name="x1">Input argument #2</param>
    /// <param name="x2">Input argument #3</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object mydblquad(Object strfunc, Object x1, Object x2)
    {
      return mcr.EvaluateFunction("mydblquad", strfunc, x1, x2);
    }


    /// <summary>
    /// Provides a single output, 4-input Objectinterface to the mydblquad M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="strfunc">Input argument #1</param>
    /// <param name="x1">Input argument #2</param>
    /// <param name="x2">Input argument #3</param>
    /// <param name="y1">Input argument #4</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object mydblquad(Object strfunc, Object x1, Object x2, Object y1)
    {
      return mcr.EvaluateFunction("mydblquad", strfunc, x1, x2, y1);
    }


    /// <summary>
    /// Provides a single output, 5-input Objectinterface to the mydblquad M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="strfunc">Input argument #1</param>
    /// <param name="x1">Input argument #2</param>
    /// <param name="x2">Input argument #3</param>
    /// <param name="y1">Input argument #4</param>
    /// <param name="y2">Input argument #5</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object mydblquad(Object strfunc, Object x1, Object x2, Object y1, Object y2)
    {
      return mcr.EvaluateFunction("mydblquad", strfunc, x1, x2, y1, y2);
    }


    /// <summary>
    /// Provides the standard 0-input Object interface to the mydblquad M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] mydblquad(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "mydblquad", new Object[]{});
    }


    /// <summary>
    /// Provides the standard 1-input Object interface to the mydblquad M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="strfunc">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] mydblquad(int numArgsOut, Object strfunc)
    {
      return mcr.EvaluateFunction(numArgsOut, "mydblquad", strfunc);
    }


    /// <summary>
    /// Provides the standard 2-input Object interface to the mydblquad M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="strfunc">Input argument #1</param>
    /// <param name="x1">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] mydblquad(int numArgsOut, Object strfunc, Object x1)
    {
      return mcr.EvaluateFunction(numArgsOut, "mydblquad", strfunc, x1);
    }


    /// <summary>
    /// Provides the standard 3-input Object interface to the mydblquad M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="strfunc">Input argument #1</param>
    /// <param name="x1">Input argument #2</param>
    /// <param name="x2">Input argument #3</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] mydblquad(int numArgsOut, Object strfunc, Object x1, Object x2)
    {
      return mcr.EvaluateFunction(numArgsOut, "mydblquad", strfunc, x1, x2);
    }


    /// <summary>
    /// Provides the standard 4-input Object interface to the mydblquad M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="strfunc">Input argument #1</param>
    /// <param name="x1">Input argument #2</param>
    /// <param name="x2">Input argument #3</param>
    /// <param name="y1">Input argument #4</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] mydblquad(int numArgsOut, Object strfunc, Object x1, Object x2, 
                        Object y1)
    {
      return mcr.EvaluateFunction(numArgsOut, "mydblquad", strfunc, x1, x2, y1);
    }


    /// <summary>
    /// Provides the standard 5-input Object interface to the mydblquad M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="strfunc">Input argument #1</param>
    /// <param name="x1">Input argument #2</param>
    /// <param name="x2">Input argument #3</param>
    /// <param name="y1">Input argument #4</param>
    /// <param name="y2">Input argument #5</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] mydblquad(int numArgsOut, Object strfunc, Object x1, Object x2, 
                        Object y1, Object y2)
    {
      return mcr.EvaluateFunction(numArgsOut, "mydblquad", strfunc, x1, x2, y1, y2);
    }


    /// <summary>
    /// Provides a single output, 0-input Objectinterface to the myquad M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object myquad()
    {
      return mcr.EvaluateFunction("myquad", new Object[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input Objectinterface to the myquad M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="strfunc">Input argument #1</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object myquad(Object strfunc)
    {
      return mcr.EvaluateFunction("myquad", strfunc);
    }


    /// <summary>
    /// Provides a single output, 2-input Objectinterface to the myquad M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="strfunc">Input argument #1</param>
    /// <param name="a">Input argument #2</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object myquad(Object strfunc, Object a)
    {
      return mcr.EvaluateFunction("myquad", strfunc, a);
    }


    /// <summary>
    /// Provides a single output, 3-input Objectinterface to the myquad M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="strfunc">Input argument #1</param>
    /// <param name="a">Input argument #2</param>
    /// <param name="b">Input argument #3</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object myquad(Object strfunc, Object a, Object b)
    {
      return mcr.EvaluateFunction("myquad", strfunc, a, b);
    }


    /// <summary>
    /// Provides the standard 0-input Object interface to the myquad M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] myquad(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "myquad", new Object[]{});
    }


    /// <summary>
    /// Provides the standard 1-input Object interface to the myquad M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="strfunc">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] myquad(int numArgsOut, Object strfunc)
    {
      return mcr.EvaluateFunction(numArgsOut, "myquad", strfunc);
    }


    /// <summary>
    /// Provides the standard 2-input Object interface to the myquad M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="strfunc">Input argument #1</param>
    /// <param name="a">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] myquad(int numArgsOut, Object strfunc, Object a)
    {
      return mcr.EvaluateFunction(numArgsOut, "myquad", strfunc, a);
    }


    /// <summary>
    /// Provides the standard 3-input Object interface to the myquad M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="strfunc">Input argument #1</param>
    /// <param name="a">Input argument #2</param>
    /// <param name="b">Input argument #3</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] myquad(int numArgsOut, Object strfunc, Object a, Object b)
    {
      return mcr.EvaluateFunction(numArgsOut, "myquad", strfunc, a, b);
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
