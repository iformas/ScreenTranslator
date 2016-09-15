using Emgu.CV;
using Emgu.CV.OCR;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using ScreenTranslator.Clasess;
using System.Linq;

namespace ScreenTranslator.WinFroms
{
    public partial class frmMainWindow : Form
    {
        private static readonly String _workingPath = Directory.GetCurrentDirectory();
        private static readonly String _tessdataPath = _workingPath + "\\Tessdata";
        private static readonly String _langsFileName = "languages.json";
        private List<Language> _languages;

        public frmMainWindow()
        {
            InitializeComponent();
        }


        private void frmMainWindow_Load(object sender, EventArgs e)
        {
            try
            {

                //langs inicialization
                cmbFrom.Items.Add("Select");
                cmbFrom.SelectedIndex = 0;
                cmbTo.Items.Add("Select");
                cmbTo.SelectedIndex = 0;
                _languages = Language.Load(_workingPath + "\\", _langsFileName);
                foreach (Language lang in _languages)
                {
                    if (lang.ocrKey != null)
                    {
                        cmbFrom.Items.Add(lang.name);
                    }
                    cmbTo.Items.Add(lang.name);
                }
            }
            catch (Exception ex)
            {
                ErrorMessage(ex.Message);
            }
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            if (cmbFrom.SelectedIndex != 0)
            {
                String fromOCRKey = _languages.FirstOrDefault(x => x.name == cmbFrom.SelectedItem.ToString()).ocrKey;
                try
                {
                    using (Bitmap bmp = new Bitmap(picCaptureArea.Width, picCaptureArea.Height))
                    {

                        Tesseract OCRz = new Tesseract(_tessdataPath, fromOCRKey, OcrEngineMode.Default);
                        Graphics graphics = Graphics.FromImage(bmp);
                        var screenPosition = PointToScreen(picCaptureArea.Location);
                        graphics.CopyFromScreen(new Point(screenPosition.X, screenPosition.Y), new Point(0, 0), bmp.Size);
                        OCRz.Recognize(new Image<Bgr, byte>(bmp));
                        this.rtxCapturedText.Text = OCRz.GetText();
                    }
                }
                catch (ArgumentException)
                {
                    ErrorMessage("Missing language \"" + fromOCRKey + "\" in folder " + _tessdataPath);
                }
                catch (Exception ex)
                {
                    ErrorMessage(ex.Message);
                }
            }
            else
            {
                ErrorMessage("No \"From\" lang selected");
            }
        }

        private void btnTranslate_Click(object sender, EventArgs e)
        {
            if (cmbTo.SelectedIndex != 0)
            {
                try
                {
                    String fromGTranslateKey = _languages.FirstOrDefault(x => x.name == cmbFrom.SelectedItem.ToString()).gTranslateKey;
                    String toGTranslateKey = _languages.FirstOrDefault(x => x.name == cmbTo.SelectedItem.ToString()).gTranslateKey;

                    Translator t = new Translator();
                    rtxCapturedText.Text = t.Translate(rtxCapturedText.Text, fromGTranslateKey, toGTranslateKey);
                }
                catch (Exception ex)
                {
                    ErrorMessage(ex.Message);
                }

            }
            else
            {
                ErrorMessage("No \"To\" lang selected");
            }
        }

        private void ErrorMessage(String _message)
        {
            MessageBox.Show(_message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
