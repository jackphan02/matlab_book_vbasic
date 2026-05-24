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

namespace CurveFittingNameSpace
{
  /// <summary>
  /// The CurveFitting class provides a CLS compliant, MWArray interface to the
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
    /// Provides a void output, 0-input MWArrayinterface to the CurveFittings M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    ///
    public void CurveFittings()
    {
      mcr.EvaluateFunction(0, "CurveFittings", new MWArray[]{});
    }


    /// <summary>
    /// Provides a void output, 1-input MWArrayinterface to the CurveFittings M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="x">Input argument #1</param>
    ///
    public void CurveFittings(MWArray x)
    {
      mcr.EvaluateFunction(0, "CurveFittings", x);
    }


    /// <summary>
    /// Provides a void output, 2-input MWArrayinterface to the CurveFittings M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="x">Input argument #1</param>
    /// <param name="y">Input argument #2</param>
    ///
    public void CurveFittings(MWArray x, MWArray y)
    {
      mcr.EvaluateFunction(0, "CurveFittings", x, y);
    }


    /// <summary>
    /// Provides a void output, 3-input MWArrayinterface to the CurveFittings M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="x">Input argument #1</param>
    /// <param name="y">Input argument #2</param>
    /// <param name="cftLib">Input argument #3</param>
    ///
    public void CurveFittings(MWArray x, MWArray y, MWArray cftLib)
    {
      mcr.EvaluateFunction(0, "CurveFittings", x, y, cftLib);
    }


    /// <summary>
    /// Provides the standard 0-input MWArray interface to the CurveFittings M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] CurveFittings(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "CurveFittings", new MWArray[]{});
    }


    /// <summary>
    /// Provides the standard 1-input MWArray interface to the CurveFittings M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="x">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] CurveFittings(int numArgsOut, MWArray x)
    {
      return mcr.EvaluateFunction(numArgsOut, "CurveFittings", x);
    }


    /// <summary>
    /// Provides the standard 2-input MWArray interface to the CurveFittings M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="x">Input argument #1</param>
    /// <param name="y">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] CurveFittings(int numArgsOut, MWArray x, MWArray y)
    {
      return mcr.EvaluateFunction(numArgsOut, "CurveFittings", x, y);
    }


    /// <summary>
    /// Provides the standard 3-input MWArray interface to the CurveFittings M-function.
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
    public MWArray[] CurveFittings(int numArgsOut, MWArray x, MWArray y, MWArray cftLib)
    {
      return mcr.EvaluateFunction(numArgsOut, "CurveFittings", x, y, cftLib);
    }


    /// <summary>
    /// Provides an interface for the CurveFittings function in which the input and
    /// output
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
    public void CurveFittings(int numArgsOut, ref MWArray[] argsOut, MWArray[] argsIn)
    {
      mcr.EvaluateFunction("CurveFittings", numArgsOut, ref argsOut, argsIn);
    }


    /// <summary>
    /// Provides a void output, 0-input MWArrayinterface to the CurveFittingWithPlots
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Curve fit data                     
    /// </remarks>
    ///
    public void CurveFittingWithPlots()
    {
      mcr.EvaluateFunction(0, "CurveFittingWithPlots", new MWArray[]{});
    }


    /// <summary>
    /// Provides a void output, 1-input MWArrayinterface to the CurveFittingWithPlots
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Curve fit data                     
    /// </remarks>
    /// <param name="x">Input argument #1</param>
    ///
    public void CurveFittingWithPlots(MWArray x)
    {
      mcr.EvaluateFunction(0, "CurveFittingWithPlots", x);
    }


    /// <summary>
    /// Provides a void output, 2-input MWArrayinterface to the CurveFittingWithPlots
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Curve fit data                     
    /// </remarks>
    /// <param name="x">Input argument #1</param>
    /// <param name="y">Input argument #2</param>
    ///
    public void CurveFittingWithPlots(MWArray x, MWArray y)
    {
      mcr.EvaluateFunction(0, "CurveFittingWithPlots", x, y);
    }


    /// <summary>
    /// Provides a void output, 3-input MWArrayinterface to the CurveFittingWithPlots
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
    public void CurveFittingWithPlots(MWArray x, MWArray y, MWArray cftLib)
    {
      mcr.EvaluateFunction(0, "CurveFittingWithPlots", x, y, cftLib);
    }


    /// <summary>
    /// Provides the standard 0-input MWArray interface to the CurveFittingWithPlots
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
    public MWArray[] CurveFittingWithPlots(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "CurveFittingWithPlots", new MWArray[]{});
    }


    /// <summary>
    /// Provides the standard 1-input MWArray interface to the CurveFittingWithPlots
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
    public MWArray[] CurveFittingWithPlots(int numArgsOut, MWArray x)
    {
      return mcr.EvaluateFunction(numArgsOut, "CurveFittingWithPlots", x);
    }


    /// <summary>
    /// Provides the standard 2-input MWArray interface to the CurveFittingWithPlots
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
    public MWArray[] CurveFittingWithPlots(int numArgsOut, MWArray x, MWArray y)
    {
      return mcr.EvaluateFunction(numArgsOut, "CurveFittingWithPlots", x, y);
    }


    /// <summary>
    /// Provides the standard 3-input MWArray interface to the CurveFittingWithPlots
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
    public MWArray[] CurveFittingWithPlots(int numArgsOut, MWArray x, MWArray y, MWArray 
                                     cftLib)
    {
      return mcr.EvaluateFunction(numArgsOut, "CurveFittingWithPlots", x, y, cftLib);
    }


    /// <summary>
    /// Provides an interface for the CurveFittingWithPlots function in which the input
    /// and output
    /// arguments are specified as an array of MWArrays.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// M-Documentation:
    /// Curve fit data                     
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of MWArray output arguments</param>
    /// <param name= "argsIn">Array of MWArray input arguments</param>
    ///
    public void CurveFittingWithPlots(int numArgsOut, ref MWArray[] argsOut, MWArray[] 
                            argsIn)
    {
      mcr.EvaluateFunction("CurveFittingWithPlots", numArgsOut, ref argsOut, argsIn);
    }


    /// <summary>
    /// Provides a void output, 0-input MWArrayinterface to the
    /// CurveFittingWithPlotsAdvance M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Curve fit data                     
    /// </remarks>
    ///
    public void CurveFittingWithPlotsAdvance()
    {
      mcr.EvaluateFunction(0, "CurveFittingWithPlotsAdvance", new MWArray[]{});
    }


    /// <summary>
    /// Provides a void output, 1-input MWArrayinterface to the
    /// CurveFittingWithPlotsAdvance M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Curve fit data                     
    /// </remarks>
    /// <param name="x">Input argument #1</param>
    ///
    public void CurveFittingWithPlotsAdvance(MWArray x)
    {
      mcr.EvaluateFunction(0, "CurveFittingWithPlotsAdvance", x);
    }


    /// <summary>
    /// Provides a void output, 2-input MWArrayinterface to the
    /// CurveFittingWithPlotsAdvance M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Curve fit data                     
    /// </remarks>
    /// <param name="x">Input argument #1</param>
    /// <param name="y">Input argument #2</param>
    ///
    public void CurveFittingWithPlotsAdvance(MWArray x, MWArray y)
    {
      mcr.EvaluateFunction(0, "CurveFittingWithPlotsAdvance", x, y);
    }


    /// <summary>
    /// Provides a void output, 3-input MWArrayinterface to the
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
    public void CurveFittingWithPlotsAdvance(MWArray x, MWArray y, MWArray cftLib)
    {
      mcr.EvaluateFunction(0, "CurveFittingWithPlotsAdvance", x, y, cftLib);
    }


    /// <summary>
    /// Provides a void output, 4-input MWArrayinterface to the
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
    public void CurveFittingWithPlotsAdvance(MWArray x, MWArray y, MWArray cftLib, 
                                       MWArray graTitle)
    {
      mcr.EvaluateFunction(0, "CurveFittingWithPlotsAdvance", x, y, cftLib, graTitle);
    }


    /// <summary>
    /// Provides a void output, 5-input MWArrayinterface to the
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
    public void CurveFittingWithPlotsAdvance(MWArray x, MWArray y, MWArray cftLib, 
                                       MWArray graTitle, MWArray xlab)
    {
      mcr.EvaluateFunction(0, "CurveFittingWithPlotsAdvance", x, y, cftLib, graTitle, xlab);
    }


    /// <summary>
    /// Provides a void output, 6-input MWArrayinterface to the
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
    public void CurveFittingWithPlotsAdvance(MWArray x, MWArray y, MWArray cftLib, 
                                       MWArray graTitle, MWArray xlab, MWArray ylab)
    {
      mcr.EvaluateFunction(0, "CurveFittingWithPlotsAdvance", x, y, cftLib, graTitle, xlab, ylab);
    }


    /// <summary>
    /// Provides a void output, 7-input MWArrayinterface to the
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
    public void CurveFittingWithPlotsAdvance(MWArray x, MWArray y, MWArray cftLib, 
                                       MWArray graTitle, MWArray xlab, MWArray ylab, 
                                       MWArray cftColor)
    {
      mcr.EvaluateFunction(0, "CurveFittingWithPlotsAdvance", x, y, cftLib, graTitle, xlab, ylab, cftColor);
    }


    /// <summary>
    /// Provides a void output, 8-input MWArrayinterface to the
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
    public void CurveFittingWithPlotsAdvance(MWArray x, MWArray y, MWArray cftLib, 
                                       MWArray graTitle, MWArray xlab, MWArray ylab, 
                                       MWArray cftColor, MWArray dataColor)
    {
      mcr.EvaluateFunction(0, "CurveFittingWithPlotsAdvance", x, y, cftLib, graTitle, xlab, ylab, cftColor, dataColor);
    }


    /// <summary>
    /// Provides a void output, 9-input MWArrayinterface to the
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
    public void CurveFittingWithPlotsAdvance(MWArray x, MWArray y, MWArray cftLib, 
                                       MWArray graTitle, MWArray xlab, MWArray ylab, 
                                       MWArray cftColor, MWArray dataColor, MWArray 
                                       cftLegend)
    {
      mcr.EvaluateFunction(0, "CurveFittingWithPlotsAdvance", x, y, cftLib, graTitle, xlab, ylab, cftColor, dataColor, cftLegend);
    }


    /// <summary>
    /// Provides a void output, 10-input MWArrayinterface to the
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
    public void CurveFittingWithPlotsAdvance(MWArray x, MWArray y, MWArray cftLib, 
                                       MWArray graTitle, MWArray xlab, MWArray ylab, 
                                       MWArray cftColor, MWArray dataColor, MWArray 
                                       cftLegend, MWArray dataLengend)
    {
      mcr.EvaluateFunction(0, "CurveFittingWithPlotsAdvance", x, y, cftLib, graTitle, xlab, ylab, cftColor, dataColor, cftLegend, dataLengend);
    }


    /// <summary>
    /// Provides the standard 0-input MWArray interface to the
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
    public MWArray[] CurveFittingWithPlotsAdvance(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "CurveFittingWithPlotsAdvance", new MWArray[]{});
    }


    /// <summary>
    /// Provides the standard 1-input MWArray interface to the
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
    public MWArray[] CurveFittingWithPlotsAdvance(int numArgsOut, MWArray x)
    {
      return mcr.EvaluateFunction(numArgsOut, "CurveFittingWithPlotsAdvance", x);
    }


    /// <summary>
    /// Provides the standard 2-input MWArray interface to the
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
    public MWArray[] CurveFittingWithPlotsAdvance(int numArgsOut, MWArray x, MWArray y)
    {
      return mcr.EvaluateFunction(numArgsOut, "CurveFittingWithPlotsAdvance", x, y);
    }


    /// <summary>
    /// Provides the standard 3-input MWArray interface to the
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
    public MWArray[] CurveFittingWithPlotsAdvance(int numArgsOut, MWArray x, MWArray y, 
                                            MWArray cftLib)
    {
      return mcr.EvaluateFunction(numArgsOut, "CurveFittingWithPlotsAdvance", x, y, cftLib);
    }


    /// <summary>
    /// Provides the standard 4-input MWArray interface to the
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
    public MWArray[] CurveFittingWithPlotsAdvance(int numArgsOut, MWArray x, MWArray y, 
                                            MWArray cftLib, MWArray graTitle)
    {
      return mcr.EvaluateFunction(numArgsOut, "CurveFittingWithPlotsAdvance", x, y, cftLib, graTitle);
    }


    /// <summary>
    /// Provides the standard 5-input MWArray interface to the
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
    public MWArray[] CurveFittingWithPlotsAdvance(int numArgsOut, MWArray x, MWArray y, 
                                            MWArray cftLib, MWArray graTitle, MWArray 
                                            xlab)
    {
      return mcr.EvaluateFunction(numArgsOut, "CurveFittingWithPlotsAdvance", x, y, cftLib, graTitle, xlab);
    }


    /// <summary>
    /// Provides the standard 6-input MWArray interface to the
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
    public MWArray[] CurveFittingWithPlotsAdvance(int numArgsOut, MWArray x, MWArray y, 
                                            MWArray cftLib, MWArray graTitle, MWArray 
                                            xlab, MWArray ylab)
    {
      return mcr.EvaluateFunction(numArgsOut, "CurveFittingWithPlotsAdvance", x, y, cftLib, graTitle, xlab, ylab);
    }


    /// <summary>
    /// Provides the standard 7-input MWArray interface to the
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
    public MWArray[] CurveFittingWithPlotsAdvance(int numArgsOut, MWArray x, MWArray y, 
                                            MWArray cftLib, MWArray graTitle, MWArray 
                                            xlab, MWArray ylab, MWArray cftColor)
    {
      return mcr.EvaluateFunction(numArgsOut, "CurveFittingWithPlotsAdvance", x, y, cftLib, graTitle, xlab, ylab, cftColor);
    }


    /// <summary>
    /// Provides the standard 8-input MWArray interface to the
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
    public MWArray[] CurveFittingWithPlotsAdvance(int numArgsOut, MWArray x, MWArray y, 
                                            MWArray cftLib, MWArray graTitle, MWArray 
                                            xlab, MWArray ylab, MWArray cftColor, MWArray 
                                            dataColor)
    {
      return mcr.EvaluateFunction(numArgsOut, "CurveFittingWithPlotsAdvance", x, y, cftLib, graTitle, xlab, ylab, cftColor, dataColor);
    }


    /// <summary>
    /// Provides the standard 9-input MWArray interface to the
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
    public MWArray[] CurveFittingWithPlotsAdvance(int numArgsOut, MWArray x, MWArray y, 
                                            MWArray cftLib, MWArray graTitle, MWArray 
                                            xlab, MWArray ylab, MWArray cftColor, MWArray 
                                            dataColor, MWArray cftLegend)
    {
      return mcr.EvaluateFunction(numArgsOut, "CurveFittingWithPlotsAdvance", x, y, cftLib, graTitle, xlab, ylab, cftColor, dataColor, cftLegend);
    }


    /// <summary>
    /// Provides the standard 10-input MWArray interface to the
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
    public MWArray[] CurveFittingWithPlotsAdvance(int numArgsOut, MWArray x, MWArray y, 
                                            MWArray cftLib, MWArray graTitle, MWArray 
                                            xlab, MWArray ylab, MWArray cftColor, MWArray 
                                            dataColor, MWArray cftLegend, MWArray 
                                            dataLengend)
    {
      return mcr.EvaluateFunction(numArgsOut, "CurveFittingWithPlotsAdvance", x, y, cftLib, graTitle, xlab, ylab, cftColor, dataColor, cftLegend, dataLengend);
    }


    /// <summary>
    /// Provides an interface for the CurveFittingWithPlotsAdvance function in which the
    /// input and output
    /// arguments are specified as an array of MWArrays.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// M-Documentation:
    /// Curve fit data                     
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of MWArray output arguments</param>
    /// <param name= "argsIn">Array of MWArray input arguments</param>
    ///
    public void CurveFittingWithPlotsAdvance(int numArgsOut, ref MWArray[] argsOut, 
                                   MWArray[] argsIn)
    {
      mcr.EvaluateFunction("CurveFittingWithPlotsAdvance", numArgsOut, ref argsOut, 
                                   argsIn);
    }


    /// <summary>
    /// Provides a void output, 0-input MWArrayinterface to the mytextread M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    ///
    public void mytextread()
    {
      mcr.EvaluateFunction(0, "mytextread", new MWArray[]{});
    }


    /// <summary>
    /// Provides a void output, 1-input MWArrayinterface to the mytextread M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="fileName">Input argument #1</param>
    ///
    public void mytextread(MWArray fileName)
    {
      mcr.EvaluateFunction(0, "mytextread", fileName);
    }


    /// <summary>
    /// Provides a void output, 2-input MWArrayinterface to the mytextread M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="fileName">Input argument #1</param>
    /// <param name="colNum">Input argument #2</param>
    ///
    public void mytextread(MWArray fileName, MWArray colNum)
    {
      mcr.EvaluateFunction(0, "mytextread", fileName, colNum);
    }


    /// <summary>
    /// Provides a void output, 3-input MWArrayinterface to the mytextread M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="fileName">Input argument #1</param>
    /// <param name="colNum">Input argument #2</param>
    /// <param name="mydelimiter">Input argument #3</param>
    ///
    public void mytextread(MWArray fileName, MWArray colNum, MWArray mydelimiter)
    {
      mcr.EvaluateFunction(0, "mytextread", fileName, colNum, mydelimiter);
    }


    /// <summary>
    /// Provides the standard 0-input MWArray interface to the mytextread M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] mytextread(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "mytextread", new MWArray[]{});
    }


    /// <summary>
    /// Provides the standard 1-input MWArray interface to the mytextread M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="fileName">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] mytextread(int numArgsOut, MWArray fileName)
    {
      return mcr.EvaluateFunction(numArgsOut, "mytextread", fileName);
    }


    /// <summary>
    /// Provides the standard 2-input MWArray interface to the mytextread M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="fileName">Input argument #1</param>
    /// <param name="colNum">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] mytextread(int numArgsOut, MWArray fileName, MWArray colNum)
    {
      return mcr.EvaluateFunction(numArgsOut, "mytextread", fileName, colNum);
    }


    /// <summary>
    /// Provides the standard 3-input MWArray interface to the mytextread M-function.
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
    public MWArray[] mytextread(int numArgsOut, MWArray fileName, MWArray colNum, MWArray 
                          mydelimiter)
    {
      return mcr.EvaluateFunction(numArgsOut, "mytextread", fileName, colNum, mydelimiter);
    }


    /// <summary>
    /// Provides an interface for the mytextread function in which the input and output
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
    public void mytextread(int numArgsOut, ref MWArray[] argsOut, MWArray[] argsIn)
    {
      mcr.EvaluateFunction("mytextread", numArgsOut, ref argsOut, argsIn);
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
