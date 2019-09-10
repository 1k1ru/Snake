namespace SnakeClient
{
    partial class GameForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            this.canvas = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lScore = new System.Windows.Forms.Label();
            this.radioButton_WithBorders = new System.Windows.Forms.RadioButton();
            this.radioButton_Borderless = new System.Windows.Forms.RadioButton();
            this.label_scoretext = new System.Windows.Forms.Label();
            this.bPlay = new System.Windows.Forms.Button();
            this.timerGame = new System.Windows.Forms.Timer(this.components);
            this.panel_score = new System.Windows.Forms.Panel();
            this.panel_mode = new System.Windows.Forms.Panel();
            this.bClose = new System.Windows.Forms.Button();
            this.label_controls = new System.Windows.Forms.Label();
            this.panel_controls = new System.Windows.Forms.Panel();
            this.label_w = new System.Windows.Forms.Label();
            this.label_s = new System.Windows.Forms.Label();
            this.label_a = new System.Windows.Forms.Label();
            this.label_d = new System.Windows.Forms.Label();
            this.label_space = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).BeginInit();
            this.panel_score.SuspendLayout();
            this.panel_mode.SuspendLayout();
            this.panel_controls.SuspendLayout();
            this.SuspendLayout();
            // 
            // canvas
            // 
            this.canvas.BackColor = System.Drawing.Color.DimGray;
            this.canvas.Dock = System.Windows.Forms.DockStyle.Left;
            this.canvas.Location = new System.Drawing.Point(0, 0);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(800, 600);
            this.canvas.TabIndex = 0;
            this.canvas.TabStop = false;
            this.canvas.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.canvas_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(38, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Mode:";
            // 
            // lScore
            // 
            this.lScore.AutoSize = true;
            this.lScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lScore.Location = new System.Drawing.Point(9, 38);
            this.lScore.Name = "lScore";
            this.lScore.Size = new System.Drawing.Size(51, 55);
            this.lScore.TabIndex = 3;
            this.lScore.Text = "0";
            // 
            // radioButton_WithBorders
            // 
            this.radioButton_WithBorders.AutoSize = true;
            this.radioButton_WithBorders.FlatAppearance.BorderSize = 0;
            this.radioButton_WithBorders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton_WithBorders.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton_WithBorders.Location = new System.Drawing.Point(18, 50);
            this.radioButton_WithBorders.Name = "radioButton_WithBorders";
            this.radioButton_WithBorders.Size = new System.Drawing.Size(101, 20);
            this.radioButton_WithBorders.TabIndex = 6;
            this.radioButton_WithBorders.Text = "With borders";
            this.radioButton_WithBorders.UseVisualStyleBackColor = true;
            this.radioButton_WithBorders.CheckedChanged += new System.EventHandler(this.radioButton_WithBorders_CheckedChanged);
            // 
            // radioButton_Borderless
            // 
            this.radioButton_Borderless.AutoSize = true;
            this.radioButton_Borderless.FlatAppearance.BorderSize = 0;
            this.radioButton_Borderless.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton_Borderless.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton_Borderless.Location = new System.Drawing.Point(18, 73);
            this.radioButton_Borderless.Name = "radioButton_Borderless";
            this.radioButton_Borderless.Size = new System.Drawing.Size(91, 20);
            this.radioButton_Borderless.TabIndex = 7;
            this.radioButton_Borderless.Text = "Borderless";
            this.radioButton_Borderless.UseVisualStyleBackColor = true;
            this.radioButton_Borderless.CheckedChanged += new System.EventHandler(this.radioButton_Borderless_CheckedChanged);
            // 
            // label_scoretext
            // 
            this.label_scoretext.AutoSize = true;
            this.label_scoretext.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_scoretext.Location = new System.Drawing.Point(13, 7);
            this.label_scoretext.Name = "label_scoretext";
            this.label_scoretext.Size = new System.Drawing.Size(93, 31);
            this.label_scoretext.TabIndex = 2;
            this.label_scoretext.Text = "Score:";
            // 
            // bPlay
            // 
            this.bPlay.BackgroundImage = global::SnakeClient.Properties.Resources.play;
            this.bPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bPlay.Enabled = false;
            this.bPlay.FlatAppearance.BorderSize = 0;
            this.bPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bPlay.Location = new System.Drawing.Point(818, 12);
            this.bPlay.Name = "bPlay";
            this.bPlay.Size = new System.Drawing.Size(50, 50);
            this.bPlay.TabIndex = 1;
            this.bPlay.UseVisualStyleBackColor = true;
            this.bPlay.Click += new System.EventHandler(this.bPlay_Click);
            // 
            // timerGame
            // 
            this.timerGame.Interval = 80;
            this.timerGame.Tick += new System.EventHandler(this.timerGame_Tick);
            // 
            // panel_score
            // 
            this.panel_score.Controls.Add(this.label_scoretext);
            this.panel_score.Controls.Add(this.lScore);
            this.panel_score.Location = new System.Drawing.Point(818, 489);
            this.panel_score.Name = "panel_score";
            this.panel_score.Size = new System.Drawing.Size(118, 99);
            this.panel_score.TabIndex = 10;
            // 
            // panel_mode
            // 
            this.panel_mode.Controls.Add(this.label1);
            this.panel_mode.Controls.Add(this.radioButton_Borderless);
            this.panel_mode.Controls.Add(this.radioButton_WithBorders);
            this.panel_mode.Location = new System.Drawing.Point(809, 78);
            this.panel_mode.Name = "panel_mode";
            this.panel_mode.Size = new System.Drawing.Size(135, 109);
            this.panel_mode.TabIndex = 10;
            // 
            // bClose
            // 
            this.bClose.BackgroundImage = global::SnakeClient.Properties.Resources.close;
            this.bClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bClose.FlatAppearance.BorderSize = 0;
            this.bClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bClose.Location = new System.Drawing.Point(892, 12);
            this.bClose.Name = "bClose";
            this.bClose.Size = new System.Drawing.Size(50, 50);
            this.bClose.TabIndex = 9;
            this.bClose.UseVisualStyleBackColor = true;
            this.bClose.Click += new System.EventHandler(this.bClose_Click);
            // 
            // label_controls
            // 
            this.label_controls.AutoSize = true;
            this.label_controls.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_controls.Location = new System.Drawing.Point(21, 9);
            this.label_controls.Name = "label_controls";
            this.label_controls.Size = new System.Drawing.Size(98, 25);
            this.label_controls.TabIndex = 11;
            this.label_controls.Text = "Controls:";
            // 
            // panel_controls
            // 
            this.panel_controls.Controls.Add(this.label_space);
            this.panel_controls.Controls.Add(this.label_d);
            this.panel_controls.Controls.Add(this.label_a);
            this.panel_controls.Controls.Add(this.label_s);
            this.panel_controls.Controls.Add(this.label_w);
            this.panel_controls.Controls.Add(this.label_controls);
            this.panel_controls.Location = new System.Drawing.Point(809, 211);
            this.panel_controls.Name = "panel_controls";
            this.panel_controls.Size = new System.Drawing.Size(135, 160);
            this.panel_controls.TabIndex = 12;
            // 
            // label_w
            // 
            this.label_w.AutoSize = true;
            this.label_w.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_w.Location = new System.Drawing.Point(31, 45);
            this.label_w.Name = "label_w";
            this.label_w.Size = new System.Drawing.Size(58, 20);
            this.label_w.TabIndex = 12;
            this.label_w.Text = "W - Up";
            // 
            // label_s
            // 
            this.label_s.AutoSize = true;
            this.label_s.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_s.Location = new System.Drawing.Point(31, 65);
            this.label_s.Name = "label_s";
            this.label_s.Size = new System.Drawing.Size(74, 20);
            this.label_s.TabIndex = 13;
            this.label_s.Text = "S - Down";
            // 
            // label_a
            // 
            this.label_a.AutoSize = true;
            this.label_a.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_a.Location = new System.Drawing.Point(31, 85);
            this.label_a.Name = "label_a";
            this.label_a.Size = new System.Drawing.Size(61, 20);
            this.label_a.TabIndex = 14;
            this.label_a.Text = "A - Left";
            // 
            // label_d
            // 
            this.label_d.AutoSize = true;
            this.label_d.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_d.Location = new System.Drawing.Point(31, 105);
            this.label_d.Name = "label_d";
            this.label_d.Size = new System.Drawing.Size(72, 20);
            this.label_d.TabIndex = 15;
            this.label_d.Text = "D - Right";
            // 
            // label_space
            // 
            this.label_space.AutoSize = true;
            this.label_space.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_space.Location = new System.Drawing.Point(14, 125);
            this.label_space.Name = "label_space";
            this.label_space.Size = new System.Drawing.Size(113, 20);
            this.label_space.TabIndex = 16;
            this.label_space.Text = "Space - Pause";
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(954, 600);
            this.Controls.Add(this.panel_controls);
            this.Controls.Add(this.bClose);
            this.Controls.Add(this.panel_mode);
            this.Controls.Add(this.bPlay);
            this.Controls.Add(this.panel_score);
            this.Controls.Add(this.canvas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(954, 600);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(954, 600);
            this.Name = "GameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Snake";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.GameForm_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).EndInit();
            this.panel_score.ResumeLayout(false);
            this.panel_score.PerformLayout();
            this.panel_mode.ResumeLayout(false);
            this.panel_mode.PerformLayout();
            this.panel_controls.ResumeLayout(false);
            this.panel_controls.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox canvas;
        private System.Windows.Forms.Button bPlay;
        private System.Windows.Forms.Label lScore;
        private System.Windows.Forms.Label label_scoretext;
        private System.Windows.Forms.Timer timerGame;
        private System.Windows.Forms.RadioButton radioButton_Borderless;
        private System.Windows.Forms.RadioButton radioButton_WithBorders;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_score;
        private System.Windows.Forms.Panel panel_mode;
        private System.Windows.Forms.Button bClose;
        private System.Windows.Forms.Label label_controls;
        private System.Windows.Forms.Panel panel_controls;
        private System.Windows.Forms.Label label_d;
        private System.Windows.Forms.Label label_a;
        private System.Windows.Forms.Label label_s;
        private System.Windows.Forms.Label label_w;
        private System.Windows.Forms.Label label_space;
    }
}

