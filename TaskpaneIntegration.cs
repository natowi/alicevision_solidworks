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
        
        /// <summary>
        /// The taskpane view for the addin
        /// </summary>
        private TaskpaneView mTaskpaneView;
        
        /// <summary>
        /// The UI control that going to be inside the solidworks taskpane view
        /// </summary>
        private TaskpaneHostUI mTaskpaneHost
        
        /// <summary>
        /// The current instance of the SolidWorks application
        /// </summary>
        private SldWorks mSolidworksApplication;
        
        #endregion
        
        #region Public Members
            
        /// <summary>
        /// The unique Id to the taskpane used for registration in COM
        /// </summary>
        public const string SWTASKPANE_PROGID = "MicMac_SW_BlackAddin_Taskpane";
        
        # endregion
        
        # region Solidworks Add-in Callbacks
        
        /// <summary>
        /// Called when Solidworks has loaded our add-in and wants us to do our connection logic
        /// </summary>
        /// <param name="ThisSW">The current Solidworks instance</param>
        /// <param name="Cookie">The current Solidworks cookie Id</param>
        /// <returns></returns>
    
        public bool ConnectToSW(object ThisSW, int Cookie)
        {
            // Store a reference to the current Solidworks instance
            mSolidworksApplication = (SldWorks)ThisSW;
            
            // Store cookie Id
            mSwCookie = Cookie;
            
            // Setup a callback info
            var ok = mSolidworksApplication.SetAddinCallbackInfo2(0, this, mSwCookie);
            
            //Create our UI
            LoadUI();
            
            //Return ok
            return true;
            
        }
        
        /// <summary>
        /// Called when SolidWorks is about to unload our add-in and wants us to do our disconnection logic
        /// </summary>
        /// <param name="ThisSW">The current Solidworks instance</param>
        /// <param name="Cookie">The current Solidworks cookie Id</param>
        /// <returns></returns>
        public bool DisconnectFromSW
        {
            // Clean up the UI
            UnloadUI();
            
            // Return ok
            return true;
        }
        
        #endregion
            
        #region Create UI
        /// <summary>
        /// Create our Taskpane and inject our host UI
        /// </summary>
        private void LoadUI()
        {
            // Find location to our taskpane
            var imagePath = Path.Combine(Path.GetDirectoryName(typeof(TaskpaneIntegration).Assembly.CodeBase...
                ...Replace(@"file:\", string.Empty), "arton1-bf637.jpg");
            
            // Create Taskpane
            mTaskpaneView = mSolidworksApplication.CreateTaskpaneView2(imagePath, "SW - MicMac PhotoGrammetry");
            
            // Load UI into taskpane
            mTaskpaneHost = (TaskpaneHostUI)mTaskpaneView.AddControl(TaskpaneIntegration.SWTASKPANE_PROGID,
                 ...string.Empty);
         }
                                      
                                         
 p128


// Code by Nikhil S. Potabatti, 2019
// https://scholarworks.iupui.edu/handle/1805/19992


