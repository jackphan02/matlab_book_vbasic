/*
* MATLAB Compiler: 4.11 (R2009b)
* Date: Wed Jun 23 22:17:39 2010
* Arguments: "-B" "macro_default" "-W"
* "dotnet:GeneratingGraphicsNameSpace,GeneratingGraphicsClass,0.0,private" "-d"
* "C:\MatlabVB\Mfiles\GeneratingGraphics\GeneratingGraphicsNameSpace\src" "-T" "link:lib"
* "-v"
* "class{GeneratingGraphicsClass:C:\MatlabVB\Mfiles\GeneratingGraphics\multiPlotForArrays.
* m,C:\MatlabVB\Mfiles\GeneratingGraphics\multiPlotForFuncs.m,C:\MatlabVB\Mfiles\Generatin
* gGraphics\mytextread.m,C:\MatlabVB\Mfiles\GeneratingGraphics\simplePlot.m}" 
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

namespace GeneratingGraphicsNameSpace
{
  /// <summary>
  /// The GeneratingGraphicsClass class provides a CLS compliant, MWArray interface to
  /// the M-functions contained in the files:
  /// <newpara></newpara>
  /// C:\MatlabVB\Mfiles\GeneratingGraphics\multiPlotForArrays.m
  /// <newpara></newpara>
  /// C:\MatlabVB\Mfiles\GeneratingGraphics\multiPlotForFuncs.m
  /// <newpara></newpara>
  /// C:\MatlabVB\Mfiles\GeneratingGraphics\mytextread.m
  /// <newpara></newpara>
  /// C:\MatlabVB\Mfiles\GeneratingGraphics\simplePlot.m
  /// <newpara></newpara>
  /// deployprint.m
  /// <newpara></newpara>
  /// printdlg.m
  /// </summary>
  /// <remarks>
  /// @Version 0.0
  /// </remarks>
  public class GeneratingGraphicsClass : IDisposable
  {
    #region Constructors

    /// <summary internal= "true">
    /// The static constructor instantiates and initializes the MATLAB Component Runtime
    /// instance.
    /// </summary>
    static GeneratingGraphicsClass()
    {
      if (MWMCR.MCRAppInitialized)
      {
        Assembly assembly= Assembly.GetExecutingAssembly();

        string ctfFilePath= assembly.Location;

        int lastDelimiter= ctfFilePath.LastIndexOf(@"\");

        ctfFilePath= ctfFilePath.Remove(lastDelimiter, (ctfFilePath.Length - lastDelimiter));

        string ctfFileName = MCRComponentState.MCC_GeneratingGraphicsNameSpace_name_data + ".ctf";

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
        mcr= new MWMCR(MCRComponentState.MCC_GeneratingGraphicsNameSpace_name_data,
                       MCRComponentState.MCC_GeneratingGraphicsNameSpace_root_data,
                       MCRComponentState.MCC_GeneratingGraphicsNameSpace_public_data,
                       MCRComponentState.MCC_GeneratingGraphicsNameSpace_session_data,
                       MCRComponentState.MCC_GeneratingGraphicsNameSpace_matlabpath_data,
                       MCRComponentState.MCC_GeneratingGraphicsNameSpace_classpath_data,
                       MCRComponentState.MCC_GeneratingGraphicsNameSpace_libpath_data,
                       MCRComponentState.MCC_GeneratingGraphicsNameSpace_mcr_application_options,
                       MCRComponentState.MCC_GeneratingGraphicsNameSpace_mcr_runtime_options,
                       MCRComponentState.MCC_GeneratingGraphicsNameSpace_mcr_pref_dir,
                       MCRComponentState.MCC_GeneratingGraphicsNameSpace_set_warning_state,
                       ctfFilePath, embeddedCtfStream, true);
      }
      else
      {
        throw new ApplicationException("MWArray assembly could not be initialized");
      }
    }


    /// <summary>
    /// Constructs a new instance of the GeneratingGraphicsClass class.
    /// </summary>
    public GeneratingGraphicsClass()
    {
    }


    #endregion Constructors

    #region Finalize

    /// <summary internal= "true">
    /// Class destructor called by the CLR garbage collector.
    /// </summary>
    ~GeneratingGraphicsClass()
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
    /// Provides a void output, 0-input MWArrayinterface to the multiPlotForArrays
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// title('Figure Legends') ;
    /// </remarks>
    ///
    public void multiPlotForArrays()
    {
      mcr.EvaluateFunction(0, "multiPlotForArrays", new MWArray[]{});
    }


    /// <summary>
    /// Provides a void output, 1-input MWArrayinterface to the multiPlotForArrays
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// title('Figure Legends') ;
    /// </remarks>
    /// <param name="t">Input argument #1</param>
    ///
    public void multiPlotForArrays(MWArray t)
    {
      mcr.EvaluateFunction(0, "multiPlotForArrays", t);
    }


    /// <summary>
    /// Provides a void output, 2-input MWArrayinterface to the multiPlotForArrays
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// title('Figure Legends') ;
    /// </remarks>
    /// <param name="t">Input argument #1</param>
    /// <param name="y1">Input argument #2</param>
    ///
    public void multiPlotForArrays(MWArray t, MWArray y1)
    {
      mcr.EvaluateFunction(0, "multiPlotForArrays", t, y1);
    }


    /// <summary>
    /// Provides a void output, 3-input MWArrayinterface to the multiPlotForArrays
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// title('Figure Legends') ;
    /// </remarks>
    /// <param name="t">Input argument #1</param>
    /// <param name="y1">Input argument #2</param>
    /// <param name="y2">Input argument #3</param>
    ///
    public void multiPlotForArrays(MWArray t, MWArray y1, MWArray y2)
    {
      mcr.EvaluateFunction(0, "multiPlotForArrays", t, y1, y2);
    }


    /// <summary>
    /// Provides a void output, 4-input MWArrayinterface to the multiPlotForArrays
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// title('Figure Legends') ;
    /// </remarks>
    /// <param name="t">Input argument #1</param>
    /// <param name="y1">Input argument #2</param>
    /// <param name="y2">Input argument #3</param>
    /// <param name="y3">Input argument #4</param>
    ///
    public void multiPlotForArrays(MWArray t, MWArray y1, MWArray y2, MWArray y3)
    {
      mcr.EvaluateFunction(0, "multiPlotForArrays", t, y1, y2, y3);
    }


    /// <summary>
    /// Provides a void output, 5-input MWArrayinterface to the multiPlotForArrays
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// title('Figure Legends') ;
    /// </remarks>
    /// <param name="t">Input argument #1</param>
    /// <param name="y1">Input argument #2</param>
    /// <param name="y2">Input argument #3</param>
    /// <param name="y3">Input argument #4</param>
    /// <param name="y4">Input argument #5</param>
    ///
    public void multiPlotForArrays(MWArray t, MWArray y1, MWArray y2, MWArray y3, MWArray 
                             y4)
    {
      mcr.EvaluateFunction(0, "multiPlotForArrays", t, y1, y2, y3, y4);
    }


    /// <summary>
    /// Provides a void output, 6-input MWArrayinterface to the multiPlotForArrays
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// title('Figure Legends') ;
    /// </remarks>
    /// <param name="t">Input argument #1</param>
    /// <param name="y1">Input argument #2</param>
    /// <param name="y2">Input argument #3</param>
    /// <param name="y3">Input argument #4</param>
    /// <param name="y4">Input argument #5</param>
    /// <param name="strTitle">Input argument #6</param>
    ///
    public void multiPlotForArrays(MWArray t, MWArray y1, MWArray y2, MWArray y3, MWArray 
                             y4, MWArray strTitle)
    {
      mcr.EvaluateFunction(0, "multiPlotForArrays", t, y1, y2, y3, y4, strTitle);
    }


    /// <summary>
    /// Provides a void output, 7-input MWArrayinterface to the multiPlotForArrays
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// title('Figure Legends') ;
    /// </remarks>
    /// <param name="t">Input argument #1</param>
    /// <param name="y1">Input argument #2</param>
    /// <param name="y2">Input argument #3</param>
    /// <param name="y3">Input argument #4</param>
    /// <param name="y4">Input argument #5</param>
    /// <param name="strTitle">Input argument #6</param>
    /// <param name="strxlabel">Input argument #7</param>
    ///
    public void multiPlotForArrays(MWArray t, MWArray y1, MWArray y2, MWArray y3, MWArray 
                             y4, MWArray strTitle, MWArray strxlabel)
    {
      mcr.EvaluateFunction(0, "multiPlotForArrays", t, y1, y2, y3, y4, strTitle, strxlabel);
    }


    /// <summary>
    /// Provides a void output, 8-input MWArrayinterface to the multiPlotForArrays
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// title('Figure Legends') ;
    /// </remarks>
    /// <param name="t">Input argument #1</param>
    /// <param name="y1">Input argument #2</param>
    /// <param name="y2">Input argument #3</param>
    /// <param name="y3">Input argument #4</param>
    /// <param name="y4">Input argument #5</param>
    /// <param name="strTitle">Input argument #6</param>
    /// <param name="strxlabel">Input argument #7</param>
    /// <param name="strylabel">Input argument #8</param>
    ///
    public void multiPlotForArrays(MWArray t, MWArray y1, MWArray y2, MWArray y3, MWArray 
                             y4, MWArray strTitle, MWArray strxlabel, MWArray strylabel)
    {
      mcr.EvaluateFunction(0, "multiPlotForArrays", t, y1, y2, y3, y4, strTitle, strxlabel, strylabel);
    }


    /// <summary>
    /// Provides the standard 0-input MWArray interface to the multiPlotForArrays
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// title('Figure Legends') ;
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] multiPlotForArrays(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "multiPlotForArrays", new MWArray[]{});
    }


    /// <summary>
    /// Provides the standard 1-input MWArray interface to the multiPlotForArrays
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// title('Figure Legends') ;
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="t">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] multiPlotForArrays(int numArgsOut, MWArray t)
    {
      return mcr.EvaluateFunction(numArgsOut, "multiPlotForArrays", t);
    }


    /// <summary>
    /// Provides the standard 2-input MWArray interface to the multiPlotForArrays
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// title('Figure Legends') ;
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="t">Input argument #1</param>
    /// <param name="y1">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] multiPlotForArrays(int numArgsOut, MWArray t, MWArray y1)
    {
      return mcr.EvaluateFunction(numArgsOut, "multiPlotForArrays", t, y1);
    }


    /// <summary>
    /// Provides the standard 3-input MWArray interface to the multiPlotForArrays
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// title('Figure Legends') ;
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="t">Input argument #1</param>
    /// <param name="y1">Input argument #2</param>
    /// <param name="y2">Input argument #3</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] multiPlotForArrays(int numArgsOut, MWArray t, MWArray y1, MWArray y2)
    {
      return mcr.EvaluateFunction(numArgsOut, "multiPlotForArrays", t, y1, y2);
    }


    /// <summary>
    /// Provides the standard 4-input MWArray interface to the multiPlotForArrays
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// title('Figure Legends') ;
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="t">Input argument #1</param>
    /// <param name="y1">Input argument #2</param>
    /// <param name="y2">Input argument #3</param>
    /// <param name="y3">Input argument #4</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] multiPlotForArrays(int numArgsOut, MWArray t, MWArray y1, MWArray 
                                  y2, MWArray y3)
    {
      return mcr.EvaluateFunction(numArgsOut, "multiPlotForArrays", t, y1, y2, y3);
    }


    /// <summary>
    /// Provides the standard 5-input MWArray interface to the multiPlotForArrays
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// title('Figure Legends') ;
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="t">Input argument #1</param>
    /// <param name="y1">Input argument #2</param>
    /// <param name="y2">Input argument #3</param>
    /// <param name="y3">Input argument #4</param>
    /// <param name="y4">Input argument #5</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] multiPlotForArrays(int numArgsOut, MWArray t, MWArray y1, MWArray 
                                  y2, MWArray y3, MWArray y4)
    {
      return mcr.EvaluateFunction(numArgsOut, "multiPlotForArrays", t, y1, y2, y3, y4);
    }


    /// <summary>
    /// Provides the standard 6-input MWArray interface to the multiPlotForArrays
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// title('Figure Legends') ;
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="t">Input argument #1</param>
    /// <param name="y1">Input argument #2</param>
    /// <param name="y2">Input argument #3</param>
    /// <param name="y3">Input argument #4</param>
    /// <param name="y4">Input argument #5</param>
    /// <param name="strTitle">Input argument #6</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] multiPlotForArrays(int numArgsOut, MWArray t, MWArray y1, MWArray 
                                  y2, MWArray y3, MWArray y4, MWArray strTitle)
    {
      return mcr.EvaluateFunction(numArgsOut, "multiPlotForArrays", t, y1, y2, y3, y4, strTitle);
    }


    /// <summary>
    /// Provides the standard 7-input MWArray interface to the multiPlotForArrays
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// title('Figure Legends') ;
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="t">Input argument #1</param>
    /// <param name="y1">Input argument #2</param>
    /// <param name="y2">Input argument #3</param>
    /// <param name="y3">Input argument #4</param>
    /// <param name="y4">Input argument #5</param>
    /// <param name="strTitle">Input argument #6</param>
    /// <param name="strxlabel">Input argument #7</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] multiPlotForArrays(int numArgsOut, MWArray t, MWArray y1, MWArray 
                                  y2, MWArray y3, MWArray y4, MWArray strTitle, MWArray 
                                  strxlabel)
    {
      return mcr.EvaluateFunction(numArgsOut, "multiPlotForArrays", t, y1, y2, y3, y4, strTitle, strxlabel);
    }


    /// <summary>
    /// Provides the standard 8-input MWArray interface to the multiPlotForArrays
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// title('Figure Legends') ;
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="t">Input argument #1</param>
    /// <param name="y1">Input argument #2</param>
    /// <param name="y2">Input argument #3</param>
    /// <param name="y3">Input argument #4</param>
    /// <param name="y4">Input argument #5</param>
    /// <param name="strTitle">Input argument #6</param>
    /// <param name="strxlabel">Input argument #7</param>
    /// <param name="strylabel">Input argument #8</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] multiPlotForArrays(int numArgsOut, MWArray t, MWArray y1, MWArray 
                                  y2, MWArray y3, MWArray y4, MWArray strTitle, MWArray 
                                  strxlabel, MWArray strylabel)
    {
      return mcr.EvaluateFunction(numArgsOut, "multiPlotForArrays", t, y1, y2, y3, y4, strTitle, strxlabel, strylabel);
    }


    /// <summary>
    /// Provides a void output, 0-input MWArrayinterface to the multiPlotForFuncs
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// y1 = cos(t)           ;
    /// y2 = cos(t + pi/3)    ;
    /// y3 = cos(t + 2*pi/3)  ;
    /// </remarks>
    ///
    public void multiPlotForFuncs()
    {
      mcr.EvaluateFunction(0, "multiPlotForFuncs", new MWArray[]{});
    }


    /// <summary>
    /// Provides a void output, 1-input MWArrayinterface to the multiPlotForFuncs
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// y1 = cos(t)           ;
    /// y2 = cos(t + pi/3)    ;
    /// y3 = cos(t + 2*pi/3)  ;
    /// </remarks>
    /// <param name="strPlot1">Input argument #1</param>
    ///
    public void multiPlotForFuncs(MWArray strPlot1)
    {
      mcr.EvaluateFunction(0, "multiPlotForFuncs", strPlot1);
    }


    /// <summary>
    /// Provides a void output, 2-input MWArrayinterface to the multiPlotForFuncs
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// y1 = cos(t)           ;
    /// y2 = cos(t + pi/3)    ;
    /// y3 = cos(t + 2*pi/3)  ;
    /// </remarks>
    /// <param name="strPlot1">Input argument #1</param>
    /// <param name="colorPlot1">Input argument #2</param>
    ///
    public void multiPlotForFuncs(MWArray strPlot1, MWArray colorPlot1)
    {
      mcr.EvaluateFunction(0, "multiPlotForFuncs", strPlot1, colorPlot1);
    }


    /// <summary>
    /// Provides a void output, 3-input MWArrayinterface to the multiPlotForFuncs
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// y1 = cos(t)           ;
    /// y2 = cos(t + pi/3)    ;
    /// y3 = cos(t + 2*pi/3)  ;
    /// </remarks>
    /// <param name="strPlot1">Input argument #1</param>
    /// <param name="colorPlot1">Input argument #2</param>
    /// <param name="markerPlot1">Input argument #3</param>
    ///
    public void multiPlotForFuncs(MWArray strPlot1, MWArray colorPlot1, MWArray 
                            markerPlot1)
    {
      mcr.EvaluateFunction(0, "multiPlotForFuncs", strPlot1, colorPlot1, markerPlot1);
    }


    /// <summary>
    /// Provides a void output, 4-input MWArrayinterface to the multiPlotForFuncs
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// y1 = cos(t)           ;
    /// y2 = cos(t + pi/3)    ;
    /// y3 = cos(t + 2*pi/3)  ;
    /// </remarks>
    /// <param name="strPlot1">Input argument #1</param>
    /// <param name="colorPlot1">Input argument #2</param>
    /// <param name="markerPlot1">Input argument #3</param>
    /// <param name="strPlot2">Input argument #4</param>
    ///
    public void multiPlotForFuncs(MWArray strPlot1, MWArray colorPlot1, MWArray 
                            markerPlot1, MWArray strPlot2)
    {
      mcr.EvaluateFunction(0, "multiPlotForFuncs", strPlot1, colorPlot1, markerPlot1, strPlot2);
    }


    /// <summary>
    /// Provides a void output, 5-input MWArrayinterface to the multiPlotForFuncs
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// y1 = cos(t)           ;
    /// y2 = cos(t + pi/3)    ;
    /// y3 = cos(t + 2*pi/3)  ;
    /// </remarks>
    /// <param name="strPlot1">Input argument #1</param>
    /// <param name="colorPlot1">Input argument #2</param>
    /// <param name="markerPlot1">Input argument #3</param>
    /// <param name="strPlot2">Input argument #4</param>
    /// <param name="colorPlot2">Input argument #5</param>
    ///
    public void multiPlotForFuncs(MWArray strPlot1, MWArray colorPlot1, MWArray 
                            markerPlot1, MWArray strPlot2, MWArray colorPlot2)
    {
      mcr.EvaluateFunction(0, "multiPlotForFuncs", strPlot1, colorPlot1, markerPlot1, strPlot2, colorPlot2);
    }


    /// <summary>
    /// Provides a void output, 6-input MWArrayinterface to the multiPlotForFuncs
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// y1 = cos(t)           ;
    /// y2 = cos(t + pi/3)    ;
    /// y3 = cos(t + 2*pi/3)  ;
    /// </remarks>
    /// <param name="strPlot1">Input argument #1</param>
    /// <param name="colorPlot1">Input argument #2</param>
    /// <param name="markerPlot1">Input argument #3</param>
    /// <param name="strPlot2">Input argument #4</param>
    /// <param name="colorPlot2">Input argument #5</param>
    /// <param name="markerPlot2">Input argument #6</param>
    ///
    public void multiPlotForFuncs(MWArray strPlot1, MWArray colorPlot1, MWArray 
                            markerPlot1, MWArray strPlot2, MWArray colorPlot2, MWArray 
                            markerPlot2)
    {
      mcr.EvaluateFunction(0, "multiPlotForFuncs", strPlot1, colorPlot1, markerPlot1, strPlot2, colorPlot2, markerPlot2);
    }


    /// <summary>
    /// Provides a void output, 7-input MWArrayinterface to the multiPlotForFuncs
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// y1 = cos(t)           ;
    /// y2 = cos(t + pi/3)    ;
    /// y3 = cos(t + 2*pi/3)  ;
    /// </remarks>
    /// <param name="strPlot1">Input argument #1</param>
    /// <param name="colorPlot1">Input argument #2</param>
    /// <param name="markerPlot1">Input argument #3</param>
    /// <param name="strPlot2">Input argument #4</param>
    /// <param name="colorPlot2">Input argument #5</param>
    /// <param name="markerPlot2">Input argument #6</param>
    /// <param name="strPlot3">Input argument #7</param>
    ///
    public void multiPlotForFuncs(MWArray strPlot1, MWArray colorPlot1, MWArray 
                            markerPlot1, MWArray strPlot2, MWArray colorPlot2, MWArray 
                            markerPlot2, MWArray strPlot3)
    {
      mcr.EvaluateFunction(0, "multiPlotForFuncs", strPlot1, colorPlot1, markerPlot1, strPlot2, colorPlot2, markerPlot2, strPlot3);
    }


    /// <summary>
    /// Provides a void output, 8-input MWArrayinterface to the multiPlotForFuncs
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// y1 = cos(t)           ;
    /// y2 = cos(t + pi/3)    ;
    /// y3 = cos(t + 2*pi/3)  ;
    /// </remarks>
    /// <param name="strPlot1">Input argument #1</param>
    /// <param name="colorPlot1">Input argument #2</param>
    /// <param name="markerPlot1">Input argument #3</param>
    /// <param name="strPlot2">Input argument #4</param>
    /// <param name="colorPlot2">Input argument #5</param>
    /// <param name="markerPlot2">Input argument #6</param>
    /// <param name="strPlot3">Input argument #7</param>
    /// <param name="colorPlot3">Input argument #8</param>
    ///
    public void multiPlotForFuncs(MWArray strPlot1, MWArray colorPlot1, MWArray 
                            markerPlot1, MWArray strPlot2, MWArray colorPlot2, MWArray 
                            markerPlot2, MWArray strPlot3, MWArray colorPlot3)
    {
      mcr.EvaluateFunction(0, "multiPlotForFuncs", strPlot1, colorPlot1, markerPlot1, strPlot2, colorPlot2, markerPlot2, strPlot3, colorPlot3);
    }


    /// <summary>
    /// Provides a void output, 9-input MWArrayinterface to the multiPlotForFuncs
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// y1 = cos(t)           ;
    /// y2 = cos(t + pi/3)    ;
    /// y3 = cos(t + 2*pi/3)  ;
    /// </remarks>
    /// <param name="strPlot1">Input argument #1</param>
    /// <param name="colorPlot1">Input argument #2</param>
    /// <param name="markerPlot1">Input argument #3</param>
    /// <param name="strPlot2">Input argument #4</param>
    /// <param name="colorPlot2">Input argument #5</param>
    /// <param name="markerPlot2">Input argument #6</param>
    /// <param name="strPlot3">Input argument #7</param>
    /// <param name="colorPlot3">Input argument #8</param>
    /// <param name="markerPlot3">Input argument #9</param>
    ///
    public void multiPlotForFuncs(MWArray strPlot1, MWArray colorPlot1, MWArray 
                            markerPlot1, MWArray strPlot2, MWArray colorPlot2, MWArray 
                            markerPlot2, MWArray strPlot3, MWArray colorPlot3, MWArray 
                            markerPlot3)
    {
      mcr.EvaluateFunction(0, "multiPlotForFuncs", strPlot1, colorPlot1, markerPlot1, strPlot2, colorPlot2, markerPlot2, strPlot3, colorPlot3, markerPlot3);
    }


    /// <summary>
    /// Provides a void output, 10-input MWArrayinterface to the multiPlotForFuncs
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// y1 = cos(t)           ;
    /// y2 = cos(t + pi/3)    ;
    /// y3 = cos(t + 2*pi/3)  ;
    /// </remarks>
    /// <param name="strPlot1">Input argument #1</param>
    /// <param name="colorPlot1">Input argument #2</param>
    /// <param name="markerPlot1">Input argument #3</param>
    /// <param name="strPlot2">Input argument #4</param>
    /// <param name="colorPlot2">Input argument #5</param>
    /// <param name="markerPlot2">Input argument #6</param>
    /// <param name="strPlot3">Input argument #7</param>
    /// <param name="colorPlot3">Input argument #8</param>
    /// <param name="markerPlot3">Input argument #9</param>
    /// <param name="strTitle">Input argument #10</param>
    ///
    public void multiPlotForFuncs(MWArray strPlot1, MWArray colorPlot1, MWArray 
                            markerPlot1, MWArray strPlot2, MWArray colorPlot2, MWArray 
                            markerPlot2, MWArray strPlot3, MWArray colorPlot3, MWArray 
                            markerPlot3, MWArray strTitle)
    {
      mcr.EvaluateFunction(0, "multiPlotForFuncs", strPlot1, colorPlot1, markerPlot1, strPlot2, colorPlot2, markerPlot2, strPlot3, colorPlot3, markerPlot3, strTitle);
    }


    /// <summary>
    /// Provides a void output, 11-input MWArrayinterface to the multiPlotForFuncs
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// y1 = cos(t)           ;
    /// y2 = cos(t + pi/3)    ;
    /// y3 = cos(t + 2*pi/3)  ;
    /// </remarks>
    /// <param name="strPlot1">Input argument #1</param>
    /// <param name="colorPlot1">Input argument #2</param>
    /// <param name="markerPlot1">Input argument #3</param>
    /// <param name="strPlot2">Input argument #4</param>
    /// <param name="colorPlot2">Input argument #5</param>
    /// <param name="markerPlot2">Input argument #6</param>
    /// <param name="strPlot3">Input argument #7</param>
    /// <param name="colorPlot3">Input argument #8</param>
    /// <param name="markerPlot3">Input argument #9</param>
    /// <param name="strTitle">Input argument #10</param>
    /// <param name="strxlabel">Input argument #11</param>
    ///
    public void multiPlotForFuncs(MWArray strPlot1, MWArray colorPlot1, MWArray 
                            markerPlot1, MWArray strPlot2, MWArray colorPlot2, MWArray 
                            markerPlot2, MWArray strPlot3, MWArray colorPlot3, MWArray 
                            markerPlot3, MWArray strTitle, MWArray strxlabel)
    {
      mcr.EvaluateFunction(0, "multiPlotForFuncs", strPlot1, colorPlot1, markerPlot1, strPlot2, colorPlot2, markerPlot2, strPlot3, colorPlot3, markerPlot3, strTitle, strxlabel);
    }


    /// <summary>
    /// Provides a void output, 12-input MWArrayinterface to the multiPlotForFuncs
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// y1 = cos(t)           ;
    /// y2 = cos(t + pi/3)    ;
    /// y3 = cos(t + 2*pi/3)  ;
    /// </remarks>
    /// <param name="strPlot1">Input argument #1</param>
    /// <param name="colorPlot1">Input argument #2</param>
    /// <param name="markerPlot1">Input argument #3</param>
    /// <param name="strPlot2">Input argument #4</param>
    /// <param name="colorPlot2">Input argument #5</param>
    /// <param name="markerPlot2">Input argument #6</param>
    /// <param name="strPlot3">Input argument #7</param>
    /// <param name="colorPlot3">Input argument #8</param>
    /// <param name="markerPlot3">Input argument #9</param>
    /// <param name="strTitle">Input argument #10</param>
    /// <param name="strxlabel">Input argument #11</param>
    /// <param name="strylabel">Input argument #12</param>
    ///
    public void multiPlotForFuncs(MWArray strPlot1, MWArray colorPlot1, MWArray 
                            markerPlot1, MWArray strPlot2, MWArray colorPlot2, MWArray 
                            markerPlot2, MWArray strPlot3, MWArray colorPlot3, MWArray 
                            markerPlot3, MWArray strTitle, MWArray strxlabel, MWArray 
                            strylabel)
    {
      mcr.EvaluateFunction(0, "multiPlotForFuncs", strPlot1, colorPlot1, markerPlot1, strPlot2, colorPlot2, markerPlot2, strPlot3, colorPlot3, markerPlot3, strTitle, strxlabel, strylabel);
    }


    /// <summary>
    /// Provides the standard 0-input MWArray interface to the multiPlotForFuncs
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// y1 = cos(t)           ;
    /// y2 = cos(t + pi/3)    ;
    /// y3 = cos(t + 2*pi/3)  ;
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] multiPlotForFuncs(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "multiPlotForFuncs", new MWArray[]{});
    }


    /// <summary>
    /// Provides the standard 1-input MWArray interface to the multiPlotForFuncs
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// y1 = cos(t)           ;
    /// y2 = cos(t + pi/3)    ;
    /// y3 = cos(t + 2*pi/3)  ;
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="strPlot1">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] multiPlotForFuncs(int numArgsOut, MWArray strPlot1)
    {
      return mcr.EvaluateFunction(numArgsOut, "multiPlotForFuncs", strPlot1);
    }


    /// <summary>
    /// Provides the standard 2-input MWArray interface to the multiPlotForFuncs
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// y1 = cos(t)           ;
    /// y2 = cos(t + pi/3)    ;
    /// y3 = cos(t + 2*pi/3)  ;
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="strPlot1">Input argument #1</param>
    /// <param name="colorPlot1">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] multiPlotForFuncs(int numArgsOut, MWArray strPlot1, MWArray 
                                 colorPlot1)
    {
      return mcr.EvaluateFunction(numArgsOut, "multiPlotForFuncs", strPlot1, colorPlot1);
    }


    /// <summary>
    /// Provides the standard 3-input MWArray interface to the multiPlotForFuncs
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// y1 = cos(t)           ;
    /// y2 = cos(t + pi/3)    ;
    /// y3 = cos(t + 2*pi/3)  ;
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="strPlot1">Input argument #1</param>
    /// <param name="colorPlot1">Input argument #2</param>
    /// <param name="markerPlot1">Input argument #3</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] multiPlotForFuncs(int numArgsOut, MWArray strPlot1, MWArray 
                                 colorPlot1, MWArray markerPlot1)
    {
      return mcr.EvaluateFunction(numArgsOut, "multiPlotForFuncs", strPlot1, colorPlot1, markerPlot1);
    }


    /// <summary>
    /// Provides the standard 4-input MWArray interface to the multiPlotForFuncs
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// y1 = cos(t)           ;
    /// y2 = cos(t + pi/3)    ;
    /// y3 = cos(t + 2*pi/3)  ;
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="strPlot1">Input argument #1</param>
    /// <param name="colorPlot1">Input argument #2</param>
    /// <param name="markerPlot1">Input argument #3</param>
    /// <param name="strPlot2">Input argument #4</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] multiPlotForFuncs(int numArgsOut, MWArray strPlot1, MWArray 
                                 colorPlot1, MWArray markerPlot1, MWArray strPlot2)
    {
      return mcr.EvaluateFunction(numArgsOut, "multiPlotForFuncs", strPlot1, colorPlot1, markerPlot1, strPlot2);
    }


    /// <summary>
    /// Provides the standard 5-input MWArray interface to the multiPlotForFuncs
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// y1 = cos(t)           ;
    /// y2 = cos(t + pi/3)    ;
    /// y3 = cos(t + 2*pi/3)  ;
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="strPlot1">Input argument #1</param>
    /// <param name="colorPlot1">Input argument #2</param>
    /// <param name="markerPlot1">Input argument #3</param>
    /// <param name="strPlot2">Input argument #4</param>
    /// <param name="colorPlot2">Input argument #5</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] multiPlotForFuncs(int numArgsOut, MWArray strPlot1, MWArray 
                                 colorPlot1, MWArray markerPlot1, MWArray strPlot2, 
                                 MWArray colorPlot2)
    {
      return mcr.EvaluateFunction(numArgsOut, "multiPlotForFuncs", strPlot1, colorPlot1, markerPlot1, strPlot2, colorPlot2);
    }


    /// <summary>
    /// Provides the standard 6-input MWArray interface to the multiPlotForFuncs
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// y1 = cos(t)           ;
    /// y2 = cos(t + pi/3)    ;
    /// y3 = cos(t + 2*pi/3)  ;
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="strPlot1">Input argument #1</param>
    /// <param name="colorPlot1">Input argument #2</param>
    /// <param name="markerPlot1">Input argument #3</param>
    /// <param name="strPlot2">Input argument #4</param>
    /// <param name="colorPlot2">Input argument #5</param>
    /// <param name="markerPlot2">Input argument #6</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] multiPlotForFuncs(int numArgsOut, MWArray strPlot1, MWArray 
                                 colorPlot1, MWArray markerPlot1, MWArray strPlot2, 
                                 MWArray colorPlot2, MWArray markerPlot2)
    {
      return mcr.EvaluateFunction(numArgsOut, "multiPlotForFuncs", strPlot1, colorPlot1, markerPlot1, strPlot2, colorPlot2, markerPlot2);
    }


    /// <summary>
    /// Provides the standard 7-input MWArray interface to the multiPlotForFuncs
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// y1 = cos(t)           ;
    /// y2 = cos(t + pi/3)    ;
    /// y3 = cos(t + 2*pi/3)  ;
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="strPlot1">Input argument #1</param>
    /// <param name="colorPlot1">Input argument #2</param>
    /// <param name="markerPlot1">Input argument #3</param>
    /// <param name="strPlot2">Input argument #4</param>
    /// <param name="colorPlot2">Input argument #5</param>
    /// <param name="markerPlot2">Input argument #6</param>
    /// <param name="strPlot3">Input argument #7</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] multiPlotForFuncs(int numArgsOut, MWArray strPlot1, MWArray 
                                 colorPlot1, MWArray markerPlot1, MWArray strPlot2, 
                                 MWArray colorPlot2, MWArray markerPlot2, MWArray 
                                 strPlot3)
    {
      return mcr.EvaluateFunction(numArgsOut, "multiPlotForFuncs", strPlot1, colorPlot1, markerPlot1, strPlot2, colorPlot2, markerPlot2, strPlot3);
    }


    /// <summary>
    /// Provides the standard 8-input MWArray interface to the multiPlotForFuncs
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// y1 = cos(t)           ;
    /// y2 = cos(t + pi/3)    ;
    /// y3 = cos(t + 2*pi/3)  ;
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="strPlot1">Input argument #1</param>
    /// <param name="colorPlot1">Input argument #2</param>
    /// <param name="markerPlot1">Input argument #3</param>
    /// <param name="strPlot2">Input argument #4</param>
    /// <param name="colorPlot2">Input argument #5</param>
    /// <param name="markerPlot2">Input argument #6</param>
    /// <param name="strPlot3">Input argument #7</param>
    /// <param name="colorPlot3">Input argument #8</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] multiPlotForFuncs(int numArgsOut, MWArray strPlot1, MWArray 
                                 colorPlot1, MWArray markerPlot1, MWArray strPlot2, 
                                 MWArray colorPlot2, MWArray markerPlot2, MWArray 
                                 strPlot3, MWArray colorPlot3)
    {
      return mcr.EvaluateFunction(numArgsOut, "multiPlotForFuncs", strPlot1, colorPlot1, markerPlot1, strPlot2, colorPlot2, markerPlot2, strPlot3, colorPlot3);
    }


    /// <summary>
    /// Provides the standard 9-input MWArray interface to the multiPlotForFuncs
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// y1 = cos(t)           ;
    /// y2 = cos(t + pi/3)    ;
    /// y3 = cos(t + 2*pi/3)  ;
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="strPlot1">Input argument #1</param>
    /// <param name="colorPlot1">Input argument #2</param>
    /// <param name="markerPlot1">Input argument #3</param>
    /// <param name="strPlot2">Input argument #4</param>
    /// <param name="colorPlot2">Input argument #5</param>
    /// <param name="markerPlot2">Input argument #6</param>
    /// <param name="strPlot3">Input argument #7</param>
    /// <param name="colorPlot3">Input argument #8</param>
    /// <param name="markerPlot3">Input argument #9</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] multiPlotForFuncs(int numArgsOut, MWArray strPlot1, MWArray 
                                 colorPlot1, MWArray markerPlot1, MWArray strPlot2, 
                                 MWArray colorPlot2, MWArray markerPlot2, MWArray 
                                 strPlot3, MWArray colorPlot3, MWArray markerPlot3)
    {
      return mcr.EvaluateFunction(numArgsOut, "multiPlotForFuncs", strPlot1, colorPlot1, markerPlot1, strPlot2, colorPlot2, markerPlot2, strPlot3, colorPlot3, markerPlot3);
    }


    /// <summary>
    /// Provides the standard 10-input MWArray interface to the multiPlotForFuncs
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// y1 = cos(t)           ;
    /// y2 = cos(t + pi/3)    ;
    /// y3 = cos(t + 2*pi/3)  ;
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="strPlot1">Input argument #1</param>
    /// <param name="colorPlot1">Input argument #2</param>
    /// <param name="markerPlot1">Input argument #3</param>
    /// <param name="strPlot2">Input argument #4</param>
    /// <param name="colorPlot2">Input argument #5</param>
    /// <param name="markerPlot2">Input argument #6</param>
    /// <param name="strPlot3">Input argument #7</param>
    /// <param name="colorPlot3">Input argument #8</param>
    /// <param name="markerPlot3">Input argument #9</param>
    /// <param name="strTitle">Input argument #10</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] multiPlotForFuncs(int numArgsOut, MWArray strPlot1, MWArray 
                                 colorPlot1, MWArray markerPlot1, MWArray strPlot2, 
                                 MWArray colorPlot2, MWArray markerPlot2, MWArray 
                                 strPlot3, MWArray colorPlot3, MWArray markerPlot3, 
                                 MWArray strTitle)
    {
      return mcr.EvaluateFunction(numArgsOut, "multiPlotForFuncs", strPlot1, colorPlot1, markerPlot1, strPlot2, colorPlot2, markerPlot2, strPlot3, colorPlot3, markerPlot3, strTitle);
    }


    /// <summary>
    /// Provides the standard 11-input MWArray interface to the multiPlotForFuncs
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// y1 = cos(t)           ;
    /// y2 = cos(t + pi/3)    ;
    /// y3 = cos(t + 2*pi/3)  ;
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="strPlot1">Input argument #1</param>
    /// <param name="colorPlot1">Input argument #2</param>
    /// <param name="markerPlot1">Input argument #3</param>
    /// <param name="strPlot2">Input argument #4</param>
    /// <param name="colorPlot2">Input argument #5</param>
    /// <param name="markerPlot2">Input argument #6</param>
    /// <param name="strPlot3">Input argument #7</param>
    /// <param name="colorPlot3">Input argument #8</param>
    /// <param name="markerPlot3">Input argument #9</param>
    /// <param name="strTitle">Input argument #10</param>
    /// <param name="strxlabel">Input argument #11</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] multiPlotForFuncs(int numArgsOut, MWArray strPlot1, MWArray 
                                 colorPlot1, MWArray markerPlot1, MWArray strPlot2, 
                                 MWArray colorPlot2, MWArray markerPlot2, MWArray 
                                 strPlot3, MWArray colorPlot3, MWArray markerPlot3, 
                                 MWArray strTitle, MWArray strxlabel)
    {
      return mcr.EvaluateFunction(numArgsOut, "multiPlotForFuncs", strPlot1, colorPlot1, markerPlot1, strPlot2, colorPlot2, markerPlot2, strPlot3, colorPlot3, markerPlot3, strTitle, strxlabel);
    }


    /// <summary>
    /// Provides the standard 12-input MWArray interface to the multiPlotForFuncs
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// y1 = cos(t)           ;
    /// y2 = cos(t + pi/3)    ;
    /// y3 = cos(t + 2*pi/3)  ;
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="strPlot1">Input argument #1</param>
    /// <param name="colorPlot1">Input argument #2</param>
    /// <param name="markerPlot1">Input argument #3</param>
    /// <param name="strPlot2">Input argument #4</param>
    /// <param name="colorPlot2">Input argument #5</param>
    /// <param name="markerPlot2">Input argument #6</param>
    /// <param name="strPlot3">Input argument #7</param>
    /// <param name="colorPlot3">Input argument #8</param>
    /// <param name="markerPlot3">Input argument #9</param>
    /// <param name="strTitle">Input argument #10</param>
    /// <param name="strxlabel">Input argument #11</param>
    /// <param name="strylabel">Input argument #12</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] multiPlotForFuncs(int numArgsOut, MWArray strPlot1, MWArray 
                                 colorPlot1, MWArray markerPlot1, MWArray strPlot2, 
                                 MWArray colorPlot2, MWArray markerPlot2, MWArray 
                                 strPlot3, MWArray colorPlot3, MWArray markerPlot3, 
                                 MWArray strTitle, MWArray strxlabel, MWArray strylabel)
    {
      return mcr.EvaluateFunction(numArgsOut, "multiPlotForFuncs", strPlot1, colorPlot1, markerPlot1, strPlot2, colorPlot2, markerPlot2, strPlot3, colorPlot3, markerPlot3, strTitle, strxlabel, strylabel);
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
    /// Provides a void output, 0-input MWArrayinterface to the simplePlot M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    ///
    public void simplePlot()
    {
      mcr.EvaluateFunction(0, "simplePlot", new MWArray[]{});
    }


    /// <summary>
    /// Provides a void output, 1-input MWArrayinterface to the simplePlot M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="x">Input argument #1</param>
    ///
    public void simplePlot(MWArray x)
    {
      mcr.EvaluateFunction(0, "simplePlot", x);
    }


    /// <summary>
    /// Provides a void output, 2-input MWArrayinterface to the simplePlot M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="x">Input argument #1</param>
    /// <param name="y">Input argument #2</param>
    ///
    public void simplePlot(MWArray x, MWArray y)
    {
      mcr.EvaluateFunction(0, "simplePlot", x, y);
    }


    /// <summary>
    /// Provides a void output, 3-input MWArrayinterface to the simplePlot M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="x">Input argument #1</param>
    /// <param name="y">Input argument #2</param>
    /// <param name="strColor">Input argument #3</param>
    ///
    public void simplePlot(MWArray x, MWArray y, MWArray strColor)
    {
      mcr.EvaluateFunction(0, "simplePlot", x, y, strColor);
    }


    /// <summary>
    /// Provides the standard 0-input MWArray interface to the simplePlot M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] simplePlot(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "simplePlot", new MWArray[]{});
    }


    /// <summary>
    /// Provides the standard 1-input MWArray interface to the simplePlot M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="x">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] simplePlot(int numArgsOut, MWArray x)
    {
      return mcr.EvaluateFunction(numArgsOut, "simplePlot", x);
    }


    /// <summary>
    /// Provides the standard 2-input MWArray interface to the simplePlot M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="x">Input argument #1</param>
    /// <param name="y">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] simplePlot(int numArgsOut, MWArray x, MWArray y)
    {
      return mcr.EvaluateFunction(numArgsOut, "simplePlot", x, y);
    }


    /// <summary>
    /// Provides the standard 3-input MWArray interface to the simplePlot M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="x">Input argument #1</param>
    /// <param name="y">Input argument #2</param>
    /// <param name="strColor">Input argument #3</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] simplePlot(int numArgsOut, MWArray x, MWArray y, MWArray strColor)
    {
      return mcr.EvaluateFunction(numArgsOut, "simplePlot", x, y, strColor);
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
