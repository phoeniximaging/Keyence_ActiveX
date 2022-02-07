using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VEIPv2._0
{
    class boxDrawer
    {

    }

    public static void DrawBoxes()
    {

        String tagLine;
        Size size;

        inputBitValue = new CheckBox[dataType * numberOfBits];
        inputBitText = new TextBox[dataType * numberOfBits];
        InputValuesText = new TextBox[maxDataTypes];
        InputValuesLabel = new TextBox[maxDataTypes];

        OutputValueNumber = new NumericUpDown[maxDataTypes];
        OutputValuesLabel = new TextBox[maxDataTypes];
        outputBitValue = new CheckBox[dataType * numberOfBits];
        outputBitText = new TextBox[dataType * numberOfBits];

        for (int j = 0; j < numberOfBits; j++)
        {
            for (int i = 0; i < dataType; i++)
            {
                inputBitText[dataType * j + i] = new TextBox();
                inputBitText[dataType * j + i].Margin = new Padding(0);
                inputBitText[dataType * j + i].Dock = DockStyle.Right;
                inputBitText[dataType * j + i].TextAlign = HorizontalAlignment.Right;
                inputBitText[dataType * j + i].Text = "[" + Convert.ToString(j) + "]." + Convert.ToString(i);
                size = GetSize(inputBitText[dataType * j + i]);
                inputBitText[dataType * j + i].Width = 180;
                inputBitText[dataType * j + i].Height = size.Height;
                inputBitText[dataType * j + i].ReadOnly = true;
                inputValueTextPanel.Controls.Add(inputBitText[dataType * j + i]);

                inputBitValue[dataType * j + i] = new CheckBox();
                inputBitValue[dataType * j + i].Text = "";
                inputBitValue[dataType * j + i].Margin = new Padding(0);
                inputBitValue[dataType * j + i].Width = 15;
                inputBitValue[dataType * j + i].Height = size.Height;
                inputBitValue[dataType * j + i].CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
                inputBitValue[dataType * j + i].Enabled = false;
                inputFlagPanel.Controls.Add(inputBitValue[dataType * j + i]);

                outputBitValue[dataType * j + i] = new CheckBox();
                outputBitValue[dataType * j + i].Text = "";
                outputBitValue[dataType * j + i].Margin = new Padding(0);
                outputBitValue[dataType * j + i].Width = 15;
                outputBitValue[dataType * j + i].Height = 20;
                outputBitValue[dataType * j + i].Enabled = true;
                outputFlagPanel.Controls.Add(outputBitValue[dataType * j + i]);

                outputBitText[dataType * j + i] = new TextBox();
                outputBitText[dataType * j + i].Margin = new Padding(0);
                outputBitText[dataType * j + i].Dock = DockStyle.Left;
                outputBitText[dataType * j + i].Width = 79;
                outputBitText[dataType * j + i].TextAlign = HorizontalAlignment.Right;
                outputBitText[dataType * j + i].Text = "[" + Convert.ToString(j) + "]." + Convert.ToString(i);
                outputBitText[dataType * j + i].ReadOnly = true;
                outputValueTextPanel.Controls.Add(outputBitText[dataType * j + i]);
            }
        }

        //creates and formats all input text boxes
        //start loop at 1 instead of 0 because the first DINT (byte address 0) is for bit allocation. The following is byte allocation, which starts at DINT 1
        for (int i = numberOfBits; i < maxDataTypes; i++)
        {
            InputValuesText[i] = new TextBox();
            InputValuesText[i].Margin = new Padding(0);
            InputValuesText[i].Dock = DockStyle.Left;
            InputValuesText[i].Width = 79;
            InputValuesText[i].TextAlign = HorizontalAlignment.Right;
            InputValuesText[i].ReadOnly = true;


            InputValuesLabel[i] = new TextBox();
            InputValuesLabel[i].Margin = new Padding(0);
            InputValuesLabel[i].Dock = DockStyle.Left;
            InputValuesLabel[i].Width = 79;
            InputValuesLabel[i].TextAlign = HorizontalAlignment.Right;
            InputValuesLabel[i].Text = "[" + Convert.ToString(i) + "]";
            InputValuesLabel[i].ReadOnly = true;


            InputValueLabelPanel.Controls.Add(InputValuesLabel[i]);
            InputDataListPanel.Controls.Add(InputValuesText[i]);

            //Outputs
            OutputValueNumber[i] = new NumericUpDown();
            OutputValueNumber[i].Margin = new Padding(0);
            OutputValueNumber[i].Dock = DockStyle.Left;
            OutputValueNumber[i].Width = 79;
            OutputValueNumber[i].TextAlign = HorizontalAlignment.Right;
            OutputValueNumber[i].Text = "0";

            OutputValuesLabel[i] = new TextBox();
            OutputValuesLabel[i].Margin = new Padding(0);
            OutputValuesLabel[i].Dock = DockStyle.Left;
            OutputValuesLabel[i].Width = 79;
            OutputValuesLabel[i].TextAlign = HorizontalAlignment.Right;
            OutputValuesLabel[i].Text = "[" + Convert.ToString(i) + "]";
            OutputValuesLabel[i].ReadOnly = true;
            outputAddressLabelPanel.Controls.Add(OutputValuesLabel[i]);
            outputDataListPanel.Controls.Add(OutputValueNumber[i]);

        }

        //add tags to list
        string currentText = "";
        StreamReader sr = new StreamReader(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + @"\VEIP_Tags.csv");
        for (int i = 0; i < inputBitText.Length; i++)
        {
            currentText = inputBitText[i].Text;
            tagLine = sr.ReadLine();
            inputBitText[i].Text = tagLine + currentText;
        }

        //WHY IS IT NULL!!???
        //for(int i = 0; i < InputValuesLabel.Length; i++)
        //{
        //currentText = InputValuesLabel[i].Text;
        //tagLine = sr.ReadLine();
        //InputValuesLabel[i].Text = tagLine + currentText;
        //}
        for (int i = 0; i < outputBitText.Length; i++)
        {
            Console.Write(outputBitText[i].Text);
            currentText = outputBitText[i].Text;
            tagLine = sr.ReadLine();
            outputBitText[i].Text = tagLine + currentText;
        }
        //for (int i = 0; i < OutputValuesLabel.Length; i++)
        //{
        //   currentText = OutputValuesLabel[i].Text;
        //    tagLine = sr.ReadLine();
        //    OutputValuesLabel[i].Text = tagLine + currentText;
        //}


        inputFlagPanel.Update();
        inputValueTextPanel.Update();
        outputFlagPanel.Update();
        outputValueTextPanel.Update();
        InputValueLabelPanel.Update();
        InputDataListPanel.Update();
        outputAddressLabelPanel.Update();
        outputDataListPanel.Update();
    }

}
