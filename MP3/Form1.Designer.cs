namespace MP3
{
    partial class Player
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Player));
            this.bt_play = new System.Windows.Forms.Button();
            this.bt_pause = new System.Windows.Forms.Button();
            this.bt_stop = new System.Windows.Forms.Button();
            this.bt_open = new System.Windows.Forms.Button();
            this.p_bar = new System.Windows.Forms.ProgressBar();
            this.track_volume = new System.Windows.Forms.TrackBar();
            this.Player1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.Play_list = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lb_start = new System.Windows.Forms.Label();
            this.lb_end = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.track_volume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player1)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_play
            // 
            this.bt_play.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bt_play.Location = new System.Drawing.Point(12, 405);
            this.bt_play.Name = "bt_play";
            this.bt_play.Size = new System.Drawing.Size(113, 33);
            this.bt_play.TabIndex = 0;
            this.bt_play.Text = "Play";
            this.bt_play.UseVisualStyleBackColor = true;
            this.bt_play.Click += new System.EventHandler(this.bt_play_Click);
            // 
            // bt_pause
            // 
            this.bt_pause.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bt_pause.Location = new System.Drawing.Point(145, 405);
            this.bt_pause.Name = "bt_pause";
            this.bt_pause.Size = new System.Drawing.Size(113, 33);
            this.bt_pause.TabIndex = 1;
            this.bt_pause.Text = "Pause";
            this.bt_pause.UseVisualStyleBackColor = true;
            this.bt_pause.Click += new System.EventHandler(this.bt_pause_Click);
            // 
            // bt_stop
            // 
            this.bt_stop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bt_stop.Location = new System.Drawing.Point(279, 405);
            this.bt_stop.Name = "bt_stop";
            this.bt_stop.Size = new System.Drawing.Size(113, 33);
            this.bt_stop.TabIndex = 2;
            this.bt_stop.Text = "Stop";
            this.bt_stop.UseVisualStyleBackColor = true;
            this.bt_stop.Click += new System.EventHandler(this.bt_stop_Click);
            // 
            // bt_open
            // 
            this.bt_open.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bt_open.Location = new System.Drawing.Point(414, 405);
            this.bt_open.Name = "bt_open";
            this.bt_open.Size = new System.Drawing.Size(276, 33);
            this.bt_open.TabIndex = 3;
            this.bt_open.Text = "Open";
            this.bt_open.UseVisualStyleBackColor = true;
            this.bt_open.Click += new System.EventHandler(this.bt_open_Click);
            // 
            // p_bar
            // 
            this.p_bar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.p_bar.Location = new System.Drawing.Point(52, 380);
            this.p_bar.Name = "p_bar";
            this.p_bar.Size = new System.Drawing.Size(597, 10);
            this.p_bar.TabIndex = 5;
            this.p_bar.Click += new System.EventHandler(this.p_bar_Click);
            this.p_bar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.p_bar_MouseDown);
            // 
            // track_volume
            // 
            this.track_volume.Location = new System.Drawing.Point(644, 19);
            this.track_volume.Maximum = 100;
            this.track_volume.Name = "track_volume";
            this.track_volume.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.track_volume.Size = new System.Drawing.Size(45, 299);
            this.track_volume.TabIndex = 9;
            this.track_volume.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.track_volume.Scroll += new System.EventHandler(this.track_volume_Scroll);
            // 
            // Player1
            // 
            this.Player1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Player1.Enabled = true;
            this.Player1.Location = new System.Drawing.Point(0, 0);
            this.Player1.Name = "Player1";
            this.Player1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Player1.OcxState")));
            this.Player1.Size = new System.Drawing.Size(699, 10);
            this.Player1.TabIndex = 7;
            // 
            // Play_list
            // 
            this.Play_list.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Play_list.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Play_list.FormattingEnabled = true;
            this.Play_list.ItemHeight = 20;
            this.Play_list.Location = new System.Drawing.Point(12, 19);
            this.Play_list.Name = "Play_list";
            this.Play_list.Size = new System.Drawing.Size(610, 324);
            this.Play_list.TabIndex = 4;
            this.Play_list.SelectedIndexChanged += new System.EventHandler(this.Play_list_SelectedIndexChanged);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lb_start
            // 
            this.lb_start.AutoSize = true;
            this.lb_start.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lb_start.Location = new System.Drawing.Point(12, 376);
            this.lb_start.Name = "lb_start";
            this.lb_start.Size = new System.Drawing.Size(34, 13);
            this.lb_start.TabIndex = 10;
            this.lb_start.Text = "00:00";
            // 
            // lb_end
            // 
            this.lb_end.AutoSize = true;
            this.lb_end.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lb_end.Location = new System.Drawing.Point(655, 377);
            this.lb_end.Name = "lb_end";
            this.lb_end.Size = new System.Drawing.Size(34, 13);
            this.lb_end.TabIndex = 11;
            this.lb_end.Text = "00:00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(642, 321);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Volume";
            // 
            // Player
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(699, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_end);
            this.Controls.Add(this.lb_start);
            this.Controls.Add(this.track_volume);
            this.Controls.Add(this.p_bar);
            this.Controls.Add(this.Play_list);
            this.Controls.Add(this.bt_open);
            this.Controls.Add(this.bt_stop);
            this.Controls.Add(this.bt_pause);
            this.Controls.Add(this.bt_play);
            this.Controls.Add(this.Player1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Player";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Player";
            this.Load += new System.EventHandler(this.Player_Load);
            ((System.ComponentModel.ISupportInitialize)(this.track_volume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_play;
        private System.Windows.Forms.Button bt_pause;
        private System.Windows.Forms.Button bt_stop;
        private System.Windows.Forms.Button bt_open;
        private System.Windows.Forms.ProgressBar p_bar;
        private AxWMPLib.AxWindowsMediaPlayer Player1;
        private System.Windows.Forms.TrackBar track_volume;
        private System.Windows.Forms.ListBox Play_list;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lb_start;
        private System.Windows.Forms.Label lb_end;
        private System.Windows.Forms.Label label1;
    }
}

