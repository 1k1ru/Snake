namespace SnakeClient
{
    partial class GameOverForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameOverForm));
            this.button_refresh = new System.Windows.Forms.Button();
            this.label_go = new System.Windows.Forms.Label();
            this.label_ys = new System.Windows.Forms.Label();
            this.label_score = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_refresh
            // 
            this.button_refresh.BackgroundImage = global::SnakeClient.Properties.Resources.refresh;
            this.button_refresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_refresh.FlatAppearance.BorderSize = 0;
            this.button_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_refresh.Location = new System.Drawing.Point(75, 138);
            this.button_refresh.Name = "button_refresh";
            this.button_refresh.Size = new System.Drawing.Size(50, 50);
            this.button_refresh.TabIndex = 0;
            this.button_refresh.UseVisualStyleBackColor = true;
            this.button_refresh.Click += new System.EventHandler(this.button_refresh_Click);
            // 
            // label_go
            // 
            this.label_go.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label_go.Location = new System.Drawing.Point(12, 9);
            this.label_go.Name = "label_go";
            this.label_go.Size = new System.Drawing.Size(176, 31);
            this.label_go.TabIndex = 1;
            this.label_go.Text = "Game Over!";
            this.label_go.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_ys
            // 
            this.label_ys.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label_ys.Location = new System.Drawing.Point(12, 40);
            this.label_ys.Name = "label_ys";
            this.label_ys.Size = new System.Drawing.Size(176, 31);
            this.label_ys.TabIndex = 2;
            this.label_ys.Text = "Your Score:";
            this.label_ys.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_score
            // 
            this.label_score.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_score.Location = new System.Drawing.Point(12, 71);
            this.label_score.Name = "label_score";
            this.label_score.Size = new System.Drawing.Size(176, 55);
            this.label_score.TabIndex = 3;
            this.label_score.Text = "0";
            this.label_score.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GameOverForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(200, 200);
            this.Controls.Add(this.label_score);
            this.Controls.Add(this.label_ys);
            this.Controls.Add(this.label_go);
            this.Controls.Add(this.button_refresh);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GameOverForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "GameOver";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.GameOverForm_MouseDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_refresh;
        private System.Windows.Forms.Label label_go;
        private System.Windows.Forms.Label label_ys;
        private System.Windows.Forms.Label label_score;
    }
}