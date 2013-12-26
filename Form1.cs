namespace ResistorCalculator {
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Reflection;
    using System.Windows.Forms;

    internal sealed partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            var ver = Assembly.GetAssembly(typeof(Form1)).GetName().Version;
            Text = string.Format("Resistor Calculator v{0}.{1}", ver.Major, ver.Minor);
            band1.DataSource = MakeValueList();
            band2.DataSource = MakeValueList();
            Make3Band();
        }

        private static List<Resistor> MakeValueList() {
            var ret = new List<Resistor> {
                new Resistor("Black", 0),
                new Resistor("Brown", 1),
                new Resistor("Red", 2),
                new Resistor("Orange", 3),
                new Resistor("Yellow", 4),
                new Resistor("Green", 5),
                new Resistor("Blue", 6),
                new Resistor("Violet", 7),
                new Resistor("Grey", 8),
                new Resistor("White", 9)
            };
            return ret;
        }

        private static List<Resistor> MakeMultiList(int bands) {
            var ret = new List<Resistor> {
                new Resistor("Black", 1),
                new Resistor("Brown", 10),
                new Resistor("Red", 100),
                new Resistor("Orange", 1000),
                new Resistor("Yellow", 10000),
                new Resistor("Green", 100000),
                new Resistor("Blue", 1000000),
                new Resistor("Violet", 10000000),
                new Resistor("Grey", 100000000),
                new Resistor("White", 1000000000),
                new Resistor("Gold", 0.1)
            };
            if (bands >= 5)
                ret.Add(new Resistor("Silver", 0.01));
            return ret;
        }

        private static List<Resistor> MakeToleranceList() {
            var ret = new List<Resistor> {
                new Resistor("Brown", 1),
                new Resistor("Red", 2),
                new Resistor("Green", 0.5),
                new Resistor("Blue", 0.25),
                new Resistor("Violet", 0.1),
                new Resistor("Grey", 0.05),
                new Resistor("Gold", 5),
                new Resistor("Silver", 10)
            };
            return ret;
        }

        private static List<Resistor> MakeTempList() {
            var ret = new List<Resistor> {
                new Resistor("Brown", 100),
                new Resistor("Red", 50),
                new Resistor("Orange", 15),
                new Resistor("Yellow", 25)
            };
            return ret;
        }

        private void Make3Band() {
            band3.DataSource = MakeMultiList(3);
        }

        private void Make4Band() {
            Make3Band();
            band4.DataSource = MakeToleranceList();
        }

        private void Make5Band() {
            band3.DataSource = MakeValueList();
            band4.DataSource = MakeMultiList(5);
            band5.DataSource = MakeToleranceList();
        }

        private void Make6Band() {
            Make5Band();
            band6.DataSource = MakeTempList();
        }

        private void ClearBands() {
            band3.DataSource = null;
            band4.DataSource = null;
            band5.DataSource = null;
            band6.DataSource = null;
        }

        private void BandCountChanged(object sender, EventArgs e) {
            ClearBands();
            band4.Enabled = bandc4.Checked || bandc5.Checked || bandc6.Checked;
            band5.Enabled = bandc5.Checked || bandc6.Checked;
            band6.Enabled = bandc6.Checked;
            if(bandc3.Checked)
                Make3Band();
            if(bandc4.Checked)
                Make4Band();
            if(bandc5.Checked)
                Make5Band();
            if(bandc6.Checked)
                Make6Band();
        }

        private void CalcvalbtnClick(object sender, EventArgs e) { MessageBox.Show(CalcValue(bandc3.Checked ? 3 : bandc4.Checked ? 4 : bandc5.Checked ? 5 : 6)); }

        private static string GetReadable(ulong val) {
            if(val < 1000000 && val > 1000)
                return (val / (double) 1000) + "K" + "Ω";
            if (val < 1000000000 && val > 1000000)
                return (val / (double) 1000000) + "M" + "Ω";
            if (val > 1000000000)
                return (val / (double)1000000000) + "G" + "Ω";
            return val.ToString(CultureInfo.InvariantCulture) + "Ω";
        }

        private string CalcValue(int bands) {
            var ret = ((Resistor) band1.SelectedItem).Value.ToString(CultureInfo.InvariantCulture);
            ret += ((Resistor) band2.SelectedItem).Value.ToString(CultureInfo.InvariantCulture);
            ulong tmp;
            Resistor multi;
            Resistor tolerance;
            switch(bands) {
                case 3:
                    multi = (Resistor) band3.SelectedItem;
                    tmp = ulong.Parse(ret);
                    return GetReadable((ulong) (tmp * (multi.IsBelowZero ? multi.Value2 : multi.Value))) + " ± 20%";
                case 4:
                    multi = (Resistor) band3.SelectedItem;
                    tolerance = (Resistor) band4.SelectedItem;
                    tmp = ulong.Parse(ret);
                    return GetReadable((ulong) (tmp * (multi.IsBelowZero ? multi.Value2 : multi.Value))) + " ± " + (tolerance.IsBelowZero ? tolerance.Value2 : tolerance.Value) + "%";
                case 5:
                    ret += ((Resistor) band3.SelectedItem).Value.ToString(CultureInfo.InvariantCulture);
                    multi = (Resistor) band4.SelectedItem;
                    tolerance = (Resistor) band5.SelectedItem;
                    tmp = ulong.Parse(ret);
                    return GetReadable((ulong) (tmp * (multi.IsBelowZero ? multi.Value2 : multi.Value))) + " ± " + (tolerance.IsBelowZero ? tolerance.Value2 : tolerance.Value) + "%";
                default:
                    ret += ((Resistor) band3.SelectedItem).Value.ToString(CultureInfo.InvariantCulture);
                    multi = (Resistor) band4.SelectedItem;
                    tolerance = (Resistor) band5.SelectedItem;
                    tmp = ulong.Parse(ret);
                    return GetReadable((ulong) (tmp * (multi.IsBelowZero ? multi.Value2 : multi.Value))) + " ± " + (tolerance.IsBelowZero ? tolerance.Value2 : tolerance.Value) + "% " + ((Resistor) band6.SelectedItem).Value + "ppm";
            }
        }
    }
}