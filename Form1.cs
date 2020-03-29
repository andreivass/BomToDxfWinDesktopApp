using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DxfBom1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblBrowseDxf_Click(object sender, EventArgs e)
        {
        }

        string dxf_file; // input dxf file
        bool dxf_bool = false; // bool, if input file extension is correct
        string txt_file; // input txt file
        bool txt_bool = false; // bool, if input file extension is correct

        private void btnBrowseDxf_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                dxf_file = openFileDialog1.FileName;
                try
                {
                    string text = File.ReadAllText(dxf_file);
                }
                catch (IOException)
                {
                }
          
                if (dxf_file.Substring(dxf_file.Length - 3).Equals("DXF", StringComparison.OrdinalIgnoreCase))
                {
                    lblSelectedDfx.Text = dxf_file;
                    dxf_bool = true;
                } else
                {
                    lblSelectedDfx.Text = "Wrong file type selected";
                    dxf_bool = false;
                }
            }
        }

        private void btnBrowseTxt_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                txt_file = openFileDialog1.FileName;
                try
                {
                    string text = File.ReadAllText(txt_file);
                }
                catch (IOException)
                {
                }

                if (txt_file.Substring(txt_file.Length - 3).Equals("TXT", StringComparison.OrdinalIgnoreCase))
                {
                    lblTxtSelected.Text = txt_file;
                    txt_bool = true;
                }
                else
                {
                    lblTxtSelected.Text = "Wrong file type selected";
                    txt_bool = false;
                }
            }
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            if (txt_bool && dxf_bool)
            {
                string TxtText = File.ReadAllText(txt_file);
                string TxtTextFirstLine = TxtText.Split(new[] { '\r', '\n' }).FirstOrDefault();

                string DxfText = File.ReadAllText(dxf_file);

                // check if dxf file alreay contains BOM info
                if (DxfText.Contains(TxtTextFirstLine))
                {
                    lblRun.Text = "Dxf already contains BOM layer. Select another dxf.";
                }
                else
                {
                    // 1st part of create new MText element on layer BOM
                    string MTextBaseStart = "ENTITIES\n0\nMTEXT\n5\n256\n330\n1F\n100\nAcDbEntity\n8\nBOM\n100\nAcDbMText\n10\n-20.0\n20\n-20.0\n30\n0.0\n40\n2.5\n41\n0.0\n71\n1\n72\n1\n3\n";
                    //modify input txt to match dxf standard, create 2nd part
                    string MTextBaseMid = TxtText.Replace(System.Environment.NewLine, @"\P");
                    // 3rd part of create new MText element on layer BOM
                    string MTextBaseEnd = "\n73\n1\n44\n1.0";
                    string MTextEntity = MTextBaseStart + MTextBaseMid + MTextBaseEnd;
                    string NewDxfCode = DxfText.Replace("ENTITIES", MTextEntity);
                    //Console.Write(NewDxfCode);
                    //Console.Write("\n -----------" + DxfText);
                    File.WriteAllText(dxf_file, NewDxfCode);
                    lblRun.Text = "Done. Select another or quit.";
                }                
            }
            else
            {
                lblRun.Text = "Select correct file types and click Run";
            }
        }
    }
}
