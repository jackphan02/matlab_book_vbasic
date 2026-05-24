/*
* MATLAB Compiler: 4.11 (R2009b)
* Date: Sun Aug 15 12:00:10 2010
* Arguments: "-B" "macro_default" "-W"
* "dotnet:CurveFittingNameSpace,CurveFitting,0.0,private" "-d"
* "C:\MatlabVB\Mfiles\CurveFitting\CurveFittingNameSpace\src" "-T" "link:lib" "-v"
* "class{CurveFitting:C:\MatlabVB\Mfiles\CurveFitting\CurveFittings.m,C:\MatlabVB\Mfiles\C
* urveFitting\CurveFittingWithPlots.m,C:\MatlabVB\Mfiles\CurveFitting\CurveFittingWithPlot
* sAdvance.m,C:\MatlabVB\Mfiles\CurveFitting\mytextread.m,C:\MatlabVB\Mfiles\CurveFitting\
* mytranspose.m}" 
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

namespace CurveFittingNameSpaceNative
{
  /// <summary>
  /// The CurveFitting class provides a CLS compliant, Object (native) interface to the
  /// M-functions contained in the files:
  /// <newpara></newpara>
  /// C:\MatlabVB\Mfiles\CurveFitting\CurveFittings.m
  /// <newpara></newpara>
  /// C:\MatlabVB\Mfiles\CurveFitting\CurveFittingWithPlots.m
  /// <newpara></newpara>
  /// C:\MatlabVB\Mfiles\CurveFitting\CurveFittingWithPlotsAdvance.m
  /// <newpara></newpara>
  /// C:\MatlabVB\Mfiles\CurveFitting\mytextread.m
  /// <newpara></newpara>
  /// C:\MatlabVB\Mfiles\CurveFitting\mytranspose.m
  /// <newpara></newpara>
  /// deployprint.m
  /// <newpara></newpara>
  /// printdlg.m
  /// </summary>
  /// <remarks>
  /// @Version 0.0
  /// </remarks>
  public class CurveFitting : IDisposable
  {
    #region Constructors

    /// <summary internal= "true">
    /// The static constructor instantiates and initializes the MATLAB Component Runtime
    /// instance.
    /// </summary>
    static CurveFitting()
    {
      if (MWMCR.MCRAppInitialized)
      {
        Assembly assembly= Assembly.GetExecutingAssembly();

        string ctfFilePath= assembly.Location;

        int lastDelimiter= ctfFilePath.LastIndexOf(@"\");

        ctfFilePath= ctfFilePath.Remove(lastDelimiter, (ctfFilePath.Length - lastDelimiter));

        string ctfFileName = MCRComponentState.MCC_CurveFittingNameSpace_name_data + ".ctf";

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
        mcr= new MWMCR(MCRComponentState.MCC_CurveFittingNameSpace_name_data,
                       MCRComponentState.MCC_CurveFittingNameSpace_root_data,
                       MCRComponentState.MCC_CurveFittingNameSpace_public_data,
                       MCRComponentState.MCC_CurveFittingNameSpace_session_data,
                       MCRComponentState.MCC_CurveFittingNameSpace_matlabpath_data,
                       MCRComponentState.MCC_CurveFittingNameSpace_classpath_data,
                       MCRComponentState.MCC_CurveFittingNameSpace_libpath_data,
                       MCRComponentState.MCC_CurveFittingNameSpace_mcr_application_options,
                       MCRComponentState.MCC_CurveFittingNameSpace_mcr_runtime_options,
                       MCRComponentState.MCC_CurveFittingNameSpace_mcr_pref_dir,
                       MCRComponentState.MCC_CurveFittingNameSpace_set_warning_state,
                       ctfFilePath, embeddedCtfStream, true);
      }
      else
      {
        throw new ApplicationException("MWArray assembly could not be initialized");
      }
    }


    /// <summary>
    /// Constructs a new instance of the CurveFitting class.
    /// </summary>
    public CurveFitting()
    {
    }


    #endregion Constructors

    #region Finalize

    /// <summary internal= "true">
    /// Class destructor called by the CLR garbage collector.
    /// </summary>
    ~CurveFitting()
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
    /// Provides a void output, 0-input Objectinterface to the CurveFittings M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    ///
    public void CurveFittings()
    {
      mcr.EvaluateFunction(0, "CurveFittings", new Object[]{});
    }


    /// <summary>
    /// Provides a void output, 1-input Objectinterface to the CurveFittings M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="x">Input argument #1</param>
    ///
    public void CurveFittings(Object x)
    {
      mcr.EvaluateFunction(0, "CurveFittings", x);
    }


    /// <summary>
    /// Provides a void output, 2-input Objectinterface to the CurveFittings M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="x">Input argument #1</param>
    /// <param name="y">Input argument #2</param>
    ///
    public void CurveFittings(Object x, Object y)
    {
      mcr.EvaluateFunction(0, "CurveFittings", x, y);
    }


    /// <summary>
    /// Provides a void output, 3-input Objectinterface to the CurveFittings M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="x">Input argument #1</param>
    /// <param name="y">Input argument #2</param>
    /// <param name="cftLib">Input argument #3</param>
    ///
    public void CurveFittings(Object x, Object y, Object cftLib)
    {
      mcr.EvaluateFunction(0, "CurveFittings", x, y, cftLib);
    }


    /// <summary>
    /// Provides the standard 0-input Object interface to the CurveFittings M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] CurveFittings(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "CurveFittings", new Object[]{});
    }


    /// <summary>
    /// Provides the standard 1-input Object interface to the CurveFittings M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="x">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] CurveFittings(int numArgsOut, Object x)
    {
      return mcr.EvaluateFunction(numArgsOut, "CurveFittings", x);
    }


    /// <summary>
    /// Provides the standard 2-input Object interface to the CurveFittings M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="x">Input argument #1</param>
    /// <param name="y">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] CurveFittings(int numArgsOut, Object x, Object y)
    {
      return mcr.EvaluateFunction(numArgsOut, "CurveFittings", x, y);
    }


    /// <summary>
    /// Provides the standard 3-input Object interface to the CurveFittings M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="x">Input argument #1</param>
    /// <param name="y">Input argument #2</param>
    /// <param name="cftLib">Input argument #3</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] CurveFittings(int numArgsOut, Object x, Object y, Object cftLib)
    {
      return mcr.EvaluateFunction(numArgsOut, "CurveFittings", x, y, cftLib);
    }


    /// <summary>
    /// Provides a void output, 0-input Objectinterface to the CurveFittingWithPlots
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Curve fit data                     
    /// </remarks>
    ///
    public void CurveFittingWithPlots()
    {
      mcr.EvaluateFunction(0, "CurveFittingWithPlots", new Object[]{});
    }


    /// <summary>
    /// Provides a void output, 1-input Objectinterface to the CurveFittingWithPlots
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Curve fit data                     
    /// </remarks>
    /// <param name="x">Input argument #1</param>
    ///
    public void CurveFittingWithPlots(Object x)
    {
      mcr.EvaluateFunction(0, "CurveFittingWithPlots", x);
    }


    /// <summary>
    /// Provides a void output, 2-input Objectinterface to the CurveFittingWithPlots
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Curve fit data                     
    /// </remarks>
    /// <param name="x">Input argument #1</param>
    /// <param name="y">Input argument #2</param>
    ///
    public void CurveFittingWithPlots(Object x, Object y)
    {
      mcr.EvaluateFunction(0, "CurveFittingWithPlots", x, y);
    }


    /// <summary>
    /// Provides a void output, 3-input Objectinterface to the CurveFittingWithPlots
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Curve fit data                     
    /// </remarks>
    /// <param name="x">Input argument #1</param>
    /// <param name="y">Input argument #2</param>
    /// <param name="cftLib">Input argument #3</param>
    ///
    public void CurveFittingWithPlots(Object x, Object y, Object cftLib)
    {
      mcr.EvaluateFunction(0, "CurveFittingWithPlots", x, y, cftLib);
    }


    /// <summary>
    /// Provides the standard 0-input Object interface to the CurveFittingWithPlots
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Curve fit data                     
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] CurveFittingWithPlots(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "CurveFittingWithPlots", new Object[]{});
    }


    /// <summary>
    /// Provides the standard 1-input Object interface to the CurveFittingWithPlots
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Curve fit data                     
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="x">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] CurveFittingWithPlots(int numArgsOut, Object x)
    {
      return mcr.EvaluateFunction(numArgsOut, "CurveFittingWithPlots", x);
    }


    /// <summary>
    /// Provides the standard 2-input Object interface to the CurveFittingWithPlots
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Curve fit data                     
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="x">Input argument #1</param>
    /// <param name="y">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] CurveFittingWithPlots(int numArgsOut, Object x, Object y)
    {
      return mcr.EvaluateFunction(numArgsOut, "CurveFittingWithPlots", x, y);
    }


    /// <summary>
    /// Provides the standard 3-input Object interface to the CurveFittingWithPlots
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Curve fit data                     
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="x">Input argument #1</param>
    /// <param name="y">Input argument #2</param>
    /// <param name="cftLib">Input argument #3</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] CurveFittingWithPlots(int numArgsOut, Object x, Object y, Object 
                                    cftLib)
    {
      return mcr.EvaluateFunction(numArgsOut, "CurveFittingWithPlots", x, y, cftLib);
    }


    /// <summary>
    /// Provides a void output, 0-input Objectinterface to the
    /// CurveFittingWithPlotsAdvance M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Curve fit data                     
    /// </remarks>
    ///
    public void CurveFittingWithPlotsAdvance()
    {
      mcr.EvaluateFunction(0, "CurveFittingWithPlotsAdvance", new Object[]{});
    }


    /// <summary>
    /// Provides a void output, 1-input Objectinterface to the
    /// CurveFittingWithPlotsAdvance M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Curve fit data                     
    /// </remarks>
    /// <param name="x">Input argument #1</param>
    ///
    public void CurveFittingWithPlotsAdvance(Object x)
    {
      mcr.EvaluateFunction(0, "CurveFittingWithPlotsAdvance", x);
    }


    /// <summary>
    /// Provides a void output, 2-input Objectinterface to the
    /// CurveFittingWithPlotsAdvance M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Curve fit data                     
    /// </remarks>
    /// <param name="x">Input argument #1</param>
    /// <param name="y">Input argument #2</param>
    ///
    public void CurveFittingWithPlotsAdvance(Object x, Object y)
    {
      mcr.EvaluateFunction(0, "CurveFittingWithPlotsAdvance", x, y);
    }


    /// <summary>
    /// Provides a void output, 3-input Objectinterface to the
    /// CurveFittingWithPlotsAdvance M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Curve fit data                     
    /// </remarks>
    /// <param name="x">Input argument #1</param>
    /// <param name="y">Input argument #2</param>
    /// <param name="cftLib">Input argument #3</param>
    ///
    public void CurveFittingWithPlotsAdvance(Object x, Object y, Object cftLib)
    {
      mcr.EvaluateFunction(0, "CurveFittingWithPlotsAdvance", x, y, cftLib);
    }


    /// <summary>
    /// Provides a void output, 4-input Objectinterface to the
    /// CurveFittingWithPlotsAdvance M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Curve fit data                     
    /// </remarks>
    /// <param name="x">Input argument #1</param>
    /// <param name="y">Input argument #2</param>
    /// <param name="cftLib">Input argument #3</param>
    /// <param name="graTitle">Input argument #4</param>
    ///
    public void CurveFittingWithPlotsAdvance(Object x, Object y, Object cftLib, Object 
                                       graTitle)
    {
      mcr.EvaluateFunction(0, "CurveFittingWithPlotsAdvance", x, y, cftLib, graTitle);
    }


    /// <summary>
    /// Provides a void output, 5-input Objectinterface to the
    /// CurveFittingWithPlotsAdvance M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Curve fit data                     
    /// </remarks>
    /// <param name="x">Input argument #1</param>
    /// <param name="y">Input argument #2</param>
    /// <param name="cftLib">Input argument #3</param>
    /// <param name="graTitle">Input argument #4</param>
    /// <param name="xlab">Input argument #5</param>
    ///
    public void CurveFittingWithPlotsAdvance(Object x, Object y, Object cftLib, Object 
                                       graTitle, Object xlab)
    {
      mcr.EvaluateFunction(0, "CurveFittingWithPlotsAdvance", x, y, cftLib, graTitle, xlab);
    }


    /// <summary>
    /// Provides a void output, 6-input Objectinterface to the
    /// CurveFittingWithPlotsAdvance M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Curve fit data                     
    /// </remarks>
    /// <param name="x">Input argument #1</param>
    /// <param name="y">Input argument #2</param>
    /// <param name="cftLib">Input argument #3</param>
    /// <param name="graTitle">Input argument #4</param>
    /// <param name="xlab">Input argument #5</param>
    /// <param name="ylab">Input argument #6</param>
    ///
    public void CurveFittingWithPlotsAdvance(Object x, Object y, Object cftLib, Object 
                                       graTitle, Object xlab, Object ylab)
    {
      mcr.EvaluateFunction(0, "CurveFittingWithPlotsAdvance", x, y, cftLib, graTitle, xlab, ylab);
    }


    /// <summary>
    /// Provides a void output, 7-input Objectinterface to the
    /// CurveFittingWithPlotsAdvance M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Curve fit data                     
    /// </remarks>
    /// <param name="x">Input argument #1</param>
    /// <param name="y">Input argument #2</param>
    /// <param name="cftLib">Input argument #3</param>
    /// <param name="graTitle">Input argument #4</param>
    /// <param name="xlab">Input argument #5</param>
    /// <param name="ylab">Input argument #6</param>
    /// <param name="cftColor">Input argument #7</param>
    ///
    public void CurveFittingWithPlotsAdvance(Object x, Object y, Object cftLib, Object 
                                       graTitle, Object xlab, Object ylab, Object 
                                       cftColor)
    {
      mcr.EvaluateFunction(0, "CurveFittingWithPlotsAdvance", x, y, cftLib, graTitle, xlab, ylab, cftColor);
    }


    /// <summary>
    /// Provides a void output, 8-input Objectinterface to the
    /// CurveFittingWithPlotsAdvance M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Curve fit data                     
    /// </remarks>
    /// <param name="x">Input argument #1</param>
    /// <param name="y">Input argument #2</param>
    /// <param name="cftLib">Input argument #3</param>
    /// <param name="graTitle">Input argument #4</param>
    /// <param name="xlab">Input argument #5</param>
    /// <param name="ylab">Input argument #6</param>
    /// <param name="cftColor">Input argument #7</param>
    /// <param name="dataColor">Input argument #8</param>
    ///
    public void CurveFittingWithPlotsAdvance(Object x, Object y, Object cftLib, Object 
                                       graTitle, Object xlab, Object ylab, Object 
                                       cftColor, Object dataColor)
    {
      mcr.EvaluateFunction(0, "CurveFittingWithPlotsAdvance", x, y, cftLib, graTitle, xlab, ylab, cftColor, dataColor);
    }


    /// <summary>
    /// Provides a void output, 9-input Objectinterface to the
    /// CurveFittingWithPlotsAdvance M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Curve fit data                     
    /// </remarks>
    /// <param name="x">Input argument #1</param>
    /// <param name="y">Input argument #2</param>
    /// <param name="cftLib">Input argument #3</param>
    /// <param name="graTitle">Input argument #4</param>
    /// <param name="xlab">Input argument #5</param>
    /// <param name="ylab">Input argument #6</param>
    /// <param name="cftColor">Input argument #7</param>
    /// <param name="dataColor">Input argument #8</param>
    /// <param name="cftLegend">Input argument #9</param>
    ///
    public void CurveFittingWithPlotsAdvance(Object x, Object y, Object cftLib, Object 
                                       graTitle, Object xlab, Object ylab, Object 
                                       cftColor, Object dataColor, Object cftLegend)
    {
      mcr.EvaluateFunction(0, "CurveFittingWithPlotsAdvance", x, y, cftLib, graTitle, xlab, ylab, cftColor, dataColor, cftLegend);
    }


    /// <summary>
    /// Provides a void output, 10-input Objectinterface to the
    /// CurveFittingWithPlotsAdvance M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Curve fit data                     
    /// </remarks>
    /// <param name="x">Input argument #1</param>
    /// <param name="y">Input argument #2</param>
    /// <param name="cftLib">Input argument #3</param>
    /// <param name="graTitle">Input argument #4</param>
    /// <param name="xlab">Input argument #5</param>
    /// <param name="ylab">Input argument #6</param>
    /// <param name="cftColor">Input argument #7</param>
    /// <param name="dataColor">Input argument #8</param>
    /// <param name="cftLegend">Input argument #9</param>
    /// <param name="dataLengend">Input argument #10</param>
    ///
    public void CurveFittingWithPlotsAdvance(Object x, Object y, Object cftLib, Object 
                                       graTitle, Object xlab, Object ylab, Object 
                                       cftColor, Object dataColor, Object cftLegend, 
                                       Object dataLengend)
    {
      mcr.EvaluateFunction(0, "CurveFittingWithPlotsAdvance", x, y, cftLib, graTitle, xlab, ylab, cftColor, dataColor, cftLegend, dataLengend);
    }


    /// <summary>
    /// Provides the standard 0-input Object interface to the
    /// CurveFittingWithPlotsAdvance M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Curve fit data                     
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] CurveFittingWithPlotsAdvance(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "CurveFittingWithPlotsAdvance", new Object[]{});
    }


    /// <summary>
    /// Provides the standard 1-input Object interface to the
    /// CurveFittingWithPlotsAdvance M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Curve fit data                     
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="x">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] CurveFittingWithPlotsAdvance(int numArgsOut, Object x)
    {
      return mcr.EvaluateFunction(numArgsOut, "CurveFittingWithPlotsAdvance", x);
    }


    /// <summary>
    /// Provides the standard 2-input Object interface to the
    /// CurveFittingWithPlotsAdvance M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Curve fit data                     
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="x">Input argument #1</param>
    /// <param name="y">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] CurveFittingWithPlotsAdvance(int numArgsOut, Object x, Object y)
    {
      return mcr.EvaluateFunction(numArgsOut, "CurveFittingWithPlotsAdvance", x, y);
    }


    /// <summary>
    /// Provides the standard 3-input Object interface to the
    /// CurveFittingWithPlotsAdvance M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Curve fit data                     
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="x">Input argument #1</param>
    /// <param name="y">Input argument #2</param>
    /// <param name="cftLib">Input argument #3</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] CurveFittingWithPlotsAdvance(int numArgsOut, Object x, Object y, 
                                           Object cftLib)
    {
      return mcr.EvaluateFunction(numArgsOut, "CurveFittingWithPlotsAdvance", x, y, cftLib);
    }


    /// <summary>
    /// Provides the standard 4-input Object interface to the
    /// CurveFittingWithPlotsAdvance M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Curve fit data                     
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="x">Input argument #1</param>
    /// <param name="y">Input argument #2</param>
    /// <param name="cftLib">Input argument #3</param>
    /// <param name="graTitle">Input argument #4</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] CurveFittingWithPlotsAdvance(int numArgsOut, Object x, Object y, 
                                           Object cftLib, Object graTitle)
    {
      return mcr.EvaluateFunction(numArgsOut, "CurveFittingWithPlotsAdvance", x, y, cftLib, graTitle);
    }


    /// <summary>
    /// Provides the standard 5-input Object interface to the
    /// CurveFittingWithPlotsAdvance M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Curve fit data                     
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="x">Input argument #1</param>
    /// <param name="y">Input argument #2</param>
    /// <param name="cftLib">Input argument #3</param>
    /// <param name="graTitle">Input argument #4</param>
    /// <param name="xlab">Input argument #5</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] CurveFittingWithPlotsAdvance(int numArgsOut, Object x, Object y, 
                                           Object cftLib, Object graTitle, Object xlab)
    {
      return mcr.EvaluateFunction(numArgsOut, "CurveFittingWithPlotsAdvance", x, y, cftLib, graTitle, xlab);
    }


    /// <summary>
    /// Provides the standard 6-input Object interface to the
    /// CurveFittingWithPlotsAdvance M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Curve fit data                     
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="x">Input argument #1</param>
    /// <param name="y">Input argument #2</param>
    /// <param name="cftLib">Input argument #3</param>
    /// <param name="graTitle">Input argument #4</param>
    /// <param name="xlab">Input argument #5</param>
    /// <param name="ylab">Input argument #6</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] CurveFittingWithPlotsAdvance(int numArgsOut, Object x, Object y, 
                                           Object cftLib, Object graTitle, Object xlab, 
                                           Object ylab)
    {
      return mcr.EvaluateFunction(numArgsOut, "CurveFittingWithPlotsAdvance", x, y, cftLib, graTitle, xlab, ylab);
    }


    /// <summary>
    /// Provides the standard 7-input Object interface to the
    /// CurveFittingWithPlotsAdvance M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Curve fit data                     
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="x">Input argument #1</param>
    /// <param name="y">Input argument #2</param>
    /// <param name="cftLib">Input argument #3</param>
    /// <param name="graTitle">Input argument #4</param>
    /// <param name="xlab">Input argument #5</param>
    /// <param name="ylab">Input argument #6</param>
    /// <param name="cftColor">Input argument #7</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] CurveFittingWithPlotsAdvance(int numArgsOut, Object x, Object y, 
                                           Object cftLib, Object graTitle, Object xlab, 
                                           Object ylab, Object cftColor)
    {
      return mcr.EvaluateFunction(numArgsOut, "CurveFittingWithPlotsAdvance", x, y, cftLib, graTitle, xlab, ylab, cftColor);
    }


    /// <summary>
    /// Provides the standard 8-input Object interface to the
    /// CurveFittingWithPlotsAdvance M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Curve fit data                     
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="x">Input argument #1</param>
    /// <param name="y">Input argument #2</param>
    /// <param name="cftLib">Input argument #3</param>
    /// <param name="graTitle">Input argument #4</param>
    /// <param name="xlab">Input argument #5</param>
    /// <param name="ylab">Input argument #6</param>
    /// <param name="cftColor">Input argument #7</param>
    /// <param name="dataColor">Input argument #8</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] CurveFittingWithPlotsAdvance(int numArgsOut, Object x, Object y, 
                                           Object cftLib, Object graTitle, Object xlab, 
                                           Object ylab, Object cftColor, Object dataColor)
    {
      return mcr.EvaluateFunction(numArgsOut, "CurveFittingWithPlotsAdvance", x, y, cftLib, graTitle, xlab, ylab, cftColor, dataColor);
    }


    /// <summary>
    /// Provides the standard 9-input Object interface to the
    /// CurveFittingWithPlotsAdvance M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Curve fit data                     
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="x">Input argument #1</param>
    /// <param name="y">Input argument #2</param>
    /// <param name="cftLib">Input argument #3</param>
    /// <param name="graTitle">Input argument #4</param>
    /// <param name="xlab">Input argument #5</param>
    /// <param name="ylab">Input argument #6</param>
    /// <param name="cftColor">Input argument #7</param>
    /// <param name="dataColor">Input argument #8</param>
    /// <param name="cftLegend">Input argument #9</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] CurveFittingWithPlotsAdvance(int numArgsOut, Object x, Object y, 
                                           Object cftLib, Object graTitle, Object xlab, 
                                           Object ylab, Object cftColor, Object 
                                           dataColor, Object cftLegend)
    {
      return mcr.EvaluateFunction(numArgsOut, "CurveFittingWithPlotsAdvance", x, y, cftLib, graTitle, xlab, ylab, cftColor, dataColor, cftLegend);
    }


    /// <summary>
    /// Provides the standard 10-input Object interface to the
    /// CurveFittingWithPlotsAdvance M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Curve fit data                     
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="x">Input argument #1</param>
    /// <param name="y">Input argument #2</param>
    /// <param name="cftLib">Input argument #3</param>
    /// <param name="graTitle">Input argument #4</param>
    /// <param name="xlab">Input argument #5</param>
    /// <param name="ylab">Input argument #6</param>
    /// <param name="cftColor">Input argument #7</param>
    /// <param name="dataColor">Input argument #8</param>
    /// <param name="cftLegend">Input argument #9</param>
    /// <param name="dataLengend">Input argument #10</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] CurveFittingWithPlotsAdvance(int numArgsOut, Object x, Object y, 
                                           Object cftLib, Object graTitle, Object xlab, 
                                           Object ylab, Object cftColor, Object 
                                           dataColor, Object cftLegend, Object 
                                           dataLengend)
    {
      return mcr.EvaluateFunction(numArgsOut, "CurveFittingWithPlotsAdvance", x, y, cftLib, graTitle, xlab, ylab, cftColor, dataColor, cftLegend, dataLengend);
    }


    /// <summary>
    /// Provides a void output, 0-input Objectinterface to the mytextread M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    ///
    public void mytextread()
    {
      mcr.EvaluateFunction(0, "mytextread", new Object[]{});
    }


    /// <summary>
    /// Provides a void output, 1-input Objectinterface to the mytextread M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="fileName">Input argument #1</param>
    ///
    public void mytextread(Object fileName)
    {
      mcr.EvaluateFunction(0, "mytextread", fileName);
    }


    /// <summary>
    /// Provides a void output, 2-input Objectinterface to the mytextread M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="fileName">Input argument #1</param>
    /// <param name="colNum">Input argument #2</param>
    ///
    public void mytextread(Object fileName, Object colNum)
    {
      mcr.EvaluateFunction(0, "mytextread", fileName, colNum);
    }


    /// <summary>
    /// Provides a void output, 3-input Objectinterface to the mytextread M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="fileName">Input argument #1</param>
    /// <param name="colNum">Input argument #2</param>
    /// <param name="mydelimiter">Input argument #3</param>
    ///
    public void mytextread(Object fileName, Object colNum, Object mydelimiter)
    {
      mcr.EvaluateFunction(0, "mytextread", fileName, colNum, mydelimiter);
    }


    /// <summary>
    /// Provides the standard 0-input Object interface to the mytextread M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] mytextread(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "mytextread", new Object[]{});
    }


    /// <summary>
    /// Provides the standard 1-input Object interface to the mytextread M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="fileName">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] mytextread(int numArgsOut, Object fileName)
    {
      return mcr.EvaluateFunction(numArgsOut, "mytextread", fileName);
    }


    /// <summary>
    /// Provides the standard 2-input Object interface to the mytextread M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="fileName">Input argument #1</param>
    /// <param name="colNum">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] mytextread(int numArgsOut, Object fileName, Object colNum)
    {
      return mcr.EvaluateFunction(numArgsOut, "mytextread", fileName, colNum);
    }


    /// <summary>
    /// Provides the standard 3-input Object interface to the mytextread M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="fileName">Input argument #1</param>
    /// <param name="colNum">Input argument #2</param>
    /// <param name="mydelimiter">Input argument #3</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] mytextread(int numArgsOut, Object fileName, Object colNum, Object 
                         mydelimiter)
    {
      return mcr.EvaluateFunction(numArgsOut, "mytextread", fileName, colNum, mydelimiter);
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
