﻿namespace WordGenerator.Controls.LookUpTableTab
{
    partial class LookupTableControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.newLUTButton = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.LUTSelector = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableDisplay = new System.Windows.Forms.DataGridView();
            this.xValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loadLUT = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.varUpdate = new System.Windows.Forms.Button();
            this.LUTSelectorListBox = new System.Windows.Forms.ListBox();
            this.renameButton = new System.Windows.Forms.Button();
            this.clearLUTButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tableDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // newLUTButton
            // 
            this.newLUTButton.Location = new System.Drawing.Point(101, 75);
            this.newLUTButton.Name = "newLUTButton";
            this.newLUTButton.Size = new System.Drawing.Size(145, 70);
            this.newLUTButton.TabIndex = 3;
            this.newLUTButton.Text = "Create New LUT";
            this.newLUTButton.UseVisualStyleBackColor = true;
            this.newLUTButton.Click += new System.EventHandler(this.newLUTButton_Click_1);
            this.newLUTButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.newLUTButton_Click);
            // 
            // LUTSelector
            // 
            this.LUTSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LUTSelector.FormattingEnabled = true;
            this.LUTSelector.Location = new System.Drawing.Point(610, 361);
            this.LUTSelector.Name = "LUTSelector";
            this.LUTSelector.Size = new System.Drawing.Size(145, 21);
            this.LUTSelector.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Select Lookup Table to Edit:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tableDisplay
            // 
            this.tableDisplay.AllowDrop = true;
            this.tableDisplay.AllowUserToResizeColumns = false;
            this.tableDisplay.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.tableDisplay.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tableDisplay.CausesValidation = false;
            this.tableDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableDisplay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.xValue,
            this.yValue});
            this.tableDisplay.Location = new System.Drawing.Point(376, 17);
            this.tableDisplay.MultiSelect = false;
            this.tableDisplay.Name = "tableDisplay";
            this.tableDisplay.RowHeadersVisible = false;
            this.tableDisplay.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.tableDisplay.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.tableDisplay.Size = new System.Drawing.Size(203, 878);
            this.tableDisplay.TabIndex = 6;
            this.tableDisplay.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableDisplay_CellContentClick_1);
            this.tableDisplay.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableDisplay_CellEndEdit);
            this.tableDisplay.EnabledChanged += new System.EventHandler(this.tableDisplay_EnabledChanged);
            // 
            // xValue
            // 
            this.xValue.HeaderText = "X Value";
            this.xValue.Name = "xValue";
            this.xValue.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.xValue.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // yValue
            // 
            this.yValue.HeaderText = "Y Value";
            this.yValue.Name = "yValue";
            this.yValue.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.yValue.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // loadLUT
            // 
            this.loadLUT.Location = new System.Drawing.Point(610, 110);
            this.loadLUT.Name = "loadLUT";
            this.loadLUT.Size = new System.Drawing.Size(145, 70);
            this.loadLUT.TabIndex = 7;
            this.loadLUT.Text = "Populate Using CSV";
            this.loadLUT.UseVisualStyleBackColor = true;
            this.loadLUT.Click += new System.EventHandler(this.loadLUT_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(732, 45);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 8;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(607, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Name of Lookup Table:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(291, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "Lookup Tables (Experimental)";
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(792, 215);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(145, 70);
            this.deleteButton.TabIndex = 11;
            this.deleteButton.Text = "Delete This LUT";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.AddExtension = false;
            this.openFileDialog1.Filter = "\"CSV Files\"|*.csv";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // varUpdate
            // 
            this.varUpdate.Location = new System.Drawing.Point(610, 215);
            this.varUpdate.Name = "varUpdate";
            this.varUpdate.Size = new System.Drawing.Size(145, 70);
            this.varUpdate.TabIndex = 12;
            this.varUpdate.Text = "Update Variables";
            this.varUpdate.UseVisualStyleBackColor = true;
            this.varUpdate.Click += new System.EventHandler(this.varUpdate_Click);
            // 
            // LUTSelectorListBox
            // 
            this.LUTSelectorListBox.FormattingEnabled = true;
            this.LUTSelectorListBox.Location = new System.Drawing.Point(101, 204);
            this.LUTSelectorListBox.Name = "LUTSelectorListBox";
            this.LUTSelectorListBox.Size = new System.Drawing.Size(145, 433);
            this.LUTSelectorListBox.TabIndex = 13;
            this.LUTSelectorListBox.SelectedIndexChanged += new System.EventHandler(this.LUTSelectorListBox_SelectedIndexChanged);
            // 
            // renameButton
            // 
            this.renameButton.Location = new System.Drawing.Point(838, 43);
            this.renameButton.Name = "renameButton";
            this.renameButton.Size = new System.Drawing.Size(68, 23);
            this.renameButton.TabIndex = 14;
            this.renameButton.Text = "Rename";
            this.renameButton.UseVisualStyleBackColor = true;
            this.renameButton.Click += new System.EventHandler(this.renameButton_Click);
            // 
            // clearLUTButton
            // 
            this.clearLUTButton.Location = new System.Drawing.Point(792, 110);
            this.clearLUTButton.Name = "clearLUTButton";
            this.clearLUTButton.Size = new System.Drawing.Size(145, 70);
            this.clearLUTButton.TabIndex = 15;
            this.clearLUTButton.Text = "Clear LUT";
            this.clearLUTButton.UseVisualStyleBackColor = true;
            this.clearLUTButton.Click += new System.EventHandler(this.clearLUTButton_Click);
            // 
            // LookupTableControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.clearLUTButton);
            this.Controls.Add(this.renameButton);
            this.Controls.Add(this.LUTSelectorListBox);
            this.Controls.Add(this.varUpdate);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.loadLUT);
            this.Controls.Add(this.tableDisplay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LUTSelector);
            this.Controls.Add(this.newLUTButton);
            this.Name = "LookupTableControl";
            this.Size = new System.Drawing.Size(1264, 918);
            ((System.ComponentModel.ISupportInitialize)(this.tableDisplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button newLUTButton;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ComboBox LUTSelector;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button loadLUT;
        public System.Windows.Forms.DataGridView tableDisplay;
        private System.Windows.Forms.DataGridViewTextBoxColumn xValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn yValue;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button varUpdate;
        private System.Windows.Forms.ListBox LUTSelectorListBox;
        private System.Windows.Forms.Button renameButton;
        private System.Windows.Forms.Button clearLUTButton;
    }
}
