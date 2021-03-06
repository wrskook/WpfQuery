﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.IO;

namespace WpfQuery
{
    /// <summary>
    /// DelDomain.xaml 的交互逻辑
    /// </summary>
    public partial class DelDomain : Window
    {
        public DelDomain()
        {
            InitializeComponent();

            GetDelDomain();
        }

        private void GetDelDomain()
        {
            //读取
            string filepath = "config\\deldomain.txt";
            if (File.Exists(filepath))
            {
                string[] str = File.ReadAllLines(filepath, System.Text.Encoding.Default);
                foreach (string item in str)
                {
                    if (item.Trim() != "")
                    {
                        wtDelDomain.Text += item + "\r\n";
                    }
                }
            }
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string str = wtDelDomain.Text.Trim();
            string Adr = "config\\deldomain.txt";
            //把txt清空
            FileStream stream = File.Open(Adr, FileMode.OpenOrCreate, FileAccess.Write);
            stream.Seek(0, SeekOrigin.Begin);
            stream.SetLength(0);
            stream.Close();
            //向txt里面追加信息
            StreamWriter sw = new StreamWriter(Adr, true, Encoding.GetEncoding("gb2312"));
            sw.WriteLine(str);
            sw.Flush();
            sw.Close();
        }
    }
}
