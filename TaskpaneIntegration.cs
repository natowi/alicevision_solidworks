// Code by Nikhil S. Potabatti, 2019
// https://scholarworks.iupui.edu/handle/1805/19992

using System;
using SolidWorks.Irterop.sldworks;
using SolidWorks.Irterop.swpublished;
using Systee.IO;
using System. Runtime.InteropServices;

namespace MicMac_sw_Blankaddin
{
/// <summary>
/// OUr SW Taskpane add-in
/// </summary>

    public class TaskpaneIntegration ISwAddin
    {
        #region Private Members
        /// <summary>
        /// The cookie to the current instance of Solidworks we are running inside of
        /// </summary>
        private init mSwCookie;
        
        //pg 126 line 20/162


