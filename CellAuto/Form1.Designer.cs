
namespace CellAuto
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.GenerateRandomLife = new System.Windows.Forms.Button();
            this.Quit = new System.Windows.Forms.Button();
            this.nextgeneration = new System.Windows.Forms.Button();
            this.kill = new System.Windows.Forms.Button();
            this.start = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pauseTime = new System.Windows.Forms.Button();
            this.counter = new System.Windows.Forms.Label();
            this.counterNum = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeight = 30;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.ColumnHeadersVisible = false;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 10;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridView1.Size = new System.Drawing.Size(983, 353);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick_1);
            // 
            // GenerateRandomLife
            // 
            this.GenerateRandomLife.Location = new System.Drawing.Point(634, 392);
            this.GenerateRandomLife.Name = "GenerateRandomLife";
            this.GenerateRandomLife.Size = new System.Drawing.Size(142, 23);
            this.GenerateRandomLife.TabIndex = 1;
            this.GenerateRandomLife.Text = "GenerateRandomLife";
            this.GenerateRandomLife.UseVisualStyleBackColor = true;
            this.GenerateRandomLife.Click += new System.EventHandler(this.GenerateRandomLife_Click);
            // 
            // Quit
            // 
            this.Quit.Location = new System.Drawing.Point(893, 392);
            this.Quit.Name = "Quit";
            this.Quit.Size = new System.Drawing.Size(75, 23);
            this.Quit.TabIndex = 2;
            this.Quit.Text = "Quit";
            this.Quit.UseVisualStyleBackColor = true;
            this.Quit.Click += new System.EventHandler(this.Quit_Click);
            // 
            // nextgeneration
            // 
            this.nextgeneration.Location = new System.Drawing.Point(323, 392);
            this.nextgeneration.Name = "nextgeneration";
            this.nextgeneration.Size = new System.Drawing.Size(119, 23);
            this.nextgeneration.TabIndex = 3;
            this.nextgeneration.Text = "Next Generation";
            this.nextgeneration.UseVisualStyleBackColor = true;
            this.nextgeneration.Click += new System.EventHandler(this.nextgeneration_Click);
            // 
            // kill
            // 
            this.kill.Location = new System.Drawing.Point(792, 392);
            this.kill.Name = "kill";
            this.kill.Size = new System.Drawing.Size(75, 23);
            this.kill.TabIndex = 4;
            this.kill.Text = "Kill";
            this.kill.UseVisualStyleBackColor = true;
            this.kill.Click += new System.EventHandler(this.kill_Click);
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(45, 392);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(75, 23);
            this.start.TabIndex = 5;
            this.start.Text = "Start";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pauseTime
            // 
            this.pauseTime.Location = new System.Drawing.Point(179, 392);
            this.pauseTime.Name = "pauseTime";
            this.pauseTime.Size = new System.Drawing.Size(75, 23);
            this.pauseTime.TabIndex = 6;
            this.pauseTime.Text = "Stop";
            this.pauseTime.UseVisualStyleBackColor = true;
            this.pauseTime.Click += new System.EventHandler(this.pauseTime_Click);
            // 
            // counter
            // 
            this.counter.AutoSize = true;
            this.counter.Location = new System.Drawing.Point(492, 396);
            this.counter.Name = "counter";
            this.counter.Size = new System.Drawing.Size(31, 15);
            this.counter.TabIndex = 7;
            this.counter.Text = "Gen:";
            // 
            // counterNum
            // 
            this.counterNum.AutoSize = true;
            this.counterNum.Location = new System.Drawing.Point(541, 396);
            this.counterNum.Name = "counterNum";
            this.counterNum.Size = new System.Drawing.Size(13, 15);
            this.counterNum.TabIndex = 9;
            this.counterNum.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 461);
            this.Controls.Add(this.counterNum);
            this.Controls.Add(this.counter);
            this.Controls.Add(this.pauseTime);
            this.Controls.Add(this.start);
            this.Controls.Add(this.kill);
            this.Controls.Add(this.nextgeneration);
            this.Controls.Add(this.Quit);
            this.Controls.Add(this.GenerateRandomLife);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button GenerateRandomLife;
        private System.Windows.Forms.Button Quit;
        private System.Windows.Forms.Button nextgeneration;
        private System.Windows.Forms.Button kill;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button pauseTime;
        private System.Windows.Forms.Label counter;
        private System.Windows.Forms.Label counterNum;
    }
}

