namespace uFR_Coder_Simplest
{
    partial class frmuFRCoderSimplest
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.stbConnected = new System.Windows.Forms.StatusStrip();
            this.pnlConnected = new System.Windows.Forms.ToolStripStatusLabel();
            this.pnlError_code = new System.Windows.Forms.ToolStripStatusLabel();
            this.pnlError_expl = new System.Windows.Forms.ToolStripStatusLabel();
            this.mnuuFRCoderSimplestItem = new System.Windows.Forms.MenuStrip();
            this.mnuExitItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtCardSerial = new System.Windows.Forms.TextBox();
            this.lblCardSerial = new System.Windows.Forms.Label();
            this.txtReadData = new System.Windows.Forms.TextBox();
            this.lblReadData = new System.Windows.Forms.Label();
            this.btnReadData = new System.Windows.Forms.Button();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.stbFunction_error = new System.Windows.Forms.StatusStrip();
            this.pnlFunct_error = new System.Windows.Forms.ToolStripStatusLabel();
            this.pnlErr_codes = new System.Windows.Forms.ToolStripStatusLabel();
            this.pnlErr_explain = new System.Windows.Forms.ToolStripStatusLabel();
            this.stbCardStatus = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.stbConnected.SuspendLayout();
            this.mnuuFRCoderSimplestItem.SuspendLayout();
            this.stbFunction_error.SuspendLayout();
            this.stbCardStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // stbConnected
            // 
            this.stbConnected.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.stbConnected.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pnlConnected,
            this.pnlError_code,
            this.pnlError_expl});
            this.stbConnected.Location = new System.Drawing.Point(0, 280);
            this.stbConnected.Name = "stbConnected";
            this.stbConnected.Size = new System.Drawing.Size(564, 22);
            this.stbConnected.SizingGrip = false;
            this.stbConnected.TabIndex = 0;
            this.stbConnected.Text = "statusStrip1";
            // 
            // pnlConnected
            // 
            this.pnlConnected.AutoSize = false;
            this.pnlConnected.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.pnlConnected.Name = "pnlConnected";
            this.pnlConnected.Size = new System.Drawing.Size(120, 17);
            // 
            // pnlError_code
            // 
            this.pnlError_code.AutoSize = false;
            this.pnlError_code.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.pnlError_code.Name = "pnlError_code";
            this.pnlError_code.Size = new System.Drawing.Size(50, 17);
            this.pnlError_code.Text = " ";
            // 
            // pnlError_expl
            // 
            this.pnlError_expl.Name = "pnlError_expl";
            this.pnlError_expl.Size = new System.Drawing.Size(372, 17);
            this.pnlError_expl.Spring = true;
            this.pnlError_expl.Text = " ";
            // 
            // mnuuFRCoderSimplestItem
            // 
            this.mnuuFRCoderSimplestItem.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuExitItem});
            this.mnuuFRCoderSimplestItem.Location = new System.Drawing.Point(0, 0);
            this.mnuuFRCoderSimplestItem.Name = "mnuuFRCoderSimplestItem";
            this.mnuuFRCoderSimplestItem.Size = new System.Drawing.Size(564, 24);
            this.mnuuFRCoderSimplestItem.TabIndex = 1;
            this.mnuuFRCoderSimplestItem.Text = "menuStrip1";
            // 
            // mnuExitItem
            // 
            this.mnuExitItem.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.mnuExitItem.Name = "mnuExitItem";
            this.mnuExitItem.Size = new System.Drawing.Size(40, 20);
            this.mnuExitItem.Text = "Exit";
            this.mnuExitItem.Click += new System.EventHandler(this.mnuExitItem_Click);
            // 
            // txtCardSerial
            // 
            this.txtCardSerial.BackColor = System.Drawing.Color.White;
            this.txtCardSerial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCardSerial.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCardSerial.Location = new System.Drawing.Point(261, 51);
            this.txtCardSerial.Name = "txtCardSerial";
            this.txtCardSerial.ReadOnly = true;
            this.txtCardSerial.Size = new System.Drawing.Size(134, 24);
            this.txtCardSerial.TabIndex = 5;
            this.txtCardSerial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblCardSerial
            // 
            this.lblCardSerial.AutoSize = true;
            this.lblCardSerial.Location = new System.Drawing.Point(170, 54);
            this.lblCardSerial.Name = "lblCardSerial";
            this.lblCardSerial.Size = new System.Drawing.Size(72, 13);
            this.lblCardSerial.TabIndex = 4;
            this.lblCardSerial.Text = "Card Serial";
            // 
            // txtReadData
            // 
            this.txtReadData.BackColor = System.Drawing.Color.White;
            this.txtReadData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtReadData.Location = new System.Drawing.Point(51, 107);
            this.txtReadData.Multiline = true;
            this.txtReadData.Name = "txtReadData";
            this.txtReadData.ReadOnly = true;
            this.txtReadData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtReadData.Size = new System.Drawing.Size(168, 108);
            this.txtReadData.TabIndex = 8;
            // 
            // lblReadData
            // 
            this.lblReadData.AutoSize = true;
            this.lblReadData.Location = new System.Drawing.Point(73, 91);
            this.lblReadData.Name = "lblReadData";
            this.lblReadData.Size = new System.Drawing.Size(100, 13);
            this.lblReadData.TabIndex = 10;
            this.lblReadData.Text = "Student Number";
            // 
            // btnReadData
            // 
            this.btnReadData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReadData.Location = new System.Drawing.Point(280, 130);
            this.btnReadData.Name = "btnReadData";
            this.btnReadData.Size = new System.Drawing.Size(223, 40);
            this.btnReadData.TabIndex = 12;
            this.btnReadData.Text = "INPUT CARD";
            this.btnReadData.UseVisualStyleBackColor = true;
            this.btnReadData.Click += new System.EventHandler(this.btnReadData_Click);
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Interval = 500;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // stbFunction_error
            // 
            this.stbFunction_error.AutoSize = false;
            this.stbFunction_error.Dock = System.Windows.Forms.DockStyle.None;
            this.stbFunction_error.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.stbFunction_error.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pnlFunct_error,
            this.pnlErr_codes,
            this.pnlErr_explain});
            this.stbFunction_error.Location = new System.Drawing.Point(0, 234);
            this.stbFunction_error.Name = "stbFunction_error";
            this.stbFunction_error.Size = new System.Drawing.Size(564, 22);
            this.stbFunction_error.SizingGrip = false;
            this.stbFunction_error.TabIndex = 13;
            this.stbFunction_error.Text = "statusStrip1";
            // 
            // pnlFunct_error
            // 
            this.pnlFunct_error.AutoSize = false;
            this.pnlFunct_error.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.pnlFunct_error.Name = "pnlFunct_error";
            this.pnlFunct_error.Size = new System.Drawing.Size(120, 17);
            this.pnlFunct_error.Text = "Function Error";
            // 
            // pnlErr_codes
            // 
            this.pnlErr_codes.AutoSize = false;
            this.pnlErr_codes.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.pnlErr_codes.Name = "pnlErr_codes";
            this.pnlErr_codes.Size = new System.Drawing.Size(50, 17);
            this.pnlErr_codes.Text = " ";
            // 
            // pnlErr_explain
            // 
            this.pnlErr_explain.Name = "pnlErr_explain";
            this.pnlErr_explain.Size = new System.Drawing.Size(372, 17);
            this.pnlErr_explain.Spring = true;
            this.pnlErr_explain.Text = " ";
            // 
            // stbCardStatus
            // 
            this.stbCardStatus.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.stbCardStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3});
            this.stbCardStatus.Location = new System.Drawing.Point(0, 258);
            this.stbCardStatus.Name = "stbCardStatus";
            this.stbCardStatus.Size = new System.Drawing.Size(564, 22);
            this.stbCardStatus.SizingGrip = false;
            this.stbCardStatus.TabIndex = 18;
            this.stbCardStatus.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.AutoSize = false;
            this.toolStripStatusLabel1.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(120, 17);
            this.toolStripStatusLabel1.Text = "CARD STATUS";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.AutoSize = false;
            this.toolStripStatusLabel2.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(50, 17);
            this.toolStripStatusLabel2.Text = " ";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(341, 17);
            this.toolStripStatusLabel3.Spring = true;
            this.toolStripStatusLabel3.Text = " ";
            // 
            // frmuFRCoderSimplest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 302);
            this.Controls.Add(this.stbCardStatus);
            this.Controls.Add(this.stbFunction_error);
            this.Controls.Add(this.btnReadData);
            this.Controls.Add(this.lblReadData);
            this.Controls.Add(this.txtReadData);
            this.Controls.Add(this.txtCardSerial);
            this.Controls.Add(this.lblCardSerial);
            this.Controls.Add(this.stbConnected);
            this.Controls.Add(this.mnuuFRCoderSimplestItem);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.mnuuFRCoderSimplestItem;
            this.MaximizeBox = false;
            this.Name = "frmuFRCoderSimplest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "uFR Coder Simplest";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.stbConnected.ResumeLayout(false);
            this.stbConnected.PerformLayout();
            this.mnuuFRCoderSimplestItem.ResumeLayout(false);
            this.mnuuFRCoderSimplestItem.PerformLayout();
            this.stbFunction_error.ResumeLayout(false);
            this.stbFunction_error.PerformLayout();
            this.stbCardStatus.ResumeLayout(false);
            this.stbCardStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip stbConnected;
        private System.Windows.Forms.MenuStrip mnuuFRCoderSimplestItem;
        private System.Windows.Forms.ToolStripMenuItem mnuExitItem;
        private System.Windows.Forms.TextBox txtCardSerial;
        private System.Windows.Forms.Label lblCardSerial;
        private System.Windows.Forms.ToolStripStatusLabel pnlConnected;
        private System.Windows.Forms.TextBox txtReadData;
        private System.Windows.Forms.Label lblReadData;
        private System.Windows.Forms.Button btnReadData;
        private System.Windows.Forms.ToolStripStatusLabel pnlError_code;
        private System.Windows.Forms.ToolStripStatusLabel pnlError_expl;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.StatusStrip stbFunction_error;
        private System.Windows.Forms.ToolStripStatusLabel pnlFunct_error;
        private System.Windows.Forms.ToolStripStatusLabel pnlErr_codes;
        private System.Windows.Forms.ToolStripStatusLabel pnlErr_explain;
        private System.Windows.Forms.StatusStrip stbCardStatus;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
    }
}

