
namespace XmlTask
{
    partial class Form1
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
            this.FootballersSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fIleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.SaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SecondNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BirthDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.RoleTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.GamesCountUpDown = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ScoredBallsCountUpDown = new System.Windows.Forms.NumericUpDown();
            this.BirthPlaceTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.MoveToStartButton = new System.Windows.Forms.Button();
            this.PreviousElementButton = new System.Windows.Forms.Button();
            this.MoveToEndButton = new System.Windows.Forms.Button();
            this.NextElementButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.ElementIndexAndCountLabel = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.InsertButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.executeTaskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.FootballersSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GamesCountUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScoredBallsCountUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // FootballersSource
            // 
            this.FootballersSource.ListChanged += new System.ComponentModel.ListChangedEventHandler(this.FootballersSource_ListChanged);
            this.FootballersSource.PositionChanged += new System.EventHandler(this.FootballersSource_PositionChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fIleToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(381, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fIleToolStripMenuItem
            // 
            this.fIleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewToolStripMenuItem,
            this.OpenXMLToolStripMenuItem,
            this.toolStripSeparator1,
            this.SaveToolStripMenuItem,
            this.SaveXMLToolStripMenuItem,
            this.toolStripSeparator2,
            this.ExitToolStripMenuItem});
            this.fIleToolStripMenuItem.Name = "fIleToolStripMenuItem";
            this.fIleToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fIleToolStripMenuItem.Text = "File";
            // 
            // NewToolStripMenuItem
            // 
            this.NewToolStripMenuItem.Name = "NewToolStripMenuItem";
            this.NewToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.NewToolStripMenuItem.Text = "New";
            this.NewToolStripMenuItem.Click += new System.EventHandler(this.NewToolStripMenuItem_Click);
            // 
            // OpenXMLToolStripMenuItem
            // 
            this.OpenXMLToolStripMenuItem.Name = "OpenXMLToolStripMenuItem";
            this.OpenXMLToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.OpenXMLToolStripMenuItem.Text = "Open XML";
            this.OpenXMLToolStripMenuItem.Click += new System.EventHandler(this.OpenXMLToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(127, 6);
            // 
            // SaveToolStripMenuItem
            // 
            this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            this.SaveToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.SaveToolStripMenuItem.Text = "Save";
            this.SaveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // SaveXMLToolStripMenuItem
            // 
            this.SaveXMLToolStripMenuItem.Name = "SaveXMLToolStripMenuItem";
            this.SaveXMLToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.SaveXMLToolStripMenuItem.Text = "Save XML";
            this.SaveXMLToolStripMenuItem.Click += new System.EventHandler(this.SaveXMLToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(127, 6);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.ExitToolStripMenuItem.Text = "Exit";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DeleteAllToolStripMenuItem,
            this.executeTaskToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // DeleteAllToolStripMenuItem
            // 
            this.DeleteAllToolStripMenuItem.Name = "DeleteAllToolStripMenuItem";
            this.DeleteAllToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.DeleteAllToolStripMenuItem.Text = "Delete all";
            this.DeleteAllToolStripMenuItem.Click += new System.EventHandler(this.DeleteAllToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // AboutToolStripMenuItem
            // 
            this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            this.AboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.AboutToolStripMenuItem.Text = "About";
            this.AboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // SecondNameTextBox
            // 
            this.SecondNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.FootballersSource, "SecondName", true));
            this.SecondNameTextBox.Location = new System.Drawing.Point(109, 37);
            this.SecondNameTextBox.Name = "SecondNameTextBox";
            this.SecondNameTextBox.Size = new System.Drawing.Size(229, 20);
            this.SecondNameTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Second name";
            // 
            // BirthDatePicker
            // 
            this.BirthDatePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.FootballersSource, "BirthDate", true));
            this.BirthDatePicker.Location = new System.Drawing.Point(109, 63);
            this.BirthDatePicker.Name = "BirthDatePicker";
            this.BirthDatePicker.Size = new System.Drawing.Size(229, 20);
            this.BirthDatePicker.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Birth date";
            // 
            // RoleTextBox
            // 
            this.RoleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.FootballersSource, "Role", true));
            this.RoleTextBox.Location = new System.Drawing.Point(109, 89);
            this.RoleTextBox.Name = "RoleTextBox";
            this.RoleTextBox.Size = new System.Drawing.Size(229, 20);
            this.RoleTextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Role";
            // 
            // GamesCountUpDown
            // 
            this.GamesCountUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.FootballersSource, "GamesCount", true));
            this.GamesCountUpDown.Location = new System.Drawing.Point(109, 115);
            this.GamesCountUpDown.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.GamesCountUpDown.Name = "GamesCountUpDown";
            this.GamesCountUpDown.Size = new System.Drawing.Size(228, 20);
            this.GamesCountUpDown.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Games";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Scored Balls";
            // 
            // ScoredBallsCountUpDown
            // 
            this.ScoredBallsCountUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.FootballersSource, "ScoredBallsCount", true));
            this.ScoredBallsCountUpDown.Location = new System.Drawing.Point(109, 141);
            this.ScoredBallsCountUpDown.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.ScoredBallsCountUpDown.Name = "ScoredBallsCountUpDown";
            this.ScoredBallsCountUpDown.Size = new System.Drawing.Size(229, 20);
            this.ScoredBallsCountUpDown.TabIndex = 10;
            // 
            // BirthPlaceTextBox
            // 
            this.BirthPlaceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.FootballersSource, "BirthPlace", true));
            this.BirthPlaceTextBox.Location = new System.Drawing.Point(109, 167);
            this.BirthPlaceTextBox.Name = "BirthPlaceTextBox";
            this.BirthPlaceTextBox.Size = new System.Drawing.Size(229, 20);
            this.BirthPlaceTextBox.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Birth place";
            // 
            // MoveToStartButton
            // 
            this.MoveToStartButton.Location = new System.Drawing.Point(24, 209);
            this.MoveToStartButton.Name = "MoveToStartButton";
            this.MoveToStartButton.Size = new System.Drawing.Size(47, 24);
            this.MoveToStartButton.TabIndex = 13;
            this.MoveToStartButton.Text = "<<";
            this.MoveToStartButton.UseVisualStyleBackColor = true;
            this.MoveToStartButton.Click += new System.EventHandler(this.MoveToStartButton_Click);
            // 
            // PreviousElementButton
            // 
            this.PreviousElementButton.Location = new System.Drawing.Point(85, 209);
            this.PreviousElementButton.Name = "PreviousElementButton";
            this.PreviousElementButton.Size = new System.Drawing.Size(49, 24);
            this.PreviousElementButton.TabIndex = 14;
            this.PreviousElementButton.Text = "<";
            this.PreviousElementButton.UseVisualStyleBackColor = true;
            this.PreviousElementButton.Click += new System.EventHandler(this.PreviousElementButton_Click);
            // 
            // MoveToEndButton
            // 
            this.MoveToEndButton.Location = new System.Drawing.Point(289, 209);
            this.MoveToEndButton.Name = "MoveToEndButton";
            this.MoveToEndButton.Size = new System.Drawing.Size(49, 24);
            this.MoveToEndButton.TabIndex = 16;
            this.MoveToEndButton.Text = ">>";
            this.MoveToEndButton.UseVisualStyleBackColor = true;
            this.MoveToEndButton.Click += new System.EventHandler(this.MoveToEndButton_Click);
            // 
            // NextElementButton
            // 
            this.NextElementButton.Location = new System.Drawing.Point(228, 209);
            this.NextElementButton.Name = "NextElementButton";
            this.NextElementButton.Size = new System.Drawing.Size(47, 24);
            this.NextElementButton.TabIndex = 15;
            this.NextElementButton.Text = ">";
            this.NextElementButton.UseVisualStyleBackColor = true;
            this.NextElementButton.Click += new System.EventHandler(this.NextElementButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "OpenFileDialog";
            // 
            // ElementIndexAndCountLabel
            // 
            this.ElementIndexAndCountLabel.AutoSize = true;
            this.ElementIndexAndCountLabel.Location = new System.Drawing.Point(169, 215);
            this.ElementIndexAndCountLabel.Name = "ElementIndexAndCountLabel";
            this.ElementIndexAndCountLabel.Size = new System.Drawing.Size(24, 13);
            this.ElementIndexAndCountLabel.TabIndex = 17;
            this.ElementIndexAndCountLabel.Text = "0/0";
            this.ElementIndexAndCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(75, 239);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(52, 25);
            this.AddButton.TabIndex = 18;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // InsertButton
            // 
            this.InsertButton.Location = new System.Drawing.Point(133, 239);
            this.InsertButton.Name = "InsertButton";
            this.InsertButton.Size = new System.Drawing.Size(52, 25);
            this.InsertButton.TabIndex = 19;
            this.InsertButton.Text = "Insert";
            this.InsertButton.UseVisualStyleBackColor = true;
            this.InsertButton.Click += new System.EventHandler(this.InsertButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(191, 239);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(52, 25);
            this.EditButton.TabIndex = 20;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(249, 239);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(52, 25);
            this.DeleteButton.TabIndex = 21;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // executeTaskToolStripMenuItem
            // 
            this.executeTaskToolStripMenuItem.Name = "executeTaskToolStripMenuItem";
            this.executeTaskToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.executeTaskToolStripMenuItem.Text = "Execute task";
            this.executeTaskToolStripMenuItem.Click += new System.EventHandler(this.ExecuteTaskToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 276);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.InsertButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.ElementIndexAndCountLabel);
            this.Controls.Add(this.MoveToEndButton);
            this.Controls.Add(this.NextElementButton);
            this.Controls.Add(this.PreviousElementButton);
            this.Controls.Add(this.MoveToStartButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BirthPlaceTextBox);
            this.Controls.Add(this.ScoredBallsCountUpDown);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.GamesCountUpDown);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.RoleTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BirthDatePicker);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SecondNameTextBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.FootballersSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GamesCountUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScoredBallsCountUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource FootballersSource;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fIleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenXMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem SaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveXMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutToolStripMenuItem;
        private System.Windows.Forms.TextBox SecondNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker BirthDatePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox RoleTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown GamesCountUpDown;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown ScoredBallsCountUpDown;
        private System.Windows.Forms.TextBox BirthPlaceTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button MoveToStartButton;
        private System.Windows.Forms.Button PreviousElementButton;
        private System.Windows.Forms.Button MoveToEndButton;
        private System.Windows.Forms.Button NextElementButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog SaveFileDialog;
        private System.Windows.Forms.Label ElementIndexAndCountLabel;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button InsertButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.ToolStripMenuItem executeTaskToolStripMenuItem;
    }
}

