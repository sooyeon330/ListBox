﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListBox
{
    public partial class Form1 : Form
    {
        private string OrgStr = ""; //결과 : 저장
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.OrgStr = this.lbResult.Text;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (this.txtList.Text != "")
            {
                this.lbView.Items.Add(this.txtList.Text);
                this.txtList.Text = "";
                this.txtList.Focus();
            }
            else
            {
                MessageBox.Show("추가할 아이템을 입력하세요", "알림",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtList.Focus();
            }

        }
        private void LbView_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.lbResult.Text = this.OrgStr + this.lbView.SelectedItem.ToString();
        }

        private void TxtList_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                if (this.txtList.Text != "")
                {
                    this.lbView.Items.Add(this.txtList.Text);
                    this.txtList.Text = "";
                    this.txtList.Focus();
                }
                else
                {
                    MessageBox.Show("추가할 아이템을 입력하세요", "알림",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.txtList.Focus();
                }
            }
        }
    }
}
