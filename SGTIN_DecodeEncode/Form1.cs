using SGTIN_DecodeEncode.Logic;
using SGTIN_DecodeEncode.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGTIN_DecodeEncode
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] lines = System.IO.File.ReadAllLines(@"..\..\..\data.csv");
            product_ComboBox.DataSource = lines;

            typeOfSGTIN_ComboBox.SelectedIndex = 0;
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            SGTIN sGTIN = new SGTIN();

            try
            {
                _numberOfSGTINBits = sGTIN.GetSGTINNumberOfBits(((ComboBox)sender).SelectedItem.ToString());
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void ChooseFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.CheckFileExists = true;
            openFileDialog.AddExtension = true;
            openFileDialog.Multiselect = false;
            openFileDialog.Filter = "txt files (*.txt)|*.txt";

            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                _FiePath = openFileDialog.FileName;
                label1.Text = openFileDialog.SafeFileName;
            }
        }

        private void product_ComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            string[] productArray = ((string)((ComboBox)sender).SelectedValue).Split(';');

            _Product = new Product();
            _Product.CompanyPrefix = productArray[0];
            _Product.CompanyName = productArray[1];
            _Product.ItemReference = productArray[2];
            _Product.ItemName = productArray[3];
        }

        private void Serach_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();

            if (_FiePath == null || _FiePath == "")
            {
                MessageBox.Show("Please choose SGTN EPC file");
                return;
            }

            SGTIN sgtin = new SGTIN();
            System.IO.StreamReader file = new System.IO.StreamReader(_FiePath);
            string line = "";

            while ((line = file.ReadLine()) != null)
            {
                if(line[0] != '3' || line[1] != '0')
                {
                    _invalidSGTIN96_EPC += 1;
                    continue;
                }

                try
                {
                    //Call method and remove Header
                    string binary = sgtin.ConvertHexToListOfInts(line.Remove(0, 2).ToCharArray(), _numberOfSGTINBits);

                    //Remove Filter
                    binary = binary.Remove(0, 3);

                    //Get partition and remove it
                    int partition = Convert.ToInt32(binary.Substring(0, 3), 2);
                    binary = binary.Remove(0, 3);

                    //Get number of digits for Company Prefix, get Company Prefix and remove digits from list
                    int companyPrefixBits = sgtin.GetNumberOfBitsForCompanyPrefix(partition);
                    long companyPrefix = Convert.ToInt64(binary.Substring(0, companyPrefixBits), 2);
                    binary = binary.Remove(0, companyPrefixBits);

                    //Get number of digits for Item Reference, get Item Reference and remove digits from list
                    int itemReferenceBits = sgtin.GetNumberOfBitsForItemReference(partition);
                    long itemReference = Convert.ToInt64(binary.Substring(0, itemReferenceBits), 2);
                    binary = binary.Remove(0, itemReferenceBits);

                    //Compare Item Reference and add to listView
                    if (itemReference.ToString() == _Product.ItemReference)
                    {
                        int serialNumber = Convert.ToInt32(binary, 2);

                        ListViewItem listItem = new ListViewItem(_Product.CompanyName);
                        listItem.SubItems.Add(_Product.ItemName);
                        listItem.SubItems.Add(serialNumber.ToString());
                        listView1.Items.Add(listItem);
                        listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);

                        _numberOfSearchedItema += 1;
                    }
                }
                catch (FormatException formatException)
                {
                    if (formatException.Message == "Could not find any recognizable digits.")
                    {
                        _invalidSGTIN96_EPC += 1;
                    }
                }
            }

            numberOfInvalidSGTIN96_EPCs.Text = _invalidSGTIN96_EPC.ToString();
            numberOfSearchedItems_Label.Text = _numberOfSearchedItema.ToString();

            _invalidSGTIN96_EPC = 0;
            _numberOfSearchedItema = 0;
        }

        private int _invalidSGTIN96_EPC { get; set; }
        private int _numberOfSearchedItema { get; set; }
        private string _FiePath { get; set; }
        private Product _Product { get; set; }
        private int _numberOfSGTINBits { get; set; }
    }
}
