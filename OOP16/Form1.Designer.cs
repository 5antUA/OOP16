namespace OOP16
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelList = new System.Windows.Forms.Label();
            this.capacityBox = new System.Windows.Forms.TextBox();
            this.valueBox = new System.Windows.Forms.TextBox();
            this.capButton = new System.Windows.Forms.Button();
            this.addElemButton = new System.Windows.Forms.Button();
            this.labelInfo1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelInfo2 = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.mulButton = new System.Windows.Forms.Button();
            this.divButton = new System.Windows.Forms.Button();
            this.skalarBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.skalarLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(192, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(619, 167);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // labelList
            // 
            this.labelList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.labelList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelList.Location = new System.Drawing.Point(484, 254);
            this.labelList.Name = "labelList";
            this.labelList.Size = new System.Drawing.Size(487, 140);
            this.labelList.TabIndex = 1;
            // 
            // capacityBox
            // 
            this.capacityBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.capacityBox.Location = new System.Drawing.Point(66, 274);
            this.capacityBox.Name = "capacityBox";
            this.capacityBox.Size = new System.Drawing.Size(138, 38);
            this.capacityBox.TabIndex = 2;
            // 
            // valueBox
            // 
            this.valueBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.valueBox.Location = new System.Drawing.Point(66, 384);
            this.valueBox.Name = "valueBox";
            this.valueBox.Size = new System.Drawing.Size(138, 38);
            this.valueBox.TabIndex = 3;
            // 
            // capButton
            // 
            this.capButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.capButton.Location = new System.Drawing.Point(272, 274);
            this.capButton.Name = "capButton";
            this.capButton.Size = new System.Drawing.Size(126, 38);
            this.capButton.TabIndex = 4;
            this.capButton.Text = "Виконати";
            this.capButton.UseVisualStyleBackColor = true;
            this.capButton.Click += new System.EventHandler(this.capButton_Click);
            // 
            // addElemButton
            // 
            this.addElemButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addElemButton.Location = new System.Drawing.Point(272, 384);
            this.addElemButton.Name = "addElemButton";
            this.addElemButton.Size = new System.Drawing.Size(126, 38);
            this.addElemButton.TabIndex = 5;
            this.addElemButton.Text = "Виконати";
            this.addElemButton.UseVisualStyleBackColor = true;
            this.addElemButton.Click += new System.EventHandler(this.addElemButton_Click);
            // 
            // labelInfo1
            // 
            this.labelInfo1.AutoSize = true;
            this.labelInfo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInfo1.Location = new System.Drawing.Point(567, 225);
            this.labelInfo1.Name = "labelInfo1";
            this.labelInfo1.Size = new System.Drawing.Size(225, 29);
            this.labelInfo1.TabIndex = 6;
            this.labelInfo1.Text = "Список елементів";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(62, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(336, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Задати кількість елементів в масиві";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(107, 341);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(236, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "Додати елемент в масив";
            // 
            // labelInfo2
            // 
            this.labelInfo2.AutoSize = true;
            this.labelInfo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInfo2.Location = new System.Drawing.Point(567, 428);
            this.labelInfo2.Name = "labelInfo2";
            this.labelInfo2.Size = new System.Drawing.Size(244, 29);
            this.labelInfo2.TabIndex = 10;
            this.labelInfo2.Text = "Результат операцій";
            // 
            // labelResult
            // 
            this.labelResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.labelResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelResult.Location = new System.Drawing.Point(484, 457);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(487, 140);
            this.labelResult.TabIndex = 9;
            // 
            // mulButton
            // 
            this.mulButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mulButton.Location = new System.Drawing.Point(162, 537);
            this.mulButton.Name = "mulButton";
            this.mulButton.Size = new System.Drawing.Size(126, 38);
            this.mulButton.TabIndex = 15;
            this.mulButton.Text = "*";
            this.mulButton.UseVisualStyleBackColor = true;
            this.mulButton.Click += new System.EventHandler(this.mulButton_Click);
            // 
            // divButton
            // 
            this.divButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.divButton.Location = new System.Drawing.Point(307, 537);
            this.divButton.Name = "divButton";
            this.divButton.Size = new System.Drawing.Size(126, 38);
            this.divButton.TabIndex = 16;
            this.divButton.Text = "/";
            this.divButton.UseVisualStyleBackColor = true;
            this.divButton.Click += new System.EventHandler(this.divButton_Click);
            // 
            // skalarBox
            // 
            this.skalarBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.skalarBox.Location = new System.Drawing.Point(46, 537);
            this.skalarBox.Name = "skalarBox";
            this.skalarBox.Size = new System.Drawing.Size(84, 38);
            this.skalarBox.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(192, 494);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(219, 24);
            this.label6.TabIndex = 13;
            this.label6.Text = "Операції над масивами";
            // 
            // skalarLabel
            // 
            this.skalarLabel.AutoSize = true;
            this.skalarLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.skalarLabel.Location = new System.Drawing.Point(52, 494);
            this.skalarLabel.Name = "skalarLabel";
            this.skalarLabel.Size = new System.Drawing.Size(73, 24);
            this.skalarLabel.TabIndex = 18;
            this.skalarLabel.Text = "Скаляр";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(995, 647);
            this.Controls.Add(this.skalarLabel);
            this.Controls.Add(this.skalarBox);
            this.Controls.Add(this.divButton);
            this.Controls.Add(this.mulButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labelInfo2);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelInfo1);
            this.Controls.Add(this.addElemButton);
            this.Controls.Add(this.capButton);
            this.Controls.Add(this.valueBox);
            this.Controls.Add(this.capacityBox);
            this.Controls.Add(this.labelList);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Lab 16";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelList;
        private System.Windows.Forms.TextBox capacityBox;
        private System.Windows.Forms.TextBox valueBox;
        private System.Windows.Forms.Button capButton;
        private System.Windows.Forms.Button addElemButton;
        private System.Windows.Forms.Label labelInfo1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelInfo2;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Button mulButton;
        private System.Windows.Forms.Button divButton;
        private System.Windows.Forms.TextBox skalarBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label skalarLabel;
    }
}

