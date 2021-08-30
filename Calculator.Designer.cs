
namespace LogicalFunctionsCalculator
{
    partial class Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Input = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.XORButton = new System.Windows.Forms.Button();
            this.NOTButton = new System.Windows.Forms.Button();
            this.FalseButton = new System.Windows.Forms.Button();
            this.TrueButton = new System.Windows.Forms.Button();
            this.EQVButton = new System.Windows.Forms.Button();
            this.IMPButton = new System.Windows.Forms.Button();
            this.ORButton = new System.Windows.Forms.Button();
            this.ANDButton = new System.Windows.Forms.Button();
            this.CEButton = new System.Windows.Forms.Button();
            this.CButton = new System.Windows.Forms.Button();
            this.PARButton = new System.Windows.Forms.Button();
            this.SCSButton = new System.Windows.Forms.Button();
            this.EquallyButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Input);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(434, 124);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(434, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 73);
            this.label1.TabIndex = 1;
            // 
            // Input
            // 
            this.Input.Dock = System.Windows.Forms.DockStyle.Top;
            this.Input.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Input.Location = new System.Drawing.Point(0, 0);
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(434, 40);
            this.Input.TabIndex = 0;
            this.Input.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.XORButton, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.NOTButton, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.FalseButton, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.TrueButton, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.EQVButton, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.IMPButton, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.ORButton, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.ANDButton, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.CEButton, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.CButton, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.PARButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.SCSButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.EquallyButton, 3, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 124);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(434, 400);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // XORButton
            // 
            this.XORButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.XORButton.Location = new System.Drawing.Point(327, 203);
            this.XORButton.Name = "XORButton";
            this.XORButton.Size = new System.Drawing.Size(104, 94);
            this.XORButton.TabIndex = 12;
            this.XORButton.Text = "xor";
            this.XORButton.UseVisualStyleBackColor = true;
            this.XORButton.Click += new System.EventHandler(this.XORButton_Click);
            // 
            // NOTButton
            // 
            this.NOTButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NOTButton.Location = new System.Drawing.Point(219, 203);
            this.NOTButton.Name = "NOTButton";
            this.NOTButton.Size = new System.Drawing.Size(102, 94);
            this.NOTButton.TabIndex = 11;
            this.NOTButton.Text = "not";
            this.NOTButton.UseVisualStyleBackColor = true;
            this.NOTButton.Click += new System.EventHandler(this.NOTButton_Click);
            // 
            // FalseButton
            // 
            this.FalseButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FalseButton.Location = new System.Drawing.Point(111, 203);
            this.FalseButton.Name = "FalseButton";
            this.FalseButton.Size = new System.Drawing.Size(102, 94);
            this.FalseButton.TabIndex = 10;
            this.FalseButton.Text = "false";
            this.FalseButton.UseVisualStyleBackColor = true;
            this.FalseButton.Click += new System.EventHandler(this.FalseButton_Click);
            // 
            // TrueButton
            // 
            this.TrueButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TrueButton.Location = new System.Drawing.Point(3, 203);
            this.TrueButton.Name = "TrueButton";
            this.TrueButton.Size = new System.Drawing.Size(102, 94);
            this.TrueButton.TabIndex = 9;
            this.TrueButton.Text = "true";
            this.TrueButton.UseVisualStyleBackColor = true;
            this.TrueButton.Click += new System.EventHandler(this.TrueButton_Click);
            // 
            // EQVButton
            // 
            this.EQVButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EQVButton.Location = new System.Drawing.Point(327, 103);
            this.EQVButton.Name = "EQVButton";
            this.EQVButton.Size = new System.Drawing.Size(104, 94);
            this.EQVButton.TabIndex = 8;
            this.EQVButton.Text = "eqv";
            this.EQVButton.UseVisualStyleBackColor = true;
            this.EQVButton.Click += new System.EventHandler(this.EQVButton_Click);
            // 
            // IMPButton
            // 
            this.IMPButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IMPButton.Location = new System.Drawing.Point(219, 103);
            this.IMPButton.Name = "IMPButton";
            this.IMPButton.Size = new System.Drawing.Size(102, 94);
            this.IMPButton.TabIndex = 7;
            this.IMPButton.Text = "imp";
            this.IMPButton.UseVisualStyleBackColor = true;
            this.IMPButton.Click += new System.EventHandler(this.IMPButton_Click);
            // 
            // ORButton
            // 
            this.ORButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ORButton.Location = new System.Drawing.Point(111, 103);
            this.ORButton.Name = "ORButton";
            this.ORButton.Size = new System.Drawing.Size(102, 94);
            this.ORButton.TabIndex = 6;
            this.ORButton.Text = "or";
            this.ORButton.UseVisualStyleBackColor = true;
            this.ORButton.Click += new System.EventHandler(this.ORButton_Click);
            // 
            // ANDButton
            // 
            this.ANDButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ANDButton.Location = new System.Drawing.Point(3, 103);
            this.ANDButton.Name = "ANDButton";
            this.ANDButton.Size = new System.Drawing.Size(102, 94);
            this.ANDButton.TabIndex = 5;
            this.ANDButton.Text = "and";
            this.ANDButton.UseVisualStyleBackColor = true;
            this.ANDButton.Click += new System.EventHandler(this.ANDButton_Click);
            // 
            // CEButton
            // 
            this.CEButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CEButton.Location = new System.Drawing.Point(327, 3);
            this.CEButton.Name = "CEButton";
            this.CEButton.Size = new System.Drawing.Size(104, 94);
            this.CEButton.TabIndex = 4;
            this.CEButton.Text = "CE";
            this.CEButton.UseVisualStyleBackColor = true;
            this.CEButton.Click += new System.EventHandler(this.CEButton_Click);
            // 
            // CButton
            // 
            this.CButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CButton.Location = new System.Drawing.Point(219, 3);
            this.CButton.Name = "CButton";
            this.CButton.Size = new System.Drawing.Size(102, 94);
            this.CButton.TabIndex = 3;
            this.CButton.Text = "C";
            this.CButton.UseVisualStyleBackColor = true;
            this.CButton.Click += new System.EventHandler(this.CButton_Click);
            // 
            // PARButton
            // 
            this.PARButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PARButton.Location = new System.Drawing.Point(111, 3);
            this.PARButton.Name = "PARButton";
            this.PARButton.Size = new System.Drawing.Size(102, 94);
            this.PARButton.TabIndex = 2;
            this.PARButton.Text = "par";
            this.PARButton.UseVisualStyleBackColor = true;
            this.PARButton.Click += new System.EventHandler(this.PARButton_Click);
            // 
            // SCSButton
            // 
            this.SCSButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SCSButton.Location = new System.Drawing.Point(3, 3);
            this.SCSButton.Name = "SCSButton";
            this.SCSButton.Size = new System.Drawing.Size(102, 94);
            this.SCSButton.TabIndex = 1;
            this.SCSButton.Text = "scs";
            this.SCSButton.UseVisualStyleBackColor = true;
            this.SCSButton.Click += new System.EventHandler(this.SCSButton_Click);
            // 
            // EquallyButton
            // 
            this.EquallyButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EquallyButton.Location = new System.Drawing.Point(327, 303);
            this.EquallyButton.Name = "EquallyButton";
            this.EquallyButton.Size = new System.Drawing.Size(104, 94);
            this.EquallyButton.TabIndex = 13;
            this.EquallyButton.Text = "=";
            this.EquallyButton.UseVisualStyleBackColor = true;
            this.EquallyButton.Click += new System.EventHandler(this.EquallyButton_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 524);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(250, 400);
            this.Name = "Calculator";
            this.Text = "Logical calculator";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox Input;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button XORButton;
        private System.Windows.Forms.Button NOTButton;
        private System.Windows.Forms.Button FalseButton;
        private System.Windows.Forms.Button TrueButton;
        private System.Windows.Forms.Button EQVButton;
        private System.Windows.Forms.Button IMPButton;
        private System.Windows.Forms.Button ORButton;
        private System.Windows.Forms.Button ANDButton;
        private System.Windows.Forms.Button CEButton;
        private System.Windows.Forms.Button CButton;
        private System.Windows.Forms.Button PARButton;
        private System.Windows.Forms.Button SCSButton;
        private System.Windows.Forms.Button EquallyButton;
    }
}

