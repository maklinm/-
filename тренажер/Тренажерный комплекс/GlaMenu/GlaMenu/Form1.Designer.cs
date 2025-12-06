namespace GlaMenu
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.Exit = new System.Windows.Forms.Button();
            this.Trase = new System.Windows.Forms.PictureBox();
            this.Test1 = new System.Windows.Forms.Button();
            this.Probn1 = new System.Windows.Forms.Button();
            this.TK_stop = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Trase)).BeginInit();
            this.SuspendLayout();
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.Transparent;
            this.Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Exit.FlatAppearance.BorderSize = 0;
            this.Exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OrangeRed;
            this.Exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PeachPuff;
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Exit.ForeColor = System.Drawing.Color.Snow;
            this.Exit.Location = new System.Drawing.Point(302, 350);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(211, 56);
            this.Exit.TabIndex = 4;
            this.Exit.Text = "ВЫХОД ИЗ ПРОГРАММЫ";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Trase
            // 
            this.Trase.BackColor = System.Drawing.Color.Transparent;
            this.Trase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Trase.Enabled = false;
            this.Trase.ErrorImage = null;
            this.Trase.InitialImage = ((System.Drawing.Image)(resources.GetObject("Trase.InitialImage")));
            this.Trase.Location = new System.Drawing.Point(663, 350);
            this.Trase.Name = "Trase";
            this.Trase.Size = new System.Drawing.Size(89, 76);
            this.Trase.TabIndex = 5;
            this.Trase.TabStop = false;
            this.Trase.Visible = false;
            this.Trase.Click += new System.EventHandler(this.Trase_Click);
            // 
            // Test1
            // 
            this.Test1.BackColor = System.Drawing.Color.Transparent;
            this.Test1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Test1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Test1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Test1.Location = new System.Drawing.Point(143, 198);
            this.Test1.Name = "Test1";
            this.Test1.Size = new System.Drawing.Size(324, 25);
            this.Test1.TabIndex = 6;
            this.Test1.Text = "ТЕСТОВЫЙ ЗАПУКС ВИРТУАЛЬНОЙ РЛС";
            this.Test1.UseVisualStyleBackColor = false;
            this.Test1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Test1_MouseClick);
            this.Test1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Test1_MouseUp);
            // 
            // Probn1
            // 
            this.Probn1.BackColor = System.Drawing.Color.Transparent;
            this.Probn1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Probn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Probn1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Probn1.Location = new System.Drawing.Point(143, 245);
            this.Probn1.Name = "Probn1";
            this.Probn1.Size = new System.Drawing.Size(370, 24);
            this.Probn1.TabIndex = 7;
            this.Probn1.Text = " СТАНДАРТНЫЙ ЗАПУСК ВИРТУАЛЬНОЙ РЛС";
            this.Probn1.UseVisualStyleBackColor = false;
            this.Probn1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Probn1_MouseClick);
            this.Probn1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Probn1_MouseUp);
            // 
            // TK_stop
            // 
            this.TK_stop.Enabled = true;
            this.TK_stop.Tick += new System.EventHandler(this.TK_stop_Tick);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(271, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 22);
            this.label1.TabIndex = 9;
            this.label1.Text = "ТРЕНАЖЁР ВИРТУАЛЬНОЙ РЛС";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Silver;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(143, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(529, 27);
            this.label2.TabIndex = 10;
            this.label2.Text = "Выбор режимов управления виртуальной станцией";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.BackgroundImage = global::GlaMenu.Properties.Resources.phonoteka_p_radar_fon_30;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Probn1);
            this.Controls.Add(this.Test1);
            this.Controls.Add(this.Trase);
            this.Controls.Add(this.Exit);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Load += new System.EventHandler(this.Menu_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Menu_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Menu_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.Trase)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.PictureBox Trase;
        private System.Windows.Forms.Button Test1;
        private System.Windows.Forms.Button Probn1;
        private System.Windows.Forms.Timer TK_stop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

