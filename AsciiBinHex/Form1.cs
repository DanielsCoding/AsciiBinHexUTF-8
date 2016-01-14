using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace AsciiBinHex
{
    public partial class UmrechnerAsciiHExBin : Form
    {
        List<string> BinList = new List<string>();
        //string binListString;

        bool changedByCode = false;

        public UmrechnerAsciiHExBin()
        {
            InitializeComponent();
        }

        private void textBoxAscii_TextChanged(object sender, EventArgs e)
        {
            //Ascii in Hex
            StringBuilder sBuffer = new StringBuilder();
            for (int i = 0; i < textBoxAscii.Text.Length; i++)
            {
                sBuffer.Append(Convert.ToInt32(textBoxAscii.Text[i]).ToString("x"));
            }
            textBoxHex.Text = sBuffer.ToString().ToUpper();

            HexInBin();
        }

        private void textBoxHex_TextChanged(object sender, EventArgs e)
        {
            //System.Text.UTF8Encoding encoding = new System.Text.UTF8Encoding();
            //byte[] dBytes = encoding.GetBytes(textBoxHex.Text);

            //string utf8result = System.Text.Encoding.UTF8.GetString(dBytes);
            //textBoxUTF8.Text = utf8result;

            HexInBin();
            BinInAscii();
        }

        private void textBoxBin_TextChanged(object sender, EventArgs e)
        {
            int zahlBin = 0;
            foreach (var item in textBoxBin.Text)
            {
                if (item.ToString() == "0" || item.ToString() == "1")
                {
                    zahlBin++;
                }
            }
            if (zahlBin == textBoxBin.Text.Length)
            {
                //Bin in Hex
                if (textBoxAscii.Text.Length <= 8)
                {
                    if (textBoxBin.Text.Length % 4 == 0 && textBoxBin.Text != "")
                    {
                        textBoxHex.Text = Convert.ToInt64(textBoxBin.Text, 2).ToString("X");
                    }

                    if (textBoxBin.Text == "" || textBoxBin.Text == null)
                    {
                        textBoxHex.Text = "";
                    }
                }
                BinInAscii();
            }
            else
            {
                MessageBox.Show("Ungültige Eingabe");
                textBoxBin.Text = "";
            }
        }

        private void HexInBin()
        {
            string binaercode = String.Join(String.Empty, textBoxHex.Text.Select(c => Convert.ToString(Convert.ToInt32(c.ToString(), 16), 2).PadLeft(4, '0')));
            textBoxBin.Text = binaercode;
        }

        private void BinInAscii()
        {
            if (textBoxHex.Text.Length % 2 == 0)
            {
                string binary = textBoxBin.Text;
                var list = new List<Byte>();
                for (int i = 0; i < binary.Length; i += 8)
                {
                    if (binary.Length >= i + 8)
                    {
                        String t = binary.Substring(i, 8);
                        list.Add(Convert.ToByte(t, 2));
                    }
                }
                textBoxAscii.Text = Encoding.ASCII.GetString(list.ToArray());
            }
        }

        private void textBoxUTF8_TextChanged(object sender, EventArgs e)
        {
            //UTF-8 in Hex
            //Hex in Bin
        }

        private void textBoxHex2_TextChanged(object sender, EventArgs e)
        {
            //todo
            if (!changedByCode)
            {
                HexInBin2();
            }
            changedByCode = false;

        }

        private void HexInBin2()
        {
            //ToDo1 -> fehler hier geht es nichtmehr raus und erhöht immmer den text von der box (nurr wenn ich das bei ToDo2 mache)
            string binaercode = String.Join(String.Empty, textBoxHex2.Text.Select(c => Convert.ToString(Convert.ToInt32(c.ToString(), 16), 2).PadLeft(4, '0')));

            changedByCode = true;
            textBoxBin2.Text = binaercode;


        }

        #region Methoden für UTF-8

        private void HexInUTF8()
        {
            byte[] dBytes = StringToByteArray(textBoxHex2.Text);

            string utf8result = System.Text.Encoding.UTF8.GetString(dBytes);
            textBoxUTF8.Text = utf8result;
        }

        public static byte[] StringToByteArray(String hex)
        {
            int NumberChars = hex.Length / 2;
            byte[] bytes = new byte[NumberChars];
            using (var sr = new StringReader(hex))
            {
                for (int i = 0; i < NumberChars; i++)
                    bytes[i] =
                      Convert.ToByte(new string(new char[2] { (char)sr.Read(), (char)sr.Read() }), 16);
            }
            return bytes;
        }

        #endregion

        private void textBoxBin2_TextChanged(object sender, EventArgs e)
        {
            int zahlBin2 = 0;
            foreach (var item in textBoxBin2.Text)
            {
                if (item.ToString() == "0" || item.ToString() == "1")
                {
                    zahlBin2++;
                }
            }
            if (zahlBin2 == textBoxBin2.Text.Length)
            {
                //BinInHex
                //hier hängt sich das programm auf bei hex in bin, da sich der text ändert und dardurch geht es auch beim löschen in die methode (und da die binlist immer die werte sich speichert und nicht löscht gibt es fheler)-> ToDo2
                //if (textBoxBin2.Text.Length % 4 == 0 && textBoxBin2.Text != "")
                //{
                //    binListString = "";

                //    int startindex = textBoxBin2.Text.Length - 4;
                //    string gekürtzterString = textBoxBin2.Text.Substring(startindex, textBoxBin2.Text.Length - startindex);

                //    var hexvalue = (Convert.ToInt64(gekürtzterString, 2).ToString("X"));
                //    BinList.Add(hexvalue);

                //    foreach (var item in BinList)
                //    {
                //        binListString = binListString + item.ToString();
                //    }

                //    textBoxHex2.Text = binListString;
                //}

                if (textBoxBin2.Text.Length % 4 == 0 && textBoxBin2.Text != "")
                {
                    textBoxHex2.Text = (Convert.ToInt64(textBoxBin2.Text, 2).ToString("X")); //-> zu klein sonst funktioniert es
                }

                if (textBoxBin2.Text == "" || textBoxBin2.Text == null)
                {
                    textBoxHex2.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Ungültige Eingabe");
                textBoxBin2.Text = "";
            }
            //Hex in UTF-8
            HexInUTF8();
        }

        #region KeyDown

        private void textBoxHex2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete || e.KeyCode == Keys.Return)
            {
                changedByCode = true;
            }

            if (e.KeyCode == Keys.Escape)
            {
                Beenden();
            }
        }

        private void UmrechnerAsciiHExBin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Beenden();
            }
        }

        private void Beenden()
        {
            DialogResult result = MessageBox.Show("Wollen Sie beenden?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            { }
            else
            {
                Environment.Exit(0);
            }
        }

        private void textBoxAscii_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Beenden();
            }
        }

        private void textBoxHex_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Beenden();
            }
        }

        private void textBoxBin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Beenden();
            }
        }

        private void textBoxUTF8_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Beenden();
            }
        }

        private void textBoxBin2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Beenden();
            }
        }

        #endregion
    }
}
