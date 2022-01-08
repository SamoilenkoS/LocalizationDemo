using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocalizationDemo
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void russianMenuItem_Click(object sender, EventArgs e)
        {
            russianMenuItem.Checked = true;
            englishMenuItem.Checked = false;
        }

        private void englishMenuItem_Click(object sender, EventArgs e)
        {
            russianMenuItem.Checked = false;
            englishMenuItem.Checked = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormLocalization ru = LoadFromFile("ru.txt");
            var ruLocale = JsonSerializer.Serialize(ru);
            //SaveLocaleToFile(ruLocale, "ru.txt");
            FormLocalization en = new FormLocalization
            {
                fileMenuItem = "File",
                openMenuItem = "Open"
            };
            FormLocalization current = null;
            if (englishMenuItem.Checked)
            {
                current = en;
            }
            else if (russianMenuItem.Checked)
            {
                current = ru;
            }

            LoadLocale(current);
        }

        private FormLocalization LoadFromFile(string filepath)
        {
            using (StreamReader streamReader = new StreamReader(filepath))
            {
                var str = streamReader.ReadToEnd();
                FormLocalization formLocalization = JsonSerializer.Deserialize<FormLocalization>(str);
                return formLocalization;
            }
        }

        private void SaveLocaleToFile(string locale, string filepath)
        {
            using(StreamWriter streamWriter = new StreamWriter(filepath))
            {
                streamWriter.Write(locale);
            }
        }

        private void LoadLocale(FormLocalization current)
        {
            fileMenuItem.Text = current.fileMenuItem;
            openMenuItem.Text = current.openMenuItem;
        }

        private List<string> Recursion(GroupBox groupBox, int count)
        {
            List<string> result = new List<string>();
            StringBuilder stringBuilder = new StringBuilder(string.Empty);
            for (int i = 0; i < count; i++)
            {
                stringBuilder.Append("\t");
            }

            var currentTabs = stringBuilder.ToString();
            foreach (var item in groupBox.Controls.Cast<Control>())
            {
                result.Add(
                    currentTabs
                    + item.Name
                    + ":"
                    + item.Text);

                if (item is GroupBox)
                {
                    result.AddRange(Recursion(item as GroupBox, count + 1));
                }
                else if(item is ListBox)
                {
                    ListBox current = item as ListBox;
                    foreach (var listBoxItem in current.Items)
                    {
                        result.Add(currentTabs + "\t" + listBoxItem);
                    }
                }
            }

            return result;
        }

        private List<string> Recursion(ToolStripMenuItem menuItem, int count)
        {
            List<string> result = new List<string>();
            StringBuilder stringBuilder = new StringBuilder(string.Empty);
            for (int i = 0; i < count; i++)
            {
                stringBuilder.Append("\t");
            }

            var currentTabs = stringBuilder.ToString();
            foreach (var item in menuItem.DropDownItems.Cast<ToolStripMenuItem>())
            {
                result.Add(
                    currentTabs
                    + item.Name
                    + ":"
                    + item.Text);
            }

            return result;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using(StreamWriter streamWriter = new StreamWriter("formItems.txt"))
            {
                foreach (var item in Controls.Cast<Control>())
                {
                    streamWriter.WriteLine(item.Name + ":" + item.Text);
                    if (item is GroupBox)
                    {
                        var groupBoxComponents = Recursion(item as GroupBox, 1);
                        foreach (var groupBoxItem in groupBoxComponents)
                        {
                            streamWriter.WriteLine(groupBoxItem);
                        }
                    }
                    if(item is MenuStrip)
                    {
                        MenuStrip menu = item as MenuStrip;
                        foreach(var menuItem in menu.Items.Cast<ToolStripMenuItem>())
                        {
                            var menuItems = Recursion(menuItem, 1);
                            foreach (var mSubItenm in menuItems)
                            {
                                streamWriter.WriteLine(mSubItenm);
                            }
                           
                        }
                    }
                }
            }
        }
    }
}
