namespace Cold_Storage_System
{
    partial class TrangChu
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
            button1 = new Button();
            label1 = new Label();
            groupBox1 = new GroupBox();
            button8 = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.LightYellow;
            button1.Location = new Point(26, 60);
            button1.Name = "button1";
            button1.Size = new Size(312, 50);
            button1.TabIndex = 0;
            button1.Text = "Quản lý đơn đặt hàng";
            button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.LightBlue;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Segoe UI", 26.1428585F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(322, 7);
            label1.Name = "label1";
            label1.Size = new Size(393, 84);
            label1.TabIndex = 1;
            label1.Text = "TRANG CHỦ";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.LightBlue;
            groupBox1.Controls.Add(button8);
            groupBox1.Controls.Add(button6);
            groupBox1.Controls.Add(button5);
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Font = new Font("Segoe UI", 11.1428576F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(71, 125);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(822, 330);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Chọn chức năng: ";
            // 
            // button8
            // 
            button8.BackColor = Color.Pink;
            button8.Location = new Point(251, 264);
            button8.Name = "button8";
            button8.Size = new Size(312, 50);
            button8.TabIndex = 7;
            button8.Text = "Thoát ứng dụng";
            button8.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.BackColor = Color.LightYellow;
            button6.Location = new Point(482, 126);
            button6.Name = "button6";
            button6.Size = new Size(312, 50);
            button6.TabIndex = 5;
            button6.Text = "Quản lý hàng hóa";
            button6.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = Color.LightYellow;
            button5.Location = new Point(482, 60);
            button5.Name = "button5";
            button5.Size = new Size(312, 50);
            button5.TabIndex = 4;
            button5.Text = "Quản lý kiểm hàng";
            button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.LightYellow;
            button4.Location = new Point(482, 195);
            button4.Name = "button4";
            button4.Size = new Size(312, 50);
            button4.TabIndex = 3;
            button4.Text = "Quản lý sản xuất";
            button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.LightYellow;
            button3.Location = new Point(26, 195);
            button3.Name = "button3";
            button3.Size = new Size(312, 50);
            button3.TabIndex = 2;
            button3.Text = "Quản lý nhập hàng";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.LightYellow;
            button2.Location = new Point(26, 126);
            button2.Name = "button2";
            button2.Size = new Size(312, 50);
            button2.TabIndex = 1;
            button2.Text = "Quản lý xuất hàng";
            button2.UseVisualStyleBackColor = false;
            // 
            // TrangChu
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            ClientSize = new Size(1035, 502);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "TrangChu";
            Text = "Trang chủ";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private GroupBox groupBox1;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button8;
    }
}
