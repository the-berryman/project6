namespace Project6
{
    partial class project6
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
            this.teamsList = new System.Windows.Forms.ListBox();
            this.winnersList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.calculatePush = new System.Windows.Forms.Button();
            this.exitPush = new System.Windows.Forms.Button();
            this.totalwins = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // teamsList
            // 
            this.teamsList.FormattingEnabled = true;
            this.teamsList.Location = new System.Drawing.Point(34, 90);
            this.teamsList.Name = "teamsList";
            this.teamsList.Size = new System.Drawing.Size(120, 147);
            this.teamsList.TabIndex = 0;
            this.teamsList.SelectedIndexChanged += new System.EventHandler(this.teamsList_SelectedIndexChanged);
            // 
            // winnersList
            // 
            this.winnersList.FormattingEnabled = true;
            this.winnersList.Location = new System.Drawing.Point(260, 90);
            this.winnersList.Name = "winnersList";
            this.winnersList.Size = new System.Drawing.Size(120, 147);
            this.winnersList.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "List of teams";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(257, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "List of World Series Winners";
            // 
            // calculatePush
            // 
            this.calculatePush.Location = new System.Drawing.Point(79, 306);
            this.calculatePush.Name = "calculatePush";
            this.calculatePush.Size = new System.Drawing.Size(75, 23);
            this.calculatePush.TabIndex = 4;
            this.calculatePush.Text = "Calculate";
            this.calculatePush.UseVisualStyleBackColor = true;
            this.calculatePush.Click += new System.EventHandler(this.calculatePush_Click);
            // 
            // exitPush
            // 
            this.exitPush.Location = new System.Drawing.Point(260, 306);
            this.exitPush.Name = "exitPush";
            this.exitPush.Size = new System.Drawing.Size(75, 23);
            this.exitPush.TabIndex = 5;
            this.exitPush.Text = "Exit";
            this.exitPush.UseVisualStyleBackColor = true;
            this.exitPush.Click += new System.EventHandler(this.exitPush_Click);
            // 
            // totalwins
            // 
            this.totalwins.AutoSize = true;
            this.totalwins.Location = new System.Drawing.Point(76, 258);
            this.totalwins.Name = "totalwins";
            this.totalwins.Size = new System.Drawing.Size(0, 13);
            this.totalwins.TabIndex = 8;
            // 
            // project6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 341);
            this.Controls.Add(this.totalwins);
            this.Controls.Add(this.exitPush);
            this.Controls.Add(this.calculatePush);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.winnersList);
            this.Controls.Add(this.teamsList);
            this.Name = "project6";
            this.Text = "World Series Winner Navigator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox teamsList;
        private System.Windows.Forms.ListBox winnersList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button calculatePush;
        private System.Windows.Forms.Button exitPush;
        private System.Windows.Forms.Label totalwins;
    }
}

