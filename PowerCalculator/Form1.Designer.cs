namespace PowerCalculator
{
    partial class form_PowerCalculator
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
            lbl_Resistance = new Label();
            txt_Current = new TextBox();
            lbl_Current = new Label();
            txt_Voltage = new TextBox();
            lbl_Voltage = new Label();
            txt_Power = new TextBox();
            lbl_Power = new Label();
            lbl_Amp = new Label();
            lbl_Volt = new Label();
            lbl_Ohm = new Label();
            lbl_Watt = new Label();
            btn_Calculate = new Button();
            btn_Clear = new Button();
            txt_Resistance = new TextBox();
            SuspendLayout();
            // 
            // lbl_Resistance
            // 
            lbl_Resistance.AutoSize = true;
            lbl_Resistance.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Resistance.Location = new Point(71, 46);
            lbl_Resistance.Name = "lbl_Resistance";
            lbl_Resistance.Size = new Size(110, 21);
            lbl_Resistance.TabIndex = 0;
            lbl_Resistance.Text = "&Resistance (R):";
            // 
            // txt_Current
            // 
            txt_Current.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Current.Location = new Point(187, 87);
            txt_Current.Name = "txt_Current";
            txt_Current.RightToLeft = RightToLeft.Yes;
            txt_Current.Size = new Size(296, 29);
            txt_Current.TabIndex = 3;
            txt_Current.TextChanged += txt_Input_TextChanged;
            // 
            // lbl_Current
            // 
            lbl_Current.AutoSize = true;
            lbl_Current.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Current.Location = new Point(97, 90);
            lbl_Current.Name = "lbl_Current";
            lbl_Current.Size = new Size(84, 21);
            lbl_Current.TabIndex = 2;
            lbl_Current.Text = "&Current (I):";
            // 
            // txt_Voltage
            // 
            txt_Voltage.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Voltage.Location = new Point(187, 134);
            txt_Voltage.Name = "txt_Voltage";
            txt_Voltage.RightToLeft = RightToLeft.Yes;
            txt_Voltage.Size = new Size(296, 29);
            txt_Voltage.TabIndex = 5;
            txt_Voltage.TextChanged += txt_Input_TextChanged;
            // 
            // lbl_Voltage
            // 
            lbl_Voltage.AutoSize = true;
            lbl_Voltage.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Voltage.Location = new Point(92, 137);
            lbl_Voltage.Name = "lbl_Voltage";
            lbl_Voltage.Size = new Size(90, 21);
            lbl_Voltage.TabIndex = 4;
            lbl_Voltage.Text = "&Voltage (U):";
            // 
            // txt_Power
            // 
            txt_Power.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Power.Location = new Point(187, 177);
            txt_Power.Name = "txt_Power";
            txt_Power.RightToLeft = RightToLeft.Yes;
            txt_Power.Size = new Size(296, 29);
            txt_Power.TabIndex = 7;
            txt_Power.TextChanged += txt_Input_TextChanged;
            // 
            // lbl_Power
            // 
            lbl_Power.AutoSize = true;
            lbl_Power.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Power.Location = new Point(102, 180);
            lbl_Power.Name = "lbl_Power";
            lbl_Power.Size = new Size(79, 21);
            lbl_Power.TabIndex = 6;
            lbl_Power.Text = "&Power (P):";
            // 
            // lbl_Amp
            // 
            lbl_Amp.AutoSize = true;
            lbl_Amp.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Amp.Location = new Point(489, 87);
            lbl_Amp.Name = "lbl_Amp";
            lbl_Amp.Size = new Size(34, 21);
            lbl_Amp.TabIndex = 9;
            lbl_Amp.Text = " [A]";
            // 
            // lbl_Volt
            // 
            lbl_Volt.AutoSize = true;
            lbl_Volt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Volt.Location = new Point(489, 134);
            lbl_Volt.Name = "lbl_Volt";
            lbl_Volt.Size = new Size(34, 21);
            lbl_Volt.TabIndex = 10;
            lbl_Volt.Text = " [V]";
            // 
            // lbl_Ohm
            // 
            lbl_Ohm.AutoSize = true;
            lbl_Ohm.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Ohm.Location = new Point(489, 46);
            lbl_Ohm.Name = "lbl_Ohm";
            lbl_Ohm.Size = new Size(36, 21);
            lbl_Ohm.TabIndex = 11;
            lbl_Ohm.Text = " [Ω]";
            // 
            // lbl_Watt
            // 
            lbl_Watt.AutoSize = true;
            lbl_Watt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Watt.Location = new Point(489, 180);
            lbl_Watt.Name = "lbl_Watt";
            lbl_Watt.Size = new Size(39, 21);
            lbl_Watt.TabIndex = 12;
            lbl_Watt.Text = " [W]";
            // 
            // btn_Calculate
            // 
            btn_Calculate.Location = new Point(187, 222);
            btn_Calculate.Name = "btn_Calculate";
            btn_Calculate.Size = new Size(108, 37);
            btn_Calculate.TabIndex = 13;
            btn_Calculate.Text = "Calculate";
            btn_Calculate.UseVisualStyleBackColor = true;
            btn_Calculate.Click += btn_Calculate_Click;
            // 
            // btn_Clear
            // 
            btn_Clear.Location = new Point(301, 222);
            btn_Clear.Name = "btn_Clear";
            btn_Clear.Size = new Size(108, 37);
            btn_Clear.TabIndex = 14;
            btn_Clear.Text = "Clear";
            btn_Clear.UseVisualStyleBackColor = true;
            btn_Clear.Click += btn_Clear_Click;
            // 
            // txt_Resistance
            // 
            txt_Resistance.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Resistance.Location = new Point(187, 46);
            txt_Resistance.Name = "txt_Resistance";
            txt_Resistance.RightToLeft = RightToLeft.Yes;
            txt_Resistance.Size = new Size(296, 29);
            txt_Resistance.TabIndex = 15;
            txt_Resistance.TextChanged += txt_Input_TextChanged;
            // 
            // form_PowerCalculator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(618, 308);
            Controls.Add(txt_Resistance);
            Controls.Add(btn_Clear);
            Controls.Add(btn_Calculate);
            Controls.Add(lbl_Watt);
            Controls.Add(lbl_Ohm);
            Controls.Add(lbl_Volt);
            Controls.Add(lbl_Amp);
            Controls.Add(txt_Power);
            Controls.Add(lbl_Power);
            Controls.Add(txt_Voltage);
            Controls.Add(lbl_Voltage);
            Controls.Add(txt_Current);
            Controls.Add(lbl_Current);
            Controls.Add(lbl_Resistance);
            Name = "form_PowerCalculator";
            Text = "PowerCalculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_Resistance;
        private TextBox txt_Current;
        private Label lbl_Current;
        private TextBox txt_Voltage;
        private Label lbl_Voltage;
        private TextBox txt_Power;
        private Label lbl_Power;
        private Label lbl_Amp;
        private Label lbl_Volt;
        private Label lbl_Ohm;
        private Label lbl_Watt;
        private Button btn_Calculate;
        private Button btn_Clear;
        private TextBox txt_Resistance;
    }
}