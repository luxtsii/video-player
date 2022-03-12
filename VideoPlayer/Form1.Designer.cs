namespace VideoPlayer
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.loadVideo = new System.Windows.Forms.Button();
            this.videoDialog = new System.Windows.Forms.OpenFileDialog();
            this.backFrame = new System.Windows.Forms.Button();
            this.forwardFrame = new System.Windows.Forms.Button();
            this.startBtn = new System.Windows.Forms.CheckBox();
            this.endBtn = new System.Windows.Forms.CheckBox();
            this.loopBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Dock = System.Windows.Forms.DockStyle.Top;
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(0, 0);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(1314, 759);
            this.axWindowsMediaPlayer1.TabIndex = 0;
            this.axWindowsMediaPlayer1.Enter += new System.EventHandler(this.axWindowsMediaPlayer1_Enter);
            // 
            // loadVideo
            // 
            this.loadVideo.Location = new System.Drawing.Point(10, 765);
            this.loadVideo.Name = "loadVideo";
            this.loadVideo.Size = new System.Drawing.Size(75, 23);
            this.loadVideo.TabIndex = 1;
            this.loadVideo.Text = "Load Video";
            this.loadVideo.UseVisualStyleBackColor = true;
            this.loadVideo.Click += new System.EventHandler(this.loadVideo_Click);
            // 
            // videoDialog
            // 
            this.videoDialog.FileName = "videoDialog";
            // 
            // backFrame
            // 
            this.backFrame.Location = new System.Drawing.Point(92, 765);
            this.backFrame.Name = "backFrame";
            this.backFrame.Size = new System.Drawing.Size(28, 23);
            this.backFrame.TabIndex = 2;
            this.backFrame.Text = "<";
            this.backFrame.UseVisualStyleBackColor = true;
            this.backFrame.Click += new System.EventHandler(this.backFrame_Click);
            // 
            // forwardFrame
            // 
            this.forwardFrame.Location = new System.Drawing.Point(126, 765);
            this.forwardFrame.Name = "forwardFrame";
            this.forwardFrame.Size = new System.Drawing.Size(28, 23);
            this.forwardFrame.TabIndex = 3;
            this.forwardFrame.Text = ">";
            this.forwardFrame.UseVisualStyleBackColor = true;
            this.forwardFrame.Click += new System.EventHandler(this.forwardFrame_Click);
            // 
            // startBtn
            // 
            this.startBtn.AutoSize = true;
            this.startBtn.Location = new System.Drawing.Point(160, 769);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(48, 17);
            this.startBtn.TabIndex = 4;
            this.startBtn.Text = "Start";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.CheckedChanged += new System.EventHandler(this.startBtn_CheckedChanged_1);
            // 
            // endBtn
            // 
            this.endBtn.AutoSize = true;
            this.endBtn.Location = new System.Drawing.Point(214, 769);
            this.endBtn.Name = "endBtn";
            this.endBtn.Size = new System.Drawing.Size(45, 17);
            this.endBtn.TabIndex = 5;
            this.endBtn.Text = "End";
            this.endBtn.UseVisualStyleBackColor = true;
            this.endBtn.CheckedChanged += new System.EventHandler(this.endBtn_CheckedChanged_1);
            // 
            // loopBtn
            // 
            this.loopBtn.Location = new System.Drawing.Point(265, 765);
            this.loopBtn.Name = "loopBtn";
            this.loopBtn.Size = new System.Drawing.Size(75, 23);
            this.loopBtn.TabIndex = 6;
            this.loopBtn.Text = "Loop";
            this.loopBtn.UseVisualStyleBackColor = true;
            this.loopBtn.Click += new System.EventHandler(this.loopBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1314, 800);
            this.Controls.Add(this.loopBtn);
            this.Controls.Add(this.endBtn);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.forwardFrame);
            this.Controls.Add(this.backFrame);
            this.Controls.Add(this.loadVideo);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void AxWindowsMediaPlayer1_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            throw new System.NotImplementedException();
        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Button loadVideo;
        private System.Windows.Forms.OpenFileDialog videoDialog;
        private System.Windows.Forms.Button backFrame;
        private System.Windows.Forms.Button forwardFrame;
        private System.Windows.Forms.CheckBox startBtn;
        private System.Windows.Forms.CheckBox endBtn;
        private System.Windows.Forms.Button loopBtn;
    }
}

