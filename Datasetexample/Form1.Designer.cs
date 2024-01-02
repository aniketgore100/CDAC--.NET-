namespace Datasetexample
{
    partial class Form1
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
            button1=new Button();
            dataGridView1=new DataGridView();
            button2=new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location=new Point(565, 577);
            button1.Name="button1";
            button1.Size=new Size(112, 34);
            button1.TabIndex=0;
            button1.Text="button1";
            button1.UseVisualStyleBackColor=true;
            button1.Click+=button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode=DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location=new Point(360, 44);
            dataGridView1.Name="dataGridView1";
            dataGridView1.RowHeadersWidth=62;
            dataGridView1.RowTemplate.Height=33;
            dataGridView1.Size=new Size(591, 402);
            dataGridView1.TabIndex=1;
            // 
            // button2
            // 
            button2.Location=new Point(287, 553);
            button2.Name="button2";
            button2.Size=new Size(112, 34);
            button2.TabIndex=2;
            button2.Text="button2";
            button2.UseVisualStyleBackColor=true;
            button2.Click+=button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions=new SizeF(10F, 25F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(1253, 720);
            Controls.Add(button2);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Name="Form1";
            Text="Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private DataGridView dataGridView1;
        private Button button2;
    }
}