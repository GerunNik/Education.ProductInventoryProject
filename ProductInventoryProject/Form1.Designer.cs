namespace ProductInventoryProject
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// Clean up any resources being used.
        /// Clean up any resources being used.
        /// Clean up any resources being used.
        /// Clean up any resources being used.        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.totalValue_txt = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.itemValue_txt = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.item_txt = new System.Windows.Forms.TextBox();
            this.newPrice_txt = new System.Windows.Forms.TextBox();
            this.newQuantity_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Get total Value";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(43, 68);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // totalValue_txt
            // 
            this.totalValue_txt.Location = new System.Drawing.Point(43, 42);
            this.totalValue_txt.Name = "totalValue_txt";
            this.totalValue_txt.ReadOnly = true;
            this.totalValue_txt.Size = new System.Drawing.Size(100, 20);
            this.totalValue_txt.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(43, 214);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Create new Product";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // itemValue_txt
            // 
            this.itemValue_txt.Location = new System.Drawing.Point(443, 102);
            this.itemValue_txt.Name = "itemValue_txt";
            this.itemValue_txt.ReadOnly = true;
            this.itemValue_txt.Size = new System.Drawing.Size(100, 20);
            this.itemValue_txt.TabIndex = 6;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(443, 128);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Calculate";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(440, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Get total Value of Product";
            // 
            // item_txt
            // 
            this.item_txt.Location = new System.Drawing.Point(544, 42);
            this.item_txt.Name = "item_txt";
            this.item_txt.Size = new System.Drawing.Size(100, 20);
            this.item_txt.TabIndex = 7;
            // 
            // newPrice_txt
            // 
            this.newPrice_txt.Location = new System.Drawing.Point(652, 102);
            this.newPrice_txt.Name = "newPrice_txt";
            this.newPrice_txt.Size = new System.Drawing.Size(100, 20);
            this.newPrice_txt.TabIndex = 8;
            // 
            // newQuantity_txt
            // 
            this.newQuantity_txt.Location = new System.Drawing.Point(652, 147);
            this.newQuantity_txt.Name = "newQuantity_txt";
            this.newQuantity_txt.Size = new System.Drawing.Size(100, 20);
            this.newQuantity_txt.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(541, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Product Name";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(652, 173);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 11;
            this.button4.Text = "Set";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(649, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Set new Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(649, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Set new Quantity";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 276);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.newQuantity_txt);
            this.Controls.Add(this.newPrice_txt);
            this.Controls.Add(this.item_txt);
            this.Controls.Add(this.itemValue_txt);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.totalValue_txt);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox totalValue_txt;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox itemValue_txt;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox item_txt;
        private System.Windows.Forms.TextBox newPrice_txt;
        private System.Windows.Forms.TextBox newQuantity_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

