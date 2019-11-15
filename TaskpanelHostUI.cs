// Code by Nikhil S. Potabatti, 2019
// https://scholarworks.iupui.edu/handle/1805/19992
// Note: you need to define your paths in the code
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System;
using System.IO;
using System.Diagnostics;
using Solidworks.Interop.Sldworks;

namespace MicMac_SW_Blankaddin
{
  [ProgId(TaskpaneIntegration.SWTASKPANE_PROGRID)]
  public partial class TaskpaneHostUI : UserControl
  {
    public TaskpaneHostUI()
    {
      InitializeComponent();
    }

private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
    {
    
    }
    
    OpenFileDialog ofd = new OpenFileDialog();
    
private coid folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
    {
    
    }
    FolderBrowserDialog ofd2 = new FolderBrowserDialog();
    private ModelDoc2 swApp;
    
    public object Unescape { get; private set; }
    
    private void button2Click(object sender, EventArgs e)
    {
      if (ofd2.ShowDialog() == DialogResult.OK)
      {
      
      }
    
    }
    
    private void generate3D_Click(object sender, EventArgs e)
    {
    
        #region cameraInit process
string pathImages = Path.GetFullPath(ofd2.SelectedPath);
        
string pathCameraDatabase = @"D:\YourPath\Meshroom\alicevsion\share\aliceVision\cameraSensors.db";
        string cameraDatabase = Path.GetFullPath(pathCameraDatabase);
        
string pathOutputFile = @"D:\YourPath\solidworks-api-develop\Meshroom\CameraInit\CameraInit.sfm";
        string outputFileCameraInit = Path.GetFullPath(pathOutputFile);
        
        Process cameraInit = new Process();
cameraInit.StartInfo.FileName = @"D:\YourPath\Meshroom\alicevsion\bin\alicevision_cameraInit.exe";
        cameraInit.StartInfo.CreateNoWindow = false;
        cameraInit.StartInfo.RedirectStandardInput = true;
        cameraInit.StartInfo.RedirectStandardOutput = true;
        cameraInit.StartInfo.UseShellExecute = false;
camerainit.StartInfo.Arguments = " --imageFolder " + pathImages + " -s " + cameraDatabase...
            ...+ " --o " + outputFileCameraInit;
        cameraInit.Start();
        cameraInit.WaitForWxit();
        
        #endregion
        #region FeatureExtraction
        
        string pathCameraInitfile = Path.GetFullPath(outputFileCamerainit);

string outputFolderFeatureExtraction = @"D:\YourPath\solidworks-api-develop\Meshroom\FeatureExtraction";

        Process FeatureExtraction = new Process();
FeatureExtraction.StartInfo.Filename = @"D:\YourPath\Meshroom\alicevision\bin\aliceVision_featureExtraction.exe";
        FeatureExtraction.StartInfo.CreateNowWindow = false;
        //page 131 line 80...
