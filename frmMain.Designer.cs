﻿namespace jjget
{
    partial class frmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnGetIndex = new System.Windows.Forms.Button();
            this.grpBookInfo = new System.Windows.Forms.GroupBox();
            this.lblChapterCnt = new System.Windows.Forms.Label();
            this.lblFinnished = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnChooseSaveLoc = new System.Windows.Forms.Button();
            this.txtSaveLoc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.grpConfig = new System.Windows.Forms.GroupBox();
            this.chkIgnoreFontDecodingError = new System.Windows.Forms.CheckBox();
            this.lblLoginInfo = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnOpenDir = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.chkUsePwdMask = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.chkUseMobileEdition = new System.Windows.Forms.CheckBox();
            this.txtProxyPort = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtProxyServ = new System.Windows.Forms.TextBox();
            this.chkUseProxy = new System.Windows.Forms.CheckBox();
            this.chkSplitChapter = new System.Windows.Forms.CheckBox();
            this.picVerifyCode = new System.Windows.Forms.PictureBox();
            this.txtVerifyCode = new System.Windows.Forms.TextBox();
            this.lblPromptM = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCntDone = new System.Windows.Forms.Label();
            this.picProgress = new System.Windows.Forms.PictureBox();
            this.lblProgBar = new System.Windows.Forms.Label();
            this.txtNovelID = new System.Windows.Forms.TextBox();
            this.lblPromptU = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.lblPromptD = new System.Windows.Forms.Label();
            this.txtStartChap = new System.Windows.Forms.TextBox();
            this.txtEndChap = new System.Windows.Forms.TextBox();
            this.grpBookInfo.SuspendLayout();
            this.grpConfig.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picVerifyCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProgress)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGetIndex
            // 
            this.btnGetIndex.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.btnGetIndex.Location = new System.Drawing.Point(346, 55);
            this.btnGetIndex.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGetIndex.Name = "btnGetIndex";
            this.btnGetIndex.Size = new System.Drawing.Size(108, 27);
            this.btnGetIndex.TabIndex = 0;
            this.btnGetIndex.Text = "GET√";
            this.btnGetIndex.UseVisualStyleBackColor = true;
            this.btnGetIndex.Click += new System.EventHandler(this.btnGetIndex_Click);
            // 
            // grpBookInfo
            // 
            this.grpBookInfo.Controls.Add(this.lblChapterCnt);
            this.grpBookInfo.Controls.Add(this.lblFinnished);
            this.grpBookInfo.Controls.Add(this.label3);
            this.grpBookInfo.Controls.Add(this.lblAuthor);
            this.grpBookInfo.Controls.Add(this.label2);
            this.grpBookInfo.Controls.Add(this.label1);
            this.grpBookInfo.Location = new System.Drawing.Point(21, 12);
            this.grpBookInfo.Name = "grpBookInfo";
            this.grpBookInfo.Size = new System.Drawing.Size(316, 219);
            this.grpBookInfo.TabIndex = 2;
            this.grpBookInfo.TabStop = false;
            this.grpBookInfo.Text = "书名";
            // 
            // lblChapterCnt
            // 
            this.lblChapterCnt.AutoSize = true;
            this.lblChapterCnt.Location = new System.Drawing.Point(245, 22);
            this.lblChapterCnt.Name = "lblChapterCnt";
            this.lblChapterCnt.Size = new System.Drawing.Size(21, 24);
            this.lblChapterCnt.TabIndex = 4;
            this.lblChapterCnt.Text = "0";
            // 
            // lblFinnished
            // 
            this.lblFinnished.AutoSize = true;
            this.lblFinnished.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblFinnished.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblFinnished.Location = new System.Drawing.Point(274, 22);
            this.lblFinnished.Name = "lblFinnished";
            this.lblFinnished.Size = new System.Drawing.Size(48, 25);
            this.lblFinnished.TabIndex = 5;
            this.lblFinnished.Text = "完结";
            this.lblFinnished.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(202, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "章节：";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(60, 22);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(64, 24);
            this.lblAuthor.TabIndex = 2;
            this.lblAuthor.Text = "某太太";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(10, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(285, 169);
            this.label2.TabIndex = 1;
            this.label2.Text = "（＊￣︶￣）ｙ　";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "作者：";
            // 
            // btnStart
            // 
            this.btnStart.Enabled = false;
            this.btnStart.Font = new System.Drawing.Font("微软雅黑", 15F);
            this.btnStart.Location = new System.Drawing.Point(346, 118);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(108, 45);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "开始";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnChooseSaveLoc
            // 
            this.btnChooseSaveLoc.Location = new System.Drawing.Point(343, 21);
            this.btnChooseSaveLoc.Name = "btnChooseSaveLoc";
            this.btnChooseSaveLoc.Size = new System.Drawing.Size(88, 28);
            this.btnChooseSaveLoc.TabIndex = 4;
            this.btnChooseSaveLoc.Text = "浏览…";
            this.btnChooseSaveLoc.UseVisualStyleBackColor = true;
            this.btnChooseSaveLoc.Click += new System.EventHandler(this.btnChooseSaveLoc_Click);
            // 
            // txtSaveLoc
            // 
            this.txtSaveLoc.Location = new System.Drawing.Point(15, 53);
            this.txtSaveLoc.Name = "txtSaveLoc";
            this.txtSaveLoc.Size = new System.Drawing.Size(413, 31);
            this.txtSaveLoc.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(10, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "保存路径:";
            // 
            // grpConfig
            // 
            this.grpConfig.Controls.Add(this.chkIgnoreFontDecodingError);
            this.grpConfig.Controls.Add(this.lblLoginInfo);
            this.grpConfig.Controls.Add(this.label9);
            this.grpConfig.Controls.Add(this.btnOpenDir);
            this.grpConfig.Controls.Add(this.btnLogin);
            this.grpConfig.Controls.Add(this.chkUsePwdMask);
            this.grpConfig.Controls.Add(this.label8);
            this.grpConfig.Controls.Add(this.txtPwd);
            this.grpConfig.Controls.Add(this.txtUsername);
            this.grpConfig.Controls.Add(this.label7);
            this.grpConfig.Controls.Add(this.chkUseMobileEdition);
            this.grpConfig.Controls.Add(this.txtProxyPort);
            this.grpConfig.Controls.Add(this.label6);
            this.grpConfig.Controls.Add(this.txtProxyServ);
            this.grpConfig.Controls.Add(this.chkUseProxy);
            this.grpConfig.Controls.Add(this.label4);
            this.grpConfig.Controls.Add(this.btnChooseSaveLoc);
            this.grpConfig.Controls.Add(this.chkSplitChapter);
            this.grpConfig.Controls.Add(this.txtSaveLoc);
            this.grpConfig.Controls.Add(this.picVerifyCode);
            this.grpConfig.Controls.Add(this.txtVerifyCode);
            this.grpConfig.Location = new System.Drawing.Point(17, 387);
            this.grpConfig.Name = "grpConfig";
            this.grpConfig.Size = new System.Drawing.Size(437, 240);
            this.grpConfig.TabIndex = 7;
            this.grpConfig.TabStop = false;
            this.grpConfig.Text = "设置";
            // 
            // chkIgnoreFontDecodingError
            // 
            this.chkIgnoreFontDecodingError.AutoSize = true;
            this.chkIgnoreFontDecodingError.Location = new System.Drawing.Point(319, 196);
            this.chkIgnoreFontDecodingError.Name = "chkIgnoreFontDecodingError";
            this.chkIgnoreFontDecodingError.Size = new System.Drawing.Size(300, 28);
            this.chkIgnoreFontDecodingError.TabIndex = 24;
            this.chkIgnoreFontDecodingError.Text = "使用？替代V章中解码失败的字符";
            this.toolTip1.SetToolTip(this.chkIgnoreFontDecodingError, "选中后，如果VIP章节中的加密文字解密失败，则使用问号替代且继续下载。仅在解码错误较少且下载内容可读时勾选。");
            this.chkIgnoreFontDecodingError.UseVisualStyleBackColor = true;
            this.chkIgnoreFontDecodingError.Visible = false;
            this.chkIgnoreFontDecodingError.CheckedChanged += new System.EventHandler(this.chkIgnoreFontDecodingError_CheckedChanged);
            // 
            // lblLoginInfo
            // 
            this.lblLoginInfo.Location = new System.Drawing.Point(316, 153);
            this.lblLoginInfo.Name = "lblLoginInfo";
            this.lblLoginInfo.Size = new System.Drawing.Size(112, 74);
            this.lblLoginInfo.TabIndex = 18;
            this.lblLoginInfo.Text = "登陆信息";
            this.lblLoginInfo.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(234, 195);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 24);
            this.label9.TabIndex = 23;
            this.label9.Text = "验证码";
            // 
            // btnOpenDir
            // 
            this.btnOpenDir.Location = new System.Drawing.Point(247, 21);
            this.btnOpenDir.Name = "btnOpenDir";
            this.btnOpenDir.Size = new System.Drawing.Size(88, 28);
            this.btnOpenDir.TabIndex = 20;
            this.btnOpenDir.Text = "打开";
            this.btnOpenDir.UseVisualStyleBackColor = true;
            this.btnOpenDir.Click += new System.EventHandler(this.btnOpenDir_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(347, 124);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 26);
            this.btnLogin.TabIndex = 17;
            this.btnLogin.Text = "登陆";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // chkUsePwdMask
            // 
            this.chkUsePwdMask.AutoSize = true;
            this.chkUsePwdMask.Checked = true;
            this.chkUsePwdMask.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkUsePwdMask.Location = new System.Drawing.Point(228, 155);
            this.chkUsePwdMask.Name = "chkUsePwdMask";
            this.chkUsePwdMask.Size = new System.Drawing.Size(72, 28);
            this.chkUsePwdMask.TabIndex = 17;
            this.chkUsePwdMask.Text = "密码";
            this.chkUsePwdMask.UseVisualStyleBackColor = true;
            this.chkUsePwdMask.CheckedChanged += new System.EventHandler(this.chkUsePwdMask_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 158);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 24);
            this.label8.TabIndex = 16;
            this.label8.Text = "用户名";
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(289, 153);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '*';
            this.txtPwd.Size = new System.Drawing.Size(139, 31);
            this.txtPwd.TabIndex = 15;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(62, 153);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(160, 31);
            this.txtUsername.TabIndex = 14;
            this.txtUsername.Leave += new System.EventHandler(this.txtUsername_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(100, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 24);
            this.label7.TabIndex = 13;
            this.label7.Text = "http://";
            // 
            // chkUseMobileEdition
            // 
            this.chkUseMobileEdition.AutoSize = true;
            this.chkUseMobileEdition.Location = new System.Drawing.Point(156, 123);
            this.chkUseMobileEdition.Name = "chkUseMobileEdition";
            this.chkUseMobileEdition.Size = new System.Drawing.Size(126, 28);
            this.chkUseMobileEdition.TabIndex = 12;
            this.chkUseMobileEdition.Text = "使用手机版";
            this.chkUseMobileEdition.UseVisualStyleBackColor = true;
            // 
            // txtProxyPort
            // 
            this.txtProxyPort.Enabled = false;
            this.txtProxyPort.Location = new System.Drawing.Point(354, 88);
            this.txtProxyPort.Name = "txtProxyPort";
            this.txtProxyPort.Size = new System.Drawing.Size(55, 31);
            this.txtProxyPort.TabIndex = 11;
            this.txtProxyPort.Text = "80";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(339, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 24);
            this.label6.TabIndex = 10;
            this.label6.Text = ":";
            // 
            // txtProxyServ
            // 
            this.txtProxyServ.Enabled = false;
            this.txtProxyServ.Location = new System.Drawing.Point(156, 88);
            this.txtProxyServ.Name = "txtProxyServ";
            this.txtProxyServ.Size = new System.Drawing.Size(179, 31);
            this.txtProxyServ.TabIndex = 9;
            // 
            // chkUseProxy
            // 
            this.chkUseProxy.AutoSize = true;
            this.chkUseProxy.Location = new System.Drawing.Point(15, 90);
            this.chkUseProxy.Name = "chkUseProxy";
            this.chkUseProxy.Size = new System.Drawing.Size(108, 28);
            this.chkUseProxy.TabIndex = 8;
            this.chkUseProxy.Text = "使用代理";
            this.chkUseProxy.UseVisualStyleBackColor = true;
            this.chkUseProxy.CheckedChanged += new System.EventHandler(this.chkUseProxy_CheckedChanged);
            // 
            // chkSplitChapter
            // 
            this.chkSplitChapter.AutoSize = true;
            this.chkSplitChapter.Location = new System.Drawing.Point(14, 123);
            this.chkSplitChapter.Name = "chkSplitChapter";
            this.chkSplitChapter.Size = new System.Drawing.Size(162, 28);
            this.chkSplitChapter.TabIndex = 7;
            this.chkSplitChapter.Text = "每章节一个文件";
            this.chkSplitChapter.UseVisualStyleBackColor = true;
            // 
            // picVerifyCode
            // 
            this.picVerifyCode.Location = new System.Drawing.Point(62, 190);
            this.picVerifyCode.Name = "picVerifyCode";
            this.picVerifyCode.Size = new System.Drawing.Size(160, 27);
            this.picVerifyCode.TabIndex = 21;
            this.picVerifyCode.TabStop = false;
            // 
            // txtVerifyCode
            // 
            this.txtVerifyCode.Enabled = false;
            this.txtVerifyCode.Location = new System.Drawing.Point(289, 192);
            this.txtVerifyCode.Name = "txtVerifyCode";
            this.txtVerifyCode.Size = new System.Drawing.Size(139, 31);
            this.txtVerifyCode.TabIndex = 16;
            // 
            // lblPromptM
            // 
            this.lblPromptM.AutoEllipsis = true;
            this.lblPromptM.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblPromptM.Location = new System.Drawing.Point(24, 262);
            this.lblPromptM.Name = "lblPromptM";
            this.lblPromptM.Size = new System.Drawing.Size(424, 28);
            this.lblPromptM.TabIndex = 8;
            this.lblPromptM.Click += new System.EventHandler(this.LblPrompt_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(358, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 24);
            this.label5.TabIndex = 9;
            this.label5.Text = "已完成：";
            // 
            // lblCntDone
            // 
            this.lblCntDone.AutoSize = true;
            this.lblCntDone.Location = new System.Drawing.Point(416, 168);
            this.lblCntDone.Name = "lblCntDone";
            this.lblCntDone.Size = new System.Drawing.Size(21, 24);
            this.lblCntDone.TabIndex = 10;
            this.lblCntDone.Text = "0";
            // 
            // picProgress
            // 
            this.picProgress.Image = ((System.Drawing.Image)(resources.GetObject("picProgress.Image")));
            this.picProgress.Location = new System.Drawing.Point(13, 318);
            this.picProgress.Name = "picProgress";
            this.picProgress.Size = new System.Drawing.Size(53, 65);
            this.picProgress.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picProgress.TabIndex = 11;
            this.picProgress.TabStop = false;
            this.picProgress.Visible = false;
            // 
            // lblProgBar
            // 
            this.lblProgBar.AutoSize = true;
            this.lblProgBar.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgBar.Location = new System.Drawing.Point(69, 363);
            this.lblProgBar.Name = "lblProgBar";
            this.lblProgBar.Size = new System.Drawing.Size(30, 22);
            this.lblProgBar.TabIndex = 12;
            this.lblProgBar.Text = "0%";
            this.lblProgBar.Visible = false;
            // 
            // txtNovelID
            // 
            this.txtNovelID.Location = new System.Drawing.Point(346, 21);
            this.txtNovelID.Name = "txtNovelID";
            this.txtNovelID.Size = new System.Drawing.Size(108, 31);
            this.txtNovelID.TabIndex = 13;
            // 
            // lblPromptU
            // 
            this.lblPromptU.AutoEllipsis = true;
            this.lblPromptU.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblPromptU.Location = new System.Drawing.Point(24, 234);
            this.lblPromptU.Name = "lblPromptU";
            this.lblPromptU.Size = new System.Drawing.Size(424, 28);
            this.lblPromptU.TabIndex = 14;
            this.lblPromptU.Click += new System.EventHandler(this.LblPrompt_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 10000;
            this.toolTip1.InitialDelay = 500;
            this.toolTip1.ReshowDelay = 100;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.linkLabel1.Location = new System.Drawing.Point(360, 190);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(97, 24);
            this.linkLabel1.TabIndex = 15;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "开源许可…";
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.LinkColor = System.Drawing.Color.Teal;
            this.linkLabel2.Location = new System.Drawing.Point(377, 212);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(46, 24);
            this.linkLabel2.TabIndex = 16;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "帮助";
            this.linkLabel2.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // lblPromptD
            // 
            this.lblPromptD.AutoEllipsis = true;
            this.lblPromptD.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblPromptD.Location = new System.Drawing.Point(24, 290);
            this.lblPromptD.Name = "lblPromptD";
            this.lblPromptD.Size = new System.Drawing.Size(424, 28);
            this.lblPromptD.TabIndex = 17;
            this.lblPromptD.Click += new System.EventHandler(this.LblPrompt_Click);
            // 
            // txtStartChap
            // 
            this.txtStartChap.Location = new System.Drawing.Point(346, 84);
            this.txtStartChap.Name = "txtStartChap";
            this.txtStartChap.Size = new System.Drawing.Size(49, 31);
            this.txtStartChap.TabIndex = 18;
            // 
            // txtEndChap
            // 
            this.txtEndChap.Location = new System.Drawing.Point(405, 84);
            this.txtEndChap.Name = "txtEndChap";
            this.txtEndChap.Size = new System.Drawing.Size(49, 31);
            this.txtEndChap.TabIndex = 18;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 640);
            this.Controls.Add(this.txtEndChap);
            this.Controls.Add(this.txtStartChap);
            this.Controls.Add(this.lblPromptD);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.lblPromptU);
            this.Controls.Add(this.txtNovelID);
            this.Controls.Add(this.lblProgBar);
            this.Controls.Add(this.picProgress);
            this.Controls.Add(this.lblCntDone);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblPromptM);
            this.Controls.Add(this.grpConfig);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.grpBookInfo);
            this.Controls.Add(this.btnGetIndex);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JJGET";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.grpBookInfo.ResumeLayout(false);
            this.grpBookInfo.PerformLayout();
            this.grpConfig.ResumeLayout(false);
            this.grpConfig.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picVerifyCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProgress)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetIndex;
        private System.Windows.Forms.GroupBox grpBookInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblChapterCnt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnChooseSaveLoc;
        private System.Windows.Forms.TextBox txtSaveLoc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox grpConfig;
        private System.Windows.Forms.Label lblPromptM;
        private System.Windows.Forms.CheckBox chkSplitChapter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblCntDone;
        private System.Windows.Forms.PictureBox picProgress;
        private System.Windows.Forms.Label lblProgBar;
        private System.Windows.Forms.CheckBox chkUseProxy;
        private System.Windows.Forms.TextBox txtProxyPort;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtProxyServ;
        private System.Windows.Forms.TextBox txtNovelID;
        private System.Windows.Forms.CheckBox chkUseMobileEdition;
        private System.Windows.Forms.Label lblPromptU;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblFinnished;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.CheckBox chkUsePwdMask;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblLoginInfo;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Button btnOpenDir;
        private System.Windows.Forms.PictureBox picVerifyCode;
        private System.Windows.Forms.TextBox txtVerifyCode;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblPromptD;
        private System.Windows.Forms.CheckBox chkIgnoreFontDecodingError;
        private System.Windows.Forms.TextBox txtStartChap;
        private System.Windows.Forms.TextBox txtEndChap;
    }
}

